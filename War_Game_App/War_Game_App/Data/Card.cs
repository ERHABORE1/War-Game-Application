using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Game_Project
{
    /// <summary>
    /// The suit of a card (Club, Diamond, Spade, Heart).
    /// </summary>
    public enum Suit
    {
        Club,
        Diamond,
        Spade,
        Heart
    }

    /// <summary>
    /// The rank of a card, ranging from Two to Ace.
    /// </summary>
    public enum Rank
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    /// <summary>
    /// Represents a playing card with a specific suit and rank.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// The suit of the card.
        /// </summary>
        public Suit Suit { get; set; }

        /// <summary>
        /// The rank of the card.
        /// </summary>
        public Rank Rank { get; set; }
    }
}

