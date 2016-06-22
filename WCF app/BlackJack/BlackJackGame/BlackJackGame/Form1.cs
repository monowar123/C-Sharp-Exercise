using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace BlackJackGame
{
    public partial class Form1 : Form
    {
        private ServiceReference1.BlackJackClient dealer;

        private string dealersCards;
        private string playersCards;

        private List<PictureBox> cardBoxes;

        private int currentPlayerCard;
        private int currentDealerCard;

        private ResourceManager pictureLibrary = Properties.Resources.ResourceManager;

        public enum GameStatus
        {
            PUSH,
            LOSE,
            WIN,
            BLACKJACK
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dealer = new ServiceReference1.BlackJackClient();

            //put picture boxes into card boxes
            cardBoxes = new List<PictureBox>();
            cardBoxes.Add(pictureBox1);
            cardBoxes.Add(pictureBox2);
            cardBoxes.Add(pictureBox3);
            cardBoxes.Add(pictureBox4);
            cardBoxes.Add(pictureBox5);
            cardBoxes.Add(pictureBox6);
            cardBoxes.Add(pictureBox7);
            cardBoxes.Add(pictureBox8);
            cardBoxes.Add(pictureBox9);
            cardBoxes.Add(pictureBox10);
            cardBoxes.Add(pictureBox11);
            cardBoxes.Add(pictureBox12);
            cardBoxes.Add(pictureBox13);
            cardBoxes.Add(pictureBox14);
            cardBoxes.Add(pictureBox15);
            cardBoxes.Add(pictureBox16);
            cardBoxes.Add(pictureBox17);
            cardBoxes.Add(pictureBox18);
            cardBoxes.Add(pictureBox19);
            cardBoxes.Add(pictureBox20);
            cardBoxes.Add(pictureBox21);
            cardBoxes.Add(pictureBox22);
        }

        private void DealerPlay()
        {
            //reveal dealer's second card
            string[] cards = dealersCards.Split('\t');
            DisplayCard(1, cards[1]);

            string nextCard;

            //while value of dealear's hand is below 17, he must take cards
            while (dealer.GetHandValue(dealersCards) < 17)
            {
                nextCard = dealer.DealCard();
                dealersCards += '\t' + nextCard;

                MessageBox.Show("Dealer takes a card.");
                DisplayCard(currentDealerCard, nextCard);
                ++currentDealerCard;
            }

            int dealersTotal = dealer.GetHandValue(dealersCards);
            int playersTotal = dealer.GetHandValue(playersCards);

            //if dealer busted, player win
            if (dealersTotal > 21)
            {
                GameOver(GameStatus.WIN);
            }
            else
            {
                //if dealer and player have not exceeded 21, higher score wins; equal score is a push.
                if (dealersTotal > playersTotal)
                    GameOver(GameStatus.LOSE);
                else if (playersTotal > dealersTotal)
                    GameOver(GameStatus.WIN);
                else
                    GameOver(GameStatus.PUSH);
            }
        }

        public void DisplayCard(int card, string cardValue)
        {
            //retrive appropriate picture box
            PictureBox displayBox = cardBoxes[card];

            //if string representing card is empty, set display box to display back of card
            if (string.IsNullOrEmpty(cardValue))
            {
                displayBox.Image = (Image)pictureLibrary.GetObject("back1");
                return;
            }

            //retrive face and suit value of card from cardvalue
            string face = cardValue.Substring(0, cardValue.IndexOf(' '));
            string suit = cardValue.Substring(cardValue.IndexOf(' ') + 1);

            char suitLetter;

            switch (Convert.ToInt32(suit))
            {
                case 0: //clubs
                    suitLetter = 'C';
                    break;
                case 1: // diamonds
                    suitLetter = 'D';
                    break;
                case 3: // hearts
                    suitLetter = 'H';
                    break;
                default:  //spades
                    suitLetter = 'S';
                    break;
            }

            //set display box to display appropriate image
            displayBox.Image = (Image)pictureLibrary.GetObject(suitLetter + face);
        }

        public void GameOver(GameStatus winner)
        {
            string[] cards = dealersCards.Split('\t');

            //display all the dealer's card
            for (int i = 0; i < cards.Length; i++)
            {
                DisplayCard(i, cards[i]);
            }

            //display appropriate status
            if (winner == GameStatus.PUSH)
                lblStatus.Text = "It's a tie!";
            else if (winner == GameStatus.LOSE)
                lblStatus.Text = "You Lose\nTry again";
            else if (winner == GameStatus.BLACKJACK)
                lblStatus.Text = "BLACKJACK!";
            else
                lblStatus.Text = "You Win!";

            //Display final point of dealer and player
            lblDealer.Text = "Dealer : " + dealer.GetHandValue(dealersCards);
            lblPlayer.Text = "Player : " + dealer.GetHandValue(playersCards);

            //reset control for new game
            btnDeal.Enabled = true;
            btnHit.Enabled = false;
            btnStay.Enabled = false;
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            string card;

            //clear card image
            foreach (PictureBox cardImage in cardBoxes)
                cardImage.Image = null;
            lblStatus.Text = string.Empty;
            lblDealer.Text = string.Empty;
            lblPlayer.Text = string.Empty;

            dealer.Shuffle();

            //deal two cards to player
            playersCards = dealer.DealCard();
            DisplayCard(11, playersCards);
            card = dealer.DealCard();
            DisplayCard(12, card);
            playersCards += '\t' + card;

            //deal two cards to dealer, only display face of first card
            dealersCards = dealer.DealCard();
            DisplayCard(0, dealersCards);
            card = dealer.DealCard();
            DisplayCard(1, string.Empty);
            dealersCards += '\t' + card;

            btnDeal.Enabled = false;
            btnHit.Enabled = true;
            btnStay.Enabled = true;

            //determine the value of the two hands
            int dealersTotal = dealer.GetHandValue(dealersCards);
            int playesTotal = dealer.GetHandValue(playersCards);

            if (dealersTotal == playesTotal && dealersTotal == 21)
                GameOver(GameStatus.PUSH);
            else if (dealersTotal == 21)
                GameOver(GameStatus.LOSE);
            else if (playesTotal == 21)
                GameOver(GameStatus.BLACKJACK);

            //next dealer card has index 2 in cardBoxes
            currentDealerCard = 2;
            //next player card has index 13 in cardBoxes
            currentPlayerCard = 13;
        }

        //deal another card to player
        private void btnHit_Click(object sender, EventArgs e)
        {
            string card = dealer.DealCard();
            playersCards += '\t' + card;

            DisplayCard(currentPlayerCard, card);
            ++currentPlayerCard;

            int total = dealer.GetHandValue(playersCards);

            if (total > 21)
                GameOver(GameStatus.LOSE);
            else if (total == 21)
            {
                btnHit.Enabled = false;
                DealerPlay();
            }
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            btnStay.Enabled = false;
            btnHit.Enabled = false;
            btnDeal.Enabled = true;

            DealerPlay();
        }
    }
}
