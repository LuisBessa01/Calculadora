using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FmrCalculadora : Form
    {
        float valor1;
        string operacao = "";
        public FmrCalculadora()
        {
            InitializeComponent();
        }

        private void FmrMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txtVisor.Text);
            operacao = "soma";
            txtVisor.Clear();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtVisor.Text += '0';
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisor.Text += '1';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisor.Text += '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisor.Text += '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisor.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisor.Text += '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisor.Text += '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisor.Text += '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisor.Text += '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisor.Text += '9';
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txtVisor.Text);
            operacao = "subtracao";
            txtVisor.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txtVisor.Text);
            operacao = "multi";
            txtVisor.Clear();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(txtVisor.Text);
            operacao = "divisao";
            txtVisor.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (operacao)
            {
                case "soma":
                    txtVisor.Text = Convert.ToString(valor1 + Convert.ToSingle(txtVisor.Text));
                    break;

                case "subtracao":
                    txtVisor.Text = Convert.ToString(valor1 - Convert.ToSingle(txtVisor.Text));
                    break;

                case "multi":
                    txtVisor.Text = Convert.ToString(valor1 * Convert.ToSingle(txtVisor.Text));
                    break;

                case "divisao":
                    txtVisor.Text = Convert.ToString(valor1 / Convert.ToSingle(txtVisor.Text));
                    break;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
        }

        private void celsiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmrConversorTemperatura formularioTemperatura = new fmrConversorTemperatura();
            formularioTemperatura.ShowDialog();
        }

        private void FmrCalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
