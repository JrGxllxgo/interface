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
    internal class Grupo
    {
        #region Campos

        private int numMatricula = 1;
        private string nombre;
        private string[] codigosAsignaturas;
        private List<Alumno> alumnos;

        #endregion

        #region Propiedades

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string[] CodigosAsignaturas { get { return codigosAsignaturas; } set { codigosAsignaturas = value; } }
        public List<Alumno> Alumnos { get { return alumnos; } set { alumnos = value; } }

        #endregion

        public Grupo(string nombre, string[] codigosAsignaturas)
        {
            this.nombre = nombre;
            this.codigosAsignaturas = codigosAsignaturas;
            this.alumnos = new List<Alumno>();
        }

        public void anadirAlumno(Alumno alumno)
        {
            alumno.Matricula = numMatricula;
            alumnos.Add(alumno);
            numMatricula++;
        }

        private int localizarAlumno(int matricula)
        {
            int posicion = -1;
            for (int i = 0; i < alumnos.Count; i++)
            {
                if (alumnos[i].Matricula == matricula)
                {
                    posicion = i;
                }
            }
            return posicion;
        }

        public Alumno buscarAlumno(int matricula)
        {
            int posicion = localizarAlumno(matricula);
            if (posicion == -1)
            {
                throw new ArgumentOutOfRangeException();
            }

            return alumnos[posicion];
        }

        public bool borrarAlumno(int matricula)
        {
            int posicion = localizarAlumno(matricula);
            bool borrar = false;
            if (posicion == -1)
            {
                throw new ArgumentOutOfRangeException();
            }

            alumnos.RemoveAt(posicion);
            borrar = true;

            return borrar;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
