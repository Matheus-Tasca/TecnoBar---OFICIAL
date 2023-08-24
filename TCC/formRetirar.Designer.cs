namespace TCC
{
    partial class formRetirar
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
            label2 = new Label();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            campoRetirar = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)campoRetirar).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(210, 9);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 6;
            label2.Text = "Retirar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 23);
            label1.TabIndex = 5;
            label1.Text = "Quantidade Atual";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Enabled = false;
            maskedTextBox1.Location = new Point(41, 35);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(150, 23);
            maskedTextBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(386, 35);
            button1.Name = "button1";
            button1.Size = new Size(82, 23);
            button1.TabIndex = 8;
            button1.Text = "Retirar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // campoRetirar
            // 
            campoRetirar.Location = new Point(227, 35);
            campoRetirar.Name = "campoRetirar";
            campoRetirar.Size = new Size(153, 23);
            campoRetirar.TabIndex = 9;
            // 
            // formRetirar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 88);
            Controls.Add(campoRetirar);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Name = "formRetirar";
            Text = "Retirar do Estoque";
            ((System.ComponentModel.ISupportInitialize)campoRetirar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private NumericUpDown campoRetirar;
    }
}