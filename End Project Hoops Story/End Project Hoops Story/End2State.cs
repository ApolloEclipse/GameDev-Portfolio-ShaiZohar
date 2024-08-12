using EndProjectHoopsStory;

public class End2State : GameState
{
    // Constructor that initializes the player's name by calling the base class constructor
    public End2State(string playerName) : base(playerName) { }

    // Display method to show the narrative for Ending 2
    public override void Display()
    {
        Console.Clear(); // Clear the console for a fresh display
        Console.WriteLine("Ending 2: The Group is Rescued");
        Console.WriteLine();

        // Display the narrative text for the second ending
        Console.WriteLine("We pushed forward with every last bit of strength we had left, the distant signal growing closer with each step. The jungle had thrown everything it could at us—treachery, hunger, fear—but we had survived it all. Now, we were on the verge of escape.");
        Console.WriteLine();
        Console.WriteLine("Finally, we broke through the dense undergrowth and into a clearing. There, waiting for us, was a helicopter, its rotors spinning in the fading light. Relief washed over me as I saw the rescue team waving us in.");
        Console.WriteLine();
        Console.WriteLine("\"We made it,\" I breathed, almost in disbelief. We were safe.");
        Console.WriteLine();
        Console.WriteLine("As we climbed aboard, I couldn’t help but look back at the jungle we’d just escaped from. It had tried to break us, but we’d made it through—together. The weight of everything we had endured pressed down on me, but there was also a sense of victory. We had outlasted whatever twisted game was being played.");
        Console.WriteLine();
        Console.WriteLine("The helicopter lifted off, carrying us away from the nightmare. Malik, Daniel, and Noa slumped in their seats, exhaustion etched into their faces. But there was also a glimmer of hope in their eyes—we had survived.");
        Console.WriteLine();
        Console.WriteLine("As the jungle faded into the distance below us, I couldn’t shake the feeling that this wasn’t the end. So many questions still swirled in my mind—who had targeted us, and why? What had Lena’s true role been in all this? And who else might have been involved?");
        Console.WriteLine();
        Console.WriteLine("I glanced out the window, watching as the thick canopy of trees disappeared into the horizon. The relief of being rescued was real, but it was tainted by the unknown. We had escaped with our lives, but the mystery remained, a shadow lingering over the victory.");
        Console.WriteLine();
        Console.WriteLine("\"Looks like we’ll live to tell this story,\" I said quietly, though the unease in my chest lingered. The others nodded, but I could see they felt it too—the sense that this wasn’t truly over.");
        Console.WriteLine();
        Console.WriteLine("As the helicopter flew us to safety, I knew one thing for certain: the questions wouldn’t leave me alone. Even as we returned to the world we knew, the darkness of the jungle—and the secrets it held—would stay with me.");
        Console.WriteLine();
        Console.WriteLine("And someday, I would find the answers.");
        Console.WriteLine();
    }

    // HandleInput method to handle player input after the ending is displayed
    public override void HandleInput(string input, GameContext context)
    {
        // Prompt the player to press Enter to end the game
        Console.WriteLine("Press Enter to end the game...");
        Console.ReadLine();
        Environment.Exit(0); // Ends the game
    }
}
