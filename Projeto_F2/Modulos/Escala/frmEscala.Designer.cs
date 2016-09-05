﻿namespace Projeto_F2.Modulos.Escala
{
    partial class frmEscala
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
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCelsius = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdFah = new System.Windows.Forms.RadioButton();
            this.rdKevin = new System.Windows.Forms.RadioButton();
            this.rdCelsius = new System.Windows.Forms.RadioButton();
            this.txtTemp = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbFah = new System.Windows.Forms.Label();
            this.txtFah = new System.Windows.Forms.TextBox();
            this.lbKelvin = new System.Windows.Forms.Label();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTemp)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(82, 19);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.ReadOnly = true;
            this.txtCelsius.Size = new System.Drawing.Size(126, 20);
            this.txtCelsius.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperatura:";
            // 
            // lbCelsius
            // 
            this.lbCelsius.AutoSize = true;
            this.lbCelsius.Location = new System.Drawing.Point(6, 22);
            this.lbCelsius.Name = "lbCelsius";
            this.lbCelsius.Size = new System.Drawing.Size(43, 13);
            this.lbCelsius.TabIndex = 3;
            this.lbCelsius.Text = "Celsius:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdFah);
            this.groupBox1.Controls.Add(this.rdKevin);
            this.groupBox1.Controls.Add(this.rdCelsius);
            this.groupBox1.Controls.Add(this.txtTemp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 73);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // rdFah
            // 
            this.rdFah.AutoSize = true;
            this.rdFah.Location = new System.Drawing.Point(134, 45);
            this.rdFah.Name = "rdFah";
            this.rdFah.Size = new System.Drawing.Size(75, 17);
            this.rdFah.TabIndex = 6;
            this.rdFah.Text = "Fahrenheit";
            this.rdFah.UseVisualStyleBackColor = true;
            this.rdFah.CheckedChanged += new System.EventHandler(this.rdFah_CheckedChanged);
            // 
            // rdKevin
            // 
            this.rdKevin.AutoSize = true;
            this.rdKevin.Location = new System.Drawing.Point(74, 45);
            this.rdKevin.Name = "rdKevin";
            this.rdKevin.Size = new System.Drawing.Size(54, 17);
            this.rdKevin.TabIndex = 5;
            this.rdKevin.Text = "Kelvin";
            this.rdKevin.UseVisualStyleBackColor = true;
            this.rdKevin.CheckedChanged += new System.EventHandler(this.rdKevin_CheckedChanged);
            // 
            // rdCelsius
            // 
            this.rdCelsius.AutoSize = true;
            this.rdCelsius.Checked = true;
            this.rdCelsius.Location = new System.Drawing.Point(10, 45);
            this.rdCelsius.Name = "rdCelsius";
            this.rdCelsius.Size = new System.Drawing.Size(58, 17);
            this.rdCelsius.TabIndex = 4;
            this.rdCelsius.TabStop = true;
            this.rdCelsius.Text = "Celsius";
            this.rdCelsius.UseVisualStyleBackColor = true;
            this.rdCelsius.CheckedChanged += new System.EventHandler(this.rdCelsius_CheckedChanged);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(82, 19);
            this.txtTemp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtTemp.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(126, 20);
            this.txtTemp.TabIndex = 3;
            this.txtTemp.ValueChanged += new System.EventHandler(this.txtTemp_ValueChanged);
            this.txtTemp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTemp_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbFah);
            this.groupBox2.Controls.Add(this.txtFah);
            this.groupBox2.Controls.Add(this.lbKelvin);
            this.groupBox2.Controls.Add(this.txtKelvin);
            this.groupBox2.Controls.Add(this.lbCelsius);
            this.groupBox2.Controls.Add(this.txtCelsius);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 101);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saida";
            // 
            // lbFah
            // 
            this.lbFah.AutoSize = true;
            this.lbFah.Location = new System.Drawing.Point(6, 74);
            this.lbFah.Name = "lbFah";
            this.lbFah.Size = new System.Drawing.Size(60, 13);
            this.lbFah.TabIndex = 7;
            this.lbFah.Text = "Fahrenheit:";
            // 
            // txtFah
            // 
            this.txtFah.Location = new System.Drawing.Point(82, 71);
            this.txtFah.Name = "txtFah";
            this.txtFah.ReadOnly = true;
            this.txtFah.Size = new System.Drawing.Size(126, 20);
            this.txtFah.TabIndex = 6;
            // 
            // lbKelvin
            // 
            this.lbKelvin.AutoSize = true;
            this.lbKelvin.Location = new System.Drawing.Point(6, 48);
            this.lbKelvin.Name = "lbKelvin";
            this.lbKelvin.Size = new System.Drawing.Size(39, 13);
            this.lbKelvin.TabIndex = 5;
            this.lbKelvin.Text = "Kelvin:";
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(82, 45);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.ReadOnly = true;
            this.txtKelvin.Size = new System.Drawing.Size(126, 20);
            this.txtKelvin.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEscala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 229);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEscala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEscala";
            this.Load += new System.EventHandler(this.frmEscala_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTemp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCelsius;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdFah;
        private System.Windows.Forms.RadioButton rdKevin;
        private System.Windows.Forms.RadioButton rdCelsius;
        private System.Windows.Forms.NumericUpDown txtTemp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbFah;
        private System.Windows.Forms.TextBox txtFah;
        private System.Windows.Forms.Label lbKelvin;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.Button button1;
    }
}