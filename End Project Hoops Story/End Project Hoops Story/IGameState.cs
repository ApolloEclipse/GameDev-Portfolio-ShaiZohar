// This interface represents the state of the game. Each state in the game must implement these methods.
using EndProjectHoopsStory;

public interface IGameState
{
    // This method is responsible for displaying the content of the current game state to the player.
    void Display();

    // This method handles the player's input and updates the game context accordingly.
    // The 'input' parameter represents the player's input, and 'context' is the current state of the game.
    void HandleInput(string input, GameContext context);
}
