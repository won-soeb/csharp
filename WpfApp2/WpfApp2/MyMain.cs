﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    class MyMain
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new MainWindow());
        }
    }
}
