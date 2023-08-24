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
    public partial class formEstoque : Form
    {
        public formEstoque()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            formInserir formInserir = new formInserir();
            formInserir.Show();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            formRetirar formRetirar = new formRetirar();
            formRetirar.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            formConsulta formConsulta = new formConsulta();
            formConsulta.Show();
        }

        private void btnAjustar_Click(object sender, EventArgs e)
        {
            formAjustar formAjustar = new formAjustar();
            formAjustar.Show();
        }
    }
}
