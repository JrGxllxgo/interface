/*
* PRÁCTICA.............: Práctica 4.
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Diseño de clases. Herencia y polimorfismo.
* FECHA de ENTREGA.....: 10 de novimebre de 2022
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class FichaLibroVol :FichaLibro
    {
        private int volumen;

        public int Volumen
        {
            get { return volumen; }
        }

        public FichaLibroVol(string referencia, string titulo, int numEjemplares, string autor, string editorial, int volumen) : base(referencia, titulo, numEjemplares, autor, editorial)
        {
            this.volumen = volumen;
        }

        public override void imprimir()
        {
            Console.WriteLine("---------- DATOS INTRODUCIDOS ----------" +
                "\nReferencia -->\t\t" + Referencia +
                "\nTítulo -->\t\t" + Titulo +
                "\nAutor -->\t\t" + Autor +
                "\nEditorial -->\t\t" + Editorial +
                "\nVolumen -->\t\t" + Volumen +
                "\nEjemplares -->\t\t" + NumEjemplares);
        }
    }
}
