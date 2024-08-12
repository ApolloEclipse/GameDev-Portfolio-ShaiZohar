using EndProjectHoopsStory;

public class End3State : GameState
{
    // Constructor that initializes the player's name by calling the base class constructor
    public End3State(string playerName) : base(playerName) { }

    // Display method to show the narrative for Ending 3
    public override void Display()
    {
        // Display the title of the ending
        Console.WriteLine("Ending 3: Kidnapping");
        Console.WriteLine();

        // Display the narrative text for the third ending
        Console.WriteLine($"I stepped closer to Josh, my voice dropping to a dangerous whisper. \"You better start talking, Josh. Because if you don’t, I’ll make sure whatever they planned for me happens to you first.\"");
        Console.WriteLine();
        Console.WriteLine("Josh’s eyes widened, fear flashing across his face as he realized he was out of options. He opened his mouth to speak, but before a word could escape, a sharp crack echoed through the jungle—a gunshot.");
        Console.WriteLine();
        Console.WriteLine("Josh crumpled to the ground, blood pouring from a bullet wound in his chest. We barely had time to react before we heard footsteps approaching. Turning around, we saw Lena emerging from the shadows, a cold, detached look in her eyes. She wasn’t alone—a group of men, armed and dangerous, flanked her, their expressions just as ruthless.");
        Console.WriteLine();
        Console.WriteLine($"\"Sorry, {playerName},\" Lena said, her voice devoid of any emotion. \"You were never supposed to make it this far.\"");
        Console.WriteLine();
        Console.WriteLine("My heart pounded as I realized we were surrounded. Malik and Daniel tensed, but there was no way we could fight our way out of this. We were outnumbered, outgunned, and out of time.");
        Console.WriteLine();
        Console.WriteLine("Before we could make a move, the men were on us, binding our hands and forcing us to our knees. I tried to make eye contact with Lena, searching for some sign of remorse, but there was nothing there—just cold, hard resolve.");
        Console.WriteLine();
        Console.WriteLine("As they dragged us toward a waiting vehicle, the reality of our situation hit me like a ton of bricks. We weren’t getting rescued. We were being taken.");
        Console.WriteLine();
        Console.WriteLine("As the vehicle roared to life, carrying us deeper into the unknown, one thought pounded in my head: We weren’t out of the game yet.");
        Console.WriteLine();

        // Call the EndGame method to conclude the game
        EndGame();
    }

    // HandleInput method to capture any user input at the end of the game
    public override void HandleInput(string input, GameContext context)
    {
        // Since it's an end state, no further transitions occur.
        // However, we can handle input here to allow the user to exit the game.
        Console.WriteLine("Game over. Press any key to exit.");
        Console.ReadKey(); // Wait for any key press
        Environment.Exit(0); // End the game
    }

    // Private method to conclude the game
    private void EndGame()
    {
        // Display ending message and end game
        Console.WriteLine("Game over. Press any key to exit.");
        Console.ReadKey();
        Environment.Exit(0); // End the game
    }
}
