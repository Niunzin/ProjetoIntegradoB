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
    public partial class frmControleData : Form
    {
        private frmCalcData frmPai;
        private int tipo = 0; // 0 = indefinido; 1 = add; 2 = sub;
        DateTime data1;
        string strData1;

        public frmControleData(frmCalcData parent, string acao, DateTime data1, string strData1)
        {
            InitializeComponent();

            frmPai = parent;
            this.data1 = data1;
            this.strData1 = strData1;
            
            if (acao == "add")
            {
                tipo = 1;
                grpBox.Text = "Adicionar à data";
            } else if (acao == "sub")
            {
                tipo = 2;
                grpBox.Text = "Subtrair da data";
            }

            if (tipo == 0)
                this.Close();
        }

        private void frmControleData_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string paramData = numDias.Value + ";" + numSemanas.Value + ";" + numMeses.Value;
            frmPai.NovaDataInserida(paramData, data1, strData1);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
