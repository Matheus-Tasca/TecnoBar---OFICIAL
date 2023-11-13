using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESKTOP2019
{
    public partial class CDPROD : Form
    {
        MySqlConnection conection;
        DataSet dsProd;

        int modo = 1;
        bool ativo;

        public void limpar()
        {
            campoCategoria.SelectedIndex = -1;
            campoCod.Clear();
            campoNome.Clear();
            campoCusto.Clear();
            campoQTDInicio.Clear();
            campoQTDMinima.Clear();
            campoVenda.Clear();
        }

        public void habilitar()
        {
            try
            {
                switch (modo)
                {
                    case 0:
                        btnNovo.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnSalvar.Enabled = true;
                        btnCancelar.Enabled = true;
                        gridProd.Enabled = true;
                        break;
                    case 1: //salvar
                        btnNovo.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnCancelar.Enabled = true;
                        btnSalvar.Enabled = true;
                        gridProd.Enabled = false;
                        campoNome.Focus();
                        break;
                    case 2: //alterar
                        gridProd.Enabled = true;
                        btnNovo.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnCancelar.Enabled = true;
                        btnSalvar.Enabled = true;
                        gridProd.Enabled = true;
                        break;
                }
            }
            catch
            {
                MessageBox.Show("O valor da variável modo difere dentre 0 e 2", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Busca()
        {
            String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            string query = "SELECT * FROM produto";

            using (conection = new MySqlConnection(conString))
            {
                conection.Open();

                using (MySqlCommand command = new MySqlCommand(query, conection))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridProd.AutoGenerateColumns = true;

                    gridProd.DataSource = dataTable;

                    foreach (DataGridViewColumn column in gridProd.Columns)
                    {
                        if(column.DataPropertyName != "nomeProd" && column.DataPropertyName != "nomeCategoria" && column.DataPropertyName != "ativo")
                        {
                            column.Visible = false;
                        }
                    }

                    gridProd.Columns[1].HeaderText = "Nome";
                    gridProd.Columns[1].Width = 160;
                    gridProd.Columns[8].HeaderText = "Categoria";
                    gridProd.Columns[8].Width = 160;
                    gridProd.Columns[7].HeaderText = "Status";
                    gridProd.Columns[7].Width = 110;

                    
                }
            }
        }

        public CDPROD()
        {
            InitializeComponent();
            Busca();
            modo = 0;
            habilitar();
            CarregaDadosCombo();
            campoCategoria.SelectedIndex = -1;
            gridProd.RowHeadersWidth = 20;
        }

        private void campoQTDInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void campoQTDMinima_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void campoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DoubleNumber(e);
        }

        private void campoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DoubleNumber(e);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
            modo = 1;
            habilitar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
            modo = 0;
            habilitar();
            campoCategoria.SelectedIndex = -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
                int linhasAfetadas = 0;
                try
                {
                    if (cbAtivo.Checked == true)
                    {
                        ativo = true;
                    }
                    else
                    {
                        ativo = false;
                    }
                    if ((campoCategoria.SelectedIndex == -1) || (campoVenda.Text == "") || (campoNome.Text == "") || (campoCusto.Text == "") || (campoQTDInicio.Text == "") || (campoQTDMinima.Text == ""))
                    {
                        throw new CampoVazioException("Todos os campos devem ser preenchidos");
                    }
                    else
                    {
                        string qryInsereProd = "INSERT into produto (nomeProd,  nomeCategoria, qtdMin, qtdEstoque, valorEntrada, valorVenda, ativo)"
                            + "VALUES (@nome, @nomeCategoria, @qtdMin, @qtdEst, @valorEntrada, @valorVenda, @ativo)";
                        String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; //pega a localização que foi explicada (endereco)
                        using (conection = new MySqlConnection(conString))//Criar conexão com o banco (manda um whats pro banco falando que ta indo) 
                        {
                            conection.Open(); //abre

                            MySqlCommand comando = new MySqlCommand(qryInsereProd, conection); //da o comando
                            comando.Parameters.AddWithValue("@nome", campoNome.Text);
                            comando.Parameters.AddWithValue("@nomeCategoria", campoCategoria.SelectedValue); // SELECTEDVALEU PEGA O Valeu atribuido lá embaixo ao c
                            comando.Parameters.AddWithValue("@qtdMin", campoQTDMinima.Text);
                            comando.Parameters.AddWithValue("@qtdEst", campoQTDInicio.Text);
                            comando.Parameters.AddWithValue("@valorEntrada", campoCusto.Text);
                            comando.Parameters.AddWithValue("@valorVenda", campoVenda.Text);
                            comando.Parameters.AddWithValue("@ativo", ativo);

                            linhasAfetadas = comando.ExecuteNonQuery();
                            conection.Close();

                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("Produto inserido com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Busca();
                            }
                            else
                            {
                                MessageBox.Show("Falha ao inserir o produto.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    modo = 0;
                    habilitar();
                    Busca();
                }
                catch (CampoVazioException cv)
                {
                    MessageBox.Show($"{cv.Message}");
                }
            }
        

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (gridProd.SelectedRows.Count > 0)
            {
                try
                {
                    {
                        string conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                        using (MySqlConnection connection = new MySqlConnection(conString))
                        {
                            connection.Open();

                            string query = "UPDATE produto SET nomeProd = @nome, valorEntrada = @valorEntrada, valorVenda = @valorVenda, " +
                                           "qtdMin = @qtdMin, nomeCategoria = @nomeCategoria, qtdEstoque = @qtdEstoque, ativo = @ativo " +
                                           "WHERE codProd = @codProd";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@codProd", campoCod.Text);
                                command.Parameters.AddWithValue("@nome", campoNome.Text);
                                command.Parameters.AddWithValue("@valorEntrada", campoCusto.Text);
                                command.Parameters.AddWithValue("@valorVenda", campoVenda.Text);
                                command.Parameters.AddWithValue("@qtdMin", campoQTDMinima.Text);
                                command.Parameters.AddWithValue("@nomeCategoria", campoCategoria.SelectedValue);
                                command.Parameters.AddWithValue("@qtdEstoque", campoQTDInicio.Text);
                                command.Parameters.AddWithValue("@ativo", cbAtivo.Checked ? 1 : 0);

                                int linhasAfetadas = command.ExecuteNonQuery();

                                if (linhasAfetadas > 0)
                                {
                                    MessageBox.Show("Produto atualizado com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Busca();
                                    return; // paraR a função 
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao atualizar o produto.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao alterar produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto (clicando na coluna mais a esquerda da tabela) para alterar", "Produto não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void gridProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gridProd.SelectedRows.Count > 0)
            {
                btnSalvar.Enabled = false;
                btnNovo.Enabled = false;

                int rowIndex = gridProd.SelectedRows[0].Index; //selciona o index

                object selectedCellValue = gridProd.Rows[rowIndex].Cells["codProd"].Value; //tu pega a coluna 

                if (selectedCellValue != null)
                {
                    string selected = selectedCellValue.ToString();
                    string conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                    using (MySqlConnection connection = new MySqlConnection(conString))
                    {
                        connection.Open();

                        string query = "SELECT * FROM produto WHERE codProd = @codigo";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@codigo", selected);

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {

                                if (reader.Read())
                                {
                                    campoCod.Text = reader["codProd"].ToString();
                                    campoNome.Text = reader["nomeProd"].ToString();
                                    campoCusto.Text = reader["valorEntrada"].ToString();
                                    campoVenda.Text = reader["valorVenda"].ToString();
                                    campoQTDMinima.Text = reader["qtdMin"].ToString();
                                    campoCategoria.Text = reader["nomeCategoria"].ToString();
                                    campoQTDInicio.Text = reader["qtdEstoque"].ToString();
                                    int ativoValue = Convert.ToInt32(reader["ativo"]);
                                    if (ativoValue == 1)
                                    {
                                        cbAtivo.Checked = true;
                                    }
                                    else
                                    {
                                        cbAtivo.Checked = false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Selecione uma linha que não esteja vazia", "Linha Vazia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Célula selecionada está vazia.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnNovaCate_Click(object sender, EventArgs e)
        {
            AddCategoria novaCat = new AddCategoria();
            novaCat.Show();
        }

        private void CarregaDadosCombo()
        {
            try
            {
                string conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                using (MySqlConnection connection = new MySqlConnection(conString))
                {
                    connection.Open();

                    string query = "SELECT nomeCategoria FROM categoria";
                    using (MySqlCommand comando = new MySqlCommand(query, connection))
                    {
                        comando.CommandText = query; //executa a query

                        MySqlDataAdapter adapter = new MySqlDataAdapter(comando); //  trás para o seu datatable ou dataset
                        DataTable dataTable = new DataTable(); //criando uma tabela
                        adapter.Fill(dataTable); //preenche os dados que recebeu do comando sql 

                        campoCategoria.DisplayMember = "nomeCategoria";
                        campoCategoria.ValueMember = "nomeCategoria";
                        campoCategoria.DataSource = dataTable;

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void campoCategoria_SelectedIndexChanged(object sender, EventArgs e) // Aqui mostra no combo o que selecionou 
        {
            if (campoCategoria.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)campoCategoria.SelectedItem;
                string nomeSelecionado = selectedRow["nomeCategoria"].ToString();
            }
        }

        private void Filtrar()
        {
            if (gridProd.DataSource is DataTable dt) {
                ((DataTable)gridProd.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", "nomeProd", txtBusca.Text);
                gridProd.DataSource = dt;
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        /* private void campoCusto_TextChanged(object sender, EventArgs e)
         {
             setTamanhoBox(campoCusto);
         }

         private void campoVenda_TextChanged(object sender, EventArgs e)
         {
             setTamanhoBox(campoVenda);
         }*/
    }
}