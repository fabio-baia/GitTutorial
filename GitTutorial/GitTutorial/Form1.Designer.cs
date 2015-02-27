namespace GitTutorial
{
    partial class CALCULADORA
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SOMA = new System.Windows.Forms.Button();
            this.TB_N1 = new System.Windows.Forms.TextBox();
            this.TB_N2 = new System.Windows.Forms.TextBox();
            this.TB_RESULTADO = new System.Windows.Forms.TextBox();
            this.VALOR_A = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SUBTRACAO = new System.Windows.Forms.Button();
            this.DIVISAO = new System.Windows.Forms.Button();
            this.MULTIPLICAO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // SOMA
            // 
            this.SOMA.Location = new System.Drawing.Point(219, 54);
            this.SOMA.Name = "SOMA";
            this.SOMA.Size = new System.Drawing.Size(102, 23);
            this.SOMA.TabIndex = 0;
            this.SOMA.Text = "SOMA";
            this.SOMA.UseVisualStyleBackColor = true;
            this.SOMA.Click += new System.EventHandler(this.SOMA_Click);
            // 
            // TB_N1
            // 
            this.TB_N1.Location = new System.Drawing.Point(92, 57);
            this.TB_N1.Name = "TB_N1";
            this.TB_N1.Size = new System.Drawing.Size(100, 20);
            this.TB_N1.TabIndex = 1;
            // 
            // TB_N2
            // 
            this.TB_N2.Location = new System.Drawing.Point(92, 86);
            this.TB_N2.Name = "TB_N2";
            this.TB_N2.Size = new System.Drawing.Size(100, 20);
            this.TB_N2.TabIndex = 2;
            // 
            // TB_RESULTADO
            // 
            this.TB_RESULTADO.Location = new System.Drawing.Point(92, 144);
            this.TB_RESULTADO.Name = "TB_RESULTADO";
            this.TB_RESULTADO.Size = new System.Drawing.Size(100, 20);
            this.TB_RESULTADO.TabIndex = 3;
            // 
            // VALOR_A
            // 
            this.VALOR_A.AutoSize = true;
            this.VALOR_A.Location = new System.Drawing.Point(12, 64);
            this.VALOR_A.Name = "VALOR_A";
            this.VALOR_A.Size = new System.Drawing.Size(53, 13);
            this.VALOR_A.TabIndex = 4;
            this.VALOR_A.Text = "VALOR A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "VALOR B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "RESULTADO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "GitTutorial";
            // SUBTRACAO
            // 
            this.SUBTRACAO.Location = new System.Drawing.Point(219, 112);
            this.SUBTRACAO.Name = "SUBTRACAO";
            this.SUBTRACAO.Size = new System.Drawing.Size(102, 23);
            this.SUBTRACAO.TabIndex = 7;
            this.SUBTRACAO.Text = "SUBTRAÇÂO";
            this.SUBTRACAO.UseVisualStyleBackColor = true;
            this.SUBTRACAO.Click += new System.EventHandler(this.SUBTRACAO_Click);
            // 
            this.button1.Location = new System.Drawing.Point(13, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hello";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // DIVISAO
            // 
            // Form1
            this.DIVISAO.Location = new System.Drawing.Point(219, 83);
            this.DIVISAO.Name = "DIVISAO";
            this.DIVISAO.Size = new System.Drawing.Size(102, 23);
            this.DIVISAO.TabIndex = 8;
            this.DIVISAO.Text = "DIVISÂO";
            this.DIVISAO.UseVisualStyleBackColor = true;
            this.DIVISAO.Click += new System.EventHandler(this.DIVISAO_Click);
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            // button1
            // MULTIPLICAO
            // 
            this.MULTIPLICAO.Location = new System.Drawing.Point(219, 141);
            this.MULTIPLICAO.Name = "MULTIPLICAO";
            this.MULTIPLICAO.Size = new System.Drawing.Size(102, 23);
            this.MULTIPLICAO.TabIndex = 9;
            this.MULTIPLICAO.Text = "MULTIPLICAÇÂO";
            this.MULTIPLICAO.UseVisualStyleBackColor = true;
            this.MULTIPLICAO.Click += new System.EventHandler(this.MULTIPLICAO_Click);
            // 
            // CALCULADORA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(347, 186);
            this.Controls.Add(this.MULTIPLICAO);
            this.Controls.Add(this.DIVISAO);
            this.Controls.Add(this.SUBTRACAO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VALOR_A);
            this.Controls.Add(this.TB_RESULTADO);
            this.Controls.Add(this.TB_N2);
            this.Controls.Add(this.TB_N1);
            this.Controls.Add(this.SOMA);
            this.Name = "CALCULADORA";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valorA;
        private System.Windows.Forms.TextBox valorB;
        private System.Windows.Forms.Button SOMA;
        private System.Windows.Forms.TextBox TB_N1;
        private System.Windows.Forms.TextBox TB_N2;
        private System.Windows.Forms.TextBox TB_RESULTADO;
        private System.Windows.Forms.Label VALOR_A;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SUBTRACAO;
        private System.Windows.Forms.Button DIVISAO;
        private System.Windows.Forms.Button MULTIPLICAO;
    }
}

