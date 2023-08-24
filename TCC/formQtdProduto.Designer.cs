namespace TCC
{
    partial class formQtdProduto
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
            button1 = new Button();
            label1 = new Label();
            campoQtd = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)campoQtd).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(184, 57);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(71, 14);
            label1.TabIndex = 2;
            label1.Text = "Quantidade";
            // 
            // campoQtd
            // 
            campoQtd.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            campoQtd.Location = new Point(12, 57);
            campoQtd.Name = "campoQtd";
            campoQtd.Size = new Size(149, 22);
            campoQtd.TabIndex = 3;
            // 
            // formQtdProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 109);
            Controls.Add(campoQtd);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "formQtdProduto";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)campoQtd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private NumericUpDown campoQtd;
    }
}