using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESKTOP2019
{
    public partial class AddCategoria : Form
    {
        MySqlConnection connection;
        public AddCategoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int linhasAfetadas = 0;
            string stringconnection = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; //trago os dados
            string qryInsCat = "Insert into categoria (nomeCategoria) values (@categoria)"; //crio a query
            using(connection = new MySqlConnection(stringconnection)) //stabeleço a conexão com o banco
            {
                connection.Open(); //abre conexão com banco
                MySqlCommand comand = new MySqlCommand(qryInsCat, connection); //onde vc vai e o que vai fazer
                comand.Parameters.AddWithValue("@categoria", campoCate.Text); // setando os valores da query

                linhasAfetadas = comand.ExecuteNonQuery(); // não sei mas é importante

                connection.Close(); //fecha conexão

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Categoria inserida com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao inserir a categoria.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
        }
    }
}
