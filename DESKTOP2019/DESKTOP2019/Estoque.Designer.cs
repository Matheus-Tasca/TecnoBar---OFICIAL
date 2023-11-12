
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.campoFiltro = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.campoCod = new System.Windows.Forms.TextBox();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.campoAjuste = new System.Windows.Forms.GroupBox();
            this.campoQTDajust = new System.Windows.Forms.NumericUpDown();
            this.gridEstoque = new System.Windows.Forms.DataGridView();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.campoFiltro.SuspendLayout();
            this.campoAjuste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campoQTDajust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // campoFiltro
            // 
            this.campoFiltro.BackColor = System.Drawing.Color.Transparent;
            this.campoFiltro.Controls.Add(this.btnRecarregar);
            this.campoFiltro.Controls.Add(this.label2);
            this.campoFiltro.Controls.Add(this.label1);
            this.campoFiltro.Controls.Add(this.campoCod);
            this.campoFiltro.Controls.Add(this.campoNome);
            this.campoFiltro.Location = new System.Drawing.Point(12, 12);
            this.campoFiltro.Name = "campoFiltro";
            this.campoFiltro.Size = new System.Drawing.Size(549, 101);
            this.campoFiltro.TabIndex = 0;
            this.campoFiltro.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // campoCod
            // 
            this.campoCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCod.Location = new System.Drawing.Point(16, 47);
            this.campoCod.Name = "campoCod";
            this.campoCod.Size = new System.Drawing.Size(141, 22);
            this.campoCod.TabIndex = 2;
            this.campoCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressionouCod);
            // 
            // campoNome
            // 
            this.campoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNome.Location = new System.Drawing.Point(237, 47);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(141, 22);
            this.campoNome.TabIndex = 3;
            this.campoNome.TextChanged += new System.EventHandler(this.campoNome_TextChanged);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(16, 91);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(141, 30);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(362, 91);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(141, 31);
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
            this.btnRetirar.Location = new System.Drawing.Point(187, 91);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(141, 31);
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
            // campoAjuste
            // 
            this.campoAjuste.Controls.Add(this.campoQTDajust);
            this.campoAjuste.Controls.Add(this.btnInserir);
            this.campoAjuste.Controls.Add(this.btnTotal);
            this.campoAjuste.Controls.Add(this.btnRetirar);
            this.campoAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoAjuste.Location = new System.Drawing.Point(13, 455);
            this.campoAjuste.Name = "campoAjuste";
            this.campoAjuste.Size = new System.Drawing.Size(549, 138);
            this.campoAjuste.TabIndex = 12;
            this.campoAjuste.TabStop = false;
            this.campoAjuste.Text = "Ajuste de Estoque";
            // 
            // campoQTDajust
            // 
            this.campoQTDajust.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoQTDajust.Location = new System.Drawing.Point(172, 37);
            this.campoQTDajust.Name = "campoQTDajust";
            this.campoQTDajust.Size = new System.Drawing.Size(176, 28);
            this.campoQTDajust.TabIndex = 12;
            // 
            // gridEstoque
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridEstoque.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridEstoque.Location = new System.Drawing.Point(12, 119);
            this.gridEstoque.Name = "gridEstoque";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridEstoque.Size = new System.Drawing.Size(550, 319);
            this.gridEstoque.TabIndex = 12;
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Location = new System.Drawing.Point(445, 35);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(74, 34);
            this.btnRecarregar.TabIndex = 6;
            this.btnRecarregar.Text = "Recarregar";
            this.btnRecarregar.UseVisualStyleBackColor = true;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 615);
            this.Controls.Add(this.gridEstoque);
            this.Controls.Add(this.campoAjuste);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoFiltro);
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.campoFiltro.ResumeLayout(false);
            this.campoFiltro.PerformLayout();
            this.campoAjuste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.campoQTDajust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox campoFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campoCod;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox campoAjuste;
        private System.Windows.Forms.DataGridView gridEstoque;
        private System.Windows.Forms.NumericUpDown campoQTDajust;
        private System.Windows.Forms.Button btnRecarregar;
    }
}