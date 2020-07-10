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
        int maxid,chem_code=0, target_code=0;
        String query;
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand sqlcmd;
        SqlConnection cn;
        String selected;

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
            //now lets refresh the  combos
            gettargets();
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
        {//lets first clear  the listbox
            lsttargets.Items.Clear();
            //lets retrievetargets for selected chemical
            targettext.Text = "Targets for: "+cbochem.SelectedItem;
            query = "select pest_disease_details.pdd_desc from chemical_pest inner join pest_disease_details on chemical_pest.target_code=pest_disease_details.pdd_code inner join chemical_details on chemical_pest.chemical_code=chemical_details.chemical_code where chemical_details.chemical_name='"+cbochem.SelectedItem+"'";
            sqlcmd = new SqlCommand(query,cn);
            dr = sqlcmd.ExecuteReader();
            while (dr.Read()) {
                lsttargets.Items.Add(dr.GetString(0) + "\n");
               
               // lsttargets.Items.Add("\n");
            }
            dr.Dispose();
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
            //get the chemical code and target code
            getcodes("insert");
        //lets now insert the new combination
            query = "insert into chemical_pest(chemical_code,target_code)values('"+chem_code+"','"+target_code +"')";
            da = new SqlDataAdapter(query, cn);
            da.InsertCommand = new SqlCommand(query,cn);
            if(da.InsertCommand.ExecuteNonQuery()==1){
                MessageBox.Show("Update unsuccessful");
            }else{
                MessageBox.Show("Update Done");
            }
            da.Dispose();
        }
                         private void getcodes(String action) {
            String chemname = "", targetname = "";
            if(action=="insert"){
                chemname=cbochem.SelectedItem.ToString().Trim();
                targetname = cbotarget.SelectedItem.ToString().Trim();
            }else if(action=="delete"){
                chemname = targettext.Text;
                targetname = lsttargets.Items.ToString();
            }
            chem_code = 0;
            target_code = 0;
            //get chem code
            query = "SELECT chemical_code  FROM [Chemical_Details] where chemical_name='" + chemname + "'";
            sqlcmd = new SqlCommand(query, cn);
            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                chem_code = dr.GetInt16(0);
            }
            dr.Dispose();
            //get target code
            query = "select  Pest_Disease_Details.pdd_code from Pest_Disease_Details  where Pest_Disease_Details.pdd_desc='" +targetname+ "'";
            sqlcmd = new SqlCommand(query, cn);
            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                target_code = dr.GetInt16(0);
            }
            dr.Dispose();
        }


        private void getchemicals() {
            cbochem.Items.Clear();
            query = "SELECT distinct(chemical_name)  FROM [Chemical_Details] where deleted=0";
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
        private void filtertargets()
        {
            //filter the  target list to leave only those not created
            cbotarget.Items.Clear();
            query = "SELECT distinct(pdd_desc) FROM [Pest_Disease_Details]   where deleted=0 and pdd_code not in(select target_code from chemical_pest where chemical_code="+chem_code+")";
            sqlcmd = new SqlCommand(query, cn);
            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                cbotarget.Items.Add(dr.GetString(0));
            }
            dr.Dispose();

        }
                    private void button5_Click(object sender, EventArgs e)
        {
            //get chemical and target codes
            getcodes("delete");
            //delete selected item
            String confirm = MessageBox.Show("Are you sure you wish to delete selected target?", "CONFIRM DELETION", MessageBoxButtons.YesNo).ToString();
            if (confirm =="Yes") {
                query = "delete from chemical_pest where chemical_code=" + chem_code + "and target_code=" + target_code;
                da = new SqlDataAdapter(query, cn);
                da.DeleteCommand = new SqlCommand(query, cn);
                if (da.DeleteCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Target successfully deleted");
                }
                else {
                    MessageBox.Show("Target could not be deleted. Please try again later");
                }
                da.Dispose();
            }
           //MessageBox.Show( lsttargets.ge);
        }

        private void lsttargets_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(lsttargets.SelectedItems.ToString());
            MessageBox.Show(lsttargets.get());
            selected = "";
           // lsttargets.
            
        }

        private void cbochem_SelectedIndexChanged(object sender, EventArgs e)
        {
            chem_code = 0;
           //get chem code
            query = "SELECT chemical_code  FROM [Chemical_Details] where chemical_name='" + cbochem.SelectedItem.ToString().Trim() + "'";
            sqlcmd = new SqlCommand(query, cn);
            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                chem_code = dr.GetInt16(0);
            }
            dr.Dispose();
            filtertargets();
        }

        

      
       
    }
}
