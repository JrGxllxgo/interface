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
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("************** GESTIÓN BIBLIOTECA **************");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("1. Añadir registro" +
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
                                            ficha = crearLibroVol();
                                            fichas.Add(ficha);
                                            ficha.imprimir();
                                            addOpt = 6;
                                            optSelected = 0;
                                            break;
                                        case 3:
                                            ficha = crearRevista();
                                            fichas.Add(ficha);
                                            ficha.imprimir();
                                            addOpt = 6;
                                            optSelected = 0;
                                            break;
                                        case 4:
                                            ficha = crearDVD();
                                            fichas.Add(ficha);
                                            ficha.imprimir();
                                            addOpt = 6;
                                            optSelected = 0;
                                            break;
                                        case 5:
                                            Console.WriteLine(Console.ReadKey());
                                            addOpt = 6;
                                            optSelected = 0;
                                            break;
                                        default: //mensaje predefinido que saldrá cuando introduzcan un valor numérico que no está entre las opciones
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Opción no válida");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;
                                    }
                                }
                            }
                            catch (FormatException) //controlamos la excepción para que solo introduzcan valores numéricos
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Valores numéricos únicamente");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        case 2:
                            imprimirFichas(fichas);
                            break;
                        case 3://opción donde salimos del programa
                            Console.WriteLine("Hasta luego!!!");
                            Environment.Exit(0);
                            break;
                        default: //mensaje predefinido que saldrá cuando introduzcan un valor numérico que no está entre las opciones
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opción no válida");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                }
                catch (OverflowException) //cojemos la excepcion por si escribe un valor muy largo
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error en la introduccion de la opción");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (FormatException) //excepcion por si escribe texto
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error en la introduccion de la opción");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private static void imprimirFichas(ArrayList fichas)
        {
            Console.Clear();
            for (int i = 0; i < fichas.Count; i++)
            {
                ((Ficha)fichas[i]).imprimir();
            }
        }

        private static Ficha crearDVD()
        {
            Console.Clear();
            string referencia = Auxiliar.leerCadena("Introduzca la referencia del DVD");
            string titulo = Auxiliar.leerCadena("Introduzca el Título del DVD");
            int numEjemplares = Auxiliar.solicitarEnteroRango(0, Int32.MaxValue, "Introduzca el número de ejemplares");
            string director = Auxiliar.leerCadena("Introduzca el director");
            DateTime año = DateTime.Parse("1/1/" + Auxiliar.leerCadena("Añada el año del DVD"));

            while (año.Year < 1950 || año.Year > DateTime.Now.Year)
            {
                Console.WriteLine("El año está fuera de rangos");
                año = DateTime.Parse("1/1/" + Auxiliar.leerCadena("Añada el año del DVD"));
            }
            ArrayList actores = anadirActores();

            return new FichaDVD(referencia, titulo, numEjemplares, director, año, actores);
        }

        private static ArrayList anadirActores()
        {
            Console.Clear();
            ArrayList actores = new ArrayList();
            ConsoleKey teclaSalir = ConsoleKey.Escape;
            ConsoleKey teclaPulsada = ConsoleKey.Enter;
            while (teclaPulsada != teclaSalir)
            {
                actores.Add(Auxiliar.leerCadena("Introduzca un actor"));
                Console.WriteLine("Pulsa ESC para dejar de añadir actores");
                teclaPulsada = Console.ReadKey().Key;
            }

            return actores;
        }

        private static Ficha crearRevista()
        {
            Console.Clear();
            string referencia = Auxiliar.leerCadena("Introduzca la referencia de la revista");
            string titulo = Auxiliar.leerCadena("Introduzca el Título de la revista");
            int numEjemplares = Auxiliar.solicitarEnteroRango(0, Int32.MaxValue, "Introduzca el número de ejemplares");
            int numero = Auxiliar.solicitarEnteroRango(0, Int32.MaxValue, "Introduzca el número de la revista");
            DateTime año = DateTime.Parse("1/1/" + Auxiliar.leerCadena("Añada el año de la revista"));

            while(año.Year < 1950 || año.Year > DateTime.Now.Year)
            {
                Console.WriteLine("El año está fuera de rangos");
                año = DateTime.Parse("1/1/" + Auxiliar.leerCadena("Añada el año de la revista"));
            }

            return new FichaRevista(referencia, titulo, numEjemplares, numero, año);
        }

        private static Ficha crearLibroVol()
        {
            Console.Clear();
            string referencia = Auxiliar.leerCadena("Introduzca la referencia del libro");
            string titulo = Auxiliar.leerCadena("Introduzca el Título del libro");
            int numEjemplares = Auxiliar.solicitarEnteroRango(0, Int32.MaxValue, "Introduzca el número de ejemplares");
            string autor = Auxiliar.leerCadena("Introduzca el nombre del autor");
            string editorial = Auxiliar.leerCadena("Introduzca la editorial del libro");
            int volumen = Auxiliar.solicitarEnteroRango(0, Int32.MaxValue, "Introduzca el volumen del libro");

            return new FichaLibroVol(referencia, titulo, numEjemplares, autor, editorial, volumen);
        }

        private static FichaLibro crearLibro()
        {
            Console.Clear();
            string referencia = Auxiliar.leerCadena("Introduzca la referencia del libro");
            string titulo = Auxiliar.leerCadena("Introduzca el Título del libro");
            int numEjemplares = Auxiliar.solicitarEnteroRango(0, Int32.MaxValue, "Introduzca el número de ejemplares");
            string autor = Auxiliar.leerCadena("Introduzca el nombre del autor");
            string editorial = Auxiliar.leerCadena("Introduzca la editorial del libro:");

            return new FichaLibro(referencia, titulo, numEjemplares, autor, editorial);
        }
    }
}