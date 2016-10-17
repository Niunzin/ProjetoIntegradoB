﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_F2.Modulos.Escala;
using Projeto_F2.Modulos.CalculadoraDeDatas;
using Projeto_F2.Modulos.ForcaSenha;

namespace Projeto_F2
{
    public partial class frmLogin : Form
    {
        public const string APP_VERSION = "2.1";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupLogin.Enabled = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSobre().Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text += " " + APP_VERSION;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
        }

        private void escalasDeTemperaturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmEscala().ShowDialog();
        }

        private void calculadoraOfDatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCalcData().ShowDialog();
        }

        private void forçaDaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmForcaSenha().ShowDialog();
        }
    }
}
