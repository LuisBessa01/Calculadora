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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrTelaSplash));
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            lblCarregando = new Label();
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
            // progressBar1
            // 
            progressBar1.Location = new Point(173, 159);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(470, 23);
            progressBar1.TabIndex = 4;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCarregando);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculadora 3001";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Label lblCarregando;
    }
}
