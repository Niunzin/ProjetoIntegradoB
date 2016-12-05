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
        class Acao
        {
            public const int ENC = 1;
            public const int DEC = 2;
        }

        private int acao = 0;

        public frmCripto(int ac)
        {
            InitializeComponent();
            this.acao = ac;
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
                if (acao == Acao.ENC)
                {
                    lbResultado.Text = Cripto.Codificar(txtMensagem.Text, (int)numericUpDown.Value);
                    StreamWriter sw = new StreamWriter("cripto.txt", true);
                    sw.WriteLine(lbResultado.Text);
                    sw.Close();
                }
                else
                {
                    lbResultado.Text = Cripto.Decodificar(txtMensagem.Text, (int)numericUpDown.Value);
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.StackTrace + '\n' + er.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCripto_Load(object sender, EventArgs e)
        {
        }
    }
}
