using EndProjectHoopsStory;

public class Chapter3_1State : GameState
{
    // Constructor that initializes the player's name by calling the base class constructor.
    public Chapter3_1State(string playerName) : base(playerName) { }

    // Display method to show the content and options for this specific state where the protagonist faces the tiger.
    public override void Display()
    {
        Console.Clear(); // Clear the console for a fresh display
        Console.WriteLine("There was no time to think—only to act.");
        Console.WriteLine("I spotted a piece of wreckage—a long, jagged metal rod—and snatched it up, feeling its weight in my hand.");
        Console.WriteLine("Stepping forward, I squared my shoulders and locked eyes with the others.");
        Console.WriteLine("\"Stay back,\" I ordered, my voice steady despite the fear clawing at my insides. \"I’ve got this.\"");
        Console.WriteLine();
        Console.WriteLine("The tiger emerged from the shadows, its eyes burning like embers in the firelight.");
        Console.WriteLine("My heart pounded so hard I could feel it in my throat, but I forced myself to stay calm, gripping the rod until my knuckles turned white.");
        Console.WriteLine("\"Alright, big guy,\" I muttered under my breath, bracing for the fight of my life. \"Let’s see what you’ve got.\"");
        Console.WriteLine();
        Console.WriteLine("I forced a grin, trying to keep my nerves in check.");
        Console.WriteLine("\"And here I thought the toughest challenge this week would be our next practice drill.\"");
        Console.WriteLine();
        Console.WriteLine("But inside, my thoughts were racing.");
        Console.WriteLine("A tiger—of all the things that could’ve gone wrong today, now I had to fight a freaking tiger.");
        Console.WriteLine("I knew I was strong, but this was a whole different kind of beast.");
        Console.WriteLine("The tiger’s eyes locked onto mine, a low growl rumbling from its chest.");
        Console.WriteLine("Its muscles rippled as it prepared to lunge. There was no time to think—only to act.");
        Console.WriteLine();
        Console.WriteLine("The beast’s claws sliced through the air as it charged, and I had to think fast.");
        Console.WriteLine();
        Console.WriteLine("1. Dodge to the right, avoiding the claws.");
        Console.WriteLine("2. Swing the rod directly at the tiger’s head.");
        Console.WriteLine("3. Jump left to create more distance.");
        Console.WriteLine();
    }

    // HandleInput method to process the player's choice and transition to the next part of the story.
    public override void HandleInput(string input, GameContext context)
    {
        // Clear the console for a fresh display of the chosen option's text
        Console.Clear();

        // Handle user input and display the chosen option's text
        switch (input.Trim())
        {
            case "1":
                Console.WriteLine("I threw myself to the right, feeling the rush of air as the tiger’s claws sliced through the space where I’d just been. My heart was hammering as I realized just how close I’d come to being shredded. I spun back around, gripping the rod tighter, and swung in a wide arc. The metal connected with the tiger’s shoulder, the impact sending a shockwave up my arms.");
                Console.WriteLine();
                Console.WriteLine("It roared in fury, wheeling around to face me again, its eyes blazing with renewed anger. \"Not bad for a warm-up, huh?\" I quipped, trying to mask the fear bubbling up inside me. But deep down, I knew I was in for the fight of my life.");

                // Transition to the next state in the story sequence
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                context.SetState(new Chapter3_2State(playerName));
                break;

            case "2":
                Console.WriteLine("I swung the rod with all my might, aiming for the tiger’s head. The metal connected with a dull thud, momentarily stunning the beast. It shook its head, disoriented, and for a split second, I felt a flicker of hope. Maybe, just maybe, I could actually take this thing down.");
                Console.WriteLine();
                Console.WriteLine("But then it let out a furious roar, its eyes narrowing as it locked onto me again. My heart sank. So much for getting off easy. I gritted my teeth, preparing for its next move. \"Alright, let’s see if you’re as tough as you look,\" I muttered, trying to psych myself up, though my hands were trembling slightly.");

                // Wait for the user to press Enter to continue to the next chapter
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                context.SetState(new Chapter3_2State(playerName));
                break;

            case "3":
                Console.WriteLine("I leaped to the left, putting some distance between us. The tiger snarled, clearly frustrated by the sudden gap. \"Not so fast,\" I breathed, grateful for the extra space to think. I adjusted my grip on the rod, trying to steady my nerves. This wasn’t just about surviving—it was about making sure I didn’t become this beast’s dinner.");
                Console.WriteLine();
                Console.WriteLine("I could feel my heart racing, each beat echoing in my ears as I prepared for the next attack. The tiger was sizing me up, its tail flicking back and forth as it planned its next move. \"Come on, kitty,\" I muttered under my breath. \"Let’s dance.\"");

                // Wait for the user to press Enter to continue to the next chapter
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                context.SetState(new Chapter3_2State(playerName));
                break;

            default:
                // Handle invalid input
                Console.WriteLine("Invalid input. Please choose a valid option.");
                return;
        }
    }
}
