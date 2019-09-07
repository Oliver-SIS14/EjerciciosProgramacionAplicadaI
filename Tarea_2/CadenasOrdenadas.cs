using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacionAplicadaI.Tarea_2
{
    public class CadenasOrdenadas
    {

        public CadenasOrdenadas()
        {

        }

        public void OrdenarCadenas()
        {
            int comparacion;
            string cadena1, cadena2;

            Console.WriteLine("Inserte la cadena 1: ");
            cadena1 = Console.ReadLine();
            Console.WriteLine("\nInserte la cadena 2: ");
            cadena2 = Console.ReadLine();

            comparacion = String.Compare(cadena1, cadena2);

            if(comparacion < 0)
            {
                Console.WriteLine("\n" + cadena1 + "\n" + cadena2);
            }
            else
            {
                Console.WriteLine("\n" + cadena2 + "\n" + cadena1);
            }

        }
    }
}
