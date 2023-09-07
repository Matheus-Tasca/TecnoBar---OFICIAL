using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // para trabalhar com arquivos
using MySql.Data.MySqlClient;
using System.Configuration;

namespace TCC
{
    public partial class formProduto : Form
    {
        MySqlConnection conection;
        DataSet dsProd;

        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";
        int modo = 0; // 0 = padrão ; 1 = inclusão

        public formProduto()
        {
            InitializeComponent();
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

        public void limpar()
        {
            campoCate.SelectedIndex = -1;
            campoCod.Clear();
            campoNome.Clear();
            campoCusto.Clear();
            campoQtdE.Clear();
            campoQtdMin.Clear();
            campoPreco.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpar();
            modo = 1;
            habilitar();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((campoCate.SelectedIndex == -1) || (campoPreco.Text == "") || (campoNome.Text == "") || (campoCusto.Text == "") || (campoQtdE.Text == "") || (campoQtdMin.Text == ""))
                {
                    throw new CampoVazioException("Todos os campos devem ser preenchidos");
                }
                else
                {
                    string qryInsereProd = "INSERT into produto (nomeProd,  codCategoria, qtdMin, qtdEstoque, valorEntrada, valorVenda, linkImg)"
                        + "VALUES (@nome, @codcategoria, @qtdMin, @qtdEst, @valorEntrada, @valorVenda, @linkImg)";
                    String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; //pega a localização que foi explicada
                    using (conection = new MySqlConnection(conString))//Criar conexão com o banco (chega no local)
                    {
                        conection.Open(); //abre

                        MySqlCommand comando = new MySqlCommand(qryInsereProd, conection); //da o comando
                        comando.Parameters.AddWithValue("@nome", campoNome.Text);
                        comando.Parameters.AddWithValue("@codcategoria", campoCate.SelectedIndex);
                        comando.Parameters.AddWithValue("@qtdMin", campoQtdMin.Text);
                        comando.Parameters.AddWithValue("@qtdEst", campoQtdE.Text);
                        comando.Parameters.AddWithValue("@valorEntrada", campoCusto.Text);
                        comando.Parameters.AddWithValue("@valorVenda", campoPreco.Text);
                        comando.Parameters.AddWithValue("@linkImg", "TESTE");

                        int linhasAfetadas = comando.ExecuteNonQuery();
                        conection.Close();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Produto inserido com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            /*else
            {
                //foto
                if (destinoCompleto == "")
                {
                    if (MessageBox.Show("Nenhuma foto foi selecionada. Tem certeza que deseja salvar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Produto cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        modo = 0;
                        habilitar();
                        limpar();
                    }
                }
                if (destinoCompleto != "")
                {
                    System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                    if (File.Exists(destinoCompleto))
                    {
                        pb_Imagem.ImageLocation = origemCompleto; //atribuindo o caminho de origem ao picture box
                        MessageBox.Show("Produto cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        modo = 0;
                        habilitar();
                        limpar();
                        //C:\Users\joaop\source\repos\Desktop C#\TCC\bin\Debug\net7.0-windows\FotoProduto;                     
                    }
                    else
                    {
                        MessageBox.Show("Arquivo não copiado");
                    }
                }
                // fim da foto*/
        }
        //OnChange categoria
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            formNovaCate formNovaCate = new formNovaCate();
            formNovaCate.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            formExlcuirProduto formExlcuirProduto = new formExlcuirProduto();
            formExlcuirProduto.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                origemCompleto = "";
                foto = "";
                pastaDestino = Globais.caminhoFotos;
                destinoCompleto = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    origemCompleto = openFileDialog1.FileName; // o caminho todo por exemplo C:\Users\joaop\source\repos\Desktop C#\TCC\bin\Debug
                    foto = openFileDialog1.SafeFileName; //só o nome do arquivo 
                    destinoCompleto = pastaDestino + foto;
                }

                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pb_Imagem.ImageLocation = origemCompleto;
                }
                else
                {
                    MessageBox.Show("Arquivo não copiado");
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void campoPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DoubleNumber(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.DoubleNumber(e);
        }

        private void campoQtdE_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formAlterar formAlterar = new formAlterar();
            formAlterar.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
            modo = 0;
            habilitar();
        }

        private void campoQtdMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }
    }
}
