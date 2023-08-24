namespace TCC
{
    partial class formAlterar
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
            btnAjuste = new Button();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            campoCod = new TextBox();
            campoCate = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            campoNome = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAjuste
            // 
            btnAjuste.Location = new Point(12, 381);
            btnAjuste.Name = "btnAjuste";
            btnAjuste.Size = new Size(575, 44);
            btnAjuste.TabIndex = 13;
            btnAjuste.Text = "Alterar";
            btnAjuste.UseVisualStyleBackColor = true;
            btnAjuste.Click += btnAjuste_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Items.AddRange(new object[] { "1 Coca Cola 500ml", "2 Pepsi 500ml", "3 Guaraná Antártica 500ml", "4 Esfirra de frango ", "5 Picole de chocolate", "6 Água com gás 350ml", "7 Coxinha de frango", "8 Empada de palmito", "9 Água sem gás" });
            listBox1.Location = new Point(12, 115);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(575, 234);
            listBox1.TabIndex = 12;
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
            groupBox2.Location = new Point(12, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(575, 91);
            groupBox2.TabIndex = 11;
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
            campoCate.Items.AddRange(new object[] { "Refrigerante", "Salgado", "Água" });
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
            // formAlterar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 450);
            Controls.Add(btnAjuste);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Name = "formAlterar";
            Text = "formAlterar";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAjuste;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private TextBox campoCod;
        private ComboBox campoCate;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox campoNome;
    }
}