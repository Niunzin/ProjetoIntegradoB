using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Projeto_F2.Modulos.ForcaSenha
{
    class AvaliarSenha
    {
        private static bool contemRepeticao(string s)
        {
            int tamanho = s.Length;
            int contagem = 0;
            string ultimaLetra = s.Substring(0, 1);

            for(int i = 0; i < tamanho; i++)
            {
                string letra = s.Substring(i, 1);
                if (letra == ultimaLetra)
                {
                    contagem++;
                    if (contagem >= 3)
                        return true;
                    continue;
                }

                ultimaLetra = letra;
            }

            return false;
        }

        public static bool eUmaSequenciaCrescente(string s)
        {
            if (s.Contains("0123")) return true;
            else if (s.Contains("1234")) return true;
            else if (s.Contains("2345")) return true;
            else if (s.Contains("3456")) return true;
            else if (s.Contains("4567")) return true;
            else if (s.Contains("5678")) return true;
            else if (s.Contains("6789")) return true;
            return false;
        }

        public static bool eUmaSequenciaDecrescente(string s)
        {
            if (s.Contains("9876")) return true;
            else if (s.Contains("8765")) return true;
            else if (s.Contains("7654")) return true;
            else if (s.Contains("6543")) return true;
            else if (s.Contains("5432")) return true;
            else if (s.Contains("4321")) return true;
            else if (s.Contains("3210")) return true;
            return false;
        }

        public static string ObterMensagem(int resultado)
        {
            switch(resultado)
            {
                case -1:
                    return "Sua senha precisa conter no mínimo 7 e no máximo 11 algarismos numéricos e/ou letras.";
                case -2:
                    return "Sua senha não pode conter espaços em branco.";
                case -3:
                    return "Sua senha não pode conter caracteres especiais, utilize apenas letras e números.";
                case -4:
                    return "Sua senha precisa ter no mínimo 3 letras.";
                case -5:
                    return "Sua senha precisa ter no mínimo 2 números.";
                case -6:
                    return "Sua senha não pode conter 3 ou mais letras ou números repetidas em sequência.";
            }

            return "Erro indefinido.";
        }

        public static string ObterForcaString(int pontuacao)
        {
            if (pontuacao >= 9)
            {
                return "Muito Forte";
            }
            else if (pontuacao >= 7)
            {
                return "Forte";
            }
            else if (pontuacao >= 5)
            {
                return "Razoável";
            }
            else if (pontuacao >= 3)
            {
                return "Fraca";
            }
            else
            {
                return "Muito Fraca";
            }
        }

        public static int ObterForca(string senha)
        {
            int pontos = 10;
            var expressao = new Regex("^[a-zA-Z0-9]*$");

            if (senha.Length < 7 || senha.Length > 11)
                return -1;

            if (senha.Contains(" "))
                return -2;

            if (!expressao.IsMatch(senha))
                return -3;

            if (senha.Count(char.IsLetter) < 3)
                return -4;

            if (senha.Count(char.IsNumber) < 2)
                return -5;

            if (contemRepeticao(senha))
                return -6;

            /*
            if(senha == antigasenha)
                return -7;
            */

            if (eUmaSequenciaCrescente(senha))
                pontos = pontos - 2;

            if (eUmaSequenciaDecrescente(senha))
                pontos = pontos - 2;

            if (senha.Count(char.IsLetter) <= 3)
                pontos = pontos - 1;

            if (senha.Count(char.IsNumber) <= 2)
                pontos = pontos - 1;

            // 5, 6 e 7

            DateTime auxiliar;
            if (DateTime.TryParse(senha, out auxiliar))
                pontos = pontos - 3;

            return pontos;
        }
    }
}
