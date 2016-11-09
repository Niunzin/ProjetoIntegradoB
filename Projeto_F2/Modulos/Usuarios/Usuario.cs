using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_F2.Modulos.Usuarios
{
    public enum Estado
    {
        NORMAL,
        BLOQUEADO,
        SENHA_INICIAL
    }

    public enum Permissao
    {
        ESTAGIARIO,
        OPERADOR,
        GERENTE,
        ADMINISTRADOR
    }

    class Usuario
    {
        public string CPF { get; set; }
        public string Senha { get; set; }
        public DateTime AlteracaoSenha { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public Estado Estado { get; set; }
        public Permissao Permissao { get; set; }

        public Usuario()
        {

        }

        public override string ToString()
        {
            return 
                this.CPF + ";" +
                this.Senha + ";" +
                this.AlteracaoSenha.ToString("dd/mm/yyyy hh:mm:ss") + ";" +
                this.Nome + ";" +
                this.RG + ";" +
                this.Estado + ";" +
                this.Permissao;
        }
    }
}
