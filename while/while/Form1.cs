using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int numero=1;
            while (numero <= 10)
        {
            listBox.Items.Add(numero);
            numero = numero + 1;
            /*Declaração da variável numero do tipo inteiro,
            a variável foi inicializada com o numero 1.
            "Enquanto" o numero for menor ou igual 5 o listBox será preenchido
            expressão= numero+ numero1 é o incremento. */
        }
    }
}
}
