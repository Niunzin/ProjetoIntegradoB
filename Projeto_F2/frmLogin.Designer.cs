namespace Projeto_F2
{
    partial class frmLogin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.meusDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.controlarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.escalasDeTemperaturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraOfDatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forçaDaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criptografarMensagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decodificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.groupLogin = new System.Windows.Forms.GroupBox();
            this.llBCadastro = new System.Windows.Forms.LinkLabel();
            this.lbEntrouTitulo = new System.Windows.Forms.Label();
            this.lbEntrouDesc = new System.Windows.Forms.Label();
            this.editarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.menuTools,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(396, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuLogin
            // 
            this.menuLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meusDadosToolStripMenuItem,
            this.alterarSenhaToolStripMenuItem,
            this.editarPerfilToolStripMenuItem,
            this.toolStripSeparator1,
            this.controlarUsuáriosToolStripMenuItem});
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(50, 20);
            this.menuLogin.Text = "Entrar";
            this.menuLogin.Click += new System.EventHandler(this.lToolStripMenuItem_Click);
            // 
            // meusDadosToolStripMenuItem
            // 
            this.meusDadosToolStripMenuItem.Name = "meusDadosToolStripMenuItem";
            this.meusDadosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.meusDadosToolStripMenuItem.Text = "Meus dados";
            this.meusDadosToolStripMenuItem.Visible = false;
            this.meusDadosToolStripMenuItem.Click += new System.EventHandler(this.meusDadosToolStripMenuItem_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar senha";
            this.alterarSenhaToolStripMenuItem.Visible = false;
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            this.toolStripSeparator1.Visible = false;
            // 
            // controlarUsuáriosToolStripMenuItem
            // 
            this.controlarUsuáriosToolStripMenuItem.Name = "controlarUsuáriosToolStripMenuItem";
            this.controlarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.controlarUsuáriosToolStripMenuItem.Text = "Controlar Usuários";
            this.controlarUsuáriosToolStripMenuItem.Visible = false;
            this.controlarUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.controlarUsuáriosToolStripMenuItem_Click);
            // 
            // menuTools
            // 
            this.menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escalasDeTemperaturaToolStripMenuItem1,
            this.calculadoraOfDatToolStripMenuItem,
            this.forçaDaSenhaToolStripMenuItem,
            this.criptografarMensagemToolStripMenuItem});
            this.menuTools.Enabled = false;
            this.menuTools.Name = "menuTools";
            this.menuTools.Size = new System.Drawing.Size(84, 20);
            this.menuTools.Text = "Ferramentas";
            // 
            // escalasDeTemperaturaToolStripMenuItem1
            // 
            this.escalasDeTemperaturaToolStripMenuItem1.Name = "escalasDeTemperaturaToolStripMenuItem1";
            this.escalasDeTemperaturaToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.escalasDeTemperaturaToolStripMenuItem1.Text = "Escalas de Temperatura";
            this.escalasDeTemperaturaToolStripMenuItem1.Click += new System.EventHandler(this.escalasDeTemperaturaToolStripMenuItem1_Click);
            // 
            // calculadoraOfDatToolStripMenuItem
            // 
            this.calculadoraOfDatToolStripMenuItem.Name = "calculadoraOfDatToolStripMenuItem";
            this.calculadoraOfDatToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.calculadoraOfDatToolStripMenuItem.Text = "Calculadora de Datas";
            this.calculadoraOfDatToolStripMenuItem.Click += new System.EventHandler(this.calculadoraOfDatToolStripMenuItem_Click);
            // 
            // forçaDaSenhaToolStripMenuItem
            // 
            this.forçaDaSenhaToolStripMenuItem.Name = "forçaDaSenhaToolStripMenuItem";
            this.forçaDaSenhaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.forçaDaSenhaToolStripMenuItem.Text = "Avaliar Senha";
            this.forçaDaSenhaToolStripMenuItem.Click += new System.EventHandler(this.forçaDaSenhaToolStripMenuItem_Click);
            // 
            // criptografarMensagemToolStripMenuItem
            // 
            this.criptografarMensagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codificarToolStripMenuItem,
            this.decodificarToolStripMenuItem});
            this.criptografarMensagemToolStripMenuItem.Name = "criptografarMensagemToolStripMenuItem";
            this.criptografarMensagemToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.criptografarMensagemToolStripMenuItem.Text = "Cripto";
            this.criptografarMensagemToolStripMenuItem.Click += new System.EventHandler(this.criptografarMensagemToolStripMenuItem_Click);
            // 
            // codificarToolStripMenuItem
            // 
            this.codificarToolStripMenuItem.Name = "codificarToolStripMenuItem";
            this.codificarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.codificarToolStripMenuItem.Text = "Codificar";
            this.codificarToolStripMenuItem.Click += new System.EventHandler(this.codificarToolStripMenuItem_Click);
            // 
            // decodificarToolStripMenuItem
            // 
            this.decodificarToolStripMenuItem.Name = "decodificarToolStripMenuItem";
            this.decodificarToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.decodificarToolStripMenuItem.Text = "Decodificar";
            this.decodificarToolStripMenuItem.Click += new System.EventHandler(this.decodificarToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(221, 87);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(139, 37);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(67, 55);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(292, 23);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(67, 23);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(292, 23);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // groupLogin
            // 
            this.groupLogin.Controls.Add(this.llBCadastro);
            this.groupLogin.Controls.Add(this.btnEntrar);
            this.groupLogin.Controls.Add(this.label1);
            this.groupLogin.Controls.Add(this.txtSenha);
            this.groupLogin.Controls.Add(this.label2);
            this.groupLogin.Controls.Add(this.txtUsuario);
            this.groupLogin.Enabled = false;
            this.groupLogin.Location = new System.Drawing.Point(13, 33);
            this.groupLogin.Margin = new System.Windows.Forms.Padding(4);
            this.groupLogin.Name = "groupLogin";
            this.groupLogin.Padding = new System.Windows.Forms.Padding(4);
            this.groupLogin.Size = new System.Drawing.Size(371, 135);
            this.groupLogin.TabIndex = 8;
            this.groupLogin.TabStop = false;
            this.groupLogin.Text = "Área de acesso";
            // 
            // llBCadastro
            // 
            this.llBCadastro.AutoSize = true;
            this.llBCadastro.Location = new System.Drawing.Point(7, 97);
            this.llBCadastro.Name = "llBCadastro";
            this.llBCadastro.Size = new System.Drawing.Size(81, 16);
            this.llBCadastro.TabIndex = 6;
            this.llBCadastro.TabStop = true;
            this.llBCadastro.Text = "Criar conta";
            this.llBCadastro.Visible = false;
            this.llBCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llBCadastro_LinkClicked);
            // 
            // lbEntrouTitulo
            // 
            this.lbEntrouTitulo.AutoSize = true;
            this.lbEntrouTitulo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEntrouTitulo.Location = new System.Drawing.Point(12, 33);
            this.lbEntrouTitulo.Name = "lbEntrouTitulo";
            this.lbEntrouTitulo.Size = new System.Drawing.Size(132, 16);
            this.lbEntrouTitulo.TabIndex = 9;
            this.lbEntrouTitulo.Text = "Seja bem-vindo, ";
            // 
            // lbEntrouDesc
            // 
            this.lbEntrouDesc.Location = new System.Drawing.Point(12, 49);
            this.lbEntrouDesc.Name = "lbEntrouDesc";
            this.lbEntrouDesc.Size = new System.Drawing.Size(372, 120);
            this.lbEntrouDesc.TabIndex = 10;
            this.lbEntrouDesc.Text = "Utilize o menu para navegação e utilização das nossas ferramentas.\r\n";
            // 
            // editarPerfilToolStripMenuItem
            // 
            this.editarPerfilToolStripMenuItem.Name = "editarPerfilToolStripMenuItem";
            this.editarPerfilToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.editarPerfilToolStripMenuItem.Text = "Editar perfil";
            this.editarPerfilToolStripMenuItem.Visible = false;
            this.editarPerfilToolStripMenuItem.Click += new System.EventHandler(this.editarPerfilToolStripMenuItem_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 178);
            this.Controls.Add(this.groupLogin);
            this.Controls.Add(this.lbEntrouDesc);
            this.Controls.Add(this.lbEntrouTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Usuários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupLogin.ResumeLayout(false);
            this.groupLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox groupLogin;
        private System.Windows.Forms.ToolStripMenuItem menuTools;
        private System.Windows.Forms.ToolStripMenuItem escalasDeTemperaturaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calculadoraOfDatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forçaDaSenhaToolStripMenuItem;
        private System.Windows.Forms.LinkLabel llBCadastro;
        private System.Windows.Forms.ToolStripMenuItem meusDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem controlarUsuáriosToolStripMenuItem;
        private System.Windows.Forms.Label lbEntrouTitulo;
        private System.Windows.Forms.Label lbEntrouDesc;
        private System.Windows.Forms.ToolStripMenuItem criptografarMensagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decodificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPerfilToolStripMenuItem;
    }
}

