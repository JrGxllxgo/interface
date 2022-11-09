/*
* PRÁCTICA.............: Práctica 4.
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Diseño de clases. Herencia y polimorfismo.
* FECHA de ENTREGA.....: 10 de novimebre de 2022
*/

using System.Collections;
using System.Runtime.CompilerServices;

namespace Practica4
{
    class PruebaFicha
    {
        public static void Main(String[] args)
        {

            Int16 optSelected;

            ArrayList fichas = new ArrayList();
            Ficha ficha;

            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n1. Añadir registro" +
                        "\n2. Consultar biblioteca" +
                        "\n3. Salir");
                    optSelected = Convert.ToInt16(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;

                    switch (optSelected)
                    {
                        case 1:
                            try
                            {
                                int addOpt = 0;

                                while (addOpt != 6)
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("1: Añadir Libro" +
                                        "\t\n2: Añadir Libro Volumen" +
                                        "\t\n3: Añadir Revista" +
                                        "\t\n4: Añadir DVD" +
                                        "\t\n5:Atrás");

                                    addOpt = Convert.ToInt16(Console.ReadLine());

                                    switch (addOpt)
                                    {
                                        case 1:
                                            ficha = crearLibro();
                                            fichas.Add(ficha);
                                            ficha.imprimir();
                                            addOpt = 6;
                                            optSelected = 0;
                                            break;
                                        case 2:
                                            break;
                                        case 3:
                                            break;
                                        case 4:
                                            break;
                                        case 5:
                                            addOpt = 6;
                                            optSelected = 0;
                                            break;
                                        default: //mensaje predefinido que saldrá cuando introduzcan un valor numérico que no está entre las opciones
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Opción no válida");
                                            break;
                                    }
                                }
                            }
                            catch (System.FormatException) //controlamos la excepción para que solo introduzcan valores numéricos
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Valores numéricos únicamente");
                            }
                            break;
                        case 2:
                            break;
                        case 3://opción donde salimos del programa
                            Console.WriteLine("Hasta luego!!!");
                            Environment.Exit(0);
                            break;
                        default: //mensaje predefinido que saldrá cuando introduzcan un valor numérico que no está entre las opciones
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                }
                catch (OverflowException) //cojemos la excepcion por si escribe un valor muy largo
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error en la introduccion de la opción");
                }
                catch (FormatException) //excepcion por si escribe texto
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error en la introduccion de la opción");
                }
            }
        }

        private static FichaLibro crearLibro()
        {
            string referencia = Auxiliar.leerCadena("Introduzca la referencia del libro");
            string titulo = Auxiliar.leerCadena("Introduzca el Título del libro");
            int numEjemplares = Auxiliar.solicitarEnteroRango(0, Int32.MaxValue, "Introduzca el número de ejemplares");
            string autor = Auxiliar.leerCadena("Introduzca el nombre del autor");
            string editorial = Auxiliar.leerCadena("Introduzca la editorial del libro:");

            return new FichaLibro(referencia, titulo, numEjemplares, autor, editorial);
        }
    }
}