using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacionAplicadaI.Tarea_1
{
    class Divisa
    {

        private double cantidadDolar;
        private double cambio;
        private double resultado;

        public Divisa()
        {
            cantidadDolar = 0.0;
            cambio = 0.0;
            resultado = 0.0;
        }
        public void ConvertirAEuro()
        {
            Console.WriteLine("Inserte la cantidad de dolares a convertir: ");
            cantidadDolar = float.Parse(Console.ReadLine());

            Console.WriteLine("Inserte el cambio del dia (Dolar a Euro): ");
            cambio = float.Parse(Console.ReadLine());

            resultado = cantidadDolar * cambio;

            Console.WriteLine("Euros: " + resultado);

        }
    }

}