using System.Drawing.Printing;
using System.Windows.Forms;

namespace Lab4
{
    partial class EmployeeSalaryDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private PrintDocument printDocument1 = new PrintDocument();

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.AllEmployeesTabControl = new System.Windows.Forms.TabControl();
            this.tabAllEmployees = new System.Windows.Forms.TabPage();
            this.allEmployeesLabel = new System.Windows.Forms.Label();
            this.allInfoLabel = new System.Windows.Forms.Label();
            this.tabSalary = new System.Windows.Forms.TabPage();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.salaryInfoLabel = new System.Windows.Forms.Label();
            this.tabCommission = new System.Windows.Forms.TabPage();
            this.commissionLabel = new System.Windows.Forms.Label();
            this.tabSalaryAndCommission = new System.Windows.Forms.TabPage();
            this.baseCommissionLabel = new System.Windows.Forms.Label();
            this.tabHourly = new System.Windows.Forms.TabPage();
            this.hourlyLabel = new System.Windows.Forms.Label();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.searchResultsLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.sortAscendingRadioButton = new System.Windows.Forms.RadioButton();
            this.sortDescendingRadioButton = new System.Windows.Forms.RadioButton();
            this.ssnCheckBox = new System.Windows.Forms.CheckBox();
            this.lastNameCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByGroupBox = new System.Windows.Forms.GroupBox();
            this.payAmountCheckBox = new System.Windows.Forms.CheckBox();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.totalPmtLabel = new System.Windows.Forms.Label();
            this.AllEmployeesTabControl.SuspendLayout();
            this.tabAllEmployees.SuspendLayout();
            this.tabSalary.SuspendLayout();
            this.tabCommission.SuspendLayout();
            this.tabSalaryAndCommission.SuspendLayout();
            this.tabHourly.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.sortByGroupBox.SuspendLayout();
            this.sortGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(730, 373);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(92, 30);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Cancel";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AllEmployeesTabControl
            // 
            this.AllEmployeesTabControl.Controls.Add(this.tabAllEmployees);
            this.AllEmployeesTabControl.Controls.Add(this.tabSalary);
            this.AllEmployeesTabControl.Controls.Add(this.tabCommission);
            this.AllEmployeesTabControl.Controls.Add(this.tabSalaryAndCommission);
            this.AllEmployeesTabControl.Controls.Add(this.tabHourly);
            this.AllEmployeesTabControl.Controls.Add(this.searchTab);
            this.AllEmployeesTabControl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllEmployeesTabControl.Location = new System.Drawing.Point(10, 39);
            this.AllEmployeesTabControl.Name = "AllEmployeesTabControl";
            this.AllEmployeesTabControl.SelectedIndex = 0;
            this.AllEmployeesTabControl.Size = new System.Drawing.Size(812, 235);
            this.AllEmployeesTabControl.TabIndex = 0;
            this.AllEmployeesTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.AllEmployeesTabControl_SelectedIndexChanged);
            // 
            // tabAllEmployees
            // 
            this.tabAllEmployees.Controls.Add(this.allEmployeesLabel);
            this.tabAllEmployees.Controls.Add(this.allInfoLabel);
            this.tabAllEmployees.Location = new System.Drawing.Point(4, 25);
            this.tabAllEmployees.Name = "tabAllEmployees";
            this.tabAllEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllEmployees.Size = new System.Drawing.Size(804, 206);
            this.tabAllEmployees.TabIndex = 0;
            this.tabAllEmployees.Text = "All";
            this.tabAllEmployees.UseVisualStyleBackColor = true;
            // 
            // allEmployeesLabel
            // 
            this.allEmployeesLabel.AutoSize = true;
            this.allEmployeesLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allEmployeesLabel.Location = new System.Drawing.Point(10, 15);
            this.allEmployeesLabel.Name = "allEmployeesLabel";
            this.allEmployeesLabel.Size = new System.Drawing.Size(0, 14);
            this.allEmployeesLabel.TabIndex = 1;
            // 
            // allInfoLabel
            // 
            this.allInfoLabel.AutoSize = true;
            this.allInfoLabel.Location = new System.Drawing.Point(4, 4);
            this.allInfoLabel.MaximumSize = new System.Drawing.Size(610, 210);
            this.allInfoLabel.Name = "allInfoLabel";
            this.allInfoLabel.Size = new System.Drawing.Size(0, 16);
            this.allInfoLabel.TabIndex = 0;
            // 
            // tabSalary
            // 
            this.tabSalary.Controls.Add(this.salaryLabel);
            this.tabSalary.Controls.Add(this.salaryInfoLabel);
            this.tabSalary.Location = new System.Drawing.Point(4, 25);
            this.tabSalary.Name = "tabSalary";
            this.tabSalary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalary.Size = new System.Drawing.Size(804, 206);
            this.tabSalary.TabIndex = 1;
            this.tabSalary.Text = "Salary";
            this.tabSalary.UseVisualStyleBackColor = true;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryLabel.Location = new System.Drawing.Point(10, 15);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(0, 14);
            this.salaryLabel.TabIndex = 2;
            // 
            // salaryInfoLabel
            // 
            this.salaryInfoLabel.AutoSize = true;
            this.salaryInfoLabel.Location = new System.Drawing.Point(3, 3);
            this.salaryInfoLabel.MaximumSize = new System.Drawing.Size(610, 210);
            this.salaryInfoLabel.Name = "salaryInfoLabel";
            this.salaryInfoLabel.Size = new System.Drawing.Size(0, 16);
            this.salaryInfoLabel.TabIndex = 1;
            // 
            // tabCommission
            // 
            this.tabCommission.Controls.Add(this.commissionLabel);
            this.tabCommission.Location = new System.Drawing.Point(4, 25);
            this.tabCommission.Name = "tabCommission";
            this.tabCommission.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommission.Size = new System.Drawing.Size(804, 206);
            this.tabCommission.TabIndex = 2;
            this.tabCommission.Text = "Commission";
            this.tabCommission.UseVisualStyleBackColor = true;
            // 
            // commissionLabel
            // 
            this.commissionLabel.AutoSize = true;
            this.commissionLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commissionLabel.Location = new System.Drawing.Point(10, 15);
            this.commissionLabel.Name = "commissionLabel";
            this.commissionLabel.Size = new System.Drawing.Size(0, 14);
            this.commissionLabel.TabIndex = 2;
            // 
            // tabSalaryAndCommission
            // 
            this.tabSalaryAndCommission.Controls.Add(this.baseCommissionLabel);
            this.tabSalaryAndCommission.Location = new System.Drawing.Point(4, 25);
            this.tabSalaryAndCommission.Name = "tabSalaryAndCommission";
            this.tabSalaryAndCommission.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalaryAndCommission.Size = new System.Drawing.Size(804, 206);
            this.tabSalaryAndCommission.TabIndex = 3;
            this.tabSalaryAndCommission.Text = "Base Salary + Commission";
            this.tabSalaryAndCommission.UseVisualStyleBackColor = true;
            // 
            // baseCommissionLabel
            // 
            this.baseCommissionLabel.AutoSize = true;
            this.baseCommissionLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseCommissionLabel.Location = new System.Drawing.Point(10, 15);
            this.baseCommissionLabel.Name = "baseCommissionLabel";
            this.baseCommissionLabel.Size = new System.Drawing.Size(0, 14);
            this.baseCommissionLabel.TabIndex = 2;
            // 
            // tabHourly
            // 
            this.tabHourly.Controls.Add(this.hourlyLabel);
            this.tabHourly.Location = new System.Drawing.Point(4, 25);
            this.tabHourly.Name = "tabHourly";
            this.tabHourly.Padding = new System.Windows.Forms.Padding(3);
            this.tabHourly.Size = new System.Drawing.Size(804, 206);
            this.tabHourly.TabIndex = 4;
            this.tabHourly.Text = "Hourly";
            this.tabHourly.UseVisualStyleBackColor = true;
            // 
            // hourlyLabel
            // 
            this.hourlyLabel.AutoSize = true;
            this.hourlyLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyLabel.Location = new System.Drawing.Point(10, 15);
            this.hourlyLabel.Name = "hourlyLabel";
            this.hourlyLabel.Size = new System.Drawing.Size(0, 14);
            this.hourlyLabel.TabIndex = 2;
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.searchResultsLabel);
            this.searchTab.Location = new System.Drawing.Point(4, 25);
            this.searchTab.Name = "searchTab";
            this.searchTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab.Size = new System.Drawing.Size(804, 206);
            this.searchTab.TabIndex = 5;
            this.searchTab.Text = "Search";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultsLabel.Location = new System.Drawing.Point(10, 15);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(0, 14);
            this.searchResultsLabel.TabIndex = 2;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(704, 280);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(118, 16);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Total Payment Due";
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeButton.Location = new System.Drawing.Point(572, 373);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(142, 30);
            this.addEmployeeButton.TabIndex = 7;
            this.addEmployeeButton.Text = "Add New Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // sortAscendingRadioButton
            // 
            this.sortAscendingRadioButton.AutoSize = true;
            this.sortAscendingRadioButton.Checked = true;
            this.sortAscendingRadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortAscendingRadioButton.Location = new System.Drawing.Point(11, 33);
            this.sortAscendingRadioButton.Name = "sortAscendingRadioButton";
            this.sortAscendingRadioButton.Size = new System.Drawing.Size(87, 20);
            this.sortAscendingRadioButton.TabIndex = 8;
            this.sortAscendingRadioButton.TabStop = true;
            this.sortAscendingRadioButton.Text = "Ascending";
            this.sortAscendingRadioButton.UseVisualStyleBackColor = true;
            this.sortAscendingRadioButton.CheckedChanged += new System.EventHandler(this.sortAscendingRadioButton_CheckedChanged);
            // 
            // sortDescendingRadioButton
            // 
            this.sortDescendingRadioButton.AutoSize = true;
            this.sortDescendingRadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortDescendingRadioButton.Location = new System.Drawing.Point(11, 56);
            this.sortDescendingRadioButton.Name = "sortDescendingRadioButton";
            this.sortDescendingRadioButton.Size = new System.Drawing.Size(94, 20);
            this.sortDescendingRadioButton.TabIndex = 9;
            this.sortDescendingRadioButton.Text = "Descending";
            this.sortDescendingRadioButton.UseVisualStyleBackColor = true;
            this.sortDescendingRadioButton.CheckedChanged += new System.EventHandler(this.sortDescendingRadioButton_CheckedChanged);
            // 
            // ssnCheckBox
            // 
            this.ssnCheckBox.AutoSize = true;
            this.ssnCheckBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnCheckBox.Location = new System.Drawing.Point(11, 34);
            this.ssnCheckBox.Name = "ssnCheckBox";
            this.ssnCheckBox.Size = new System.Drawing.Size(54, 20);
            this.ssnCheckBox.TabIndex = 10;
            this.ssnCheckBox.Text = "SSN";
            this.ssnCheckBox.UseVisualStyleBackColor = true;
            this.ssnCheckBox.CheckedChanged += new System.EventHandler(this.ssnCheckBox_CheckedChanged);
            // 
            // lastNameCheckBox
            // 
            this.lastNameCheckBox.AutoSize = true;
            this.lastNameCheckBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameCheckBox.Location = new System.Drawing.Point(11, 58);
            this.lastNameCheckBox.Name = "lastNameCheckBox";
            this.lastNameCheckBox.Size = new System.Drawing.Size(90, 20);
            this.lastNameCheckBox.TabIndex = 12;
            this.lastNameCheckBox.Text = "Last Name";
            this.lastNameCheckBox.UseVisualStyleBackColor = true;
            this.lastNameCheckBox.CheckedChanged += new System.EventHandler(this.lastNameCheckBox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            //
            // sortByGroupBox
            // 
            this.sortByGroupBox.Controls.Add(this.payAmountCheckBox);
            this.sortByGroupBox.Controls.Add(this.lastNameCheckBox);
            this.sortByGroupBox.Controls.Add(this.ssnCheckBox);
            this.sortByGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByGroupBox.Location = new System.Drawing.Point(227, 280);
            this.sortByGroupBox.Name = "sortByGroupBox";
            this.sortByGroupBox.Size = new System.Drawing.Size(200, 123);
            this.sortByGroupBox.TabIndex = 14;
            this.sortByGroupBox.TabStop = false;
            this.sortByGroupBox.Text = "Sort By";
            // 
            // payAmountCheckBox
            // 
            this.payAmountCheckBox.AutoSize = true;
            this.payAmountCheckBox.Location = new System.Drawing.Point(11, 81);
            this.payAmountCheckBox.Name = "payAmountCheckBox";
            this.payAmountCheckBox.Size = new System.Drawing.Size(98, 20);
            this.payAmountCheckBox.TabIndex = 13;
            this.payAmountCheckBox.Text = "Pay Amount";
            this.payAmountCheckBox.UseVisualStyleBackColor = true;
            this.payAmountCheckBox.CheckedChanged += new System.EventHandler(this.payAmountCheckBox_CheckedChanged);
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.sortAscendingRadioButton);
            this.sortGroupBox.Controls.Add(this.sortDescendingRadioButton);
            this.sortGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortGroupBox.Location = new System.Drawing.Point(10, 280);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(200, 123);
            this.sortGroupBox.TabIndex = 15;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Sort";
            // 
            // totalPmtLabel
            // 
            this.totalPmtLabel.AutoSize = true;
            this.totalPmtLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalPmtLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalPmtLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPmtLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.totalPmtLabel.Location = new System.Drawing.Point(605, 308);
            this.totalPmtLabel.MaximumSize = new System.Drawing.Size(210, 20);
            this.totalPmtLabel.MinimumSize = new System.Drawing.Size(210, 20);
            this.totalPmtLabel.Name = "totalPmtLabel";
            this.totalPmtLabel.Size = new System.Drawing.Size(210, 20);
            this.totalPmtLabel.TabIndex = 16;
            this.totalPmtLabel.Text = "0";
            this.totalPmtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmployeeSalaryDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(845, 415);
            this.Controls.Add(this.totalPmtLabel);
            this.Controls.Add(this.sortGroupBox);
            this.Controls.Add(this.sortByGroupBox);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.AllEmployeesTabControl);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EmployeeSalaryDisplay";
            this.Text = "Employee Salary Display";
            this.AllEmployeesTabControl.ResumeLayout(false);
            this.tabAllEmployees.ResumeLayout(false);
            this.tabAllEmployees.PerformLayout();
            this.tabSalary.ResumeLayout(false);
            this.tabSalary.PerformLayout();
            this.tabCommission.ResumeLayout(false);
            this.tabCommission.PerformLayout();
            this.tabSalaryAndCommission.ResumeLayout(false);
            this.tabSalaryAndCommission.PerformLayout();
            this.tabHourly.ResumeLayout(false);
            this.tabHourly.PerformLayout();
            this.searchTab.ResumeLayout(false);
            this.searchTab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sortByGroupBox.ResumeLayout(false);
            this.sortByGroupBox.PerformLayout();
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TabControl AllEmployeesTabControl;
        private System.Windows.Forms.TabPage tabAllEmployees;
        private System.Windows.Forms.TabPage tabSalary;
        private System.Windows.Forms.TabPage tabCommission;
        private System.Windows.Forms.TabPage tabSalaryAndCommission;
        private System.Windows.Forms.TabPage tabHourly;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label allInfoLabel;
        private System.Windows.Forms.Label salaryInfoLabel;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.RadioButton sortAscendingRadioButton;
        private System.Windows.Forms.RadioButton sortDescendingRadioButton;
        private System.Windows.Forms.CheckBox ssnCheckBox;
        private System.Windows.Forms.CheckBox lastNameCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox sortByGroupBox;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.CheckBox payAmountCheckBox;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Label allEmployeesLabel;
        private Label salaryLabel;
        private Label commissionLabel;
        private Label baseCommissionLabel;
        private Label hourlyLabel;
        private Label searchResultsLabel;
        private Label totalPmtLabel;

    }
}

