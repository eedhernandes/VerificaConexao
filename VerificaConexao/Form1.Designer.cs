namespace VerificaConexao
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.btnPararVerificacao = new System.Windows.Forms.Button();
            this.btnIniciarVerificacao = new System.Windows.Forms.Button();
            this.lblIpDestino = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmr1
            // 
            this.tmr1.Interval = 1000;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // btnPararVerificacao
            // 
            this.btnPararVerificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPararVerificacao.Location = new System.Drawing.Point(192, 12);
            this.btnPararVerificacao.Name = "btnPararVerificacao";
            this.btnPararVerificacao.Size = new System.Drawing.Size(130, 23);
            this.btnPararVerificacao.TabIndex = 11;
            this.btnPararVerificacao.Text = "Parar verificação";
            this.btnPararVerificacao.UseVisualStyleBackColor = true;
            this.btnPararVerificacao.Click += new System.EventHandler(this.btnPararVerificacao_Click);
            // 
            // btnIniciarVerificacao
            // 
            this.btnIniciarVerificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarVerificacao.Location = new System.Drawing.Point(12, 12);
            this.btnIniciarVerificacao.Name = "btnIniciarVerificacao";
            this.btnIniciarVerificacao.Size = new System.Drawing.Size(130, 23);
            this.btnIniciarVerificacao.TabIndex = 10;
            this.btnIniciarVerificacao.Text = "Iniciar verificação";
            this.btnIniciarVerificacao.UseVisualStyleBackColor = true;
            this.btnIniciarVerificacao.Click += new System.EventHandler(this.btnIniciarVerificacao_Click);
            // 
            // lblIpDestino
            // 
            this.lblIpDestino.AutoSize = true;
            this.lblIpDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpDestino.Location = new System.Drawing.Point(124, 71);
            this.lblIpDestino.Name = "lblIpDestino";
            this.lblIpDestino.Size = new System.Drawing.Size(31, 25);
            this.lblIpDestino.TabIndex = 9;
            this.lblIpDestino.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ip destino:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(83, 118);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 25);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 164);
            this.Controls.Add(this.btnPararVerificacao);
            this.Controls.Add(this.btnIniciarVerificacao);
            this.Controls.Add(this.lblIpDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verifica conexão";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Button btnPararVerificacao;
        private System.Windows.Forms.Button btnIniciarVerificacao;
        private System.Windows.Forms.Label lblIpDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
    }
}