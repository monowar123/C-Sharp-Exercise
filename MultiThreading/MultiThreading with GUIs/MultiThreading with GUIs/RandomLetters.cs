using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MultiThreading_with_GUIs
{
    public class RandomLetters
    {
        private static Random generator = new Random();
        private bool suspended = false;
        private Label output;
        private string threadName;

        public RandomLetters(Label label)
        {
            output = label;
        }

        private delegate void DisplayDalegate(char displayChar);

        private void DisplayCharacter(char displayChar)
        {
            output.Text = threadName + ": " + displayChar;
        }

        public void GenerateRandomCharacters()
        {
            threadName = Thread.CurrentThread.Name;
            while (true)
            {
                Thread.Sleep(generator.Next(1001));
                lock (this)
                {
                    while (suspended)
                    {
                        Monitor.Wait(this);
                    }
                }
                char displayChar = (char)(generator.Next(26) + 65);

                output.Invoke(new DisplayDalegate(DisplayCharacter), new object[] { displayChar });
            }
        }

        public void Toggle()
        {
            suspended = !suspended;
            output.BackColor = suspended ? Color.Red : Color.LightGreen;
            lock (this)
            {
                if (!suspended)
                {
                    Monitor.Pulse(this);
                }
            }
        }
    }
}
