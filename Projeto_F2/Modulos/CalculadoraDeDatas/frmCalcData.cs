using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_F2.Modulos.CalculadoraDeDatas;

namespace Projeto_F2.Modulos.CalculadoraDeDatas
{
    public partial class frmCalcData : Form
    {
        private int acao = 0;

        public frmCalcData()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int dia, mes, ano, diaHoje, mesHoje, anoHoje;
                DateTime hoje, data;
                string strData = txtAno.Text + "-" + txtMes.Text.PadLeft(2, '0') + "-" + txtDia.Text.PadLeft(2, '0');

                if (!Utilidades.ValidarData(strData)) return;

                dia = Utilidades.ObterNumericoApartirDeString(strData, "dia");
                mes = Utilidades.ObterNumericoApartirDeString(strData, "mes");
                ano = Utilidades.ObterNumericoApartirDeString(strData, "ano");

                if (dia == 0) throw new Exception("Falha ao converter dia para numérico.");
                if (mes == 0) throw new Exception("Falha ao converter mês para numérico.");
                if (ano == 0) throw new Exception("Falha ao converter ano para numérico.");

                hoje = DateTime.Now;

                if (DateTime.TryParse(strData, out data) == false)
                    throw new Exception("Houve um problema ao converter a data para o sistema. (" + strData + ")");

                diaHoje = int.Parse(hoje.ToString("dd"));
                mesHoje = int.Parse(hoje.ToString("MM"));
                anoHoje = int.Parse(hoje.ToString("yyyy"));

                // Calcular Idade
                if (acao == 0)
                {
                    txtResultado.Clear();
                    TimeSpan diferencaDatas = hoje.Subtract(data);

                    addTextBoxTitle("Calcular Idade");
                    addTextBoxResult("Idade em anos:", (diferencaDatas.Days / 365).ToString());
                    addTextBoxResult("Idade em meses:", Math.Floor(diferencaDatas.Days / (365.25 / 12)).ToString());
                    addTextBoxResult("Idade em dias:", (diferencaDatas.Days).ToString());
                    addTextBoxResult("Idade em horas:", (diferencaDatas.Days * 24).ToString());
                }
            } 
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addTextBoxTitle(string title)
        {
            txtResultado.SelectionFont = new Font(new Font("Verdana", (float)10.5), FontStyle.Bold);
            txtResultado.AppendText(title);
            txtResultado.SelectionFont = new Font(new Font("Verdana", (float)9.75), FontStyle.Regular);
            txtResultado.AppendText("\n\n");
        }

        private void addTextBoxResult(string key, string value)
        {
            txtResultado.SelectionFont = new Font(new Font("Verdana", (float)9.75), FontStyle.Bold);
            txtResultado.AppendText(key + "\t\t");
            txtResultado.SelectionFont = new Font(new Font("Verdana", (float)9.75), FontStyle.Regular);
            txtResultado.AppendText(value + "\n");
        }

        private void txtDia_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDia.TextLength >= 2)
                txtMes.Focus();
        }

        private void txtMes_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMes.TextLength >= 2)
                txtAno.Focus();
        }

        private void txtAno_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtAno.TextLength >= 4)
                btnCalcular.Focus();
        }

        private void calculadoraMulticulturalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rdHojeEData_CheckedChanged(object sender, EventArgs e)
        {
            acao = 0;
        }

        private void rdAdicao_CheckedChanged(object sender, EventArgs e)
        {
            acao = 1;
        }

        private void rdSubtracao_CheckedChanged(object sender, EventArgs e)
        {
            acao = 2;
        }

        private void rdInformacoes_CheckedChanged(object sender, EventArgs e)
        {
            acao = 3;
        }

    }
}
