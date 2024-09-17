namespace Calculadora
{
    public partial class fmrTelaSplash : Form
    {
        List<string> carregando = new List<string>();
        int pontosAtuais = 1;

        public fmrTelaSplash()
        {
            InitializeComponent();
        }

        private void tmrCarregando_Tick(object sender, EventArgs e)
        {
            pgbCarregando.Value += 2;
        }

        private void tmrDescarregando_Tick(object sender, EventArgs e)
        {
            tmrCarregando02.Start();
            tmrCarregando.Stop();
            tmrMudarCarregamento.Stop();
        }

        private void tmrDescarregando_Tick_1(object sender, EventArgs e)
        {
            pgbCarregando.Value += 10;
            if (pgbCarregando.Value == pgbCarregando.Maximum)
            {
                tmrCarregando02.Enabled= false;
                this.Hide();
            }
        }

        private void tmrTresPontos_Tick(object sender, EventArgs e)
        {

            if (pontosAtuais == 1)
            {
                lblCarregando.Text = carregando[1];
                pontosAtuais = 2;
            }

            else if (pontosAtuais == 2)
            {
                lblCarregando.Text = carregando[2];
                pontosAtuais = 3;
            }

            else if (pontosAtuais == 3)
            {
                lblCarregando.Text = carregando[0];
                pontosAtuais = 1;
            }
        }

        private void fmrTelaSplash_Load(object sender, EventArgs e)
        {
            carregando.Add("Carregando.");
            carregando.Add("Carregando..");
            carregando.Add("Carregando...");
        }
    }
}
