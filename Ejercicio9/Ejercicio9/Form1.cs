using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio9
{
    public partial class myTextEditor : Form
    {
        public myTextEditor()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open my new file";
            openFile.Filter = "Text Files (*.txt) |*.txt|All Files (*.*)|*.*"; 
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                rtb.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = openFile.FileName;
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save my new file";
            saveFile.Filter = "Text Files (*.txt) |*.txt|All Files (*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                rtb.LoadFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = saveFile.FileName;

        }

        private void pageSetUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pSUD.ShowDialog();

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printD.ShowDialog();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontSel = new FontDialog();
            fontSel.Font = rtb.Font;
            fontSel.ShowDialog();
            rtb.Font = fontSel.Font;
        }
    }
}
