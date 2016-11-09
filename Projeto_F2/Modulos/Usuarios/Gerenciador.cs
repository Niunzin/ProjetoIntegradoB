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
        private const string arquivo = "reg_usuarios.txt";

        public Gerenciador()
        {

        }

        public void Adicionar(Usuario usuario)
        {
            try
            {
                File.AppendAllText(arquivo, usuario.ToString() + "\n");
            } catch (Exception e)
            {
                MessageBox.Show(e.Message, "Falha ao salvar usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Remover(Usuario usuario)
        {
            try
            {
                string conteudo = File.ReadAllText(arquivo);
                string[] usuarios = new string[] { };
                List<string> novos_usuarios = new List<string>();

                if (!conteudo.Contains('\n'))
                    return;

                usuarios = conteudo.Split('\n');
                
                foreach(string u in usuarios)
                {
                    if (u.Equals(usuario))
                        continue;

                    novos_usuarios.Add(u);
                }

                File.Delete(arquivo);
                File.AppendAllText(arquivo, string.Join("\n", novos_usuarios.ToArray()));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Falha ao remover usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar(Usuario antigo, Usuario novo)
        {

        }
    }
}
