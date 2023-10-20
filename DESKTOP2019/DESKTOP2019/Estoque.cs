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

        public void Busca()
        {
            String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;
            string query = "SELECT * FROM produto"; // Substitua pelo seu SQL

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
                        string qtd = reader["qtdEstoque"].ToString();
                        listaEst.Items.Add($"{cod}  {nome} : {qtd}");
                    }

                    reader.Close();
                }
            }
        }

        public Estoque()
        {
            InitializeComponent();
            Busca();   
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(campoQTDajust.Value);
            int selecionou = Convert.ToInt32(this.listaEst.SelectedIndex + 1);

            try
            {
                if (MessageBox.Show("Tem certeza que deseja adicionar VALOR para o estoque desse produto", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    String qryExc = ($"UPDATE produto SET qtdEstoque = qtdEstoque - {valor} where codProd = {selecionou}");
                    String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; //endereco
                    using (conection = new MySqlConnection(conString))
                    {
                        conection.Open();
                        MySqlCommand cmd = new MySqlCommand(qryExc, conection);
                        int linhafetadas = cmd.ExecuteNonQuery();
                        conection.Close();

                       // MessageBox.Show("Consulta SQL: " + qryExc);

                        if (linhafetadas > 0)
                        {
                            MessageBox.Show("Esoque retirado com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listaEst.Items.Clear();
                            Busca();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao retirar o estoque", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Não foi possível se comunicar com o Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            campoQTDajust.Value = 0;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(campoQTDajust.Value);
            int selecionou = Convert.ToInt32(this.listaEst.SelectedIndex + 1);

            try
            {
                if (MessageBox.Show("Tem certeza que deseja adicionar VALOR para o estoque desse produto", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    String qryInsert = ($"UPDATE produto SET qtdEstoque = qtdEstoque + {valor} where codProd = {selecionou}");
                    String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; //endereco
                    using (conection = new MySqlConnection(conString)) 
                    {
                        conection.Open();
                        MySqlCommand cmd = new MySqlCommand(qryInsert, conection);
                        int linhafetadas = cmd.ExecuteNonQuery();
                        conection.Close();

                        if (linhafetadas > 0)
                        {
                            MessageBox.Show("Esoque inserido com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listaEst.Items.Clear();
                            Busca();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao inserir o estoque", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            } catch (MySqlException){
                MessageBox.Show("Não foi possível se comunicar com o Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            campoQTDajust.Value = 0;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(campoQTDajust.Value);
            int selecionou = Convert.ToInt32(this.listaEst.SelectedIndex + 1);

            try
            {
                if (MessageBox.Show("Tem certeza que deseja adicionar VALOR para o estoque desse produto", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    String qryInsert = ($"UPDATE produto SET qtdEstoque = {valor} where codProd = {selecionou}");
                    String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; //endereco
                    using (conection = new MySqlConnection(conString))
                    {
                        conection.Open();
                        MySqlCommand cmd = new MySqlCommand(qryInsert, conection);
                        int linhafetadas = cmd.ExecuteNonQuery();
                        conection.Close();

                        if (linhafetadas > 0)
                        {
                            MessageBox.Show("Esoque ajustado com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            listaEst.Items.Clear();
                            Busca();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao ajustar o estoque", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                campoQTDajust.Value = 0;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Não foi possível se comunicar com o Banco de Dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void campoCod_TextChanged(object sender, EventArgs e)
        {
            String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            String qryBuscaCod = "SELECT * from produto where codProd = @codProd";
            using (conection = new MySqlConnection(conString))
            {
                conection.Open();
                using(MySqlCommand commnad = new MySqlCommand(qryBuscaCod, conection))
                {
                    commnad.Parameters.AddWithValue("@codProd", campoCod.Text);
                    MySqlDataReader reader = commnad.ExecuteReader();
                    string nome = reader["nomeProd"].ToString();
                    string qtd = reader["qtdEstoque"].ToString();

                    int linhasAfetadas = commnad.ExecuteNonQuery();
                    
                    if(linhasAfetadas > 0)
                    {
                        listaEst.Items.Clear();
                        listaEst.Items.Add($"{qtd} {nome}");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível achar esse código", "Falha", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }

                conection.Close();
                AppSettingsReader.Close();
            }
        }
    }
}
