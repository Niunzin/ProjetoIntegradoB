using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_F2.Modulos.Utilitarios.Criptografia
{
    public partial class frmCripto : Form
    {
        public frmCripto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbResultado.Text))
                return;

            Clipboard.SetText(lbResultado.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lbResultado.Text = Cripto.Codificar(txtMensagem.Text, (int)numericUpDown.Value);

                StreamWriter sw = new StreamWriter("cripto.txt", true);
                sw.WriteLine(lbResultado.Text);
                sw.Close();
            } catch (Exception er)
            {
                MessageBox.Show(er.StackTrace + '\n' + er.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCripto_Load(object sender, EventArgs e)
        {
        }
    }
}
