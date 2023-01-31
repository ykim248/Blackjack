using System.Collections.Generic;

namespace Blackjack.Models
{
    public class Hand
    {
        public List<Card> Cards { get; set; } // List to hold the cards in the hand
        public int Value { get; set; } // The total value of the cards in the hand

        public Hand()
        {
            Cards = new List<Card>();
            Value = 0;
        }

        public void AddCard(Card card)
        {
            Cards.Add(card); // Add the card to the list of cards in the hand
            Value += card.Value; // Add the value of the card to the hand's total value
        }

        public void Clear()
        {
            Cards.Clear(); // Clear the list of cards in the hand
            Value = 0; // Reset the value of the hand
        }
        public int CalculateHandValue()
        {
            int total = 0;
            int aces = 0;
            //iterating through all the card in cards list
            foreach (var card in Cards)
            {
                if (card.Value == 1)
                {
                    aces++;
                }
                //Adding the value of all the cards
                total += card.Value;
            }
            //Checking if total is greater than 21 and aces are greater than 0
            while (total > 21 && aces > 0)
            {
                total -= 10; //Reducing the value of total by 10
                aces--;
            }
            return total;
        }
    }
}
