﻿namespace Calculadora
{
    partial class FmrCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrCalculadora));
            txtVisor = new TextBox();
            btnSoma = new Button();
            btnSubtracao = new Button();
            btnMulti = new Button();
            btnDivisao = new Button();
            btnLimpar = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            button9 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnIgual = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            menuStrip1 = new MenuStrip();
            conversorToolStripMenuItem = new ToolStripMenuItem();
            mspConversorTemperatura = new ToolStripMenuItem();
            mspConversorDistancia = new ToolStripMenuItem();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            mspSair = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtVisor
            // 
            txtVisor.Enabled = false;
            txtVisor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVisor.Location = new Point(41, 72);
            txtVisor.Multiline = true;
            txtVisor.Name = "txtVisor";
            txtVisor.Size = new Size(410, 93);
            txtVisor.TabIndex = 0;
            txtVisor.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(41, 171);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(80, 80);
            btnSoma.TabIndex = 1;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += button1_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(149, 171);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(80, 80);
            btnSubtracao.TabIndex = 2;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(257, 171);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(80, 80);
            btnMulti.TabIndex = 3;
            btnMulti.Text = "X";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(371, 171);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(80, 80);
            btnDivisao.TabIndex = 4;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(371, 269);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(80, 80);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "CLEAR";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(257, 269);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 80);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(149, 269);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 80);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(41, 269);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 80);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // button9
            // 
            button9.Location = new Point(371, 378);
            button9.Name = "button9";
            button9.Size = new Size(80, 80);
            button9.TabIndex = 12;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(257, 378);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 80);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(149, 378);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 80);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(41, 378);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 80);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(371, 478);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(80, 181);
            btnIgual.TabIndex = 16;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(149, 478);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 80);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(41, 478);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 80);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(257, 478);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 80);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(41, 579);
            btn0.Name = "btn0";
            btn0.Size = new Size(296, 80);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { conversorToolStripMenuItem, arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(509, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // conversorToolStripMenuItem
            // 
            conversorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mspConversorTemperatura, mspConversorDistancia });
            conversorToolStripMenuItem.Name = "conversorToolStripMenuItem";
            conversorToolStripMenuItem.Size = new Size(73, 20);
            conversorToolStripMenuItem.Text = "Conversor";
            // 
            // mspConversorTemperatura
            // 
            mspConversorTemperatura.Name = "mspConversorTemperatura";
            mspConversorTemperatura.Size = new Size(212, 22);
            mspConversorTemperatura.Text = "Celsius -> Fahrenheit";
            mspConversorTemperatura.Click += celsiusToolStripMenuItem_Click;
            // 
            // mspConversorDistancia
            // 
            mspConversorDistancia.Name = "mspConversorDistancia";
            mspConversorDistancia.Size = new Size(212, 22);
            mspConversorDistancia.Text = "Centímetros -> Polegadas";
            mspConversorDistancia.Click += mspConversorDistancia_Click;
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mspSair });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // mspSair
            // 
            mspSair.Name = "mspSair";
            mspSair.Size = new Size(93, 22);
            mspSair.Text = "Sair";
            mspSair.Click += mspSair_Click;
            // 
            // FmrCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 681);
            Controls.Add(btn0);
            Controls.Add(btnIgual);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(button9);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnLimpar);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDivisao);
            Controls.Add(btnMulti);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSoma);
            Controls.Add(txtVisor);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FmrCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            FormClosed += FmrCalculadora_FormClosed;
            Load += FmrMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVisor;
        private Button btnSoma;
        private Button btnSubtracao;
        private Button btnMulti;
        private Button btnDivisao;
        private Button btnLimpar;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button button9;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnIgual;
        private Button btn2;
        private Button btn1;
        private Button btn3;
        private Button btn0;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem conversorToolStripMenuItem;
        private ToolStripMenuItem mspConversorTemperatura;
        private ToolStripMenuItem mspConversorDistancia;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem mspSair;
    }
}