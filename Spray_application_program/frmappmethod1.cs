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
                    int ad_code = maxid;
                    String ad_desc = txt_desc.Text.Trim();
                    bool deleted = chkdeleted.Checked;
                   // make sure the description is not empty
                    if (txt_desc.Text != "") {
                        // check if the method exits
                        query = "select count(AD_desc) as count1 from application_method where ad_desc='"+ad_desc+"'";
                        sqlcmd = new SqlCommand(query, con);
                        dtr = sqlcmd.ExecuteReader();
                        while (dtr.Read())
                        {
                           // MessageBox.Show(dtr.GetSqlDouble(0).Value);
                            if (dtr.GetSqlInt32(0)>0)
                            {
                                MessageBox.Show("Application Method Already exists");
                            }
                            else
                            {
                                dtr.Close();
                              
                                //lets insert
                                query = "insert into application_method(ad_code,ad_desc,deleted)values('"+ad_code+"','"+ad_desc+"','"+deleted+"')";
                                dta = new SqlDataAdapter(query, con);
                                dta.InsertCommand = new SqlCommand(query,con);
                                //dta.InsertCommand.ExecuteNonQuery();
                                if (dta.InsertCommand.ExecuteNonQuery()==1)
                                {
                                    MessageBox.Show("Application method has been added");
                                    txt_desc.Clear();
                                    getid();
                                    dta.Dispose();
                                    sqlcmd.Dispose();
                                }


                            }
                        }
                       
                    }

        
                }

        private void getid()
        {
            query = "select max(AD_code) as maxid from application_method";
            sqlcmd = new SqlCommand(query, con);
            dtr = sqlcmd.ExecuteReader();
            while (dtr.Read()){
            maxid=(dtr.GetInt16(0)+1);
            txt_code.Text = maxid.ToString();
            }
            dtr.Dispose();
            sqlcmd.Dispose();
                }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.Application.Exit();
            this.Dispose();
        }

    }
}
