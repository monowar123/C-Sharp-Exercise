using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
// the serialization is also accomplished by this namespace
using System.Runtime.Serialization.Formatters.Soap;

   /*   //soap is normally used for xml document
    * soap->: simple object access protocol.
    var fStream = new FileStream(txtSave.Text, FileMode.Create, FileAccess.Write);
    var sFormatter = new SoapFormatter();
    sFormatter.Serialize(fStream, vehicle);
    */

namespace SerializationBinary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            var vehicle = new Car();
            vehicle.Make = txtMake.Text;
            vehicle.Model = txtModel.Text;
            vehicle.Color = txtColor.Text;
            vehicle.Year = Convert.ToInt32(comboBox1.SelectedIndex);

            //normal binary writer
            var fStream = new FileStream("car1.car", FileMode.Create);
            var binWritter = new BinaryWriter(fStream);
            try
            {
                binWritter.Write(vehicle.Make);
                binWritter.Write(vehicle.Model);
                binWritter.Write(vehicle.Color);
                binWritter.Write(vehicle.Year.ToString());
            }
            catch
            {
                MessageBox.Show("There is something error");
            }
            finally
            {
                binWritter.Close();
                fStream.Close();
                foreach (Control guiControl in Controls)
                {
                    if (guiControl is TextBox)
                    {
                        ((TextBox)guiControl).Clear();
                    }
                }
                comboBox1.Update();
            }

            //Binary serialization code
            FileStream fStream2 = new FileStream("car2.car", FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(fStream2, vehicle);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //normal binary reader
            //var fStream = new FileStream("car1.car", FileMode.Open);
            //var binReader = new BinaryReader(fStream);

            //try
            //{
            //    var vehicle = new Car();
            //    vehicle.Make = binReader.ReadString();
            //    vehicle.Model = binReader.ReadString();
            //    vehicle.Color = binReader.ReadString();
            //    vehicle.Year = Convert.ToInt32(binReader.ReadString());

            //    txtMake.Text = vehicle.Make;
            //    txtModel.Text = vehicle.Model;
            //    txtColor.Text = vehicle.Color;
            //    comboBox1.SelectedIndex = vehicle.Year;
            //}
            //catch
            //{
            //    MessageBox.Show("There is an error");
            //}
            //finally
            //{
            //    binReader.Close();
            //    fStream.Close();
            //}

            //deserialization
            FileStream fStream2 = new FileStream("car2.car", FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            Car vehicle2 = new Car();
            vehicle2 = (Car)bFormatter.Deserialize(fStream2);

            txtMake.Text = vehicle2.Make;
            txtModel.Text = vehicle2.Model;
            txtColor.Text = vehicle2.Color;
            comboBox1.SelectedIndex = vehicle2.Year;
        }
    }
}
