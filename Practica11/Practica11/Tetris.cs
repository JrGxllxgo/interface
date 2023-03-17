using System;
using System.Collections;
/*
* PRÁCTICA.............: Práctica 11 Resumen. Clases, Objetos y dll’s
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Práctica 11. Matenimiento. Resumen (Recopilación).
* FECHA de ENTREGA.....: 21 de febrero de 2023
*/
namespace Practica11
{
    /// <summary>
    /// Descripción breve de Tetris.
    /// </summary>
    public class Tetris
    {
        private List<Pieza> m_matrizPiezas;
        private MatrizPantalla m_matrizPantalla;
        private Pieza m_piezaActual;
        private Pieza m_piezaSiguiente;
        private bool m_juegoTerminado;
        private int m_puntuacion;
        private int m_nivel;
        private int m_numLineas;
        private Random r;

        public List<Pieza> M_matrizPiezas { get { return m_matrizPiezas; } }

        #region Constructor
        public Tetris()
        {
            m_matrizPantalla = new MatrizPantalla();
            m_matrizPiezas = new List<Pieza>();
            string formaPieza1 = "";
            string formaPieza2 = "";
            string formaPieza3 = "";
            string formaPieza4 = "";

            //          **
            //  Pieza   **
            // Observacion: Esa Pieza no Rota
            formaPieza1 += "1100";
            formaPieza1 += "1100";
            formaPieza1 += "0000";
            formaPieza1 += "0000";

            m_matrizPiezas.Add(new Pieza(formaPieza1, formaPieza1, formaPieza1, formaPieza1, 7));

            //          
            //  Pieza   ****
            // Observacion: Esa Pieza solo tiene 2 posiciones
            formaPieza1 = "";
            formaPieza1 += "1000";
            formaPieza1 += "1000";
            formaPieza1 += "1000";
            formaPieza1 += "1000";

            formaPieza2 = "";
            formaPieza2 += "0000";
            formaPieza2 += "1111";
            formaPieza2 += "0000";
            formaPieza2 += "0000";

            m_matrizPiezas.Add(new Pieza(formaPieza1, formaPieza2, formaPieza1, formaPieza2, 1));

            //          * 
            //  Pieza   ***
            formaPieza1 = "";
            formaPieza1 += "1100";
            formaPieza1 += "1000";
            formaPieza1 += "1000";
            formaPieza1 += "0000";

            formaPieza2 = "";
            formaPieza2 += "1110";
            formaPieza2 += "0010";
            formaPieza2 += "0000";
            formaPieza2 += "0000";

            formaPieza3 = "";
            formaPieza3 += "0100";
            formaPieza3 += "0100";
            formaPieza3 += "1100";
            formaPieza3 += "0000";

            formaPieza4 = "";
            formaPieza4 += "1000";
            formaPieza4 += "1110";
            formaPieza4 += "0000";
            formaPieza4 += "0000";
            m_matrizPiezas.Add(new Pieza(formaPieza1, formaPieza2, formaPieza3, formaPieza4, 2));

            //           * 
            //  Pieza   ***
            formaPieza1 = "";
            formaPieza1 += "1000";
            formaPieza1 += "1100";
            formaPieza1 += "1000";
            formaPieza1 += "0000";

            formaPieza2 = "";
            formaPieza2 += "1110";
            formaPieza2 += "0100";
            formaPieza2 += "0000";
            formaPieza2 += "0000";

            formaPieza3 = "";
            formaPieza3 += "0100";
            formaPieza3 += "1100";
            formaPieza3 += "0100";
            formaPieza3 += "0000";

            formaPieza4 = "";
            formaPieza4 += "0100";
            formaPieza4 += "1110";
            formaPieza4 += "0000";
            formaPieza4 += "0000";
            m_matrizPiezas.Add(new Pieza(formaPieza1, formaPieza2, formaPieza3, formaPieza4, 3));

            //           **
            //  Pieza   **
            // Observacion: Esa formaPieza solo tiene 2 posiciones
            formaPieza1 = "";
            formaPieza1 += "0110";
            formaPieza1 += "1100";
            formaPieza1 += "0000";
            formaPieza1 += "0000";

            formaPieza2 = "";
            formaPieza2 += "1000";
            formaPieza2 += "1100";
            formaPieza2 += "0100";
            formaPieza2 += "0000";
            m_matrizPiezas.Add(new Pieza(formaPieza1, formaPieza2, formaPieza1, formaPieza2, 4));

            //         **  
            //  Pieza   **
            // Observacion: Esa formaPieza solo tiene 2 posiciones
            formaPieza1 = "";
            formaPieza1 += "1100";
            formaPieza1 += "0110";
            formaPieza1 += "0000";
            formaPieza1 += "0000";

            formaPieza2 = "";
            formaPieza2 += "0100";
            formaPieza2 += "1100";
            formaPieza2 += "1000";
            formaPieza2 += "0000";

            m_matrizPiezas.Add(new Pieza(formaPieza1, formaPieza2, formaPieza1, formaPieza2, 5));

            //            * 
            //  Pieza   ***
            formaPieza1 = "";
            formaPieza1 += "1100";
            formaPieza1 += "0100";
            formaPieza1 += "0100";
            formaPieza1 += "0000";

            formaPieza2 = "";
            formaPieza2 += "1110";
            formaPieza2 += "1000";
            formaPieza2 += "0000";
            formaPieza2 += "0000";

            formaPieza3 = "";
            formaPieza3 += "1000";
            formaPieza3 += "1000";
            formaPieza3 += "1100";
            formaPieza3 += "0000";

            formaPieza4 = "";
            formaPieza4 += "0010";
            formaPieza4 += "1110";
            formaPieza4 += "0000";
            formaPieza4 += "0000";
            m_matrizPiezas.Add(new Pieza(formaPieza1, formaPieza2, formaPieza3, formaPieza4, 6));

            r = new Random(unchecked((int)DateTime.Now.Ticks));
            nuevoJuego();
        }
        #endregion


