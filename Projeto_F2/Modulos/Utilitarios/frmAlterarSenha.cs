using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Projeto_F2.Modulos.Usuarios;
using Projeto_F2.Modulos.ForcaSenha;

namespace Projeto_F2.Modulos.Utilitarios
{
    public partial class frmAlterarSenha : Form
    {
        Projeto_F2.Modulos.Usuarios.Usuario usuario;
        Gerenciador gerenciador;

        public frmAlterarSenha(Projeto_F2.Modulos.Usuarios.Usuario usuario, Gerenciador gerenciador)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.gerenciador = gerenciador;
        }

        private void frmAlterarSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmAlterarSenha_Load(object sender, EventArgs e)
        {
            if (!usuario.SenhaValida())
            {
                lbNotificao.ForeColor = Color.DarkGoldenrod;
                lbNotificao.Text = "Você não atualiza sua senha à mais de 90 dias, por favor atualize a mesma.";
            }
            
            if (usuario.SenhaCritica())
            {
                lbNotificao.ForeColor = Color.DarkRed;
                lbNotificao.Text = "Você não atualiza sua senha à mais de 180 dias, você não poderá entrar até atualizar a mesma.";
            }
            
            if (string.IsNullOrEmpty(usuario.Senha) || usuario.Estado == Estado.SENHA_INICIAL)
            {
                lbNotificao.ForeColor = Color.DarkRed;
                lbNotificao.Text = "Você precisa definir uma senha para esse usuário.";
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            int forca = AvaliarSenha.ObterForca(txtSenha.Text);

            lbForcaSenha.Text = "Nova senha: (" + AvaliarSenha.ObterForcaString(forca) + ")";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                txtSenha.Text = txtSenha.Text.Trim();
                txtSenha2.Text = txtSenha2.Text.Trim();

                int forca = AvaliarSenha.ObterForca(txtSenha.Text);

                if (forca < 3)
                    throw new Exception("A senha é muito fraca.");

                if (!txtSenha.Text.Equals(txtSenha2.Text))
                    throw new Exception("As senhas não conferem.");

                usuario.Senha = Cripto.MD5(txtSenha.Text);
                usuario.Alteracaosenha = DateTime.Now;
                usuario.Estado = Estado.NORMAL;

                gerenciador.Salvar();

                MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception er)
            {
                lbInfo.Text = er.Message;
            }
        }
    }
}
