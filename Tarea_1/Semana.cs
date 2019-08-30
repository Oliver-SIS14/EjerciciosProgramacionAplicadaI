using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacionAplicadaI.Tarea_1
{
    class Semana
    {

        int dia;

        public Semana()
        {
            dia = 0;
        }

        public void Dia()
        {
            Console.WriteLine("Inserte el numero del dia: ");
            dia = Int16.Parse(Console.ReadLine());

            if (dia == 1)
                Console.WriteLine("Es domingo");
            else if (dia == 2)
                Console.WriteLine("Es Lunes");
            else if (dia == 3)
                Console.WriteLine("Es Martes");
            else if (dia == 4)
                Console.WriteLine("Es Miercoles");
            else if (dia == 5)
                Console.WriteLine("Es Jueves");
            else if (dia == 6)
                Console.WriteLine("Es Viernes");
            else if (dia == 7)
                Console.WriteLine("Es Sabado");
        }

    }
}
