/*
* PRÁCTICA.............: Práctica Inicial.
* NOMBRE y APELLIDOS...: José Ramón Gallego Velez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 12 de octubre de 2022
*/

using PracticaInicial;
namespace PracticaInicial
{
    class EjemploCalculadora
    {
        public static void Main(string[] args)
        {
            Int16 optSelected = 0;

            while (optSelected != 3) //bucle para estar continuamente en el menú, al salir de una acción también
            {
                Console.Title = "Práctica 0";
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Elija opción a ejecutar: (1)Ecuación de 2 Grado   (2)Mostrar tabla de Multiplicar   (3)Salir");
                    optSelected = Convert.ToInt16(Console.ReadLine());

                    switch (optSelected) //switch usado para ir alternando entre las opciones
                    {
                        case 1: //opción para llamar al metodo del cálculo de ecuacion de segundo grado
                            try
                            {
                                askForEcuationValues();
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
                                askForTableValues();
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

        // Método donde introducimos dos valores y llamamos a la clase de la tabla de multiplicar
        private static void askForTableValues()
        {
            Console.Clear();
            Console.Title = "Tabla de multiplicar";

            Console.WriteLine("Introduzca el factor");
            double factor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca el número de resultados que desea");
            double numRep = Convert.ToDouble(Console.ReadLine());

            if (numRep < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Número negativos no son posibles introducir");
            }
            else
            {
                MultTable myTable = new MultTable(factor, numRep);
                myTable.showMultTable();
            }
        }

        // Método donde introducimos dos valores y llamamos a la clase de resolver la ecuación de segundo grado
        private static void askForEcuationValues()
        {
            Console.Clear();
            Console.Title = "Ecuación de segundo grado";

            Console.WriteLine("Introduzca valor para a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca valor para b");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca valor para c");
            double c = Convert.ToDouble(Console.ReadLine());

            ScndGrade myScndGrade = new ScndGrade(a, b, c);
            myScndGrade.calcular();
        }
    }
}

