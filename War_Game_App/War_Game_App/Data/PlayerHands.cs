using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace War_Game_Project
{
    /// <summary>
    /// Manages the hands of cards for each player in the game.
    /// </summary>
    public class PlayerHands
    {
        /// <summary>
        /// A dictionary that associates each player's name with their hand of cards.
        /// </summary>
        public Dictionary<string, Hand> playerHands { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerHands"/> class.
        /// </summary>
        public PlayerHands()
        {
            playerHands = new Dictionary<string, Hand>();
        }

        /// <summary>
        /// Adds a new player with an empty hand.
        /// </summary>
        /// <param name="playerName">The name of the player to add.</param>
        public void addname(string playerName)
        {
            playerHands[playerName] = new Hand();
        }

        /// <summary>
        /// Adds a card to the specified player's hand.
        /// </summary>
        /// <param name="playerName">The name of the player.</param>
        /// <param name="card">The card to add to the player's hand.</param>
        public void addCard(string playerName, Card card)
        {
            if (playerHands.ContainsKey(playerName))
            {
                playerHands[playerName].getCard(card);
            }
        }
    }
}

