using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacionAplicadaI.Tarea_2
{
    public class NumeroACadenas
    {

        public NumeroACadenas()
        {

        }

        public void NumeroACad(int n)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Dos");
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    break;
                case 4:
                    Console.WriteLine("Cuatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
                case 6:
                    Console.WriteLine("Seis");
                    break;
                case 7:
                    Console.WriteLine("Siete");
                    break;
                case 8:
                    Console.WriteLine("Ocho");
                    break;
                case 9:
                    Console.WriteLine("Nueve");
                    break;
                case 10:
                    Console.WriteLine("Diez");
                    break;
            }

        }

        public void MostrarCadenaNumerica()
        {
            int n;
            Console.WriteLine("Inserte el numero del 1 al 9");
            n = Int32.Parse(Console.ReadLine());


            NumeroACad(n);
        }


    }
}
