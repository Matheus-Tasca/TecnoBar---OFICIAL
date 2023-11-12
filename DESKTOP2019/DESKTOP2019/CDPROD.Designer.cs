
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNovaCate = new System.Windows.Forms.Button();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.campoCategoria = new System.Windows.Forms.ComboBox();
            this.gridProd = new System.Windows.Forms.DataGridView();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProd)).BeginInit();
            this.SuspendLayout();
            // 
            // campoCod
            // 
            this.campoCod.Enabled = false;
            this.campoCod.Location = new System.Drawing.Point(32, 37);
            this.campoCod.Margin = new System.Windows.Forms.Padding(4);
            this.campoCod.Name = "campoCod";
            this.campoCod.Size = new System.Drawing.Size(83, 26);
            this.campoCod.TabIndex = 0;
            // 
            // campoNome
            // 
            this.campoNome.Location = new System.Drawing.Point(32, 114);
            this.campoNome.Margin = new System.Windows.Forms.Padding(4);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(360, 26);
            this.campoNome.TabIndex = 1;
            // 
            // campoQTDInicio
            // 
            this.campoQTDInicio.Location = new System.Drawing.Point(12, 79);
            this.campoQTDInicio.Margin = new System.Windows.Forms.Padding(4);
            this.campoQTDInicio.Name = "campoQTDInicio";
            this.campoQTDInicio.Size = new System.Drawing.Size(137, 26);
            this.campoQTDInicio.TabIndex = 2;
            this.campoQTDInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoQTDInicio_KeyPress);
            // 
            // campoVenda
            // 
            this.campoVenda.Location = new System.Drawing.Point(244, 209);
            this.campoVenda.Margin = new System.Windows.Forms.Padding(4);
            this.campoVenda.Name = "campoVenda";
            this.campoVenda.Size = new System.Drawing.Size(148, 26);
            this.campoVenda.TabIndex = 3;
            this.campoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoVenda_KeyPress);
            // 
            // campoQTDMinima
            // 
            this.campoQTDMinima.Location = new System.Drawing.Point(212, 79);
            this.campoQTDMinima.Margin = new System.Windows.Forms.Padding(4);
            this.campoQTDMinima.Name = "campoQTDMinima";
            this.campoQTDMinima.Size = new System.Drawing.Size(140, 26);
            this.campoQTDMinima.TabIndex = 4;
            this.campoQTDMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoQTDMinima_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor de Custo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor de Venda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantidade mínima ";
            // 
            // campoCusto
            // 
            this.campoCusto.Location = new System.Drawing.Point(32, 209);
            this.campoCusto.Margin = new System.Windows.Forms.Padding(4);
            this.campoCusto.Name = "campoCusto";
            this.campoCusto.Size = new System.Drawing.Size(149, 26);
            this.campoCusto.TabIndex = 1;
            this.campoCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoCusto_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quantidade Atual";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.campoQTDInicio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.campoQTDMinima);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(32, 351);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(361, 124);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estoque";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(32, 484);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(163, 50);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(231, 484);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(163, 50);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(32, 564);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(163, 50);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(231, 564);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 50);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 269);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Categoria";
            // 
            // btnNovaCate
            // 
            this.btnNovaCate.Location = new System.Drawing.Point(299, 289);
            this.btnNovaCate.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovaCate.Name = "btnNovaCate";
            this.btnNovaCate.Size = new System.Drawing.Size(95, 34);
            this.btnNovaCate.TabIndex = 22;
            this.btnNovaCate.Text = "Nova";
            this.btnNovaCate.UseVisualStyleBackColor = true;
            this.btnNovaCate.Click += new System.EventHandler(this.btnNovaCate_Click);
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Checked = true;
            this.cbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivo.Location = new System.Drawing.Point(277, 37);
            this.cbAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(61, 23);
            this.cbAtivo.TabIndex = 23;
            this.cbAtivo.Text = "Ativo";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // campoCategoria
            // 
            this.campoCategoria.FormattingEnabled = true;
            this.campoCategoria.Location = new System.Drawing.Point(32, 292);
            this.campoCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.campoCategoria.Name = "campoCategoria";
            this.campoCategoria.Size = new System.Drawing.Size(257, 27);
            this.campoCategoria.TabIndex = 24;
            this.campoCategoria.SelectedIndexChanged += new System.EventHandler(this.campoCategoria_SelectedIndexChanged);
            // 
            // gridProd
            // 
            this.gridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProd.Location = new System.Drawing.Point(425, 75);
            this.gridProd.Margin = new System.Windows.Forms.Padding(4);
            this.gridProd.Name = "gridProd";
            this.gridProd.Size = new System.Drawing.Size(471, 539);
            this.gridProd.TabIndex = 25;
            this.gridProd.SelectionChanged += new System.EventHandler(this.gridProd_SelectedIndexChanged);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(425, 37);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(239, 26);
            this.txtBusca.TabIndex = 26;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Buscar Nome";
            // 
            // CDPROD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 643);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.gridProd);
            this.Controls.Add(this.campoCategoria);
            this.Controls.Add(this.cbAtivo);
            this.Controls.Add(this.btnNovaCate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
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
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CDPROD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.CDPROD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProd)).EndInit();
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
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNovaCate;
        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.ComboBox campoCategoria;
        private System.Windows.Forms.DataGridView gridProd;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label7;
    }
}