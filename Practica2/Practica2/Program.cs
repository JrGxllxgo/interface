/*
* PRÁCTICA.............: Práctica 2.
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Definición de Clases. Uso de Métodos.
* FECHA de ENTREGA.....: 27 de octubre de 2022
*/

namespace Practica2
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("------- Introduzca los siguientes datos -------");

            Int16 optSelected;

            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n1. Crear un nuevo empleado con nómina" +
                        "\n2. Salir del Programa");
                    optSelected = Convert.ToInt16(Console.ReadLine());

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
            }
        }

        public static Nomina addNominaData(Empleado miEmpleado)
        {
            Nomina miNomina = new Nomina(miEmpleado);
            Console.WriteLine("Fecha de liquidación (dd/mm/aaaa): ");
            try
            {
                miNomina.FechaNominaProp = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de la fecha es incorrecto");
            }
            Console.WriteLine("Horas extras: ");
            miNomina.NumHorasExtrasProp = Convert.ToInt32(Console.ReadLine());
            return miNomina;
        }

        private static void createEmpleado(Empleado miEmpleado)
        {
            Console.WriteLine("Nombre: ");
            miEmpleado.NombreProp = Console.ReadLine();

            Console.WriteLine("N.I.F.: ");
            miEmpleado.NifProp = Console.ReadLine();

            Console.WriteLine("Categoría: ");
            miEmpleado.CategoriaProp = Convert.ToInt32(Console.ReadLine());
            while (miEmpleado.CategoriaProp != 1 && miEmpleado.CategoriaProp != 2)
            {
                Console.Clear();
                Console.WriteLine("La categoría solo puede ser 1 o 2\t\nIntroduzca la categoría correctamente:");
                miEmpleado.CategoriaProp = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Número de hijos: ");
            miEmpleado.NumHijosProp = Convert.ToInt32(Console.ReadLine());
            while (miEmpleado.NumHijosProp < 0)
            {
                Console.Clear();
                Console.WriteLine("Número de hijos no puede ser menor que 0\t\nIntroduzca correctamente el número de hijos");
                miEmpleado.NumHijosProp = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Trienios: ");
            miEmpleado.NumTrieniosProp = Convert.ToInt32(Console.ReadLine());
        }
    }
}