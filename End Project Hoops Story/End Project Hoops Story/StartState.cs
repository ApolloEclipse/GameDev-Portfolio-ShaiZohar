using EndProjectHoopsStory;

public class StartState : IGameState
{
    // This method is responsible for displaying the initial game prompt to the player.
    public void Display()
    {
        // Display the welcome message and options for the player.
        Console.WriteLine("Welcome to Danger Hoops: Survival Slam, are you ready to start the story?");
        Console.WriteLine("Enter 'start' to begin the game or 'quit' to end the game.");
    }

    // This method handles the player's input and transitions to the next game state based on the input.
    public void HandleInput(string input, GameContext context)
    {
        // Convert the input to lowercase to make the command case-insensitive.
        switch (input.ToLower())
        {
            case "start":
                // Prompt the player to enter their name.
                Console.WriteLine("Enter your name:");
                string playerName = Console.ReadLine();
                
                // Validate the player's name input.
                if (string.IsNullOrEmpty(playerName))
                {
                    Console.WriteLine("Invalid name. Please enter a valid name.");
                    return; // Exit the method without changing the state if the name is invalid.
                }

                // Transition to Chapter1State, passing the player's name to the next state.
                context.SetState(new Chapter1State(playerName));
                break;

            case "quit":
                // If the player chooses to quit, set the state to null, which likely ends the game loop.
                context.SetState(null);
                break;

            default:
                // If the player enters an invalid command, prompt them to enter a valid option.
                Console.WriteLine("Invalid input. Please enter 'start' to begin or 'quit' to end the game.");
                break;
        }
    }
}
