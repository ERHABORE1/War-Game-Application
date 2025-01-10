
using War_Game_Project;
namespace War_Game_App.Services
{
    /// <summary>
    /// Interface for managing core game data.
    /// </summary>
    public interface ICardWarService
    {
        /// <summary>
        /// Player hands in the game.
        /// </summary>
        PlayerHands PlayerHands { get; set; }

        /// <summary>
        /// Cards played in the current round.
        /// </summary>
        PlayedCards PlayedCards { get; set; }

        /// <summary>
        /// Number of players in the game.
        /// </summary>
        int PlayerCount { get; set; }
    }
}
