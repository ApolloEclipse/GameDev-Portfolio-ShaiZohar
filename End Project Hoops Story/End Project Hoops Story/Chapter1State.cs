using EndProjectHoopsStory;

public class Chapter1State : GameState
{
    // Constructor that initializes the player's name by calling the base class constructor.
    public Chapter1State(string playerName) : base(playerName) { }

    // Display method to show the content and options for Chapter 1.
    public override void Display()
    {
        Console.Clear(); // Clear the console for a fresh display
        Console.WriteLine("Chapter 1: The Malfunction");
        Console.WriteLine();
        Console.WriteLine("As our jet cut through the skies above the Pacific, I leaned back in my seat, trying to push aside the nerves I always felt before a big event. This time, though, it wasn’t just about basketball. Tokyo was waiting, and with it, a whole new chapter in my life. The fanfare, the cameras, the charity event—it was supposed to be another step toward solidifying my legacy. But as I stared out at the endless blue below, something gnawed at me, a feeling I couldn’t quite shake.");
        Console.WriteLine();
        Console.WriteLine("That’s when it happened.");
        Console.WriteLine();
        Console.WriteLine("The plane jolted so violently that I nearly hit my head on the seat before me. The cabin lights flickered, casting strange shadows across the worried faces of my teammates. A second later, the pilot’s voice crackled through the intercom, \"Ladies and gentlemen, we are experiencing technical difficulties. Please remain calm.\"");
        Console.WriteLine();
        Console.WriteLine("I forced a grin, trying to keep it light. \"Guess they’re out of peanuts,\" I said to Malik, but the look in his eyes told me he wasn’t buying it. Hell, neither was I. This wasn’t just turbulence. Something was seriously wrong.");
        Console.WriteLine();
        Console.WriteLine("I had to make a choice.");
        Console.WriteLine();
        Console.WriteLine("1. Rush to the cockpit.");
        Console.WriteLine("2. Stay seated and try to calm the team.");
        Console.WriteLine("3. Look out the window to assess the situation.");
        Console.WriteLine();
    }

    // HandleInput method to process the player's choice and transition to the next chapter.
    public override void HandleInput(string input, GameContext context)
    {
        // Clear console for a fresh display of the chosen option's text
        Console.Clear();

        // Handle user input and display the chosen option's text
        switch (input.Trim())
        {
            case "1":
                Console.WriteLine("Without a second thought, I unbuckled my seatbelt and sprinted toward the cockpit. My heart was pounding in my chest, but I forced a grin. \"I guess they could use a point guard up here,\" I muttered, yanking the door open.");
                Console.WriteLine("The scene inside was worse than I imagined. The pilot was drenched in sweat, his hands gripping the controls like a vice. \"We’re losing altitude fast!\" he shouted over the blaring alarms. \"Looks like a mechanical failure!\"");
                Console.WriteLine("All the humor drained out of me in an instant. This was real. And we were in serious trouble.");
                break;

            case "2":
                Console.WriteLine("I stayed where I was, feeling the weight of my teammates’ eyes on me. They needed me to keep it together, so I managed a small smile. \"Well, if this was the plan to skip practice, I’ve got to say it’s a bit extreme.\"");
                Console.WriteLine("A few chuckles, nervous but genuine. But as I looked around the cabin, I could see the fear tightening in their faces, and hear the whispers growing more frantic. I had to keep it together—for their sake and mine. Even as the plane continued its rapid descent, I knew my job was to keep them grounded, even if the world around us wasn’t.");
                break;

            case "3":
                Console.WriteLine("I leaned over and pressed my face against the window, searching for any clue as to what was going on. My heart sank when I saw it: smoke billowing from one of the engines. \"Uh, guys,\" I said, my voice betraying my unease. \"Looks like we’re about to make it to the evening news.\"");
                Console.WriteLine("I turned back to my teammates, trying to figure out our next move, but my mind kept drifting back to that thick, black smoke. This wasn’t just a minor issue —something was seriously wrong.");
                break;

            default:
                // Handle invalid input
                Console.WriteLine("Invalid input. Please choose a valid option.");
                return;
        }

        // Wait for the user to press Enter to continue to the next chapter
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();

        // Proceed to Chapter 2 by transitioning the game state
        context.SetState(new Chapter2State(playerName));
    }
}
