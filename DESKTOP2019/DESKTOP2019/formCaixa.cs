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
using static DESKTOP2019.CamadaDadosformCaixa;
using System.Collections.Generic;

namespace DESKTOP2019
{
    public partial class formCaixa : Form
    {
        public frmConcluirVenda frmFinalizarVenda = new frmConcluirVenda();
        double total;
        List<Produto> produtos = new List<Produto>();
        int quantidadeBD;
        int indice;
        List<int> listaQuantidadesProdutosVenda = new List<int>();
        public formCaixa()
        {
            InitializeComponent();
        }
        public void limpar()
        {
            txtCodigoProduto.Clear();
            txtQuantidade.Clear();
            txtCategoria.Clear();
            txtNomeProduto.Clear();
            lblValorUnitario.Text = "R$ 0,00";
            lblValorTotal.Text = "R$ 0,00";
            double total = 0;
        }



        //Evento de enter ao digitar o codigo do produto
        private void pressionaEnter(object sender, KeyEventArgs e)
        {
            //estabelecendo conexão com o banco de dados
            String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            //query com o banco
            String sqlSelect = "select nomeProd, nomeCategoria, valorVenda from produto where ativo = 1 and codProd = @codProd";
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(sqlSelect, con);
                        using (cmd)
                        {
                            cmd.Parameters.AddWithValue("@codProd", txtCodigoProduto.Text);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string nomeProduto = reader["nomeProd"].ToString();
                                    string categoria = reader["nomeCategoria"].ToString();
                                    string valorVenda = reader["valorVenda"].ToString();
                                    txtNomeProduto.Text = nomeProduto;
                                    txtCategoria.Text = categoria;
                                    lblValorUnitario.Text = valorVenda;
                                }
                            }
                        }
                        con.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("ERRO NO SISTEMA :" + ex.Message, "ERRO");
                }
                e.SuppressKeyPress = true;
            }
        }

        private void enterQuantidadeItem(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int quantidade = int.Parse(txtQuantidade.Text);
                    string valorUnitarioCampo = lblValorUnitario.Text;
                    if (double.TryParse(valorUnitarioCampo, out double valorUnitario))
                    {
                        total = valorUnitario * quantidade;
                        lblValorTotal.Text = "R$" + total.ToString();
                    }
                }
                catch (System.FormatException ex)
                {
                    MessageBox.Show("INSIRA UM VALOR EM TODOS OS CAMPOS", "ERRO NO SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mudaCampoCodigo(object sender, EventArgs e)
        {
            //estabelecendo conexão com o banco de dados
            String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            //query com o banco
            String sqlSelect = "select nomeProd, nomeCategoria, valorVenda from produto where codProd = @codProd and ativo = 1";
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sqlSelect, con);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@codProd", txtCodigoProduto.Text);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nomeProduto = reader["nomeProd"].ToString();
                                string categoria = reader["nomeCategoria"].ToString();
                                string valorVenda = reader["valorVenda"].ToString();
                                txtNomeProduto.Text = nomeProduto;
                                txtCategoria.Text = categoria;
                                lblValorUnitario.Text = valorVenda;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERRO NO SISTEMA :" + ex.Message, "ERRO");
            }
        }

        private void LeaveCampoQuantidade(object sender, EventArgs e)
        {
            if (txtQuantidade.Text != "")
            {
                try
                {
                    int quantidade = int.Parse(txtQuantidade.Text);
                    string valorUnitarioCampo = lblValorUnitario.Text;
                    if (double.TryParse(valorUnitarioCampo, out double valorUnitario))
                    {
                        double total = valorUnitario * quantidade;
                        lblValorTotal.Text = "R$" + total.ToString();
                    }
                }
                catch (System.FormatException ex)
                {
                    MessageBox.Show("INSIRA UM VALOR EM TODOS OS CAMPOS", "ERRO NO SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                int codProd = int.Parse(txtCodigoProduto.Text);
                string nomeProduto = txtNomeProduto.Text;
                double valorVenda = double.Parse(lblValorUnitario.Text);
                int quantidade = int.Parse(txtQuantidade.Text);
                Produto produto = new Produto(codProd, nomeProduto, valorVenda, quantidade);
                produtos.Add(produto);
                double valorTotalProduto = produto.quantidade * produto.valorVenda;
                listBoxProdutos.Items.Add("Cod: "+ produto.codProduto + " | "+" Produto: " + produto.nomeProduto + " | " + produto.quantidade + "x" + " | " + "\n R$: " + valorTotalProduto.ToString());
                total += valorTotalProduto;
                limpar();
                lblSubTotal.Text = "R$: " + total.ToString();
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("INSIRA UM VALOR EM TODOS OS CAMPOS", "ERRO NO SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void finalizaVenda(object sender, EventArgs e)
        {
            /*String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            string sqlAtualizarQuantidade = "update produto set qtdEstoque = qtdEstoque - @quantidade where codProd = @codProd";
            string sqlVerificarQuantidade = "select qtdEstoque from produto where codProd = @codPrd";
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    MySqlCommand cmdVerificaQuantidade = new MySqlCommand(sqlVerificarQuantidade, con);
                    MySqlCommand cmdAtualizaQuantidade = new MySqlCommand(sqlAtualizarQuantidade, con);

                    //verificando a quantidade de cada item no estoque
                    using (cmdVerificaQuantidade)
                    {
                        foreach (Produto p in produtos)
                        {
                            cmdVerificaQuantidade.Parameters.Clear();
                            cmdVerificaQuantidade.Parameters.AddWithValue("@codPrd", p.codProduto);
                            using (MySqlDataReader reader = cmdVerificaQuantidade.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    quantidadeBD = int.Parse(reader["codVenda"].ToString());
                                    listaQuantidadesProdutosVenda.Add(quantidadeBD);
                                }
                            }
                        }
                    }
                }
            }catch(MySqlException ex)
            {
                MessageBox.Show("ERRO NO SISTEMA: " + ex.Message, "ERRO");
            }*/
            frmConcluirVenda frmVenda = new frmConcluirVenda(total, produtos);
            frmVenda.Show();
            produtos.Clear();
            listBoxProdutos.Items.Clear();
            lblSubTotal.Text = "";
            total = 0;
        }

        private void cmdCancelarVenda(object sender, EventArgs e)
        {
            listBoxProdutos.Items.Clear();
            total = 0;
            txtQuantidade.Clear();
            txtNomeProduto.Clear();
            txtCodigoProduto.Clear();
            txtCategoria.Clear();
            lblSubTotal.Text = "";
        }

        private void textChangedQuantidade(object sender, EventArgs e)
        {
            
            if (txtQuantidade.Text != "")
            {
                try
                {
                    int quantidade = int.Parse(txtQuantidade.Text);
                    string valorUnitarioCampo = lblValorUnitario.Text;
                    if (double.TryParse(valorUnitarioCampo, out double valorUnitario))
                    {
                        double total = valorUnitario * quantidade;
                        lblValorTotal.Text = "R$" + total.ToString();
                    }
                }
                catch (System.FormatException ex)
                {
                    MessageBox.Show("INSIRA UM VALOR EM TODOS OS CAMPOS", "ERRO NO SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EnterCampoQuantidade(object sender, EventArgs e)
        {
            if (txtQuantidade.Text != "")
            {
                try
                {
                    int quantidade = int.Parse(txtQuantidade.Text);
                    string valorUnitarioCampo = lblValorUnitario.Text;
                    if (double.TryParse(valorUnitarioCampo, out double valorUnitario))
                    {
                        double total = valorUnitario * quantidade;
                        lblValorTotal.Text = "R$" + total.ToString();
                    }
                }
                catch (System.FormatException ex)
                {
                    MessageBox.Show("INSIRA UM VALOR EM TODOS OS CAMPOS", "ERRO NO SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deletarItemVenda(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Delete)
            {
                if (listBoxProdutos.SelectedIndex != -1)
                {
                    List<Produto> produtosCopia = new List<Produto>(produtos);
                    foreach (Produto produto in produtosCopia)
                    {
                        indice = produtos.IndexOf(produto);
                        if (indice == listBoxProdutos.SelectedIndex)
                        {
                                int quantidade = produto.quantidade;
                                double valor = produto.valorVenda;
                                total = total - (quantidade * valor);
                                produtos.Remove(produto);
                                listBoxProdutos.Items.RemoveAt(listBoxProdutos.SelectedIndex);
                                lblSubTotal.Text = "R$: " + total.ToString();
                        }
                    }
                }
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }
    }
}


