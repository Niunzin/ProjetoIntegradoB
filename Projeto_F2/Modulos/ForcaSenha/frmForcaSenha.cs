using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_F2.Modulos.ForcaSenha
{
    public partial class frmForcaSenha : Form
    {
        public frmForcaSenha()
        {
            InitializeComponent();
        }

        private void frmForcaSenha_Load(object sender, EventArgs e)
        {
            progressBar.Width = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            try
            {
                int pontuacao = AvaliarSenha.ObterForca(txtSenha.Text);

                if (pontuacao >= 0)
                    progressBar.Width = (pontuacao * 227) / 10;

                progressBar.ForeColor = Color.Black;

                if(pontuacao >= 0)
                    lbPontos.Text = "Sua senha possui " + pontuacao + " pontos.";

                Console.WriteLine(pontuacao);
                Console.WriteLine((pontuacao * 227) / 10);

                if (pontuacao >= 9)
                {
                    progressBar.BackColor = Color.Green;
                    progressBar.Text = "Muito Forte";
                }
                else if (pontuacao >= 7)
                {
                    progressBar.BackColor = Color.LightGreen;
                    progressBar.Text = "Forte";
                }
                else if (pontuacao >= 5)
                {
                    progressBar.BackColor = Color.Yellow;
                    progressBar.Text = "Razoável";
                }
                else if (pontuacao >= 3)
                {
                    progressBar.BackColor = Color.Red;
                    progressBar.Text = "Fraca";
                }
                else
                {
                    progressBar.Width = 0;
                    progressBar.BackColor = Color.Black;
                    progressBar.ForeColor = Color.White;
                    progressBar.Text = "Muito Fraca";

                    if (pontuacao < 0)
                        MessageBox.Show(AvaliarSenha.ObterMensagem(pontuacao), "Senha insegura!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSenha.Text);
            MessageBox.Show("A senha foi copiada com sucesso!", "Sucesso!" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