        public int[,] matrizPantalla
        {
            get
            {
                return m_matrizPantalla.matrizPantalla;
            }
        }

        public bool juegoTerminado
        {
            get
            {
                return m_juegoTerminado;
            }
        }

        public Pieza piezaSiguiente
        {
            get
            {
                return m_piezaSiguiente;
            }
        }

        public int puntuacion
        {
            get
            {
                return m_puntuacion;
            }
        }

        public int numLineas
        {
            get
            {
                return m_numLineas;
            }
        }

        public int nivel
        {
            get
            {
                return m_nivel;
            }
        }

        private Pieza nuevaPieza()
        {
            int a = r.Next(0, Constantes.NUM_PIEZAS);
            Pieza p = (Pieza)((Pieza)m_matrizPiezas[a]).Clone();
            return p;
        }

        public void muevePiezaAbajo()
        {
            Pieza pTemp = (Pieza)m_piezaActual.Clone();
            m_matrizPantalla.borrarPieza(m_piezaActual);
            pTemp.posY = pTemp.posY + 1;
            if (m_matrizPantalla.puedeBajarPieza(pTemp))
            {
                m_piezaActual = pTemp;
            }
            else
            {
                m_matrizPantalla.pintarPieza(m_piezaActual);
                m_piezaActual = m_piezaSiguiente;
                if (!m_matrizPantalla.puedeBajarPieza(m_piezaActual) && m_piezaActual.posY < 0)
                {
                    m_juegoTerminado = true;
                }
                m_piezaSiguiente = nuevaPieza();
                m_puntuacion = m_puntuacion + 4;
                m_numLineas += compruebaLineasCompletas();
            }
            if (!m_juegoTerminado)
                m_matrizPantalla.pintarPieza(m_piezaActual);
        }

        public void muevePiezaDerecha()
        {
            Pieza pTemp = (Pieza)m_piezaActual.Clone();
            m_matrizPantalla.borrarPieza(m_piezaActual);
            pTemp.posX = pTemp.posX + 1;
            if (m_matrizPantalla.puedeMoverPieza(pTemp))
            {
                m_piezaActual = pTemp;
            }
            m_matrizPantalla.pintarPieza(m_piezaActual);
        }

        public void muevePiezaIzquierda()
        {
            Pieza pTemp = (Pieza)m_piezaActual.Clone();
            m_matrizPantalla.borrarPieza(m_piezaActual);
            pTemp.posX = pTemp.posX - 1;
            if (m_matrizPantalla.puedeMoverPieza(pTemp))
            {
                m_piezaActual = pTemp;
            }
            m_matrizPantalla.pintarPieza(m_piezaActual);
        }

        public void rotaPiezaIzquierda()
        {
            Pieza pTemp = (Pieza)m_piezaActual.Clone();
            m_matrizPantalla.borrarPieza(m_piezaActual);
            pTemp.rotarIzquierda();
            if (m_matrizPantalla.puedeMoverPieza(pTemp))
            {
                m_piezaActual = pTemp;
            }
            m_matrizPantalla.pintarPieza(m_piezaActual);
        }

        public void rotaPiezaDerecha()
        {
            Pieza pTemp = (Pieza)m_piezaActual.Clone();
            m_matrizPantalla.borrarPieza(m_piezaActual);
            pTemp.rotarDerecha();
            if (m_matrizPantalla.puedeMoverPieza(pTemp))
            {
                m_piezaActual = pTemp;
            }
            m_matrizPantalla.pintarPieza(m_piezaActual);
        }

        public void nuevoJuego()
        {
            m_puntuacion = 0;
            m_numLineas = 0;
            m_nivel = 0;
            inicializa();
        }

        public void nuevoNivel()
        {
            if (m_nivel < 9)
                m_nivel++;
            m_numLineas = 0;
            inicializa();
        }

        public void inicializa()
        {
            m_matrizPantalla.borrarPantalla();
            m_piezaActual = nuevaPieza();
            System.Threading.Thread.Sleep(100); // Retardo para que no salgan las dos primeras piezas iguales
            m_piezaSiguiente = nuevaPieza();
            m_matrizPantalla.pintarPieza(m_piezaActual);
            m_juegoTerminado = false;
        }

        private int compruebaLineasCompletas()
        {
            return m_matrizPantalla.eliminaLineasCompletas();
        }

        #region Pruebas
        /*
                public void prueba()
                {
                    int color = 1;
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            color++;
                            if (color > 7)
                                color = 1;
                            for (int k = 0; k < Constantes.FILAS_PIEZAS; k++)
                            {
                                for (int l = 0; l < Constantes.COLUMNAS_PIEZAS; l++)
                                {
                                    m_matrizPantalla[(i * 4) + k + i, (j * 4) + l] = ((Pieza)m_matrizPiezas[i, j])[k, l] * color;
                                }
                            }
                        }
                    }
                }
        */
        #endregion
    }
}
