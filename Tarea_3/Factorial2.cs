using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_programacionAplicadaI.Tarea_3
{
    public partial class Factorial2 : Form
    {
        public Factorial2()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            int numero;

            numero = Convert.ToInt32(NumeroTextBox.Text);

            for(int i=numero-1; i>1; i--)
            {
                numero *= i;
                Console.WriteLine("\n" + numero);
            }

            Console.WriteLine("El factorial es: " + numero);

            FactorialTextBox.Text = Convert.ToString(numero);
        }
    }
}
