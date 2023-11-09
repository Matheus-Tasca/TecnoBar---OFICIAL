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
        int indice;
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
            String sqlSelect = "select nomeProd, nomeCategoria, valorVenda from produto where codProd = @codProd";
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
            String sqlSelect = "select nomeProd, nomeCategoria, valorVenda from produto where codProd = @codProd";
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
                string nomeProduto = txtNomeProduto.Text;
                double valorVenda = double.Parse(lblValorUnitario.Text);
                int quantidade = int.Parse(txtQuantidade.Text);
                Produto produto = new Produto(nomeProduto, valorVenda, quantidade);
                produtos.Add(produto);
                double valorTotalProduto = produto.quantidade * produto.valorVenda;
                listBoxProdutos.Items.Add("Produto: " + produto.nomeProduto + " | " + produto.quantidade + "x" + " | " + "\n R$: " + valorTotalProduto.ToString());
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
            frmConcluirVenda frmVenda = new frmConcluirVenda(total);
            frmVenda.Show();
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
    }
}


