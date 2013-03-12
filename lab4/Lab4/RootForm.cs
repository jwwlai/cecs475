using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab4
{
    public partial class RootForm : Form
    {
        Form about;
        EmployeeManagerSingleton theManager;

        public RootForm(EmployeeManagerSingleton employeeManager)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.theManager = employeeManager;
        }

        private void employeeSalariesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form salaryDisplay = new EmployeeSalaryDisplay(this, this.theManager);            
            salaryDisplay.ShowDialog();            
        }

        private void newEmployeeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form employeeInfo = new NewEmployeeInfoForm(this, theManager);
            employeeInfo.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutDropDownMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form about = new AboutBoxDisplay(this);
            about.Show();
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /******************* HELPER METHODS *****************************/
       
    }
}
