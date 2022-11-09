using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class Auxiliar
    {

        public static string leerCadena(string txt)
        {
            string txtUser = null;

            while (txtUser == null || txtUser.Equals(""))
            {
                Console.WriteLine(txt);
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
                    Console.WriteLine(txt);
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
                }
                catch (FormatException) //excepcion por si escribe texto
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error en la introduccion del número");
                }
            }
            return num;
        }
    }
}
