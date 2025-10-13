namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();
                int guess = random.Next(1, 101);
                int userGuess = 0;
                Console.WriteLine("Welcome to the Number Guessing Game!");
                Console.WriteLine("I have selected a number between 1 and 100. Can you guess it?");
                while (userGuess != guess)
                {
                    Console.Write("Enter your guess: ");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out userGuess))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Please enter a valid number.");
                        Console.ResetColor();
                        continue;
                    }
                    if (userGuess < guess)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Too low! Try again.");
                        Console.ResetColor();
                    }
                    else if (userGuess > guess)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Too high! Try again.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Congratulations! You've guessed the correct number: {guess}");
                        Console.WriteLine("Congratulations! You Win The Game...");
                        Console.ResetColor();
                    }
                }
                Console.Write("Do you want to play again? [Y/N]: ");
                string str = Console.ReadLine();
                if (!str.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Thank you for playing!");
                    Console.ResetColor();
                    break;
                }
            }
        }
    }
}
