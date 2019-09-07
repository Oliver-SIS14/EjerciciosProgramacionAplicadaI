using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que haga una funcion que tenga como parametro un arreglo jagged

namespace Ejercicios_programacionAplicadaI.Tarea_2
{
    public class JaggedParametro
    {
        public JaggedParametro()
        {

        }

        public void FuncionPrincipal()
        {
            int[][] numeros = new int[4][];

            numeros[0] = new int[4];
            numeros[1] = new int[2];
            numeros[2] = new int[5];
            numeros[3] = new int[2];

            int dato;

            for(int n = 0; n < 4; n++)
            {
                for(int m=0; m< numeros[n].GetLength(0); m++)
                {
                    Console.WriteLine("Inserte el numero de el indice [ " + n + " ]" + "[ " + m + " ] ");
                    dato = Int32.Parse(Console.ReadLine());
                    numeros[n][m] = dato;
                }
            }

            ImprimirArregloJagged(numeros); //Arreglo Jagged Como Parametro
        }

        public void ImprimirArregloJagged(int[][] array)
        {
            for (int n = 0; n < 4; n++)
            {
                for (int m = 0; m < array[n].GetLength(0); m++)
                {
                    Console.WriteLine("numero de el indice [ " + n + " ]" + "[ " + m + " ] es: " + array[n][m]);
                }
            }
        }

    }
}
