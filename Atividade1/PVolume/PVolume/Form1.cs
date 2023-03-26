using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {

        double raio, altura, volume;
        //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        public Form1()
        {
            InitializeComponent(); 
        }

        private void tbRaio_Validated(object sender, EventArgs e)
        {

            if (!double.TryParse(tbRaio.Text, out raio))
            {
                MessageBox.Show("Raio inválido");
            }
            else
                if (raio <= 0)
            {
                MessageBox.Show("Valor do raio deve ser maior que zero");
            }
        }

        private void tbAltura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(tbAltura.Text, out altura))
            {
                MessageBox.Show("Altura inválido");
            }
            else
                if (altura <= 0)
            {
                MessageBox.Show("Valor da altura deve ser maior que zero");
            }
        }

        private void tbRaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar == (char)(13))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void tbAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar == (char)(13))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btn_calcular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            tbVolume.Text = (Math.PI * (double.Parse(tbRaio.Text) * double.Parse(tbRaio.Text)) * double.Parse(tbAltura.Text)).ToString("N2");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
