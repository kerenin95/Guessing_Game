using System;

namespace NumberGuessingGame
{
    class GuessingGame
    {
        static int secretNumber()
        {
            Random r = new Random();
            int secretNum = r.Next(101);

            return secretNum;
        }

        static void Main(string[] args)
        {
            int tries = 0;
            int sN = secretNumber();

            Console.WriteLine("Please Guess a number between 1 and 100:\n");

            try
            {
                int guess = Convert.ToInt32(Console.ReadLine());

                while (guess != sN)
                {
                    if (guess > sN)
                    {
                        Console.WriteLine($"You are too high \nPlease guess again:\n");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (guess < sN)
                    {
                        Console.WriteLine($"You are too low \nPlease guess again:\n");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                    tries++;
                }

                Console.WriteLine($"Congratulations, you guessed the number in {tries} tries!");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }                               

            

            Console.ReadLine();
        }
    }
}
