using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacionAplicadaI.Tarea_2
{
    public class Diccionario
    {

        public Diccionario()
        {

        }

        public void BuscarPalabra()
        {
            Hashtable miTabla = new Hashtable();

            string palabra;

            miTabla.Add("Programa", "Conjunto de instrucciones dadas al computador");
            miTabla.Add("Clase", "Definicion de las propiedades de un objeto");
            miTabla.Add("Computadora", "Es un dispositivo que transforma datos en informacion util");
            miTabla.Add("Mesa", "Mueble usado para postrar utensilios");
            miTabla.Add("Celular", "Dispositivo en forma de computador disminuido");


            Console.WriteLine("Inserte la palabra que desea buscar: \nPrograma\nClase\nComputadora\nMesa\nCelular");
            palabra = Console.ReadLine();

            Console.WriteLine(miTabla[palabra]);
        }

    }
}
