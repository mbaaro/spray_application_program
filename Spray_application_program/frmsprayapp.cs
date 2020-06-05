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
            Form frm = new frmHousedetails();
            frm.Show();

        }

        private void cropDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcrops show = new frmcrops();
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
            frmingredients1 show = new frmingredients1();
            show.Show();
        }

        private void modeOfActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmodeofaction1 show = new frmmodeofaction1();
            show.Show();
                    }

        private void applicationMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmappmethod1 show = new frmappmethod1();
            show.Show();
        }

        private void tankTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtanktypes1 show = new frmtanktypes1();
            show.Show();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchemtypes1 show = new frmchemtypes1();
            show.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchemcat1 show = new frmchemcat1();
            show.Show();
        }

        private void wHORatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWHORatings1 show = new frmWHORatings1();
            show.Show();
        }

        private void waterVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmwatervolume show = new frmwatervolume();
            show.Show();
         }

        private void phaseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmphase1 show = new frmphase1();
            show.Show();
                    }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmemployees1 show = new frmemployees1();
            show.Show();
        }

        private void detailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmchemical_details show = new frmchemical_details();
            show.Show();
                    }

        private void conversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmuomconvert1 show = new frmuomconvert1();
            show.Show();
        }

        private void nozzleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnozzle1 show = new frmnozzle1();
            show.Show();
        }

        private void pestDiseaseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpest_diseases1 show = new frmpest_diseases1();
            show.Show();
        }

        private void sprayPressureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmspraypressure1 show = new frmspraypressure1();
            show.Show();
        }

        private void sprayMachinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmspraymachines1 show = new frmspraymachines1();
            show.Show();
        }

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmteams1 show = new frmteams1();
            show.Show();
        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmweeks show = new frmweeks();
            show.Show();
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcurrency1 show = new frmcurrency1();
            show.Show();
        }

        private void storeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstore show = new frmstore();
            show.Show();
        }
    }
}
