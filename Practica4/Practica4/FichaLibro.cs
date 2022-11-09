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
    internal class FichaLibro : Ficha
    {
        #region atributos
        private string autor;
        private string editorial;
        #endregion

        #region propiedades
        public string Autor
        {
            get { return autor; }
        }

        public string Editorial
        {
            get { return editorial; }
        }
        #endregion

        public FichaLibro(string referencia, string titulo, int numEjemplares, string autor, string editorial) : base(referencia, titulo, numEjemplares)
        {
            this.autor = autor;
            this.editorial = editorial;
        }

        public override void imprimir()
        {
            Console.WriteLine("---------- DATOS INTRODUCIDOS ----------" +
                "\nReferencia -->\t\t" + Referencia +
                "\nTítulo -->\t\t" + Titulo +
                "\nAutor -->\t\t" + Autor +
                "\nEditorial -->\t\t" + Editorial +
                "\nEjemplares -->\t\t" + NumEjemplares);
        }
    }
}
