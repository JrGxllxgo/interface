/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 20 de Enero de 2023
*/

using System.Text.RegularExpressions;

namespace Practica8
{
    partial class FormDatosAlumno : Form
    {
        #region Campos

        GroupBox grpNotas;
        TextBox[] txtNotas;
        string notasPattern = @"^[0-9,]+$";
        string nombrePattern = @"^[A-Za-z]+$";
        Alumno alumnoSel;
        #endregion

        #region Propiedades
        public Alumno AlumnoSel { get { return alumnoSel; } set { alumnoSel = value; } }

        #endregion

        public FormDatosAlumno()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            this.CenterToParent();

            grpNotas = new GroupBox();
            txtNotas = new TextBox[FormMain.grupoSel.CodigosAsignaturas.Length];

            crearTextBoxNotas(10, 40, 40);
        }

        public FormDatosAlumno(Alumno alumnoSel)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            this.CenterToParent();

            this.AlumnoSel = alumnoSel;

            grpNotas = new GroupBox();
            
            if(AlumnoSel == null)
            {
                MessageBox.Show("Error en el alumno seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtNotas = new TextBox[alumnoSel.Notas.Length];

                crearTextBoxNotasEditar(10, 40, 40);

                txtNombreAlumnoNuevo.Text = alumnoSel.Nombre;
            }

        }

        private void crearTextBoxNotasEditar(int posicionX, int anchuraLbl, int anchuraTxt)
        {
            for (int i = 0; i < alumnoSel.Notas.Length; i++)
            {
                Label lblNota = new Label();

                lblNota.Text = FormMain.grupoSel.CodigosAsignaturas[i];
                lblNota.Location = new Point(posicionX, 30);
                lblNota.Size = new Size(anchuraLbl, 15);

                posicionX += anchuraLbl + 5;

                grpNotas.Controls.Add(lblNota);

                TextBox txtNota = new TextBox();

                txtNota.Text = Convert.ToString(alumnoSel.Notas[i]);
                txtNota.Location = new Point(posicionX, 25);
                txtNota.Size = new Size(anchuraTxt, 15);
                txtNota.TextChanged += new EventHandler(txtBoxSoloDoubles);

                txtNotas[i] = txtNota;

                posicionX += anchuraTxt + 20;

                grpNotas.Controls.Add(txtNotas[i]);
            }
            grpNotas.Location = new Point(42, 100);
            grpNotas.Size = new Size(FormMain.grupoSel.CodigosAsignaturas.Length * anchuraTxt * 2 + 25 * FormMain.grupoSel.CodigosAsignaturas.Length, 70);
            grpNotas.Text = "Notas";
            this.Controls.Add(grpNotas);
        }

        private void crearTextBoxNotas(int posicionX, int anchuraLbl, int anchuraTxt)
        {
            for (int i = 0; i < FormMain.grupoSel.CodigosAsignaturas.Length; i++)
            {
                Label lblNota = new Label();

                lblNota.Text = FormMain.grupoSel.CodigosAsignaturas[i];
                lblNota.Location = new Point(posicionX, 30);
                lblNota.Size = new Size(anchuraLbl, 15);

                posicionX += anchuraLbl + 5;

                grpNotas.Controls.Add(lblNota);

                TextBox txtNota = new TextBox();

                txtNota.Location = new Point(posicionX, 25);
                txtNota.Size = new Size(anchuraTxt, 15);
                txtNota.TextChanged += new EventHandler(txtBoxSoloDoubles);
                txtNota.TabIndex = i + 2;

                txtNotas[i] = txtNota;

                posicionX += anchuraTxt + 20;

                grpNotas.Controls.Add(txtNotas[i]);
            }
            grpNotas.Location = new Point(42, 100);

            int grpNotasAnchura = FormMain.grupoSel.CodigosAsignaturas.Length * anchuraTxt * 2 + 25 * FormMain.grupoSel.CodigosAsignaturas.Length;
            grpNotas.Size = new Size(grpNotasAnchura, 70);

            grpNotas.Text = "Notas";
            grpNotas.TabIndex = 1;
            this.Controls.Add(grpNotas);

            this.Width = grpNotasAnchura + 100;
        }

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {

            double[] notas = new double[FormMain.grupoSel.CodigosAsignaturas.Length];

            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = Convert.ToDouble(txtNotas[i].Text);
            }

            if (alumnoSel != null)
            {
                FormMain.grupoSel.buscarAlumno(alumnoSel.Matricula).Nombre = txtNombreAlumnoNuevo.Text;
                FormMain.grupoSel.buscarAlumno(alumnoSel.Matricula).Notas = notas;
            }
            else
            {
                FormMain.grupoSel.anadirAlumno(new Alumno(txtNombreAlumnoNuevo.Text, notas));
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtBoxSoloDoubles(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (contarCaracter(textBox.Text, ',') > 1 || !Regex.IsMatch(textBox.Text, notasPattern))
            {
                errorProvider.SetError(textBox, "Debe introducir un número (si es decimal, debe estar separado por una ',')");
            }
            else
            {
                if (Convert.ToDouble(textBox.Text) > 10)
                {
                    errorProvider.SetError(textBox, "Debe introducir una nota entre 0 y 10");

                }
                else
                {
                    errorProvider.SetError(textBox, "");
                }
            }
            habilitarBoton();
        }

        private void txtBoxNombreAlumnoVacio(object sender, EventArgs e)
        {
            if (txtNombreAlumnoNuevo.Text.Trim().Equals(""))
            {
                errorProvider.SetError(txtNombreAlumnoNuevo, "El nombre no puede contener carácteres espciales ni estar vacío");
            }
            else
            {
                errorProvider.SetError(txtNombreAlumnoNuevo, "");
                btnCrearAlumno.Enabled = false;
            }
            habilitarBoton();
        }

        private int contarCaracter(string cadena, char caracter)
        {
            int veces = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == caracter)
                {
                    veces++;
                }
            }
            return veces;
        }

        private bool comprobarErrores()
        {
            int contador = 0;
            bool error = false;

            while (contador < txtNotas.Length && !error)
            {
                //Comprobamos si hay algún error en algún control y si encontramos uno, paramos de buscar
                if (txtNotas[contador].Text == "")
                {
                    error = true;
                }
                contador++;
            }

            if (!error)
            {
                if (errorProvider.GetError(txtNombreAlumnoNuevo) != "")
                {
                    error = true;
                }
                else
                {
                    contador = 0;
                    while (contador < txtNotas.Length && !error)
                    {
                        //Comprobamos si hay algún error en algún control y si encontramos uno, paramos de buscar
                        if (errorProvider.GetError(txtNotas[contador]) != "")
                        {
                            error = true;
                        }
                        contador++;
                    }
                }
            }
            return error;
        }

        private void habilitarBoton()
        {
            if (comprobarErrores())
            {
                btnCrearAlumno.Enabled = false;
            }
            else
            {
                btnCrearAlumno.Enabled = true;
            }
        }

    }
}
