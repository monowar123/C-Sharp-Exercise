using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankLibrary
{
    public partial class BankUIForm : Form
    {
        protected int TextBoxCount = 4;
        public enum TextBoxIndeces 
        { 
            ACCOUNT, 
            FIRST, 
            LAST, 
            BALANCE 
        }
        public BankUIForm()
        {
            InitializeComponent();
        }

        public void ClearTextBoxes()
        {
            foreach (Control guiControl in Controls)
            {
                if (guiControl is TextBox)
                {
                    ((TextBox)guiControl).Clear();
                }
            }
        }

        public void SetTextBoxValues(string[] values)
        {
            if (values.Length != TextBoxCount)
            {
                throw (new ArgumentException("There must be " + (TextBoxCount + 1) + "strings in the array"));
            }
            else
            {
                textBoxAccount.Text = values[(int)TextBoxIndeces.ACCOUNT];
                textBoxFirstName.Text = values[(int)TextBoxIndeces.FIRST];
                textBoxLastName.Text = values[(int)TextBoxIndeces.LAST];
                textBoxBalance.Text = values[(int)TextBoxIndeces.BALANCE];
            }
        }

        public string[] GetTextBoxValues()
        {
            string[] values = new string[TextBoxCount];

            values[(int)TextBoxIndeces.ACCOUNT] = textBoxAccount.Text;
            values[(int)TextBoxIndeces.FIRST] = textBoxFirstName.Text;
            values[(int)TextBoxIndeces.LAST] = textBoxLastName.Text;
            values[(int)TextBoxIndeces.BALANCE] = textBoxBalance.Text;

            return values;
        }

    }
}
