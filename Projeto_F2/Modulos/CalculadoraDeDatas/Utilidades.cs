using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_F2.Modulos.CalculadoraDeDatas
{
    class Utilidades
    {
        public enum TipoOperacao
        {
            CALCULAR_IDADE = 0,
            CALCULAR_ADD_DATAS = 1,
            CALCULAR_SUB_DATAS = 2,
            INFO_DATA = 3,
            INFO_ENTRE_DATAS = 4,
        }

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

        /*
         * Verifica se a tecla digitada é um número
         * para melhor experiência do usuário no formulário.
         *
         * Retorna true ou false
        */
        public static bool ChecarTecla(System.Windows.Forms.Keys tecla)
        {
            switch(tecla)
            {
                case System.Windows.Forms.Keys.D0: return true;
                case System.Windows.Forms.Keys.D1: return true;
                case System.Windows.Forms.Keys.D2: return true;
                case System.Windows.Forms.Keys.D3: return true;
                case System.Windows.Forms.Keys.D4: return true;
                case System.Windows.Forms.Keys.D5: return true;
                case System.Windows.Forms.Keys.D6: return true;
                case System.Windows.Forms.Keys.D7: return true;
                case System.Windows.Forms.Keys.D8: return true;
                case System.Windows.Forms.Keys.D9: return true;
                case System.Windows.Forms.Keys.NumPad0: return true;
                case System.Windows.Forms.Keys.NumPad1: return true;
                case System.Windows.Forms.Keys.NumPad2: return true;
                case System.Windows.Forms.Keys.NumPad3: return true;
                case System.Windows.Forms.Keys.NumPad4: return true;
                case System.Windows.Forms.Keys.NumPad5: return true;
                case System.Windows.Forms.Keys.NumPad6: return true;
                case System.Windows.Forms.Keys.NumPad7: return true;
                case System.Windows.Forms.Keys.NumPad8: return true;
                case System.Windows.Forms.Keys.NumPad9: return true;
            }

            return false;
        }

        /*
         * Obtem o nome do mês em extenso.
         * Formato de entrada:
         * MM (de 1 a 12)
         * 
         * Retorna uma string
        */
        public static string ObterNomeMes(int mes)
        {
            switch(mes)
            {
                case 1: return "Janeiro";
                case 2: return "Fevereiro";
                case 3: return "Março";
                case 4: return "Abril";
                case 5: return "Maio";
                case 6: return "Junho";
                case 7: return "Julho";
                case 8: return "Agosto";
                case 9: return "Setembro";
                case 10: return "Outubro";
                case 11: return "Novembro";
                case 12: return "Dezembro";
                default: return "Erro";
            }
        }
    }
}
