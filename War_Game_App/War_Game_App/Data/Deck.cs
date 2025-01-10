using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Game_Project
{
    /// <summary>
    /// Represents a deck of cards with functionalities to create, shuffle, and distribute cards.
    /// </summary>
    public class Deck
    {
        /// <summary>
        /// The stack representing the deck of cards.
        /// </summary>
        public Stack<Card> cardDeck;

        /// <summary>
        /// Creates a deck with 52 randomly generated cards. May contain duplicates.
        /// </summary>
        public void createdeck()
        {
            cardDeck = new Stack<Card>();
            int s_count = Enum.GetValues(typeof(Suit)).Length;
            int r_count = Enum.GetValues(typeof(Rank)).Length;

            while (cardDeck.Count < 52)
            {
                Card newcard = new Card();
                var random = new Random();
                int s_int = random.Next(0, s_count);
                int r_int = random.Next(0, r_count);
                newcard.Suit = (Suit)s_int;
                newcard.Rank = (Rank)r_int;

                cardDeck.Push(newcard);
            }
        }

        /// <summary>
        /// Displays the current count of cards in the deck.
        /// </summary>
        public void checkdecksize()
        {
            Console.WriteLine(cardDeck.Count());
        }

        /// <summary>
        /// Returns the current count of cards in the deck.
        /// </summary>
        /// <returns>The number of cards in the deck.</returns>
        public int decksize()
        {
            return cardDeck.Count();
        }

        /// <summary>
        /// Displays each card in the deck without modifying the deck.
        /// </summary>
        public void view()
        {
            Stack<Card> holder = new Stack<Card>();
            while (cardDeck.Count > 0)
            {
                Card p_card = cardDeck.Pop();
                Console.WriteLine($"{p_card.Rank} of {p_card.Suit}");
                holder.Push(p_card);
            }
            while (holder.Count > 0)
            {
                Card p_card = holder.Pop();
                cardDeck.Push(p_card);
            }
        }

        /// <summary>
        /// Distributes a card from the deck by removing and returning the top card.
        /// </summary>
        /// <returns>The top card from the deck, or null if the deck is empty.</returns>
        public Card distribute()
        {
            if (cardDeck.Count > 0)
            {
                return cardDeck.Pop();
            }
            return null;
        }

        private static readonly Random rand = new Random();

        /// <summary>
        /// Shuffles the deck by randomly rearranging the cards.
        /// </summary>
        public void Shuffle()
        {
            List<Card> unshuffledcard = new List<Card>(cardDeck);

            for (int i = 0; i < 52; i++)
            {
                int r = rand.Next(0, unshuffledcard.Count - 1);
                Card temp = unshuffledcard[r];
                unshuffledcard[r] = unshuffledcard[i];
                unshuffledcard[i] = temp;
            }
            cardDeck = new Stack<Card>(unshuffledcard);
        }

        /// <summary>
        /// Creates an instance of a hand (example method; not implemented).
        /// </summary>
        private void CreateHand()
        {
            Hand name = new Hand();
        }
    }
}

