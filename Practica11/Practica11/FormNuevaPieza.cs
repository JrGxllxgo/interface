using Practica11.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    public partial class FormNuevaPieza : Form
    {
        List<string> formasPiezas;
        public FormNuevaPieza()
        {
            InitializeComponent();
            formasPiezas = new List<string>();
            cbColores.SelectedItem = cbColores.Items[0];
            CenterToParent();
        }

        private void chckBoxPieza_Changed(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                checkBox.Image = Resources.cuadrado_pieza_relleno;
            }
            else
            {
                checkBox.Image = Resources.cuadrado_pieza_vacio;
            }
        }

        private void btnContinuarNuevaPieza_Click(object sender, EventArgs e)
        {

            string formaPieza = "";
            for (int i = Controls.Count - 1; i > 2; i = i - 4)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Controls[i - j].GetType() == typeof(CheckBox))
                    {
                        if (((CheckBox)Controls[i - j]).Checked)
                        {
                            formaPieza += "1";
                        }
                        else
                        {
                            formaPieza += "0";
                        }
                        ((CheckBox)Controls[i - j]).Checked = false;
                        if (formasPiezas.Count == 3)
                        {
                            ((CheckBox)Controls[i - j]).Enabled = false;

                        }
                    }
                }
            }
            if (formaPieza.IndexOf('1') == -1)
            {
                MessageBox.Show("Debes rellenar al menos un bloque");
            }
            else
            {

                formasPiezas.Add(formaPieza);
                MessageBox.Show("Forma registrada");
                if (formasPiezas.Count == 4)
                {
                    ((Button)sender).Enabled = false;
                }
            }
            btnTerminar.Enabled = true;

        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {

            if (formasPiezas.Count == 3)
            {
                MessageBox.Show("Si ya has registrado 3 formas debes registrar una cuarta obligatoriamente");
            }
            else
            {
                Pieza piezaNueva = new Pieza();
                if (formasPiezas.Count == 4)
                {
                    piezaNueva = new Pieza(formasPiezas[0], formasPiezas[1], formasPiezas[2], formasPiezas[3], cbColores.SelectedIndex + 1);
                }
                else if (formasPiezas.Count == 2)
                {
                    piezaNueva = new Pieza(formasPiezas[0], formasPiezas[1], formasPiezas[0], formasPiezas[1], cbColores.SelectedIndex + 1);
                }
                else if (formasPiezas.Count == 1)
                {
                    piezaNueva = new Pieza(formasPiezas[0], formasPiezas[0], formasPiezas[0], formasPiezas[0], cbColores.SelectedIndex + 1);
                }
                Constantes.NUM_PIEZAS += 1;
                frmGUI.t.M_matrizPiezas.Add(piezaNueva);
                this.Close();
            }
        }
    }
}
