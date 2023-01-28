using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Blackjack.Models
{
    public class Card
    {
        // Enumeration for the suit of the card
        public enum Suit { Hearts, Diamonds, Spades, Clubs };
        // Enumeration for the rank of the card
        public enum Rank { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace };

        public Suit suit { get; set; }  //property to hold suit of card
        public Rank rank { get; set; }  //property to hold rank of card
        public Image cardImage { get; set; } //property to hold image of card
        public int Value { get; set; } // added property
        // Constructor for the card class
       public Card(Suit suit, Rank rank, Image cardImage) 
        {
            this.suit = suit;
            this.rank = rank;
            this.cardImage = cardImage;
            Value = (int)rank; // added value assignment
        }

        // Method to get the value of the card
        public int GetCardValue()
        {
            if (this.rank == Rank.Ace)
                return 11;
            else if (this.rank == Rank.Jack || this.rank == Rank.Queen || this.rank == Rank.King)
                return 10;
            else
                return (int)this.rank;
        }
    }
}
