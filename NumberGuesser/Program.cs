using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GreatUser();

            while (true)
            { 
                var random = new Random();
                int randomm = random.Next(1,5);

                // MATER
                int pogodi = 0;

                Console.WriteLine("Guess a number between 1 and 5");

                while (pogodi != randomm)
                {
                    var broj = Console.ReadLine();

                    if(!int.TryParse(broj, out pogodi))
                    {
                        PrintColorMessage(ConsoleColor.Blue, "Not a number");
                        continue;
                    }

                    pogodi = Int32.Parse(broj);

                    if (pogodi != randomm)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");

                Console.WriteLine("Play again? (y or no)");

                var answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "No")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }
        // User Name
        static void GreatUser()
        {

            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name + ", lets play a game... ");
        }
        // Change Color and message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
