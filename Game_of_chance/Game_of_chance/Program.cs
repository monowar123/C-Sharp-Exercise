using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game_of_chance
{
    class Program
    {
        static void Main(string[] args)
        {
            Craps game = new Craps();
            game.Play();
            Console.ReadKey();
        }
    }
}
