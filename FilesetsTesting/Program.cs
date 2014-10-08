using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FilesetsLibrary;

namespace FilesetsTesting
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var testingRepo = new FilesetsTestRepo();
            var window = new FilesetsWindow(testingRepo);


            Application.Run(window);
        }
    }
}
