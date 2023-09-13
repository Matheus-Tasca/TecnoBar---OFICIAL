
namespace TCC
{
    partial class formCaixa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Itens_Venda = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.campoCod = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_valorTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.campoCate = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(33, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(480, 264);
            this.listBox1.TabIndex = 0;
            // 
            // Itens_Venda
            // 
            this.Itens_Venda.FormattingEnabled = true;
            this.Itens_Venda.Location = new System.Drawing.Point(541, 17);
            this.Itens_Venda.Name = "Itens_Venda";
            this.Itens_Venda.Size = new System.Drawing.Size(209, 199);
            this.Itens_Venda.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.campoCate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.campoNome);
            this.groupBox1.Controls.Add(this.campoCod);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // campoNome
            // 
            this.campoNome.Location = new System.Drawing.Point(20, 44);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(100, 20);
            this.campoNome.TabIndex = 3;
            // 
            // campoCod
            // 
            this.campoCod.Location = new System.Drawing.Point(184, 44);
            this.campoCod.Name = "campoCod";
            this.campoCod.Size = new System.Drawing.Size(100, 20);
            this.campoCod.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_valorTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(541, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 65);
            this.panel1.TabIndex = 3;
            // 
            // lbl_valorTotal
            // 
            this.lbl_valorTotal.AutoSize = true;
            this.lbl_valorTotal.Location = new System.Drawing.Point(90, 21);
            this.lbl_valorTotal.Name = "lbl_valorTotal";
            this.lbl_valorTotal.Size = new System.Drawing.Size(35, 13);
            this.lbl_valorTotal.TabIndex = 1;
            this.lbl_valorTotal.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "R$";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(541, 293);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(96, 23);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(655, 293);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(541, 332);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(96, 23);
            this.btn_Adicionar.TabIndex = 6;
            this.btn_Adicionar.Text = "button3";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            // 
            // campoCate
            // 
            this.campoCate.FormattingEnabled = true;
            this.campoCate.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.campoCate.Location = new System.Drawing.Point(347, 44);
            this.campoCate.Name = "campoCate";
            this.campoCate.Size = new System.Drawing.Size(107, 21);
            this.campoCate.TabIndex = 9;
            // 
            // formCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 398);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Itens_Venda);
            this.Controls.Add(this.listBox1);
            this.Name = "formCaixa";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox Itens_Venda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.TextBox campoCod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_valorTotal;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.ComboBox campoCate;
    }
}

