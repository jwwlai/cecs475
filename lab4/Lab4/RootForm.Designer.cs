namespace Lab4
{
    partial class RootForm
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
            this.employeeSalariesBtn = new System.Windows.Forms.Button();
            this.newEmployeeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDropDownMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomePictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcomePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeSalariesBtn
            // 
            this.employeeSalariesBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeSalariesBtn.Location = new System.Drawing.Point(78, 371);
            this.employeeSalariesBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeeSalariesBtn.Name = "employeeSalariesBtn";
            this.employeeSalariesBtn.Size = new System.Drawing.Size(182, 28);
            this.employeeSalariesBtn.TabIndex = 1;
            this.employeeSalariesBtn.Text = "Employee Salaries";
            this.employeeSalariesBtn.UseVisualStyleBackColor = true;
            this.employeeSalariesBtn.Click += new System.EventHandler(this.employeeSalariesBtn_Click);
            // 
            // newEmployeeBtn
            // 
            this.newEmployeeBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmployeeBtn.Location = new System.Drawing.Point(78, 418);
            this.newEmployeeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newEmployeeBtn.Name = "newEmployeeBtn";
            this.newEmployeeBtn.Size = new System.Drawing.Size(182, 28);
            this.newEmployeeBtn.TabIndex = 2;
            this.newEmployeeBtn.Text = "Add New Employee";
            this.newEmployeeBtn.UseVisualStyleBackColor = true;
            this.newEmployeeBtn.Click += new System.EventHandler(this.newEmployeeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(78, 465);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(182, 28);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(326, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutDropDownMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(41, 20);
            this.fileMenu.Text = "File";
            this.fileMenu.Click += new System.EventHandler(this.fileMenu_Click);
            // 
            // aboutDropDownMenuItem
            // 
            this.aboutDropDownMenuItem.Name = "aboutDropDownMenuItem";
            this.aboutDropDownMenuItem.Size = new System.Drawing.Size(110, 22);
            this.aboutDropDownMenuItem.Text = "About";
            this.aboutDropDownMenuItem.Click += new System.EventHandler(this.aboutDropDownMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // welcomePictureBox
            // 
            this.welcomePictureBox.Image = global::Lab4.Properties.Resources.manager;
            this.welcomePictureBox.Location = new System.Drawing.Point(0, 27);
            this.welcomePictureBox.Name = "welcomePictureBox";
            this.welcomePictureBox.Size = new System.Drawing.Size(326, 317);
            this.welcomePictureBox.TabIndex = 6;
            this.welcomePictureBox.TabStop = false;
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 529);
            this.Controls.Add(this.welcomePictureBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.newEmployeeBtn);
            this.Controls.Add(this.employeeSalariesBtn);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RootForm";
            this.Text = "Employee Manager Application";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcomePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button employeeSalariesBtn;
        private System.Windows.Forms.Button newEmployeeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutDropDownMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox welcomePictureBox;
    }
}