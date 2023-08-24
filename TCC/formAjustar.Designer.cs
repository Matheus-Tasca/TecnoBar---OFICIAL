namespace TCC
{
    partial class formAjustar
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
            campoAjustar = new NumericUpDown();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)campoAjustar).BeginInit();
            SuspendLayout();
            // 
            // campoAjustar
            // 
            campoAjustar.Location = new Point(241, 50);
            campoAjustar.Name = "campoAjustar";
            campoAjustar.Size = new Size(154, 23);
            campoAjustar.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(401, 50);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Ajustar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(225, 24);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 8;
            label2.Text = "Ajustar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 24);
            label1.Name = "label1";
            label1.Size = new Size(148, 23);
            label1.TabIndex = 7;
            label1.Text = "Quantidade Atual";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Enabled = false;
            maskedTextBox1.Location = new Point(56, 50);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.ReadOnly = true;
            maskedTextBox1.Size = new Size(150, 23);
            maskedTextBox1.TabIndex = 6;
            // 
            // formAjustar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 96);
            Controls.Add(campoAjustar);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Name = "formAjustar";
            Text = "Ajustar";
            ((System.ComponentModel.ISupportInitialize)campoAjustar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown campoAjustar;
        private Button button1;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
    }
}