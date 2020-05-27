using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spray_application_program
{
    public partial class frmsprayapp : Form
    {
        public frmsprayapp()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void greenHouseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Housedetails();
            frm.Show();

        }
    }
}
