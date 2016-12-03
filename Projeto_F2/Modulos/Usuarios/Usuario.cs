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

    public class Usuario
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
            set { if (_rg.Length <= 10) _rg = value; }
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

        public int diferencaDataAlteracaoSenha()
        {
            TimeSpan ts = DateTime.Now - Alteracaosenha;
            return ts.Days;
        }

        public bool SenhaValida()
        {
            if (diferencaDataAlteracaoSenha() > 90)
                return false;

            return true;
        }

        public bool SenhaCritica()
        {
            if (diferencaDataAlteracaoSenha() > 180)
                return true;

            return false;
        }

        public Usuario()
        {

        }

        public override string ToString()
        {
            char mask = ' ';
            return
                this.Cpf.PadRight(11, mask) +
                this.Senha.PadRight(50, mask) +
                this.Alteracaosenha.ToString("dd/MM/yyyy HH:mm:ss").PadRight(19, mask) +
                this.Nome.PadRight(50, mask) +
                this.Rg.PadRight(10, mask) +
                this.Estado.ToString() +
                this.Permissao.ToString();
        }

        public void FromString(string txtUsuarios)
        {
            try
            {
                int lenght = 142;
                txtUsuarios = txtUsuarios.TrimEnd();

                if (txtUsuarios.Length != lenght)
                    throw new Exception("Falha ao obter usuário. (esperado tamanho " + lenght + ", obtido " + txtUsuarios.Length + ")");
                
                this.Cpf = txtUsuarios.Substring(0, 11).Trim();
                this.Senha = txtUsuarios.Substring(11, 50).Trim();
                this.Alteracaosenha = DateTime.ParseExact(txtUsuarios.Substring(60, 20).Trim(), "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                this.Nome = txtUsuarios.Substring(80, 50).Trim();
                this.Rg = txtUsuarios.Substring(130, 10).Trim();
                this.Estado = int.Parse(txtUsuarios.Substring(140, 1).Trim());
                this.Permissao = int.Parse(txtUsuarios.Substring(141, 1).Trim());

            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace + '\n' + '\n' + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
