using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Validating_Input
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Cursors myCursor = new Cursors();
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var emptyBoxes =
                from Control currentControl in Controls
                where currentControl is TextBox
                let box = currentControl as TextBox
                where string.IsNullOrEmpty(box.Text)
                orderby box.TabIndex
                select box;
           
            if (emptyBoxes.Count() > 0)
            {
                MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!validateInput(lastNameTextBox.Text, "^[A-Z][a-zA-Z]*$", "Invalid Last Name"))
                    lastNameTextBox.Select();
                else if (!validateInput(firstNameTextBox.Text, "^[A-Z][a-zA-Z]*$", "Invalid First Name"))
                    firstNameTextBox.Select();
                //else if(!addressTextBox.Text,"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$","Invalid Address")
                //    addressTextBox.Select();
                else
                {
                    this.Hide();
                    MessageBox.Show("Thank you!", "Information Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool validateInput(string input, string expression, string message)
        {
            bool valid = Regex.Match(input, expression).Success;
            if (!valid)
            {
                MessageBox.Show(message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return valid;
        }
    }
}
