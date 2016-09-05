using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_F2.Modulos.Escala
{
    public partial class frmEscala : Form
    {
        internal int indiceAtual = 0;

        public frmEscala()
        {
            InitializeComponent();
        }

        private void txtTemp_ValueChanged(object sender, EventArgs e)
        {
            CalculoEscala.Temperatura Temperatura = CalculoEscala.Temperatura.CELSIUS;
            decimal Valor = txtTemp.Value;

            switch(indiceAtual)
            {
                case 1:
                    Temperatura = CalculoEscala.Temperatura.KELVIN;
                    break;
                case 2:
                    Temperatura = CalculoEscala.Temperatura.FAHRENHEIT;
                    break;
                default:
                    Temperatura = CalculoEscala.Temperatura.CELSIUS;
                    break;
            }

            txtCelsius.Text = string.Format("{0} ºC", Math.Round(CalculoEscala.Converter(Temperatura, Valor, CalculoEscala.Temperatura.CELSIUS), 2));
            txtKelvin.Text = string.Format("{0} K", Math.Round(CalculoEscala.Converter(Temperatura, Valor, CalculoEscala.Temperatura.KELVIN), 2));
            txtFah.Text = string.Format("{0} ºF", Math.Round(CalculoEscala.Converter(Temperatura, Valor, CalculoEscala.Temperatura.FAHRENHEIT), 2));
        }

        private void rdCelsius_CheckedChanged(object sender, EventArgs e)
        {
            this.indiceAtual = 0;
            txtTemp_ValueChanged(null, null);
        }

        private void rdKevin_CheckedChanged(object sender, EventArgs e)
        {
            this.indiceAtual = 1;
            txtTemp_ValueChanged(null, null);
        }

        private void rdFah_CheckedChanged(object sender, EventArgs e)
        {
            this.indiceAtual = 2;
            txtTemp_ValueChanged(null, null);
        }

        private void txtTemp_KeyDown(object sender, KeyEventArgs e)
        {
            txtTemp_ValueChanged(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEscala_Load(object sender, EventArgs e)
        {
            txtTemp_ValueChanged(null, null);
        }
    }
}
