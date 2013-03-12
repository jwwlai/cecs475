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
    public partial class TestForm : Form
    {
        public TestForm(string someMessage)
        {
            InitializeComponent();
            this.testLabel.Text = someMessage;
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
