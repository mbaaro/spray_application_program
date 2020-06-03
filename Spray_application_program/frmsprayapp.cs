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

        private void cropDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcrops show = new frmcrops();
            show.Show();
        }

        private void cropStageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcropstage show = new frmcropstage();
            show.Show();
        }

        private void cropStageDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcutstage show = new frmcutstage();
            show.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchemical_details show = new frmchemical_details();
            show.Show();
        }

        private void chemicalPestsTargetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchemtargets show = new frmchemtargets();
            show.Show();
        }

        private void ingredientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmappmethod show = new frmappmethod();
            show.Show();
        }

        private void modeOfActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmappmethod show = new frmappmethod();
            show.Show();
                    }

        private void applicationMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmappmethod show = new frmappmethod();
            show.Show();
        }
    }
}
