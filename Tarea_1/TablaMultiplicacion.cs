using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacionAplicadaI.Tarea_1
{
    class TablaMultiplicacion
    {

        private int numero;

        public TablaMultiplicacion()
        {
            numero = 0;
        }

        public void Tabla()
        {
            Console.WriteLine("Inserte el numero para mostrar su tabla:");
            numero = Int16.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + numero * i);
            }

        }

    }
}
