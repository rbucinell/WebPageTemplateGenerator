using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WebPageTemplateGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            IconAssigner.Execute();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm( args.Length == 0 ? "" : args[0]  ));
        }
    }
}
