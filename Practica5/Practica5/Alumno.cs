/*
* PRÁCTICA.............: Práctica 5.
* NOMBRE Y APELLIDOS...: José Ramón Gallego Vélez
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Estructuras de Datos Internas y Manejo de Ficheros.
* FECHA DE ENTREGA.....: 18 de noviembre de 2022
*/

namespace Practica5
{
    internal class Alumno : IComparable<Alumno>
    {
        #region atributos
        private int numMatr;
        private static int contador = 0;
        private string nombre;
        private float[] notas;
        #endregion  

        #region propiedades
        public int NumMatr
        {
            get { return numMatr; }
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public float[] Notas
        {
            get { return notas; }
        }
        #endregion
        public Alumno(string nombre, float[] notas)
        {
            numMatr = contador++;
            this.nombre = nombre;
            this.notas = notas;
        }

        public void imprimeAlumno()
        {
            Console.WriteLine("Matrícula: " + NumMatr + " Nombre: " + Nombre);
        }

        public float mediaAlumno()
        {
            float media = 0;
            for(int i = 0; i < Notas.Length; i++)
            {
                media += Notas[i];
            }

            media = media / Notas.Length;
            return media;
        }

        public string showNotas()
        {
            string notas = "";
            for (int i = 0; i < Notas.Length; i++)
            {
                if (i != Notas.Length - 1)
                {
                    notas += Notas[i] + ",";
                }
                else
                {
                    notas += Notas[i];
                }
            }
            return notas;
        }

        public int CompareTo(Alumno? other)
        {
            return this.Nombre.CompareTo(other.Nombre);
        }

        public override string ToString()
        {
            return "Matrícula: " + numMatr + " || Nombre: " + Nombre + " || Notas: " + showNotas() + " || Media: " + mediaAlumno();
        }
    }
}
