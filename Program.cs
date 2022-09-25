namespace GuessTheNumber
{
    internal class Program
    {


        private static void ColorMessage(ConsoleColor color, string input)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(input);
            Console.ResetColor();
        }


        private static void Main(string[] args)
        {
            Random random = new Random();
            bool playGameAgain = true;
            int min = 0;
            int max = 100;
            int guess = 0;
            int guesses = 0;
            int numberToGuess;


            while (playGameAgain)
            {
                numberToGuess = random.Next(min, max);

                while (guess != numberToGuess)
                {
                    ColorMessage(ConsoleColor.DarkCyan, ("Guess the number from " + min + " to " + max + ":"));
                    guess = int.Parse(Console.ReadLine());
                    ColorMessage(ConsoleColor.Cyan, ("Your guess: " + guess));
                    if (guess == numberToGuess)
                    {
                        break;
                    }
                    else if (guess > numberToGuess)
                    {
                        Console.WriteLine(guess + " is too big!");
                    }
                    else if (guess < numberToGuess)
                    {
                        Console.WriteLine(guess + " is too small!");
                    }

                    guesses++;
                }

                ColorMessage(ConsoleColor.Green, "Your number is " + numberToGuess + ", you've won ;)");
                ColorMessage(ConsoleColor.Magenta, ("Number of tries: " + guesses));
                ColorMessage(ConsoleColor.Yellow, ("Would you like to play again? (Y - yes, N - no)"));


                switch (Console.ReadLine())
                {
                    case "Y":
                        playGameAgain = true;
                        break;
                    case "N":
                        playGameAgain = false;
                        break;
                    default:
                        playGameAgain = false;
                        break;
                }
            }
        }
    }
}