using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_F2.Modulos.CalculadoraDeDatas
{
    class Utilidades
    {
        /*
         * Verifica se a data entrada é válida.
         * Formado de entrada:
         * AAAA-MM-DD
         * 
         * Retorna true ou false
        */
        public static bool ValidarData(string data)
        {
            int dia, mes, ano;
            if (int.TryParse(data.Split(new char[] { '-' })[2], out dia) == false)
                throw new Exception("O dia precisa ser um inteiro numérico.");

            if (int.TryParse(data.Split(new char[] { '-' })[1], out mes) == false)
                throw new Exception("O mês precisa ser um inteiro numérico.");

            if (int.TryParse(data.Split(new char[] { '-' })[0], out ano) == false)
                throw new Exception("O ano precisa ser um inteiro numérico.");

            if (dia < 1 || dia > 31)
                throw new Exception("Digite um dia válido. (Entre 1 e 31)");

            if (mes < 1 || mes > 12)
                throw new Exception("Digite um mês válido. (Entre 1 e 12)");

            if (ano < 1900)
                throw new Exception("Digite um ano válido. (A cima de 1900)");

            return true;
        }

        /*
         * Obtem o dia, mês ou ano em valor numério.
         * Formato de entrada:
         * AAAA-MM-DD, "esperado"
         *   esperado = dia, mes ou ano
         *   
         * Retorna o valor esperado em caso de sucesso, ou 0 em caso de falha.
        */
        public static int ObterNumericoApartirDeString(string data, string retorno)
        {
            if (!Utilidades.ValidarData(data)) return 0;

            if (retorno == "dia")
                return int.Parse(data.Split(new char[] { '-' })[2]);
            else if (retorno == "mes")
                return int.Parse(data.Split(new char[] { '-' })[1]);
            else if (retorno == "ano")
                return int.Parse(data.Split(new char[] { '-' })[0]);

            return 0;
        }
    }
}
