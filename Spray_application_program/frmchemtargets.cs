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
            getchemicals();
            gettargets();
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
                if (checkexisting("target") == true)
                {
                    MessageBox.Show("This Target already exists. Check to make sure none is marked as deleted");
                }
                else { 
                //target  does not exist, lets insert new record
                    inserttaget();
                }

            }
        }

        private void getmax() {
            query = "SELECT max(pdd_code) as max FROM [Pest_Disease_Details]";
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
                query = "SELECT count(pdd_desc) as count FROM [Pest_Disease_Details] where pdd_desc='"+txt_desc.Text.Trim()+"' ";
                                
            }
            else if(type=="pesttarget"){
                query = "select count(chemical_pest.target_code)as count from chemical_pest inner join pest_disease_details on chemical_pest.target_code=pest_disease_details.pdd_code inner join chemical_type on chemical_pest.chemical_code=chemical_type.ct_code where pest_disease_details.pdd_desc='" + cbotarget.SelectedItem.ToString().Trim() + "' and chemical_type.ct_desc='" + cbochem.SelectedItem.ToString().Trim() + "'";
            }
            sqlcmd = new SqlCommand(query,cn);
            dr = sqlcmd.ExecuteReader();
            while (dr.Read()) {
                if (dr.GetInt32(0) == 0) {
                    status = false;
                }
                else {
                    status = true;
                }
            }
            //lets close the connections
            dr.Dispose();
            sqlcmd.Dispose();
            return status;
        }

        private void inserttaget() { 
        //lets insert a new target
            query= "insert into pest_disease_details(pdd_code,pdd_desc,deleted)values('" + txt_code.Text.Trim() + "','" + txt_desc.Text.Trim() + "','"+chk_deleted.Checked+"')";
            da = new SqlDataAdapter(query, cn);
            da.InsertCommand = new SqlCommand(query,cn);
            if(da.InsertCommand.ExecuteNonQuery()==1){
                MessageBox.Show("Target Successfully saved");
            }else{
                MessageBox.Show("Target not successfully saved");
            }
        //closing open connections
            da.Dispose();
                    }

        private void btn_retrieve_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //lets make sure this combination does not exist
            if (checkexisting("pesttarget") == true)
            {
                MessageBox.Show("This Chemical - Target combination already exists. Check to make sure none is marked as deleted");
            }
            else
            {
                //target  does not exist, lets insert new record
                insertpesttarget();
            }
        }

        private void insertpesttarget() { 
        //lets now insert the new combination
            query = @"insert into chemical_pest(chemical_code,target_code)values(
            select  distinct chemical_type.ct_code from chemical_type  where chemical_type.ct_desc='" + cbochem.SelectedItem.ToString().Trim() + "',"
            select  distinct Pest_Disease_Details.pdd_code from Pest_Disease_Details  where Pest_Disease_Details.pdd_desc='" + cbotarget.SelectedItem.ToString().Trim() + "'";
            Console.WriteLine(query);
            da = new SqlDataAdapter(query, cn);
            da.InsertCommand = new SqlCommand(query,cn);
            if(da.InsertCommand.ExecuteNonQuery()==1){
                MessageBox.Show("Update unsuccessful");
            }else{
                MessageBox.Show("Update Done");
            }
            da.Dispose();
        }
        private void getchemicals() {
            cbochem.Items.Clear();
            query = "SELECT distinct(ct_desc) FROM [chemical_type] where deleted=0";
            sqlcmd = new SqlCommand(query, cn);
            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                cbochem.Items.Add(dr.GetString(0));
            }
            dr.Dispose();
        }
        private void gettargets() {
            cbotarget.Items.Clear();
            query = "SELECT distinct(pdd_desc) FROM [Pest_Disease_Details] where deleted=0";
            sqlcmd = new SqlCommand(query, cn);
            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                cbotarget.Items.Add(dr.GetString(0));
            }
            dr.Dispose();

        }

       
    }
}
