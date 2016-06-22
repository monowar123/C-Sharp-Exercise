using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Data_Sets_Exercise
{
    public partial class Form1 : Form
    {
        DataSet dsVideoCollection;

        DataTable dtDirectors;
        DataTable dtVideoCatagories;
        DataTable dtRatings;
        DataTable dtActors;
        DataTable dtFormates;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsVideoCollection = new DataSet("Videos");
            dsVideoCollection.Tables.CollectionChanged += new CollectionChangeEventHandler(TableCollectionChanged);

            dtDirectors = new DataTable();   //allocate memory
            dtDirectors.TableName = "Directors";  //give a name
            dtVideoCatagories = new DataTable("Catagories");   //allocate memory and give a name

            dsVideoCollection.Tables.Add(dtDirectors);    //add datatable to data set
            dsVideoCollection.Tables.Add(dtVideoCatagories);
            dtRatings = dsVideoCollection.Tables.Add();        //another way
            dtActors = dsVideoCollection.Tables.Add("Actors");      //another way
            dtFormates = dsVideoCollection.Tables.Add("Formates");




            DataColumn[] colVideos = new DataColumn[7];

            colVideos[0] = new DataColumn("Title");
            colVideos[1] = new DataColumn("Director");
            colVideos[2] = new DataColumn("YearReleased");
            colVideos[3] = new DataColumn("Length");
            colVideos[4] = new DataColumn("Rating");
            colVideos[5] = new DataColumn("Format");
            colVideos[6] = new DataColumn("Category");

            DataTable dtVideos = new DataTable("Videos");
            dtVideos.Columns.AddRange(colVideos);

            dsVideoCollection = new DataSet("VideoCollection");
            dsVideoCollection.Tables.Add(dtVideos);

            for (int i = 0; i < dtVideos.Columns.Count; i++)
                lbxVideos.Items.Add(dtVideos.Columns[i].ColumnName);
        }

        private void TableCollectionChanged(object sender, CollectionChangeEventArgs e)
        {
            //MessageBox.Show("hello");
        }
    }
}
