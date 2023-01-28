using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Blackjack.Models;

namespace Blackjack.Models
{
    public class Deck
    {
        private List<Card> _cards;

        // Constructor for the Deck class
        public Deck()
        {
            _cards = new List<Card>();

            //populate the deck with cards
            foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
            {
                foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
                {
                    var image = Image.FromFile($"images/{suit.ToString()}.png");
                    _cards.Add(new Card(suit, rank, image));
                }
            }
        }

        // Method to shuffle the deck
        public void Shuffle()
        {
            Random rng = new Random();

            int n = _cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = _cards[k];
                _cards[k] = _cards[n];
                _cards[n] = value;
            }
        }

        // Method to draw a card from the deck
        public Card DrawCard()
        {
            Card drawnCard = _cards[0];
            _cards.RemoveAt(0);
            return drawnCard;
        }
    }

}
