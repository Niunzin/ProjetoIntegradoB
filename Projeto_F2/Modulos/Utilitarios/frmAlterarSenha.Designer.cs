namespace Projeto_F2.Modulos.Utilitarios
{
    partial class frmAlterarSenha
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNotificao = new System.Windows.Forms.Label();
            this.lbForcaSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notificações";
            // 
            // lbNotificao
            // 
            this.lbNotificao.Location = new System.Drawing.Point(12, 25);
            this.lbNotificao.Name = "lbNotificao";
            this.lbNotificao.Size = new System.Drawing.Size(355, 55);
            this.lbNotificao.TabIndex = 1;
            this.lbNotificao.Text = "Sem novas mensagens.";
            // 
            // lbForcaSenha
            // 
            this.lbForcaSenha.AutoSize = true;
            this.lbForcaSenha.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.lbForcaSenha.Location = new System.Drawing.Point(12, 80);
            this.lbForcaSenha.Name = "lbForcaSenha";
            this.lbForcaSenha.Size = new System.Drawing.Size(98, 16);
            this.lbForcaSenha.TabIndex = 2;
            this.lbForcaSenha.Text = "Nova senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(12, 99);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(355, 22);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nova senha (confirmação):";
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(12, 143);
            this.txtSenha2.MaxLength = 50;
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.Size = new System.Drawing.Size(355, 22);
            this.txtSenha2.TabIndex = 5;
            this.txtSenha2.UseSystemPasswordChar = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(250, 171);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(117, 33);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar senha";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.Location = new System.Drawing.Point(12, 171);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(232, 33);
            this.lbInfo.TabIndex = 7;
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 220);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lbForcaSenha);
            this.Controls.Add(this.lbNotificao);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmAlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar senha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlterarSenha_FormClosing);
            this.Load += new System.EventHandler(this.frmAlterarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNotificao;
        private System.Windows.Forms.Label lbForcaSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lbInfo;
    }
}