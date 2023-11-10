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
    public partial class frmConcluirVenda : Form
    {
        public frmConcluirVenda(double valorTotal)
        {
            InitializeComponent();
            getValorTotal = valorTotal;
            txtBoxTotalPagar.Text = "R$: " + (getValorTotal).ToString();
           
    }
        public frmConcluirVenda()
        {
            InitializeComponent();
        }

        public double getValorTotal { get; set; }
        public double valorEmDinheiro;
        public double valorPix;
        double desconto;
        double valorInicial;

        public void calcularTrocoPix()
        {
            valorInicial = getValorTotal;
            if (double.TryParse(txtBoxPix.Text, out valorPix))
            {
                if (valorPix > 0)
                {
                    double troco = (valorPix + valorEmDinheiro) - (valorInicial-desconto);
                    if (troco < 0)
                    {
                        lblTrocoValor.Text = "R$ 0,00";
                    }
                    else
                    {
                        lblTrocoValor.Text = "R$" + troco.ToString();
                    }
                }
            }
        }

        public void calcularTrocoDinheiro()
        {
            valorInicial = getValorTotal;
            if (double.TryParse(txtBoxDinheiro.Text, out valorEmDinheiro))
            {
                if (valorEmDinheiro > 0)
                {
                    double troco = (valorPix + valorEmDinheiro) - (valorInicial - desconto);
                    if (troco < 0)
                    {
                        lblTrocoValor.Text = "R$ 0,00";
                    }
                    else
                    {
                        lblTrocoValor.Text = "R$" + troco.ToString();
                    }
                }
            }
        }

        private void digitarValorDinheiro(object sender, EventArgs e)
        {
            calcularTrocoDinheiro();
        }

        private void digitarValorPix(object sender, EventArgs e)
        {
            calcularTrocoPix();
        }

        private void inserirDesconto(object sender, EventArgs e)
        {
            
        }

        private void digitarDesconto(object sender, EventArgs e)
        {
            if (double.TryParse(txtBoxDesconto.Text, out desconto))
            {
                if(txtBoxDesconto.Text != "")
                {
                    txtBoxTotalPagar.Text = "R$: " + (getValorTotal - desconto).ToString();
                }
            }
        }

        private void digitarValorPix_Leave(object sender, EventArgs e)
        {
            calcularTrocoPix();
        }

        private void digitarValorPix_Enter(object sender, EventArgs e)
        {
            calcularTrocoPix();
        }

        private void digitarValorDinheiro_Enter(object sender, EventArgs e)
        {
            calcularTrocoDinheiro();
        }
    }
}


