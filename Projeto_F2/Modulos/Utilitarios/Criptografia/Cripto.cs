using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_F2.Modulos.Utilitarios
{
    public class Cripto
    {
        public static String Codificar(string Mensagem, int Chave = 4)
        {
            Mensagem = Mensagem.ToUpper();
            string Resultado = "";

            string[] Procurar = new string[] {      "A",    "E",    "I",    "O",    "U" };
            string[] Substituir = new string[] {    "*",    "#",    "+",    "-",    "$" };

            for (int i = 0; i < Mensagem.Length; i++)
            {
                int ASCII = (int)Mensagem[i];
                int ASCIIK = ASCII + Chave;

                string Caracter = Char.ConvertFromUtf32(ASCIIK);

                for (int j = 0; j < Procurar.Length; j++)
                    if (Caracter == Procurar[j])
                        Caracter = Substituir[j];

                Resultado += Caracter;
            }

            return Resultado;
        }

        public static String Decodificar(string Mensagem, int Chave = 4)
        {
            return "";
        }

        public static String MD5(string Mensagem)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();

            // Adiciona RDN_SLT na frente da mensagem, apenas para diferenciar a senha. (segurança extra)
            byte[] hash = md5.ComputeHash(Encoding.ASCII.GetBytes("RDN_SLT" + Mensagem));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
