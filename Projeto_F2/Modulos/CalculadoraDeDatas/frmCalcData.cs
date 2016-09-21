using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_F2.Modulos.CalculadoraDeDatas
{
    public partial class frmCalcData : Form
    {
        public frmCalcData()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int dia, mes, ano, diaHoje, mesHoje, anoHoje;
                DateTime hoje;

                if (int.TryParse(txtDia.Text, out dia) == false)
                    throw new Exception("O dia precisa ser um inteiro numérico.");

                if (int.TryParse(txtMes.Text, out mes) == false)
                    throw new Exception("O mês precisa ser um inteiro numérico.");

                if (int.TryParse(txtAno.Text, out ano) == false)
                    throw new Exception("O ano precisa ser um inteiro numérico.");

                if (dia < 1 || dia > 31)
                    throw new Exception("Digite um dia válido. (Entre 1 e 31)");

                if (mes < 1 || mes > 12)
                    throw new Exception("Digite um mês válido. (Entre 1 e 12)");

                if (ano <= 0)
                    throw new Exception("Digite um ano válido. (A cima de 0)");

                hoje = DateTime.Now;

                diaHoje = int.Parse(hoje.ToString("dd"));
                mesHoje = int.Parse(hoje.ToString("MM"));
                anoHoje = int.Parse(hoje.ToString("yyyy"));

                MessageBox.Show(diaHoje + "/" + mesHoje + "/" + anoHoje);
            } 
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
