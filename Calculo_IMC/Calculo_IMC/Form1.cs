using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura *altura);
            txtIMC.Text = imc.ToString("0.00");
            if (imc < 18.49)
                MessageBox.Show("SITUAÇÃO: Você está abaixo do Peso",
                    "Cálculo de IMC",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            else if (imc < 24.99)
                MessageBox.Show("SITUAÇÃO: Você está com o Peso dentro " +
                    "da Normalidade", "Cálculo de IMC",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            else if (imc < 29.99)
                MessageBox.Show("SITUAÇÂO: Você está acima do Peso",
                    "Cálculo de IMC",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            else if (imc < 34.99)
                MessageBox.Show("ATENÇÃO! Voccê está com obesidade grau I",
                    "Cálculo de IMC",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            else if (imc < 39.99)
                MessageBox.Show("ATENÇÃO! Você está com besidade grau II",
                    "Cálculo de IMC",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            else
                MessageBox.Show("ATENÇÃO! Você está com grau de obesidade grau III" +
                    "(mórbidade)", "Cálculo de IMC",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);

                    
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Text = ("");
            txtAltura.Text = ("");
            txtIMC.Text = ("");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
