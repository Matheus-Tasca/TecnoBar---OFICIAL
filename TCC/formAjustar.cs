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
    public partial class formAjustar : Form
    {
        public formAjustar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Você tem certeza que deseja definir para {campoAjustar.Value} a quantidade total do seu estoque?", "Confirmação de ajuste do estoque", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //ajusta no banco
            }
        }
    }
}
