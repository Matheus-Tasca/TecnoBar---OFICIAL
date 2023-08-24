﻿namespace TCC
{
    partial class formProduto
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
            lblNome = new Label();
            campoNome = new TextBox();
            lblCateg = new Label();
            campoCod = new TextBox();
            label1 = new Label();
            campoCate = new ComboBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            campoPreco = new TextBox();
            label2 = new Label();
            button1 = new Button();
            pb_Imagem = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            btnExcluir = new Button();
            openFileDialog1 = new OpenFileDialog();
            campoCusto = new TextBox();
            label3 = new Label();
            campoQtdE = new TextBox();
            label4 = new Label();
            campoQtdMin = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pb_Imagem).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(21, 64);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(39, 14);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // campoNome
            // 
            campoNome.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            campoNome.Location = new Point(21, 81);
            campoNome.MaximumSize = new Size(340, 38);
            campoNome.Multiline = true;
            campoNome.Name = "campoNome";
            campoNome.Size = new Size(320, 26);
            campoNome.TabIndex = 2;
            // 
            // lblCateg
            // 
            lblCateg.AutoSize = true;
            lblCateg.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCateg.Location = new Point(21, 188);
            lblCateg.Name = "lblCateg";
            lblCateg.Size = new Size(59, 14);
            lblCateg.TabIndex = 3;
            lblCateg.Text = "Categoria";
            // 
            // campoCod
            // 
            campoCod.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            campoCod.Location = new Point(21, 21);
            campoCod.MaximumSize = new Size(500, 38);
            campoCod.Multiline = true;
            campoCod.Name = "campoCod";
            campoCod.ReadOnly = true;
            campoCod.Size = new Size(72, 22);
            campoCod.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 4);
            label1.Name = "label1";
            label1.Size = new Size(44, 14);
            label1.TabIndex = 10;
            label1.Text = "Código";
            // 
            // campoCate
            // 
            campoCate.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            campoCate.FormattingEnabled = true;
            campoCate.ImeMode = ImeMode.On;
            campoCate.Items.AddRange(new object[] { "Refrigerante", "Salgado", "Água" });
            campoCate.Location = new Point(21, 204);
            campoCate.MaximumSize = new Size(258, 0);
            campoCate.Name = "campoCate";
            campoCate.Size = new Size(226, 22);
            campoCate.TabIndex = 11;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = SystemColors.ActiveCaption;
            btnNovo.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovo.Location = new Point(3, 0);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(125, 37);
            btnNovo.TabIndex = 12;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += button2_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(130, 0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(125, 37);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // campoPreco
            // 
            campoPreco.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            campoPreco.Location = new Point(21, 147);
            campoPreco.MaximumSize = new Size(300, 40);
            campoPreco.Name = "campoPreco";
            campoPreco.Size = new Size(155, 22);
            campoPreco.TabIndex = 0;
            campoPreco.KeyPress += campoPreco_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 130);
            label2.Name = "label2";
            label2.Size = new Size(36, 14);
            label2.TabIndex = 16;
            label2.Text = "Preço";
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(381, 208);
            button1.Name = "button1";
            button1.Size = new Size(201, 30);
            button1.TabIndex = 17;
            button1.Text = "Selecionar Foto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pb_Imagem
            // 
            pb_Imagem.BorderStyle = BorderStyle.Fixed3D;
            pb_Imagem.Location = new Point(381, 11);
            pb_Imagem.Name = "pb_Imagem";
            pb_Imagem.Size = new Size(201, 191);
            pb_Imagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Imagem.TabIndex = 18;
            pb_Imagem.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(271, 201);
            button2.Name = "button2";
            button2.Size = new Size(70, 25);
            button2.TabIndex = 19;
            button2.Text = "Nova";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 128);
            button3.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(260, 0);
            button3.Name = "button3";
            button3.Size = new Size(125, 37);
            button3.TabIndex = 20;
            button3.Text = "Alterar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(21, 342);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 43);
            panel1.TabIndex = 22;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(386, 0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(125, 37);
            btnExcluir.TabIndex = 23;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png|JPEG(*.jpeg)|*.jpeg";
            // 
            // campoCusto
            // 
            campoCusto.Location = new Point(195, 147);
            campoCusto.Name = "campoCusto";
            campoCusto.Size = new Size(146, 22);
            campoCusto.TabIndex = 23;
            campoCusto.KeyPress += textBox1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(195, 130);
            label3.Name = "label3";
            label3.Size = new Size(37, 14);
            label3.TabIndex = 24;
            label3.Text = "Custo";
            // 
            // campoQtdE
            // 
            campoQtdE.Location = new Point(6, 35);
            campoQtdE.Name = "campoQtdE";
            campoQtdE.Size = new Size(155, 22);
            campoQtdE.TabIndex = 25;
            campoQtdE.KeyPress += campoQtdE_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 18);
            label4.Name = "label4";
            label4.Size = new Size(152, 14);
            label4.TabIndex = 26;
            label4.Text = "Quantidade Inical Estoque";
            // 
            // campoQtdMin
            // 
            campoQtdMin.Location = new Point(185, 35);
            campoQtdMin.Name = "campoQtdMin";
            campoQtdMin.Size = new Size(139, 22);
            campoQtdMin.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(185, 18);
            label5.Name = "label5";
            label5.Size = new Size(115, 14);
            label5.TabIndex = 27;
            label5.Text = "Quantidade mínima";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(campoQtdE);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(campoQtdMin);
            groupBox1.Location = new Point(20, 257);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 63);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estoque";
            // 
            // formProduto
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 397);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(campoCusto);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(pb_Imagem);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(campoPreco);
            Controls.Add(campoCate);
            Controls.Add(label1);
            Controls.Add(campoCod);
            Controls.Add(lblCateg);
            Controls.Add(campoNome);
            Controls.Add(lblNome);
            Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "formProduto";
            Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)pb_Imagem).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNome;
        private TextBox campoNome;
        private Label lblCateg;
        private TextBox campoCod;
        private Label label1;
        private ComboBox campoCate;
        private Button btnNovo;
        private Button btnSalvar;
        private TextBox campoPreco;
        private Label label2;
        private Button button1;
        private PictureBox pb_Imagem;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Button btnExcluir;
        private OpenFileDialog openFileDialog1;
        private TextBox campoCusto;
        private Label label3;
        private TextBox campoQtdE;
        private Label label4;
        private TextBox campoQtdMin;
        private Label label5;
        private GroupBox groupBox1;
    }
}