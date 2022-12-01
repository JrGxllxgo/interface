namespace PrimerForm
{
    partial class frmMainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainApp));
            this.lblIntro = new System.Windows.Forms.Label();
            this.txtBUsername = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            this.grpConfig = new System.Windows.Forms.GroupBox();
            this.tmrMiTmer = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            this.grpConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(151, 34);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(213, 25);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "Write the following data";
            this.lblIntro.UseWaitCursor = true;
            this.lblIntro.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBUsername
            // 
            this.txtBUsername.Location = new System.Drawing.Point(26, 19);
            this.txtBUsername.Name = "txtBUsername";
            this.txtBUsername.Size = new System.Drawing.Size(168, 20);
            this.txtBUsername.TabIndex = 1;
            this.txtBUsername.TextChanged += new System.EventHandler(this.txtBUsername_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(160, 116);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(265, 116);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(87, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // prgProgress
            // 
            this.prgProgress.Location = new System.Drawing.Point(314, 180);
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(181, 23);
            this.prgProgress.TabIndex = 4;
            // 
            // grpConfig
            // 
            this.grpConfig.Controls.Add(this.btnRestart);
            this.grpConfig.Controls.Add(this.txtBUsername);
            this.grpConfig.Location = new System.Drawing.Point(144, 62);
            this.grpConfig.Name = "grpConfig";
            this.grpConfig.Size = new System.Drawing.Size(220, 112);
            this.grpConfig.TabIndex = 5;
            this.grpConfig.TabStop = false;
            this.grpConfig.Text = "Config";
            // 
            // tmrMiTmer
            // 
            this.tmrMiTmer.Interval = 500;
            this.tmrMiTmer.Tick += new System.EventHandler(this.tmrMiTmer_Tick);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(72, 83);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // frmMainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 215);
            this.Controls.Add(this.prgProgress);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.grpConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainApp";
            this.Text = "MiPrimeraApp Windows";
            this.Load += new System.EventHandler(this.frmMainApp_Load);
            this.grpConfig.ResumeLayout(false);
            this.grpConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.TextBox txtBUsername;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ProgressBar prgProgress;
        private System.Windows.Forms.GroupBox grpConfig;
        private System.Windows.Forms.Timer tmrMiTmer;
        private System.Windows.Forms.Button btnRestart;
    }
}

