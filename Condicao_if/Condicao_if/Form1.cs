using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicao_if
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

        private void button1_Click(object sender, EventArgs e)
        {
            int idade;
            idade = Convert.ToInt32(textIdade.Text);
            if (idade < 18)
                MessageBox.Show("você é menor de idade", "Mensagem");
            else
                MessageBox.Show("você já é de maior", "Mensagem");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textIdade.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
