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
        int min = 8;
        int max = 69;
        int guess = 0;
        int guesses = 0;
        int numberToGuess;
  

        while (playGameAgain)
        {
            numberToGuess = random.Next(min, max);

            while (guess != numberToGuess)
            {
                Console.WriteLine("Zgadnij liczbe od " + min + " do " + max + ":");
                guess = int.Parse(Console.ReadLine());
                Console.WriteLine("Twoj wybor: " + guess);
                if (guess == numberToGuess)
                {
                    break;
                }
                else if (guess > numberToGuess)
                {
                    Console.WriteLine(guess + " jest za duza!");
                }
                else if (guess < numberToGuess)
                {
                    Console.WriteLine(guess + " jest za mala!");
                }

                guesses++;
            }

            ColorMessage(ConsoleColor.Green, "Twoja liczba to " + numberToGuess + " wygrales ;)");
            Console.WriteLine("Ilosc prob: " + guesses);
            Console.WriteLine("Czy chcesz zgrac ponownie? (T - tak, N - nie)");

     
            switch (Console.ReadLine())
            {
                case "T":
                    playGameAgain = true;
                    break;
                case "N":
                    playGameAgain = false;
                    break;
            }
        }
    }
}