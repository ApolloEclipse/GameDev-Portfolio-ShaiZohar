using EndProjectHoopsStory;

public class Chapter6State : GameState
{
    // Constructor that initializes the player's name by calling the base class constructor.
    public Chapter6State(string playerName) : base(playerName) { }

    // Display method to show the content and options for Chapter 6.
    public override void Display()
    {
        Console.Clear(); // Clear the console for a fresh display
        Console.WriteLine("Chapter 6: The Confrontation");
        Console.WriteLine();
        Console.WriteLine("The sun was setting, casting long shadows through the dense jungle as we continued our march toward the distant signal. The tension in the group was thick enough to cut with a knife. Josh walked ahead, his hands bound tightly, with Malik and Daniel keeping a close watch on him. No one spoke, but I could see the doubt and fear in their eyes. We were all exhausted—physically and mentally—but something still didn’t add up.");
        Console.WriteLine();
        Console.WriteLine("My mind kept racing over everything that had happened: the bomb, Lena’s disappearance, the poisoned berries, and Josh’s sudden betrayal. It was all connected somehow, but I couldn’t quite put my finger on it. One thing was clear, though—someone wanted me dead.");
        Console.WriteLine();
        Console.WriteLine("As we walked, I found myself falling into step beside Josh. I had to know the truth.");
        Console.WriteLine();
        Console.WriteLine($"\"Josh,\" I began quietly, my voice steady despite the anger boiling beneath the surface, \"why us? What did we do to deserve this?\"");
        Console.WriteLine();
        Console.WriteLine("Josh didn’t answer right away. His eyes flicked to Malik and Daniel, who were watching him closely, and then back to me. I could see the wheels turning in his head, weighing his options. He knew he was outnumbered, out of tricks—almost out of time.");
        Console.WriteLine();
        Console.WriteLine("I had to make a choice.");
        Console.WriteLine();
        Console.WriteLine("1. Press Josh harder to make him talk.");
        Console.WriteLine("2. Threaten him, hoping fear will break him.");
        Console.WriteLine("3. Try to reason with Josh, appealing to whatever humanity he might have left.");
        Console.WriteLine();
    }

