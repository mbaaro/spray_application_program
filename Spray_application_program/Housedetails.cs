﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;


namespace Spray_application_program
{
    public partial class Housedetails : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlDataAdapter da;
        SqlCommand command;
        String query;
        public Housedetails()
        {
            InitializeComponent();
            //get connection
            Connector cn = new Connector();
            con = cn.connect();
        }

        private void grdhouses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void gethouses()
        {
            // fetch the available houses
            query = "";
            command = new SqlCommand(query, con);
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr.GetString(1));

            }
            //lets set the results as the data to the grid
            grdhouses.DataSource = dr;
        }

    }
}
