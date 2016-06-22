using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace API
{
    public partial class Form1 : Form
    {
        //[DllImport("User32.dll")]
        //public static extern void ListBox1.InsertItem(string a);
        //public static extern int MessageBox(int h, string m, string c, MessageBoxIcon i);

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_INFO
        {
            public uint dwOemId;
            public uint dwPageSize;
            public uint lpMinimumApplicationAddress;
            public uint lpMaximumApplicationAddress;
            public uint dwActiveProcessorMask;
            public uint dwNumberOfProcessors;
            public uint dwProcessorType;
            public uint dwAllocationGranularity;
            public uint dwProcessorLevel;
            public uint dwProcessorRevision;
        }

        [DllImport("kernel32")]
        static extern void GetSystemInfo(ref SYSTEM_INFO pSI);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox(0, "API messageBox", "API demo", MessageBoxIcon.Error);
            try
            {
                SYSTEM_INFO pSI = new SYSTEM_INFO();
                GetSystemInfo(ref pSI);

                
                MessageBox.Show(pSI.dwProcessorType.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
