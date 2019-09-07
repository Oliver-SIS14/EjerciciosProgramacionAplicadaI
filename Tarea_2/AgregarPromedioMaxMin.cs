using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//En este ejercicio 3 en 1 se agrega el promedio, el maximo y el minimo (Calificaciones)

namespace Ejercicios_programacionAplicadaI.Tarea_2
{
    class AgregarPromedioMaxMin
    {
            
            public AgregarPromedioMaxMin()
            {   

            }   

            public void Operaciones()
            {
                int cantidad = 0; // Cantidad de alumnos
                int salones = 0; // Cantidad de salones
                int n = 0; // Variable de control de ciclo salones
                int m = 0; // Variable de control del ciclo alumnos
                string valor ="";

                // Variables para el promedio
                float suma = 0.0f;
                float promedio = 0.0f;
                float minima = 10.0f; //Variable para la calificación mínima
                float maxima = 0.0f; //Variable para la calificación maxima
            
                Console.WriteLine("Dame la cantidad de salones");
                valor = Console.ReadLine();
                salones = Convert.ToInt32(valor);
            
                float[][] calif = new float[salones][];
             

                for(n=0;n<salones;n++) // Ciclo salones
                {
                    Console.WriteLine("Dame la cantidad de alumnos para el salon :  " + n);
                    valor=Console.ReadLine();
                    cantidad=Convert.ToInt32(valor);
                    // Instanciamos el arreglo
                    calif[n]=new float[cantidad];
                }

                for(n=0;n<salones;n++) // Ciclo salones
                {
                     Console.WriteLine("Salon " + n);

                    for(m=0;m<calif[n].GetLength(0);m++)
                    {
                    Console.Write("Dame la calificación: ");
                    valor=Console.ReadLine();
                    calif [n][m]=Convert.ToSingle(valor);
                    }
                }

                    int acum = 0; //Acumulador del promedio
                    minima = calif[0][0]; 
                    maxima = calif[0][0];

                Console.WriteLine("—— Información ——");
            for (n = 0; n < salones; n++) // Ciclo salones
                {
                    Console.WriteLine("Salon " + n);

                    for (m = 0; m < calif[n].GetLength(0); m++) // Ciclo alumnos
                    {
                    Console.WriteLine("El alumno" + m + "Tiene: " + calif[n][m]);

                    if (calif[n][m] > maxima)
                        maxima = calif[n][m];

                    if (calif[n][m] < minima)
                        minima = calif[n][m];

                        suma += calif[n][m]; //Acumulador del promedio
                        acum++;
                    }
                 }

            promedio = suma / acum; //Calculo del promedio

            Console.WriteLine("\nEl promedio de calificaciones es: " + promedio);
            Console.WriteLine("\nCalificacion maxima: " + maxima);
            Console.WriteLine("\nCalificacion Minima: " + minima);
        }
}
}
