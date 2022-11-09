/*
* PRÁCTICA.............: Práctica 4.
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Diseño de clases. Herencia y polimorfismo.
* FECHA de ENTREGA.....: 10 de novimebre de 2022
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    internal class FichaDVD : Ficha
    {
        #region atributos
        private string director;
        private DateTime año;
        private ArrayList actores;
        #endregion

        #region propiedades
        public string Director
        {
            get { return director; }
        }

        public DateTime Año
        {
            get { return año; }
        }

        public ArrayList Actores
        {
            get { return actores; }
        }
        #endregion
        public FichaDVD(string referencia, string titulo, int numEjemplares, string director, DateTime año, ArrayList actores) : base(referencia, titulo, numEjemplares)
        {
            this.actores = actores;
            this.director = director;
            this.actores = actores; 
        }

        public override void imprimir()
        {
            Console.WriteLine("---------- DATOS INTRODUCIDOS ----------" +
                "\nReferencia -->\t\t" + Referencia +
                "\nTítulo -->\t\t" + Titulo +
                "\nDirector -->\t\t" + Director +
                "\nAño -->\t\t" + Año.Year +
                "\nEjemplares -->\t\t" + NumEjemplares +
                "\nActores:");
            showActores();
        }

        private void showActores()
        {
            for(int i = 0; i < actores.Count; i++)
            {
                Console.WriteLine("\t· " + actores[i]);
            }
        }
    }
}
