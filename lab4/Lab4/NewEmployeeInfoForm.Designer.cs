namespace Lab4
{
    partial class NewEmployeeInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.salaryTypeComboBox = new System.Windows.Forms.ComboBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.employeeTypeLabel = new System.Windows.Forms.Label();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.firstBox = new System.Windows.Forms.TextBox();
            this.secondBox = new System.Windows.Forms.TextBox();
            this.thirdBox = new System.Windows.Forms.TextBox();
            this.thirdLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.employeeInfoGroup = new System.Windows.Forms.GroupBox();
            this.compensationGroup = new System.Windows.Forms.GroupBox();
            this.employeeInfoGroup.SuspendLayout();
            this.compensationGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(19, 27);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(72, 16);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(19, 85);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(71, 16);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnLabel.Location = new System.Drawing.Point(19, 146);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(96, 16);
            this.ssnLabel.TabIndex = 4;
            this.ssnLabel.Text = "Social Security";
            // 
            // salaryTypeComboBox
            // 
            this.salaryTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.salaryTypeComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryTypeComboBox.FormattingEnabled = true;
            this.salaryTypeComboBox.Items.AddRange(new object[] {
            "-- Select --",
            "Salary",
            "Commission",
            "Base + Commission",
            "Hourly"});
            this.salaryTypeComboBox.Location = new System.Drawing.Point(21, 46);
            this.salaryTypeComboBox.Name = "salaryTypeComboBox";
            this.salaryTypeComboBox.Size = new System.Drawing.Size(314, 24);
            this.salaryTypeComboBox.TabIndex = 5;
            this.salaryTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.empTypeComboBox_SelectedIndexChanged);
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameTextBox.Location = new System.Drawing.Point(19, 46);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(296, 22);
            this.fNameTextBox.TabIndex = 6;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameTextBox.Location = new System.Drawing.Point(19, 104);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(296, 22);
            this.lNameTextBox.TabIndex = 7;
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnTextBox.Location = new System.Drawing.Point(19, 165);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(296, 22);
            this.ssnTextBox.TabIndex = 8;
            // 
            // employeeTypeLabel
            // 
            this.employeeTypeLabel.AutoSize = true;
            this.employeeTypeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeTypeLabel.Location = new System.Drawing.Point(18, 27);
            this.employeeTypeLabel.Name = "employeeTypeLabel";
            this.employeeTypeLabel.Size = new System.Drawing.Size(163, 16);
            this.employeeTypeLabel.TabIndex = 9;
            this.employeeTypeLabel.Text = "Select Compensation Type";
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeButton.Location = new System.Drawing.Point(593, 293);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(121, 31);
            this.addEmployeeButton.TabIndex = 10;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(723, 293);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(73, 31);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLabel.Location = new System.Drawing.Point(27, 93);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(61, 16);
            this.firstLabel.TabIndex = 12;
            this.firstLabel.Text = "1st Label";
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLabel.Location = new System.Drawing.Point(27, 121);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(64, 16);
            this.secondLabel.TabIndex = 16;
            this.secondLabel.Text = "2nd Label";
            // 
            // firstBox
            // 
            this.firstBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstBox.Location = new System.Drawing.Point(121, 90);
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(214, 22);
            this.firstBox.TabIndex = 17;
            // 
            // secondBox
            // 
            this.secondBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondBox.Location = new System.Drawing.Point(121, 118);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(214, 22);
            this.secondBox.TabIndex = 18;
            // 
            // thirdBox
            // 
            this.thirdBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdBox.Location = new System.Drawing.Point(121, 147);
            this.thirdBox.Name = "thirdBox";
            this.thirdBox.Size = new System.Drawing.Size(214, 22);
            this.thirdBox.TabIndex = 22;
            // 
            // thirdLabel
            // 
            this.thirdLabel.AutoSize = true;
            this.thirdLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdLabel.Location = new System.Drawing.Point(27, 150);
            this.thirdLabel.Name = "thirdLabel";
            this.thirdLabel.Size = new System.Drawing.Size(61, 16);
            this.thirdLabel.TabIndex = 21;
            this.thirdLabel.Text = "3rd Label";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(227, 20);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(261, 16);
            this.instructionLabel.TabIndex = 23;
            this.instructionLabel.Text = "Please enter the New Employee Information";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // employeeInfoGroup
            // 
            this.employeeInfoGroup.Controls.Add(this.firstNameLabel);
            this.employeeInfoGroup.Controls.Add(this.fNameTextBox);
            this.employeeInfoGroup.Controls.Add(this.lastNameLabel);
            this.employeeInfoGroup.Controls.Add(this.lNameTextBox);
            this.employeeInfoGroup.Controls.Add(this.ssnLabel);
            this.employeeInfoGroup.Controls.Add(this.ssnTextBox);
            this.employeeInfoGroup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeInfoGroup.Location = new System.Drawing.Point(21, 56);
            this.employeeInfoGroup.Name = "employeeInfoGroup";
            this.employeeInfoGroup.Size = new System.Drawing.Size(361, 209);
            this.employeeInfoGroup.TabIndex = 24;
            this.employeeInfoGroup.TabStop = false;
            this.employeeInfoGroup.Text = "Employee Information";
            // 
            // compensationGroup
            // 
            this.compensationGroup.Controls.Add(this.salaryTypeComboBox);
            this.compensationGroup.Controls.Add(this.employeeTypeLabel);
            this.compensationGroup.Controls.Add(this.firstBox);
            this.compensationGroup.Controls.Add(this.thirdBox);
            this.compensationGroup.Controls.Add(this.firstLabel);
            this.compensationGroup.Controls.Add(this.thirdLabel);
            this.compensationGroup.Controls.Add(this.secondBox);
            this.compensationGroup.Controls.Add(this.secondLabel);
            this.compensationGroup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compensationGroup.Location = new System.Drawing.Point(435, 56);
            this.compensationGroup.Name = "compensationGroup";
            this.compensationGroup.Size = new System.Drawing.Size(361, 209);
            this.compensationGroup.TabIndex = 25;
            this.compensationGroup.TabStop = false;
            this.compensationGroup.Text = "Compensation";
            // 
            // NewEmployeeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 367);
            this.Controls.Add(this.compensationGroup);
            this.Controls.Add(this.employeeInfoGroup);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Name = "NewEmployeeInfoForm";
            this.Text = "Employee Information";
            this.employeeInfoGroup.ResumeLayout(false);
            this.employeeInfoGroup.PerformLayout();
            this.compensationGroup.ResumeLayout(false);
            this.compensationGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.ComboBox salaryTypeComboBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.Label employeeTypeLabel;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.TextBox secondBox;
        private System.Windows.Forms.TextBox thirdBox;
        private System.Windows.Forms.Label thirdLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.GroupBox employeeInfoGroup;
        private System.Windows.Forms.GroupBox compensationGroup;
    }
}