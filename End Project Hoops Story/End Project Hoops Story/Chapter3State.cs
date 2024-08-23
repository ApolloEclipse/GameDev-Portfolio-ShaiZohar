using EndProjectHoopsStory;

public class Chapter3State : GameState
{
    // Constructor that initializes the player's name by calling the base class constructor.
    public Chapter3State(string playerName) : base(playerName) { }

    // Display method to show the content and options for Chapter 3.
    public override void Display()
    {
        Console.Clear(); // Clear the console for a fresh display
        Console.WriteLine("Chapter 3: The Threat");
        Console.WriteLine();
        Console.WriteLine("Nightfall brought with it a new kind of terror.");
        Console.WriteLine();
        Console.WriteLine("The jungle around us seemed to come alive as the sun dipped below the horizon, the distant roars and cries of unseen animals setting my nerves on edge. We had managed to get a fire going, but it did little to ease the tension. The team huddled close, every crack of a branch sending a wave of unease through the group.");
        Console.WriteLine();
        Console.WriteLine("Then, a roar tore through the night—a deep, guttural sound that shook me to my core. \"A tiger,\" I whispered, more to myself than anyone else. Of all the places to crash, we had to end up in a jungle with tigers.");
        Console.WriteLine();
        Console.WriteLine("I forced a smirk, even though my heart was pounding. \"Great, and here I thought the only wild thing I’d be facing this week was Coach’s temper.\"");
        Console.WriteLine();
        Console.WriteLine("I had to make a choice.");
        Console.WriteLine();
        Console.WriteLine("1. Fight the tiger to protect the team.");
        Console.WriteLine("2. Suggest hiding and waiting for the tiger to pass.");
        Console.WriteLine("3. Propose using a flare to blind the tiger and make a quick escape.");
        Console.WriteLine();
    }

    // HandleInput method to process the player's choice and transition to the next chapter or a different state.
    public override void HandleInput(string input, GameContext context)
    {
        // Clear the console for a fresh display of the chosen option's text
        Console.Clear();

        // Handle user input and display the chosen option's text
        switch (input.Trim())
        {
            case "1":
                // Transition to a new state related to fighting the tiger (could lead to a specific outcome or end).
                Console.WriteLine("You decided to confront the tiger...");
                // Transition to the state where the player confronts the tiger directly.
                context.SetState(new Chapter3_1State(playerName)); // Assuming Chapter3_1State represents a specific outcome
                break;

            case "2":
                Console.WriteLine("I motioned for everyone to get back to the wreckage, pulling them into the shattered fuselage. \"Quiet,\" I whispered, barely daring to breathe. We huddled together, listening as the tiger prowled around outside, its heavy footsteps crushing the underbrush. I could feel every muscle in my body tensing, waiting for the moment it would try to break through.");
                Console.WriteLine();
                Console.WriteLine("But after what felt like an eternity, the sounds began to fade. The tiger had moved on, at least for now. I let out a breath I hadn’t realized I was holding. \"Looks like we’re not on the menu tonight,\" I said, my voice shaky but relieved.");
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine(); // Wait for the user to press Enter before proceeding

                // Proceed to the next chapter based on the choice, if applicable
                context.SetState(new Chapter4State(playerName)); // Assuming all choices except "1" lead to Chapter 4
                break;

            case "3":
                Console.WriteLine("We didn’t have much time, but I knew we needed a plan before that tiger emerged from the shadows. My eyes landed on the plane’s emergency kit, and an idea sparked. \"We need to blind it,\" I said, pulling out one of the flares. \"If we can confuse it long enough, we might be able to get away.\"");
                Console.WriteLine();
                Console.WriteLine("I quickly explained the plan. \"When I say go, I’ll light this flare and toss it right in front of the tiger. The bright light should throw it off, and that’ll be our chance to make a run for it.\"");
                Console.WriteLine();
                Console.WriteLine("The tension was thick as we waited, hearts pounding in the darkness. When I finally saw the tiger’s glowing eyes approaching through the trees, I knew it was now or never. \"Go!\" I shouted, striking the flare and tossing it onto the ground between us and the tiger.");
                Console.WriteLine();
                Console.WriteLine("The flare burst to life, its blinding red light illuminating the night. The tiger recoiled, its eyes narrowing in confusion as it let out a low growl. For a moment, it seemed caught between fear and instinct, unsure whether to advance or retreat.");
                Console.WriteLine();
                Console.WriteLine("\"Now, move!\" I urged the others, and we bolted away from the wreckage, using the flare’s light to guide us as we sprinted through the jungle. The tiger, too stunned by the sudden brightness, didn’t give chase.");
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine(); // Wait for the user to press Enter before proceeding

                // Proceed to the next chapter based on the choice, if applicable
                context.SetState(new Chapter4State(playerName)); // Assuming all choices except "1" lead to Chapter 4
                break;

            default:
                // Handle invalid input
                Console.WriteLine("Invalid input. Please choose a valid option.");
                return;
        }

        // Wait for the user to press Enter to continue to the next chapter

    }
}
