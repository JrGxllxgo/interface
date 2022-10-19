/*
* PRÁCTICA.............: Práctica 1.
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: P.O.O. Abstracción. Definición de Clases.
* FECHA de ENTREGA.....: 19 de octubre de 2022
*/

using Practica1;
using System;
using System.Text;

namespace Practica1
{
    class Ejecutable
    {

        private static string marca;
        private static byte consumo, pulgadas;
        private static double precio;

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Introduzca la marca");
            marca = Console.ReadLine();

            try
            {
                Console.WriteLine("Introduzca el número de pulgadas");
                pulgadas = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Introduzca el consumo");
                consumo = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Introduzca el precio");
                String precioString = Console.ReadLine();
                precio = Convert.ToDouble(precioString.Replace(".", ","));

                if (precio < 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Precio no puede seguir negativo");
                    Main(args); //con esta llamada hacemos que se reinicie el programa para volver a pedir los datos
                }

            }
            catch (System.FormatException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error en el formato introducido");

                Main(args); //con esta llamada hacemos que se reinicie el programa para volver a pedir los datos
            }
            catch (System.OverflowException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error en el valor introducido");

                Main(args); //con esta llamada hacemos que se reinicie el programa para volver a pedir los datos
            }

            Tv myTv = new Tv(marca, pulgadas, consumo, precio); //llamamos a la clase enviándole los parámetros para el constructor

            Int16 optSelected;

            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n0: Encender - Apagar dispositivo" +
                        "\n1: Subir Volumen" +
                        "\n2: Bajar Volumen" +
                        "\n3: Cambiar Canal" +
                        "\n4: Canal Anterior" +
                        "\n5: Desconcetar Televisor");
                    optSelected = Convert.ToInt16(Console.ReadLine());

                    switch (optSelected)
                    {
                        case 0:
                            myTv.pulsarOnOff();
                            break;
                        case 1:
                            myTv.subirVolumen();
                            break;
                        case 2:
                            myTv.bajarVolumen();
                            break;
                        case 3:
                            myTv.ponerCanal();
                            break;
                        case 4:
                            myTv.cambiarCanalAnterior();
                            break;
                        case 5: //opción donde salimos del programa
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
                catch (System.OverflowException) //cojemos la excepcion por si escribe un valor muy largo
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error en la introduccion de la opción");
                }
                catch (System.FormatException) //cojemos la excepcion por si se escribe un valor incorrecto
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error en el formato introducido");
                }
            }
        }
    }
}