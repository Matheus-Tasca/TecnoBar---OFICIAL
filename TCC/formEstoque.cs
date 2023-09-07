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

namespace TCC
{
    public partial class formEstoque : Form
    {
        MySqlConnection con;
        DataSet dsEstoque;
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

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                String qryBusca = "select * from produto";
                String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                using (con = new MySqlConnection(conString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(qryBusca, con);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd); //Esse e data set funcionam para armazenar os dados que vem do sql
                    dsEstoque = new DataSet();
                    da.Fill(dsEstoque, "Estoque"); // aqui é colocado em uma tabela os dados pegos (a tabela recebe o nome de Estoque)
                    DataTable dtEstoque = dsEstoque.Tables["Estoque"];

                    listProd.DisplayMember = dtEstoque.Columns["nomeProd"].ColumnName; //O display é para mostrar na tela
                   // listProd.DisplayMember = dtEstoque.Columns["codProd"].ColumnName;
                    listProd.ValueMember = dtEstoque.Columns["codProd"].ColumnName; //O value é o que ele guardará como informação daquele item

                    listProd.DataSource = dtEstoque;
                }
            }   
            catch (MySqlException ex)
            {
                MessageBox.Show("Falha ao tentar conectar com o BD!\n" + ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Falha geral do sistema!");
            }
        }                            
    }
}
