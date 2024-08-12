using EndProjectHoopsStory;

public class Chapter5State : GameState
{
    // Constructor that initializes the player's name by calling the base class constructor.
    public Chapter5State(string playerName) : base(playerName) { }

    // Display method to show the content and options for Chapter 5.
    public override void Display()
    {
        Console.Clear(); // Clear the console for a fresh display
        Console.WriteLine("Chapter 5: The Poison");
        Console.WriteLine();
        Console.WriteLine("By the time the sun was high overhead, hunger clawed at us, making it impossible to ignore. We trudged through the jungle, each step heavier than the last. Our energy was draining fast, and desperation was starting to set in. That’s when Josh, one of the pilots, called out from a few yards away.");
        Console.WriteLine();
        Console.WriteLine("\"Hey, check this out!\" he said, pointing to a cluster of berries hanging from a low bush. They looked ripe and juicy, almost out of place in the middle of this unforgiving jungle.");
        Console.WriteLine();
        Console.WriteLine("\"Looks like we’ve got ourselves a snack,\" Josh said with a grin, plucking a few berries and holding them out to me. \"Go ahead, " + playerName + ". You’re our leader—why don’t you try them first?\"");
        Console.WriteLine();
        Console.WriteLine("Something about the way he said it put me on edge, but the gnawing hunger made it hard to think clearly.");
        Console.WriteLine();
        Console.WriteLine("I had to make a choice.");
        Console.WriteLine();
        Console.WriteLine("1. Eat the berries Josh found.");
        Console.WriteLine("2. Come up with another plan to deal with the hunger.");
        Console.WriteLine("3. Avoid the berries and keep searching.");
        Console.WriteLine();
    }

    // HandleInput method to process the player's choice and transition to the next chapter or a different state.
    public override void HandleInput(string input, GameContext context)
    {
        // Handle user input and display the chosen option's text
        switch (input.Trim())
        {
            case "1":
                Console.Clear();
                Console.WriteLine("Desperation—and maybe a little trust in Josh—pushed me to take the berries from his hand. I popped a few into my mouth, trying to ignore the nagging voice in the back of my mind. They tasted sweet at first, almost too sweet, but then a harsh bitterness followed, spreading like wildfire across my tongue.");
                Console.WriteLine();
                Console.WriteLine("Within moments, I felt a wave of dizziness crash over me. My vision blurred, and my stomach twisted in knots. That’s when it hit me: Lena wasn’t the only one out to get me. I stumbled back, my mind racing as I realized Josh had set me up. He wasn’t just a pilot—he was part of whatever had brought us down. I tried to shout a warning, but the words stuck in my throat. The world spun as I collapsed to the ground, the poison searing through my veins.");
                Console.WriteLine();
                Console.WriteLine("As the darkness closed in, one thought gripped me with cold clarity: I never saw it coming.");
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                // Transition to End1State (fatal ending)
                context.SetState(new End1State(playerName));
                break;

            case "2":
                Console.Clear();
                Console.WriteLine("The berries were tempting, but something about the way Josh was pushing them made my instincts scream caution. I eyed him, trying to keep my tone light but firm. \"You sure these are good, Josh? If you’re so confident, why don’t you have the first taste?\"");
                Console.WriteLine();
                Console.WriteLine("Josh hesitated, his smile faltering for just a moment. \"Come on, " + playerName + ", you’re the leader. You should go first,\" he said, trying to brush it off. But the unease in the group was palpable. Malik, Daniel, and Noa exchanged glances, and I could tell they were thinking the same thing I was—something wasn’t right.");
                Console.WriteLine();
                Console.WriteLine("\"How about you eat one, then we’ll all follow,\" I suggested, my voice hardening. The tension thickened as Josh’s eyes darted between us, realizing he was cornered.");
                Console.WriteLine();
                Console.WriteLine("His hand tightened around the berries, and in a flash, he spun on his heel and bolted into the jungle. \"Josh, get back here!\" I shouted, but he was fast—too fast. Malik and Daniel were quicker, though, and they tackled him to the ground before he could get far.");
                Console.WriteLine();
                Console.WriteLine("We dragged him back to the group, his breath coming in ragged gasps, his face pale. \"You were trying to set us up, weren’t you?\" Malik growled, holding him down as he struggled.");
                Console.WriteLine();
                Console.WriteLine("Josh’s silence said it all. The truth hung heavy in the air—he wasn’t on our side. We couldn’t trust him, not with our lives hanging by a thread. I stared down at the man who was supposed to be our pilot, a bitter taste in my mouth that had nothing to do with the berries.");
                Console.WriteLine();
                Console.WriteLine("\"We’re done here,\" I said quietly. \"We need to move, now.\"");
                Console.WriteLine();
                Console.WriteLine("The truth was out—Josh had tried to set us up. There was no way we could leave him loose to cause more trouble. We tied him up securely with some rope we’d salvaged from the wreckage, making sure he couldn’t slip free. \"You’re coming with us,\" I said, my voice cold and steady. \"But don’t think for a second we trust you.\"");
                Console.WriteLine();
                Console.WriteLine("With Josh bound and under constant watch, we left the berries behind, our focus now solely on getting out of this jungle alive. The stakes had never been higher, and we weren’t about to let our guard down. Whatever twisted game was being played, we were determined to survive it.");
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                // Transition to Chapter 6 (continuation)
                context.SetState(new Chapter6State(playerName));
                break;

            case "3":
                Console.Clear();
                Console.WriteLine("I stared at the berries, every instinct telling me to back off. \"Let’s keep moving,\" I said, stepping away from the bush. The others followed, their faces tight with hunger and exhaustion, but they trusted my gut.");
                Console.WriteLine();
                Console.WriteLine("We pressed on, and just when I thought we’d hit our limit, we stumbled upon a small stream. The water was clear, and fish darted through the shallows. With some effort, we managed to catch enough to satisfy our gnawing hunger.");
                Console.WriteLine();
                Console.WriteLine("As we sat by the stream, cooking our makeshift meal, I glanced at the others. \"Well,\" I said with a grin, \"I guess sushi’s on the menu after all. Just don’t expect any soy sauce.\"");
                Console.WriteLine();
                Console.WriteLine("The joke drew a few tired chuckles, and for a moment, the weight of our situation lifted. After eating, as we rested by the stream, my eyes caught something on the horizon—a faint, flickering light in the distance. It wasn’t much, but it was something.");
                Console.WriteLine();
                Console.WriteLine("\"Looks like we might not be as lost as we thought,\" I said, nodding toward the distant signal. The sight of that signal gave us the energy we needed to push forward, a renewed sense of hope guiding us through the thick jungle. We knew we weren’t out of danger yet, but with every step, the possibility of rescue felt more real.");
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                // Transition to End2State (positive ending)
                context.SetState(new End2State(playerName));
                break;

            default:
                Console.Clear();
                Console.WriteLine("Invalid input. Please choose a valid option.");
                Console.WriteLine();
                // Wait for the user to press Enter to re-display options
                Console.WriteLine("Press Enter to try again...");
                Console.ReadLine();
                Display(); // Redisplay the options
                break;
        }
    }
}
