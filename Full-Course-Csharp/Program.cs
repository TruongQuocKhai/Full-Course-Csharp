using System;

namespace Full_Course_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "truongkhai";
            string guess = "";

            while (guess != secretWord)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
            }
            Console.WriteLine("you win!");
            Console.ReadLine();
        }
    }
}
