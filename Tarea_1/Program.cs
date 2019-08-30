using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_programacionAplicadaI.Tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int op;
            Console.WriteLine("Capitulo 1\n\n1.)Imprime mi nombre y agrega mas mensajes\n\nCapitulo 2\n\n2.)Calcular perimetro de poligonos.\n3.)Convertir de grados a radianes\n4.)Convertir de celcius a Fahrenheit\n5.)Convertir de dolar a euro\n\nCapitulo 3\n\n6.)Par o Impar\n7.)Dia de la semana\n8.)Area o perimetro de cualquier poligono\n\nCapitulo 4\n\n9.)Tabla de un numero\n10.)Potencia\n11.)Promedio de edades\n\nEliga la opcion que desee: ");
            op = short.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    {
                        Nombre nombre = new Nombre();
                        nombre.Mensaje();
                        break;
                    }

                case 2:
                    {
                        Poligono obj = new Poligono();
                        obj.CalcularPerimetro();
                        break;
                    }
                case 3:
                    {
                        Grados grade = new Grados();
                        grade.ConvertirARadianes();
                        break;
                    }
                case 4:
                    {
                        Grados grade = new Grados();
                        grade.ConvertirAFarenheit();
                        break;
                    }
                case 5:
                    {
                        Divisa objeto = new Divisa();
                        objeto.ConvertirAEuro();
                        break;
                    }
                case 6:
                    {
                        ParImpar num = new ParImpar();
                        num.ParOImpar();
                        break;
                    }
                case 7:
                    {
                        Semana dia = new Semana();
                        dia.Dia();
                        break;
                    }
                case 8:
                    {
                        PoligonoRegular pol = new PoligonoRegular();
                        pol.Calculo();
                        break;
                    }
                case 9:
                    {
                        TablaMultiplicacion tab = new TablaMultiplicacion();
                        tab.Tabla();
                        break;
                    }
                case 10:
                    {
                        Potencia pot = new Potencia();
                        pot.power();
                        break;
                    }
                case 11:
                    {
                        PromedioEdad pe = new PromedioEdad();
                        pe.CalculoEdades();
                        break;
                    }
            }
            Console.ReadKey();
        }

    }
}

