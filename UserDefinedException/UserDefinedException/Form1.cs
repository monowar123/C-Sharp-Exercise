using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserDefinedException
{
    public partial class SquareRootForm : Form
    {
        public SquareRootForm()
        {
            InitializeComponent();
        }

        public double SquareRoot( double value )
        {
            if (value < 0)
                throw new NegetiveNumberException("Square root of negetive number is not permitted.");
            else
                return Math.Sqrt(value);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            try
            {
                double result = SquareRoot(Convert.ToDouble(textBox1.Text));
                textBox2.Text = Convert.ToString(result);
            }
            catch (FormatException exParameter)
            {
                MessageBox.Show(exParameter.Message, "Invalid Number Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NegetiveNumberException exParameter)
            {
                MessageBox.Show(exParameter.Message);
            }
        }
    }
}
