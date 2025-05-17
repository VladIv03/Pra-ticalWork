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

            Console.WriteLine($"Your age is {age}. Let's continue!");
            Console.WriteLine("========================================");
            Console.WriteLine($"Statistic:\nNickname: {nickname}\nAge: {age}");
            Console.WriteLine("========================================");
            bool isChoise = false;
            int choise = 0;
            while (!isChoise)
            {
                Console.WriteLine("Press: 1 to play\nPress: 2 to exit the game");
                var input = Console.ReadLine();
                bool isNumber = int.TryParse(input, out choise);
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
            
            
        }
    }
}
            
                
                        
                
                

                
            
            
            
            
            
              
                  
            
                
              
               
            
            
            
        
    
