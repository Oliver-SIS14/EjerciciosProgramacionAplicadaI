using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacionAplicadaI.Tarea_1
{
    class Potencia
    {

        private int numero;
        private int pow;
        private int res;

        public Potencia()
        {
            numero = pow = res = 0;
        }
        public void power()
        {
            Console.WriteLine("Digite el numero a elevar: ");
            numero = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Digite la potencia a la cual desea elevar: ");
            pow = Int16.Parse(Console.ReadLine());

            res = numero;

            for (int i = 0; i < pow - 1; i++)
            {
                res *= numero;
            }

            Console.WriteLine("El resultado es: " + res);
        }
    }
}
