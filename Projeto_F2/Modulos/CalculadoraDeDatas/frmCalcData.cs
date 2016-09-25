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
using System.Globalization;

namespace Projeto_F2.Modulos.CalculadoraDeDatas
{
    public partial class frmCalcData : Form
    {
        private Utilidades.TipoOperacao acao = Utilidades.TipoOperacao.CALCULAR_IDADE;

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
                if (acao == Utilidades.TipoOperacao.CALCULAR_IDADE)
                {
                    txtResultado.Clear();
                    TimeSpan diferencaDatas = hoje.Subtract(data);

                    addTextBoxTitle("Cálculo de Idade");
                    addTextBoxResult("Idade em anos:", Math.Floor(diferencaDatas.Days / 365.25).ToString());
                    addTextBoxResult("Idade em meses:", Math.Floor(diferencaDatas.Days / (365.25 / 12)).ToString());
                    addTextBoxResult("Idade em dias:", (diferencaDatas.Days).ToString());
                    addTextBoxResult("Idade em horas:", (diferencaDatas.Days * 24).ToString());
                } else if (acao == Utilidades.TipoOperacao.INFO_ENTRE_DATAS)
                {
                    new frmNovaDataPadrao(this, data, strData).ShowDialog();
                } else if (acao == Utilidades.TipoOperacao.CALCULAR_ADD_DATAS)
                {
                    new frmControleData(this, "add", data, strData).ShowDialog();
                } else if (acao == Utilidades.TipoOperacao.CALCULAR_SUB_DATAS)
                {
                    new frmControleData(this, "sub", data, strData).ShowDialog();
                } else if (acao == Utilidades.TipoOperacao.INFO_DATA)
                {
                    txtResultado.Clear();

                    addTextBoxTitle("Informações da Data");
                    addTextBoxResult("Dia:", data.ToString("dddd", new CultureInfo("pt-BR")));
                    addTextBoxResult("Mês:", Utilidades.ObterNomeMes(data.Month));
                    addTextBoxResult("Dia juliano:\t", ((data - new DateTime(data.Year, 1, 1)).TotalDays + 1).ToString());
                    addTextBoxResult("É ano bissexto?:", ((DateTime.IsLeapYear(data.Year)) ? "Sim" : "Não") );
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void NovaDataInserida(string strData2, DateTime data1, string strData1)
        {
            try
            {
                if (acao == Utilidades.TipoOperacao.INFO_ENTRE_DATAS)
                {
                    int dia, mes, ano;
                    DateTime data2;
                    dia = Utilidades.ObterNumericoApartirDeString(strData2, "dia");
                    mes = Utilidades.ObterNumericoApartirDeString(strData2, "mes");
                    ano = Utilidades.ObterNumericoApartirDeString(strData2, "ano");

                    if (dia == 0) throw new Exception("Falha ao converter dia para numérico.");
                    if (mes == 0) throw new Exception("Falha ao converter mês para numérico.");
                    if (ano == 0) throw new Exception("Falha ao converter ano para numérico.");

                    if (DateTime.TryParse(strData2, out data2) == false)
                        throw new Exception("Houve um problema ao converter a data para o sistema. (" + strData2 + ")");

                    int diasDiferenca = data1.Subtract(data2).Days;

                    if (diasDiferenca < 0)
                        diasDiferenca = diasDiferenca * (-1);

                    int anosDiferenca = (int)Math.Floor(diasDiferenca / 365.25);
                    int mesesDiferenca = (int)Math.Floor(diasDiferenca / (365.25 / 12));
                    int semanasDiferenca = (int)Math.Floor(diasDiferenca / (365.25 / (12 / 7)));
                    int horasDiferenca = (int)(diasDiferenca * 24);

                    txtResultado.Clear();

                    addTextBoxTitle("Diferença entre as Datas");
                    addTextBoxResult("Anos:\t", anosDiferenca.ToString());
                    addTextBoxResult("Meses:", mesesDiferenca.ToString());
                    addTextBoxResult("Semanas:", semanasDiferenca.ToString());
                    addTextBoxResult("Dias:\t", diasDiferenca.ToString());
                    addTextBoxResult("Horas:", horasDiferenca.ToString());
                } else if (acao == Utilidades.TipoOperacao.CALCULAR_ADD_DATAS)
                {
                    string pacoteRecebido = strData2; // formato: dias;semanas;meses
                    int addDias, addSemanas, addMeses;

                    if (!int.TryParse(pacoteRecebido.Split(new char[] { ';' })[0], out addDias))
                        throw new Exception("Houve um problema ao converter os dias recebidos em inteiro.");

                    if (!int.TryParse(pacoteRecebido.Split(new char[] { ';' })[1], out addSemanas))
                        throw new Exception("Houve um problema ao converter as semanas recebidas em inteiro.");

                    if (!int.TryParse(pacoteRecebido.Split(new char[] { ';' })[2], out addMeses))
                        throw new Exception("Houve um problema ao converter os meses recebidos em inteiro.");

                    DateTime data2 = data1.AddDays(addDias).AddDays(addSemanas * 7).AddMonths(addMeses);

                    txtResultado.Clear();
                    addTextBoxTitle("Data Futura");
                    addTextBoxResult("Resultado obtido:", data2.ToShortDateString());
                }
                else if (acao == Utilidades.TipoOperacao.CALCULAR_SUB_DATAS)
                {
                    string pacoteRecebido = strData2; // formato: dias;semanas;meses
                    int addDias, addSemanas, addMeses;

                    if (!int.TryParse(pacoteRecebido.Split(new char[] { ';' })[0], out addDias))
                        throw new Exception("Houve um problema ao converter os dias recebidos em inteiro.");

                    if (!int.TryParse(pacoteRecebido.Split(new char[] { ';' })[1], out addSemanas))
                        throw new Exception("Houve um problema ao converter as semanas recebidas em inteiro.");

                    if (!int.TryParse(pacoteRecebido.Split(new char[] { ';' })[2], out addMeses))
                        throw new Exception("Houve um problema ao converter os meses recebidos em inteiro.");

                    DateTime data2 = data1.AddDays(addDias * (-1)).AddDays(addSemanas * 7 * (-1)).AddMonths(addMeses * (-1));

                    txtResultado.Clear();
                    addTextBoxTitle("Data Futura");
                    addTextBoxResult("Resultado obtido:", data2.ToShortDateString());
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
            if (txtDia.TextLength >= 2 && Utilidades.ChecarTecla(e.KeyCode))
                txtMes.Focus();
        }

        private void txtMes_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMes.TextLength >= 2 && Utilidades.ChecarTecla(e.KeyCode))
                txtAno.Focus();
        }

        private void txtAno_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtAno.TextLength >= 4 && Utilidades.ChecarTecla(e.KeyCode))
                btnCalcular.Focus();
        }

        private void calculadoraMulticulturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCalcMultiCultural().ShowDialog();
        }

        private void rdHojeEData_CheckedChanged(object sender, EventArgs e)
        {
            acao = Utilidades.TipoOperacao.CALCULAR_IDADE;
        }

        private void rdAdicao_CheckedChanged(object sender, EventArgs e)
        {
            acao = Utilidades.TipoOperacao.CALCULAR_ADD_DATAS;
        }

        private void rdSubtracao_CheckedChanged(object sender, EventArgs e)
        {
            acao = Utilidades.TipoOperacao.CALCULAR_SUB_DATAS;
        }

        private void rdInformacoes_CheckedChanged(object sender, EventArgs e)
        {
            acao = Utilidades.TipoOperacao.INFO_DATA;
        }

        private void rdInfoEntreDatas_CheckedChanged(object sender, EventArgs e)
        {
            acao = Utilidades.TipoOperacao.INFO_ENTRE_DATAS;
        }

    }
}
