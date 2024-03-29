﻿using MySql.Data.MySqlClient;
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
            getValorTotal = valorTotal; //- double.Parse(txtBoxDesconto.Text);
            txtBoxTotalPagar.Text = "R$: " + (getValorTotal /*- double.Parse(txtBoxDesconto.Text)*/).ToString();
            produtosVenda = produtos;
        }
        public frmConcluirVenda()
        {
            InitializeComponent();
        }

        public double getValorTotal { get; set; }
        public double valorEmDinheiro;
        public double valorPix;
        public double valorCartao;
        double desconto;
        double valorInicial;
        List<Produto> produtosVenda = new List<Produto>();
        List<Venda> listaVenda = new List<Venda>();
        DateTime data;
        int codvendaSelect;
        int codVendaAdicionar;
        double troco;
        double valorPago;
        public void calcularTrocoPix()
        {
            valorInicial = getValorTotal;
            if (double.TryParse(txtBoxPix.Text, out valorPix))
            {
                if (valorPix > 0)
                {
                    troco = (valorPix + valorEmDinheiro + valorCartao) - (valorInicial - double.Parse(txtBoxDesconto.Text));
                    txtValorPago.Text = "R$: " + (valorPix + valorEmDinheiro + valorCartao).ToString();
                    if(txtBoxDinheiro.Text == "" && txtBoxCartao.Text == "" && txtBoxPix.Text == "")
                    {
                        txtValorPago.Text = "R$ 0,00";
                    }
                    if (troco < 0)
                    {
                        lblTrocoValor.Text = "R$ 0,00";
                    }
                    else
                    {
                        if (valorPix == 0 && valorEmDinheiro == 0)
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
        }

        public void calcularTrocoDinheiro()
        {
            valorInicial = getValorTotal - double.Parse(txtBoxDesconto.Text);
            if (double.TryParse(txtBoxDinheiro.Text, out valorEmDinheiro))
            {
                if (valorEmDinheiro > 0)
                {
                    troco = (valorPix + valorEmDinheiro + valorCartao) - (valorInicial - double.Parse(txtBoxDesconto.Text));
                    txtValorPago.Text = "R$: " + (valorPix + valorEmDinheiro + valorCartao).ToString();
                    if (txtBoxDinheiro.Text == "" && txtBoxCartao.Text == "" && txtBoxPix.Text == "")
                    {
                        txtValorPago.Text = "R$ 0,00";
                    }
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

        public void calcularTrocoCartão()
        {
            valorInicial = getValorTotal - double.Parse(txtBoxDesconto.Text);
            if (double.TryParse(txtBoxCartao.Text, out valorCartao))
            {
                if (valorCartao > 0)
                {
                    troco = (valorPix + valorEmDinheiro + valorCartao) - (valorInicial - double.Parse(txtBoxDesconto.Text));
                    txtValorPago.Text = "R$: " + (valorPix + valorEmDinheiro + valorCartao).ToString();
                    if (txtBoxDinheiro.Text == "" && txtBoxCartao.Text == "" && txtBoxPix.Text == "")
                    {
                        txtValorPago.Text = "R$ 0,00";
                    }
                    if (troco < 0)
                    {
                        lblTrocoValor.Text = "R$ 0,00";
                    }
                    else
                    {
                        if (valorPix == 0 && valorEmDinheiro == 0)
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
        }

        private void digitarValorDinheiro(object sender, EventArgs e)
        {
            calcularTrocoDinheiro();
            if (txtBoxDinheiro.Text == "" && txtBoxCartao.Text == "" && txtBoxPix.Text == "")
            {
                txtValorPago.Text = "R$ 0,00";
            }
        }

        private void digitarValorPix(object sender, EventArgs e)
        {
            calcularTrocoPix();
            if (txtBoxDinheiro.Text == "" && txtBoxCartao.Text == "" && txtBoxPix.Text == "")
            {
                txtValorPago.Text = "R$ 0,00";
            }
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
            if (txtBoxDinheiro.Text == "" && txtBoxCartao.Text == "" && txtBoxPix.Text == "")
            {
                txtValorPago.Text = "R$ 0,00";
            }
        }

        private void digitarValorPix_Enter(object sender, EventArgs e)
        {
            calcularTrocoPix();
            if (txtBoxDinheiro.Text == "" && txtBoxCartao.Text == "" && txtBoxPix.Text == "")
            {
                txtValorPago.Text = "R$ 0,00";
            }
        }

        private void digitarValorDinheiro_Enter(object sender, EventArgs e)
        {
            calcularTrocoDinheiro();
            if (txtBoxDinheiro.Text == "" && txtBoxCartao.Text == "" && txtBoxPix.Text == "")
            {
                txtValorPago.Text = "R$ 0,00";
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //estabelecendo conexão com o banco de dados
            String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            //query com o banco
            String sqlSelectcodVenda = "select codVenda from Venda order by codVenda DESC";
            String sqlAdicionarVenda = "insert into Venda (codVenda, codProd, nomeProd, QtdProd, ValorProd, ValorTotalVenda, Data_Registro) VALUES (@codVenda, @codProd, @nomeProd, @QtdProd, @ValorProd, @ValorTotalVenda, @Data_Registro)";
            data = DateTime.Now;
            double total = getValorTotal - double.Parse(txtBoxDesconto.Text);
            if ((valorPix+valorEmDinheiro+valorCartao) - total == 0 || (valorPix + valorEmDinheiro + valorCartao) - total > 0)
            {
                Console.WriteLine("Passei1");
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
                                    Console.WriteLine("Passei2");
                                    codvendaSelect = int.Parse(reader["codVenda"].ToString());
                                    codVendaAdicionar = codvendaSelect;
                                }
                            }
                        }
                        using (cmdAdicionarVenda)
                        {
                            foreach (Produto p in produtosVenda)
                            {
                                Venda venda = new Venda(codVendaAdicionar, p.quantidade, p.codProduto, data);
                                listaVenda.Add(venda);
                            }

                            foreach (Venda v in listaVenda)
                            {
                                cmdAdicionarVenda.Parameters.Clear();
                                cmdAdicionarVenda.Parameters.AddWithValue("@codVenda", codVendaAdicionar + 1);
                                cmdAdicionarVenda.Parameters.AddWithValue("@codProd", v.codProd);
                                cmdAdicionarVenda.Parameters.AddWithValue("@nomeProd", DBNull.Value);
                                cmdAdicionarVenda.Parameters.AddWithValue("@QtdProd", v.quantidade);
                                cmdAdicionarVenda.Parameters.AddWithValue("@ValorProd", DBNull.Value);
                                cmdAdicionarVenda.Parameters.AddWithValue("@ValorTotalVenda", DBNull.Value);
                                cmdAdicionarVenda.Parameters.AddWithValue("@Data_Registro", data);
                                int linhasAfetdas = cmdAdicionarVenda.ExecuteNonQuery();
                            }
                            MessageBox.Show("Venda concluída com sucesso !", "VENDA CONCLUÍDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            produtosVenda.Clear();
                            this.Close();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("ERRO NO SISTEMA :" + ex.Message, "ERRO");
                }
            }
            else
            {
                MessageBox.Show("VALOR INSUFICIENTE", "ERRO: VALOR INSUFICIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void digitarValorDinheiro_Leave(object sender, EventArgs e)
        {
            calcularTrocoDinheiro();
            if (txtBoxDinheiro.Text == "" && txtBoxCartao.Text == "" && txtBoxPix.Text == "")
            {
                txtValorPago.Text = "R$ 0,00";
            }
        }

        private void inserirValorCartão(object sender, EventArgs e)
        {
            calcularTrocoCartão();
            if (txtBoxDinheiro.Text == "" && txtBoxCartao.Text == "" && txtBoxPix.Text == "")
            {
                txtValorPago.Text = "R$ 0,00";
            }
        }

        private void calculaTrocoCartao_enter(object sender, EventArgs e)
        {
            calcularTrocoCartão();
            if (txtBoxDinheiro.Text == "" && txtBoxCartao.Text == "" && txtBoxPix.Text == "")
            {
                txtValorPago.Text = "R$ 0,00";
            }
        }

        private void calculaTrocoCartao_leave(object sender, EventArgs e)
        {
            calcularTrocoCartão();
            if (txtBoxDinheiro.Text == "" && txtBoxCartao.Text == "" && txtBoxPix.Text == "")
            {
                txtValorPago.Text = "R$ 0,00";
            }
        }

        private void calculaSaldo(object sender, EventArgs e)
        {
           
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja fechar o formulário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verifica se o usuário clicou em "Sim"
            if (result == DialogResult.Yes)
            {
                // Fecha o formulário
                this.Close();
            }
        }
    }
}


