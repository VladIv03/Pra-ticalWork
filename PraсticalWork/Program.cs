using System;

namespace PraсticalWork
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello, Welcome to the game: Stone Scissors Paper");
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
            int playerTotalWins = 0;
            Console.WriteLine($"Your age is {age}. Let's continue!");
            while (true)
            {
                Console.WriteLine("========================================");
                Console.WriteLine($"Statistic:\nNickname: {nickname}\nAge: {age}\nNumber of wins: {playerTotalWins}");
                Console.WriteLine("========================================");
                var isChoise = false;
                var choise = 0;
                while (!isChoise)
                {
                    Console.WriteLine("Press: 1 to play\nPress: 2 to exit the game");
                    var input = Console.ReadLine();
                    var isNumber = int.TryParse(input, out choise);
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
                        Console.WriteLine($"Goodbye, {nickname}!");
                        return;
                    }
                }
                Random random = new Random();
                int[] options = { 1, 2, 3 };
                int playerWin = 0, computerWin = 0, rounds = 0;
                while (rounds < 3 && playerWin < 2 && computerWin < 2)
                {
                    int playerChoice = 0;
                    bool isValidChoice = false;
                    while (!isValidChoice)
                    {
                        Console.WriteLine("Select the type of weapon:\n1.Stone 2.Scissors 3.Paper");
                        string input = Console.ReadLine();
                        isValidChoice = int.TryParse(input, out playerChoice) && playerChoice >= 1 && playerChoice <= 3;
                        if (!isValidChoice) Console.WriteLine("Press 1, 2 or 3!");
                    }
                    Console.WriteLine($"You chose: {playerChoice}");
                    int playerChoise = playerChoice;
                    int computerChoice = options[random.Next(0, 3)];
                    string computerChoiceText = computerChoice == 1 ? "Stone" : computerChoice == 2 ? "Scissors" : "Paper";
                    Console.WriteLine($"Computer choice: {computerChoice} - {computerChoiceText}");
                    if (playerChoise == computerChoice)
                    {
                        Console.WriteLine("Its Draw");
                        continue;
                    }
                    if ((playerChoise == 1 && computerChoice == 2) ||
                        (playerChoise == 2 && computerChoice == 3) ||
                        (playerChoise == 3 && computerChoice == 1))
                    {
                        Console.WriteLine($"You win this round!");
                        playerWin++;
                    }
                    else
                    {
                        computerWin++;
                        Console.WriteLine($"Computer win this round!");
                    }
                    rounds++;
                }
                if (playerWin >= 2)
                {
                    Console.WriteLine("You won the battle!");
                    playerTotalWins++;
                }
                else if (computerWin >= 2) Console.WriteLine("Computer won the battle!");
                else Console.WriteLine("It was a draw");
            }






        }
    }
}
            
                
                        
                
                

                
            
            
            
            
            
              
                  
            
                
              
               
            
            
            
        
    
