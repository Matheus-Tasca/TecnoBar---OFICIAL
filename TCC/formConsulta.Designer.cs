namespace TCC
{
    partial class formConsulta
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
            campoConsulta = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // campoConsulta
            // 
            campoConsulta.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            campoConsulta.Location = new Point(68, 44);
            campoConsulta.Name = "campoConsulta";
            campoConsulta.ReadOnly = true;
            campoConsulta.Size = new Size(217, 22);
            campoConsulta.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 18);
            label1.Name = "label1";
            label1.Size = new Size(152, 23);
            label1.TabIndex = 2;
            label1.Text = "Quantidade Atual ";
            // 
            // formConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 87);
            Controls.Add(label1);
            Controls.Add(campoConsulta);
            Name = "formConsulta";
            Text = "Consulta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox campoConsulta;
        private Label label1;
    }
}