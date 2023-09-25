
namespace DESKTOP2019
{
    partial class formCaixa
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
            this.grpFiltrar = new System.Windows.Forms.GroupBox();
            this.lblValorUnitarioTitulo = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblValorTotalTitulo = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.listBoxProdutos = new System.Windows.Forms.ListBox();
            this.lblSubTotalTitulo = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.grpFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFiltrar
            // 
            this.grpFiltrar.Controls.Add(this.btnAdicionarProduto);
            this.grpFiltrar.Controls.Add(this.textBox2);
            this.grpFiltrar.Controls.Add(this.lblQuantidade);
            this.grpFiltrar.Controls.Add(this.lblValorTotal);
            this.grpFiltrar.Controls.Add(this.lblValorTotalTitulo);
            this.grpFiltrar.Controls.Add(this.comboBox1);
            this.grpFiltrar.Controls.Add(this.lblCategoria);
            this.grpFiltrar.Controls.Add(this.label1);
            this.grpFiltrar.Controls.Add(this.lblValorUnitarioTitulo);
            this.grpFiltrar.Controls.Add(this.txtNomeProduto);
            this.grpFiltrar.Controls.Add(this.lblNomeProduto);
            this.grpFiltrar.Controls.Add(this.textBox1);
            this.grpFiltrar.Controls.Add(this.lblCodigoBarras);
            this.grpFiltrar.Location = new System.Drawing.Point(12, 23);
            this.grpFiltrar.Name = "grpFiltrar";
            this.grpFiltrar.Size = new System.Drawing.Size(402, 334);
            this.grpFiltrar.TabIndex = 0;
            this.grpFiltrar.TabStop = false;
            this.grpFiltrar.Text = "Filtrar produtos";
            this.grpFiltrar.Enter += new System.EventHandler(this.grpFiltrar_Enter);
            // 
            // lblValorUnitarioTitulo
            // 
            this.lblValorUnitarioTitulo.AutoSize = true;
            this.lblValorUnitarioTitulo.Location = new System.Drawing.Point(22, 189);
            this.lblValorUnitarioTitulo.Name = "lblValorUnitarioTitulo";
            this.lblValorUnitarioTitulo.Size = new System.Drawing.Size(70, 13);
            this.lblValorUnitarioTitulo.TabIndex = 4;
            this.lblValorUnitarioTitulo.Text = "Valor Unitário";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(206, 66);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(135, 20);
            this.txtNomeProduto.TabIndex = 3;
            this.txtNomeProduto.TextChanged += new System.EventHandler(this.txtNomeProduto_TextChanged);
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(203, 36);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(35, 13);
            this.lblNomeProduto.TabIndex = 2;
            this.lblNomeProduto.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Location = new System.Drawing.Point(22, 36);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(87, 13);
            this.lblCodigoBarras.TabIndex = 0;
            this.lblCodigoBarras.Text = "Codigo de barras";
            this.lblCodigoBarras.Click += new System.EventHandler(this.lblCodigoBarras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "R$ 0,00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(22, 108);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.Click += new System.EventHandler(this.lblCategoria_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // lblValorTotalTitulo
            // 
            this.lblValorTotalTitulo.AutoSize = true;
            this.lblValorTotalTitulo.Location = new System.Drawing.Point(283, 189);
            this.lblValorTotalTitulo.Name = "lblValorTotalTitulo";
            this.lblValorTotalTitulo.Size = new System.Drawing.Size(58, 13);
            this.lblValorTotalTitulo.TabIndex = 8;
            this.lblValorTotalTitulo.Text = "Valor Total";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(283, 219);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(45, 13);
            this.lblValorTotal.TabIndex = 9;
            this.lblValorTotal.Text = "R$ 0,00";
            this.lblValorTotal.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(203, 105);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(99, 13);
            this.lblQuantidade.TabIndex = 10;
            this.lblQuantidade.Text = "Quantidade do item";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(206, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 20);
            this.textBox2.TabIndex = 11;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(25, 248);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(316, 44);
            this.btnAdicionarProduto.TabIndex = 12;
            this.btnAdicionarProduto.Text = "Adicionar produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Location = new System.Drawing.Point(420, 394);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(181, 44);
            this.btnCancelarVenda.TabIndex = 13;
            this.btnCancelarVenda.Text = "Cancelar Venda";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Location = new System.Drawing.Point(607, 394);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(181, 44);
            this.btnFinalizarVenda.TabIndex = 14;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            // 
            // listBoxProdutos
            // 
            this.listBoxProdutos.FormattingEnabled = true;
            this.listBoxProdutos.Location = new System.Drawing.Point(420, 32);
            this.listBoxProdutos.Name = "listBoxProdutos";
            this.listBoxProdutos.Size = new System.Drawing.Size(368, 290);
            this.listBoxProdutos.TabIndex = 15;
            // 
            // lblSubTotalTitulo
            // 
            this.lblSubTotalTitulo.AutoSize = true;
            this.lblSubTotalTitulo.Location = new System.Drawing.Point(436, 344);
            this.lblSubTotalTitulo.Name = "lblSubTotalTitulo";
            this.lblSubTotalTitulo.Size = new System.Drawing.Size(67, 13);
            this.lblSubTotalTitulo.TabIndex = 16;
            this.lblSubTotalTitulo.Text = "SUBTOTAL:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(668, 344);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(0, 13);
            this.lblSubTotal.TabIndex = 17;
            // 
            // formCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblSubTotalTitulo);
            this.Controls.Add(this.listBoxProdutos);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.grpFiltrar);
            this.Name = "formCaixa";
            this.Text = "formCaixa";
            this.grpFiltrar.ResumeLayout(false);
            this.grpFiltrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltrar;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblValorUnitarioTitulo;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblValorTotalTitulo;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.ListBox listBoxProdutos;
        private System.Windows.Forms.Label lblSubTotalTitulo;
        private System.Windows.Forms.Label lblSubTotal;
    }
}