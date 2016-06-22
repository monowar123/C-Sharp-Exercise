using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards myDeckOfCards = new DeckOfCards();
            myDeckOfCards.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Console.Write("{0,-19}", myDeckOfCards.DealCard());
                if ((i + 1) % 4 == 0)
                    Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
