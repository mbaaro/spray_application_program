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
        SqlDataAdapter da;

        //class to create a  database connection
        public SqlConnection connect()
        {
            //lets now connect
            messagebox.show("ss");
        }
    }
}
