
namespace DESKTOP2019
{
    partial class Estoque
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
            this.campoFiltro = new System.Windows.Forms.GroupBox();
            this.campoCate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.campoCod = new System.Windows.Forms.TextBox();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.listaEst = new System.Windows.Forms.ListBox();
            this.campoQTDajust = new System.Windows.Forms.NumericUpDown();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.campoAjuste = new System.Windows.Forms.GroupBox();
            this.campoFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campoQTDajust)).BeginInit();
            this.campoAjuste.SuspendLayout();
            this.SuspendLayout();
            // 
            // campoFiltro
            // 
            this.campoFiltro.BackColor = System.Drawing.Color.Transparent;
            this.campoFiltro.Controls.Add(this.campoCate);
            this.campoFiltro.Controls.Add(this.label3);
            this.campoFiltro.Controls.Add(this.label2);
            this.campoFiltro.Controls.Add(this.label1);
            this.campoFiltro.Controls.Add(this.campoCod);
            this.campoFiltro.Controls.Add(this.campoNome);
            this.campoFiltro.Location = new System.Drawing.Point(12, 12);
            this.campoFiltro.Name = "campoFiltro";
            this.campoFiltro.Size = new System.Drawing.Size(519, 101);
            this.campoFiltro.TabIndex = 0;
            this.campoFiltro.TabStop = false;
            // 
            // campoCate
            // 
            this.campoCate.FormattingEnabled = true;
            this.campoCate.Location = new System.Drawing.Point(362, 47);
            this.campoCate.Name = "campoCate";
            this.campoCate.Size = new System.Drawing.Size(141, 21);
            this.campoCate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // campoCod
            // 
            this.campoCod.Location = new System.Drawing.Point(16, 47);
            this.campoCod.Name = "campoCod";
            this.campoCod.Size = new System.Drawing.Size(141, 20);
            this.campoCod.TabIndex = 2;
            this.campoCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressionouCod);
            // 
            // campoNome
            // 
            this.campoNome.Location = new System.Drawing.Point(187, 47);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(141, 20);
            this.campoNome.TabIndex = 3;
            this.campoNome.TextChanged += new System.EventHandler(this.buscaNome);
            // 
            // listaEst
            // 
            this.listaEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaEst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listaEst.FormattingEnabled = true;
            this.listaEst.ItemHeight = 25;
            this.listaEst.Location = new System.Drawing.Point(11, 131);
            this.listaEst.Name = "listaEst";
            this.listaEst.Size = new System.Drawing.Size(520, 229);
            this.listaEst.TabIndex = 1;
            // 
            // campoQTDajust
            // 
            this.campoQTDajust.Location = new System.Drawing.Point(140, 33);
            this.campoQTDajust.Name = "campoQTDajust";
            this.campoQTDajust.Size = new System.Drawing.Size(222, 20);
            this.campoQTDajust.TabIndex = 3;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(16, 71);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(141, 23);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(371, 70);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(141, 23);
            this.btnTotal.TabIndex = 5;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRetirar.FlatAppearance.BorderSize = 0;
            this.btnRetirar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnRetirar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnRetirar.Location = new System.Drawing.Point(187, 70);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(141, 23);
            this.btnRetirar.TabIndex = 6;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "Quantidade a ser ajustada";
            // 
            // campoAjuste
            // 
            this.campoAjuste.Controls.Add(this.campoQTDajust);
            this.campoAjuste.Controls.Add(this.label6);
            this.campoAjuste.Controls.Add(this.btnInserir);
            this.campoAjuste.Controls.Add(this.btnTotal);
            this.campoAjuste.Controls.Add(this.btnRetirar);
            this.campoAjuste.Location = new System.Drawing.Point(12, 374);
            this.campoAjuste.Name = "campoAjuste";
            this.campoAjuste.Size = new System.Drawing.Size(519, 100);
            this.campoAjuste.TabIndex = 12;
            this.campoAjuste.TabStop = false;
            this.campoAjuste.Text = "Ajuste de Estoque";
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 486);
            this.Controls.Add(this.campoAjuste);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listaEst);
            this.Controls.Add(this.campoFiltro);
            this.Name = "Estoque";
            this.Text = "Estoque";
            this.campoFiltro.ResumeLayout(false);
            this.campoFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campoQTDajust)).EndInit();
            this.campoAjuste.ResumeLayout(false);
            this.campoAjuste.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox campoFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campoCod;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.ListBox listaEst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox campoCate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown campoQTDajust;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox campoAjuste;
    }
}