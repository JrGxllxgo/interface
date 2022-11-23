/*
* PRÁCTICA.............: Práctica 5.
* NOMBRE Y APELLIDOS...: José Ramón Gallego Vélez
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Estructuras de Datos Internas y Manejo de Ficheros.
* FECHA DE ENTREGA.....: 18 de noviembre de 2022
*/
using Microsoft.VisualBasic;

namespace Practica5
{
    internal class Aplicacion
    {
        #region Atributos para imprimir
        private static List<string> header;
        private static List<int> cursor;
        #endregion
        public static void Main(string[] args)
        {
            Grupo myGroup = createGroup();

            int optSelected = 8;

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("************** GESTIÓN DE GRUPO **************");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1. Añadir alumno" +
                    "\n2. Borrar Alumno" +
                    "\n3. Consulta Alumno" +
                    "\n4. Acta del Grupo" +
                    "\n5. Guardar Información" +
                    "\n6. Recuperar Información" +
                    "\n7. Salir");
                optSelected = Auxiliar.solicitarEnteroRango(1, 7, "Introduzca el numero de la opcion");
                Console.ForegroundColor = ConsoleColor.White;

                switch (optSelected)
                {
                    case 1:
                        myGroup.anadirAlumno(createAlumno(myGroup));
                        Auxiliar.continueKey();
                        break;
                    case 2:
                        borrarAlumno(myGroup);
                        Auxiliar.continueKey();
                        break;
                    case 3:
                        consultaAlumno(myGroup);
                        Auxiliar.continueKey();
                        break;
                    case 4:
                        imprimirActa(myGroup);
                        Auxiliar.continueKey();
                        break;
                    case 5:
                        saveData(myGroup);
                        Auxiliar.continueKey();
                        break;
                    case 6:
                        break;
                    case 7:
                        Console.WriteLine("Hasta luego!!!");
                        Environment.Exit(0);
                        break;
                    default: //mensaje predefinido que saldrá cuando introduzcan un valor numérico que no está entre las opciones
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción no válida");
                        Console.ForegroundColor = ConsoleColor.White;
                        Auxiliar.continueKey();
                        break;
                }
            }
        }

        private static void imprimirFila(string[] fila)
        {
            for (int i = 0; i < fila.Length - 1; i++)
            {
                Console.SetCursorPosition(cursor[i], Console.CursorTop);
                Console.Write(fila[i]);
            }
            Console.WriteLine();
        }
        private static void imprimirHeader(string[] fila)
        {
            cursor = new List<int>();

            for (int i = 0; i < fila.Length - 1; i++)
            {
                cursor.Add(Console.CursorLeft);
                Console.WriteLine(cursor[i]);
                if (i == 1)
                {
                    Console.SetCursorPosition(Console.CursorLeft + 10, Console.CursorTop);
                }
                else
                {
                    Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
                }
            }

            cursor.Add(Console.CursorLeft);
            Console.WriteLine(fila[fila.Length - 1]);
        }
        //falta imprimir las filas
        private static void imprimirActa(Grupo myGroup)
        {
            if (myGroup.Alumnos.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No hay alumnos registrados");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                myGroup.Alumnos.Sort();

                List<string> fila;

                imprimirHeader(header.ToArray());

                for (int i = 0; i < myGroup.Alumnos.Count; i++)
                {
                    fila = new List<string>();

                    fila.Add(Convert.ToString(myGroup.Alumnos[i].NumMatr));

                    fila.Add(myGroup.Alumnos[i].Nombre);

                    imprimirNotas(myGroup.Alumnos[i], fila);

                    fila.Add(Convert.ToString(myGroup.Alumnos[i].mediaAlumno));
                }

                fila = new List<string>();

                fila.Add("MEDIAS");
                fila.Add("");

                for (int i = 0; i < myGroup.Alumnos[0].Notas.Length; i++)
                {
                    fila.Add(Convert.ToString(myGroup.mediaAsignatura(i)));
                }

                imprimirFila(fila.ToArray());

                Console.WriteLine();
            }
        }

        private static void imprimirNotas(Alumno alumno, List<string> fila)
        {
            for (int i = 0; i < alumno.Notas.Length; i++)
            {
                fila.Add(Convert.ToString(alumno.Notas[i]));
            }
        }

        private static void saveData(Grupo myGroup)
        {
            StreamWriter ficheroAlumnos = File.CreateText("D:\\2 DAM\\Interface\\prueba.txt");

            for (int i = 0; i < myGroup.Alumnos.Count; i++)
            {
                ficheroAlumnos.WriteLine(myGroup.Alumnos[i].ToString());
            }

            ficheroAlumnos.Close();
            Console.WriteLine("Datos guardados correctamente");
        }

        private static void consultaAlumno(Grupo myGroup)
        {
            try
            {
                Alumno alumno = myGroup.buscaAlumno(Auxiliar.solicitarEnteroRango(0, myGroup.Alumnos.Count, "Introduzca el numero de matricula"));
                alumno.imprimeAlumno();
            }
            catch (NullReferenceException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Alumno no existe");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private static void borrarAlumno(Grupo myGroup)
        {
            try
            {
                myGroup.borraAlumno(Auxiliar.solicitarEnteroRango(0, myGroup.Alumnos.Count, "Introduzca el numero de matricula"));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Alumno borrado con éxito");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Matrícula no existe");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private static Alumno createAlumno(Grupo myGroup)
        {
            string nombre = Auxiliar.leerCadena("Introduzca el nombre del alumno");

            float[] notas = new float[myGroup.NumAsignaturas];

            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = Auxiliar.solicitarEnteroRango(0, 10, "Introduzca la nota del 0 al 10");
            }

            return new Alumno(nombre, notas);
        }

        private static Grupo createGroup()
        {
            header = new List<string>();
            header.Add("MATRÍCULA");
            header.Add("NOMBRE");

            string nombre = Auxiliar.leerCadena("Nombre del grupo: ");

            int numAsignaturas = Auxiliar.solicitarEnteroRango(5, 9, "Número de asignaturas [5 - 9]: ");

            string[] codAsignaturas = new string[numAsignaturas];

            Console.WriteLine("Escriba el código de la asignatura (3 caracteres)");
            for (int i = 0; i < numAsignaturas; i++)
            {
                string asignatura = null;
                while (asignatura == null || asignatura.Length > 3)
                {
                    asignatura = Auxiliar.leerCadena("Asignatura " + i).ToUpper();

                    if (asignatura.Length > 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No puede ser más de tres carácteres");
                        Console.ForegroundColor = ConsoleColor.White;
                        asignatura = Auxiliar.leerCadena("Asignatura " + i).ToUpper();
                    }
                }

                codAsignaturas[i] = asignatura;
                header.Add(codAsignaturas[i]);
            }

            header.Add("MEDIA");

            return new Grupo(nombre, numAsignaturas, codAsignaturas);
        }
    }
}