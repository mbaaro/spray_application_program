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
    public partial class frmchemcat1 : Form
    {
        SqlConnection con;
        SqlCommand sqlcmd;
        SqlDataAdapter da;
        SqlDataReader dtr;
        String query,category;
        bool deleted;
        int maxid;

        public frmchemcat1()
        {
            InitializeComponent();
             Connector cnn = new Connector();
            con = cnn.connect();
            getmaxid();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void getmaxid()
        {
            //lets get the maximum id for chemical categories
            query = "Select max(cc_code) as maxid from chemical_category ";
            sqlcmd = new SqlCommand(query,con);
            dtr = sqlcmd.ExecuteReader();
                while(dtr.Read()){
                    maxid = dtr.GetInt16(0);
                    txt_code.Text = (maxid + 1).ToString();
                }
                sqlcmd.Dispose();
                dtr.Close();
                
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
             
            deleted = chkdeleted.Checked;
            category = txt_desc.Text.Trim();

            if (category!= "") {
                if (checkexisting()== true)
                {
                    MessageBox.Show("Category Already Exists");
                }
                else {
                    insertnew();
                }

            }
        }

        private bool checkexisting() {
            bool existing=false;
            
        //check if the entered description exists
            query = "select count(cc_desc) as count from chemical_category where cc_desc='"+category+"'";
            sqlcmd = new SqlCommand(query, con);
            dtr = sqlcmd.ExecuteReader();
            while(dtr.Read()){
            if(dtr.GetInt32(0)>0){
                existing = true;
            }
            else{
                existing = false;
            }
            }
            sqlcmd.Dispose();
            dtr.Close();
            return existing;
        }

        private void insertnew()
        {

            //lets insert the new category as it does not exist
            query = "insert into chemical_category(cc_code,cc_desc,deleted)values('"+(maxid+1) +"','"+category+"','"+deleted+"')";
            da = new SqlDataAdapter(query, con);
            da.InsertCommand = new SqlCommand(query, con);
            if (da.InsertCommand.ExecuteNonQuery() == 1) {
                MessageBox.Show("New Category created");
                txt_desc.Clear();
                getmaxid();
            }
            da.Dispose();
        }

     
    }
}
