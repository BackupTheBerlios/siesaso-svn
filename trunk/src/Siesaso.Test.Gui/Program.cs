using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Softwarekueche.Siesaso.Test.Gui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Siesaso.Hibernate.Internal.Session.InstanceDatabase = "SieSaSoDatenbank.mdb";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VSNachbildung());
        }
    }
}