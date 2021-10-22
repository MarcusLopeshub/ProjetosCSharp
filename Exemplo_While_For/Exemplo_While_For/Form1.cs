using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_While_For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboAno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int contador;
            for (contador = 2016; contador >= 1950; contador --)
            {
                cboAno.Items.Add(contador);
            }/*Declaração da variável contador do tipo inteiro laço For
            - Atribuído o valor de 2016 (ano), até que o ano seja 
            maior ou igual a 1950, o contador vai fazendo um descremento.
            Ou seja começa com 2016 e vai até 1950.
            Em seguida os itens são adicionados no Contador. */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            /*Declara o objeto novo tipo from e chama em seguida atravéz
            do método Show.*/
            novo.Show();
            //fecha o formulário atual
            this.Visible = false;
        }
        
    }
}
