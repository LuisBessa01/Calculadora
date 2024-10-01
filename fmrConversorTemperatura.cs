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
    public partial class fmrConversorTemperatura : Form
    {
        double temperaturaAntes;
        public fmrConversorTemperatura()
        {
            InitializeComponent();
        }

        private void fmrConversorTemperatura_Load(object sender, EventArgs e)
        {

        }

        private void celsiusCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            temperaturaAntes = Convert.ToDouble(txtGrausCelsius.Text);
            txtGrausFahrenheit.Text = Convert.ToString(temperaturaAntes * 1.8 + 32);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtGrausCelsius.Text = "";
            txtGrausFahrenheit.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FmrCalculadora formularioCalculadora = new FmrCalculadora();
            formularioCalculadora.Show();
            this.Close();
        }
    }
}
