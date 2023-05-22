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



// using System;

// class MagicMoose
// {
//     static void Main()
//     {
//         Console.WriteLine("Welcome to the Magic Moose!"); // Display welcome message
//         Console.WriteLine("Ask the Magic Moose any question, or hit ENTER to exit."); // Prompt the user

//         string question = GetQuestionFromUser(); // Get the first question from the user

//         while (!string.IsNullOrWhiteSpace(question)) // Continue the loop until an empty question is entered
//         {
//             string response = GetRandomResponse(); // Generate a random response
//             Console.WriteLine("Magic Moose says: " + response); // Display the response
//             Console.WriteLine();

//             question = GetQuestionFromUser(); // Get the next question from the user
//         }

//         Console.WriteLine("Goodbye!"); // Display goodbye message
//     }

//     static string GetQuestionFromUser()
//     {
//         Console.Write("Your question: "); // Prompt the user to enter a question
//         return Console.ReadLine(); // Read and return the entered question
//     }

//     static string GetRandomResponse()
//     {
//         string[] responses =
//         {
//             "As I see it, yes.",
//             "Ask again later.",
//             "Better not tell you now.",
//             "Cannot predict now.",
//             "Concentrate and ask again.",
//             "Don’t count on it.",
//             "It is certain.",
//             "It is decidedly so.",
//             "Most likely.",
//             "My reply is no.",
//             "My sources say no.",
//             "Outlook not so good.",
//             "Outlook good.",
//             "Reply hazy, try again.",
//             "Signs point to yes.",
//             "Very doubtful.",
//             "Without a doubt.",
//             "Yes.",
//             "Yes – definitely.",
//             "You may rely on it."
//         };

//         Random random = new Random(); // Create a new instance of Random class
//         int index = random.Next(responses.Length); // Generate a random index within the range of the responses array
//         return responses[index]; // Return the randomly selected response
//     }
// }


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Let's play Rock-Paper-Scissors!"); // Display the initial message

//         int userScore = 0; // Variable to track the user's score
//         int computerScore = 0; // Variable to track the computer's score

//         while (userScore < 3 && computerScore < 3) // Loop until either player reaches a score of 3
//         {
//             Console.WriteLine("Choose: (1) Rock, (2) Paper, (3) Scissors"); // Prompt the user to make a choice
//             Console.Write("Your choice: ");
//             string userInput = Console.ReadLine(); // Read the user's input

//             if (int.TryParse(userInput, out int userChoice) && userChoice >= 1 && userChoice <= 3) // Validate and parse the user's choice
//             {
//                 int computerChoice = GetRandomChoice(); // Generate a random choice for the computer

//                 Console.WriteLine($"Computer chooses: {GetChoiceName(computerChoice)}"); // Display the computer's choice
//                 Console.WriteLine();
//                 DisplayArt(userChoice, computerChoice); // Display the ASCII art for the user's choice and the computer's choice
//                 Console.WriteLine();

//                 int result = GetRoundResult(userChoice, computerChoice); // Determine the result of the round

//                 if (result == 0) // If it's a tie
//                 {
//                     Console.WriteLine("It's a tie!");
//                 }
//                 else if (result == 1) // If the user wins
//                 {
//                     Console.WriteLine("You win this round!");
//                     userScore++; // Increment the user's score
//                 }
//                 else // If the computer wins
//                 {
//                     Console.WriteLine("Computer wins this round!");
//                     computerScore++; // Increment the computer's score
//                 }

//                 Console.WriteLine();
//                 Console.WriteLine($"Your score: {userScore}"); // Display the current scores
//                 Console.WriteLine($"Computer score: {computerScore}");
//                 Console.WriteLine("-------------------------------");
//             }
//             else
//             {
//                 Console.WriteLine("Invalid choice. Please enter a number from 1 to 3."); // Display an error message for an invalid choice
//             }
//         }

//         if (userScore == 3) // If the user wins the game
//         {
//             Console.WriteLine("YOU WIN!");
//         }
//         else
//         {
//             Console.WriteLine("YOU LOSE!"); // If the computer wins the game
//         }

//         Console.WriteLine("Game Over");
//     }

//     static int GetRandomChoice()
//     {
//         Random random = new Random(); // Create an instance of the Random class
//         return random.Next(1, 4); // Generate a random number between 1 and 3 (inclusive)
//     }

//     static string GetChoiceName(int choice)
//     {
//         switch (choice) // Map the choice number to the corresponding choice name
//         {
//             case 1:
//                 return "Rock";
//             case 2:
//                 return "Paper";
//             case 3:
//                 return "Scissors";
//             default:
//                 return string.Empty; // Return an empty string for an invalid choice
//         }
//     }

//     static int GetRoundResult(int userChoice, int computerChoice)
//     {
//         if (userChoice == computerChoice) // If the choices are the same, it's a tie
//         {
//             return 0; // Return 0 to represent a tie
//         }
//         else if ((userChoice == 1 && computerChoice == 3) || // Check the winning conditions for the user
//                  (userChoice == 2 && computerChoice == 1) ||
//                  (userChoice == 3 && computerChoice == 2))
//         {
//             return 1; // Return 1 to represent the user's win
//         }
//         else // If none of the above conditions are met, the computer wins
//         {
//             return -1; // Return -1 to represent the computer's win
//         }
//     }

//     static void DisplayArt(int userChoice, int computerChoice)
//     {
//         string userArt = GetArt(userChoice); // Get the ASCII art for the user's choice
//         string computerArt = GetArt(computerChoice); // Get the ASCII art for the computer's choice

