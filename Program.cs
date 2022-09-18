using static System.Net.Mime.MediaTypeNames;

internal class Program
{





    static void ColorMessage(ConsoleColor color, string input)
    {
        Console.ForegroundColor = color;    
        Console.WriteLine(input);
        Console.ResetColor();
    }
    private static void Main(string[] args)
    {
        Random random = new Random();
        bool playGameAgain = true;
        int min = 1;
        int max = 2;
        int guess;
        int numberToGuess;
        int guesses;
        string choice;

        while (playGameAgain)
        {
            guess = 0;
            guesses = 0;
            choice = string.Empty;
            numberToGuess = random.Next(min, max + 1);

            while (guess != numberToGuess)
            {
              
                Console.WriteLine("Zgadnij liczbe od " + min + " do " + max + ":");
                guess = int.Parse(s: Console.ReadLine());
                Console.WriteLine("Twoj wybor: " + guess);
                if (guess > numberToGuess)
                {
                    Console.WriteLine(guess + " jest za duza!");
                }
                else if (guess < numberToGuess)
                {
                    Console.WriteLine(guess + " jest za mala!");
                }
                else if (guess == numberToGuess)
                {
                    break;
                }
                guesses++;
            }

            ColorMessage(ConsoleColor.Green, "Twoja liczba to " + numberToGuess + " wygrales ;)");      
            Console.WriteLine("Ilosc prob: " + guesses);
            Console.WriteLine("Czy chcesz zgrac ponownie? (T - tak, N - nie)");
            choice = Console.ReadLine();
            if (choice == "T")
            {
                playGameAgain = true;
            }
            else if (choice == "N")
            {
                playGameAgain = false;
            }
        }
    }
}