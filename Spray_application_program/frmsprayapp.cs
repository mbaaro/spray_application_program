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
            frmcurrency show = new frmcurrency();
            show.Show();
        }

        private void modeOfActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcurrency show = new frmcurrency();
            show.Show();
                    }

        private void applicationMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcurrency show = new frmcurrency();
            show.Show();
        }

        private void tankTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcurrency show = new frmcurrency();
            show.Show();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcurrency show = new frmcurrency();
            show.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcurrency show = new frmcurrency();
            show.Show();
        }

        private void wHORatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWHORatings show = new frmWHORatings();
            show.Show();
        }

        private void waterVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmwatervolume show = new frmwatervolume();
            show.Show();
         }

        private void phaseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcurrency show = new frmcurrency();
            show.Show();
                    }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmemployees show = new frmemployees();
            show.Show();
        }

        private void detailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmcurrency show = new frmcurrency();
            show.Show();
                    }

        private void conversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmuomconvert show = new frmuomconvert();
            show.Show();
        }

        private void nozzleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcurrency show = new frmcurrency();
            show.Show();
        }

        private void pestDiseaseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpests_disease show = new frmpests_disease();
            show.Show();
        }

        private void sprayPressureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcurrency show=new frmcurrency();
            show.Show();
        }

        private void sprayMachinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcurrency show = new frmcurrency();
            show.Show();
        }

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcurrency show = new frmcurrency();
            show.Show();
        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmweeks show = new frmweeks();
            show.Show();
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcurrency show = new frmcurrency();
            show.Show();
        }

        private void storeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstore show = new frmstore();
            show.Show();
        }
    }
}
