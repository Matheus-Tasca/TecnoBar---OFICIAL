﻿using System;
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
    public partial class formQtdProduto : Form
    {
        public formQtdProduto()
        {
            InitializeComponent();
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e, formCaixa fc)
        {
            fc.quant = campoQtd.Value;
        }
    }
}
