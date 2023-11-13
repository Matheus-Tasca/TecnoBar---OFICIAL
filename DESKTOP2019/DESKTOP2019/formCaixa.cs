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
        List<Produto> listaQuantidadesProdutos = new List<Produto>();
        int quantidadeBD;
        int quantidade;
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
                                    double valorVenda = double.Parse(reader["valorVenda"].ToString());
                                    txtNomeProduto.Text = nomeProduto;
                                    txtCategoria.Text = categoria;
                                    lblValorUnitario.Text = valorVenda.ToString();
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
                quantidade = int.Parse(txtQuantidade.Text);
                String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                string sqlVerificarQuantidade = "select qtdEstoque from produto where codProd = @codProd";
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        //abre conexão
                        con.Open();
                        //Verifica a quantidade atual em estoque do produto
                        MySqlCommand cmdVerificaQuantidade = new MySqlCommand(sqlVerificarQuantidade, con);

                        //verificando a quantidade do item no estoque
                        using (cmdVerificaQuantidade)
                        {
                            cmdVerificaQuantidade.Parameters.Clear();
                            cmdVerificaQuantidade.Parameters.AddWithValue("@codProd", codProd);
                            //realiza a pesquisa no bd em busca da quantidade
                            using (MySqlDataReader reader = cmdVerificaQuantidade.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    //pega a quantidade
                                    quantidadeBD = int.Parse(reader["qtdEstoque"].ToString());
                                    //verifica se quantidade da venda é superior ao estoque
                                    if (quantidadeBD < quantidade)
                                    {
                                        MessageBox.Show("ESTOQUE INSUFICIENTE", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtCodigoProduto.Text = "";
                                        txtQuantidade.Text = "";
                                        txtCategoria.Text = "";
                                        txtNomeProduto.Text = "";
                                        lblValorUnitario.Text = "R$ 0,00";
                                        lblValorTotal.Text = "R$ 0,00";
                                    }
                                    else
                                    {
                                        Produto produto = new Produto(codProd, nomeProduto, valorVenda, quantidade);
                                        produtos.Add(produto);
                                        //calcula o valorTotal do produto
                                        double valorTotalProduto = produto.quantidade * produto.valorVenda;
                                        //adiciona ao listBox
                                        listBoxProdutos.Items.Add("Cod: " + produto.codProduto + " | " + " Produto: " + produto.nomeProduto + " | " + produto.quantidade + "x" + " | " + "\n R$: " + valorTotalProduto.ToString());
                                        //calcula o total de tudo
                                        total += valorTotalProduto;
                                        //limpa os campos
                                        limpar();
                                        //adiciona ao texto de subTotal
                                        lblSubTotal.Text = "R$: " + total.ToString();
                                    }
                                    foreach (Produto p in produtos)
                                    {
                                        Produto prodQtd = new Produto(p.codProduto, quantidadeBD);
                                        listaQuantidadesProdutos.Add(prodQtd);
                                    }
                                }
                            }

                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("ERRO NO SISTEMA: " + ex.Message, "ERRO");
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("INSIRA UM VALOR EM TODOS OS CAMPOS", "ERRO NO SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

            private void finalizaVenda(object sender, EventArgs e){
                String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                string sqlAtualizarQuantidade = "update produto set qtdEstoque = qtdEstoque - @qtd where codProd = @codProd";
                try
                {
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        //abre conexão
                        con.Open();
                        //Verifica a quantidade atual em estoque do produto
                        MySqlCommand cmdAtualizaQuantidade = new MySqlCommand(sqlAtualizarQuantidade, con);
                        using (cmdAtualizaQuantidade)
                        {
                            foreach (Produto prod in listaQuantidadesProdutos)
                            {
                                cmdAtualizaQuantidade.Parameters.Clear();
                                cmdAtualizaQuantidade.Parameters.AddWithValue("@qtd", quantidade);
                                cmdAtualizaQuantidade.Parameters.AddWithValue("@codProd", prod.codProduto);
                                int linhasAfetadas = cmdAtualizaQuantidade.ExecuteNonQuery();
                            }
                        }
                    }
                    frmConcluirVenda frmVenda = new frmConcluirVenda(total, produtos);
                    frmVenda.Show();
                    listBoxProdutos.Items.Clear();
                    lblSubTotal.Text = "";
                    total = 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("ERRO NO SISTEMA: " + ex.Message, "ERRO");
                }
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


