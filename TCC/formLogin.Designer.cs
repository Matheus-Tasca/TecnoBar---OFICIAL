namespace TCC
{
    partial class formLogin
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
            campoUser = new TextBox();
            label1 = new Label();
            btn_Login = new Button();
            checkBox1 = new CheckBox();
            label2 = new Label();
            campoPassword = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // campoUser
            // 
            campoUser.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            campoUser.Location = new Point(46, 134);
            campoUser.Name = "campoUser";
            campoUser.PlaceholderText = "Usuário";
            campoUser.Size = new Size(236, 22);
            campoUser.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(78, 45);
            label1.Name = "label1";
            label1.Size = new Size(147, 36);
            label1.TabIndex = 0;
            label1.Text = "Tecnobar";
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.Location = new Point(14, 303);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(268, 23);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(14, 259);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(73, 18);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Lembrar ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(164, 259);
            label2.Name = "label2";
            label2.Size = new Size(124, 14);
            label2.TabIndex = 5;
            label2.Text = "Esqueci minha senha";
            // 
            // campoPassword
            // 
            campoPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            campoPassword.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            campoPassword.Location = new Point(46, 205);
            campoPassword.MaximumSize = new Size(1000, 1000);
            campoPassword.Name = "campoPassword";
            campoPassword.PasswordChar = '*';
            campoPassword.PlaceholderText = "Senha";
            campoPassword.Size = new Size(236, 22);
            campoPassword.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(14, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cadeado;
            pictureBox2.Location = new Point(14, 205);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(301, 344);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(campoPassword);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(btn_Login);
            Controls.Add(label1);
            Controls.Add(campoUser);
            Name = "formLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox campoUser;
        private Label label1;
        private Button btn_Login;
        private CheckBox checkBox1;
        private TextBox campoSenhas;
        private Label label2;
        private TextBox campoPassword;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}