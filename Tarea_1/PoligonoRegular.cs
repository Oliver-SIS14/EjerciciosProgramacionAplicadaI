using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacionAplicadaI.Tarea_1
{
    class PoligonoRegular
    {

        private int lados;
        private double apotema;
        private double valorLados;
        private double area;
        private double perimetro;

        public PoligonoRegular()
        {
            valorLados = area = perimetro = apotema = 0.0;
            lados = 0;
        }

        public void Calculo()
        {
            int opcion;

            Console.WriteLine("Que desea calcular 1.)Area  2.)Perimetro: ");
            opcion = Int16.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Inserte el numero de lados del poligono");
                lados = Int16.Parse(Console.ReadLine());

                Console.WriteLine("Inserte el valor de uno de los lados del poligono");
                valorLados = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite el apotema del poligono");
                apotema = double.Parse(Console.ReadLine());

                area = ((lados * valorLados) * apotema) / 2;

                Console.WriteLine("El area es: " + area);
            }
            else
            {
                Console.WriteLine("Inserte el numero de lados del poligono");
                lados = Int16.Parse(Console.ReadLine());

                Console.WriteLine("Inserte el valor de uno de los lados del poligono");
                valorLados = double.Parse(Console.ReadLine());

                perimetro = lados * valorLados;

                Console.WriteLine("El perimetro es: " + perimetro);
            }
        }

    }
}
