using EndProjectHoopsStory;

public class Chapter4State : GameState
{
    // A flag indicating whether the bomb (device) is kept by the protagonist
    public bool brokenBomb = false;

    // Constructor that initializes the player's name by calling the base class constructor.
    public Chapter4State(string playerName) : base(playerName) { }

    // Display method to show the content and options for Chapter 4.
    public override void Display()
    {
        Console.Clear(); // Clear the console for a fresh display
        Console.WriteLine("Chapter 4: The Discovery");
        Console.WriteLine();
        Console.WriteLine("The strange device continued to emit its eerie hum, and the mystery around it only grew deeper. We had to make a decision.");
        Console.WriteLine();
        Console.WriteLine("I had to make a choice.");
        Console.WriteLine();
        Console.WriteLine("1. Investigate the device further.");
        Console.WriteLine("2. Ignore it and focus on getting us out of here.");
        Console.WriteLine("3. Confront the group, suspecting sabotage.");
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
                Console.WriteLine("I crouched down, carefully turning the device over in my hands. The longer I examined it, the more certain I became—this wasn’t just a malfunction. The wires were deliberately tampered with. Someone wanted this plane to go down. A cold shiver ran down my spine as I pieced it together. \"Great,\" I muttered, feeling the weight of the situation settle over me. \"Looks like we’re not just lost—we’re targets.\"");
                Console.WriteLine();
                Console.WriteLine("I decided to keep the bomb, tucking it carefully into my pack. Who knows? It might come in handy later.");
                Console.WriteLine();
                brokenBomb = true; // Mark that the bomb is kept by the player
                Console.WriteLine("With the disturbing realization weighing heavily on me, I made my way back to the group, my mind racing with possibilities. But when I got there, something was immediately wrong. I scanned the group, counting heads—Malik, Daniel, Noa... but no Lena.");
                Console.WriteLine();
                Console.WriteLine("\"Where’s Lena?\" I asked, the unease in my gut intensifying. The others exchanged confused looks, each of them shrugging or shaking their heads. \"I thought she was with you,\" Malik said, his brow furrowing in concern.");
                Console.WriteLine();
                Console.WriteLine("\"No one saw her leave?\" I pressed, but the silence was all the answer I needed. There were no tracks, no sign of a struggle—Lena had simply vanished without a trace. The knot in my stomach tightened as the implications sank in.");
                Console.WriteLine();
                Console.WriteLine("Whatever was going on, it was clear we were in the middle of something far more dangerous than a simple plane crash. But I kept that thought to myself, not wanting to panic the others any more than they already were.");
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                // Transition to Chapter 5
                context.SetState(new Chapter5State(playerName));
                break;

            case "2":
                Console.Clear();
                Console.WriteLine("Whatever this device was, I wasn’t about to stick around and find out more. We had bigger priorities—like getting out of this jungle alive. I shoved the device aside, not wanting to waste any more time, and regrouped with the team. \"We’re heading toward that smoke signal,\" I said, my voice leaving no room for argument.");
                Console.WriteLine();
                Console.WriteLine("But as I scanned the group, something felt off. \"Where’s Lena?\" I asked, the realization hitting me like a ton of bricks. The others looked around, just as confused. There were no tracks, no signs of a struggle—she was simply gone. A cold knot formed in my stomach. Whatever was happening, it was far more sinister than we had imagined. Without another word, we pressed on toward the smoke signal, the sense of urgency now more intense than ever.");
                Console.WriteLine();
                Console.WriteLine("As we pushed through dense undergrowth, Lena’s unexplained disappearance gnawed at the back of my mind, I couldn’t shake the feeling that we were missing something important, something that might come back to haunt us.");
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                // Transition to End2State (assuming ignoring the device leads to an alternate ending)
                context.SetState(new End2State(playerName));
                break;

            case "3":
                Console.Clear();
                Console.WriteLine("The more I thought about it, the more my gut told me something was wrong—really wrong. I couldn’t shake the feeling that someone knew more than they were letting on. I grabbed the device and stormed back to the group. \"One of you knows what this is,\" I said, holding it up for everyone to see.");
                Console.WriteLine();
                Console.WriteLine("The tension was thick, the silence almost unbearable. I scanned their faces—Malik, Daniel, Noa—all looking as shocked as I felt. But Lena, the flight attendant, wouldn’t meet my eyes. Before I could say another word, she suddenly bolted, sprinting into the jungle.");
                Console.WriteLine();
                Console.WriteLine("For a moment, all we could do was stare, frozen in shock as she disappeared into the trees. It didn’t seem real. \"And here I was worried about wild animals,\" I muttered, half in disbelief, as the reality of what just happened started to sink in.");
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                // Transition to Chapter 5
                context.SetState(new Chapter5State(playerName));
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
