/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 20 de Enero de 2023
*/

namespace Practica8
{
    [Serializable]
    internal class Alumno
    {
        #region Campos

        private int matricula;
        private string nombre;
        private double[] notas;

        #endregion

        #region Propiedades

        public int Matricula { get { return matricula; } set { matricula = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public double[] Notas { get { return notas; } set { notas = value; } }

        #endregion

        public Alumno(string nombre, double[] notas)
        {
            this.nombre = nombre;
            this.notas = notas;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
