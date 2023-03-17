/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 12 de Enero de 2023
*/

namespace Practica8
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtgvGrupos = new System.Windows.Forms.DataGridView();
            this.dtgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.btnBorrarAlumno = new System.Windows.Forms.Button();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnEditarAlumno = new System.Windows.Forms.Button();
            this.btnFiltrarAlumnos = new System.Windows.Forms.Button();
            this.btnBorrarGrupo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumnos)).BeginInit();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(177, 275);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(105, 49);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(177, 330);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(105, 49);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(46, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(223, 36);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Gestor de grupos";
            // 
            // dtgvGrupos
            // 
            this.dtgvGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGrupos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGrupos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvGrupos.Location = new System.Drawing.Point(45, 71);
            this.dtgvGrupos.MultiSelect = false;
            this.dtgvGrupos.Name = "dtgvGrupos";
            this.dtgvGrupos.RowTemplate.Height = 25;
            this.dtgvGrupos.Size = new System.Drawing.Size(281, 198);
            this.dtgvGrupos.TabIndex = 4;
            this.dtgvGrupos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGrupos_CellClick);
            this.dtgvGrupos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGrupos_RowEnter);
            // 
            // dtgvAlumnos
            // 
            this.dtgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAlumnos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvAlumnos.Location = new System.Drawing.Point(366, 71);
            this.dtgvAlumnos.Name = "dtgvAlumnos";
            this.dtgvAlumnos.RowTemplate.Height = 25;
            this.dtgvAlumnos.Size = new System.Drawing.Size(404, 198);
            this.dtgvAlumnos.TabIndex = 5;
            this.dtgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAlumnos_CellClick);
            this.dtgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAlumnos_CellContentClick);
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Enabled = false;
            this.btnAgregarAlumno.Location = new System.Drawing.Point(590, 275);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(105, 49);
            this.btnAgregarAlumno.TabIndex = 6;
            this.btnAgregarAlumno.Text = "Agregar alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // btnBorrarAlumno
            // 
            this.btnBorrarAlumno.Enabled = false;
            this.btnBorrarAlumno.Location = new System.Drawing.Point(479, 275);
            this.btnBorrarAlumno.Name = "btnBorrarAlumno";
            this.btnBorrarAlumno.Size = new System.Drawing.Size(105, 49);
            this.btnBorrarAlumno.TabIndex = 7;
            this.btnBorrarAlumno.Text = "Borrar Alumno";
            this.btnBorrarAlumno.UseVisualStyleBackColor = true;
            this.btnBorrarAlumno.Click += new System.EventHandler(this.btnBorrarAlumno_Click);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(817, 24);
            this.menuPrincipal.TabIndex = 32;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercadeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // acercadeToolStripMenuItem
            // 
            this.acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            this.acercadeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercadeToolStripMenuItem.Text = "&Acerca de...";
            this.acercadeToolStripMenuItem.Click += new System.EventHandler(this.acercadeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(366, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 36);
            this.label1.TabIndex = 33;
            this.label1.Text = "Lista de alumnos";
            // 
            // btnExportar
            // 
            this.btnExportar.Enabled = false;
            this.btnExportar.Location = new System.Drawing.Point(45, 275);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(105, 49);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnEditarAlumno
            // 
            this.btnEditarAlumno.Enabled = false;
            this.btnEditarAlumno.Location = new System.Drawing.Point(366, 275);
            this.btnEditarAlumno.Name = "btnEditarAlumno";
            this.btnEditarAlumno.Size = new System.Drawing.Size(105, 49);
            this.btnEditarAlumno.TabIndex = 8;
            this.btnEditarAlumno.Text = "Editar Alumno";
            this.btnEditarAlumno.UseVisualStyleBackColor = true;
            this.btnEditarAlumno.Click += new System.EventHandler(this.btnEditarAlumno_Click);
            // 
            // btnFiltrarAlumnos
            // 
            this.btnFiltrarAlumnos.Enabled = false;
            this.btnFiltrarAlumnos.Location = new System.Drawing.Point(665, 41);
            this.btnFiltrarAlumnos.Name = "btnFiltrarAlumnos";
            this.btnFiltrarAlumnos.Size = new System.Drawing.Size(105, 27);
            this.btnFiltrarAlumnos.TabIndex = 9;
            this.btnFiltrarAlumnos.Text = "Filtrar aprobados";
            this.btnFiltrarAlumnos.UseVisualStyleBackColor = true;
            this.btnFiltrarAlumnos.Click += new System.EventHandler(this.btnFiltrarAlumno_Click);
            // 
            // btnBorrarGrupo
            // 
            this.btnBorrarGrupo.Enabled = false;
            this.btnBorrarGrupo.Location = new System.Drawing.Point(46, 330);
            this.btnBorrarGrupo.Name = "btnBorrarGrupo";
            this.btnBorrarGrupo.Size = new System.Drawing.Size(105, 49);
            this.btnBorrarGrupo.TabIndex = 2;
            this.btnBorrarGrupo.Text = "Borrar";
            this.btnBorrarGrupo.UseVisualStyleBackColor = true;
            this.btnBorrarGrupo.Click += new System.EventHandler(this.btnBorrarGrupo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(817, 399);
            this.Controls.Add(this.btnBorrarGrupo);
            this.Controls.Add(this.btnFiltrarAlumnos);
            this.Controls.Add(this.btnEditarAlumno);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrarAlumno);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.dtgvAlumnos);
            this.Controls.Add(this.dtgvGrupos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Gestión de grupos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumnos)).EndInit();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnImportar;
        private Button btnNuevo;
        private Label lblTitulo;
        private DataGridView dtgvGrupos;
        private DataGridView dtgvAlumnos;
        private Button btnAgregarAlumno;
        private Button btnBorrarAlumno;
        private MenuStrip menuPrincipal;
        private Label label1;
        private Button btnExportar;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercadeToolStripMenuItem;
        private Button btnEditarAlumno;
        private Button btnFiltrarAlumnos;
        private Button btnBorrarGrupo;
    }
}