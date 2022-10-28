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
            Empleado miEmpleado = new Empleado();

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

            miNomina.showNomina();
        }
    }
}