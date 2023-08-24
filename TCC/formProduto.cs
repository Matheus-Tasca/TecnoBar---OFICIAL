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

namespace TCC
{
    public partial class formProduto : Form
    {

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
            origemCompleto = "";
            textBox1.Clear();
            campoQtdE.Clear();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Quando tiver o banco. Da para tirar isso daqui e colocar o message no catch
                if ((campoCate.SelectedIndex == -1) || (campoCod.Text == "") || (campoNome.Text == ""))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //foto
                if (destinoCompleto == "")
                {
                    if (MessageBox.Show("Nenhuma foto foi selecionada. Tem certeza que deseja salvar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }
                if (destinoCompleto != "")
                {
                    System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                    if (File.Exists(destinoCompleto))
                    {
                        pb_Imagem.ImageLocation = origemCompleto; //atribuindo o caminho de origem ao picture box
                        MessageBox.Show("Foi para o banco");
                        //C:\Users\joaop\source\repos\Desktop C#\TCC\bin\Debug\net7.0-windows\FotoProduto;                     
                    }
                    else
                    {
                        MessageBox.Show("Arquivo não copiado");
                    }
                }
                // fim da foto

                string queryInserProduto = String.Format(@"");

                //OnChange categoria

                //manda para o banco
            }
            catch (Exception ex)
            {

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
    }
}
