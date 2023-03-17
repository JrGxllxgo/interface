using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica11;
/*
* PRÁCTICA.............: Práctica 11 Resumen. Clases, Objetos y dll’s
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Práctica 11. Matenimiento. Resumen (Recopilación).
* FECHA de ENTREGA.....: 21 de febrero de 2023
*/
namespace Practica11
{
    public partial class FormConfgDimensiones : Form
    {
        public FormConfgDimensiones()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Constantes.FILAS_PANTALLA = Convert.ToInt32(txtAltura.Text);
            Constantes.COLUMNAS_PANTALLA = Convert.ToInt32(txtAncho.Text);
            frmGUI.pbPantallaJuego.Width = Convert.ToInt32(txtAncho.Text) * 21 - Convert.ToInt32(txtAncho.Text);
            frmGUI.pbPantallaJuego.Height = Convert.ToInt32(txtAltura.Text) * 21 - Convert.ToInt32(txtAltura.Text);
            frmGUI.t = new Practica11.Tetris();
            this.Close();
        }
        private void habilitarBoton()
        {
            if (errorProvider.GetError(txtAltura) != "" || txtAltura.Text == "" || errorProvider.GetError(txtAncho) != "" || txtAncho.Text == "")
            {
                btnOk.Enabled = false;
            }
            else
            {
                btnOk.Enabled = true;
            }
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                if (Convert.ToInt16(textBox.Text) <= 8 || Convert.ToInt16(textBox.Text) > Math.Floor(Screen.PrimaryScreen.Bounds.Height * 0.044))
                {
                    errorProvider.SetError(textBox, "La anchura debe ser mayor que 8 y menor que " + Math.Floor(Screen.PrimaryScreen.Bounds.Height * 0.044));
                }
                else
                {
                    errorProvider.SetError(textBox, "");
                }
            }
            catch (Exception)
            {
                errorProvider.SetError(textBox, "Debe ser un número entero");
            }
            habilitarBoton();
        }

        private void txtAncho_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                if (Convert.ToInt16(textBox.Text) <= 8 || Convert.ToInt16(textBox.Text) > Math.Floor(Screen.PrimaryScreen.Bounds.Width * 0.044))
                {
                    errorProvider.SetError(textBox, "La altura debe ser mayor que 8 y menor que " + Math.Floor(Screen.PrimaryScreen.Bounds.Width * 0.044));
                }
                else
                {
                    errorProvider.SetError(textBox, "");
                }
            }
            catch (Exception)
            {
                errorProvider.SetError(textBox, "Debe ser un número entero");
            }
            habilitarBoton();
        }
    }

}
