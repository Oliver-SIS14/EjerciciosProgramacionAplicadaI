using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacionAplicadaI.Tarea_1
{
    class PromedioEdad
    {
        private int acum;
        private int cantidad;
        private int edad;
        private float promedio;
        private int mayor;
        private int menor;

        public PromedioEdad()
        {
            edad = cantidad = mayor = menor = 0;
            promedio = 0;
        }

        public void CalculoEdades()
        {

            Console.WriteLine("Cuantas edades desea ingresar?");
            cantidad = Int16.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Inserte edad " + i + 1);
                edad = Int16.Parse(Console.ReadLine());
                acum += edad;

                if (edad > mayor)
                    mayor = edad;
                if (edad < mayor)
                    menor = edad;

            }
            promedio = acum / cantidad;
            Console.WriteLine("Promedio de edades: " + promedio + "\nEdad menor: " + menor + "Edad Mayor: " + mayor);

        }
    }
}
