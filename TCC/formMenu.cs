using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
            BackColor = ColorTranslator.FromHtml("#252B48");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            formCaixa formCaixa = new formCaixa();
            formCaixa.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // this.Close();
            formProduto formProduto = new formProduto();
            formProduto.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            formEstoque formEstoque = new formEstoque();
            formEstoque.Show();
            //this.close();
        }

        private void formMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
