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
    public partial class frmNovaDataPadrao : Form
    {
        private frmCalcData formPai;
        private DateTime data1;
        private string strData1;

        public frmNovaDataPadrao(frmCalcData parent, DateTime data1, string strData1)
        {
            InitializeComponent();

            this.formPai = parent;
            this.data1 = data1;
            this.strData1 = strData1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string strData = txtAno.Text + "-" + txtMes.Text.PadLeft(2, '0') + "-" + txtDia.Text.PadLeft(2, '0');
                if (!Utilidades.ValidarData(strData)) return;

                formPai.NovaDataInserida(strData, data1, strData1);
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                btnOK.Focus();
        }
    }
}
