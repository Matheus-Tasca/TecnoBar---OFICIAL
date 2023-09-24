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
        int modo = 0; // 0 = padrão ; 1 = inclusão

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
                        btnExcluir.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnCancelar.Enabled = false;
                        btnSalvar.Enabled = false;
                        break;
                    case 1:
                        btnNovo.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnAlterar.Enabled = false;
                        btnCancelar.Enabled = true;
                        btnSalvar.Enabled = true;
                        campoNome.Focus();
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
                        string qtd = reader["qtdEstoque"].ToString();
                        listProd.Items.Add($"{cod} - {nome} - {qtd}");
                    }

                    reader.Close();
                }
            }
        }

        public CDPROD()
        {
            InitializeComponent();
            Busca();
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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int linhasAfetadas = 0;
            try
            {
                if ((campoCategoria.SelectedIndex == -1) || (campoVenda.Text == "") || (campoNome.Text == "") || (campoCusto.Text == "") || (campoQTDInicio.Text == "") || (campoQTDMinima.Text == ""))
                {
                    throw new CampoVazioException("Todos os campos devem ser preenchidos");
                }
                else
                {
                    string qryInsereProd = "INSERT into produto (nomeProd,  codCategoria, qtdMin, qtdEstoque, valorEntrada, valorVenda)"
                        + "VALUES (@nome, @codcategoria, @qtdMin, @qtdEst, @valorEntrada, @valorVenda)";
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(this.listProd.SelectedValue);
            String qryDelete = $"DELETE from produto where codProd = {id}";
            if (MessageBox.Show("Tem certeza que deseja inativar este produto do seu sistema? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) {
                //try
                {
                    // INATIVAR
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
    }
}
