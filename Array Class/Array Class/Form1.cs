using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Array_Class
{
    public partial class Form1 : Form
    {
        // define how array of object works with indexer
        personIndexer people;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            people = new personIndexer();
            ArrayInitializer(ref people);
            ShowPeople(people);
            //When the Array.SetValue() method is called, it replaces the element at the indicated position.
        }

        private void ArrayInitializer(ref personIndexer people)
        {
            people[0] = new person()
            {
                personID = 72947,
                firstName = "Paulette",
                lastName = "Cranston",
                gender = Genders.Female
            };

            people[1] = new person()
            {
                personID = 70854,
                firstName = "Harry",
                lastName = "Kumar",
                gender = Genders.Male
            };

            people[2] = new person()
            {
                personID = 27947,
                firstName = "Jules",
                lastName = "Davidson",
                gender = Genders.Male
            };

            people[3] = new person()
            {
                personID = 62835,
                firstName = "Leslie",
                lastName = "Harrington",
                gender = Genders.Unknown
            };

            //Array.Resize<person>(ref people, 6); //resize the person class array

            people.Resize();

            people[4] = new person()
            {
                personID = 92958,
                firstName = "Ernest",
                lastName = "Colson",
                gender = Genders.Male
            };

            people[5] = new person()
            {
                personID = 91749,
                firstName = "Patricia",
                lastName = "Katts",
                gender = Genders.Female
            };
        }

        private void ShowPeople(personIndexer people)
        {
            for (int i = 0; i < people.individuals.Length; i++)
            {
                ListViewItem item = new ListViewItem(people[i].personID.ToString());
                item.SubItems.Add(people[i].firstName);
                item.SubItems.Add(people[i].lastName);
                item.SubItems.Add(people[i].gender.ToString());
                listView1.Items.Add(item);
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            person pers = (person)people.individuals.GetValue(e.ItemIndex); //get value from the array according to the selection 

            txtPersonID.Text = pers.personID.ToString();
            txtFirstName.Text = pers.firstName;
            txtLastName.Text = pers.lastName;
            txtGender.Text = pers.gender.ToString();
        }
    }
}
