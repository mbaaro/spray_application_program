﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Spray_application_program
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //lets get connected
            Connector cn = new Connector();
            cn.connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          Application.Run(new frmsprayapp());
            
        }
    }
}
