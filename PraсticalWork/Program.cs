using System;

namespace PraсticalWork
{
    internal class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("   ==================================================");
            Console.WriteLine(">>> Hello, Welcome to the game: Stone Scissors Paper <<<");
            Console.WriteLine("   ==================================================");
            Console.ResetColor();
            Console.Write("Enter your Nickname:");
            var nickname = Console.ReadLine();
            {
                while (string.IsNullOrWhiteSpace(nickname))
                {
                    Console.Write("Nickname cannot be empty.\nEnter your Nickname:");
                    nickname = Console.ReadLine();
                }
            }
            var age = 0;
            var isAgeInt = false;
            while (!isAgeInt)
            {
                Console.Write("Enter your age:");
                var ageInt = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ageInt))
                {
                    Console.WriteLine("Age cannot be empty. Try again.");
                    continue;
                }
                var isNumber = int.TryParse(ageInt, out age);
                if (!isNumber)
                {
                    Console.WriteLine("Age must be a number. Try again.");
                    continue;
                }

                if (age < 12)
                {
                    Console.WriteLine("Sorry, the game is only available from 12 years old.");
                    continue;
                }
                isAgeInt = true;
            }
            var playerTotalWins = 0;
            Console.WriteLine($"Your age is {age}. Let's continue!");
            while (true)
            {
                Console.WriteLine("======================================================");
                Console.WriteLine("            ╔════════════════════╗              ");
                Console.WriteLine("            ║     Statistic      ║              ");
                Console.WriteLine("            ╚════════════════════╝              ");
                Console.WriteLine($"Nickname: [{nickname}] Age: [{age}] Number of wins: [{playerTotalWins}]");
                Console.WriteLine("======================================================");
                var isChoise = false;
                while (!isChoise)
                {
                    Console.WriteLine("Press: 1 - Play\nPress: 2 - Exit");
                    var input = Console.ReadLine();
                    var isNumber = int.TryParse(input, out var choise);
                    if (!isNumber || (choise != 1 && choise != 2))
                    {
                        Console.WriteLine("Invalid input. Try again.");
                        continue;
                    }
                    isChoise = true;
                    if (choise == 1)
                    {
                    }
                    else
                    {
                        Console.WriteLine($"Goodbye, {nickname}!\nSee you soon!");
                        return;
                    }
                }
                var random = new Random();
                int playerWin = 0, computerWin = 0, round = 1;
                int playerRoundWins = 0, computerRoundWins = 0, roundDraws = 0;
                while (playerWin < 3 && computerWin < 3)
                {
                    Console.WriteLine($"    ╔════════════╗");
                    Console.WriteLine($"    ║   Round {round}  ║");
                    Console.WriteLine($"    ╚════════════╝");
                    var playerChoice = 0;
                    var isValidChoice = false;
                    while (!isValidChoice)
                    {
                        Console.WriteLine("Select the type of weapon:\n1.Stone 2.Scissors 3.Paper");
                        var input = Console.ReadLine();
                        isValidChoice = int.TryParse(input, out playerChoice) && playerChoice >= 1 && playerChoice <= 3;
                        if (!isValidChoice) Console.WriteLine("Press 1, 2 or 3!");
                    }

                    var playerChoiceText = playerChoice == 1 ? "Stone" : playerChoice == 2 ? "Scissors" : "Paper";
                    Console.WriteLine($"You choise: [{playerChoiceText}]");

                    var ascii = new string[]
                    {
                        //Stone
                        @"    
                        _______
                    ---'   ____)
                          (_____)
                           (_____)
                           (____)
                     ---.__(___)
                        ",
                        //Scissors
                        @"
                         _______
                      ---'  ____)____
                                ______)
                            __________)
                            (____)
                      ---.__(___)
                           ",
                        //Paper
                        @"
                         _______
                     ---'   ____)____
                                ______)
                                _______)
                              _______)
                      ---.__________)
                        "
                    };
                    Console.WriteLine(ascii[playerChoice - 1]);
                    Console.OutputEncoding = System.Text.Encoding.UTF8;
                    var computerChoice = new Random().Next(1, 4);
                    var computerChoiceText = computerChoice == 1 ? "Stone" : computerChoice == 2 ? "Scissors" : "Paper";
                    Console.WriteLine($"Computer choice: [{computerChoiceText}]");
                    Console.WriteLine(ascii[computerChoice - 1]);
                    Console.Write("Result of this round: ");
                    if ((playerChoice == 1 && computerChoice == 2) ||
                        (playerChoice == 2 && computerChoice == 3) ||
                        (playerChoice == 3 && computerChoice == 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("=== WIN ===");
                        Console.ResetColor();
                        playerWin++;
                        playerRoundWins++;
                    }
                    else if (playerChoice == computerChoice)
                    { 
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("=== DRAW ===");
                        Console.ResetColor();
                        roundDraws++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("=== LOSE ===");
                        Console.ResetColor();
                        computerRoundWins++;
                        computerWin++;
                    }

                    round++;
                    Console.WriteLine(
                        $"Score: {nickname} - {playerRoundWins} - {roundDraws} - {computerRoundWins} - Computer");
                }

                string[] winMessages =
                {
                    "Well done, you smashed it!",
                    "Great, you're on top!",
                    "Well played!",
                    "Awesome job, you're unstoppable!",
                    "Victory looks good on you!",
                    "You're killing it, champ!"
                };
                string[] loseMessages =
                {
                    "Don't be upset, try again!",
                    "A bit of bad luck, go for it!",
                    "You'll win next time!",
                    "Don't be sad, you'll come back stronger soon!",
                    "Tough game, but you almost won!",
                    "You're going too!"
                };
                if (playerWin == 3 || (playerWin == 2 && computerWin == 1))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("      ^^^YOU WIN THIS GAME^^^");
                    Console.ResetColor();
                    playerTotalWins++;
                    Console.WriteLine(winMessages[random.Next(0, winMessages.Length)]);
                }
                else if (computerWin == 3 || (computerWin == 2 && playerWin == 1))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("      ^^^COMPUTER WIN THIS GAME^^^");
                    Console.ResetColor();
                    Console.WriteLine(loseMessages[random.Next(0, loseMessages.Length)]);
                }

                /*var playAgain = 0;
                var isChoiseReturn = false;
                while (!isChoiseReturn)
                {
                    Console.Write(Do you want to play again? 1 - Yes   2 - No );
                    var input = Console.ReadLine();
                    isChoiseReturn = int.TryParse(input, out playAgain) && (playAgain == 1 || playAgain == 2);
                    if (!isChoiseReturn) Console.WriteLine("Press 1 or 2!");
                }

                if (playAgain == 2)
                {
                    Console.WriteLine($"Goodbye, {nickname}!");
                    return;
                }*/
            }
        }
    }
}
                
            
        
    

            
                
                        
                
                

                
            
            
            
            
            
              
                  
            
                
              
               
            
            
            
        
    
