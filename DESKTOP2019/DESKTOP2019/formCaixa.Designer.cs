
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
            this.grpFiltrar.Location = new System.Drawing.Point(16, 34);
            this.grpFiltrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFiltrar.Name = "grpFiltrar";
            this.grpFiltrar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFiltrar.Size = new System.Drawing.Size(536, 488);
            this.grpFiltrar.TabIndex = 0;
            this.grpFiltrar.TabStop = false;
            this.grpFiltrar.Text = "Filtrar produtos";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Location = new System.Drawing.Point(33, 197);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(179, 26);
            this.txtCategoria.TabIndex = 13;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProduto.Location = new System.Drawing.Point(33, 362);
            this.btnAdicionarProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(421, 64);
            this.btnAdicionarProduto.TabIndex = 12;
            this.btnAdicionarProduto.Text = "Adicionar produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(272, 96);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(164, 26);
            this.txtQuantidade.TabIndex = 11;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.textChangedQuantidade);
            this.txtQuantidade.Enter += new System.EventHandler(this.EnterCampoQuantidade);
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterQuantidadeItem);
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            this.txtQuantidade.Leave += new System.EventHandler(this.LeaveCampoQuantidade);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(268, 53);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(135, 19);
            this.lblQuantidade.TabIndex = 10;
            this.lblQuantidade.Text = "Quantidade do item";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(377, 320);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(62, 19);
            this.lblValorTotal.TabIndex = 9;
            this.lblValorTotal.Text = "R$ 0,00";
            // 
            // lblValorTotalTitulo
            // 
            this.lblValorTotalTitulo.AutoSize = true;
            this.lblValorTotalTitulo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalTitulo.Location = new System.Drawing.Point(377, 276);
            this.lblValorTotalTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotalTitulo.Name = "lblValorTotalTitulo";
            this.lblValorTotalTitulo.Size = new System.Drawing.Size(81, 19);
            this.lblValorTotalTitulo.TabIndex = 8;
            this.lblValorTotalTitulo.Text = "Valor Total";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(29, 158);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(68, 19);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorUnitario.Location = new System.Drawing.Point(39, 320);
            this.lblValorUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(62, 19);
            this.lblValorUnitario.TabIndex = 5;
            this.lblValorUnitario.Text = "R$ 0,00";
            // 
            // lblValorUnitarioTitulo
            // 
            this.lblValorUnitarioTitulo.AutoSize = true;
            this.lblValorUnitarioTitulo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorUnitarioTitulo.Location = new System.Drawing.Point(29, 276);
            this.lblValorUnitarioTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorUnitarioTitulo.Name = "lblValorUnitarioTitulo";
            this.lblValorUnitarioTitulo.Size = new System.Drawing.Size(99, 19);
            this.lblValorUnitarioTitulo.TabIndex = 4;
            this.lblValorUnitarioTitulo.Text = "Valor Unitário";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.Location = new System.Drawing.Point(272, 197);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(179, 26);
            this.txtNomeProduto.TabIndex = 3;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(268, 158);
            this.lblNomeProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(44, 19);
            this.lblNomeProduto.TabIndex = 2;
            this.lblNomeProduto.Text = "Nome";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(33, 96);
            this.txtCodigoProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(179, 26);
            this.txtCodigoProduto.TabIndex = 1;
            this.txtCodigoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressionaEnter);
            this.txtCodigoProduto.Leave += new System.EventHandler(this.mudaCampoCodigo);
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProduto.Location = new System.Drawing.Point(29, 53);
            this.lblCodigoProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(125, 19);
            this.lblCodigoProduto.TabIndex = 0;
            this.lblCodigoProduto.Text = "Codigo do produto";
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenda.Location = new System.Drawing.Point(560, 576);
            this.btnCancelarVenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(241, 64);
            this.btnCancelarVenda.TabIndex = 13;
            this.btnCancelarVenda.Text = "Cancelar Venda";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.cmdCancelarVenda);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.Location = new System.Drawing.Point(809, 576);
            this.btnFinalizarVenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(241, 64);
            this.btnFinalizarVenda.TabIndex = 14;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.finalizaVenda);
            // 
            // listBoxProdutos
            // 
            this.listBoxProdutos.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProdutos.FormattingEnabled = true;
            this.listBoxProdutos.ItemHeight = 30;
            this.listBoxProdutos.Location = new System.Drawing.Point(560, 47);
            this.listBoxProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxProdutos.Name = "listBoxProdutos";
            this.listBoxProdutos.Size = new System.Drawing.Size(489, 394);
            this.listBoxProdutos.TabIndex = 15;
            this.listBoxProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.deletarItemVenda);
            // 
            // lblSubTotalTitulo
            // 
            this.lblSubTotalTitulo.AutoSize = true;
            this.lblSubTotalTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalTitulo.Location = new System.Drawing.Point(581, 503);
            this.lblSubTotalTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotalTitulo.Name = "lblSubTotalTitulo";
            this.lblSubTotalTitulo.Size = new System.Drawing.Size(126, 25);
            this.lblSubTotalTitulo.TabIndex = 16;
            this.lblSubTotalTitulo.Text = "SUBTOTAL:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(891, 503);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(0, 25);
            this.lblSubTotal.TabIndex = 17;
            // 
            // formCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblSubTotalTitulo);
            this.Controls.Add(this.listBoxProdutos);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.grpFiltrar);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
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