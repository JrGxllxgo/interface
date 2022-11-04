/*
* PRÁCTICA.............: Práctica 3.
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Sentencias de Control. Excepciones.
* FECHA de ENTREGA.....: 02 de noveimbre de 2022
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class JuegoMultiplicar
    {
        #region values
        private int time, cantPreg, aciertos, fallos, operando1, operando2, resultadoCorrecto;
        private Random rand = new Random();
        #endregion


        public int TimeProp
        {
            get { return time; }
            set { time = value; }
        }

        public int Operando1Prop
        {
            get { return operando1; }
        }

        public int Operando2Prop
        {
            get { return operando2; }
        }

        public int AciertosProp
        {
            get { return aciertos; }
        }

        public int FallosProp
        {
            get { return fallos; }
        }

        public int ResultadoCorrectoProp
        {
            get { return resultadoCorrecto; }
        }

        public void generarOperandos()
        {
            operando1 = rand.Next(1,9);
            operando2 = rand.Next(1,9);
        }

        public void marcador(bool user)
        {
            if (user)
            {
                aciertos++;
            }
            else
            {
                fallos++;
            }
        }
    }
}
