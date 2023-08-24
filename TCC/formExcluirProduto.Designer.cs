namespace TCC
{
    partial class formExlcuirProduto
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
            groupBox2 = new GroupBox();
            campoCod = new TextBox();
            campoCate = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            campoNome = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonFace;
            groupBox2.Controls.Add(campoCod);
            groupBox2.Controls.Add(campoCate);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(campoNome);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(33, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(575, 91);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtrar Produtos";
            // 
            // campoCod
            // 
            campoCod.BackColor = SystemColors.ButtonHighlight;
            campoCod.Location = new Point(157, 44);
            campoCod.Name = "campoCod";
            campoCod.Size = new Size(121, 27);
            campoCod.TabIndex = 15;
            // 
            // campoCate
            // 
            campoCate.BackColor = SystemColors.ButtonHighlight;
            campoCate.FormattingEnabled = true;
            campoCate.Location = new Point(302, 44);
            campoCate.Name = "campoCate";
            campoCate.Size = new Size(121, 27);
            campoCate.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 23);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 13;
            label4.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 23);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 11;
            label2.Text = "Código";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 10;
            label1.Text = "Nome ";
            // 
            // campoNome
            // 
            campoNome.BackColor = SystemColors.ButtonHighlight;
            campoNome.Location = new Point(19, 44);
            campoNome.Name = "campoNome";
            campoNome.Size = new Size(123, 27);
            campoNome.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(33, 109);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(575, 244);
            listBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(33, 375);
            button1.Name = "button1";
            button1.Size = new Size(575, 44);
            button1.TabIndex = 10;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // formExlcuirProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 454);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Name = "formExlcuirProduto";
            Text = "Exlcuir Produto";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox campoCod;
        private ComboBox campoCate;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox campoNome;
        private ListBox listBox1;
        private Button button1;
    }
}