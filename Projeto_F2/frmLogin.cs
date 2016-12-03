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
using Projeto_F2.Modulos.Administrador;
using Projeto_F2.Modulos.Utilitarios;

namespace Projeto_F2
{
    public partial class frmLogin : Form
    {
        public const string APP_VERSION = "10.1";
        Usuario usuario;
        Gerenciador gerenciador;

        public frmLogin()
        {
            InitializeComponent();

            gerenciador = new Gerenciador();
            gerenciador.Carregar();
            return;
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
                if (usuario.Estado == Estado.BLOQUEADO)
                {
                    MessageBox.Show("Acesso bloqueado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    usuario = null;
                    return;
                }

                if (usuario.SenhaCritica() || string.IsNullOrEmpty(usuario.Senha) || usuario.Estado == Estado.SENHA_INICIAL)
                {
                    MessageBox.Show("Sua senha encontra-se num estado crítico, faça alteração da mesma para poder entrar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    new frmAlterarSenha(usuario, gerenciador).ShowDialog();
                    usuario = null;
                    return;
                }

                lbEntrouTitulo.Text += usuario.Nome + "!";
                menuTools.Enabled = true;
                menuLogin.Text = usuario.Nome;
                meusDadosToolStripMenuItem.Visible = true;
                alterarSenhaToolStripMenuItem.Visible = true;
                groupLogin.Enabled = false;
                groupLogin.Visible = false;

                if (usuario.Permissao == Permissao.ESTAGIARIO)
                {
                    forçaDaSenhaToolStripMenuItem.Enabled = false;
                }
                else if (usuario.Permissao == Permissao.OPERADOR)
                {

                }
                else if (usuario.Permissao == Permissao.GERENTE)
                {

                } else
                {
                    controlarUsuáriosToolStripMenuItem.Visible = true;
                    toolStripSeparator1.Visible = true;
                }


                if (!usuario.SenhaValida())
                    lbEntrouDesc.Text += "ATENÇÃO!\nSua senha está desatualizada à mais de 90 dias.\nVocê precisa alterar a senha a cada 90 dias, conforme previsto na política de segurança da nossa empresa.";
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

        private void controlarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmControle().Show();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnEntrar_Click(sender, e);
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAlterarSenha(usuario, gerenciador).ShowDialog();
        }

        private void meusDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMeusDados(usuario).Show();
        }
    }
}
