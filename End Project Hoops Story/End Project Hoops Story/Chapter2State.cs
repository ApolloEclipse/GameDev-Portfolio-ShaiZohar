using EndProjectHoopsStory;

public class Chapter2State : GameState
{
    // Constructor that initializes the player's name by calling the base class constructor.
    public Chapter2State(string playerName) : base(playerName) { }

    // Display method to show the content and options for Chapter 2.
    public override void Display()
    {
        Console.Clear(); // Clear the console for a fresh display
        Console.WriteLine("Chapter 2: The Crash");
        Console.WriteLine();
        Console.WriteLine("The impact was brutal.");
        Console.WriteLine();
        Console.WriteLine("One minute, we were hurtling through the air, and the next, we were ripping through the jungle canopy. The sound of metal screeching and trees snapping filled my ears, and then—silence. For a moment, I couldn’t move, couldn’t think. The world had gone eerily quiet, like the calm after a storm.");
        Console.WriteLine();
        Console.WriteLine("When I finally opened my eyes, I found myself slumped in my seat, bruised but alive. Around me, the rest of the team was stirring, groaning, checking each other for injuries. We were all battered, but miraculously, everyone had survived. I pushed myself up with a grunt, the adrenaline still pumping through my veins. \"Well,\" I said, forcing out the words, \"I guess we can cross 'plane crash' off the bucket list.\"");
        Console.WriteLine();
        Console.WriteLine("But there was no time to dwell on it. We needed to act.");
        Console.WriteLine();
        Console.WriteLine("I had to make a choice.");
        Console.WriteLine();
        Console.WriteLine("1. Check if anyone is injured.");
        Console.WriteLine("2. Scout the area for help.");
        Console.WriteLine("3. Search for supplies in the wreckage.");
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
                Console.WriteLine("The crash left my ears ringing and my vision blurred, but I knew I had to move. The first thing I did was check on the crew. The pilot and co-pilot were slumped over in their seats, unconscious but breathing. The flight attendant, a young woman whose name tag read \"Lena,\" was groaning as she tried to sit up, a nasty gash on her forehead. She gave me a dazed look, but she was tough—she’d make it.");
                Console.WriteLine("Turning around, I took in the scene. It was just me, Malik, and two other teammates—Daniel and Noa—on this private jet. We’d missed the main flight with the rest of the team because we were late getting back from a... let's just say, \"extended\" lunch. Coach Harris wasn’t exactly thrilled about it, but he’d grudgingly arranged this last-minute ride to Japan for us. I had a feeling he’d be even less thrilled to hear about this crash—if we ever got to tell him.");
                Console.WriteLine("That’s when I noticed Malik, clutching his wrist, his face twisted in pain. One glance told me everything—his hand was bent in a way that defied all anatomy classes. I tore off my jersey—the one with the mean Easter egg on it, to fashion a makeshift splint, trying to lighten the mood. \"Well, Malik, when Coach said to break them even if it breaks us, I don’t think he meant it this literally.\"");
                Console.WriteLine("He managed a weak smile, but I could see the fear in his eyes. We were stranded in the middle of nowhere, and there was no guarantee that help would find us anytime soon. I forced a grin. \"Well, at least we’re finally getting that team bonding Coach is always harping on about. Though, I could’ve done without the whole ‘survival mode’ twist.\"");
                break;

            case "2":
                Console.WriteLine("I needed to figure out where we were, so I left the wreckage behind and ventured into the thick jungle. Every step squelched in the damp, muddy ground, and the air was thick with humidity and the sounds of animals I couldn’t even name. Just as I was beginning to think I’d get lost out here, I spotted a thin column of smoke rising in the distance. My heart leapt, and I couldn’t help but smirk. \"Well, unless there’s a secret jungle barbecue, that smoke’s our best bet.\"");
                Console.WriteLine("With that bit of hope, I turned back toward the crash site. The thought of telling Coach Harris about all this crossed my mind, and I had to chuckle despite everything. \"He’s either gonna love this story or bench me for the rest of the season,\" I muttered, picking up the pace. The others needed to hear about that smoke—and fast.");
                break;

            case "3":
                Console.WriteLine("Supplies. We needed them, and fast, if we had any chance of making it through this. I sifted through the wreckage, tossing aside debris as I searched for anything that might help. After a few tense minutes, I struck gold—a first aid kit and some emergency rations. I couldn’t help but shake my head as I pocketed them. \"Who knew those tiny pretzels would actually come in handy?\" It wasn’t much, but it was better than nothing. And right now, that little bit was all we had.");
                break;

            default:
                // Handle invalid input
                Console.WriteLine("Invalid input. Please choose a valid option.");
                return;
        }

        // Wait for the user to press Enter to continue to the next chapter
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine(); // Wait for the user to press Enter before proceeding

        // Proceed to Chapter 3 by transitioning the game state
        context.SetState(new Chapter3State(playerName));
    }
}
