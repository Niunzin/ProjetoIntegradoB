using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_F2.Modulos.Usuarios
{
    public static class Estado
    {
        public static int NORMAL = 0;
        public static int BLOQUEADO = 1;
        public static int SENHA_INICIAL = 2;
    }

    public static class Permissao
    {
        public static int ESTAGIARIO = 0;
        public static int OPERADOR = 1;
        public static int GERENTE = 2;
        public static int ADMINISTRADOR = 3;
    }

    class Usuario
    {
        private string _cpf = "";

        public string Cpf
        {
            get { if (!string.IsNullOrEmpty(_cpf)) return _cpf; return ""; }
            set { if(_cpf.Length <= 10) _cpf = value; }
        }
        private string _senha = "";

        public string Senha
        {
            get { if (!string.IsNullOrEmpty(_senha)) return _senha; return ""; }
            set { if (_cpf.Length <= 50) _senha = value; }
        }
        private DateTime _alteracaosenha;

        public DateTime Alteracaosenha
        {
            get { return _alteracaosenha; }
            set { _alteracaosenha = value; }
        }
        private string _nome = "";

        public string Nome
        {
            get { if (!string.IsNullOrEmpty(_nome)) return _nome; return ""; }
            set { if (_cpf.Length <= 50) _nome = value; }
        }
        private string _rg = "";

        public string Rg
        {
            get { if (!string.IsNullOrEmpty(_rg)) return _rg; return ""; }
            set { if (_cpf.Length <= 10) _rg = value; }
        }
        private int _estado = 0;

        public int Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        private int _permissao = 0;

        public int Permissao
        {
            get { return _permissao; }
            set { _permissao = value; }
        }

        public Usuario()
        {

        }

        public override string ToString()
        {
            char mask = ' ';
            return
                this.Cpf.PadRight(10, mask) +
                this.Senha.PadRight(50, mask) +
                this.Alteracaosenha.ToString("dd/mm/yyyy hh:mm:ss").PadRight(19, mask) +
                this.Nome.PadRight(50, mask) +
                this.Rg.PadRight(10, mask) +
                this.Estado.ToString() +
                this.Permissao.ToString();
        }

        public void FromString(string txtUsuarios)
        {
            try
            {
                int lenght = 141;

                if (txtUsuarios.Length != lenght)
                    throw new Exception("Falha ao obter usuário.");
                
                this.Cpf = txtUsuarios.Substring(0, 10).Trim();
                this.Senha = txtUsuarios.Substring(10, 50).Trim();
                this.Alteracaosenha = DateTime.ParseExact(txtUsuarios.Substring(60, 19).Trim(), "dd/mm/yyyy hh:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                this.Nome = txtUsuarios.Substring(79, 50).Trim();
                this.Rg = txtUsuarios.Substring(129, 10).Trim();
                this.Estado = int.Parse(txtUsuarios.Substring(139, 1).Trim());
                this.Permissao = int.Parse(txtUsuarios.Substring(140, 1).Trim());

            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace + '\n' + '\n' + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
