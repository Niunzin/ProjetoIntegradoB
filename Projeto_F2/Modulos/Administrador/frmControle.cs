using Microsoft.VisualBasic;
using Projeto_F2.Modulos.Usuarios;
using Projeto_F2.Modulos.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_F2.Modulos.Administrador
{
    public partial class frmControle : Form
    {
        List<Usuario> usuarios;
        Gerenciador gerenciador;
        Usuario admin;

        public frmControle(Usuario admin)
        {
            InitializeComponent();

            this.admin = admin;

            gerenciador = new Gerenciador();
            gerenciador.Carregar();

            usuarios = gerenciador.ObterUsuarios();
        }

        private void carregarListaUsuarios(bool apenasBloqueados = false, int grupo = -1)
        {
            gerenciador.Limpar();
            gerenciador.Carregar();

            listBox.Items.Clear();

            foreach (Usuario usuario in usuarios)
            {
                if (apenasBloqueados)
                    if (usuario.Estado != Estado.BLOQUEADO)
                        continue;

                if (grupo != -1)
                    if (usuario.Permissao != grupo)
                        continue;
                
                listBox.Items.Add(usuario.Nome);
            }
        }

        private Usuario obterUsuarioSelecionado()
        {
            if (listBox.SelectedIndex >= 0)
                foreach (Usuario usuario in usuarios)
                    if (usuario.Nome == listBox.SelectedItem.ToString())
                        return usuario;

            if (usuarios.Count > 0)
            {
                listBox.SelectedIndex = 0;
                return usuarios[0];
            }

            return null;
        }

        private void frmControle_Load(object sender, EventArgs e)
        {
            carregarListaUsuarios();
        }

        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            carregarListaUsuarios(chckBloqueados.Checked, ((chckGrupo.Checked) ? cboxGrupoMostrar.SelectedIndex : -1));
        }

        private void chckGrupo_CheckedChanged(object sender, EventArgs e)
        {
            if (chckGrupo.Checked)
                cboxGrupoMostrar.Enabled = true;
            else
                cboxGrupoMostrar.Enabled = false;

            btnAplicarFiltro_Click(sender, e);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtSenha.Clear();
                txtRg.Clear();
                txtNome.Clear();
                txtCpf.Clear();

                Usuario selecionado = obterUsuarioSelecionado();

                if (selecionado == null)
                    throw new Exception("Usuário não encontrado.");

                groupBox.Enabled = true;
                btnBloquearDesbloquear.Enabled = true;

                if (selecionado.Estado == Estado.BLOQUEADO)
                    btnBloquearDesbloquear.Text = "Desbloquear";
                else if (selecionado.Estado == Estado.NORMAL)
                    btnBloquearDesbloquear.Text = "Bloquear";
                else
                {
                    btnBloquearDesbloquear.Enabled = false;
                    btnBloquearDesbloquear.Text = "Senha inicial";
                }

                txtNome.Text = selecionado.Nome;
                txtCpf.Text = selecionado.Cpf;
                txtRg.Text = selecionado.Rg;
                cboxPermissao.SelectedIndex = selecionado.Permissao;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBloquearDesbloquear_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = obterUsuarioSelecionado();

                if (usuario == null)
                    throw new Exception("Usuário não encontrado.");

                if (usuario.Estado == Estado.BLOQUEADO)
                {
                    btnBloquearDesbloquear.Text = "Bloquear";
                    usuario.Estado = Estado.NORMAL;
                }
                else
                {
                    btnBloquearDesbloquear.Text = "Desbloquear";
                    usuario.Estado = Estado.BLOQUEADO;
                }

                gerenciador.Salvar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = obterUsuarioSelecionado();

                if (usuario == null)
                    throw new Exception("Usuário não encontrado.");

                foreach (Usuario _usuario in usuarios)
                    if (_usuario.Nome == txtNome.Text && txtNome.Text != usuario.Nome)
                        throw new Exception("Já existe um usuário com esse nome!");

                usuario.Cpf = txtCpf.Text;
                usuario.Nome = txtNome.Text;
                usuario.Rg = txtRg.Text;

                if (!string.IsNullOrEmpty(txtSenha.Text.Trim()))
                {
                    usuario.Senha = Cripto.MD5(txtSenha.Text.Trim());

                    if (usuario.Estado == Estado.SENHA_INICIAL)
                        usuario.Estado = Estado.NORMAL;
                }

                usuario.Permissao = cboxPermissao.SelectedIndex;

                MessageBox.Show("As alterações foram salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gerenciador.Salvar();
                carregarListaUsuarios();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();

                string nome = Interaction.InputBox("Digite o nome do novo usuário", "Novo usuário", "");
                if (string.IsNullOrEmpty(nome.Trim()))
                    throw new Exception("Digite um nome para o usuário.");

                usuario.Nome = nome;
                usuario.Alteracaosenha = DateTime.Now;
                usuario.Estado = Estado.SENHA_INICIAL;

                foreach (Usuario _usuario in usuarios)
                    if (_usuario.Nome == usuario.Nome)
                        throw new Exception("Já existe um usuário com esse nome!");

                usuarios.Add(usuario);
                gerenciador.Salvar();

                btnAplicarFiltro_Click(sender, e);
            } catch (Exception er)
            {
                MessageBox.Show(er.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            Usuario usuario = obterUsuarioSelecionado();

            if (usuario == null)
                throw new Exception("Usuário não encontrado.");

            usuario.Senha = "";
            usuario.Estado = Estado.SENHA_INICIAL;

            gerenciador.Salvar();
        }

        private void chckBloqueados_CheckedChanged(object sender, EventArgs e)
        {
            btnAplicarFiltro_Click(sender, e);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Você realmente deseja deletar esse usuário?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Usuario usuario = obterUsuarioSelecionado();

                    if (usuario.Nome == admin.Nome)
                        throw new Exception("Você não pode deletar a si mesmo.");

                    if (usuario.Permissao == Permissao.ADMINISTRADOR)
                        throw new Exception("Você não pode deletar um usuário com privilégio de administrador.");

                    usuarios.Remove(usuario);
                    gerenciador.Salvar();
                    carregarListaUsuarios();

                    StreamWriter sr = new StreamWriter("arquivo-morto.txt", true);
                    sr.WriteLine(usuario.ToString());
                    sr.Close();
                }
            } catch (Exception er)
            {
                MessageBox.Show(er.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
