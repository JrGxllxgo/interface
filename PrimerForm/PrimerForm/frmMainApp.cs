using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerForm
{
    public partial class frmMainApp : Form
    {
        public frmMainApp()
        {
            InitializeComponent();
        }

        private void frmMainApp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmrMiTmer_Tick(object sender, EventArgs e)
        {
            try
            {
                prgProgress.Value++;
                txtBUsername.Text = prgProgress.Value.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                txtBUsername.Text = "Ha petao";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrMiTmer.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrMiTmer.Enabled = false;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            prgProgress.Value= 0;
            tmrMiTmer.Start();
        }
    }
}
