using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESKTOP2019
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.MdiParent = this;
            estoque.Show();
        }

        private void pDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCaixa formCaixa = new formCaixa();
            formCaixa.MdiParent = this;
            formCaixa.Show();
        }

        private void cadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CDPROD cadastro = new CDPROD();
            cadastro.MdiParent = this;
            cadastro.Show();
        }
    }
}
