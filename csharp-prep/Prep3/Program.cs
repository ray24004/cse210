using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine();

        Random random = new Random();
        bool wantToPlay = true;

        while (wantToPlay)
        {
            // Console.Write("What is the magic number? ");
            // int magicNumber = int.Parse(Console.ReadLine());

            int magicNumber = random.Next(1, 100);

            int guessedNumber = int.MinValue;
            int guessesCount = 0;

            while (guessedNumber != magicNumber)
            {
                guessesCount++;

                Console.Write("What is your guess? ");
                guessedNumber = int.Parse(Console.ReadLine());

                if (guessedNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessedNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
            }

            Console.WriteLine($"You guessed it! You needed {guessesCount} guesses.");
            Console.WriteLine();

            Console.Write("Would you like to play again? (yes/NO) ");
            wantToPlay = Console.ReadLine().ToLower() == "yes";
        }
    }
}