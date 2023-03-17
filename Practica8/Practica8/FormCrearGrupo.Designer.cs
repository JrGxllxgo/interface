/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: José Ramón Gallego Vélez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 12 de Enero de 2023
*/

namespace Practica8
{
    partial class FormCrearGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearGrupo));
            this.txtNombreNuevoGrupo = new System.Windows.Forms.TextBox();
            this.lblNombreNuevoGrupo = new System.Windows.Forms.Label();
            this.btnCrearGrupo = new System.Windows.Forms.Button();
            this.lstAsignaturasCrearGrupo = new System.Windows.Forms.CheckedListBox();
            this.errorProviderCrearGrupo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCrearGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreNuevoGrupo
            // 
            this.txtNombreNuevoGrupo.Location = new System.Drawing.Point(86, 40);
            this.txtNombreNuevoGrupo.Name = "txtNombreNuevoGrupo";
            this.txtNombreNuevoGrupo.Size = new System.Drawing.Size(100, 23);
            this.txtNombreNuevoGrupo.TabIndex = 12;
            this.txtNombreNuevoGrupo.Leave += new System.EventHandler(this.txtNombreNuevoGrupo_Leave);
            // 
            // lblNombreNuevoGrupo
            // 
            this.lblNombreNuevoGrupo.AutoSize = true;
            this.lblNombreNuevoGrupo.Location = new System.Drawing.Point(29, 43);
            this.lblNombreNuevoGrupo.Name = "lblNombreNuevoGrupo";
            this.lblNombreNuevoGrupo.Size = new System.Drawing.Size(51, 15);
            this.lblNombreNuevoGrupo.TabIndex = 19;
            this.lblNombreNuevoGrupo.Text = "Nombre";
            // 
            // btnCrearGrupo
            // 
            this.btnCrearGrupo.Enabled = false;
            this.btnCrearGrupo.Location = new System.Drawing.Point(49, 85);
            this.btnCrearGrupo.Name = "btnCrearGrupo";
            this.btnCrearGrupo.Size = new System.Drawing.Size(105, 49);
            this.btnCrearGrupo.TabIndex = 14;
            this.btnCrearGrupo.Text = "Crear";
            this.btnCrearGrupo.UseVisualStyleBackColor = true;
            this.btnCrearGrupo.Click += new System.EventHandler(this.btnCrearGrupo_Click);
            // 
            // lstAsignaturasCrearGrupo
            // 
            this.lstAsignaturasCrearGrupo.FormattingEnabled = true;
            this.lstAsignaturasCrearGrupo.Items.AddRange(new object[] {
            "LEMA",
            "PRO",
            "ENDE",
            "FOL",
            "SIGE",
            "DI"});
            this.lstAsignaturasCrearGrupo.Location = new System.Drawing.Point(224, 40);
            this.lstAsignaturasCrearGrupo.Name = "lstAsignaturasCrearGrupo";
            this.lstAsignaturasCrearGrupo.Size = new System.Drawing.Size(105, 94);
            this.lstAsignaturasCrearGrupo.TabIndex = 13;
            // 
            // errorProviderCrearGrupo
            // 
            this.errorProviderCrearGrupo.ContainerControl = this;
            // 
            // FormCrearGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 167);
            this.Controls.Add(this.lstAsignaturasCrearGrupo);
            this.Controls.Add(this.txtNombreNuevoGrupo);
            this.Controls.Add(this.lblNombreNuevoGrupo);
            this.Controls.Add(this.btnCrearGrupo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCrearGrupo";
            this.RightToLeftLayout = true;
            this.Text = "Datos del grupo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCrearGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNombreNuevoGrupo;
        private Label lblNombreNuevoGrupo;
        private Button btnCrearGrupo;
        private CheckedListBox lstAsignaturasCrearGrupo;
        private ErrorProvider errorProviderCrearGrupo;
    }
}