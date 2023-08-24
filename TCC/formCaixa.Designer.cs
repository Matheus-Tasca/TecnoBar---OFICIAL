namespace TCC
{
    partial class formCaixa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_Adicionar = new Button();
            bt_final = new Button();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            campoCod = new TextBox();
            campoCate = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            campoNome = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            lbl_valorTotal = new Label();
            label5 = new Label();
            Itens_Venda = new ListBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // bt_Adicionar
            // 
            bt_Adicionar.BackColor = SystemColors.ActiveCaption;
            bt_Adicionar.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Adicionar.Location = new Point(834, 374);
            bt_Adicionar.Name = "bt_Adicionar";
            bt_Adicionar.Size = new Size(90, 43);
            bt_Adicionar.TabIndex = 1;
            bt_Adicionar.Text = "Adicionar";
            bt_Adicionar.UseVisualStyleBackColor = false;
            bt_Adicionar.Click += bt_Adicionar_Click;
            // 
            // bt_final
            // 
            bt_final.BackColor = Color.Red;
            bt_final.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_final.Location = new Point(631, 374);
            bt_final.Name = "bt_final";
            bt_final.Size = new Size(101, 43);
            bt_final.TabIndex = 3;
            bt_final.Text = "Cancelar Venda";
            bt_final.UseVisualStyleBackColor = false;
            bt_final.Click += bt_final_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.ButtonFace;
            listBox1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(26, 114);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(575, 303);
            listBox1.TabIndex = 4;
            listBox1.DoubleClick += listBox1_DoubleClick;
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
            groupBox2.Location = new Point(26, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(575, 91);
            groupBox2.TabIndex = 7;
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
            campoCod.KeyPress += campoCod_KeyPress;
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
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(738, 374);
            button1.Name = "button1";
            button1.Size = new Size(90, 43);
            button1.TabIndex = 9;
            button1.Text = "Finalizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(lbl_valorTotal);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(631, 266);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 83);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Total da Venda";
            // 
            // lbl_valorTotal
            // 
            lbl_valorTotal.AutoSize = true;
            lbl_valorTotal.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_valorTotal.Location = new Point(126, 23);
            lbl_valorTotal.Name = "lbl_valorTotal";
            lbl_valorTotal.Size = new Size(81, 42);
            lbl_valorTotal.TabIndex = 1;
            lbl_valorTotal.Text = "0,00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(35, 23);
            label5.Name = "label5";
            label5.Size = new Size(55, 42);
            label5.TabIndex = 0;
            label5.Text = "R$";
            // 
            // Itens_Venda
            // 
            Itens_Venda.BackColor = SystemColors.ButtonFace;
            Itens_Venda.FormattingEnabled = true;
            Itens_Venda.ItemHeight = 15;
            Itens_Venda.Location = new Point(631, 12);
            Itens_Venda.Name = "Itens_Venda";
            Itens_Venda.Size = new Size(293, 229);
            Itens_Venda.TabIndex = 2;
            // 
            // formCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(943, 438);
            Controls.Add(Itens_Venda);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(listBox1);
            Controls.Add(bt_final);
            Controls.Add(bt_Adicionar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "formCaixa";
            Text = "Form1";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button bt_Adicionar;
        private Button bt_final;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox campoNome;
        private Button button1;
        private GroupBox groupBox1;
        private ComboBox campoCate;
        private Label lbl_valorTotal;
        private Label label5;
        private ListBox Itens_Venda;
        private TextBox campoCod;
    }
}