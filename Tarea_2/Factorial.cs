using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacionAplicadaI.Tarea_2
{
    public class Factorial
    {

        public Factorial()
        {

        }

        public int FactorialDe(int n)
        {
            for(int i=n-1; i>1; i--)
            {
                n *= i;
            }
            return n;
        }

        public void MostrarFactorial()
        {
            int numero, factorial;

            Console.WriteLine("Digite el numero: ");

            numero = Int32.Parse(Console.ReadLine());

            factorial = FactorialDe(numero);

            Console.WriteLine("El factorial es: " + factorial);
        }
    }
}
