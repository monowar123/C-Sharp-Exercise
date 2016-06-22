using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MultiThreading_with_GUIs
{
    public partial class Form1 : Form
    {
        private RandomLetters letter1;
        private RandomLetters letter2;
        private RandomLetters letter3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            letter1 = new RandomLetters(label1);
            Thread firstThread = new Thread(new ThreadStart(letter1.GenerateRandomCharacters));
            firstThread.Name = "Thread 1";
            firstThread.Start();

            letter2 = new RandomLetters(label2);
            Thread secondThread = new Thread(new ThreadStart(letter2.GenerateRandomCharacters));
            secondThread.Name = "Thread 2";
            secondThread.Start();

            letter3 = new RandomLetters(label3);
            Thread thirdThread = new Thread(new ThreadStart(letter3.GenerateRandomCharacters));
            thirdThread.Name = "Thread 3";
            thirdThread.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == checkBox1)
                letter1.Toggle();
            else if (sender == checkBox2)
                letter2.Toggle();
            else if (sender == checkBox3)
                letter3.Toggle();
        }

    }
}
