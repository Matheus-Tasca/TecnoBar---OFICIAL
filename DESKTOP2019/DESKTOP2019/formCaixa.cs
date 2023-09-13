using System;
using System.Windows.Forms;

namespace TCC
{

    public partial class formCaixa : Form
    {

        public decimal quant;

        string[] nomeProd = new string[3];
        string[] descProd = new string[3];
        string[] codProd = new string[3];
        double[] valorProd = new double[3];

        double somaTotal;
        int ind = 0;

        public formCaixa()
        {
            InitializeComponent();
            quant = 1;
        }

        private void bt_final_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja encerrar a venda?", "Está ação apagará tudo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                campoCod.Clear();
                campoNome.Clear();
                //campoCate.SelectedIndex = -1;
                listBox1.Items.Clear();
                lbl_valorTotal.Text = "0,00";
                Itens_Venda.Items.Clear();
                somaTotal = 0;
            }

        }

        private void loadProd()
        {
            codProd[1] = "8";
            codProd[2] = "9";
            descProd[1] = "com catupiry";
            descProd[2] = "300ml";
            nomeProd[1] = "Empada de palmito";
            nomeProd[2] = "Água sem gás";
            valorProd[1] = 80.00;
            valorProd[2] = 120.00;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadProd();
            somaTotal = 0;

        }

        private void campoCod_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                for (int cp = 1; cp < 3; cp++)
                {
                    if (campoCod.Text == codProd[cp])
                    {
                        ind = cp;
                    }
                }

                if (ind > 0)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(String.Format("{0} : {1} : {2} : {3}", codProd[ind], nomeProd[ind], descProd[ind], valorProd[ind]));
                    campoCod.Clear();

                }
                else
                {
                    MessageBox.Show("Produto não encontrado");
                    campoCod.Clear();
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                //formQtdProduto formQtd = new formQtdProduto();
                //formQtd.Show();
            }



        }

        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                somaTotal += valorProd[ind];
                lbl_valorTotal.Text = Convert.ToString(somaTotal);
                Itens_Venda.Items.Add(String.Format("{0} - {1} ({2})", nomeProd[ind], valorProd[ind]/*COLOCAR QUANTIDADE*/, quant));
                listBox1.Items.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que gostaria de finalizar?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string totalFinal = somaTotal.ToString();
                MessageBox.Show($"Venda finalizada com sucesso. Valor total de {totalFinal}", "Venda Finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                somaTotal = 0;
                listBox1.Items.Clear();
                lbl_valorTotal.Text = "0,00";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show(quant.ToString());
        }

        private void Itens_Venda_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Itens_Venda.Items.Remove(Itens_Venda.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
