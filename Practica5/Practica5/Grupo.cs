using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    internal class Grupo
    {
        #region atributos
        private string nombreGrupo;
        private int numAsignaturas;
        private string[] codsignaturas;
        List<Alumno> alumnos;
        #endregion

        #region propiedades
        public string NombreGrupo
        {
            get { return nombreGrupo; }
        }
        public int NumAsignaturas
        {
            get { return numAsignaturas; }
        }
        public string[] Codsignaturas
        {
            get { return codsignaturas; }
        }
        #endregion

        public Grupo(String nombreGrupo, int numAsignaturas, string[] codAsignaturas)
        {
            this.nombreGrupo = nombreGrupo;
            this.numAsignaturas = numAsignaturas;
            this.codsignaturas = codsignaturas;
            this.alumnos = new List<Alumno>();
        }

        public void anadirAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

        private int localizaAlumno(int matricula)
        {
            int pos = -1;
            for(int i = 0; i < alumnos.Count; i++)
            {
                if (alumnos[i].NumMatr == matricula)
                {
                    pos = i;
                }
            }

            return pos;
        }

        public Alumno buscaAlumno(int numMatricula)
        {
            int pos = localizaAlumno(numMatricula);
            Alumno encontrado = null;
            if (pos != -1)
            {
                encontrado = alumnos[pos];
            }
            return encontrado;
        }

        public bool borraAlumno(int numMatricula)
        {
            int pos = localizaAlumno(numMatricula);

            bool del = false;

            if(pos != 1)
            {
                del = true;
            }

            return del;
        }

        public double mediaAsignatura(int posicionAs)
        {
            int media = 0;
            for (int i = 0; i < alumnos.Count; i++)
            {
                media += alumnos[i].Notas[posicionAs];
            }
            media = media / alumnos.Count;
            return media;
        }

        public 
    }
}
