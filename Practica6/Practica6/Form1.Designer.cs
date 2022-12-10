namespace Practica6
{
    partial class frmHojaSalarial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHojaSalarial));
            this.grBData = new System.Windows.Forms.GroupBox();
            this.numUpDownCat = new System.Windows.Forms.NumericUpDown();
            this.numUpDownHrs = new System.Windows.Forms.NumericUpDown();
            this.numUpDownTrien = new System.Windows.Forms.NumericUpDown();
            this.numUpDownHijos = new System.Windows.Forms.NumericUpDown();
            this.maskTxtBNombre = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtBNIF = new System.Windows.Forms.MaskedTextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.datePck = new System.Windows.Forms.DateTimePicker();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblTrn = new System.Windows.Forms.Label();
            this.lblHijos = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.grBResult = new System.Windows.Forms.GroupBox();
            this.txtBLiq = new System.Windows.Forms.TextBox();
            this.lblLiq = new System.Windows.Forms.Label();
            this.txtBTotDes = new System.Windows.Forms.TextBox();
            this.lblTotDes = new System.Windows.Forms.Label();
            this.txtBTotDev = new System.Windows.Forms.TextBox();
            this.lblTotDev = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.txtBRetIRPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBCotSegDes = new System.Windows.Forms.TextBox();
            this.lblCotSegDes = new System.Windows.Forms.Label();
            this.txtBCotSegSoc = new System.Windows.Forms.TextBox();
            this.lblCotSegSoc = new System.Windows.Forms.Label();
            this.txtBPE = new System.Windows.Forms.TextBox();
            this.lblPE = new System.Windows.Forms.Label();
            this.txtBHrs = new System.Windows.Forms.TextBox();
            this.lblHE = new System.Windows.Forms.Label();
            this.txtBAnt = new System.Windows.Forms.TextBox();
            this.lblAnt = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtBSB = new System.Windows.Forms.TextBox();
            this.lblSB = new System.Windows.Forms.Label();
            this.errorNif = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.grBData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTrien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHijos)).BeginInit();
            this.grBResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // grBData
            // 
            this.grBData.Controls.Add(this.numUpDownCat);
            this.grBData.Controls.Add(this.numUpDownHrs);
            this.grBData.Controls.Add(this.numUpDownTrien);
            this.grBData.Controls.Add(this.numUpDownHijos);
            this.grBData.Controls.Add(this.maskTxtBNombre);
            this.grBData.Controls.Add(this.maskTxtBNIF);
            this.grBData.Controls.Add(this.btnCalc);
            this.grBData.Controls.Add(this.lblDate);
            this.grBData.Controls.Add(this.datePck);
            this.grBData.Controls.Add(this.lblHours);
            this.grBData.Controls.Add(this.lblTrn);
            this.grBData.Controls.Add(this.lblHijos);
            this.grBData.Controls.Add(this.lblCat);
            this.grBData.Controls.Add(this.lblName);
            this.grBData.Controls.Add(this.lblNif);
            this.grBData.Location = new System.Drawing.Point(40, 12);
            this.grBData.Name = "grBData";
            this.grBData.Size = new System.Drawing.Size(721, 249);
            this.grBData.TabIndex = 0;
            this.grBData.TabStop = false;
            this.grBData.Text = "Introducción de datos";
            // 
            // numUpDownCat
            // 
            this.numUpDownCat.Location = new System.Drawing.Point(70, 121);
            this.numUpDownCat.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numUpDownCat.Name = "numUpDownCat";
            this.numUpDownCat.Size = new System.Drawing.Size(33, 20);
            this.numUpDownCat.TabIndex = 23;
            // 
            // numUpDownHrs
            // 
            this.numUpDownHrs.Location = new System.Drawing.Point(481, 121);
            this.numUpDownHrs.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUpDownHrs.Name = "numUpDownHrs";
            this.numUpDownHrs.Size = new System.Drawing.Size(33, 20);
            this.numUpDownHrs.TabIndex = 22;
            // 
            // numUpDownTrien
            // 
            this.numUpDownTrien.Location = new System.Drawing.Point(314, 126);
            this.numUpDownTrien.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownTrien.Name = "numUpDownTrien";
            this.numUpDownTrien.Size = new System.Drawing.Size(33, 20);
            this.numUpDownTrien.TabIndex = 21;
            // 
            // numUpDownHijos
            // 
            this.numUpDownHijos.Location = new System.Drawing.Point(176, 121);
            this.numUpDownHijos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownHijos.Name = "numUpDownHijos";
            this.numUpDownHijos.Size = new System.Drawing.Size(33, 20);
            this.numUpDownHijos.TabIndex = 20;
            // 
            // maskTxtBNombre
            // 
            this.maskTxtBNombre.Location = new System.Drawing.Point(67, 72);
            this.maskTxtBNombre.Name = "maskTxtBNombre";
            this.maskTxtBNombre.Size = new System.Drawing.Size(89, 20);
            this.maskTxtBNombre.TabIndex = 19;
            this.maskTxtBNombre.Leave += new System.EventHandler(this.maskTxtBNombre_Leave);
            // 
            // maskTxtBNIF
            // 
            this.maskTxtBNIF.Location = new System.Drawing.Point(70, 34);
            this.maskTxtBNIF.Mask = "mas";
            this.maskTxtBNIF.Name = "maskTxtBNIF";
            this.maskTxtBNIF.Size = new System.Drawing.Size(86, 20);
            this.maskTxtBNIF.TabIndex = 18;
            this.maskTxtBNIF.Leave += new System.EventHandler(this.maskTxtBNIF_Leave);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(578, 188);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(117, 41);
            this.btnCalc.TabIndex = 16;
            this.btnCalc.Text = "CALCULAR";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(14, 178);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 13);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Periodo Liquidación";
            // 
            // datePck
            // 
            this.datePck.CustomFormat = "MM - yyyy";
            this.datePck.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePck.Location = new System.Drawing.Point(117, 172);
            this.datePck.MaxDate = new System.DateTime(2022, 12, 2, 0, 0, 0, 0);
            this.datePck.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.datePck.Name = "datePck";
            this.datePck.Size = new System.Drawing.Size(102, 20);
            this.datePck.TabIndex = 14;
            this.datePck.Value = new System.DateTime(2022, 12, 2, 0, 0, 0, 0);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(398, 128);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(77, 13);
            this.lblHours.TabIndex = 12;
            this.lblHours.Text = "Nº Horas Extra";
            this.lblHours.UseWaitCursor = true;
            // 
            // lblTrn
            // 
            this.lblTrn.AutoSize = true;
            this.lblTrn.Location = new System.Drawing.Point(249, 128);
            this.lblTrn.Name = "lblTrn";
            this.lblTrn.Size = new System.Drawing.Size(59, 13);
            this.lblTrn.TabIndex = 10;
            this.lblTrn.Text = "Nº Trienios";
            // 
            // lblHijos
            // 
            this.lblHijos.AutoSize = true;
            this.lblHijos.Location = new System.Drawing.Point(125, 128);
            this.lblHijos.Name = "lblHijos";
            this.lblHijos.Size = new System.Drawing.Size(45, 13);
            this.lblHijos.TabIndex = 8;
            this.lblHijos.Text = "Nº Hijos";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(16, 128);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(54, 13);
            this.lblCat.TabIndex = 6;
            this.lblCat.Text = "Categoría";
            this.lblCat.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nombre";
            this.lblName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(30, 33);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(33, 13);
            this.lblNif.TabIndex = 0;
            this.lblNif.Text = "N.I.F.";
            // 
            // grBResult
            // 
            this.grBResult.Controls.Add(this.txtBLiq);
            this.grBResult.Controls.Add(this.lblLiq);
            this.grBResult.Controls.Add(this.txtBTotDes);
            this.grBResult.Controls.Add(this.lblTotDes);
            this.grBResult.Controls.Add(this.txtBTotDev);
            this.grBResult.Controls.Add(this.lblTotDev);
            this.grBResult.Controls.Add(this.btnMod);
            this.grBResult.Controls.Add(this.txtBRetIRPF);
            this.grBResult.Controls.Add(this.label1);
            this.grBResult.Controls.Add(this.txtBCotSegDes);
            this.grBResult.Controls.Add(this.lblCotSegDes);
            this.grBResult.Controls.Add(this.txtBCotSegSoc);
            this.grBResult.Controls.Add(this.lblCotSegSoc);
            this.grBResult.Controls.Add(this.txtBPE);
            this.grBResult.Controls.Add(this.lblPE);
            this.grBResult.Controls.Add(this.txtBHrs);
            this.grBResult.Controls.Add(this.lblHE);
            this.grBResult.Controls.Add(this.txtBAnt);
            this.grBResult.Controls.Add(this.lblAnt);
            this.grBResult.Controls.Add(this.btnSalir);
            this.grBResult.Controls.Add(this.txtBSB);
            this.grBResult.Controls.Add(this.lblSB);
            this.grBResult.Location = new System.Drawing.Point(40, 309);
            this.grBResult.Name = "grBResult";
            this.grBResult.Size = new System.Drawing.Size(721, 324);
            this.grBResult.TabIndex = 1;
            this.grBResult.TabStop = false;
            this.grBResult.Text = "Resultado";
            // 
            // txtBLiq
            // 
            this.txtBLiq.Location = new System.Drawing.Point(260, 288);
            this.txtBLiq.Name = "txtBLiq";
            this.txtBLiq.ReadOnly = true;
            this.txtBLiq.Size = new System.Drawing.Size(92, 20);
            this.txtBLiq.TabIndex = 35;
            // 
            // lblLiq
            // 
            this.lblLiq.AutoSize = true;
            this.lblLiq.Location = new System.Drawing.Point(175, 291);
            this.lblLiq.Name = "lblLiq";
            this.lblLiq.Size = new System.Drawing.Size(43, 13);
            this.lblLiq.TabIndex = 34;
            this.lblLiq.Text = "Líquido";
            // 
            // txtBTotDes
            // 
            this.txtBTotDes.Location = new System.Drawing.Point(375, 251);
            this.txtBTotDes.Name = "txtBTotDes";
            this.txtBTotDes.ReadOnly = true;
            this.txtBTotDes.Size = new System.Drawing.Size(92, 20);
            this.txtBTotDes.TabIndex = 33;
            // 
            // lblTotDes
            // 
            this.lblTotDes.AutoSize = true;
            this.lblTotDes.Location = new System.Drawing.Point(278, 254);
            this.lblTotDes.Name = "lblTotDes";
            this.lblTotDes.Size = new System.Drawing.Size(91, 13);
            this.lblTotDes.TabIndex = 32;
            this.lblTotDes.Text = "Total Descuentos";
            // 
            // txtBTotDev
            // 
            this.txtBTotDev.Location = new System.Drawing.Point(117, 251);
            this.txtBTotDev.Name = "txtBTotDev";
            this.txtBTotDev.ReadOnly = true;
            this.txtBTotDev.Size = new System.Drawing.Size(92, 20);
            this.txtBTotDev.TabIndex = 31;
            // 
            // lblTotDev
            // 
            this.lblTotDev.AutoSize = true;
            this.lblTotDev.Location = new System.Drawing.Point(32, 254);
            this.lblTotDev.Name = "lblTotDev";
            this.lblTotDev.Size = new System.Drawing.Size(83, 13);
            this.lblTotDev.TabIndex = 30;
            this.lblTotDev.Text = "Total Devengos";
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(578, 230);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(117, 41);
            this.btnMod.TabIndex = 29;
            this.btnMod.Text = "Modificar Datos";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMod_MouseClick);
            // 
            // txtBRetIRPF
            // 
            this.txtBRetIRPF.Location = new System.Drawing.Point(433, 153);
            this.txtBRetIRPF.Name = "txtBRetIRPF";
            this.txtBRetIRPF.ReadOnly = true;
            this.txtBRetIRPF.Size = new System.Drawing.Size(92, 20);
            this.txtBRetIRPF.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Retención IRPF";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBCotSegDes
            // 
            this.txtBCotSegDes.Location = new System.Drawing.Point(433, 112);
            this.txtBCotSegDes.Name = "txtBCotSegDes";
            this.txtBCotSegDes.ReadOnly = true;
            this.txtBCotSegDes.Size = new System.Drawing.Size(92, 20);
            this.txtBCotSegDes.TabIndex = 26;
            // 
            // lblCotSegDes
            // 
            this.lblCotSegDes.AutoSize = true;
            this.lblCotSegDes.Location = new System.Drawing.Point(278, 115);
            this.lblCotSegDes.Name = "lblCotSegDes";
            this.lblCotSegDes.Size = new System.Drawing.Size(149, 13);
            this.lblCotSegDes.TabIndex = 25;
            this.lblCotSegDes.Text = "Cotización Seguro Desempleo";
            // 
            // txtBCotSegSoc
            // 
            this.txtBCotSegSoc.Location = new System.Drawing.Point(433, 76);
            this.txtBCotSegSoc.Name = "txtBCotSegSoc";
            this.txtBCotSegSoc.ReadOnly = true;
            this.txtBCotSegSoc.Size = new System.Drawing.Size(92, 20);
            this.txtBCotSegSoc.TabIndex = 24;
            // 
            // lblCotSegSoc
            // 
            this.lblCotSegSoc.AutoSize = true;
            this.lblCotSegSoc.Location = new System.Drawing.Point(278, 79);
            this.lblCotSegSoc.Name = "lblCotSegSoc";
            this.lblCotSegSoc.Size = new System.Drawing.Size(139, 13);
            this.lblCotSegSoc.TabIndex = 23;
            this.lblCotSegSoc.Text = "Cotización Seguridad Social";
            // 
            // txtBPE
            // 
            this.txtBPE.Location = new System.Drawing.Point(106, 194);
            this.txtBPE.Name = "txtBPE";
            this.txtBPE.ReadOnly = true;
            this.txtBPE.Size = new System.Drawing.Size(92, 20);
            this.txtBPE.TabIndex = 22;
            // 
            // lblPE
            // 
            this.lblPE.AutoSize = true;
            this.lblPE.Location = new System.Drawing.Point(34, 197);
            this.lblPE.Name = "lblPE";
            this.lblPE.Size = new System.Drawing.Size(59, 13);
            this.lblPE.TabIndex = 21;
            this.lblPE.Text = "Paga Extra";
            // 
            // txtBHrs
            // 
            this.txtBHrs.Location = new System.Drawing.Point(104, 153);
            this.txtBHrs.Name = "txtBHrs";
            this.txtBHrs.ReadOnly = true;
            this.txtBHrs.Size = new System.Drawing.Size(92, 20);
            this.txtBHrs.TabIndex = 20;
            this.txtBHrs.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblHE
            // 
            this.lblHE.AutoSize = true;
            this.lblHE.Location = new System.Drawing.Point(32, 156);
            this.lblHE.Name = "lblHE";
            this.lblHE.Size = new System.Drawing.Size(62, 13);
            this.lblHE.TabIndex = 19;
            this.lblHE.Text = "Horas Extra";
            this.lblHE.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // txtBAnt
            // 
            this.txtBAnt.Location = new System.Drawing.Point(104, 112);
            this.txtBAnt.Name = "txtBAnt";
            this.txtBAnt.ReadOnly = true;
            this.txtBAnt.Size = new System.Drawing.Size(92, 20);
            this.txtBAnt.TabIndex = 18;
            // 
            // lblAnt
            // 
            this.lblAnt.AutoSize = true;
            this.lblAnt.Location = new System.Drawing.Point(32, 115);
            this.lblAnt.Name = "lblAnt";
            this.lblAnt.Size = new System.Drawing.Size(61, 13);
            this.lblAnt.TabIndex = 17;
            this.lblAnt.Text = "Antiguedad";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(578, 277);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 41);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSalir_MouseClick);
            // 
            // txtBSB
            // 
            this.txtBSB.Location = new System.Drawing.Point(104, 76);
            this.txtBSB.Name = "txtBSB";
            this.txtBSB.ReadOnly = true;
            this.txtBSB.Size = new System.Drawing.Size(92, 20);
            this.txtBSB.TabIndex = 3;
            // 
            // lblSB
            // 
            this.lblSB.AutoSize = true;
            this.lblSB.Location = new System.Drawing.Point(32, 79);
            this.lblSB.Name = "lblSB";
            this.lblSB.Size = new System.Drawing.Size(66, 13);
            this.lblSB.TabIndex = 0;
            this.lblSB.Text = "Salario Base";
            // 
            // errorNif
            // 
            this.errorNif.ContainerControl = this;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // frmHojaSalarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 681);
            this.Controls.Add(this.grBResult);
            this.Controls.Add(this.grBData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 2000);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHojaSalarial";
            this.Text = "Hoja Salarial";
            this.grBData.ResumeLayout(false);
            this.grBData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTrien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHijos)).EndInit();
            this.grBResult.ResumeLayout(false);
            this.grBResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBData;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.DateTimePicker datePck;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblTrn;
        private System.Windows.Forms.Label lblHijos;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox grBResult;
        private System.Windows.Forms.TextBox txtBHrs;
        private System.Windows.Forms.Label lblHE;
        private System.Windows.Forms.TextBox txtBAnt;
        private System.Windows.Forms.Label lblAnt;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtBSB;
        private System.Windows.Forms.Label lblSB;
        private System.Windows.Forms.TextBox txtBPE;
        private System.Windows.Forms.Label lblPE;
        private System.Windows.Forms.TextBox txtBRetIRPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBCotSegDes;
        private System.Windows.Forms.Label lblCotSegDes;
        private System.Windows.Forms.TextBox txtBCotSegSoc;
        private System.Windows.Forms.Label lblCotSegSoc;
        private System.Windows.Forms.TextBox txtBLiq;
        private System.Windows.Forms.Label lblLiq;
        private System.Windows.Forms.TextBox txtBTotDes;
        private System.Windows.Forms.Label lblTotDes;
        private System.Windows.Forms.TextBox txtBTotDev;
        private System.Windows.Forms.Label lblTotDev;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.MaskedTextBox maskTxtBNIF;
        private System.Windows.Forms.ErrorProvider errorNif;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.MaskedTextBox maskTxtBNombre;
        private System.Windows.Forms.NumericUpDown numUpDownHijos;
        private System.Windows.Forms.NumericUpDown numUpDownCat;
        private System.Windows.Forms.NumericUpDown numUpDownHrs;
        private System.Windows.Forms.NumericUpDown numUpDownTrien;
    }
}

