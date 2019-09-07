using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacionAplicadaI.Tarea_2
{
    public class DatosSalon
    {
        public DatosSalon()
        {

        }

        public void ColectarDatos()
        {
            int cantidad;
            float valor,promedio = 0,maximo = 0 ,minimo = 0,acum = 0;
            ArrayList datos = new ArrayList();

            Console.WriteLine("Inserte el numero de calificaciones a evaluar: ");
            cantidad = Int16.Parse(Console.ReadLine());

            for(int i=0; i<cantidad; i++)
            {
                Console.WriteLine("\nInserte calificacion " + (i + 1));
                valor = float.Parse(Console.ReadLine());
                datos.Add(valor);
            }

            maximo = (float)datos[0];
            minimo = (float)datos[0];

            foreach (float value in datos) //Uso del foreach
            {
                if (value > maximo)
                    maximo = value;

                if (value < minimo)
                    minimo = value;

               acum += value;
            }

            int elementos = datos.Count;
            promedio = (float)acum / elementos;

            Console.WriteLine("\n\nEl promedio es: " + promedio + "\nCalificacion Maxima: " + maximo + "\nCalificacion Minima: " + minimo);

        }

    }
}
