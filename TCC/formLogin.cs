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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((campoPassword.Text == "1234") && (campoUser.Text == "joao"))
            {
                formMenu formMenu = new formMenu();
                formMenu.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos", "Cadastro não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
