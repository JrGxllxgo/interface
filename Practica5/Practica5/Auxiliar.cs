/*
* PRÁCTICA.............: Práctica 5.
* NOMBRE Y APELLIDOS...: José Ramón Gallego Vélez
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Estructuras de Datos Internas y Manejo de Ficheros.
* FECHA DE ENTREGA.....: 18 de noviembre de 2022
*/

namespace Practica5
{
    internal class Auxiliar
    {
        public static string leerCadena(string txt)
        {
            string txtUser = null;

            while (txtUser == null || txtUser.Equals(""))
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(txt);
                Console.ForegroundColor = ConsoleColor.White;
                txtUser = Console.ReadLine();

                if (txtUser.Equals(""))
                {
                    Console.WriteLine("La cadena no puede estar vacía");
                }
            }

            return txtUser;
        }
        public static int solicitarEnteroRango(int limInf, int limSup, string txt)
        {
            int num = -1;

            while (num < limInf || limSup < num)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(txt);
                    Console.ForegroundColor = ConsoleColor.White;
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num < limInf)
                    {
                        Console.WriteLine("Número fuera del rango inferior");
                    }
                    else if (num > limSup)
                    {
                        Console.WriteLine("Número fuera del rango superior");
                    }
                }
                catch (OverflowException) //cojemos la excepcion por si escribe un valor muy largo
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error en la introduccion del número");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (FormatException) //excepcion por si escribe texto
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error en la introduccion del número");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            return num;
        }
        public static void continueKey()
        {
            Console.WriteLine("Pulsa cualquier tecla si desea continuar");
            Console.ReadKey();
        }
        public static void writeError(string txt)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(txt);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
