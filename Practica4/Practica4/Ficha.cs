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
    public abstract class Ficha
    {
        #region atributos
        private string referencia;
        private string titulo;
        private int numEjemplares;
        private int numOrden;
        #endregion

        #region propiedades
        public string Referencia
        {
            get { return referencia; }
        }
        public string Titulo
        {
            get { return titulo; }
        }
        public int NumEjemplares
        {
            get { return numEjemplares; }
        }
        public int NumOrden
        {
            get { return numOrden; }
        }
        #endregion

        public Ficha(string referencia, string titulo, int numEjemplares) {
            this.referencia = referencia + "/" + NumOrden;
            this.titulo = titulo;
            this.numEjemplares = numEjemplares;
            numOrden++;
        }

        public abstract void imprimir();
    }
}
