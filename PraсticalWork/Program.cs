using System;

namespace PraсticalWork
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello, Welcome to the game: Stone Scissors Paper");
            Console.Write("Enter your Nickname:");
            string nickname = Console.ReadLine();
            {
                while (string.IsNullOrWhiteSpace(nickname))
                {
                    Console.Write("Nickname cannot be empty.\nEnter your Nickname:");
                    nickname = Console.ReadLine();
                }
            }
            int age = 0;
            bool isAgeInt = false;
                  while (!isAgeInt)
                  {
                      Console.Write("Enter your age:");
                       string ageInt = Console.ReadLine();
                       if (string.IsNullOrWhiteSpace(ageInt))
                       {
                           Console.WriteLine("Age cannot be empty. Try again.");
                           continue;
                       }
                       bool isNumber = int.TryParse(ageInt, out age);
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
            
            
              
                  
            
                
              
               
            
            
            
        }
    }
}