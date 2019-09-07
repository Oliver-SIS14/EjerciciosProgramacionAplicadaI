using Ejercicios_programacionAplicadaI.Tarea_2;
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
            Console.WriteLine("Capitulo 1\n\n1.)Imprime mi nombre y agrega mas mensajes\n\nCapitulo 2\n\n2.)Calcular perimetro de poligonos.\n3.)Convertir de grados a radianes\n4.)Convertir de celcius a Fahrenheit\n5.)Convertir de dolar a euro\n\nCapitulo 3\n\n6.)Par o Impar\n7.)Dia de la semana\n8.)Area o perimetro de cualquier poligono\n\nCapitulo 4\n\n9.)Tabla de un numero\n10.)Potencia\n11.)Promedio de edades\n\nCapitulo 5\n\n12.)Factorial de un numero\n13.)Numero a cadena\n\nCapitulo 6\n\n14.)Agregar Calculo de promedio, Menor y Mayor calificacion\n15.)Programa de la escuela utilizando Funciones\n16.)Jagged Como Parametro\n\n Capitulo 7\n\n17.)Maxima y Minima Array List\n18.)Diccionario Hash\n19.)Agenda Telefonica\n\nCapitulo 8\n\n20.)Horario AM/FM\n21.)Cadenas Ordenadas\n\nEliga la opcion que desee: ");
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
                case 12:
                    {
                        Factorial fact = new Factorial();
                        fact.MostrarFactorial();
                        break;
                    }
                case 13:
                    {
                        NumeroACadenas n = new NumeroACadenas();
                        n.MostrarCadenaNumerica();
                        break;
                    }
                case 14:
                    {
                        AgregarPromedioMaxMin ap = new AgregarPromedioMaxMin();
                        ap.Operaciones();
                        break;
                    }
                case 15:
                    {
                        ProgramaEscuela pe = new ProgramaEscuela();
                        pe.DatosEscuela();

                        break;
                    }
                case 16:
                    {
                        JaggedParametro jp = new JaggedParametro();
                        jp.FuncionPrincipal();
                        break;
                    }
                case 17:
                    {
                        DatosSalon ds = new DatosSalon();
                        ds.ColectarDatos();
                        break;
                    }
                case 18:
                    {
                        Diccionario dic = new Diccionario();
                        dic.BuscarPalabra();
                        break;
                    }
                case 19:
                    {
                        AgendaTelefonica at = new AgendaTelefonica();
                        at.GuardarNumeros();
                        break;
                    }
                case 20:
                    {
                        FormatoHora fh = new FormatoHora();
                        fh.Formato();
                        break;
                    }
                case 21:
                    {
                        CadenasOrdenadas co = new CadenasOrdenadas();
                        co.OrdenarCadenas();
                        break;
                    }
            }
            Console.ReadKey();
        }

    }
}

