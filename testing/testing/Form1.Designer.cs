namespace testing
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.file2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.file21ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.file22ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.file221ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file1ToolStripMenuItem,
            this.file2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file1ToolStripMenuItem
            // 
            this.file1ToolStripMenuItem.Name = "file1ToolStripMenuItem";
            this.file1ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.file1ToolStripMenuItem.Text = "file 1";
            // 
            // file2ToolStripMenuItem
            // 
            this.file2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file21ToolStripMenuItem,
            this.file22ToolStripMenuItem});
            this.file2ToolStripMenuItem.Name = "file2ToolStripMenuItem";
            this.file2ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.file2ToolStripMenuItem.Text = "file2";
            // 
            // file21ToolStripMenuItem
            // 
            this.file21ToolStripMenuItem.Name = "file21ToolStripMenuItem";
            this.file21ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.file21ToolStripMenuItem.Text = "file 2.1";
            // 
            // file22ToolStripMenuItem
            // 
            this.file22ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file221ToolStripMenuItem});
            this.file22ToolStripMenuItem.Name = "file22ToolStripMenuItem";
            this.file22ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.file22ToolStripMenuItem.Text = "file 2.2";
            // 
            // file221ToolStripMenuItem
            // 
            this.file221ToolStripMenuItem.Name = "file221ToolStripMenuItem";
            this.file221ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.file221ToolStripMenuItem.Text = "file2.2.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem file2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem file21ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem file22ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem file221ToolStripMenuItem;
    }
}

