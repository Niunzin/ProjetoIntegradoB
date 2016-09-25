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
    public partial class frmCalcMultiCultural : Form
    {
        List<string> calendarioJudaico;
        List<string> calendarioIslamico;
        List<string> calendarioChines;

        public frmCalcMultiCultural()
        {
            InitializeComponent();

            calendarioJudaico = new List<string>();
            calendarioJudaico.Add("8 Sivan, 5750");
            calendarioJudaico.Add("22 Kislev, 5757");
            calendarioJudaico.Add("1 Adar I, 5760");
            calendarioJudaico.Add("2 Tevet, 5766");
            calendarioJudaico.Add("22 Tishrei, 5773");
            calendarioJudaico.Add("9 Iyar, 5774");
            calendarioJudaico.Add("15 Nissan, 5776");
            calendarioJudaico.Add("5 Elul, 5778");
            calendarioJudaico.Add("20 Tamuz, 5780");

            calendarioIslamico = new List<string>();
            calendarioIslamico.Add("7 Dhu I-Qa `da, 1410");
            calendarioIslamico.Add("22 Rajab, 1417");
            calendarioIslamico.Add("2 Dhu I-Qa `da, 1420");
            calendarioIslamico.Add("2 Dhu I-Hijja, 1426");
            calendarioIslamico.Add("22 Dhu I-Qa `da, 1433");
            calendarioIslamico.Add("9 Rajab, 1435");
            calendarioIslamico.Add("15 Rajab, 1437");
            calendarioIslamico.Add("4 Dhu I-Hijja, 1439");
            calendarioIslamico.Add("21 Dhu I-Qa `da, 1441");

            calendarioChines = new List<string>();
            calendarioChines.Add("庚午年五月初九，马年, Ano do Cavalo");
            calendarioChines.Add("丙子年十月廿三，鼠年, Ano do Rato");
            calendarioChines.Add("庚辰年正月初三，龙年, Ano do Dragão");
            calendarioChines.Add("乙酉年腊月初三，鸡年, Ano do Galo");
            calendarioChines.Add("壬辰年八月廿三，龙年, Ano do Dragão");
            calendarioChines.Add("甲午年四月十一，马年, Ano do Cavalo");
            calendarioChines.Add("丙申年三月十七，猴年, Ano do Macaco");
            calendarioChines.Add("戊戌年七月初六，狗年, Ano do Cão");
            calendarioChines.Add("庚子年五月廿二，鼠年, Ano do Rato");
        }

        private void frmCalcMultiCultural_Load(object sender, EventArgs e)
        {
            this.FindForm();
            this.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox.SelectedIndex;

            listBox.Items.Clear();
            listBox.Items.Add("Calendário Judáico:");
            listBox.Items.Add(calendarioJudaico.ElementAt(index));
            listBox.Items.Add("");
            listBox.Items.Add("Calendário Muçulmano (Islâmico):");
            listBox.Items.Add(calendarioIslamico.ElementAt(index));
            listBox.Items.Add("");
            listBox.Items.Add("Calendário Chinês:");
            listBox.Items.Add(calendarioChines.ElementAt(index));
        }
    }
}
