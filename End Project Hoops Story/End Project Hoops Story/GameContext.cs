using System;

namespace EndProjectHoopsStory
{
    public class GameContext
    {
        // Property to hold the current state of the game. It is private set, meaning it can only be modified within this class.
        public IGameState CurrentState { get; private set; }

        // Method to change the state of the game. Accepts an object that implements the IGameState interface.
        public void SetState(IGameState newState)
        {
            // Set the current state to the new state provided.
            CurrentState = newState;
        }

        // The main game loop that runs as long as the CurrentState is not null.
        public void Run()
        {
            // Loop while the game has an active state.
            while (CurrentState != null)
            {
                // Display the current state's content to the player.
                CurrentState.Display();

                // Get the player's input.
                string input = Console.ReadLine();

                // Pass the input to the current state's HandleInput method, along with the game context.
                CurrentState.HandleInput(input, this);
            }
        }
    }
}
