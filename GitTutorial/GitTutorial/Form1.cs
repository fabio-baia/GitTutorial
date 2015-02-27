using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTutorial
{
    public partial class CALCULADORA : Form
    {
        public CALCULADORA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            MessageBox.Show("Hello World!!");
=======
>>>>>>> criando calculadora
        }

        private void SOMA_Click(object sender, EventArgs e)
        {
            double n1, n2, calculo;

            n1 = double.Parse(TB_N1.Text);

            n2 = double.Parse(TB_N2.Text);

            calculo = n1 + n2;

            TB_RESULTADO.Text = calculo.ToString();

            MessageBox.Show("Funcionalidade Emersonnnn = " + TB_RESULTADO.Text);


           }

        private void DIVISAO_Click(object sender, EventArgs e)
        {
            double n1, n2, calculo;

            n1 = double.Parse(TB_N1.Text);

            n2 = double.Parse(TB_N2.Text);

            calculo = n1 / n2;

            TB_RESULTADO.Text = calculo.ToString();

            MessageBox.Show("Funcionalidade Emersonnnn = " + TB_RESULTADO.Text);
        }

        private void SUBTRACAO_Click(object sender, EventArgs e)
        {
            double n1, n2, calculo;

            n1 = double.Parse(TB_N1.Text);

            n2 = double.Parse(TB_N2.Text);

            calculo = n1 - n2;

            TB_RESULTADO.Text = calculo.ToString();

            MessageBox.Show("Funcionalidade Emersonnnn = " + TB_RESULTADO.Text);
        }

        private void MULTIPLICAO_Click(object sender, EventArgs e)
        {
            double n1, n2, calculo;

            n1 = double.Parse(TB_N1.Text);

            n2 = double.Parse(TB_N2.Text);

            calculo = n1 * n2;

            TB_RESULTADO.Text = calculo.ToString();

            MessageBox.Show("Funcionalidade Emersonnnn = " + TB_RESULTADO.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

      }
}
