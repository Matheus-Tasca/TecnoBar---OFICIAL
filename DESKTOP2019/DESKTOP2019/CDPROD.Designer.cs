
namespace DESKTOP2019
{
    partial class CDPROD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.campoCod = new System.Windows.Forms.TextBox();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.campoQTDInicio = new System.Windows.Forms.TextBox();
            this.campoVenda = new System.Windows.Forms.TextBox();
            this.campoQTDMinima = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.campoCusto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.listProd = new System.Windows.Forms.ListBox();
            this.campoCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNovaCate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // campoCod
            // 
            this.campoCod.Enabled = false;
            this.campoCod.Location = new System.Drawing.Point(24, 25);
            this.campoCod.Name = "campoCod";
            this.campoCod.Size = new System.Drawing.Size(63, 20);
            this.campoCod.TabIndex = 0;
            this.campoCod.TextChanged += new System.EventHandler(this.campoCod_TextChanged);
            // 
            // campoNome
            // 
            this.campoNome.Location = new System.Drawing.Point(24, 78);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(234, 20);
            this.campoNome.TabIndex = 1;
            // 
            // campoQTDInicio
            // 
            this.campoQTDInicio.Location = new System.Drawing.Point(9, 35);
            this.campoQTDInicio.Name = "campoQTDInicio";
            this.campoQTDInicio.Size = new System.Drawing.Size(104, 20);
            this.campoQTDInicio.TabIndex = 2;
            this.campoQTDInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoQTDInicio_KeyPress);
            // 
            // campoVenda
            // 
            this.campoVenda.Location = new System.Drawing.Point(183, 130);
            this.campoVenda.Name = "campoVenda";
            this.campoVenda.Size = new System.Drawing.Size(112, 20);
            this.campoVenda.TabIndex = 3;
            this.campoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoVenda_KeyPress);
            // 
            // campoQTDMinima
            // 
            this.campoQTDMinima.Location = new System.Drawing.Point(159, 35);
            this.campoQTDMinima.Name = "campoQTDMinima";
            this.campoQTDMinima.Size = new System.Drawing.Size(106, 20);
            this.campoQTDMinima.TabIndex = 4;
            this.campoQTDMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoQTDMinima_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor de Custo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor de Venda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantidade mínima ";
            // 
            // campoCusto
            // 
            this.campoCusto.Location = new System.Drawing.Point(24, 130);
            this.campoCusto.Name = "campoCusto";
            this.campoCusto.Size = new System.Drawing.Size(113, 20);
            this.campoCusto.TabIndex = 1;
            this.campoCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoCusto_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quantida inicial ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.campoQTDInicio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.campoQTDMinima);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(24, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 65);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estoque";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(24, 307);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(88, 23);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(130, 307);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(88, 23);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(235, 307);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 23);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Inativar";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(343, 307);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(446, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // listProd
            // 
            this.listProd.FormattingEnabled = true;
            this.listProd.Location = new System.Drawing.Point(311, 16);
            this.listProd.Name = "listProd";
            this.listProd.Size = new System.Drawing.Size(223, 264);
            this.listProd.TabIndex = 19;
            // 
            // campoCategoria
            // 
            this.campoCategoria.FormattingEnabled = true;
            this.campoCategoria.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.campoCategoria.Location = new System.Drawing.Point(24, 176);
            this.campoCategoria.Name = "campoCategoria";
            this.campoCategoria.Size = new System.Drawing.Size(194, 21);
            this.campoCategoria.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Categoria";
            // 
            // btnNovaCate
            // 
            this.btnNovaCate.Location = new System.Drawing.Point(224, 174);
            this.btnNovaCate.Name = "btnNovaCate";
            this.btnNovaCate.Size = new System.Drawing.Size(71, 23);
            this.btnNovaCate.TabIndex = 22;
            this.btnNovaCate.Text = "Nova";
            this.btnNovaCate.UseVisualStyleBackColor = true;
            // 
            // CDPROD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 362);
            this.Controls.Add(this.btnNovaCate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.campoCategoria);
            this.Controls.Add(this.listProd);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoVenda);
            this.Controls.Add(this.campoCusto);
            this.Controls.Add(this.campoNome);
            this.Controls.Add(this.campoCod);
            this.Name = "CDPROD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CDPROD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoCod;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.TextBox campoQTDInicio;
        private System.Windows.Forms.TextBox campoVenda;
        private System.Windows.Forms.TextBox campoQTDMinima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox campoCusto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox listProd;
        private System.Windows.Forms.ComboBox campoCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNovaCate;
    }
}