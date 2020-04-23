using System.Collections.Generic;
using System;

namespace c#task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumberEasy = random.Next(1, 11);
            int randomNumberMedium = random.Next(1, 21);
            int randomNumberHard = random.Next(1, 50);

            int guess;
            int NumberofGuessesEasy = 6;
            int NumberofGuessesMedium = 4;
            int NumberofGuessesHard = 3;
            bool gameOver = false; 
            string level = "";
            Console.Write("select a level: ");
            level = (Console.ReadLine());

            if (level == "easy")
            {
                Console.WriteLine("level 1 selected");
                Console.WriteLine("I'm thinking of a number between 1 and 10! what is it?");

              while (gameOver == false)
                {
                 guess = Convert.ToInt32(Console.ReadLine());
                 NumberofGuessesEasy --;

                 if (guess != randomNumberEasy && NumberofGuessesEasy == 0)
                 {
                    Console.WriteLine("YOU GOT IT WRONG");
                    gameOver = true;
                 }
                 else if (guess == randomNumberEasy)
                 {
                    Console.WriteLine("YOU GOT IT RIGHT");
                    gameOver = true;
                 }
                 else if (guess > randomNumberEasy)
                 {
                    Console.WriteLine("my number is smaller than that");
                 }
                 else if (guess < randomNumberEasy)
                 {
                    Console.WriteLine("my number is greater than that");
                 }
                }
            }

            else if (level == "medium")
            {
                Console.WriteLine("level 2 selected");
                Console.WriteLine("I'm thinking of a number between 1 and 20! what is it?");

            while (gameOver == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                NumberofGuessesMedium --;

                if (guess != randomNumberMedium && NumberofGuessesMedium == 0)
                {
                    Console.WriteLine("YOU GOT IT WRONG");
                    gameOver = true;
                }
                else if (guess == randomNumberMedium)
                {
                    Console.WriteLine("YOU GOT IT RIGHT");
                    gameOver = true;
                }
                else if (guess > randomNumberMedium)
                {
                    Console.WriteLine("my number is smaller than that");
                }
                else if (guess < randomNumberMedium)
                {
                    Console.WriteLine("my number is greater than that");
                }
            }
            }
            
            else if (level == "hard")
            {
                Console.WriteLine("level 3 selected");
            }
        
        
            Console.WriteLine("I'm thinking of a number between 1 and 50! what is it?");

            while (gameOver == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                NumberofGuessesHard --;

                if (guess != randomNumberHard && NumberofGuessesHard == 0)
                {
                    Console.WriteLine("YOU GOT IT WRONG");
                    gameOver = true;
                }
                else if (guess == randomNumberHard)
                {
                    Console.WriteLine("YOU GOT IT RIGHT");
                    gameOver = true;
                }
                else if (guess > randomNumberHard)
                {
                    Console.WriteLine("my number is smaller than that");
                }
                else if (guess < randomNumberHard)
                {
                    Console.WriteLine("my number is greater than that");
                }
            }
          
            Console.ReadLine();
        }
    }
}
