using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace API_playSound
{
    class Program
    {
        [DllImport("winmm.dll")]
        public static extern long PlaySound(string lpszName, long hModule, long dwFlags);

        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                long retval;
                string fname = "G:\\Bashi.wav";

                retval = PlaySound(fname, 0, 1); // it can only play .wav formate
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
