/*
* PRÁCTICA.............: Práctica 3.
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Sentencias de Control. Excepciones.
* FECHA de ENTREGA.....: 02 de noveimbre de 2022
*/


using Practica3;
using System.Xml;

namespace Practica3
{
    class PruebaJuego
    {
        private static int time = 10, numPreg = 10;
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
                                            leerTiempoLimite();
                                            break;

                                        case 2:
                                            leerNumeroPreguntas();
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
                                jugar(time, numPreg);
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
                catch (FormatException) //controlamos la excepción para que solo introduzcan valores numéricos
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valores numéricos únicamente");
                }
                catch (OverflowException) //controlamos la excepción para que solo introduzcan valores numéricos
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número incorrecto");
                }
            }
        }

        public static void leerTiempoLimite()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Introduzca el tiempo máximo entre 3 y 10 segundos");
                time = Convert.ToInt16(Console.ReadLine());
                if (time < 3 || time > 10)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valores fuera de los límites");
                    leerTiempoLimite();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Tiempo establecido correctamente!");
                }
            }
            catch (FormatException) //controlamos la excepción para que solo introduzcan valores numéricos
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valores numéricos únicamente");
                leerTiempoLimite();
            }
        }

        public static void leerNumeroPreguntas()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Introduzca el número de preguntas máximo entre 1 y 10");
                numPreg = Convert.ToInt16(Console.ReadLine());
                if (numPreg < 1 || numPreg > 10)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valores fuera de los límites");
                    leerNumeroPreguntas();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Número de preguntas establecido correctamente!");
                }
            }
            catch (FormatException) //controlamos la excepción para que solo introduzcan valores numéricos
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valores numéricos únicamente");
                leerNumeroPreguntas();
            }
        }

        public static void jugar(int time, int numPreg)
        {
            Console.WriteLine("Empecemos a jugar!!");
            JuegoMultiplicar myGame = new JuegoMultiplicar();
            myGame.TimeProp = time;

            for (int i = 1; i <= numPreg; i++)
            {
                Console.Clear();
                DateTime startTime = DateTime.Now;
                Console.ForegroundColor = ConsoleColor.White;
                myGame.generarOperandos();
                Console.WriteLine(myGame.Operando1Prop + " * " + myGame.Operando2Prop);
                string answer = "";
                ConsoleKeyInfo key = new ConsoleKeyInfo((char)ConsoleKey.Backspace, ConsoleKey.Backspace, false, false, false);
                TimeSpan t = DateTime.Now - startTime;
                int timeUsed = int.Parse(t.Seconds.ToString());

                do
                {
                    t = DateTime.Now - startTime;
                    timeUsed = int.Parse(t.Seconds.ToString());
                    if (Console.KeyAvailable)
                    {
                        key = Console.ReadKey();
                        answer += key.Key;
                        answer = answer.Replace("D", "");
                    }
                    else
                    {
                        Thread.Sleep(100);
                    }
                }while(timeUsed < myGame.TimeProp && key.Key != ConsoleKey.Enter);
                try
                {
                    answer = answer.Replace("Enter", "");
                    int integerAnswer = Convert.ToInt32(answer);
                    if (integerAnswer == Convert.ToInt32(myGame.Operando1Prop * myGame.Operando2Prop))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correcto!!");
                        myGame.marcador(true);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error!");
                        myGame.marcador(false);
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Tiempo límite alcanzado");
                }
                

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nAciertos: " + myGame.AciertosProp +
                    "\nFallos: " + myGame.FallosProp);

                Console.WriteLine(myGame.AciertosProp + " / " + i);
                Console.WriteLine("Pulsa enter para continuar jugando");
                Console.ReadLine();
            }

            double nota = (myGame.AciertosProp * 10) / numPreg;
            Console.WriteLine("Nota de Partida: " + nota.ToString("0.##"));
        }
    }
    
}
