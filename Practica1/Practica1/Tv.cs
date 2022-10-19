/*
* PRÁCTICA.............: Práctica 1.
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: P.O.O. Abstracción. Definición de Clases.
* FECHA de ENTREGA.....: 19 de octubre de 2022
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Tv
    {
        #region tvVariables
        private string marca;
        private static bool onOff;
        private byte canal, canalAnterior, volumen, pulgadas, consumo;
        private double precio;
        #endregion

        public Tv(string marca, byte pulgadas, byte consumo, double precio)
        {
            Console.WriteLine("Leyendo datos del televisor....");
            this.marca = marca;
            this.pulgadas = pulgadas;
            this.consumo = consumo;
            this.precio = precio;

            informacionTecnica();

            if (!onOff)
            {
                //seteamos los valores por defecto para el desarrollo de nuestro programa
                onOff = false;
                canal = 1;
                canalAnterior = 1;
                volumen = 25;
            }
        }

        public void informacionTecnica()
        {
            Console.WriteLine("Marca: " + marca + " Pulgadas: " + pulgadas + " Consumo: " + consumo + " Precio: " + precio+"€");
        }

        public void pulsarOnOff()
        {
            if (onOff) 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                onOff = false;
                Console.WriteLine("Apagada");
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                onOff = true;
                Console.WriteLine("Encendida");

                //seteamos los valores por defecto para el desarrollo de nuestro programa
                canal = 1;
                canalAnterior = 1;
                volumen = 25;
            }
        }

        public void subirVolumen()
        {
            if (onOff) //condicional de is el televisor esta encendido ejecutara el codigo para subir el volumen
            {
                volumen++;
                estadoActual();
            }
            else //sino sonará el pitido y avisará del estado del televisor
            {
                for(int i = 0; i < 3; i++)
                {
                    Console.Beep();
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Console.WriteLine("Televisor Apagado!!");
            }
        }
        public void bajarVolumen()
        {
            if (onOff) //condicional de is el televisor está encendido ejecutará el código para bajar el volumen
            {
                volumen--;
                estadoActual();
            }
            else //sino sonará el pitido y avisará del estado del televisor
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep();
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Console.WriteLine("Televisor Apagado!!");
            }

            if (volumen < 1 || (volumen < 255 && volumen > 101)) //condicional para que el volumen minimo sea 0 y no haga saltos
            {
                Console.Beep();
                volumen = 1;
                Console.Clear();
                Console.WriteLine("Volumen al mínimo");
            }
        }

        public void ponerCanal()
        {
            if (onOff) //condicional de si el televisor está encendido ejecutará el código para poner un nuevo canal
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Introduzca el canal hasta el que ir");
                byte nuevoCanal = Convert.ToByte(Console.ReadLine());
                this.canalAnterior = this.canal;
                this.canal = nuevoCanal;
                estadoActual();
            }
            else //sino sonará el pitido y avisará del estado del televisor
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep();
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Console.WriteLine("Televisor Apagado!!");
            }
        }

        public void cambiarCanalAnterior()
        {
            if (onOff) //condicional de si el televisor está encendido ejecutará el código para poner el canal anterior
            {
                this.canal = this.canalAnterior;
                estadoActual();
            }
            else //sino sonará el pitido y avisará del estado del televisor
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep();
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Console.WriteLine("Televisor Apagado!!");
            }
        }

        public void estadoActual()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tVolumen:" + volumen +
                "\n\tCanal: " + canal);
        }
    }
}
