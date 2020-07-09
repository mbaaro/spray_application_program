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
      public partial class frmchemtypes1 : Form
    {
          String query;
          SqlDataAdapter da;
          SqlDataReader dr;
          SqlCommand sqlcm;
          SqlConnection cn;
          int maxid;

        public frmchemtypes1()
        {
            InitializeComponent();
            Connector con = new Connector();
            cn = con.connect();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(txt_desc.Text !=""){
                if (checkexisting() == true) {
                    MessageBox.Show("Chemical type already exists");  
                }
                else {
                    insertnew();
                }
            }
        }
        private void getmaxid() {
            query = "";
            sqlcm = new SqlCommand(query,cn);
            dr = sqlcm.ExecuteReader();
            while(dr.Read()){
                txt_code.Text = (dr.GetInt32(0) + 1).ToString();
                maxid = (dr.GetInt32(0) + 1);
            }
        }
        private bool checkexisting() {
            bool existing=false ;


            return existing;
        }
        private void insertnew() {
        
        }
    }
}
