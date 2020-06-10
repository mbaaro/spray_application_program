using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spray_application_program
{
    public partial class frmchemtargets : Form
    {
        int maxid;
        String query;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand sqlcmd;
        SqlConnection cn;

        public frmchemtargets()
        {
            InitializeComponent();
            Connector con = new Connector();
            cn = con.connect();
            getmax();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //close current form
            this.Dispose();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
//make sure the description is not empty
            if (txt_desc.Text != "")
            {
                //lets make sure this entry does not exist

            }
        }

        private void getmax() {
            query = "SELECT max(pdd_code) as max FROM [spray_app1].[dbo].[Pest_Disease_Details]";
            sqlcmd = new SqlCommand(query, cn);
            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                maxid = (dr.GetInt16(0)+1);
            }
            txt_code.Text = maxid.ToString();
            //close the connections 
            dr.Dispose();
            sqlcmd.Dispose();
        }

        private bool checkexisting(string type)
        {
            bool status=false;

            if (type == "target")
            {
                query = "SELECT count(ppd_desc) as count FROM [spray_app1].[dbo].[Pest_Disease_Details] where pdd_desc='"+txt_desc.Text.Trim()+"' ";
                                
            }
            else if(type=="pesttarget"){
                query = "";
            }
            sqlcmd = new SqlCommand(query,cn);
            dr = sqlcmd.ExecuteReader();
            while (dr.Read()) {
                if (dr.GetInt16() > 0) {
                    status = false;
                }
                else {
                    status = true;
                }
            }
            return status;
        }



       
    }
}
