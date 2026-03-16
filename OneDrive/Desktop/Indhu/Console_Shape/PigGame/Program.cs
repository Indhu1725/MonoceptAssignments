using System;
namespace PigGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int turn = 0;
            Random r = new Random();

            while (total < 20)
            {
                int turnScore = 0;
                turn++;
                Console.WriteLine("Turn: " + turn);

                while (true)
                {
                    Console.Write("Roll or Hold (r/h): ");
                    string choice = Console.ReadLine();

                    if (choice == "r")
                    {
                        int dice = r.Next(1, 7);
                        Console.WriteLine("Dice: " + dice);

                        if (dice == 1)
                        {
                            Console.WriteLine("You rolled 1. Turn over.");
                            turnScore = 0;
                            break;
                        }
                        else
                        {
                            turnScore += dice;
                            Console.WriteLine("Turn Score: " + turnScore);
                        }
                    }
                    else if (choice == "h")
                    {
                        total += turnScore;
                        Console.WriteLine("Total Score: " + total);
                        break;
                    }
                }
            }

            Console.WriteLine("You reached 20 points in " + turn + " turns.");
        }
    }
}
                