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
	/// Descripci�n breve de Pieza.
	/// </summary>
	public class Pieza: ICloneable
	{
		private int m_posX, m_posY;
		private int m_color;
		private int m_rotacion;
		private FormaPieza [] formas = new FormaPieza[Constantes.NUM_ROTACIONES];
		public FormaPieza[] Formas { get { return formas; } }

        public Pieza()
        {

        }
		
		public Pieza(string formaPiezaRotacion1, string formaPiezaRotacion2, string formaPiezaRotacion3, string formaPiezaRotacion4, int color)
		{
			m_color = color;
			m_rotacion = 0;
			formas[0] = new FormaPieza(formaPiezaRotacion1);
			formas[1] = new FormaPieza(formaPiezaRotacion2);
			formas[2] = new FormaPieza(formaPiezaRotacion3);
			formas[3] = new FormaPieza(formaPiezaRotacion4);
			m_posX = 6;
			m_posY = 0 - alto + 1;
		}

		public int this [int y, int x]
		{
			get 
			{
				if (x < 0 || x > Constantes.COLUMNAS_PIEZAS || y < 0 || y > Constantes.FILAS_PIEZAS)
					throw new Exception("El intervalo est� fuera del �ndice");
				else
					return ((FormaPieza)formas[m_rotacion])[y, x];
			}
			set 
			{
				if (!(x < 0 || x > Constantes.COLUMNAS_PIEZAS || y < 0 || y > Constantes.FILAS_PIEZAS))
					((FormaPieza)formas[m_rotacion])[y, x] = value;
				else
					throw new Exception("El intervalo est� fuera del �ndice");
			}
		}

		public int ancho
		{
			get
			{
				return ((FormaPieza)formas[m_rotacion]).ancho;
			}
		}

		public int alto
		{
			get
			{
				return ((FormaPieza)formas[m_rotacion]).alto;
			}
		}

		public int posX
		{
			get
			{
				return m_posX;
			}
			set
			{
				m_posX = value;
			}
		}

		public int posY
		{
			get
			{
				return m_posY;
			}
			set
			{
				m_posY = value;
			}
		}

		public int color
		{
			get
			{
				return m_color;
			}
			set
			{
				m_color = value;
			}
		}

		public void rotarDerecha()
		{
			if (m_rotacion < Constantes.NUM_ROTACIONES - 1)
				m_rotacion++;
			else
				m_rotacion = 0;
		}

		public void rotarIzquierda()
		{
			if (m_rotacion > 0)
				m_rotacion--;
			else
				m_rotacion = Constantes.NUM_ROTACIONES - 1;		
		}

		#region Miembros de ICloneable

		public object Clone()
		{
			Pieza p = new Pieza();
			p.formas = (FormaPieza[])this.formas.Clone();
			p.m_posY = this.posY;
			p.m_posX = this.posX;
			p.m_color = this.color;
			p.m_rotacion = this.m_rotacion;
			return p;
		}

		#endregion
	}
}
