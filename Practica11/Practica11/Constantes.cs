using System;
using System.Drawing;
/*
* PR�CTICA.............: Pr�ctica 11 Resumen. Clases, Objetos y dll�s
* NOMBRE y APELLIDOS...: Jos� Ram�n Gallego V�lez
* CURSO y GRUPO........: 2� Desarrollo de Interfaces
* T�TULO de la PR�CTICA: Pr�ctica 11. Matenimiento. Resumen (Recopilaci�n).
* FECHA de ENTREGA.....: 21 de febrero de 2023
*/
namespace Practica11
{
    /// <summary>
    /// Descripci�n breve de Constantes.
    /// </summary>
    public class Constantes
    {
        public const int FILAS_PIEZAS = 4;
        public const int COLUMNAS_PIEZAS = 4;
        public static int NUM_PIEZAS = 7;
        public const int NUM_ROTACIONES = 4;
        public static int FILAS_PANTALLA = 22;
        public static int COLUMNAS_PANTALLA = 13;
        public const int ANCHO_CELDA = 20;
        public const int ALTO_CELDA = 20;
        public const int NUM_LINEAS_POR_NIVEL = 2;

        private static Color[] m_COLORES = new Color[7] { Color.Red, Color.Blue, Color.DarkOrange, Color.DeepPink, Color.Violet, Color.Beige, Color.DarkMagenta };

        private static int[] m_NIVELES = new int[10] { 1000, 800, 640, 512, 410, 328, 262, 210, 168, 134 };


        public static Color COLORES(int color)
        {
            return m_COLORES[color];
        }

        public static int NIVELES(int nivel)
        {
            return m_NIVELES[nivel];
        }
    }
}
