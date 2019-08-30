using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacionAplicadaI.Tarea_1
{
    class Poligono
    {

        private double perimetro;
        private double valor;
        private int cantidad;

        public Poligono()
        {
            cantidad = 0;
            perimetro = 0.0;
            valor = 0.0;
        }

        public void CalcularPerimetro()
        {
            Console.WriteLine("Inserte el tamano de un lado del poligono: ");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Inserte el numero de lados del poligono: ");
            cantidad = Int16.Parse(Console.ReadLine());

            perimetro = valor * cantidad;

            Console.WriteLine("El perimetro es: " + perimetro);

        }

    }
}
