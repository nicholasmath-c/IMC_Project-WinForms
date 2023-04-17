
namespace IMC_Project
{
    partial class CalculadoraIMC
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.MaskedTextBox();
            this.numIdade = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIMC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClassificacao = new System.Windows.Forms.Label();
            this.lblDica = new System.Windows.Forms.Label();
            this.txtDica = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DM Sans", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(208, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de IMC";
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("DM Sans", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(145, 255);
            this.txtAltura.Mask = "0.00";
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(200, 48);
            this.txtAltura.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altura (ex: 1,70):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Peso (ex: 60,55 ou 100,67):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("DM Sans", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(456, 255);
            this.txtPeso.Mask = "00.00";
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPeso.Size = new System.Drawing.Size(200, 48);
            this.txtPeso.TabIndex = 2;
            this.txtPeso.ValidatingType = typeof(int);
            this.txtPeso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPeso_KeyDown);
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // numIdade
            // 
            this.numIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numIdade.Font = new System.Drawing.Font("DM Sans", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIdade.Location = new System.Drawing.Point(145, 386);
            this.numIdade.Name = "numIdade";
            this.numIdade.Size = new System.Drawing.Size(200, 48);
            this.numIdade.TabIndex = 11;
            this.numIdade.ValueChanged += new System.EventHandler(this.numIdade_ValueChanged);
            this.numIdade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numIdade_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Idade:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(451, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gênero:";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Font = new System.Drawing.Font("DM Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasculino.Location = new System.Drawing.Point(456, 375);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(128, 32);
            this.rdbMasculino.TabIndex = 14;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Font = new System.Drawing.Font("DM Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFeminino.Location = new System.Drawing.Point(456, 413);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(118, 32);
            this.rdbFeminino.TabIndex = 15;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.txtIMC);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(255, 671);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 83);
            this.panel1.TabIndex = 16;
            // 
            // txtIMC
            // 
            this.txtIMC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIMC.AutoSize = true;
            this.txtIMC.Font = new System.Drawing.Font("DM Sans", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMC.ForeColor = System.Drawing.Color.White;
            this.txtIMC.Location = new System.Drawing.Point(162, 19);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(40, 41);
            this.txtIMC.TabIndex = 1;
            this.txtIMC.Text = "0";
            this.txtIMC.Click += new System.EventHandler(this.lblIMC_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DM Sans", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 41);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seu IMC:";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnCalc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnCalc.FlatAppearance.BorderSize = 2;
            this.btnCalc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(181)))), ((int)(((byte)(253)))));
            this.btnCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(214)))), ((int)(((byte)(254)))));
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("DM Sans", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(145, 496);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(348, 71);
            this.btnCalc.TabIndex = 17;
            this.btnCalc.Text = "CALCULAR";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("DM Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.label7.Location = new System.Drawing.Point(250, 787);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "Classificação:";
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.AutoSize = true;
            this.txtClassificacao.Font = new System.Drawing.Font("DM Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassificacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtClassificacao.Location = new System.Drawing.Point(398, 787);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(104, 28);
            this.txtClassificacao.TabIndex = 19;
            this.txtClassificacao.Text = "Nenhuma";
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblDica.Location = new System.Drawing.Point(108, 894);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(58, 25);
            this.lblDica.TabIndex = 20;
            this.lblDica.Text = "Dica:";
            this.lblDica.Visible = false;
            // 
            // txtDica
            // 
            this.txtDica.AutoSize = true;
            this.txtDica.Font = new System.Drawing.Font("DM Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDica.ForeColor = System.Drawing.Color.Black;
            this.txtDica.Location = new System.Drawing.Point(165, 894);
            this.txtDica.Name = "txtDica";
            this.txtDica.Size = new System.Drawing.Size(432, 25);
            this.txtDica.TabIndex = 21;
            this.txtDica.Text = "Para chegar no peso ideal para você, precisa de";
            this.txtDica.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(164)))), ((int)(((byte)(175)))));
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("DM Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            this.btnLimpar.Location = new System.Drawing.Point(522, 510);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(134, 47);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("DM Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(122, 945);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(523, 28);
            this.label8.TabIndex = 23;
            this.label8.Text = "OBS: Se o seu peso estiver classificado como \"Normal\", o peso ideal não precisa s" +
    "er seguido a risca, \r\né apenas um cálculo preciso baseado nas informações fornec" +
    "idas";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculadoraIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(789, 985);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtDica);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdbFeminino);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numIdade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CalculadoraIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMC - Project";
            ((System.ComponentModel.ISupportInitialize)(this.numIdade)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtAltura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtPeso;
        private System.Windows.Forms.NumericUpDown numIdade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtIMC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtClassificacao;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.Label txtDica;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label8;
    }
}

