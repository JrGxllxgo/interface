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
    internal class FichaRevista : Ficha
    {
        #region atributos
        private int numero;
        private DateTime año;
        #endregion

        #region propiedades
        public int Numero
        {
            get { return numero; }
        }

        public DateTime Año
        {
            get { return año; }
        }
        #endregion
        public FichaRevista(string referencia, string titulo, int numEjemplares, int numero, DateTime año) : base(referencia, titulo, numEjemplares)
        {
            this.numero = numero;
            this.año = año;
        }

        public override void imprimir()
        {
            Console.WriteLine("---------- DATOS INTRODUCIDOS ----------" +
                "\nReferencia -->\t\t" + Referencia +
                "\nTítulo -->\t\t" + Titulo +
                "\nNúmero -->\t\t" + Numero +
                "\nAño de Publicación -->\t\t" + año.Year +
                "\nEjemplares -->\t\t" + NumEjemplares);
        }
    }
}
