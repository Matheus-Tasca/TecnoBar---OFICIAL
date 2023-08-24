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

namespace TCC
{
    public partial class formProduto : Form
    {
        MySqlConnection conection;

        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";

        public formProduto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            campoCate.SelectedIndex = -1;
            campoCod.Clear();
            campoNome.Clear();
            campoCusto.Clear();
            campoQtdE.Clear();
            campoQtdMin.Clear();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
               

                string data_source = "";

                conection = new MySqlConnection(); //Criar conexão com o banco

                string queryProd = "INSERT into produto nomeProd, qtdMin, qtdEstoque, valorEntrada, valorVenda"
                    + "VALUES ('" + campoNome.Text + "', " +
                    "'" + campoQtdMin.Text + "', " +
                    "'" + campoQtdE.Text + "'," +
                    " '" + campoCusto.Text + "'," +
                    "'" + campoPreco.Text + "')";

                MySqlCommand comando = new MySqlCommand(queryProd, conection);

                //Quando tiver o banco. Da para tirar isso daqui e colocar o message no catch
                if ((campoCate.SelectedIndex == -1) || (campoPreco.Text == "") || (campoNome.Text == "") || (campoCusto.Text == "") || (campoQtdE.Text == "") || (campoQtdMin.Text == ""))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
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
                        }
                    }
                    if (destinoCompleto != "")
                    {
                        System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                        if (File.Exists(destinoCompleto))
                        {
                            pb_Imagem.ImageLocation = origemCompleto; //atribuindo o caminho de origem ao picture box
                            MessageBox.Show("Produto cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //C:\Users\joaop\source\repos\Desktop C#\TCC\bin\Debug\net7.0-windows\FotoProduto;                     
                        }
                        else
                        {
                            MessageBox.Show("Arquivo não copiado");
                        }
                    }
                    // fim da foto
                }
                //OnChange categoria
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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


            /*if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("O arquivo já possuí essa foto, deseja substituir?", "Substituir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }*/
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
    }
}
