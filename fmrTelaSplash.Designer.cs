namespace Calculadora
{
    partial class fmrTelaSplash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrTelaSplash));
            pictureBox1 = new PictureBox();
            pgbCarregando = new ProgressBar();
            lblCarregando = new Label();
            tmrCarregando = new System.Windows.Forms.Timer(components);
            tmrMudarCarregamento = new System.Windows.Forms.Timer(components);
            tmrCarregando02 = new System.Windows.Forms.Timer(components);
            tmrTresPontos = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.be_patient_waiting;
            pictureBox1.Location = new Point(264, 204);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pgbCarregando
            // 
            pgbCarregando.Location = new Point(173, 159);
            pgbCarregando.Name = "pgbCarregando";
            pgbCarregando.Size = new Size(470, 23);
            pgbCarregando.TabIndex = 4;
            // 
            // lblCarregando
            // 
            lblCarregando.AutoSize = true;
            lblCarregando.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarregando.Location = new Point(200, 48);
            lblCarregando.Name = "lblCarregando";
            lblCarregando.Size = new Size(416, 90);
            lblCarregando.TabIndex = 5;
            lblCarregando.Text = "Carregando.";
            // 
            // tmrCarregando
            // 
            tmrCarregando.Enabled = true;
            tmrCarregando.Tick += tmrCarregando_Tick;
            // 
            // tmrMudarCarregamento
            // 
            tmrMudarCarregamento.Enabled = true;
            tmrMudarCarregamento.Interval = 2800;
            tmrMudarCarregamento.Tick += tmrDescarregando_Tick;
            // 
            // tmrCarregando02
            // 
            tmrCarregando02.Interval = 1500;
            tmrCarregando02.Tick += tmrDescarregando_Tick_1;
            // 
            // tmrTresPontos
            // 
            tmrTresPontos.Enabled = true;
            tmrTresPontos.Interval = 500;
            tmrTresPontos.Tick += tmrTresPontos_Tick;
            // 
            // fmrTelaSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCarregando);
            Controls.Add(pgbCarregando);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fmrTelaSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora 3001";
            Load += fmrTelaSplash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar pgbCarregando;
        private Label lblCarregando;
        private System.Windows.Forms.Timer tmrCarregando;
        private System.Windows.Forms.Timer tmrMudarCarregamento;
        private System.Windows.Forms.Timer tmrCarregando02;
        private System.Windows.Forms.Timer tmrTresPontos;
    }
}