//         Console.WriteLine("Your choice:");
//         Console.WriteLine(userArt); // Display the user's ASCII art
//         Console.WriteLine();

//         Console.WriteLine("Computer choice:");
//         Console.WriteLine(computerArt); // Display the computer's ASCII art
//         Console.WriteLine();
//     }

//     static string GetArt(int choice)
//     {
//         switch (choice) // Get the ASCII art based on the choice number
//         {
//             case 1: // Rock
//                 return @"
//     _______
// ---'   ____)
//       (_____)
//       (_____)
//       (____)
// ---.__(___)
// ";
//             case 2: // Paper
//                 return @"
//      _______
// ---'    ____)____
//            ______)
//           _______)
//          _______)
// ---.__________)
// ";
//             case 3: // Scissors
//                 return @"
//     _______
// ---'   ____)____
//           ______)
//        __________)
//       (____)
// ---.__(___)
// ";
//             default:
//                 return string.Empty; // Return an empty string for an invalid choice
//         }
//     }
// }


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine();

        MooseSays("H I, I'M  E N T H U S I A S T I C !");
        MooseSays("I really am enthusiastic");

        AskQuestion("Is Canada real?", "Really? It seems very unlikely.", "I K N E W I T !!!");
        AskQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
        AskQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will!");
        AskQuestion("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");

        Console.WriteLine("Let's play Rock-Paper-Scissors!");

        int userScore = 0;
        int computerScore = 0;

        while (userScore < 3 && computerScore < 3)
        {
            Console.WriteLine("Choose: (1) Rock, (2) Paper, (3) Scissors");
            Console.Write("Your choice: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int userChoice) && userChoice >= 1 && userChoice <= 3)
            {
                int computerChoice = GetRandomChoice();

                Console.WriteLine($"Computer chooses: {GetChoiceName(computerChoice)}");
                Console.WriteLine();
                DisplayArt(userChoice, computerChoice);
                Console.WriteLine();

                int result = GetRoundResult(userChoice, computerChoice);

                if (result == 0)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (result == 1)
                {
                    Console.WriteLine("You win this round!");
                    userScore++;
                }
                else
                {
                    Console.WriteLine("Computer wins this round!");
                    computerScore++;
                }

                Console.WriteLine();
                Console.WriteLine($"Your score: {userScore}");
                Console.WriteLine($"Computer score: {computerScore}");
                Console.WriteLine("-------------------------------");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 3.");
            }
        }

        if (userScore == 3)
        {
            Console.WriteLine("YOU WIN!");
        }
        else
        {
            Console.WriteLine("YOU LOSE!");
        }

        Console.WriteLine("Game Over");

        MagicMooseMain();
    }

    static void AskQuestion(string question, string positiveResponse, string negativeResponse)
    {
        bool answer = MooseAsks(question);

        if (answer)
        {
            MooseSays(positiveResponse);
        }
        else
        {
            MooseSays(negativeResponse);
        }
    }

    static bool MooseAsks(string question)
    {
        Console.Write($"{question} (Y/N): ");
        string answer = Console.ReadLine().ToLower();

        while (answer != "y" && answer != "n")
        {
            Console.Write($"{question} (Y/N): ");
            answer = Console.ReadLine().ToLower();
        }

        return answer == "y";
    }

    static void MooseSays(string message)
    {
        Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
    }

    static int GetRandomChoice()
    {
        Random random = new Random();
        return random.Next(1, 4);
    }

    static string GetChoiceName(int choice)
    {
        switch (choice)
        {
            case 1:
                return "Rock";
            case 2:
                return "Paper";
            case 3:
                return "Scissors";
            default:
                return string.Empty;
        }
    }

    static int GetRoundResult(int userChoice, int computerChoice)
    {
        if (userChoice == computerChoice)
        {
            return 0;
        }
        else if ((userChoice == 1 && computerChoice == 3) ||
                 (userChoice == 2 && computerChoice == 1) ||
                 (userChoice == 3 && computerChoice == 2))
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }

    static void DisplayArt(int userChoice, int computerChoice)
    {
        string userArt = GetArt(userChoice);
        string computerArt = GetArt(computerChoice);

        Console.WriteLine("Your choice:");
        Console.WriteLine(userArt);
        Console.WriteLine();

        Console.WriteLine("Computer choice:");
        Console.WriteLine(computerArt);
        Console.WriteLine();
    }

    static string GetArt(int choice)
    {
        switch (choice)
        {
            case 1:
                return @"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
";
            case 2:
                return @"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
";
            case 3:
                return @"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
";
            default:
                return string.Empty;
        }
    }

    static void MagicMooseMain()
    {
        Console.WriteLine("Welcome to the Magic Moose!");
        Console.WriteLine("Ask the Magic Moose any question, or hit ENTER to exit.");

        string question = GetQuestionFromUser();

        while (!string.IsNullOrWhiteSpace(question))
        {
            string response = GetRandomResponse();
            Console.WriteLine("Magic Moose says: " + response);
            Console.WriteLine();

            question = GetQuestionFromUser();
        }

        Console.WriteLine("Goodbye!");
    }

    static string GetQuestionFromUser()
    {
        Console.Write("Your question: ");
        return Console.ReadLine();
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

        Random random = new Random();
        int index = random.Next(responses.Length);
        return responses[index];
    }
}

