/*
* PRÁCTICA.............: Práctica 5.
* NOMBRE Y APELLIDOS...: José Ramón Gallego Vélez
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Estructuras de Datos Internas y Manejo de Ficheros.
* FECHA DE ENTREGA.....: 18 de noviembre de 2022
*/

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

        public List<Alumno> Alumnos
        {
            get { return alumnos; }
        }
        #endregion

        public Grupo(String nombreGrupo, int numAsignaturas, string[] codAsignaturas)
        {
            this.nombreGrupo = nombreGrupo;
            this.numAsignaturas = numAsignaturas;
            this.codsignaturas = codAsignaturas;
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
                alumnos.RemoveAt(pos);
                del = true;
            }

            return del;
        }

        public double mediaAsignatura(int posicionAs)
        {
            double media = 0;
            for (int i = 0; i < alumnos.Count; i++)
            {
                media += alumnos[i].Notas[posicionAs];
            }
            media = media / alumnos.Count;
            return media;
        }
    }
}
