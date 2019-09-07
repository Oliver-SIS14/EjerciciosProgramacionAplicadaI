using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacionAplicadaI.Tarea_2
{
    public class FormatoHora
    {
        public FormatoHora()
        {

        }

        public void Formato()
        {
            String formato;

            formato = String.Format("La Fecha es: {0: h:m tt    yyy / d / M }", DateTime.Now);

            Console.WriteLine(formato);
        }
    }
}