    // HandleInput method to process the player's choice and transition to the next chapter or a different state.
    public override void HandleInput(string input, GameContext context)
    {
        switch (input.Trim())
        {
            case "1":
                // Player chooses to press Josh harder
                Console.Clear();
                Console.WriteLine($"I stopped dead in my tracks, forcing Josh to turn and face me. \"You’re going to tell us everything,\" I said, my voice low but firm. \"Because if you don’t, I swear we’ll leave you here to fend for yourself.\"");
                Console.WriteLine();
                Console.WriteLine("Josh’s eyes darted around, panic setting in. He knew we weren’t bluffing. But instead of immediately breaking, he clammed up, his jaw set tight. I could see the fear in his eyes, but he was still holding out, hoping for some way to escape this.");
                Console.WriteLine();
                Console.WriteLine("I stepped closer, my patience wearing thin. \"You don’t want to make this harder than it needs to be,\" I warned, but Josh remained silent. The tension was thick, the jungle around us feeling oppressively silent, as if even the animals were waiting for what would happen next.");
                Console.WriteLine();
                Console.WriteLine("Finally, Malik had enough. He grabbed Josh by the collar and shoved him against a tree. \"Talk!\" he growled, the frustration in his voice mirroring what we all felt.");
                Console.WriteLine();
                Console.WriteLine("Josh winced but stayed stubbornly quiet. I could see Malik’s knuckles whitening as he tightened his grip, and for a moment, I worried this would end badly. But then I remembered something—Josh wasn’t exactly the bravest guy in the world. He was just trying to keep it together long enough to find a way out. Maybe a little humor would throw him off balance.");
                Console.WriteLine();
                Console.WriteLine($"\"Josh, come on,\" I said, stepping in and placing a hand on Malik’s shoulder to calm him down. \"You don’t really think you can just wait us out, do you? I mean, we’ve got nowhere else to be. Unless you’re really dying to see what’s on the lunch menu today—maybe some more of those delicious berries?\"");
                Console.WriteLine();
                Console.WriteLine("Josh’s eyes flicked to mine, and I saw a crack in his resolve. A tiny, nervous smile tugged at the corner of his mouth before he could stop it. Malik eased up slightly, and that was all it took.");
                Console.WriteLine();
                Console.WriteLine("\"Alright, alright!\" Josh finally blurted out, the pressure getting to him. \"I’ll talk.\"");
                Console.WriteLine();
                Console.WriteLine($"We let him go, and he slumped against the tree, defeated. \"It wasn’t supposed to go down like this,\" he admitted, his voice trembling. \"Lena and I were just supposed to take out the target—you, {playerName}. But when the bomb didn’t do the job, everything spiraled out of control. Now they’re waiting for us at that signal you saw—they’re expecting you.\"");
                Console.WriteLine();
                Console.WriteLine("\"Who’s behind this?\" I asked, keeping my tone sharp. \"Who wants me dead?\"");
                Console.WriteLine();
                Console.WriteLine("Josh shook his head. \"I don’t know exactly who. We were just given orders—someone powerful, someone who doesn’t want you around anymore.\"");
                Console.WriteLine();
                Console.WriteLine("The information hit hard, but at least now we had some answers. I glanced at Malik, Daniel, and Noa. We knew what we were up against—or at least, we had a better idea.");
                Console.WriteLine();
                Console.WriteLine($"\"We’re not going down without a fight,\" I said, determination hardening my voice. \"But right now, our priority is getting out of this jungle alive. We follow that signal, and if it leads us to them, we deal with it when we get there.\"");
                Console.WriteLine();
                Console.WriteLine("With that, we continued our march toward the distant signal, this time with a renewed sense of purpose. The jungle seemed less daunting now that we knew the end was in sight. We were tired, beaten down, but still standing—and that was enough.");
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                // Transition to End2State (positive ending)
                context.SetState(new End2State(playerName));
                break;

            case "2":
                // Player chooses to threaten Josh (leads to a different ending, likely darker)
                Console.Clear();
                Console.WriteLine("You threatened Josh, making him fear for his life...");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                // Transition to End3State (dark ending)
                context.SetState(new End3State(playerName));
                break;

            case "3":
                // Player chooses to reason with Josh
                Console.Clear();
                Console.WriteLine($"I slowed my pace, trying a different approach. \"Josh, I get it—you’re scared, you’re in over your head. But whatever’s going on, it’s bigger than you. If you tell us the truth, maybe we can all get out of this alive.\"");
                Console.WriteLine();
                Console.WriteLine("Josh looked at me, his expression wavering between fear and something like guilt. For a moment, I thought I was getting through to him. But then, something in his eyes shifted—an eerie calm settled over him.");
                Console.WriteLine();
                Console.WriteLine("Before I could react, Josh suddenly dropped to his knees, his head hanging low. \"I... I never wanted any of this,\" he mumbled, his voice trembling. \"I was just following orders. They said if I didn’t deliver, they’d come after my family.\"");
                Console.WriteLine();
                Console.WriteLine("I could see the desperation in his eyes, and for a moment, I felt a pang of sympathy. But there was no time for compassion now. We needed answers and a way out.");
                Console.WriteLine();
                Console.WriteLine($"\"Who gave the orders, Josh?\" I pressed, trying to keep my voice steady. \"And what do they want from us?\"");
                Console.WriteLine();
                Console.WriteLine("Josh took a shaky breath, his eyes darting around as if expecting someone to jump out at him. \"I don’t know all the details,\" he admitted, \"but I know they’re waiting for us at the signal. They want you, {playerName}. They’re planning something big—something that involves all of us.\"");
                Console.WriteLine();
                Console.WriteLine("His words hit me hard, but there was still a glimmer of hope. If we could reach the signal and find out what was really going on, maybe we could turn the situation around.");
                Console.WriteLine();
                Console.WriteLine($"\"Alright, Josh,\" I said, trying to reassure him. \"We’ll deal with this. But for now, you’re coming with us. If you try anything funny, I swear, you’ll regret it.\"");
                Console.WriteLine();
                Console.WriteLine("Josh nodded, his face pale but resigned. We continued our march toward the signal, our path lit by the fading light of the setting sun. Every step we took felt heavier, burdened by the knowledge that our true enemy was still out there, waiting.");
                Console.WriteLine();
                Console.WriteLine("As we walked, I couldn’t shake the feeling that we were walking into a trap. But there was no turning back now. We had to see this through to the end, no matter what it cost us.");
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                // Transition to End2State (positive ending)
                context.SetState(new End2State(playerName));
                break;

            default:
                // Handle invalid input
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }
    }
}
