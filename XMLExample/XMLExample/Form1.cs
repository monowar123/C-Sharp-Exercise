using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using XMLExample.Classes;

namespace XMLExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadXMLFileAndFillCombos();
        }

        private void ReadXMLFileAndFillCombos()
        {
            try
            {
                string sStartupPath = Application.StartupPath;
                clsValidator objclsValidator = new clsValidator(sStartupPath + @"..\..\..\XMLFile1.xml",
                      sStartupPath + @"..\..\..\XMLFile1.xsd");
                if (objclsValidator.ValidateXMLFile()) 
                    return;
                XmlTextReader objXmlTextReader = new XmlTextReader(sStartupPath + @"..\..\..\XMLFile1.xml");
                string sName = "";
                while (objXmlTextReader.Read())
                {
                    switch (objXmlTextReader.NodeType)
                    {
                        case XmlNodeType.Element:
                            sName = objXmlTextReader.Name;
                            break;
                        case XmlNodeType.Text:
                            switch (sName)
                            {
                                case "BookName":
                                    cmbBookName.Items.Add(objXmlTextReader.Value);
                                    break;
                                case "ReleaseYear":
                                    cmbReleaseYear.Items.Add(objXmlTextReader.Value);
                                    break;
                                case "Publication":
                                    cmbPublication.Items.Add(objXmlTextReader.Value);
                                    break;
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            WriteXMLFileUsingValuesFromCombos();
        }

        private void WriteXMLFileUsingValuesFromCombos()
        {
            try
            {
                string sStartupPath = Application.StartupPath;
                XmlTextWriter objXmlTextWriter = new XmlTextWriter(sStartupPath + @"\selected.xml", null);
                objXmlTextWriter.Formatting = Formatting.Indented;
                objXmlTextWriter.WriteStartDocument();
                objXmlTextWriter.WriteStartElement("MySelectedValues");

                objXmlTextWriter.WriteStartElement("BookName");
                objXmlTextWriter.WriteString(cmbBookName.Text);
                objXmlTextWriter.WriteEndElement();

                objXmlTextWriter.WriteStartElement("ReleaseYear");
                objXmlTextWriter.WriteString(cmbReleaseYear.Text);
                objXmlTextWriter.WriteEndElement();

                objXmlTextWriter.WriteStartElement("Publication");
                objXmlTextWriter.WriteString(cmbPublication.Text);
                objXmlTextWriter.WriteEndElement();

                objXmlTextWriter.WriteEndElement();
                objXmlTextWriter.WriteEndDocument();

                objXmlTextWriter.Flush();
                objXmlTextWriter.Close();
                MessageBox.Show("The following file has been successfully created\r\n"
                    + sStartupPath
                    + @"\selected.xml", "XML", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
