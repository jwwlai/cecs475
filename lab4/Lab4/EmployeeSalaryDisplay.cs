using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.IO;

namespace Lab4
{
    public partial class EmployeeSalaryDisplay : Form
    {
        private Form whereICameFrom, messageBox;
        private EmployeeManagerSingleton employeeManager;
        private int selectedTab = 0, checkedSortBox = 0;
        private Boolean selectedRadioBtn;
        private string documentContents;
        private string listOfEmployeesToPrint;

        public Boolean linkToNewEmployee;

        public EmployeeSalaryDisplay(Form previousForm, EmployeeManagerSingleton manager)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.whereICameFrom = previousForm;
            this.employeeManager = manager;
            this.linkToNewEmployee = false;
            displayAllEmployees();
        }

        // property to link the Salary Display form to the New Employee form
        public Boolean LinkToNewEmployee 
        {
            get
            {
                return this.linkToNewEmployee;
            }
            set
            {
                this.linkToNewEmployee = false;
            }
        }
                
        private void AllEmployeesTabControl_SelectedIndexChanged(object sender, TabControlEventArgs e)
        {
            this.selectedTab = e.TabPageIndex;
            displayForSelectedTab(selectedTab);
        }
        
        private void sortAscendingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayChangeInSortDirection(sortAscendingRadioButton.Checked);            
        }

        private void sortDescendingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayChangeInSortDirection(sortAscendingRadioButton.Checked); //why Ascending? b/c if it's false, the descending must be selected
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            this.linkToNewEmployee = true;
            this.Close();
            this.whereICameFrom.Show();
        }

        private void ssnCheckBox_CheckedChanged(object sender, EventArgs e)
        {            
            int SSN = 1;
            this.checkedSortBox = SSN;
            clearCheckBoxes(SSN);
            displaySortForSelectedTab(SSN);
        }

        private void lastNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int lName = 2;
            this.checkedSortBox = lName;
            clearCheckBoxes(lName);
            displaySortForSelectedTab(lName);
        }

        private void payAmountCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int pay = 3;
            this.checkedSortBox = pay;
            clearCheckBoxes(pay);
            displaySortForSelectedTab(pay);
        }        

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writeDocument();
            ReadDocument();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            //change font that prints to save format
            Font fontToPrint = new Font("Courier New", 12.0f);

            // Sets the value of charactersOnPage to the number of characters  
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(listOfEmployeesToPrint, fontToPrint,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page.
            e.Graphics.DrawString(listOfEmployeesToPrint, fontToPrint, Brushes.Black,
            e.MarginBounds, StringFormat.GenericTypographic);
        }

        private void writeDocument()
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\testPage.txt");
                sw.Write(this.listOfEmployeesToPrint);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void ReadDocument()
        {
            string docName = "testPage.txt";
            string docPath = @"c:\";
            printDocument1.DocumentName = docName;
            using (FileStream stream = new FileStream(docPath + docName, FileMode.Open))
            using (StreamReader reader = new StreamReader(stream))
            {
                documentContents = reader.ReadToEnd();
            }
            listOfEmployeesToPrint = documentContents;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.whereICameFrom.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitButton_Click(sender, e);
        }

        /******************** HELPER FOR DISPLAY & SORTS ******************************/
        private void displayForSelectedTab(int selectedTab)
        {
            switch (this.selectedTab)
            {
                case 0: //ALL                    
                    displayAllEmployees();
                    break;
                case 1: //SALARIED                    
                    displaySalariedEmployees();
                    break;
                case 2: //COMMISSION
                    displayCommissionEmployees();
                    break;
                case 3: //BASE+COMMISSION
                    displayBasePlusCommissionEmployees();
                    break;
                case 4: //HOURLY
                    displayHourlyEmployees();
                    break;
                case 5:
                    this.searchResultsLabel.Text = "Search";
                    break;
                default:
                    break;
            }
        }

        private void displayAllEmployees()
        {
            decimal totalPmt = 0;
            listOfEmployeesToPrint = string.Format("{0,-16}{1,-16}{2,-20}{3,-1}",
                                        "First Name", "Last Name", "SSN", "Payment Due\n");
            foreach (Employee someEmployee in employeeManager.ListOfEmployees)
            {
                listOfEmployeesToPrint += someEmployee.ToString() + "\n";
                totalPmt += someEmployee.GetPaymentAmount();
            }
            this.allEmployeesLabel.Text = listOfEmployeesToPrint;
            this.totalPmtLabel.Text = String.Format("{0:C}", totalPmt);
        }

        private void displaySalariedEmployees()
        {
            decimal totalPmt = 0;
            listOfEmployeesToPrint = string.Format("{0,-16}{1,-16}{2,-20}{3,-1}",
                                        "First Name", "Last Name", "SSN", "Payment Due\n");
            foreach (Employee someEmployee in employeeManager.ListOfEmployees)
            {
                if (someEmployee is SalariedEmployee)
                {
                    listOfEmployeesToPrint += someEmployee.ToString() + "\n";
                    totalPmt += someEmployee.GetPaymentAmount();
                }
            }
            this.salaryLabel.Text = listOfEmployeesToPrint;
            this.totalPmtLabel.Text = String.Format("{0:C}", totalPmt);
        }

        private void displayCommissionEmployees()
        {
            decimal totalPmt = 0;
            listOfEmployeesToPrint = string.Format("{0,-16}{1,-16}{2,-16}{3,-18}{4,-15}{5,-1}",
                                    "First Name", "Last Name", "SSN", "Payment Due", "Sales", "Rate\n");
            foreach (Employee someEmployee in employeeManager.ListOfEmployees)
            {
                if (someEmployee is CommissionEmployee && someEmployee is BasePlusCommissionEmployee) { }
                else if (someEmployee is CommissionEmployee)
                {
                    listOfEmployeesToPrint += someEmployee.ToString(1) + "\n";
                    totalPmt += someEmployee.GetPaymentAmount();
                }
            }
            this.commissionLabel.Text = listOfEmployeesToPrint;
            this.totalPmtLabel.Text = String.Format("{0:C}", totalPmt);
        }

        private void displayBasePlusCommissionEmployees()
        {
            decimal totalPmt = 0;
            listOfEmployeesToPrint = string.Format("{0,-16}{1,-16}{2,-16}{3,-15}{4,-18}{5,-13}{6,-1}",
                                    "First Name", "Last Name", "SSN", "Payment Due", "Base Salary", "Sales", "Rate\n");
            foreach (Employee someEmployee in employeeManager.ListOfEmployees)
            {
                if (someEmployee is CommissionEmployee && someEmployee is BasePlusCommissionEmployee)
                {
                    listOfEmployeesToPrint += someEmployee.ToString(1) + "\n";
                    totalPmt += someEmployee.GetPaymentAmount();
                }
            }
            this.baseCommissionLabel.Text = listOfEmployeesToPrint;
            this.totalPmtLabel.Text = String.Format("{0:C}", totalPmt);
        }

        private void displayHourlyEmployees()
        {
            decimal totalPmt = 0;
            listOfEmployeesToPrint = string.Format("{0,-16}{1,-16}{2,-16}{3,-18}{4,-15}{5,-1}",
                                        "First Name", "Last Name", "SSN", "Payment Due", "Hourly Wage", "Hours Worked\n");
            foreach (Employee someEmployee in employeeManager.ListOfEmployees)
            {
                if (someEmployee is HourlyEmployee)
                {
                    listOfEmployeesToPrint += someEmployee.ToString(1) + "\n";
                    totalPmt += someEmployee.GetPaymentAmount();
                }
            }
            this.hourlyLabel.Text = listOfEmployeesToPrint;
            this.totalPmtLabel.Text = String.Format("{0:C}", totalPmt);
        }

        private void displaySortForSelectedTab(int sortType)  //SSN = 1, LastName = 2, PayAmount = 3
        {
            int sort = 1;   //1 for descending, 0 for ascending
            if (this.selectedRadioBtn) sort = 0;
            switch (sortType)
            {
                case 1:
                    employeeManager.ListOfEmployees.Sort(Employee.sortSsn(sort));
                    displayForSelectedTab(this.selectedTab);
                    break;
                case 2:
                    employeeManager.ListOfEmployees.Sort(Employee.sortLastName(sort));
                    displayForSelectedTab(this.selectedTab);
                    break;
                case 3:
                    employeeManager.ListOfEmployees.Sort(Employee.sortPay(sort));
                    displayForSelectedTab(this.selectedTab);
                    break;
            }            
        }

        private void displayChangeInSortDirection(Boolean sortDirection)
        {
            this.selectedRadioBtn = sortDirection;
            clearCheckBoxes(this.checkedSortBox);
            displaySortForSelectedTab(this.checkedSortBox);
        }

        private void clearCheckBoxes(int checkedBox) //SSN = 1, LastName = 2, PayAmount = 3
        {
            switch (checkedBox)
            {
                case 1:
                    lastNameCheckBox.Checked = false;
                    payAmountCheckBox.Checked = false;
                    break;
                case 2:
                    ssnCheckBox.Checked = false;
                    payAmountCheckBox.Checked = false;
                    break;
                case 3:
                    ssnCheckBox.Checked = false;
                    lastNameCheckBox.Checked = false;
                    break;
            }
        }

        /******************************************************************************/
    }
}
