using System;
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
	/// Descripci�n breve de FormaPieza.
	/// </summary>
	public class FormaPieza
	{
		private int m_ancho, m_alto;
		private int [, ] m_matrizPieza = new int[Constantes.COLUMNAS_PIEZAS, Constantes.FILAS_PIEZAS];
		
		public FormaPieza(string formaPieza)
		{
			if ( formaPieza.Length != Constantes.FILAS_PIEZAS * Constantes.COLUMNAS_PIEZAS)
				throw new Exception("La pieza consta de " + Constantes.FILAS_PIEZAS * Constantes.COLUMNAS_PIEZAS + " cuadrados");
			else
			{
				int bloque = 0;
				m_ancho = 0;
				m_alto = 0;
				for (int y = 0; y < Constantes.FILAS_PIEZAS; y++)
				{
					for (int x = 0; x < Constantes.COLUMNAS_PIEZAS; x++)
					{
						bloque = Int32.Parse(formaPieza.Substring((4 * y) + x, 1));
						if (bloque == 1)
						{
							if (m_alto < y + 1)
								m_alto = y + 1;
							if (m_ancho < x + 1)
								m_ancho = x + 1;
						}
						m_matrizPieza[y, x] = bloque;
					}
				}		
			}
		}

		public int this [int y, int x]
		{
			get 
			{
				if (x < 0 || x > Constantes.COLUMNAS_PIEZAS || y < 0 || y > Constantes.FILAS_PIEZAS)
					throw new Exception("El intervalo est� fuera del �ndice");
				else
					return m_matrizPieza[y, x];
			}
			set 
			{
				if (!(x < 0 || x > Constantes.COLUMNAS_PIEZAS || y < 0 || y > Constantes.FILAS_PIEZAS))
					m_matrizPieza[y, x] = value;
				else
					throw new Exception("El intervalo est� fuera del �ndice");
			}
		}

		public int ancho
		{
			get
			{
				return m_ancho;
			}
		}

		public int alto
		{
			get
			{
				return m_alto;
			}
		}
	}
}
