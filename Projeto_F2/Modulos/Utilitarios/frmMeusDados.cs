using Projeto_F2.Modulos.Usuarios;
using System;
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
    public partial class frmMeusDados : Form
    {
        Usuario usuario;

        public frmMeusDados(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
        }

        private void frmMeusDados_Load(object sender, EventArgs e)
        {
            this.Text += usuario.Nome;

            lbCPF.Text = usuario.Cpf;
            lbNome.Text = usuario.Nome;
            lbRG.Text = usuario.Rg;

            if (usuario.Estado == Estado.NORMAL)
                lbAcesso.Text = "Normal";
            else if (usuario.Estado == Estado.BLOQUEADO)
                lbAcesso.Text = "Bloqueado";
            else
                lbAcesso.Text = "Senha inicial";

            lbAlteracao.Text = usuario.Alteracaosenha.ToString("dd/MM/yyyy HH:mm:ss");
            if (usuario.diferencaDataAlteracaoSenha() == 0)
                lbAlteracao.Text += " (hoje)";
            else if (usuario.diferencaDataAlteracaoSenha() == 1)
                lbAlteracao.Text += " (ontem)";
            else
                lbAlteracao.Text += " (" + usuario.diferencaDataAlteracaoSenha() + " dias atrás)";

            if (usuario.Permissao == Permissao.ADMINISTRADOR)
                lbPrivilegio.Text = "Administrador";
            else if (usuario.Permissao == Permissao.ESTAGIARIO)
                lbPrivilegio.Text = "Estagiário";
            else if (usuario.Permissao == Permissao.GERENTE)
                lbPrivilegio.Text = "Gerente";
            else
                lbPrivilegio.Text = "Operador";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
