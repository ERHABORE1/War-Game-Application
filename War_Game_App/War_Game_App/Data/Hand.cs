using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Game_Project
{
    /// <summary>
    /// Represents a player's hand of cards, allowing for card drawing and adding.
    /// </summary>
    public class Hand
    {
        /// <summary>
        /// The queue of cards in the player's hand.
        /// </summary>
        public Queue<Card> cards;

        /// <summary>
        /// Initializes a new instance of the <see cref="Hand"/> class.
        /// </summary>
        public Hand()
        {
            cards = new Queue<Card>();
        }

        /// <summary>
        /// Adds a card to the player's hand.
        /// </summary>
        /// <param name="card">The card to add to the hand.</param>
        public void getCard(Card card)
        {
            cards.Enqueue(card);
        }

        /// <summary>
        /// Draws (removes and returns) the top card from the player's hand.
        /// </summary>
        /// <returns>The drawn card, or <c>null</c> if the hand is empty.</returns>
        public Card DrawCard()
        {
            if (cards.Count > 0)
            {
                return cards.Dequeue();
            }
            return null;
        }

        /// <summary>
        /// Gets the number of cards currently in the player's hand.
        /// </summary>
        /// <returns>The count of cards in the hand.</returns>
        public int handsize()
        {
            return cards.Count;
        }
    }
}
