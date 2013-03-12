using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Lab4
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
            EmployeeManagerSingleton employeeManager = new EmployeeManagerSingleton();
            Application.Run(new RootForm(employeeManager)); 
            
        }
    }
}
