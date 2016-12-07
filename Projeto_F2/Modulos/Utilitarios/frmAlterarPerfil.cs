using System;
using Projeto_F2.Modulos.Usuarios;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_F2.Modulos.Utilitarios
{
    public partial class frmAlterarPerfil : Form
    {
        Usuario usuario;
        Gerenciador gerenciador;
        
        public frmAlterarPerfil(Usuario u, Gerenciador g)
        {
            InitializeComponent();
            usuario = u;
            gerenciador = g;
        }

        private void frmAlterarPerfil_Load(object sender, EventArgs e)
        {
            txtNome.Text = usuario.Nome;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Usuario u in gerenciador.ObterUsuarios())
                    if (u.Nome.Trim() == txtNome.Text.Trim())
                        throw new Exception("Já existe um usuário com esse nome.");

                usuario.Nome = txtNome.Text.Trim();
                gerenciador.Salvar();

                MessageBox.Show("Seus dados foram alterados com sucesso.\nVocê precisa reiniciar a aplicação para surtir o efeito.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } catch (Exception er)
            {
                MessageBox.Show(er.Message, "Falha ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
