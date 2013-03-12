using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab4
{
    public partial class NewEmployeeInfoForm : Form
    {
        Form whereICameFrom, messageBox;
        EmployeeManagerSingleton employeeManager;

        string firstName, lastName, ssn;
        decimal sales, rate, salary, hourly, hoursWorked;
        int comboBoxIndexSelected;

        public NewEmployeeInfoForm(Form previousForm, EmployeeManagerSingleton manager)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.employeeManager = manager;
            this.whereICameFrom = previousForm;
            this.salaryTypeComboBox.SelectedIndex = 0;
            this.firstLabel.Hide();
            this.firstBox.Hide();
            this.secondLabel.Hide();
            this.secondBox.Hide();
            this.thirdLabel.Hide();
            this.thirdBox.Hide();
        }

        private void empTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxIndexSelected = this.salaryTypeComboBox.SelectedIndex;
            switch (comboBoxIndexSelected)
            {
                case 0:
                    this.firstLabel.Hide();
                    this.firstBox.Hide();
                    this.secondLabel.Hide();
                    this.secondBox.Hide();
                    this.thirdLabel.Hide();
                    this.thirdBox.Hide();
                    break;
                case 1: //Salary
                    this.firstLabel.Text = "Salary";
                    this.firstLabel.Show();
                    this.firstBox.Show();
                    this.secondLabel.Hide();
                    this.secondBox.Hide();
                    this.thirdLabel.Hide();
                    this.thirdBox.Hide();
                    break;
                case 2: //Commission
                    this.firstLabel.Text = "Sales";
                    this.firstLabel.Show();
                    this.firstBox.Show();
                    this.secondLabel.Text = "Rate";
                    this.secondLabel.Show();
                    this.secondBox.Show();
                    this.thirdLabel.Hide();
                    this.thirdBox.Hide();
                    break;
                case 3: //Base + Commission
                    this.firstLabel.Text = "Base Salary";
                    this.firstLabel.Show();
                    this.firstBox.Show();
                    this.secondLabel.Text = "Sales";
                    this.secondLabel.Show();
                    this.secondBox.Show();
                    this.thirdLabel.Text = "Rate";
                    this.thirdLabel.Show();
                    this.thirdBox.Show();
                    break;
                case 4: //Hourly
                    this.firstLabel.Text = "Hourly Wage";
                    this.firstLabel.Show();
                    this.firstBox.Show();
                    this.secondLabel.Text = "Hours Worked";
                    this.secondLabel.Show();
                    this.secondBox.Show();
                    this.thirdLabel.Hide();
                    this.thirdBox.Hide();
                    break;
            }
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {

            this.firstName = this.fNameTextBox.Text;
            this.lastName = this.lNameTextBox.Text;
            this.ssn = this.ssnTextBox.Text;

            //if user enters in wrong input or blank input
            if (firstName.Equals("") || lastName.Equals("") || ssn.Equals("") || !(Regex.IsMatch(firstName, @"^[a-zA-Z]+$")) || !(Regex.IsMatch(lastName, @"^[a-zA-Z]+$")) || !(Regex.IsMatch(ssn, @"^\d{3}-\d{2}-\d{4}$")))
            {
                invalidInput();
            }

            switch (comboBoxIndexSelected)
            {
                case 1: //Salary
                    try
                    {
                        this.salary = Convert.ToDecimal(this.firstBox.Text);

                        //create and add the employee
                        this.employeeManager.addEmployee(this.employeeManager.createSalaryEmployee(firstName, lastName, ssn, salary));
                        employeeAddedConfirmation();
                        
                    }
                    catch
                    {
                        //invalidInput();
                        this.firstBox.Clear();
                    }
                    break;
                case 2: //Commission
                    try
                    {

                        this.sales = System.Convert.ToDecimal(this.firstBox.Text);
                        this.rate = System.Convert.ToDecimal(this.secondBox.Text);
                        this.employeeManager.addEmployee(this.employeeManager.createCommissionEmployee(firstName, lastName, ssn, sales, rate));
                        employeeAddedConfirmation();
                    }
                    catch
                    {
                        invalidInput();
                        this.firstBox.Clear();
                        this.secondBox.Clear();
                    }
                    break;
                case 3: //Base + Commission
                    try
                    {
                        this.salary = System.Convert.ToDecimal(this.firstBox.Text);
                        this.sales = System.Convert.ToDecimal(this.secondBox.Text);
                        this.rate = System.Convert.ToDecimal(this.thirdBox.Text);
                        this.employeeManager.addEmployee(this.employeeManager.createBaseCommissionEmployee(firstName, lastName, ssn, sales, rate, salary));
                        employeeAddedConfirmation();
                    }
                    catch
                    {
                        invalidInput();
                        this.firstBox.Clear();
                        this.secondBox.Clear();
                        this.thirdBox.Clear();
                    }
                    break;
                case 4: //Hourly
                    try
                    {
                        this.hourly = System.Convert.ToDecimal(this.firstBox.Text);
                        this.hoursWorked = System.Convert.ToDecimal(this.secondBox.Text);
                        this.employeeManager.createHourlyEmployee(firstName, lastName, ssn, hourly, hoursWorked);
                        employeeAddedConfirmation();
                    }
                    catch
                    {
                        invalidInput();
                        this.firstBox.Clear();
                        this.secondBox.Clear();
                    }
                    break;
                default:
                    // CREATE BOX to NOTIFY no combo box selection was detected
                    this.messageBox = new MessageForm(this, "You must select a compensation type!");
                    this.messageBox.Show();
                    break;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.whereICameFrom.Show();
        }

        /************************** HELPER METHODS ***************************/
        private void employeeAddedConfirmation()
        {
            this.messageBox = new MessageForm(this, this.firstName + " " + this.lastName + " has been added.");
            this.messageBox.ShowDialog();
           
            this.Close();
            this.whereICameFrom.Show();
        }

        private void invalidInput()
        {
            this.messageBox = new MessageForm(this, "Invalid input! Check below for rules for input:\n\n" + "First name and last name are REQUIRED.\n"
                                                + "SSN Format (including the dashes): XXX-XX-XXXX" );
            this.messageBox.ShowDialog();
        }

        /*********************************************************************/        
    }
}
