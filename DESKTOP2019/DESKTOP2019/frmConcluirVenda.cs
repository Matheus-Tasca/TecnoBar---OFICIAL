using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DESKTOP2019.CamadaDadosformCaixa;

namespace DESKTOP2019
{
    public partial class frmConcluirVenda : Form
    {
        public frmConcluirVenda(double valorTotal, List<Produto> produtos)
        {
            InitializeComponent();
            getValorTotal = valorTotal;
            txtBoxTotalPagar.Text = "R$: " + (getValorTotal).ToString();
            produtosVenda = produtos;
    }
        public frmConcluirVenda()
        {
            InitializeComponent();
        }

        public double getValorTotal { get; set; }
        public double valorEmDinheiro;
        public double valorPix;
        double desconto;
        double valorInicial;
        List<Produto> produtosVenda = new List<Produto>();
        List<Venda> listaVenda = new List<Venda>();
        DateTime data;
        int codvendaSelect;
        int codVendaAdicionar;
        public void calcularTrocoPix()
        {
            valorInicial = getValorTotal;
            if (double.TryParse(txtBoxPix.Text, out valorPix))
            {
                if (valorPix > 0)
                {
                    double troco = (valorPix + valorEmDinheiro) - (valorInicial-desconto);
                    if (troco < 0)
                    {
                        lblTrocoValor.Text = "R$ 0,00";
                    }
                    else
                    {
                        lblTrocoValor.Text = "R$" + troco.ToString();
                    }
                }
            }
        }

        public void calcularTrocoDinheiro()
        {
            valorInicial = getValorTotal;
            if (double.TryParse(txtBoxDinheiro.Text, out valorEmDinheiro))
            {
                if (valorEmDinheiro > 0)
                {
                    double troco = (valorPix + valorEmDinheiro) - (valorInicial - desconto);
                    if (troco < 0)
                    {
                        lblTrocoValor.Text = "R$ 0,00";
                    }
                    else
                    {
                        lblTrocoValor.Text = "R$" + troco.ToString();
                    }
                }
            }
        }

        private void digitarValorDinheiro(object sender, EventArgs e)
        {
            calcularTrocoDinheiro();
        }

        private void digitarValorPix(object sender, EventArgs e)
        {
            calcularTrocoPix();
        }

        private void inserirDesconto(object sender, EventArgs e)
        {
            
        }

        private void digitarDesconto(object sender, EventArgs e)
        {
            if (double.TryParse(txtBoxDesconto.Text, out desconto))
            {
                if(txtBoxDesconto.Text != "")
                {
                    txtBoxTotalPagar.Text = "R$: " + (getValorTotal - desconto).ToString();
                }
            }
        }

        private void digitarValorPix_Leave(object sender, EventArgs e)
        {
            calcularTrocoPix();
        }

        private void digitarValorPix_Enter(object sender, EventArgs e)
        {
            calcularTrocoPix();
        }

        private void digitarValorDinheiro_Enter(object sender, EventArgs e)
        {
            calcularTrocoDinheiro();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //estabelecendo conexão com o banco de dados
            String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            //query com o banco
            String sqlSelectcodVenda = "select codVenda from Venda order by codVenda DESC";
            String sqlAdicionarVenda = "insert into Venda (codVenda, codProd, nomeProd, QtdProd, ValorProd, ValorTotalVenda, Data_Registro) VALUES (@codVenda, @codProd, @nomeProd, @QtdProd, @ValorProd, @ValorTotalVenda, @Data_Registro)";
            data = DateTime.Now;
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    MySqlCommand cmdSelectcodVenda = new MySqlCommand(sqlSelectcodVenda, con);
                    MySqlCommand cmdAdicionarVenda = new MySqlCommand(sqlAdicionarVenda, con);

                    using (cmdSelectcodVenda)
                    {
                       using (MySqlDataReader reader = cmdSelectcodVenda.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                codvendaSelect = int.Parse(reader["codVenda"].ToString());
                                codVendaAdicionar = codvendaSelect;
                            }
                        }
                    }
                    using (cmdAdicionarVenda)
                    {
                        foreach(Produto p in produtosVenda)
                        {
                            Venda venda = new Venda(codVendaAdicionar,p.quantidade, p.codProduto, data);
                            listaVenda.Add(venda);
                        }
                        
                        foreach (Venda v in listaVenda)
                        {
                            cmdAdicionarVenda.Parameters.Clear();
                            cmdAdicionarVenda.Parameters.AddWithValue("@codVenda", codVendaAdicionar+1);
                            cmdAdicionarVenda.Parameters.AddWithValue("@codProd", v.codProd);
                            cmdAdicionarVenda.Parameters.AddWithValue("@nomeProd", DBNull.Value);
                            cmdAdicionarVenda.Parameters.AddWithValue("@QtdProd", v.quantidade);
                            cmdAdicionarVenda.Parameters.AddWithValue("@ValorProd", DBNull.Value);
                            cmdAdicionarVenda.Parameters.AddWithValue("@ValorTotalVenda", DBNull.Value);
                            cmdAdicionarVenda.Parameters.AddWithValue("@Data_Registro", data);
                            int linhasAfetdas = cmdAdicionarVenda.ExecuteNonQuery();
                        }
                    }
                }
            }catch(MySqlException ex)
            {
                MessageBox.Show("ERRO NO SISTEMA :" + ex.Message, "ERRO");
            }
        }
    }
}


