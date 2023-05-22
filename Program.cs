// using System;

// Main(); //Call the Main method

//     void Main()
//     {
//         //Display welcome message
//         Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
//         Console.WriteLine("--------------------------------------------");
//         Console.WriteLine();

//         // Let the moose speak!
//         MooseSays("H I, I'M  E N T H U S I A S T I C !");
//         MooseSays("I really am enthusiastic");
//         // Ask questions and display responses
//         AskQuestion("Is Canada real?", "Really? It seems very unlikely.", "I K N E W I T !!!");
//         AskQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
//         AskQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
//         AskQuestion("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
//     }

//     void AskQuestion(string question, string positiveResponse, string negativeResponse)
//     {
//         bool answer = MooseAsks(question);
//         // display response based on answer
//         if (answer)
//         {
//             MooseSays(positiveResponse);
//         }
//         else
//         {
//             MooseSays(negativeResponse);
//         }
//     }

//     bool MooseAsks(string question)
//     {
//         // get user input
//         Console.Write($"{question} (Y/N): ");
//         string answer = Console.ReadLine().ToLower();
//         // validate the answer and prompt again if invalid
//         while (answer != "y" && answer != "n")
//         {
//             Console.Write($"{question} (Y/N): ");
//             answer = Console.ReadLine().ToLower();
//         }
//         // Return true if the answer is "y", otherwise false
//         return answer == "y";
//     }

//     void MooseSays(string message)
//     {
//         Console.WriteLine($@"
//                                       _.--^^^--,
//                                     .'          `\
//   .-^^^^^^-.                      .'              |
//  /          '.                   /            .-._/
// |             `.                |             |
//  \              \          .-._ |          _   \
//   `^^'-.         \_.-.     \   `          ( \__/
//         |             )     '=.       .,   \
//        /             (         \     /  \  /
//      /`               `\        |   /    `'
//      '..-`\        _.-. `\ _.__/   .=.
//           |  _    / \  '.-`    `-.'  /
//           \_/ |  |   './ _     _  \.'
//                '-'    | /       \ |
//                       |  .-. .-.  |
//                       \ / o| |o \ /
//                        |   / \   |    {message}
//                       / `^`   `^` \
//                      /             \
//                     | '._.'         \
//                     |  /             |
//                      \ |             |
//                       ||    _    _   /
//                       /|\  (_\  /_) /
//                       \ \'._  ` '_.'
//                        `^^` `^^^`
//     ");
//     }



using System;

class MagicMoose
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Magic Moose!"); // Display welcome message
        Console.WriteLine("Ask the Magic Moose any question, or hit ENTER to exit."); // Prompt the user

        string question = GetQuestionFromUser(); // Get the first question from the user

        while (!string.IsNullOrWhiteSpace(question)) // Continue the loop until an empty question is entered
        {
            string response = GetRandomResponse(); // Generate a random response
            Console.WriteLine("Magic Moose says: " + response); // Display the response
            Console.WriteLine();

            question = GetQuestionFromUser(); // Get the next question from the user
        }

        Console.WriteLine("Goodbye!"); // Display goodbye message
    }

    static string GetQuestionFromUser()
    {
        Console.Write("Your question: "); // Prompt the user to enter a question
        return Console.ReadLine(); // Read and return the entered question
    }

    static string GetRandomResponse()
    {
        string[] responses =
        {
            "As I see it, yes.",
            "Ask again later.",
            "Better not tell you now.",
            "Cannot predict now.",
            "Concentrate and ask again.",
            "Don’t count on it.",
            "It is certain.",
            "It is decidedly so.",
            "Most likely.",
            "My reply is no.",
            "My sources say no.",
            "Outlook not so good.",
            "Outlook good.",
            "Reply hazy, try again.",
            "Signs point to yes.",
            "Very doubtful.",
            "Without a doubt.",
            "Yes.",
            "Yes – definitely.",
            "You may rely on it."
        };

        Random random = new Random(); // Create a new instance of Random class
        int index = random.Next(responses.Length); // Generate a random index within the range of the responses array
        return responses[index]; // Return the randomly selected response
    }
}




