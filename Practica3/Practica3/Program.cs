/*
* PRÁCTICA.............: Práctica 3.
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Sentencias de Control. Excepciones.
* FECHA de ENTREGA.....: 02 de noveimbre de 2022
*/


using Practica3;
namespace Practica3
{
    class EjemploCalculadora
    {
        public static void Main(string[] args)
        {
            Int16 optSelected = 0;

            while (optSelected != 3) //bucle para estar continuamente en el menú, al salir de una acción también
            {
                Console.Title = "Práctica 3";
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Elija una de las siguientes opciones" +
                        "\n\t1:Configuración" +
                        "\n\t2:Jugar" +
                        "\n\t3:Salir");
                    optSelected = Convert.ToInt16(Console.ReadLine());

                    switch (optSelected) //switch usado para ir alternando entre las opciones
                    {
                        case 1: //opción para llamar al metodo del cálculo de ecuacion de segundo grado
                            try
                            {
                                Int16 confOpt = 0;

                                while (confOpt != 4)
                                {
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("1:Establecer tiempo máximo para las respuestas" +
                                        "\t\n2:Establecer el número de preguntas" +
                                        "\t\n3:Atrás");

                                    confOpt = Convert.ToInt16(Console.ReadLine());

                                    switch (confOpt)
                                    {
                                        case 1:
                                            Console.Clear();
                                            Console.WriteLine("Introduzca el tiempo máximo en segundos");
                                            break;

                                        case 2:
                                            Console.Clear();
                                            Console.WriteLine("Introduzca el número de preguntas");
                                            break;

                                        case 3:
                                            optSelected = 0;
                                            confOpt = 4;
                                            break;

                                        default: //mensaje predefinido que saldrá cuando introduzcan un valor numérico que no está entre las opciones
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Valor no válido");
                                            break;
                                    }
                                }//bucle para crear el menú de la configuración del juego
                            }
                            catch (System.FormatException) //controlamos la excepción para que solo introduzcan valores numéricos
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Valores numéricos únicamente");
                            }

                            break;

                        case 2: //opción para llamar al método del cálculo de la tabla de multiplicar
                            try
                            {
                                Console.WriteLine("Empecemos a jugar!!");
                            }
                            catch (System.FormatException) //controlamos la excepción para que solo introduzcan valores numéricos
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Valores numéricos únicamente");
                            }

                            break;

                        case 3: //opción donde salimos del programa
                            Console.WriteLine("Hasta luego!!!");
                            Environment.Exit(0);

                            break;

                        default: //mensaje predefinido que saldrá cuando introduzcan un valor numérico que no está entre las opciones
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Valor no válido");
                            break;
                    }
                }
                catch (System.FormatException) //controlamos la excepción para que solo introduzcan valores numéricos
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valores numéricos únicamente");
                }
                catch (System.OverflowException) //controlamos la excepción para que solo introduzcan valores numéricos
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número incorrecto");
                }

            }
        }
    } 
}
