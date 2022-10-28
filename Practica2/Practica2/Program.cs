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
        private static Empleado miEmpleado;
        private static Nómina miNomina;
        public static void Main(String[] args)
        {
            Console.WriteLine("Introduzca los siguientes datos: ");
            askForEmpleadoValues();
            askForNominaValues();

            miEmpleado.showData();
        }

        private static void askForEmpleadoValues()
        {
            miEmpleado = new Empleado();

            Console.WriteLine("Nombre: ");
            miEmpleado.NombreProp = Console.ReadLine();
            Console.WriteLine("N.I.F.: ");
            miEmpleado.NifProp = Console.ReadLine();
            Console.WriteLine("Categoría: ");
            miEmpleado.CategoriaProp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Número de hijos: ");
            miEmpleado.CategoriaProp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Trienios: ");
            miEmpleado.CategoriaProp = Convert.ToInt32(Console.ReadLine());
        }

        private static void askForNominaValues()
        {
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
        }
    }
}