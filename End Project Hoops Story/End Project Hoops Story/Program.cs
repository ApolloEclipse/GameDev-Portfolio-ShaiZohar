using System;

namespace EndProjectHoopsStory
{
    public class Program
    {
        // The entry point of the application. This is where the game starts.
        static void Main(string[] args)
        {
            // Create a new instance of the GameContext, which manages the game's state.
            GameContext context = new GameContext();

            // Set the initial state of the game to 'StartState'. This is where the game begins.
            context.SetState(new StartState());

            // Start the game loop. The context will manage the transition between states.
            context.Run();
        }
    }
}
