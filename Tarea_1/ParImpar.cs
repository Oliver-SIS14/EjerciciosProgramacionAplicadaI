using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacionAplicadaI.Tarea_1
{
    class ParImpar
    {

        int numero;

        public ParImpar()
        {
            numero = 0;
        }

        public void ParOImpar()
        {
            Console.WriteLine("Inserte el numero a evaluar: ");
            numero = Int16.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("Es par.");
            else
                Console.WriteLine("Es impar.");
        }

    }
}
