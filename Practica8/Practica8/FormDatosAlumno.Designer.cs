/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 12 de Enero de 2023
*/

namespace Practica8
{
    partial class FormDatosAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosAlumno));
            this.txtNombreAlumnoNuevo = new System.Windows.Forms.TextBox();
            this.lblNombreAlumnoNuevo = new System.Windows.Forms.Label();
            this.btnCrearAlumno = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreAlumnoNuevo
            // 
            this.txtNombreAlumnoNuevo.Location = new System.Drawing.Point(99, 43);
            this.txtNombreAlumnoNuevo.Name = "txtNombreAlumnoNuevo";
            this.txtNombreAlumnoNuevo.Size = new System.Drawing.Size(100, 23);
            this.txtNombreAlumnoNuevo.TabIndex = 0;
            this.txtNombreAlumnoNuevo.TextChanged += new System.EventHandler(this.txtBoxNombreAlumnoVacio);
            // 
            // lblNombreAlumnoNuevo
            // 
            this.lblNombreAlumnoNuevo.AutoSize = true;
            this.lblNombreAlumnoNuevo.Location = new System.Drawing.Point(42, 46);
            this.lblNombreAlumnoNuevo.Name = "lblNombreAlumnoNuevo";
            this.lblNombreAlumnoNuevo.Size = new System.Drawing.Size(51, 15);
            this.lblNombreAlumnoNuevo.TabIndex = 1;
            this.lblNombreAlumnoNuevo.Text = "Nombre";
            // 
            // btnCrearAlumno
            // 
            this.btnCrearAlumno.Enabled = false;
            this.btnCrearAlumno.Location = new System.Drawing.Point(251, 30);
            this.btnCrearAlumno.Name = "btnCrearAlumno";
            this.btnCrearAlumno.Size = new System.Drawing.Size(109, 46);
            this.btnCrearAlumno.TabIndex = 10;
            this.btnCrearAlumno.Text = "Guardar";
            this.btnCrearAlumno.UseVisualStyleBackColor = true;
            this.btnCrearAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormDatosAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 261);
            this.Controls.Add(this.btnCrearAlumno);
            this.Controls.Add(this.lblNombreAlumnoNuevo);
            this.Controls.Add(this.txtNombreAlumnoNuevo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDatosAlumno";
            this.Text = "Datos del alumno";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNombreAlumnoNuevo;
        private Label lblNombreAlumnoNuevo;
        private Button btnCrearAlumno;
        private ErrorProvider errorProvider;
    }
}