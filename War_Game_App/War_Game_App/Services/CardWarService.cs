using War_Game_Project;

namespace War_Game_App.Services 
{
    /// <summary>
    /// Manages core game data for the 'War' card game.
    /// </summary>
    public class CardWarService : ICardWarService
    {
        /// <summary>
        /// Player hands in the game.
        /// </summary>
        public PlayerHands PlayerHands { get; set; } = new PlayerHands();

        /// <summary>
        /// Cards played in the current round.
        /// </summary>
        public PlayedCards PlayedCards { get; set; } = new PlayedCards();

        /// <summary>
        /// Number of players in the game.
        /// </summary>
        public int PlayerCount { get; set; }
    }
}
