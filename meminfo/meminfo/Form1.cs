using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace meminfo
{

    public partial class Form1 : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORYSTATUS
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public uint dwTotalPhys;
            public uint dwAvailPhys;
            public uint dwTotalPageFile;
            public uint dwAvailPageFile;
            public uint dwTotalVirtual;
            public uint dwAvailVirtual;
        }

        [DllImport("kernel32")]
        static extern void GlobalMemoryStatus(ref MEMORYSTATUS buf);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MEMORYSTATUS m = new MEMORYSTATUS();
            GlobalMemoryStatus(ref m);
            listBox1.Items.Add(m.dwTotalPhys);
        }
    }
}
