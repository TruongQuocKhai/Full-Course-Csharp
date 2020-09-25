using System;

namespace Full_Course_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "TruongKhai";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuess = true;

            while (guess != secretWord && !outOfGuess)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuess = true;
                }
            }
            if (outOfGuess)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("You win!");
            }

            Console.ReadLine();
        }
    }
}
