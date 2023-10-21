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

        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Global.caminhoFotos;
        string destinoCompleto = "";
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
                        listProd.Enabled = true;
                        listProd.SelectedIndex = -1;
                        break;
                    case 1: //salvar
                        btnNovo.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnCancelar.Enabled = true;
                        btnSalvar.Enabled = true;
                        listProd.Enabled = false;
                        campoNome.Focus();
                        break;
                    case 2: //alterar
                        listProd.Enabled = true;
                        btnNovo.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnCancelar.Enabled = true;
                        btnSalvar.Enabled = true;
                        listProd.Enabled = true;
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
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string nome = reader["nomeProd"].ToString();
                        string cod = reader["codProd"].ToString();
                        //string qtd = reader["qtdEstoque"].ToString();
                        //string atv = reader["ativo"].ToString();
                        listProd.Items.Add($"{cod} - {nome}");
                    }

                    reader.Close();
                }
            }
        }

        public CDPROD()
        {
            InitializeComponent();
            Busca();
            modo = 0;
            habilitar();
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
            if (listProd.SelectedIndex != -1)
            {
                try
                {
                    {
                        string conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                        using (MySqlConnection connection = new MySqlConnection(conString))
                        {
                            connection.Open();

                            string query = "UPDATE produto SET nomeProd = @nome, valorEntrada = @valorEntrada, valorVenda = @valorVenda, " +
                                           "qtdMin = @qtdMin, codCategoria = @codCategoria, qtdEstoque = @qtdEstoque, ativo = @ativo " +
                                           "WHERE codProd = @codProd";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@codProd", campoCod.Text);
                                command.Parameters.AddWithValue("@nome", campoNome.Text);
                                command.Parameters.AddWithValue("@valorEntrada", campoCusto.Text);
                                command.Parameters.AddWithValue("@valorVenda", campoVenda.Text);
                                command.Parameters.AddWithValue("@qtdMin", campoQTDMinima.Text);
                                command.Parameters.AddWithValue("@codCategoria", campoCategoria.SelectedIndex);
                                command.Parameters.AddWithValue("@qtdEstoque", campoQTDInicio.Text);
                                command.Parameters.AddWithValue("@ativo", cbAtivo.Checked ? 1 : 0);

                                int linhasAfetadas = command.ExecuteNonQuery();

                                if (linhasAfetadas > 0)
                                {
                                    MessageBox.Show("Produto atualizado com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    listProd.Items.Clear();
                                    Busca();
                                    return; // para a função 
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
            if (listProd.SelectedIndex == -1)
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
                        string qryInsereProd = "INSERT into produto (nomeProd,  codCategoria, qtdMin, qtdEstoque, valorEntrada, valorVenda, ativo)"
                            + "VALUES (@nome, @codcategoria, @qtdMin, @qtdEst, @valorEntrada, @valorVenda, @ativo)";
                        String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; //pega a localização que foi explicada (endereco)
                        using (conection = new MySqlConnection(conString))//Criar conexão com o banco (manda um whats pro banco falando que ta indo) 
                        {
                            conection.Open(); //abre

                            MySqlCommand comando = new MySqlCommand(qryInsereProd, conection); //da o comando
                            comando.Parameters.AddWithValue("@nome", campoNome.Text);
                            comando.Parameters.AddWithValue("@codcategoria", campoCategoria.SelectedIndex);
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
                                listProd.Items.Clear();
                                Busca();
                            }
                            else
                            {
                                MessageBox.Show("Falha ao inserir o produto.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (CampoVazioException cv)
                {
                    MessageBox.Show($"{cv.Message}");
                }
            }
        }

        private void campoCod_TextChanged(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT MAX(codProd) FROM produto";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        int ultimoCodigo = Convert.ToInt32(result);
                        int proximoCodigo = ultimoCodigo + 1;
                    }
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            modo = 2;
            habilitar();

            //fazer update


        }

        private void listProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProd.SelectedIndex != -1)
            {
                // Obtém o item selecionado
                string selected = listProd.SelectedItem.ToString();
                string conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                // Conexão com o banco de dados (substitua a string de conexão conforme necessário)
                using (MySqlConnection connection = new MySqlConnection(conString))
                {
                    connection.Open();

                    // Consulta SQL para selecionar os dados com base no código
                    string query = "SELECT * FROM produto WHERE codProd = @codigo";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Adiciona o parâmetro da consulta SQL
                        command.Parameters.AddWithValue("@codigo", selected);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Verifica se há linhas retornadas
                            if (reader.Read())
                            {
                                campoCod.Text = reader["codProd"].ToString();
                                campoNome.Text = reader["nomeProd"].ToString();
                                campoCusto.Text = reader["valorEntrada"].ToString();
                                campoVenda.Text = reader["valorVenda"].ToString();
                                campoQTDMinima.Text = reader["qtdMin"].ToString();
                                campoCategoria.Text = reader["codCategoria"].ToString();
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
                                MessageBox.Show("Não foi possível selecionar o produto");
                            }
                        }
                    }
                }
            }
        }

        private void btnNovaCate_Click(object sender, EventArgs e)
        {
            AddCategoria novaCat = new AddCategoria();
            novaCat.Show();
        }

        private void campoCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conStrin = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            string qryNomeCat = "SELECT * FROM categoria";

            using (MySqlConnection con = new MySqlConnection(conStrin))
            {
                con.Open();

                campoCategoria.Items.Clear();

                using (MySqlCommand command = new MySqlCommand(qryNomeCat, con))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string nomeCategoria = reader["nomeCategoria"].ToString();
                        campoCategoria.Items.Add(nomeCategoria);
                    }

                    reader.Close();
                }
            }
        }

    }
}

