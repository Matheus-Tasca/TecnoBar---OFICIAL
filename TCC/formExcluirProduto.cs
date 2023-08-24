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
    public partial class formExlcuirProduto : Form
    {
        public formExlcuirProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem certeza que deseja excluir o produto O QUE ESTIVER SELECIONADO? Está ação será irreversível", "ATENÇÃO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}
