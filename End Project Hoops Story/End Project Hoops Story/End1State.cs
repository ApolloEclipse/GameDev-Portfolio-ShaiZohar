using System;
using EndProjectHoopsStory;

public class End1State : GameState
{
    // Stores the player's name, used in the ending text
    private string playerName;

    // Constructor that initializes the player's name by calling the base class constructor
    public End1State(string playerName) : base(playerName)
    {
        this.playerName = playerName;
    }

    // Display method to show the ending text for this specific ending
    public override void Display()
    {
        // Clear previous text from the console
        Console.Clear();

        // Display the title of the ending
        Console.WriteLine();
        Console.WriteLine("Ending 1: " + playerName + " Died");
        Console.WriteLine();

        // Display the narrative text of the ending, incorporating the player's name
        Console.WriteLine(playerName + " was gone. The reality hit me like a sledgehammer, and all I could do was collapse next to his lifeless body. My hands trembled as I reached out, fingers brushing against his cooling skin. The tears came hard and fast, blurring my vision, but I didn’t care. I couldn’t tear my eyes away from him. The world had shrunk down to this single, unbearable moment.");
        Console.WriteLine();
        Console.WriteLine("\"" + playerName + "…\" I whispered, my voice cracking under the weight of the grief. There was nothing I could do, nothing anyone could do. He was gone, and we were alone. The jungle around us seemed to close in, its oppressive silence a cruel contrast to the chaos in my heart.");
        Console.WriteLine();
        Console.WriteLine("Malik and Daniel stood nearby, their faces pale, as if they were struggling to process what had just happened. None of us spoke. There were no words that could fill the void left by " + playerName + "’s death. I couldn’t wrap my head around it—how everything had gone so wrong, so fast.");
        Console.WriteLine();
        Console.WriteLine("As I wept, my body shaking with the force of it, I suddenly heard footsteps. Josh. I’d forgotten about him for a moment, but now, as he stepped closer, something in his posture caught my attention. He wasn’t grief-stricken or even stunned. He was… calm.");
        Console.WriteLine();
        Console.WriteLine("Too calm.");
        Console.WriteLine();
        Console.WriteLine("I lifted my head, wiping my eyes, and saw him standing there, a strange look on his face. He reached into his jacket and pulled out a knife—a long, jagged blade that glinted in the fading light. My breath caught in my throat. Where had that come from?");
        Console.WriteLine();
        Console.WriteLine("Josh let out a sigh, almost like he was disappointed, as he examined the knife. \"This job,\" he muttered, more to himself than to us. \"I swear, nothing ever goes according to plan.\"");
        Console.WriteLine();
        Console.WriteLine("\"Josh…\" I started, my voice weak, barely a whisper. But he wasn’t listening. He was lost in his own world, pacing slowly, the knife spinning lazily in his hand.");
        Console.WriteLine();
        Console.WriteLine("\"This wasn’t how it was supposed to be,\" Josh continued, his tone eerily conversational, like we were discussing the weather. \"We were supposed to be in and out—clean, simple. But no, it all had to go to hell.\"");
        Console.WriteLine();
        Console.WriteLine("Before any of us could react, Josh lunged. The knife flashed through the air, sinking into Malik’s chest. Malik gasped, his eyes wide with shock, before crumpling to the ground. Blood pooled around him, soaking into the earth.");
        Console.WriteLine();
        Console.WriteLine("\"No!\" I screamed, scrambling back in horror. But there was no escape. Josh turned to Daniel, who had frozen in place, too terrified to move. Another swift movement, and Daniel fell, clutching his throat as blood gushed between his fingers.");
        Console.WriteLine();
        Console.WriteLine("I was next. I knew it, but I couldn’t move. My legs wouldn’t obey, my mind too numb to process what was happening. Josh’s expression remained cold, detached, as he slowly advanced on me, the knife dripping with the blood of my friends.");
        Console.WriteLine();
        Console.WriteLine("\"This job,\" Josh repeated, shaking his head. \"It’s all just one big mess.\"");
        Console.WriteLine();
        Console.WriteLine("The last thing I felt was the cold steel of the blade as it pierced my chest, and then, mercifully, everything faded into darkness. The jungle, once so full of life, now seemed like a tomb, silent and unyielding, as it claimed us all.");
        Console.WriteLine();

        // Call the EndGame method to conclude the game
        EndGame();
    }

    // HandleInput method to capture any user input at the end of the game
    public override void HandleInput(string input, GameContext context)
    {
        // This method can handle input to allow the user to exit the game
        Console.WriteLine();
        Console.WriteLine("Game over. Press any key to exit.");
        Console.ReadKey(); // Wait for any key press
        Environment.Exit(0); // Exit the game
    }

    // Private method to conclude the game
    private void EndGame()
    {
        // Display the final game-over message and wait for the user to press any key before exiting
        Console.WriteLine();
        Console.WriteLine("Game over. Press any key to exit.");
        Console.ReadKey();
        Environment.Exit(0); // Exit the game
    }
}
