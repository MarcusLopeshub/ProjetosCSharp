using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceito_While
{
    public partial class asdasd : Form
    {
        public asdasd()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            int c = 0;
            while (c<10000)
            {
                c = c + 1;
                IbINumero.Text = Convert.ToString(c);
                IbINumero.Refresh();
                /*Declaração de variável c, inicializada com zero.
                Condição: enquanto o c for menor que 10000 será 
                executado o laço Incremento
                Refresh é utilizado para que haja a variação dos números.*/
            }
        }
    }
}
