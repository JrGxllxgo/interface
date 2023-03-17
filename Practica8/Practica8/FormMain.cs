/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 20 de Enero de 2023
*/

using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace Practica8
{
    partial class FormMain : Form
    {
        public List<Grupo> grupos;

        public static Grupo grupoSel;
        public FormMain()
        {
            InitializeComponent();

            grupos = new List<Grupo>();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.CenterToScreen();


            crearColumnasGrupo();
        }

        public void crearColumnasGrupo()
        {
            //Defino el objeto del que quiero crear las columnas
            Type tipo = typeof(Grupo);

            // Obtener las propiedades del tipo
            PropertyInfo[] properties = tipo.GetProperties();

            DataGridViewColumn column = new DataGridViewColumn();
            column.Name = properties[0].Name;
            column.HeaderText = properties[0].Name;
            column.ValueType = tipo;
            column.CellTemplate = new DataGridViewTextBoxCell();

            dtgvGrupos.Columns.Add(column);

            // Recorrer las propiedades
            for (int i = 1; i < properties.Length - 1; i++)
            {
                column = new DataGridViewColumn();
                column.Name = properties[i].Name;
                column.HeaderText = properties[i].Name;
                column.ValueType = properties[i].PropertyType;
                column.CellTemplate = new DataGridViewTextBoxCell();

                // Agregar la columna al DataGridView
                dtgvGrupos.Columns.Add(column);
            }
        }

        public void crearColumnasAlumno()
        {
            dtgvAlumnos.Columns.Clear();
            //Defino el objeto del que quiero crear las columnas
            Type tipo = typeof(Alumno);
            // Obtener las propiedades del tipo
            PropertyInfo[] properties = tipo.GetProperties();

            DataGridViewColumn column = new DataGridViewColumn();
            column.Name = properties[0].Name;
            column.HeaderText = properties[0].Name;
            column.ValueType = tipo;
            column.CellTemplate = new DataGridViewTextBoxCell();

            dtgvAlumnos.Columns.Add(column);

            // Recorrer las propiedades
            for (int i = 1; i < properties.Length; i++)
            {
                if (properties[i].PropertyType.Name.Contains("[]"))
                {

                    for (int j = 0; j < grupoSel.CodigosAsignaturas.Length; j++)
                    {
                        column = new DataGridViewColumn();
                        column.Name = grupoSel.CodigosAsignaturas[j];
                        column.HeaderText = grupoSel.CodigosAsignaturas[j];
                        column.ValueType = typeof(double);
                        column.CellTemplate = new DataGridViewTextBoxCell();

                        dtgvAlumnos.Columns.Add(column);
                    }
                }
                else
                {
                    column = new DataGridViewColumn();
                    column.Name = properties[i].Name;
                    column.HeaderText = properties[i].Name;
                    column.ValueType = properties[i].PropertyType;
                    column.CellTemplate = new DataGridViewTextBoxCell();

                    // Agregar la columna al DataGridView
                    dtgvAlumnos.Columns.Add(column);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormCrearGrupo formCrearGrupo = new FormCrearGrupo();

            if (formCrearGrupo.ShowDialog() == DialogResult.OK)
            {
                Grupo grupoAgregado = formCrearGrupo.Grupo;
                insertarRegistro(grupoAgregado);

                grupoSel = grupoAgregado;
                crearColumnasAlumno();
                actualizarAlumnos(grupoSel.Alumnos);
            }
        }

        private void btnBorrarGrupo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas borrar el grupo " + grupoSel.Nombre + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                grupos.Remove(grupoSel);
                MessageBox.Show("Se ha borrado correctamente el grupo " + grupoSel.Nombre, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarGrupos();
            }
            else
            {
                MessageBox.Show("No se ha borrado al alumno " + grupoSel.Nombre, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Filter = "Archivos GRU (*.gru)|*.gru";
                ofd.FilterIndex = 1;
                ofd.Multiselect = false;
                ofd.RestoreDirectory = true;
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream ficheroLeer = new FileStream(ofd.FileName, FileMode.Open);

                    BinaryFormatter formatter = new BinaryFormatter();

                    Grupo grupoImportado = (Grupo)formatter.Deserialize(ficheroLeer);

                    bool repetido = false;

                    for (int i = 0; i < grupos.Count; i++)
                    {
                        if (grupos[i].Nombre.Equals(grupoImportado.Nombre))
                        {
                            repetido = true;
                        }
                    }

                    if (repetido)
                    {
                        MessageBox.Show("El grupo a importar ya existe", "Error al importar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        insertarRegistro(grupoImportado);
                        MessageBox.Show("Se ha importado correctamente el grupo", "Grupo creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ficheroLeer.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en los archivos", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Archivos GRU (*.gru)|*.gru";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            sfd.FileName = grupoSel.Nombre;
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Serialize the object to the specified file
                using (FileStream ficheroGuardar = new FileStream(sfd.FileName, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(ficheroGuardar, grupoSel);
                }
                MessageBox.Show("Se ha exportado correctamente el grupo " + grupoSel.Nombre, "Grupo importado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            FormDatosAlumno formCrearAlumno = new FormDatosAlumno();
            if (formCrearAlumno.ShowDialog() == DialogResult.OK)
            {
                insertarRegistro(grupoSel.Alumnos[grupoSel.Alumnos.Count - 1]);
            }
        }

        private void btnBorrarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumnoSel = (Alumno)dtgvAlumnos.SelectedRows[0].Cells[1].Value;
                if(alumnoSel != null)
                {

                    if (MessageBox.Show("¿Deseas borrar al alumno " + alumnoSel.Nombre + " con matrícula " + alumnoSel.Matricula + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        grupoSel.borrarAlumno(alumnoSel.Matricula);
                        MessageBox.Show("Se ha borrado correctamente al alumno " + alumnoSel.Nombre + " con matrícula " + alumnoSel.Matricula, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizarAlumnos(grupoSel.Alumnos);
                    }
                    else
                    {
                        MessageBox.Show("No se ha borrado al alumno " + alumnoSel.Nombre + " con matrícula " + alumnoSel.Matricula, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Error al borrar el alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Error al borrar el alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEditarAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumnoSel = (Alumno)dtgvAlumnos.SelectedRows[0].Cells[1].Value;
            if(alumnoSel != null)
            {
                FormDatosAlumno formCrearAlumno = new FormDatosAlumno(alumnoSel);
                formCrearAlumno.ShowDialog();
                actualizarAlumnos(grupoSel.Alumnos);
            }
            else
            {
                MessageBox.Show("Error en el alumno seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrarAlumno_Click(object sender, EventArgs e)
        {
            if (btnFiltrarAlumnos.Text != "Quitar filtro")
            {
                List<Alumno> alumnosAprobados = new List<Alumno>();
                for (int i = 0; i < grupoSel.Alumnos.Count; i++)
                {
                    bool aprobado = true;
                    for (int j = 0; j < grupoSel.Alumnos[i].Notas.Length; j++)
                    {
                        if (grupoSel.Alumnos[i].Notas[j] < 5)
                        {
                            aprobado = false;
                        }
                    }
                    if (aprobado)
                    {
                        alumnosAprobados.Add(grupoSel.Alumnos[i]);
                    }
                }
                actualizarAlumnos(alumnosAprobados);
                btnFiltrarAlumnos.Text = "Quitar filtro";
            }
            else
            {
                actualizarAlumnos(grupoSel.Alumnos);
                btnFiltrarAlumnos.Text = "Filtrar aprobados";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void insertarRegistro(Grupo grupo)
        {
            // Obtener las propiedades del objeto
            PropertyInfo[] properties = grupo.GetType().GetProperties();

            // Crear una nueva fila
            int rowIndex = dtgvGrupos.Rows.Add();
            DataGridViewRow row = dtgvGrupos.Rows[rowIndex];

            row.Cells[0].Value = grupo;

            // Recorrer las propiedades
            for (int i = 1; i < properties.Length; i++)
            {
                if (properties[i].PropertyType.Name.Contains("[]"))
                {
                    string[] asignaturas = (string[])properties[i].GetValue(grupo);

                    row.Cells[i].Value = string.Join(",", asignaturas);
                }
                else if (!properties[i].PropertyType.Name.Contains("List"))
                {
                    row.Cells[i].Value = properties[i].GetValue(grupo);
                }
                dtgvGrupos.CurrentCell = row.Cells[0];
                btnAgregarAlumno.Enabled = true;
                btnExportar.Enabled = true;
                btnBorrarGrupo.Enabled = true;
                row.Selected = true;
            }

            grupos.Add(grupo);
        }

        public void insertarRegistro(Alumno alumno)
        {
            // Obtener las propiedades del objeto
            PropertyInfo[] properties = alumno.GetType().GetProperties();

            // Crear una nueva fila
            int rowIndex = dtgvAlumnos.Rows.Add();
            DataGridViewRow row = dtgvAlumnos.Rows[rowIndex];

            int numCelda = 0;

            // Recorrer las propiedades
            for (int i = 0; i < properties.Length; i++)
            {
                if (numCelda == 1)
                {
                    row.Cells[numCelda].Value = alumno;
                    numCelda++;
                }
                else
                {
                    if (properties[i].PropertyType.Name.Contains("[]"))
                    {
                        double[] notas = (double[])properties[i].GetValue(alumno);

                        for (int j = 0; j < notas.Length; j++)
                        {
                            row.Cells[numCelda].Value = notas[j];

                            numCelda++;
                        }
                    }
                    else
                    {
                        row.Cells[numCelda].Value = properties[i].GetValue(alumno);
                        numCelda++;
                    }
                }
            }
            dtgvAlumnos.CurrentCell = row.Cells[0];
            btnBorrarAlumno.Enabled = true;
            btnEditarAlumno.Enabled = true;
            btnFiltrarAlumnos.Enabled = true;
            row.Selected = true;
        }

        private void actualizarAlumnos(List<Alumno> alumnos)
        {
            dtgvAlumnos.Rows.Clear();
            for (int i = 0; i < alumnos.Count; i++)
            {
                insertarRegistro(alumnos[i]);
            }
        }
        private void actualizarGrupos()
        {
            dtgvGrupos.Rows.Clear();
            for (int i = 0; i < grupos.Count; i++)
            {
                insertarRegistro(grupos[i]);
            }
            dtgvAlumnos.Rows.Clear();
            dtgvAlumnos.Columns.Clear();
        }
        private void dtgvGrupos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSel = dtgvGrupos.Rows[e.RowIndex];
            if (filaSel != null)
            {
                grupoSel = (Grupo)filaSel.Cells[0].Value;
                if (grupoSel != null)
                {
                    crearColumnasAlumno();
                    actualizarAlumnos(grupoSel.Alumnos);
                }
            }
        }

        private void dtgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvAlumnos.Rows[e.RowIndex].Selected = true;
        }

        private void dtgvGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvGrupos.Rows[e.RowIndex].Selected = true;
        }

        private void acercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa hecho por José Ramón Gallego Vélezz\n" +
                "Versión 3.0.0", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}