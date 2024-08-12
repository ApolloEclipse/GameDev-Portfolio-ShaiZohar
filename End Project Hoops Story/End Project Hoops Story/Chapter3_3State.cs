using EndProjectHoopsStory;

public class Chapter3_3State : GameState
{
    // Constructor that initializes the player's name by calling the base class constructor.
    public Chapter3_3State(string playerName) : base(playerName) { }

    // Display method to show the content and options for this specific state where the protagonist faces the final stages of the battle with the tiger.
    public override void Display()
    {
        Console.Clear(); // Clear the console for a fresh display
        Console.WriteLine("Bloodied and furious, the tiger prepared for another assault, its eyes locking onto mine with a deadly determination. This was a battle of endurance now, and I knew I had to outlast it, no matter the cost.");
        Console.WriteLine();
        Console.WriteLine("1. Sidestep its charge and aim for the neck.");
        Console.WriteLine("2. Stand your ground and strike as it leaps.");
        Console.WriteLine("3. Feint to the left, then deliver a crushing blow to its skull.");
    }

    // HandleInput method to process the player's choice and transition to the next part of the story or to the game's ending.
    public override void HandleInput(string input, GameContext context)
    {
        // Clear console for a fresh display of the chosen option's text
        Console.Clear();

        // Handle user input and display the chosen option's text
        switch (input.Trim())
        {
            case "1":
                Console.WriteLine("As the tiger charged, I sidestepped, narrowly avoiding its snapping jaws. My heart was pounding in my chest, each beat a reminder of how close I was to losing this fight. With a quick pivot, I swung the rod toward its neck, aiming to weaken it further.");
                Console.WriteLine();
                Console.WriteLine("The rod connected with a sickening crunch, but the tiger wasn’t down yet. It stumbled, its breath coming in ragged gasps, and I could see the exhaustion in its eyes. But I wasn’t out of the woods—I had to stay alert, knowing one mistake could be my last. \"Stay down, damn it,\" I whispered, trying to catch my breath as the tension tightened in my chest.");
                Console.WriteLine();
                Console.WriteLine("With one final, desperate swing, I struck the beast across the head. It stumbled, its fierce eyes dimming, and with a final, earth-shaking crash, it collapsed to the ground. I stood there, panting, the metal slipping from my bloodied hand as the adrenaline started to fade.");
                Console.WriteLine();
                Console.WriteLine("But victory came at a price. My vision blurred, the pain overwhelming as I dropped to my knees. Blood poured from the deep gashes in my side and arm, staining the jungle floor. As the world began to slip away, I couldn’t help but think, with bitter irony, \"I always wanted to go out like a legend.\"");

                // Transition to End 1 (a likely fatal ending)
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                context.SetState(new End1State(playerName));
                break;

            case "2":
                Console.WriteLine("I planted my feet, refusing to back down. As the tiger leaped, its claws outstretched, I swung the rod with everything I had. The impact was bone-jarring, sending a shockwave through my entire body. The tiger staggered back, clearly hurt, but it wasn’t done yet.");
                Console.WriteLine();
                Console.WriteLine("It struggled to rise, its strength clearly waning, but I knew it still had fight left in it. \"Come on, just give up already,\" I panted, knowing that both of us were running on fumes. The battle wasn’t over, but the end was in sight—I just had to survive long enough to reach it.");
                Console.WriteLine();
                Console.WriteLine("With one final, desperate swing, I struck the beast across the head. It stumbled, its fierce eyes dimming, and with a final, earth-shaking crash, it collapsed to the ground. I stood there, panting, the metal slipping from my bloodied hand as the adrenaline started to fade.");
                Console.WriteLine();
                Console.WriteLine("But victory came at a price. My vision blurred, the pain overwhelming as I dropped to my knees. Blood poured from the deep gashes in my side and arm, staining the jungle floor. As the world began to slip away, I couldn’t help but think, with bitter irony, \"I always wanted to go out like a legend.\"");

                // Transition to End 1 (a likely fatal ending)
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                context.SetState(new End1State(playerName));
                break;

            case "3":
                Console.WriteLine("I feinted left, causing the tiger to overcommit to its charge. As it stumbled, I pivoted and swung the rod with everything I had, aiming for its skull. The blow connected, sending the tiger reeling, but it wasn’t enough to finish it off.");
                Console.WriteLine();
                Console.WriteLine("The beast let out a guttural growl, its body swaying as it struggled to stay upright. I could see it was close to its limit, but so was I. \"You just don’t know when to quit, do you?\" I muttered, bracing myself for what I hoped would be the final round.");
                Console.WriteLine();
                Console.WriteLine("With one final, desperate swing, I struck the beast across the head. It stumbled, its fierce eyes dimming, and with a final, earth-shaking crash, it collapsed to the ground. I stood there, panting, the metal slipping from my bloodied hand as the adrenaline started to fade.");
                Console.WriteLine();
                Console.WriteLine("But victory came at a price. My vision blurred, the pain overwhelming as I dropped to my knees. Blood poured from the deep gashes in my side and arm, staining the jungle floor. As the world began to slip away, I couldn’t help but think, with bitter irony, \"I always wanted to go out like a legend.\"");

                // Transition to End 1 (a likely fatal ending)
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                context.SetState(new End1State(playerName));
                break;

            default:
                Console.WriteLine("Invalid input. Please choose a valid option.");
                return;
        }
    }
}
