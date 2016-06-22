using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BlackJackService
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession)]
    public class BlackJack : IBlackJack
    {
        //create persistent session deck of cards object
        List<string> deck = new List<string>();

        //deals card that has not yet been delt
        public string DealCard()
        {
            string card = deck[0];
            deck.RemoveAt(0);
            return card;
        }

        //creates and shuffles a deck of cards
        public void Shuffle()
        {
            Random randomObject = new Random();
            deck.Clear();

            //generate all possible cards
            for (int face = 1; face <= 13; face++)
                for (int suit = 0; suit <= 3; suit++)
                    deck.Add(face + " " + suit);

            //Shuffle the deck
            for (int i = 0; i < deck.Count; i++)
            {
                int newIndex = randomObject.Next(deck.Count - 1);
                string temp = deck[i];
                deck[i] = deck[newIndex];
                deck[newIndex] = temp;
            }
        }

        //computes value of hand
        public int GetHandValue(string delt)
        {
            string[] cards = delt.Split('\t');
            int total = 0;
            int face;
            int aceCount = 0;

            //loop through the cards in the hand
            foreach (var card in cards)
            {
                //get face of card
                face = Convert.ToInt32(card.Substring(0, card.IndexOf(' ')));

                switch (face)
                {
                    case 1: //if ace, increment aceCount
                        ++aceCount;
                        break;

                    case 11:
                    case 12:
                    case 13:
                        total += 10;
                        break;

                    default:
                        total += face;
                        break;
                }
            }

            //if there are any aces, calculate optimal total
            if (aceCount > 0)
            {
                if (total + 11 + aceCount - 1 <= 21)
                    total += 11 + aceCount - 1;
                else
                    total += aceCount;
            }


            return total;
        }
    }
}
