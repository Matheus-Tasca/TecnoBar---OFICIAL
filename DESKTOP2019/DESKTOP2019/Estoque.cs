using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESKTOP2019
{
    public partial class Estoque : Form
    {
        private MySqlConnection conection;
        private DataTable dataTable;

        public void Busca()
        {
            String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            string query = "SELECT codProd, nomeProd, qtdEstoque FROM produto where ativo = 1"; // Substitua pelo seu SQL

            using (conection = new MySqlConnection(conString))
            {
                conection.Open();

                using (MySqlCommand command = new MySqlCommand(query, conection))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTab = new DataTable();
                    adapter.Fill(dataTab);

                    gridEstoque.DataSource = dataTab;  //relaciona o datasoucer do grid (que é o aramazenamento de dados) com o datatable que foi preenchido 
                }
            }
        }

        public Estoque()
        {
            InitializeComponent();
            Busca();
            gridEstoque.Columns[0].HeaderText = "Codigo";
            gridEstoque.Columns[1].HeaderText = "Nome";
            gridEstoque.Columns[2].HeaderText = "Estoque Atual";

            gridEstoque.Columns[0].Width = 150;
            gridEstoque.Columns[1].Width = 200;
            gridEstoque.Columns[2].Width = 200;

            gridEstoque.RowHeadersWidth = 20;

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(campoQTDajust.Value);

            try
            {
                if (gridEstoque.SelectedRows.Count > 0  )
                {
                    string codigo = gridEstoque.SelectedRows[0].Cells[0].Value.ToString();
                    if (MessageBox.Show($"Tem certeza que deseja retira {valor} itens do estoque desse produto", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        String qryExc = ($"UPDATE produto SET qtdEstoque = qtdEstoque - {valor} where codProd = @codigo");
                        String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; //endereco
                        using (conection = new MySqlConnection(conString))
                        {
                            conection.Open();
                            MySqlCommand cmd = new MySqlCommand(qryExc, conection);
                            cmd.Parameters.AddWithValue("@codigo", codigo);
                            int linhafetadas = cmd.ExecuteNonQuery();
                            conection.Close();

                            // MessageBox.Show("Consulta SQL: " + qryExc);

                            if (linhafetadas > 0)
                            {
                                MessageBox.Show("Esoque retirado com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Busca();
                            }
                            else
                            {
                                MessageBox.Show("Falha ao retirar o estoque", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Clique em um produto para selecioná-lo", "Produto não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Não foi possível se comunicar com o Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Clique em um produto para selecioná-lo", "Produto não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            campoQTDajust.Value = 0;
            campoCod.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(campoQTDajust.Value);

            try
            {
                if (gridEstoque.SelectedRows.Count > 0)
                {
                    string codigo = gridEstoque.SelectedRows[0].Cells[0].Value.ToString(); //pega a primeira linha selecionada e sua primeira celula. Armazena o valor e joga para string
                    if (MessageBox.Show($"Tem certeza que deseja adicionar {valor} itens ao estoque desse produto", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        String qryInsert = ($"UPDATE produto SET qtdEstoque = qtdEstoque + {valor} WHERE codProd = @codigo");
                        String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; //endereco
                        using (conection = new MySqlConnection(conString))
                        {
                            conection.Open();
                            MySqlCommand cmd = new MySqlCommand(qryInsert, conection);
                            cmd.Parameters.AddWithValue("@codigo", codigo);
                            int linhafetadas = cmd.ExecuteNonQuery();
                            conection.Close();

                            if (linhafetadas > 0)
                            {
                                MessageBox.Show("Estoque inserido com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Busca();
                            }
                            else
                            {
                                MessageBox.Show("Falha ao inserir o estoque", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Clique em um produto para selecioná-lo", "Produto não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Não foi possível se comunicar com o Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Clique em um produto para selecioná-lo", "Produto não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            campoQTDajust.Value = 0;
            campoCod.Clear();
        }


        private void btnTotal_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(campoQTDajust.Value);

            try
            {
                if (gridEstoque.SelectedRows.Count > 0)
                {
                    string codigo = gridEstoque.SelectedRows[0].Cells[0].Value.ToString();
                    if (MessageBox.Show($"Tem certeza que deseja definir {valor} como novo total do estoque", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        String qryInsert = ($"UPDATE produto SET qtdEstoque = {valor} where codProd = @codigo");
                        String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; //endereco
                        using (conection = new MySqlConnection(conString))
                        {

                            conection.Open();
                            MySqlCommand cmd = new MySqlCommand(qryInsert, conection);
                            cmd.Parameters.AddWithValue("@codigo", codigo);
                            int linhafetadas = cmd.ExecuteNonQuery();
                            conection.Close();

                            if (linhafetadas > 0)
                            {
                                MessageBox.Show("Esoque ajustado com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Busca();
                            }
                            else
                            {
                                MessageBox.Show("Falha ao ajustar o estoque", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Clique em um produto para selecioná-lo", "Produto não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                campoQTDajust.Value = 0;
                campoCod.Clear();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Não foi possível se comunicar com o Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Clique em um produto para selecioná-lo", "Produto não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void PressionouCod(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrEmpty(campoCod.Text))
                {
                    Busca();
                    return;
                }
                else
                {
                    String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                    String qryBuscaCod = "SELECT * from produto where codProd = @codProd and ativo = 1";
                    try
                    {
                        using (conection = new MySqlConnection(conString))
                        {
                            conection.Open();
                            using (MySqlCommand commnad = new MySqlCommand(qryBuscaCod, conection))
                            {
                                commnad.Parameters.AddWithValue("@codProd", campoCod.Text);
                                MySqlDataAdapter adapter = new MySqlDataAdapter(commnad);
                                DataTable dataTab = new DataTable();
                                adapter.Fill(dataTab); //o adapter preenche o datatable

                                gridEstoque.DataSource = dataTab;

                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Falha para se comunicar com o banco", "Falha", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        conection.Close();
                    }
                }
            }
        }

        private void campoNome_TextChanged(object sender, EventArgs e)
        {
            string filtro = campoNome.Text.Trim();

            // Aplica o filtro ao DataTable usando o método Select
            DataRow[] resultados = dataTable.Select($"Nome LIKE '%{filtro}%'");

            // Cria um novo DataTable com os resultados filtrados
            DataTable dataTableFiltrado = dataTable.Clone(); // Mantém a estrutura do DataTable original
            foreach (DataRow row in resultados)
            {
                dataTableFiltrado.ImportRow(row);
            }

            // Atualiza o DataGridView com os resultados filtrados
            gridEstoque.DataSource = dataTableFiltrado;
        }
    }
}