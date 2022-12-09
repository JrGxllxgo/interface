using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica6
{
    public partial class frmHojaSalarial : Form
    {
        public frmHojaSalarial()
        {
            InitializeComponent();
            comBCat.Items.Insert(0, 1);
            comBCat.Items.Insert(1, 2);
            comBCat.Items.Insert(2, 3);
            maskTxtBNIF.Mask = "00000000L";

            errorNif = new System.Windows.Forms.ErrorProvider();
            errorNif.BlinkRate = 1000;
            errorNif.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grBData_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

        }

        private void maskTxtBNIF_Leave(object sender, EventArgs e)
        {
            if (!(ValidarNIF(maskTxtBNIF.Text)))
            {
                btnCalc.Text = "";
            }
        }

        public static bool ValidarNIF(string NIF)
        {
            if (NIF == "")
            {
                return false;
            }
            else
            {
                //Obtenemos la letra del NIF (el último carácter)
                String letra = NIF.Substring(NIF.Length - 1, 1);
                //Obtenemos los números del NIF
                NIF = NIF.Substring(0, NIF.Length - 1);
                //Convertimos a número
                int nifNum = int.Parse(NIF);
                int resto = nifNum % 23;
                string letraResto = ObtenerLetra(resto);
                if (letraResto != letra.ToUpper())
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private static string ObtenerLetra(int numero)
        {
            Dictionary<int, String> letras = new Dictionary<int, string>();
            letras.Add(0, "T");
            letras.Add(1, "R");
            letras.Add(2, "W");
            letras.Add(3, "A");
            letras.Add(4, "G");
            letras.Add(5, "M");
            letras.Add(6, "Y");
            letras.Add(7, "F");
            letras.Add(8, "P");
            letras.Add(9, "D");
            letras.Add(10, "X");
            letras.Add(11, "B");
            letras.Add(12, "N");
            letras.Add(13, "J");
            letras.Add(14, "Z");
            letras.Add(15, "S");
            letras.Add(16, "Q");
            letras.Add(17, "V");
            letras.Add(18, "H");
            letras.Add(19, "L");
            letras.Add(20, "C");
            letras.Add(21, "K");
            letras.Add(22, "E");
            return letras[numero];
        }
    }
}

