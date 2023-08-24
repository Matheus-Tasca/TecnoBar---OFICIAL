namespace TCC
{
    partial class formMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            btnCaixa = new Button();
            btnProduto = new Button();
            btnEstoque = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnCaixa
            // 
            btnCaixa.BackColor = SystemColors.ButtonFace;
            btnCaixa.BackgroundImageLayout = ImageLayout.Center;
            btnCaixa.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCaixa.ForeColor = SystemColors.ActiveCaptionText;
            btnCaixa.Image = Properties.Resources.caixa_eletronico1;
            btnCaixa.Location = new Point(29, 32);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(83, 107);
            btnCaixa.TabIndex = 0;
            btnCaixa.Text = "Caixa";
            btnCaixa.TextAlign = ContentAlignment.BottomCenter;
            btnCaixa.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCaixa.UseVisualStyleBackColor = false;
            btnCaixa.Click += button1_Click;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = SystemColors.ButtonFace;
            btnProduto.BackgroundImageLayout = ImageLayout.Center;
            btnProduto.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProduto.ForeColor = SystemColors.ActiveCaptionText;
            btnProduto.Image = (Image)resources.GetObject("btnProduto.Image");
            btnProduto.Location = new Point(139, 32);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(93, 107);
            btnProduto.TabIndex = 1;
            btnProduto.Text = "C. Produto";
            btnProduto.TextAlign = ContentAlignment.BottomCenter;
            btnProduto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += button1_Click_1;
            // 
            // btnEstoque
            // 
            btnEstoque.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEstoque.ForeColor = SystemColors.ActiveCaptionText;
            btnEstoque.Image = (Image)resources.GetObject("btnEstoque.Image");
            btnEstoque.ImageAlign = ContentAlignment.TopCenter;
            btnEstoque.Location = new Point(263, 32);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(83, 107);
            btnEstoque.TabIndex = 2;
            btnEstoque.Text = "Estoque";
            btnEstoque.TextAlign = ContentAlignment.BottomCenter;
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(380, 32);
            button1.Name = "button1";
            button1.Size = new Size(83, 107);
            button1.TabIndex = 3;
            button1.Text = "Sair";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // formMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(546, 298);
            Controls.Add(button1);
            Controls.Add(btnEstoque);
            Controls.Add(btnProduto);
            Controls.Add(btnCaixa);
            Name = "formMenu";
            Text = "Form2";
            Load += formMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCaixa;
        private Button btnProduto;
        private Button btnEstoque;
        private Button button1;
    }
}