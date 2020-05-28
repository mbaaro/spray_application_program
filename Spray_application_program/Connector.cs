using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Spray_application_program
{

    class Connector
    {
        string constring;
        SqlConnection con;
        

        //class to create a  database connection
        public SqlConnection connect()
        {
            try
            {

                constring = "DATA SOURCE=172.21.4.17; INITIAL CATALOG=spray_app1; INTEGRATED SECURITY=true";
                con = new SqlConnection(constring);
                con.Open();
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return con;
        }
    }
}
