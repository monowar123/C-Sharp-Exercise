using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card_Shuffling
{
    public class Card
    {
        public string face;
        public string suit;
        public Card(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }
        public override string ToString()
        {
            return face + " of " + suit;
        }
    }
}
