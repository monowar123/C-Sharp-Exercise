using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Dictionary_based_collection
{
    public partial class Form1 : Form
    {
        ListBox lbxStudents;
        Hashtable students;
        public Form1()
        {
            InitializeComponent();
            Text = "Students";
            lbxStudents = new ListBox();
            lbxStudents.Location = new Point(12, 12);
            Controls.Add(lbxStudents);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students = new Hashtable();
            students.Add("01", "Shaon");
            students.Add("03", "Mahmudul");
            students.Add("05", "Jaman");
            students.Add("06", "Toushar");
            students.Add("07", "Sorno");
            students["08"] = "Mehedi";

            foreach (DictionaryEntry entry in students)
            {
                lbxStudents.Items.Add(entry.Key + " -> " + entry.Value);
            }
            
            //link list
            List<double> values = new List<double>();
            values.Add(84.597);
            values.Add(6.47);
            values.Add(2747.06);
            values.Add(282.924);

            LinkedList<double> numbers = new LinkedList<double>(values);
            numbers.AddLast(123.3);
            LinkedListNode<double> mm = new LinkedListNode<double>(111.12);
            numbers.AddLast(mm);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (students.ContainsKey("01"))
            {
                MessageBox.Show("The list contains an item whose key is \"01\"");
            }
        }
    }
}
