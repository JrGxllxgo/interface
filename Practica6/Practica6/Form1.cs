using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Practica6
{
    public partial class frmHojaSalarial : Form
    {
        #region atributos
        private bool nif, nombre = false;
        private int categoria, numHijos, numTrienios, salarioBase, numHrs, porIrpf;
        #endregion

        public frmHojaSalarial()
        {
            InitializeComponent();
            maskTxtBNIF.Mask = "00000000L";
            maskTxtBNombre.Mask = "?????????????";
            btnCalc.Enabled = false;

            errorNif = new ErrorProvider();

            errorNombre = new ErrorProvider();
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
            categoria = (int)numUpDownCat.Value;
            numHijos = (int)numUpDownHijos.Value;
            numTrienios = (int)numUpDownTrien.Value;
            numHrs = (int)numUpDownHrs.Value;
            setPorcIrpf();
            calcNom();
        }

        private void maskTxtBNIF_Leave(object sender, EventArgs e)
        {
            if (ValidarNIF(maskTxtBNIF.Text))
            {
                nif = true;
                errorNif.Clear();
            }
            else
            {
                errorNif.SetError(this.maskTxtBNIF, "El nif es incorrecto");
                nif = false;
            }
            activateCalc();
        }

        private void maskTxtBNombre_Leave(object sender, EventArgs e)
        {
            if (!maskTxtBNombre.Text.Equals(""))
            {
                nombre = true;
                errorNombre.Clear();
            }
            else
            {
                errorNombre.SetError(maskTxtBNombre, "El nombre no puede estar vacío");
                nombre = false;
            }

            activateCalc();
        }

        private void activateCalc()
        {
            if (nif && nombre)
            {
                btnCalc.Enabled = true;
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

        private void setPorcIrpf()
        {
            if(numUpDownCat.Value == 1)
            {
                porIrpf = (int)(18 - numUpDownHijos.Value);
            }
            else if (numUpDownCat.Value == 2)
            {
                porIrpf = (int)(15 - numUpDownHijos.Value);
            }
            else
            {
                porIrpf = (int)(12 - numUpDownHijos.Value);
            }
        }

        private void calcNom()
        {
            txtBSB.Text = Convert.ToString(SetSalarioBase());
            txtBAnt.Text = Convert.ToString(ImporteAntiguedad());
            txtBHrs.Text = Convert.ToString(ImporteHrsExtra());
            txtBPE.Text = Convert.ToString(ImportePagExtra());
            txtBTotDev.Text = Convert.ToString(TotalDevengos());
            txtBCotSegSoc.Text = Convert.ToString(ImporteCotSegSoc());
            txtBCotSegDes.Text = Convert.ToString(ImporteCotSegDes());
            txtBRetIRPF.Text = Convert.ToString(RetIRPF());
            txtBTotDes.Text = Convert.ToString(TotalDescuentos());
            txtBLiq.Text = Convert.ToString(LiquidoAPercibir());
        }

        public int SetSalarioBase()
        {
            if (numUpDownCat.Value == 1)
            {
                salarioBase = 2500;
            }
            else if (numUpDownCat.Value == 2)
            {
                salarioBase = 2000;
            }
            else
            {
                salarioBase = 1000;
            }

            return salarioBase;
        }

        public double ImporteAntiguedad()
        {
            return (numTrienios * salarioBase * 4) / 100;
        }

        public double ImporteHrsExtra()
        {
            return numHrs * salarioBase * 1 / 100;
        }

        public double ImportePagExtra()
        {
            return salarioBase + ImporteAntiguedad();
        }

        public double TotalDevengos()
        {
            return salarioBase + ImporteAntiguedad() + ImporteHrsExtra() + ImportePagExtra();
        }

        public double ImporteCotSegSoc()
        {
            return TotalDevengos() * 1.97 / 100;
        }

        public double ImporteCotSegDes()
        {
            return (ImportePagExtra() / 3) * 4.51 / 100;
        }

        public double RetIRPF()
        {
            double ret;
            if (datePck.Value.Month == 12 || datePck.Value.Month == 6)
            {
                ret = TotalDevengos() + ImportePagExtra() * porIrpf / 100;
            }
            else
            {
                ret = TotalDevengos() * porIrpf / 100;
            }

            return ret;
        }

        public double LiquidoAPercibir()
        {
            double liq;
            if (datePck.Value.Month == 12 || datePck.Value.Month == 6)
            {
                liq = TotalDevengos() + ImportePagExtra() - TotalDescuentos();
            }
            else
            {
                liq = TotalDevengos() - TotalDescuentos();
            }

            return liq;
        }

        private double TotalDescuentos()
        {
            return ImporteCotSegDes() + RetIRPF() + ImporteCotSegSoc();
        }
    }
}

