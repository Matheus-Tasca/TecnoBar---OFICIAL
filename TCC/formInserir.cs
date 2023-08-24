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
    public partial class formInserir : Form
    {
        public formInserir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (campoInserir.Value > 0)
            {
                MessageBox.Show("Foi para o banco");
                //banco
            }
            else {
                MessageBox.Show("A quantidade precisa ser maior que zero", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                       
        }
    }
}
