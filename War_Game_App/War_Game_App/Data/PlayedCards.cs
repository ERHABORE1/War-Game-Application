using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Game_Project
{
    /// <summary>
    /// Manages the cards played by each player in a single round.
    /// </summary>
    public class PlayedCards
    {
        /// <summary>
        /// A dictionary that stores each player's name and the card they played.
        /// </summary>
        public Dictionary<string, Card> playedCards;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayedCards"/> class.
        /// </summary>
        public PlayedCards()
        {
            playedCards = new Dictionary<string, Card>();
        }

        /// <summary>
        /// Adds or updates the card played by a player.
        /// </summary>
        /// <param name="playerName">The name of the player.</param>
        /// <param name="card">The card played by the player.</param>
        public void addCard(string playerName, Card card)
        {
            playedCards[playerName] = card;
        }
    }
}
