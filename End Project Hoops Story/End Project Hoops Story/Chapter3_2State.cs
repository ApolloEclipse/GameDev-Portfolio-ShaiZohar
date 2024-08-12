using EndProjectHoopsStory;

public class Chapter3_2State : GameState
{
    // Constructor that initializes the player's name by calling the base class constructor.
    public Chapter3_2State(string playerName) : base(playerName) { }

    // Display method to show the content and options for this specific state where the protagonist continues to face the tiger.
    public override void Display()
    {
        Console.Clear(); // Clear the console for a fresh display
        Console.WriteLine("The tiger, undeterred, gathered itself for another attack, its growl rumbling deep in its chest as it lunged toward me again.");
        Console.WriteLine();
        Console.WriteLine("1. Duck low to avoid its sweeping claws.");
        Console.WriteLine("2. Charge forward and jab the rod at its chest.");
        Console.WriteLine("3. Roll to the side and strike at its hind legs.");
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
                Console.WriteLine("I dropped low, feeling the wind rush over my head as the tiger’s claws whizzed just inches above. The adrenaline was pumping now, my thoughts a blur as I thrust the rod upward, catching the beast under its chin.");
                Console.WriteLine();
                Console.WriteLine("It yelped in pain, rearing back, and I realized I’d only bought myself a moment’s reprieve. The tiger wasn’t going to back down easily, and I wasn’t out of danger yet. \"Alright, it’s just you and me,\" I muttered, trying to keep my focus sharp as I prepared for its next move.");

                // Transition to the next state in the story sequence
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                context.SetState(new Chapter3_3State(playerName));
                break;

            case "2":
                Console.WriteLine("I rushed forward, driving the rod into the tiger’s chest with all the strength I could muster. The impact was solid, but the beast was quick to recover, its eyes narrowing as it locked onto me again. My breath came in ragged gasps as I backed away, realizing that my strike had barely slowed it down.");
                Console.WriteLine();
                Console.WriteLine("This wasn’t going to be easy—every hit only seemed to make it angrier. I knew I had to be smarter, faster. \"Yeah, just what I needed—a real workout,\" I muttered, feeling the weight of the situation settle over me. This tiger wasn’t just tough; it was relentless.");

                // Transition to the next state in the story sequence
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                context.SetState(new Chapter3_3State(playerName));
                break;

            case "3":
                Console.WriteLine("I rolled to the side, narrowly avoiding the beast’s claws as it pounced. My body ached from the sudden movement, but I ignored the pain and swung the rod at its hind legs. The blow landed solidly, forcing the tiger to stumble.");
                Console.WriteLine();
                Console.WriteLine("It let out a furious yowl, but quickly recovered, turning to face me with a renewed aggression. My pulse was racing, sweat dripping down my brow as I realized I’d only made it angrier. \"Just trying to keep you on your toes,\" I muttered, trying to lighten the tension, but my voice shook slightly as I prepared for its next move.");

                // Transition to the next state in the story sequence
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                context.SetState(new Chapter3_3State(playerName));
                break;

            default:
                // Handle invalid input
                Console.WriteLine("Invalid input. Please choose a valid option.");
                return;
        }
    }
}
