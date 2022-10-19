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
    class ScndGrade
    {
        #region variablesForRaiz
        private double a, b, c;
        #endregion
        public ScndGrade(Double a, Double b, Double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void calcular()
        {
            double radicando = Math.Pow(b, 2) - 4 * a * c;

            Console.WriteLine("Ecuación: " + a + "x\xB2+" + b + "x+" + c);

            string raizPositiva;
            string raizNegativa;

            Console.WriteLine("Radicando: " + b + "\xB2" + "(-4*" + a + "*" + c + ")=" + radicando);

            if (radicando >= 0)
            {
                raizNegativa = ((-b - Math.Sqrt(radicando)) / (2 * a)).ToString("0.###");
                raizPositiva = ((-b + Math.Sqrt(radicando)) / (2 * a)).ToString("0.###");
            }
            else
            {
                radicando = -radicando;

                raizNegativa = -b / 2 + " - " + (((Math.Sqrt(radicando)) / 2) + "i");
                raizPositiva = -b / 2 + " + " + (((Math.Sqrt(radicando)) / 2) + "i");
            }

            Console.WriteLine("Resultado 1 --> " + raizPositiva);
            Console.WriteLine("Resultado 2 --> " + raizNegativa);
        }
    }
}
