using System;
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
using Projeto_F2.Modulos.Usuarios;

namespace Projeto_F2
{
    public partial class frmLogin : Form
    {
        public const string APP_VERSION = "2.1";
        Usuario usuario;
        Gerenciador gerenciador;

        public frmLogin()
        {
            InitializeComponent();

            gerenciador = new Gerenciador();
            gerenciador.Carregar();
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
            usuario = gerenciador.Entrar(txtUsuario.Text.Trim(), txtSenha.Text.Trim());

            if (usuario == null)
            {
                MessageBox.Show("Usuário ou senha inválido(s).", "Falha ao entrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                MessageBox.Show(string.Format("Seja bem-vindo, {0}!", usuario.Nome), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupLogin.Enabled = false;
            }
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

        private void llBCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmCadastro().ShowDialog();
        }
    }
}
