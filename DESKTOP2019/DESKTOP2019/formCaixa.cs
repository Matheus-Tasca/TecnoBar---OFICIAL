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
    public partial class formCaixa : Form
    {
        public formCaixa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void grpFiltrar_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Evento de enter ao digitar o codigo do produto
        private void pressionaEnter(object sender, KeyEventArgs e)
        {
            //estabelecendo conexão com o banco de dados
            String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            //query com o banco
            String sqlSelect = "select nomeProd, codCategoria, valorVenda from produto where codProd = @codProd";
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
                                    string categoria = reader["codCategoria"].ToString();
                                    if (categoria.Equals("1"))
                                    {
                                        categoria = "bebidas";
                                    }
                                    else{
                                        categoria = "comidas";
                                    }
                                    string valorVenda = reader["valorVenda"].ToString();
                                    txtNomeProduto.Text = nomeProduto;
                                    txtCategoria.Text = categoria;
                                    lblValorUnitario.Text = "R$ " + valorVenda;
                                }
                            }
                        }
                    }
                } catch(SqlException ex)
                {
                    MessageBox.Show("ERRO NO SISTEMA :" + ex.Message,"ERRO");
                }
            e.SuppressKeyPress = true;
            }

        }

        private void enterQuantidadeItem(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int quantidade = int.Parse(txtQuantidade.Text);
                double valorUnitario;
                if(doubl.TryParse(lblValorUnitario.Text,out valorUnitario))
                {
                    Console.WriteLine(valorUnitario);
                }

                double total = quantidade * valorUnitario;
                lblValorTotal.Text = "R$: " + total.ToString();
            }
        }
    } 
}

