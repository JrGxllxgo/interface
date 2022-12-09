/*
* PRÁCTICA.............: Práctica 2.
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Definición de Clases. Uso de Métodos.
* FECHA de ENTREGA.....: 27 de octubre de 2022
*/

using System.Linq.Expressions;

namespace Practica2
{
    class PruebaNomina
    {
        public static void Main(String[] args)
        {

            Int16 optSelected;

            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n1. Crear un nuevo empleado con nómina" +
                        "\n2. Salir del Programa");
                    optSelected = Convert.ToInt16(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;

                    switch (optSelected)
                    {
                        case 1:
                            Empleado miEmpleado = new Empleado();
                            createEmpleado(miEmpleado);
                            Nomina miNomina = addNominaData(miEmpleado);
                            miEmpleado.showEmpleadoData();
                            miNomina.showNomina();  
                            break;
                        case 2://opción donde salimos del programa
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

        public static Nomina addNominaData(Empleado miEmpleado)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Nomina miNomina = new Nomina(miEmpleado);
            Console.WriteLine("Fecha de liquidación (dd/mm/aaaa): ");
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                miNomina.FechaNominaProp = DateTime.Parse(Console.ReadLine());

                while(miNomina.FechaNominaProp.Year < (DateTime.Now.Year - 50) || miNomina.FechaNominaProp.Year > DateTime.Now.Year)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error en la fecha introducida, inténtelo otra vez: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    miNomina.FechaNominaProp = DateTime.Parse(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Formato de la fecha es incorrecto (se ha establecido la fecha actual)");
                miNomina.FechaNominaProp = DateTime.Now;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Horas extras: ");
            Console.ForegroundColor = ConsoleColor.White;
            miNomina.NumHorasExtrasProp = Convert.ToInt32(Console.ReadLine());

            while(miNomina.NumHorasExtrasProp < 0 || miNomina.NumHorasExtrasProp > 80)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Horas extras fuera de límites (min.0 -- max.80)");
                Console.ForegroundColor = ConsoleColor.White;
                miNomina.NumHorasExtrasProp = Convert.ToInt32(Console.ReadLine());
            }
            return miNomina;
        }

        public static void createEmpleado(Empleado miEmpleado)
        {
            Console.Clear();
            Console.WriteLine("------- Introduzca los siguientes datos -------");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Nombre: ");
            Console.ForegroundColor = ConsoleColor.White;
            miEmpleado.NombreProp = Console.ReadLine();
            while (miEmpleado.NombreProp.Equals(""))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El nombre no puede ser nulo");
                Console.ForegroundColor = ConsoleColor.White;
                miEmpleado.NombreProp = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("N.I.F.: ");
            Console.ForegroundColor = ConsoleColor.White;
            miEmpleado.NifProp = (Console.ReadLine());
            while (!ValidarNIF(miEmpleado.NifProp))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El NIF es incorrecto, introduzca de nuevo:");
                Console.ForegroundColor = ConsoleColor.White;
                miEmpleado.NifProp = (Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Categoría: ");
            Console.ForegroundColor = ConsoleColor.White;
            miEmpleado.CategoriaProp = Convert.ToInt32(Console.ReadLine());
            while (miEmpleado.CategoriaProp != 1 && miEmpleado.CategoriaProp != 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La categoría solo puede ser 1 o 2\t\nIntroduzca la categoría correctamente:");
                Console.ForegroundColor = ConsoleColor.White;
                miEmpleado.CategoriaProp = Convert.ToInt32(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Número de hijos: ");
            Console.ForegroundColor = ConsoleColor.White;
            miEmpleado.NumHijosProp = Convert.ToInt32(Console.ReadLine());
            while (miEmpleado.NumHijosProp < 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Número de hijos no puede ser menor que 0\t\nIntroduzca correctamente el número de hijos");
                Console.ForegroundColor = ConsoleColor.White;
                miEmpleado.NumHijosProp = Convert.ToInt32(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Trienios: ");
            Console.ForegroundColor = ConsoleColor.White;
            miEmpleado.NumTrieniosProp = Convert.ToInt32(Console.ReadLine());

            while (miEmpleado.NumTrieniosProp < 0 || miEmpleado.NumTrieniosProp > 120)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Trienios fuera de límites (min.0 -- max.120)");
                Console.ForegroundColor = ConsoleColor.White;
                miEmpleado.NumTrieniosProp = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static bool ValidarNIF(string NIF)
        {
            if (NIF == "")
            {
                return false;
            }
            else
            {
                //Obtenemos la letra del NIF (el último carácter)
                String letra = NIF.Substring(NIF.Length - 1, 1);
                //Obtenemos los números del NIF
                NIF = NIF.Substring(0, NIF.Length - 1);
                //Convertimos a número
                int nifNum = int.Parse(NIF);
                int resto = nifNum % 23;
                string letraResto = ObtenerLetra(resto);
                if (letraResto != letra.ToUpper())
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private static string ObtenerLetra(int numero)
        {
            Dictionary<int, String> letras = new Dictionary<int, string>();
            letras.Add(0, "T");
            letras.Add(1, "R");
            letras.Add(2, "W");
            letras.Add(3, "A");
            letras.Add(4, "G");
            letras.Add(5, "M");
            letras.Add(6, "Y");
            letras.Add(7, "F");
            letras.Add(8, "P");
            letras.Add(9, "D");
            letras.Add(10, "X");
            letras.Add(11, "B");
            letras.Add(12, "N");
            letras.Add(13, "J");
            letras.Add(14, "Z");
            letras.Add(15, "S");
            letras.Add(16, "Q");
            letras.Add(17, "V");
            letras.Add(18, "H");
            letras.Add(19, "L");
            letras.Add(20, "C");
            letras.Add(21, "K");
            letras.Add(22, "E");
            return letras[numero];
        }
    }
}