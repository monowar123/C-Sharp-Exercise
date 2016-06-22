using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card_Shuffling
{
    public class DeckOfCards
    {
        private Card[] deck;     //deck is the card type object array........
        private int currentCard;
        private const int NUMBER_OF_CARDS = 52;
        private Random randomNumbers;
        public DeckOfCards()
        {
            string[] faces = { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            deck = new Card[NUMBER_OF_CARDS];
            currentCard = 0;
            randomNumbers = new Random();
            // assign value to the card type objects array..........
            for (int count = 0; count < deck.Length; count++)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
            }
        }

        public void Shuffle()
        {
            currentCard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = randomNumbers.Next(NUMBER_OF_CARDS);  //represent random number between 0 to 51

                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        public Card DealCard()
        {
            if (currentCard < deck.Length)      //initially  currentCard=0 and incremented by 1
                return deck[currentCard++];
            else
                return null;
        }
    }
}
