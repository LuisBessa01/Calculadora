namespace Calculadora
{
    partial class fmrConversorTemperatura
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
            txtGrausFahrenheit = new TextBox();
            btnCalculo = new Button();
            txtGrausCelsius = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // txtGrausFahrenheit
            // 
            txtGrausFahrenheit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrausFahrenheit.Location = new Point(12, 223);
            txtGrausFahrenheit.Multiline = true;
            txtGrausFahrenheit.Name = "txtGrausFahrenheit";
            txtGrausFahrenheit.Size = new Size(364, 48);
            txtGrausFahrenheit.TabIndex = 1;
            // 
            // btnCalculo
            // 
            btnCalculo.BackColor = Color.Wheat;
            btnCalculo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculo.Location = new Point(205, 314);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Size = new Size(171, 88);
            btnCalculo.TabIndex = 2;
            btnCalculo.Text = "Converter";
            btnCalculo.UseVisualStyleBackColor = false;
            // 
            // txtGrausCelsius
            // 
            txtGrausCelsius.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGrausCelsius.Location = new Point(12, 113);
            txtGrausCelsius.Multiline = true;
            txtGrausCelsius.Name = "txtGrausCelsius";
            txtGrausCelsius.Size = new Size(364, 48);
            txtGrausCelsius.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkBlue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(202, 34);
            label1.TabIndex = 4;
            label1.Text = "Graus Celsius (°C)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Crimson;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 186);
            label2.Name = "label2";
            label2.Size = new Size(229, 34);
            label2.TabIndex = 5;
            label2.Text = "Graus Fahrenheit (F)";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Wheat;
            btnLimpar.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(12, 314);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(172, 88);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // fmrConversorTemperatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(388, 450);
            Controls.Add(btnLimpar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGrausCelsius);
            Controls.Add(btnCalculo);
            Controls.Add(txtGrausFahrenheit);
            Name = "fmrConversorTemperatura";
            Text = "Conversor °C -> F";
            Load += fmrConversorTemperatura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox txtGrausFahrenheit;
        private Button btnCalculo;
        private TextBox txtGrausCelsius;
        private Label label1;
        private Label label2;
        private Button btnLimpar;
    }
}