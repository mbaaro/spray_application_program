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

    public partial class frmappmethod1 : Form
    {
        int maxid;
        SqlConnection con;
        SqlCommand sqlcmd;
        SqlDataReader dtr;
        SqlDataAdapter dta;
        String query;

        public frmappmethod1()
        {
            InitializeComponent();
            //get connection
            Connector conn = new Connector();
            con = conn.connect();
            //get the max id
            getid();

        }

                private void btn_update_Click(object sender, EventArgs e)
                {
// make sure the description is not empty
                    if (txt_desc.Text != "") {
                        // check if the method exits
                        query = "select count(AD_desc) as count from application_method";
                        sqlcmd = new SqlCommand(query, con);
                        dtr = sqlcmd.ExecuteNonQuery();
                        while (dtr.Read())
                        {
                            if (dtr.GetInt16(count) > 0)
                            {
                                MessageBox.Show("Application Method Already exists");
                            }
                            else
                            {
                                integer ad_code=(txt_code.Text+1);
                                integer ad_desc=txt_desc.Text ;
                                Boolean deleted = chkdeleted.CheckState;

                                //lets insert
                                query = "insert int application_method(ad_code,ad_desc,deleted)values()";
                                sqlcmd = new SqlCommand(query, con);
                                dta.InsertCommand = new SqlCommand(query,con);
                                if (dta.InsertCommand.ExecuteNonQuery())
                                {
                                    MessageBox.Show("Application method has been added");
                                }


                            }
                        }
                       
                    }

        
                }

        private void getid()
        {
            query = "select max(AD_code) as maxid from application_method";
            sqlcmd = new SqlCommand(query, con);
            dtr = sqlcmd.ExecuteNonQuery();
            while (dtr.Read()){
            maxid=dtr.GetInt16("maxid");
            txt_code.Text = maxid;
            }
            dtr.Dispose();
            sqlcmd.Dispose();
                }

    }
}
