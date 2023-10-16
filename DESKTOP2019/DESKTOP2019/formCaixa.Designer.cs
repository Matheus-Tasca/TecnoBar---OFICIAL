
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
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblValorTotalTitulo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.lblValorUnitarioTitulo = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
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
            this.grpFiltrar.Controls.Add(this.txtCategoria);
            this.grpFiltrar.Controls.Add(this.btnAdicionarProduto);
            this.grpFiltrar.Controls.Add(this.txtQuantidade);
            this.grpFiltrar.Controls.Add(this.lblQuantidade);
            this.grpFiltrar.Controls.Add(this.lblValorTotal);
            this.grpFiltrar.Controls.Add(this.lblValorTotalTitulo);
            this.grpFiltrar.Controls.Add(this.lblCategoria);
            this.grpFiltrar.Controls.Add(this.lblValorUnitario);
            this.grpFiltrar.Controls.Add(this.lblValorUnitarioTitulo);
            this.grpFiltrar.Controls.Add(this.txtNomeProduto);
            this.grpFiltrar.Controls.Add(this.lblNomeProduto);
            this.grpFiltrar.Controls.Add(this.txtCodigoProduto);
            this.grpFiltrar.Controls.Add(this.lblCodigoProduto);
            this.grpFiltrar.Location = new System.Drawing.Point(12, 23);
            this.grpFiltrar.Name = "grpFiltrar";
            this.grpFiltrar.Size = new System.Drawing.Size(402, 334);
            this.grpFiltrar.TabIndex = 0;
            this.grpFiltrar.TabStop = false;
            this.grpFiltrar.Text = "Filtrar produtos";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(25, 135);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(135, 20);
            this.txtCategoria.TabIndex = 13;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(25, 248);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(316, 44);
            this.btnAdicionarProduto.TabIndex = 12;
            this.btnAdicionarProduto.Text = "Adicionar produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(204, 66);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(124, 20);
            this.txtQuantidade.TabIndex = 11;
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterQuantidadeItem);
            this.txtQuantidade.Leave += new System.EventHandler(this.LeaveCampoQuantidade);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(201, 36);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(99, 13);
            this.lblQuantidade.TabIndex = 10;
            this.lblQuantidade.Text = "Quantidade do item";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(283, 219);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(45, 13);
            this.lblValorTotal.TabIndex = 9;
            this.lblValorTotal.Text = "R$ 0,00";
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
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(22, 108);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(29, 219);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(45, 13);
            this.lblValorUnitario.TabIndex = 5;
            this.lblValorUnitario.Text = "R$ 0,00";
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
            this.txtNomeProduto.Location = new System.Drawing.Point(204, 135);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(135, 20);
            this.txtNomeProduto.TabIndex = 3;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(201, 108);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(35, 13);
            this.lblNomeProduto.TabIndex = 2;
            this.lblNomeProduto.Text = "Nome";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(25, 66);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(135, 20);
            this.txtCodigoProduto.TabIndex = 1;
            this.txtCodigoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionaEnter);
            this.txtCodigoProduto.Leave += new System.EventHandler(this.mudaCampoCodigo);
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(22, 36);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(94, 13);
            this.lblCodigoProduto.TabIndex = 0;
            this.lblCodigoProduto.Text = "Codigo do produto";
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
            this.listBoxProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProdutos.FormattingEnabled = true;
            this.listBoxProdutos.ItemHeight = 20;
            this.listBoxProdutos.Location = new System.Drawing.Point(420, 32);
            this.listBoxProdutos.Name = "listBoxProdutos";
            this.listBoxProdutos.Size = new System.Drawing.Size(368, 284);
            this.listBoxProdutos.TabIndex = 15;
            // 
            // lblSubTotalTitulo
            // 
            this.lblSubTotalTitulo.AutoSize = true;
            this.lblSubTotalTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalTitulo.Location = new System.Drawing.Point(436, 344);
            this.lblSubTotalTitulo.Name = "lblSubTotalTitulo";
            this.lblSubTotalTitulo.Size = new System.Drawing.Size(126, 25);
            this.lblSubTotalTitulo.TabIndex = 16;
            this.lblSubTotalTitulo.Text = "SUBTOTAL:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(668, 344);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(0, 25);
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
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label lblValorUnitarioTitulo;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblValorTotalTitulo;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.ListBox listBoxProdutos;
        private System.Windows.Forms.Label lblSubTotalTitulo;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtCategoria;
    }
}