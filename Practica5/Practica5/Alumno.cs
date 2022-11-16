using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    internal class Alumno
    {
        #region atributos
        int numMatr, contador = 0;
        string nombre;
        List<int> notas;
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
        public List<int>Notas
        {
            get { return notas; }
        }
        #endregion
        Alumno(string nombre, List<int> notas)
        {
            numMatr = contador++;
            this.nombre = nombre;
            this.notas = notas;
        }

        public void imprimeAlumno()
        {
            Console.WriteLine("Matrícula: " + NumMatr + "Nombre: " + Nombre);
        }

        public int mediaAlumno()
        {
            int media = 0;
            for(int i = 0; i < Notas.Count; i++)
            {
                media += Notas[i];
            }

            media = media / Notas.Count;
            return media;
        }
    }
}
