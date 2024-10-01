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
    public partial class fmrConversorDistancia : Form
    {
        double distanciaAntes;
        public fmrConversorDistancia()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            distanciaAntes = Convert.ToDouble(txtCentimetros.Text);
            txtPolegadas.Text = Convert.ToString(distanciaAntes * 2.5);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCentimetros.Text = "";
            txtPolegadas.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FmrCalculadora formularioCalculadora = new FmrCalculadora();
            formularioCalculadora.Show();
            this.Close();
        }
    }
}
