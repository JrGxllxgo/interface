using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* PRÁCTICA.............: Práctica 11 Resumen. Clases, Objetos y dll’s
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Práctica 11. Matenimiento. Resumen (Recopilación).
* FECHA de ENTREGA.....: 21 de febrero de 2023
*/
namespace Practica11
{
    internal class Jugador : IComparable<Jugador>
    {
        #region Campos

        private int numNivel;
        private string puntaje;
        private string nombre;

        #endregion

        #region Propiedades


        public int NumNivel { get { return numNivel; } set { numNivel = value; } }
        public string Puntaje { get { return puntaje; } set { puntaje = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }

        #endregion

        public Jugador(string nombre, string puntaje)
        {
            this.nombre = nombre;
            this.puntaje = puntaje;
            this.numNivel = Convert.ToInt32(puntaje.Substring(0, puntaje.IndexOf('(')));
        }

        public int CompareTo(Jugador? other)
        {
            return numNivel.CompareTo(other.numNivel);
        }
    }
}
