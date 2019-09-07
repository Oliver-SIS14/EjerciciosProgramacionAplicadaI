using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacionAplicadaI.Tarea_2
{
    public class AgendaTelefonica
    {

        public AgendaTelefonica()
        {

        }

        class Persona{ //Definiendo tipo de dato persona
            public string nombre { set; get; }
            public string numero { set; get; }

            public Persona()
            {
                this.nombre = string.Empty;
                this.numero = string.Empty;
            }
        }

        public void GuardarNumeros()
        {
            ArrayList agenda = new ArrayList();

            Persona p = new Persona();

            Console.WriteLine("\nDigite la cantidad de numeros que desea guardar");
            int cantidad = Int32.Parse(Console.ReadLine());

            for(int i=0; i<cantidad; i++)
            {
                Console.WriteLine("\nInserte el nombre de la persona: ");
                p.nombre = Console.ReadLine();

                Console.WriteLine("\nInserte el numero de la persona: ");
                p.numero = Console.ReadLine();

                agenda.Add(p);
            }
        }

    }
}
