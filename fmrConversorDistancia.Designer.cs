namespace Calculadora
{
    partial class fmrConversorDistancia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrConversorDistancia));
            btnLimpar = new Button();
            label2 = new Label();
            label1 = new Label();
            txtCentimetros = new TextBox();
            btnCalculo = new Button();
            txtPolegadas = new TextBox();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Wheat;
            btnLimpar.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(24, 307);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(172, 88);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Crimson;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(24, 179);
            label2.Name = "label2";
            label2.Size = new Size(153, 34);
            label2.TabIndex = 11;
            label2.Text = "Polegadas (″)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkBlue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(24, 67);
            label1.Name = "label1";
            label1.Size = new Size(199, 34);
            label1.TabIndex = 10;
            label1.Text = "Centímetros (cm)";
            // 
            // txtCentimetros
            // 
            txtCentimetros.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCentimetros.Location = new Point(24, 106);
            txtCentimetros.Multiline = true;
            txtCentimetros.Name = "txtCentimetros";
            txtCentimetros.Size = new Size(364, 48);
            txtCentimetros.TabIndex = 9;
            // 
            // btnCalculo
            // 
            btnCalculo.BackColor = Color.Wheat;
            btnCalculo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculo.Location = new Point(217, 307);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Size = new Size(171, 88);
            btnCalculo.TabIndex = 8;
            btnCalculo.Text = "Converter";
            btnCalculo.UseVisualStyleBackColor = false;
            btnCalculo.Click += btnCalculo_Click;
            // 
            // txtPolegadas
            // 
            txtPolegadas.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPolegadas.Location = new Point(24, 216);
            txtPolegadas.Multiline = true;
            txtPolegadas.Name = "txtPolegadas";
            txtPolegadas.ReadOnly = true;
            txtPolegadas.Size = new Size(364, 48);
            txtPolegadas.TabIndex = 7;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(24, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // fmrConversorDistancia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(411, 457);
            Controls.Add(btnVoltar);
            Controls.Add(btnLimpar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCentimetros);
            Controls.Add(btnCalculo);
            Controls.Add(txtPolegadas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fmrConversorDistancia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor cm -> in″";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpar;
        private Label label2;
        private Label label1;
        private TextBox txtCentimetros;
        private Button btnCalculo;
        private TextBox txtPolegadas;
        private Button btnVoltar;
    }
}