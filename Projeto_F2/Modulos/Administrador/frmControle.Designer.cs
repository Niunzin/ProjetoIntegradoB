namespace Projeto_F2.Modulos.Administrador
{
    partial class frmControle
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
            this.btnAddUsuario = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnBloquearDesbloquear = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxPermissao = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.cboxGrupoMostrar = new System.Windows.Forms.ComboBox();
            this.chckGrupo = new System.Windows.Forms.CheckBox();
            this.chckBloqueados = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddUsuario
            // 
            this.btnAddUsuario.Location = new System.Drawing.Point(395, 13);
            this.btnAddUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUsuario.Name = "btnAddUsuario";
            this.btnAddUsuario.Size = new System.Drawing.Size(107, 28);
            this.btnAddUsuario.TabIndex = 0;
            this.btnAddUsuario.Text = "Novo usuário";
            this.btnAddUsuario.UseVisualStyleBackColor = true;
            this.btnAddUsuario.Click += new System.EventHandler(this.btnAddUsuario_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 43);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(256, 516);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // btnBloquearDesbloquear
            // 
            this.btnBloquearDesbloquear.Location = new System.Drawing.Point(6, 22);
            this.btnBloquearDesbloquear.Name = "btnBloquearDesbloquear";
            this.btnBloquearDesbloquear.Size = new System.Drawing.Size(216, 23);
            this.btnBloquearDesbloquear.TabIndex = 2;
            this.btnBloquearDesbloquear.Text = "Bloquear";
            this.btnBloquearDesbloquear.UseVisualStyleBackColor = true;
            this.btnBloquearDesbloquear.Click += new System.EventHandler(this.btnBloquearDesbloquear_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnExcluir);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.cboxPermissao);
            this.groupBox.Controls.Add(this.button1);
            this.groupBox.Controls.Add(this.txtRg);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.txtCpf);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.txtSenha);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.txtNome);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.btnResetar);
            this.groupBox.Controls.Add(this.btnBloquearDesbloquear);
            this.groupBox.Enabled = false;
            this.groupBox.Location = new System.Drawing.Point(274, 192);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(228, 368);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Usuário selecionado";
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluir.Location = new System.Drawing.Point(6, 325);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(73, 35);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cargo:";
            // 
            // cboxPermissao
            // 
            this.cboxPermissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPermissao.Items.AddRange(new object[] {
            "Estagiário",
            "Operador",
            "Gerente",
            "Administrador"});
            this.cboxPermissao.Location = new System.Drawing.Point(6, 295);
            this.cboxPermissao.Name = "cboxPermissao";
            this.cboxPermissao.Size = new System.Drawing.Size(216, 24);
            this.cboxPermissao.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Salvar alterações";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(6, 250);
            this.txtRg.MaxLength = 10;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(216, 23);
            this.txtRg.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "RG:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(6, 205);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(216, 23);
            this.txtCpf.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "CPF:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(6, 160);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(216, 23);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.label3.Location = new System.Drawing.Point(6, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha: (insira uma nova para alterar)";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 115);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(216, 23);
            this.txtNome.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(6, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 1);
            this.label1.TabIndex = 4;
            // 
            // btnResetar
            // 
            this.btnResetar.Location = new System.Drawing.Point(6, 51);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(216, 23);
            this.btnResetar.TabIndex = 3;
            this.btnResetar.Text = "Resetar senha";
            this.btnResetar.UseVisualStyleBackColor = true;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAplicarFiltro);
            this.groupBox2.Controls.Add(this.cboxGrupoMostrar);
            this.groupBox2.Controls.Add(this.chckGrupo);
            this.groupBox2.Controls.Add(this.chckBloqueados);
            this.groupBox2.Location = new System.Drawing.Point(274, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 139);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Location = new System.Drawing.Point(97, 104);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(125, 29);
            this.btnAplicarFiltro.TabIndex = 3;
            this.btnAplicarFiltro.Text = "Aplicar Filtros";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);
            // 
            // cboxGrupoMostrar
            // 
            this.cboxGrupoMostrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGrupoMostrar.Enabled = false;
            this.cboxGrupoMostrar.FormattingEnabled = true;
            this.cboxGrupoMostrar.Items.AddRange(new object[] {
            "Estagiários",
            "Operadores",
            "Gerentes",
            "Administradores"});
            this.cboxGrupoMostrar.Location = new System.Drawing.Point(6, 74);
            this.cboxGrupoMostrar.Name = "cboxGrupoMostrar";
            this.cboxGrupoMostrar.Size = new System.Drawing.Size(216, 24);
            this.cboxGrupoMostrar.TabIndex = 2;
            // 
            // chckGrupo
            // 
            this.chckGrupo.AutoSize = true;
            this.chckGrupo.Location = new System.Drawing.Point(6, 48);
            this.chckGrupo.Name = "chckGrupo";
            this.chckGrupo.Size = new System.Drawing.Size(135, 20);
            this.chckGrupo.TabIndex = 1;
            this.chckGrupo.Text = "Mostrar apenas:";
            this.chckGrupo.UseVisualStyleBackColor = true;
            this.chckGrupo.CheckedChanged += new System.EventHandler(this.chckGrupo_CheckedChanged);
            // 
            // chckBloqueados
            // 
            this.chckBloqueados.AutoSize = true;
            this.chckBloqueados.Location = new System.Drawing.Point(6, 22);
            this.chckBloqueados.Name = "chckBloqueados";
            this.chckBloqueados.Size = new System.Drawing.Size(208, 20);
            this.chckBloqueados.TabIndex = 0;
            this.chckBloqueados.Text = "Mostrar apenas bloqueados";
            this.chckBloqueados.UseVisualStyleBackColor = true;
            this.chckBloqueados.CheckedChanged += new System.EventHandler(this.chckBloqueados_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(9, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Controle de Usuários - Administrativo";
            // 
            // frmControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 571);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnAddUsuario);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmControle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Usuários";
            this.Load += new System.EventHandler(this.frmControle_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUsuario;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnBloquearDesbloquear;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chckBloqueados;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.ComboBox cboxGrupoMostrar;
        private System.Windows.Forms.CheckBox chckGrupo;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxPermissao;
        private System.Windows.Forms.Button btnExcluir;
    }
}