namespace Projeto_F2.Modulos.CalculadoraDeDatas
{
    partial class frmCalcData
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdInfoEntreDatas = new System.Windows.Forms.RadioButton();
            this.rdInformacoes = new System.Windows.Forms.RadioButton();
            this.rdSubtracao = new System.Windows.Forms.RadioButton();
            this.rdAdicao = new System.Windows.Forms.RadioButton();
            this.rdHojeEData = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculadoraMulticulturalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdInfoEntreDatas);
            this.groupBox1.Controls.Add(this.rdInformacoes);
            this.groupBox1.Controls.Add(this.rdSubtracao);
            this.groupBox1.Controls.Add(this.rdAdicao);
            this.groupBox1.Controls.Add(this.rdHojeEData);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.txtAno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDia);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(270, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data de Entrada";
            // 
            // rdInfoEntreDatas
            // 
            this.rdInfoEntreDatas.AutoSize = true;
            this.rdInfoEntreDatas.Location = new System.Drawing.Point(6, 98);
            this.rdInfoEntreDatas.Name = "rdInfoEntreDatas";
            this.rdInfoEntreDatas.Size = new System.Drawing.Size(190, 20);
            this.rdInfoEntreDatas.TabIndex = 13;
            this.rdInfoEntreDatas.TabStop = true;
            this.rdInfoEntreDatas.Text = "Informações entre Datas";
            this.rdInfoEntreDatas.UseVisualStyleBackColor = true;
            this.rdInfoEntreDatas.CheckedChanged += new System.EventHandler(this.rdInfoEntreDatas_CheckedChanged);
            // 
            // rdInformacoes
            // 
            this.rdInformacoes.AutoSize = true;
            this.rdInformacoes.Location = new System.Drawing.Point(6, 176);
            this.rdInformacoes.Name = "rdInformacoes";
            this.rdInformacoes.Size = new System.Drawing.Size(186, 20);
            this.rdInformacoes.TabIndex = 12;
            this.rdInformacoes.Text = "Informações dessa Data";
            this.rdInformacoes.UseVisualStyleBackColor = true;
            this.rdInformacoes.CheckedChanged += new System.EventHandler(this.rdInformacoes_CheckedChanged);
            // 
            // rdSubtracao
            // 
            this.rdSubtracao.AutoSize = true;
            this.rdSubtracao.Location = new System.Drawing.Point(6, 150);
            this.rdSubtracao.Name = "rdSubtracao";
            this.rdSubtracao.Size = new System.Drawing.Size(215, 20);
            this.rdSubtracao.TabIndex = 11;
            this.rdSubtracao.Text = "Calcular Subtração de Datas";
            this.rdSubtracao.UseVisualStyleBackColor = true;
            this.rdSubtracao.CheckedChanged += new System.EventHandler(this.rdSubtracao_CheckedChanged);
            // 
            // rdAdicao
            // 
            this.rdAdicao.AutoSize = true;
            this.rdAdicao.Location = new System.Drawing.Point(6, 124);
            this.rdAdicao.Name = "rdAdicao";
            this.rdAdicao.Size = new System.Drawing.Size(191, 20);
            this.rdAdicao.TabIndex = 10;
            this.rdAdicao.Text = "Calcular Adição de Datas";
            this.rdAdicao.UseVisualStyleBackColor = true;
            this.rdAdicao.CheckedChanged += new System.EventHandler(this.rdAdicao_CheckedChanged);
            // 
            // rdHojeEData
            // 
            this.rdHojeEData.AutoSize = true;
            this.rdHojeEData.Checked = true;
            this.rdHojeEData.Location = new System.Drawing.Point(6, 72);
            this.rdHojeEData.Name = "rdHojeEData";
            this.rdHojeEData.Size = new System.Drawing.Size(120, 20);
            this.rdHojeEData.TabIndex = 9;
            this.rdHojeEData.TabStop = true;
            this.rdHojeEData.Text = "Calcular Idade";
            this.rdHojeEData.UseVisualStyleBackColor = true;
            this.rdHojeEData.CheckedChanged += new System.EventHandler(this.rdHojeEData_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mês";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dia";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(6, 200);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(258, 28);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(166, 42);
            this.txtAno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(94, 23);
            this.txtAno.TabIndex = 4;
            this.txtAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAno_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "/";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(87, 42);
            this.txtMes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMes.MaxLength = 2;
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(45, 23);
            this.txtMes.TabIndex = 2;
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMes_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "/";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(8, 42);
            this.txtDia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDia.MaxLength = 2;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(45, 23);
            this.txtDia.TabIndex = 0;
            this.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDia_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResultado);
            this.groupBox2.Location = new System.Drawing.Point(288, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(270, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Control;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.Location = new System.Drawing.Point(6, 23);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtResultado.Size = new System.Drawing.Size(258, 205);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraMulticulturalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculadoraMulticulturalToolStripMenuItem
            // 
            this.calculadoraMulticulturalToolStripMenuItem.Name = "calculadoraMulticulturalToolStripMenuItem";
            this.calculadoraMulticulturalToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.calculadoraMulticulturalToolStripMenuItem.Text = "Calculadora Multicultural";
            this.calculadoraMulticulturalToolStripMenuItem.Click += new System.EventHandler(this.calculadoraMulticulturalToolStripMenuItem_Click);
            // 
            // frmCalcData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 276);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmCalcData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Datas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdInformacoes;
        private System.Windows.Forms.RadioButton rdSubtracao;
        private System.Windows.Forms.RadioButton rdAdicao;
        private System.Windows.Forms.RadioButton rdHojeEData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculadoraMulticulturalToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtResultado;
        private System.Windows.Forms.RadioButton rdInfoEntreDatas;

    }
}