using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto_F2.Modulos.Usuarios
{
    class Gerenciador
    {
        private string arquivo = Environment.CurrentDirectory + "\\reg_usuarios.txt";
        private List<Usuario> usuarios;

        public Gerenciador()
        {
            this.usuarios = new List<Usuario>();
        }

        public void Adicionar(Usuario usuario)
        {
            try
            {
                usuarios.Add(usuario);
            } catch (Exception e)
            {
                MessageBox.Show(e.Message, "Falha ao salvar usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Remover(Usuario usuario)
        {
            try
            {
                usuarios.Remove(usuario);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Falha ao remover usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Usuario> ObterUsuarios()
        {
            return usuarios;
        }

        public Usuario ObterUsuario(Usuario usuario)
        {
            try
            {
                if (usuarios.Contains(usuario))
                {
                    return usuarios.ElementAt(usuarios.IndexOf(usuario));
                }
                else
                {
                    throw new Exception("Não foi possível encontrar o usuário.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Falha ao remover usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return usuario;
        }

        public void Salvar()
        {
            try
            {
                StreamWriter sw = new StreamWriter(arquivo);

                foreach (Usuario usuario in usuarios)
                {
                    sw.WriteLine(usuario.ToString());
                }

                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Falha ao salvar arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Carregar()
        {
            try
            {
                if (!File.Exists(arquivo))
                {
                    Console.WriteLine("Arquivo " + arquivo + " não identificado.");
                    return;
                }

                StreamReader sr = new StreamReader(arquivo);
                string source = sr.ReadToEnd();

                foreach (string line in source.Split('\n'))
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        Usuario u = new Usuario();
                        u.FromString(line);
                        usuarios.Add(u);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Falha ao carregar arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Existe(string nome)
        {
            if (usuarios.Count > 0)
                foreach (Usuario usuario in usuarios)
                    if (usuario.Nome.Equals(nome))
                        return true;

            return false;
        }

        public Usuario Entrar(string nome, string senha)
        {
            if (Existe(nome))
                foreach (Usuario usuario in usuarios)
                    if (usuario.Nome.Equals(nome) && usuario.Senha.Equals(senha))
                        return usuario;

            return null;
        }
    }
}
