using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacionAplicadaI.Tarea_1
{
    class Grados
    {

        private double grados;
        private double valorGrados;

        public Grados()
        {
            grados = 0.0;
            valorGrados = 0.0;
        }

        public void ConvertirARadianes()
        {
            Console.WriteLine("Inserte la cantidad de grados a convertir: ");
            grados = double.Parse(Console.ReadLine());

            valorGrados = (grados * 3.1416) / 180;

            Console.WriteLine("Radianes: " + valorGrados);
        }

        public void ConvertirAFarenheit()
        {
            Console.WriteLine("Inserte la cantidad de grados celsius a convertir a fahrenheit: ");
            grados = double.Parse(Console.ReadLine());

            valorGrados = (grados * (9 / 5) + 32);

            Console.WriteLine("Fahrenheit: " + valorGrados);

        }
    }
}
