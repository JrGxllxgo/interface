/*
* PRÁCTICA.............: Práctica Inicial.
* NOMBRE y APELLIDOS...: José Ramón Gallego Velez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 12 de octubre de 2022
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaInicial
{
    class MultTable
    {
        #region multVariables
        private double factor, numRep;
        private bool continuar;
        #endregion
        public MultTable(double factor, double numRep)
        {
            this.factor = factor;
            this.numRep = numRep;
        }

        public void showMultTable()
        {
            continuar = true;
            int contador = 0;
            int j = 0;
            while (continuar && j < numRep)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Desea continuar? \n" +
                    "0: Si \n" +
                    "1: No");

                    int opt = Convert.ToInt16(Console.ReadLine());
                    if (opt == 0)
                    {
                        Console.Clear();
                        continuar = true;
                        contador = 0;

                        while (contador < 15 && j < numRep)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            double calc = j * factor;
                            Console.WriteLine(factor + " * " + j + " = " + calc);
                            j++;
                            contador++;
                        }

                    }
                    else if (opt == 1)
                    {
                        continuar = false;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor no válido");
                }

            }
        }
    }
}
