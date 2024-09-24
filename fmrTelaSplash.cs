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
            if (pgbCarregando.Value < 40)
            {
                pgbCarregando.Value += 2;
            }
            else
            {
                tmrCarregando.Interval = 500;
                if (pgbCarregando.Value == 100)
                {
                    tmrCarregando.Stop();
                    this.Hide();
                    FmrMenu formularioMenu = new FmrMenu();
                    formularioMenu.ShowDialog();
                }
                else
                {
                    pgbCarregando.Value += 10;
                }
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
