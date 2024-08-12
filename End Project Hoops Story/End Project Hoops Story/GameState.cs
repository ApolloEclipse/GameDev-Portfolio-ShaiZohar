using EndProjectHoopsStory;

public abstract class GameState : IGameState
{
    // Protected field to store the player's name. This will be accessible to derived classes.
    protected string playerName;

    // Constructor to initialize the player's name. This constructor will be called by derived classes.
    protected GameState(string playerName)
    {
        this.playerName = playerName;
    }

    // Abstract method to display the current state. Each derived class must provide its own implementation.
    public abstract void Display();

    // Abstract method to handle user input. Each derived class must provide its own implementation.
    public abstract void HandleInput(string input, GameContext context);
}
