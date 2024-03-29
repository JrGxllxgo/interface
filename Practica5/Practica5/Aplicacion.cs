﻿/*
* PRÁCTICA.............: Práctica 5.
* NOMBRE Y APELLIDOS...: José Ramón Gallego Vélez
* CURSO Y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO DE LA PRÁCTICA: Estructuras de Datos Internas y Manejo de Ficheros.
* FECHA DE ENTREGA.....: 18 de noviembre de 2022
*/
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Practica5
{
    internal class Aplicacion
    {
        #region Atributos para imprimir
        private static List<string> header;
        private static List<int> cursor;
        private static List<Grupo> grupos = new List<Grupo>();
        private static string path = "../../../GroupsFiles/";
        #endregion
        public static void Main(string[] args)
        {
            int optSelected = 8;

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("************** GESTIÓN DE GRUPO **************");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1. Crear Grupo" +
                    "\n2. Usar Grupo existente" +
                    "\n3. Definir ruta de almacenamiento: " + path +
                    "\n4.  Salir");
                optSelected = Auxiliar.solicitarEnteroRango(1, 7, "Introduzca el numero de la opcion");
                Console.ForegroundColor = ConsoleColor.White;

                switch (optSelected)
                {
                    case 1:
                        grupos.Add(createGroup());
                        Auxiliar.continueKey();
                        break;
                    case 2:
                        if (grupos.Count == 0)
                        {
                            Auxiliar.writeError("No existe ningún grupo creado");
                        }
                        else
                        {
                            printGroups();
                            int grupoSel = Auxiliar.solicitarEnteroRango(1, grupos.Count, "Seleccione el número de grupo");
                            Grupo myGroup = grupos[grupoSel - 1];

                            int optSelected2 = 7;

                            while (optSelected2 != 6)
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
                                    "\n6. Volver");
                                optSelected = Auxiliar.solicitarEnteroRango(1, 7, "Introduzca el número de la opción");
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
                                        imprimirHeader(myGroup);
                                        imprimirActa(myGroup);
                                        Auxiliar.continueKey();
                                        break;
                                    case 5:
                                        saveData(myGroup);
                                        Auxiliar.continueKey();
                                        break;
                                    case 6:
                                        optSelected2 = 6;
                                        break;
                                    default: //mensaje predefinido que saldrá cuando introduzcan un valor numérico que no está entre las opciones
                                        Auxiliar.writeError("Opción no válida");
                                        Auxiliar.continueKey();
                                        break;
                                }
                            }
                        }
                        Auxiliar.continueKey();
                        break;
                    case 3:
                        string newPath = Auxiliar.leerCadena("Introduzca la ruta deseada");
                        Console.WriteLine("Ruta modificada correctamente!!" + path + " --> " + newPath);
                        path = newPath;
                        Auxiliar.continueKey();
                        break;
                    case 4:
                        Console.WriteLine("Hasta luego!!!");
                        Environment.Exit(0);
                        break;
                    default: //mensaje predefinido que saldrá cuando introduzcan un valor numérico que no está entre las opciones
                        Auxiliar.writeError("Opción no válida");
                        Auxiliar.continueKey();
                        break;
                }
            }
        }

        private static void printGroups()
        {
            for (int i = 0; i < grupos.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + grupos[i].NombreGrupo.ToString());
            }
        }

        private static void readData(Grupo myGroup)
        {
            StreamReader myFile = File.OpenText(path + myGroup.NombreGrupo + ".txt");

            string linea;
            int cont = 0;

            while ((linea = myFile.ReadLine()) != null)
            {

                string[] data = linea.Split(';');

                string[] notas = data[2].Split(',');

                float[] notasRecuperadas = new float[notas.Length];

                for (int i = 0; i < notas.Length; i++)
                {
                    notasRecuperadas[i] = float.Parse(notas[i].Trim());
                }

                myGroup.anadirAlumno(new Alumno(data[1], notasRecuperadas));

                cont++;
            }
            if (cont == 0)
            {
                Auxiliar.writeError("No se ha recuperado ningún dato");
            }
            else
            {
                Console.WriteLine("Se han recuperado los datos correctamente");
            }
        }

        private static void imprimirFila(List<Alumno> alumnos)
        {
            int cursor = 31;
            for (int i = 0; i < alumnos.Count; i++)
            {
                cursor = 31;
                Console.Write(alumnos[i].NumMatr);
                Console.SetCursorPosition(10, Console.CursorTop);
                Console.Write(alumnos[i].Nombre);
                Console.SetCursorPosition(cursor, Console.CursorTop);

                for (int j = 0; j < alumnos[i].Notas.Length; j++)
                {
                    Console.Write(alumnos[i].Notas[j]);
                    Console.SetCursorPosition(cursor, Console.CursorTop);
                    cursor += 5;
                }

                Console.SetCursorPosition(cursor + 2, Console.CursorTop);

                Console.Write(alumnos[i].mediaAlumno());

                Console.WriteLine();
            }

        }

        private static void imprimirHeader(Grupo myGroup)
        {
            int cursor = 30;
            Console.Write("MATRÍCULA");
            Console.SetCursorPosition(10, Console.CursorTop);
            Console.Write("NOMBRE");
            Console.SetCursorPosition(cursor, Console.CursorTop);

            for (int i = 0; i < myGroup.Codsignaturas.Length; i++)
            {
                Console.Write(myGroup.Codsignaturas[i]);
                Console.SetCursorPosition(cursor, Console.CursorTop);
                cursor += 5;
            }
            Console.SetCursorPosition(cursor + 2, Console.CursorTop);
            Console.Write("MEDIA");
            Console.WriteLine();
        }

        private static void imprimirActa(Grupo myGroup)
        {
            if (myGroup.Alumnos.Count == 0)
            {
                Auxiliar.writeError("No hay alumnos registrados");
            }
            else
            {
                myGroup.Alumnos.Sort();

                imprimirFila(myGroup.Alumnos);
            }
        }

        private static void saveData(Grupo myGroup)
        {
            StreamWriter ficheroAlumnos = File.CreateText(path + myGroup.NombreGrupo + ".txt");

            for (int i = 0; i < myGroup.Alumnos.Count; i++)
            {
                ficheroAlumnos.WriteLine(myGroup.Alumnos[i].ToString());
            }

            ficheroAlumnos.Close();
            Console.WriteLine("Datos guardados correctamente");
        }

        private static void consultaAlumno(Grupo myGroup)
        {
            Alumno alumno = myGroup.buscaAlumno(Auxiliar.solicitarEnteroRango(0, myGroup.Alumnos.Count, "Introduzca el numero de matricula"));
            while (alumno == null)
            {
                Auxiliar.writeError("El alumno con esa matrícula no existe.");
                alumno = myGroup.buscaAlumno(Auxiliar.solicitarEnteroRango(0, myGroup.Alumnos.Count, "Introduzca el numero de matricula que exista"));
            }
            alumno.imprimeAlumno();
        }

        private static void borrarAlumno(Grupo myGroup)
        {
            try
            {
                if (myGroup.Alumnos.Count == 0)
                {
                    Auxiliar.writeError("No hay alumnos registrados");
                }
                else
                {
                    myGroup.Alumnos.Sort();

                    imprimirHeader(myGroup);
                    imprimirFila(myGroup.Alumnos);

                    myGroup.borraAlumno(Auxiliar.solicitarEnteroRango(0, myGroup.Alumnos.Count, "Introduzca el numero de matricula"));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Alumno borrado con éxito");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Auxiliar.writeError("Matrícula no existe");
            }
        }

        private static Alumno createAlumno(Grupo myGroup)
        {
            string nombre = Auxiliar.leerCadena("Introduzca el nombre del alumno");

            float[] notas = new float[myGroup.NumAsignaturas];

            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = Auxiliar.solicitarEnteroRango(0, 10, "Introduzca la nota del 0 al 10 de " + myGroup.Codsignaturas[i]);
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
            int i = 0;
            while (i < numAsignaturas)
            {
                string asignatura = null;
                bool incorrecto = false;
                do
                {
                    incorrecto = false;
                    asignatura = Auxiliar.leerCadena("Asignatura " + i).ToUpper();
                    if (!repAsig(codAsignaturas, asignatura))
                    {
                        //asignatura = Auxiliar.leerCadena("Asignatura " + i).ToUpper();

                        if (asignatura.Length > 3)
                        {
                            Auxiliar.writeError("No puede ser más de tres carácteres");
                            incorrecto = true;
                        }
                        else
                        {
                            codAsignaturas[i] = asignatura;
                            header.Add(codAsignaturas[i]);
                        }
                    }
                    else
                    {
                        incorrecto = true;
                    }
                }
                while (incorrecto);
                i++;
            }

            header.Add("MEDIA");

            return new Grupo(nombre, numAsignaturas, codAsignaturas);
        }

        private static bool repAsig(string[] codAsignaturas, string asignatura)
        {
            bool rep = false;
            if (codAsignaturas.Contains(asignatura))
            {
                rep = true;
                Auxiliar.writeError("La asignatura" + asignatura + " ya existe");
            }
            return rep;
        }
    }
}