
namespace DESKTOP2019
{
    partial class frmConcluirVenda
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
            this.txtBoxDesconto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblTituloEncerramento = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.lblTrocoValor = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.txtBoxCartao = new System.Windows.Forms.TextBox();
            this.txtBoxPix = new System.Windows.Forms.TextBox();
            this.txtBoxDinheiro = new System.Windows.Forms.TextBox();
            this.lblCartao = new System.Windows.Forms.Label();
            this.lblPix = new System.Windows.Forms.Label();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.txtBoxTotalPagar = new System.Windows.Forms.TextBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxDesconto
            // 
            this.txtBoxDesconto.Location = new System.Drawing.Point(277, 62);
            this.txtBoxDesconto.Name = "txtBoxDesconto";
            this.txtBoxDesconto.Size = new System.Drawing.Size(106, 20);
            this.txtBoxDesconto.TabIndex = 0;
            this.txtBoxDesconto.Text = "0";
            this.txtBoxDesconto.Leave += new System.EventHandler(this.digitarDesconto);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDesconto);
            this.groupBox1.Controls.Add(this.lblTituloEncerramento);
            this.groupBox1.Controls.Add(this.txtBoxDesconto);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.Location = new System.Drawing.Point(151, 63);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(120, 17);
            this.lblDesconto.TabIndex = 2;
            this.lblDesconto.Text = "DESCONTO:   R$";
            // 
            // lblTituloEncerramento
            // 
            this.lblTituloEncerramento.AutoSize = true;
            this.lblTituloEncerramento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEncerramento.Location = new System.Drawing.Point(150, 16);
            this.lblTituloEncerramento.Name = "lblTituloEncerramento";
            this.lblTituloEncerramento.Size = new System.Drawing.Size(260, 22);
            this.lblTituloEncerramento.TabIndex = 1;
            this.lblTituloEncerramento.Text = "ENCERRAMENTO DE VENDA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSaldo);
            this.groupBox2.Controls.Add(this.lblSaldo);
            this.groupBox2.Controls.Add(this.txtValorPago);
            this.groupBox2.Controls.Add(this.lblValorPago);
            this.groupBox2.Controls.Add(this.lblTrocoValor);
            this.groupBox2.Controls.Add(this.lblTroco);
            this.groupBox2.Controls.Add(this.txtBoxCartao);
            this.groupBox2.Controls.Add(this.txtBoxPix);
            this.groupBox2.Controls.Add(this.txtBoxDinheiro);
            this.groupBox2.Controls.Add(this.lblCartao);
            this.groupBox2.Controls.Add(this.lblPix);
            this.groupBox2.Controls.Add(this.lblDinheiro);
            this.groupBox2.Controls.Add(this.txtBoxTotalPagar);
            this.groupBox2.Controls.Add(this.lblTotalPagar);
            this.groupBox2.Location = new System.Drawing.Point(31, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 407);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(277, 179);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(155, 20);
            this.txtSaldo.TabIndex = 12;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(71, 167);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(91, 31);
            this.lblSaldo.TabIndex = 11;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(277, 114);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.ReadOnly = true;
            this.txtValorPago.Size = new System.Drawing.Size(155, 20);
            this.txtValorPago.TabIndex = 10;
            this.txtValorPago.TextChanged += new System.EventHandler(this.calculaSaldo);
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPago.Location = new System.Drawing.Point(70, 102);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(152, 31);
            this.lblValorPago.TabIndex = 9;
            this.lblValorPago.Text = "Valor pago:";
            // 
            // lblTrocoValor
            // 
            this.lblTrocoValor.AutoSize = true;
            this.lblTrocoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrocoValor.Location = new System.Drawing.Point(273, 376);
            this.lblTrocoValor.Name = "lblTrocoValor";
            this.lblTrocoValor.Size = new System.Drawing.Size(58, 17);
            this.lblTrocoValor.TabIndex = 8;
            this.lblTrocoValor.Text = "R$ 0,00";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(193, 376);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(58, 17);
            this.lblTroco.TabIndex = 5;
            this.lblTroco.Text = "TROCO";
            // 
            // txtBoxCartao
            // 
            this.txtBoxCartao.Location = new System.Drawing.Point(119, 336);
            this.txtBoxCartao.Name = "txtBoxCartao";
            this.txtBoxCartao.Size = new System.Drawing.Size(132, 20);
            this.txtBoxCartao.TabIndex = 7;
            this.txtBoxCartao.TextChanged += new System.EventHandler(this.inserirValorCartão);
            this.txtBoxCartao.Enter += new System.EventHandler(this.calculaTrocoCartao_enter);
            this.txtBoxCartao.Leave += new System.EventHandler(this.calculaTrocoCartao_leave);
            // 
            // txtBoxPix
            // 
            this.txtBoxPix.Location = new System.Drawing.Point(377, 335);
            this.txtBoxPix.Name = "txtBoxPix";
            this.txtBoxPix.Size = new System.Drawing.Size(132, 20);
            this.txtBoxPix.TabIndex = 6;
            this.txtBoxPix.TextChanged += new System.EventHandler(this.digitarValorPix);
            this.txtBoxPix.Enter += new System.EventHandler(this.digitarValorPix_Enter);
            this.txtBoxPix.Leave += new System.EventHandler(this.digitarValorPix_Leave);
            // 
            // txtBoxDinheiro
            // 
            this.txtBoxDinheiro.Location = new System.Drawing.Point(227, 292);
            this.txtBoxDinheiro.Name = "txtBoxDinheiro";
            this.txtBoxDinheiro.Size = new System.Drawing.Size(132, 20);
            this.txtBoxDinheiro.TabIndex = 5;
            this.txtBoxDinheiro.TextChanged += new System.EventHandler(this.digitarValorDinheiro);
            this.txtBoxDinheiro.Enter += new System.EventHandler(this.digitarValorDinheiro_Enter);
            this.txtBoxDinheiro.Leave += new System.EventHandler(this.digitarValorDinheiro_Leave);
            // 
            // lblCartao
            // 
            this.lblCartao.AutoSize = true;
            this.lblCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartao.Location = new System.Drawing.Point(21, 338);
            this.lblCartao.Name = "lblCartao";
            this.lblCartao.Size = new System.Drawing.Size(65, 17);
            this.lblCartao.TabIndex = 4;
            this.lblCartao.Text = "CARTÃO";
            // 
            // lblPix
            // 
            this.lblPix.AutoSize = true;
            this.lblPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPix.Location = new System.Drawing.Point(330, 336);
            this.lblPix.Name = "lblPix";
            this.lblPix.Size = new System.Drawing.Size(29, 17);
            this.lblPix.TabIndex = 3;
            this.lblPix.Text = "PIX";
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinheiro.Location = new System.Drawing.Point(105, 292);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(74, 17);
            this.lblDinheiro.TabIndex = 2;
            this.lblDinheiro.Text = "DINHEIRO";
            // 
            // txtBoxTotalPagar
            // 
            this.txtBoxTotalPagar.Location = new System.Drawing.Point(277, 55);
            this.txtBoxTotalPagar.Name = "txtBoxTotalPagar";
            this.txtBoxTotalPagar.ReadOnly = true;
            this.txtBoxTotalPagar.Size = new System.Drawing.Size(155, 20);
            this.txtBoxTotalPagar.TabIndex = 1;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(70, 43);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(181, 31);
            this.lblTotalPagar.TabIndex = 0;
            this.lblTotalPagar.Text = "Total a pagar:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(55, 553);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(136, 53);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(404, 553);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 53);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmConcluirVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 618);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConcluirVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conclusão de venda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxDesconto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblTituloEncerramento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxCartao;
        private System.Windows.Forms.TextBox txtBoxPix;
        private System.Windows.Forms.TextBox txtBoxDinheiro;
        private System.Windows.Forms.Label lblCartao;
        private System.Windows.Forms.Label lblPix;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.TextBox txtBoxTotalPagar;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTrocoValor;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label lblValorPago;
    }
}