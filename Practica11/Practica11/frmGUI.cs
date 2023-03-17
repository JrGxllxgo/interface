using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Practica11;
using Microsoft.Win32;
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
    /// Descripción breve de Form1.
    /// </summary>
    public class frmGUI : Form
    {
        public static PictureBox pbPantallaJuego;
        private System.Windows.Forms.Timer timer1;
        private IContainer components;
        public static Tetris t;
        private bool haciaAbajo;
        private bool haciaDerecha;
        private bool rotaDerecha;
        private bool rotaIzquierda;
        private bool enPausa;
        private System.Windows.Forms.Timer timer2;
        private Label lblNumLineas;
        private Label lblNivel;
        private Label label2;
        private Label label1;
        private Label label3;
        private PictureBox pbPiezaSiguiente;
        private MenuStrip menu;
        private ToolStripMenuItem btnJuegoMenuItem;
        private ToolStripMenuItem btnNuevoMenuItemJuego;
        private ToolStripMenuItem btnPausaMenuItemJuego;
        private ToolStripMenuItem btnSalirMenuItemJuego;
        private ToolStripMenuItem btnAcercaDeMenuItem;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private ToolStripMenuItem btnNúmeroDeFilasMenuItemConfiguracion;
        private ToolStripMenuItem btnAñadirPiezasMenuItemConfiguracion;
        private bool haciaIzquierda;
        public static string RegPath = @"Software\MyApp\";

        public frmGUI()
        {
            //
            // Necesario para admitir el Diseñador de Windows Forms
            //
            InitializeComponent();

            //
            // TODO: agregar código de constructor después de llamar a InitializeComponent
            //
        }

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms
        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGUI));
            pbPantallaJuego = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblNumLineas = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPiezaSiguiente = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.btnJuegoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevoMenuItemJuego = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPausaMenuItemJuego = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalirMenuItemJuego = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNúmeroDeFilasMenuItemConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAñadirPiezasMenuItemConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAcercaDeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(pbPantallaJuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiezaSiguiente)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPantallaJuego
            // 
            pbPantallaJuego.BackColor = System.Drawing.Color.Black;
            pbPantallaJuego.Location = new System.Drawing.Point(163, 30);
            pbPantallaJuego.Name = "pbPantallaJuego";
            pbPantallaJuego.Size = new System.Drawing.Size(312, 516);
            pbPantallaJuego.TabIndex = 0;
            pbPantallaJuego.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblNumLineas
            // 
            this.lblNumLineas.BackColor = System.Drawing.Color.Black;
            this.lblNumLineas.ForeColor = System.Drawing.Color.White;
            this.lblNumLineas.Location = new System.Drawing.Point(19, 187);
            this.lblNumLineas.Name = "lblNumLineas";
            this.lblNumLineas.Size = new System.Drawing.Size(120, 28);
            this.lblNumLineas.TabIndex = 1;
            this.lblNumLineas.Text = "0";
            this.lblNumLineas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNivel
            // 
            this.lblNivel.BackColor = System.Drawing.Color.Black;
            this.lblNivel.ForeColor = System.Drawing.Color.White;
            this.lblNivel.Location = new System.Drawing.Point(19, 256);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(120, 28);
            this.lblNivel.TabIndex = 2;
            this.lblNivel.Text = "1";
            this.lblNivel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nivel:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lineas:";
            // 
            // pbPiezaSiguiente
            // 
            this.pbPiezaSiguiente.BackColor = System.Drawing.Color.Black;
            this.pbPiezaSiguiente.Location = new System.Drawing.Point(19, 49);
            this.pbPiezaSiguiente.Name = "pbPiezaSiguiente";
            this.pbPiezaSiguiente.Size = new System.Drawing.Size(96, 99);
            this.pbPiezaSiguiente.TabIndex = 7;
            this.pbPiezaSiguiente.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Próxima pieza:";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnJuegoMenuItem,
            this.configuraciónToolStripMenuItem,
            this.btnAcercaDeMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(416, 24);
            this.menu.TabIndex = 9;
            this.menu.Text = "menuStrip1";
            // 
            // btnJuegoMenuItem
            // 
            this.btnJuegoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevoMenuItemJuego,
            this.btnPausaMenuItemJuego,
            this.btnSalirMenuItemJuego});
            this.btnJuegoMenuItem.Name = "btnJuegoMenuItem";
            this.btnJuegoMenuItem.Size = new System.Drawing.Size(50, 20);
            this.btnJuegoMenuItem.Text = "Juego";
            // 
            // btnNuevoMenuItemJuego
            // 
            this.btnNuevoMenuItemJuego.Name = "btnNuevoMenuItemJuego";
            this.btnNuevoMenuItemJuego.Size = new System.Drawing.Size(109, 22);
            this.btnNuevoMenuItemJuego.Text = "Nuevo";
            this.btnNuevoMenuItemJuego.Click += new System.EventHandler(this.btnNuevoMenuItemJuego_Click);
            // 
            // btnPausaMenuItemJuego
            // 
            this.btnPausaMenuItemJuego.Name = "btnPausaMenuItemJuego";
            this.btnPausaMenuItemJuego.Size = new System.Drawing.Size(109, 22);
            this.btnPausaMenuItemJuego.Text = "Pausa";
            this.btnPausaMenuItemJuego.Click += new System.EventHandler(this.btnPausaMenuItemJuego_Click);
            // 
            // btnSalirMenuItemJuego
            // 
            this.btnSalirMenuItemJuego.Name = "btnSalirMenuItemJuego";
            this.btnSalirMenuItemJuego.Size = new System.Drawing.Size(109, 22);
            this.btnSalirMenuItemJuego.Text = "Salir";
            this.btnSalirMenuItemJuego.Click += new System.EventHandler(this.btnSalirMenuItemJuego_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNúmeroDeFilasMenuItemConfiguracion,
            this.btnAñadirPiezasMenuItemConfiguracion});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // btnNúmeroDeFilasMenuItemConfiguracion
            // 
            this.btnNúmeroDeFilasMenuItemConfiguracion.Name = "btnNúmeroDeFilasMenuItemConfiguracion";
            this.btnNúmeroDeFilasMenuItemConfiguracion.Size = new System.Drawing.Size(222, 22);
            this.btnNúmeroDeFilasMenuItemConfiguracion.Text = "Número de filas y columnas";
            this.btnNúmeroDeFilasMenuItemConfiguracion.Click += new System.EventHandler(this.btnNúmeroDeFilasMenuItemConfiguracion_Click);
            // 
            // btnAñadirPiezasMenuItemConfiguracion
            // 
            this.btnAñadirPiezasMenuItemConfiguracion.Name = "btnAñadirPiezasMenuItemConfiguracion";
            this.btnAñadirPiezasMenuItemConfiguracion.Size = new System.Drawing.Size(222, 22);
            this.btnAñadirPiezasMenuItemConfiguracion.Text = "Añadir piezas";
            this.btnAñadirPiezasMenuItemConfiguracion.Click += new System.EventHandler(this.btnAñadirPiezasMenuItemConfiguracion_Click);
            // 
            // btnAcercaDeMenuItem
            // 
            this.btnAcercaDeMenuItem.Name = "btnAcercaDeMenuItem";
            this.btnAcercaDeMenuItem.Size = new System.Drawing.Size(71, 20);
            this.btnAcercaDeMenuItem.Text = "Acerca de";
            this.btnAcercaDeMenuItem.Click += new System.EventHandler(this.btnAcercaDeMenuItem_Click);
            // 
            // frmGUI
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(416, 473);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbPiezaSiguiente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblNumLineas);
            this.Controls.Add(pbPantallaJuego);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "frmGUI";
            this.Text = "eTetris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGUI_FormClosing);
            this.Load += new System.EventHandler(this.frmGUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGUI_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGUI_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(pbPantallaJuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiezaSiguiente)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// Punto de entrada principal de la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new frmGUI());
        }

        private void frmGUI_Load(object sender, System.EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Practica11");
            if (key != null)
            {
                int x = (int)key.GetValue("PosiciónFormX");
                int y = (int)key.GetValue("PosiciónFormY");
                int ancho = (int)key.GetValue("AnchuraForm");
                int altura = (int)key.GetValue("AlturaForm");
                this.Location = new Point(x, y);
                this.Size = new Size(ancho, altura);
            }
            pbPantallaJuego.Width = Convert.ToInt32(Constantes.COLUMNAS_PANTALLA) * 21 - Convert.ToInt32(Constantes.COLUMNAS_PANTALLA);
            pbPantallaJuego.Height = Convert.ToInt32(Constantes.FILAS_PANTALLA) * 21 - Convert.ToInt32(Constantes.FILAS_PANTALLA);
            t = new Tetris();
        }

        private void frmGUI_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            string strKeyPress;
            strKeyPress = e.KeyCode.ToString();
            if (!t.juegoTerminado)
            {
                switch (strKeyPress.ToUpper())
                {
                    case "LEFT":
                        haciaIzquierda = true;
                        //t.muevePiezaIzquierda();
                        //pintaPantalla(t.matrizPantalla);
                        break;
                    case "RIGHT":
                        haciaDerecha = true;
                        //t.muevePiezaDerecha();
                        //pintaPantalla(t.matrizPantalla);
                        break;
                    case "UP":
                        rotaDerecha = true;
                        //t.rotaPiezaDerecha();
                        //pintaPantalla(t.matrizPantalla);
                        break;
                    case "A":
                        rotaIzquierda = true;
                        //t.rotaPiezaIzquierda();
                        //pintaPantalla(t.matrizPantalla);
                        break;
                    case "DOWN":
                        haciaAbajo = true;
                        //t.muevePiezaAbajo();
                        //pintaPantalla(t.matrizPantalla);
                        break;
                    case "P":
                        pausaJuego();
                        break;
                    default:
                        //MessageBox.Show(strKeyPress.ToUpper());
                        break;
                }
            }
            else
            {
                switch (strKeyPress.ToUpper())
                {
                    case "ENTER":

                        break;
                    default:
                        break;
                }
            }
        }

        private void frmGUI_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            string strKeyPress = null;
            strKeyPress = e.KeyCode.ToString();
            if (!t.juegoTerminado)
            {
                switch (strKeyPress.ToUpper())
                {
                    case "LEFT":
                        haciaIzquierda = false;
                        break;
                    case "RIGHT":
                        haciaDerecha = false;
                        break;
                    case "DOWN":
                        haciaAbajo = false;
                        break;
                    case "UP":
                        rotaDerecha = false;
                        break;
                    case "A":
                        rotaIzquierda = false;
                        break;
                    default:
                        //MessageBox.Show(strKeyPress.ToUpper());
                        break;
                }
            }
        }

        public void pintaPantalla(int[,] matrizPantalla)
        {
            Bitmap B = new Bitmap(pbPantallaJuego.Width, pbPantallaJuego.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics G = Graphics.FromImage(B);
            G.Clear(Color.Black);
            for (int x = 0; x < Constantes.COLUMNAS_PANTALLA; x++)
            {
                for (int y = 0; y < Constantes.FILAS_PANTALLA; y++)
                {
                    int elemento = matrizPantalla[y, x];
                    if (elemento != 0)
                    {
                        dibujaCuadro(G, y, x, Constantes.COLORES(elemento - 1));
                    }
                }
            }
            pbPantallaJuego.Image = B;
        }

        public void pintaPiezaSiguiente(Pieza p)
        {
            Bitmap B = new Bitmap(pbPiezaSiguiente.Width, pbPiezaSiguiente.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics G = Graphics.FromImage(B);
            G.Clear(Color.Black);
            for (int x = 0; x < Constantes.COLUMNAS_PIEZAS; x++)
            {
                for (int y = 0; y < Constantes.FILAS_PIEZAS; y++)
                {
                    int elemento = t.piezaSiguiente[y, x];
                    if (elemento != 0)
                    {
                        dibujaCuadro(G, y, x, Constantes.COLORES(t.piezaSiguiente.color - 1));
                    }
                }
            }
            pbPiezaSiguiente.Image = B;
        }

        private void dibujaCuadro(Graphics G, int Y, int X, Color C)
        {
            int x = (X * Constantes.ANCHO_CELDA) + 1;
            int y = (Y * Constantes.ALTO_CELDA) + 1;
            SolidBrush Br = new SolidBrush(C);
            G.FillRectangle(Br, x, y, Constantes.ANCHO_CELDA - 2, Constantes.ALTO_CELDA - 2);
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (t.numLineas < Constantes.NUM_LINEAS_POR_NIVEL)
            {
                lblNumLineas.Text = t.numLineas.ToString();
                if (haciaAbajo)
                    actualizaPantalla();
                else
                {
                    haciaAbajo = true;
                    actualizaPantalla();
                    haciaAbajo = false;
                }
                pintaPiezaSiguiente(t.piezaSiguiente);
                if (t.juegoTerminado)
                {
                    timer1.Stop();
                    MessageBox.Show("Se terminó el juego");
                    FormPuntaje formPuntaje = new FormPuntaje(lblNivel.Text + " (" + Constantes.COLUMNAS_PANTALLA + " x " + Constantes.FILAS_PANTALLA + ")");
                    formPuntaje.ShowDialog();
                    configuraciónToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void timer2_Tick(object sender, System.EventArgs e)
        {
            if (t.numLineas < Constantes.NUM_LINEAS_POR_NIVEL)
            {
                actualizaPantalla();
            }
            else
            {
                timer2.Stop();
                timer1.Stop();
                lblNumLineas.Text = t.numLineas.ToString();
                inicializaTeclas();
                t.nuevoNivel();
                MessageBox.Show("¡¡Enhorabuena!! Has pasado al nivel " + (t.nivel + 1));
                lblNivel.Text = ((int)t.nivel + 1).ToString();
                timer1.Interval = Constantes.NIVELES(t.nivel);
                timer2.Start();
                timer1.Start();
            }
            if (t.juegoTerminado)
            {
                timer2.Stop();
            }
        }

        private void actualizaPantalla()
        {
            if (haciaAbajo)
            {
                t.muevePiezaAbajo();
            }
            if (haciaDerecha)
            {
                t.muevePiezaDerecha();
            }
            if (haciaIzquierda)
            {
                t.muevePiezaIzquierda();
            }
            if (rotaDerecha)
            {
                t.rotaPiezaDerecha();
                rotaDerecha = false;
            }
            if (rotaIzquierda)
            {
                t.rotaPiezaIzquierda();
                rotaIzquierda = false;
            }
            pintaPantalla(t.matrizPantalla);
        }

        private void inicializaTeclas()
        {
            haciaDerecha = false;
            haciaIzquierda = false;
            rotaDerecha = false;
            rotaIzquierda = false;
            haciaAbajo = false;
            enPausa = false;
        }

        private void nuevoJuego()
        {
            inicializaTeclas();
            t.nuevoJuego();
            timer1.Interval = Constantes.NIVELES(t.nivel);
            pintaPantalla(t.matrizPantalla);
            timer1.Start();
            timer2.Start();
            configuraciónToolStripMenuItem.Enabled = false;
        }

        private void pausaJuego()
        {
            if (!enPausa)
            {
                configuraciónToolStripMenuItem.Enabled = true;
                timer1.Stop();
                timer2.Stop();
            }
            else
            {
                configuraciónToolStripMenuItem.Enabled = false;
                timer1.Start();
                timer2.Start();
            }
            enPausa = !enPausa;
        }

        private void btnSalirMenuItemJuego_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoMenuItemJuego_Click(object sender, EventArgs e)
        {
            nuevoJuego();
        }

        private void btnPausaMenuItemJuego_Click(object sender, EventArgs e)
        {
            pausaJuego();
        }

        private void btnAcercaDeMenuItem_Click(object sender, EventArgs e)
        {
            enPausa = false;
            pausaJuego();
            MessageBox.Show("Modificado por José Ramón Gallego Vélez" + "\nVersión 1.0.0", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNúmeroDeFilasMenuItemConfiguracion_Click(object sender, EventArgs e)
        {
            enPausa = false;
            pausaJuego();

            FormConfgDimensiones formConfgDimensiones = new FormConfgDimensiones();
            formConfgDimensiones.ShowDialog();

            Width = pbPantallaJuego.Width + 250;
            Height = pbPantallaJuego.Height + 150;
        }

        private void btnAñadirPiezasMenuItemConfiguracion_Click(object sender, EventArgs e)
        {
            enPausa = false;
            pausaJuego();

            FormNuevaPieza formNuevaPieza = new FormNuevaPieza();
            formNuevaPieza.ShowDialog();
        }

        private void frmGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Practica11");
            key.SetValue("PosiciónFormX", this.Location.X);
            key.SetValue("PosiciónFormY", this.Location.Y);
            key.SetValue("AnchuraForm", this.Width);
            key.SetValue("AlturaForm", this.Height);
        }
    }
}
