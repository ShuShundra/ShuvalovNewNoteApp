﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using note;
using System.Windows.Forms;

namespace NoteAppUI
{
    static class Program1
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new noteAppForm());
        }
    }
}
