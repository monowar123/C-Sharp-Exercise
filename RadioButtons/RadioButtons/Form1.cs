using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RadioButtons
{
    public partial class Form1 : Form
    {
        private MessageBoxButtons buttonType;
        private MessageBoxIcon iconType;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "None.";
            if (sender == okRadioButton)
                buttonType = MessageBoxButtons.OK;
            else if (sender == OKCancelRadioButton)
                buttonType = MessageBoxButtons.OKCancel;
            else if (sender == abroadRetryIgnoreRadioButton)
                buttonType = MessageBoxButtons.AbortRetryIgnore;
            else if (sender == yesNoCancelRadioButton)
                buttonType = MessageBoxButtons.YesNoCancel;
            else if (sender == yesNoRadioButton)
                buttonType = MessageBoxButtons.YesNo;
            else
                buttonType = MessageBoxButtons.RetryCancel;
        }

        private void groupBox2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "None.";
            if (sender == asteriskRadioButton)
                iconType = MessageBoxIcon.Asterisk;
            else if (sender == errorRadioButton)
                iconType = MessageBoxIcon.Error;
            else if (sender == exclamationRadioButton)
                iconType = MessageBoxIcon.Exclamation;
            else if (sender == handRadioButton)
                iconType = MessageBoxIcon.Hand;
            else if (sender == informationRadioButton)
                iconType = MessageBoxIcon.Information;
            else if (sender == questionRadioButton)
                iconType = MessageBoxIcon.Question;
            else if (sender == stopRadioButton)
                iconType = MessageBoxIcon.Stop;
            else
                iconType = MessageBoxIcon.Warning;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This is your custom MessageBox", "Custom MessageBox", buttonType, iconType, 0, 0);
            switch (result)
            {
                case DialogResult.OK:
                    label1.Text = "OK was pressed.";
                    break;
                case DialogResult.Cancel:
                    label1.Text = "Cancel was pressed.";
                    break;
                case DialogResult.Abort:
                    label1.Text = "Abort was pressed.";
                    break;
                case DialogResult.Retry:
                    label1.Text = "Retry was pressed.";
                    break;
                case DialogResult.Ignore:
                    label1.Text = "Ignore was pressed.";
                    break;
                case DialogResult.Yes:
                    label1.Text = "Yes was pressed.";
                    break;
                case DialogResult.No:
                    label1.Text = "No was pressed.";
                    break;
                default:
                    label1.Text = "Default.";
                    break;
            }
        }
    }
}
