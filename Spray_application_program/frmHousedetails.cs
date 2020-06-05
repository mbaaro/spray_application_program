using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace Spray_application_program
{
    public partial class frmHousedetails : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlDataAdapter da;
        SqlCommand command;
        String query;
        public frmHousedetails()
        {
            InitializeComponent();
            Connector cn = new Connector();
            con = cn.connect();
           
                    }

        private void grdhouses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
       
        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {

        }

          }
}
