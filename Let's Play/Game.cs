using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Let_s_Play.Datorn;
using Let_s_Play.Interfaces;


namespace Let_s_Play
{
    public class Game
    {
        IGuesser guesser = new Guesser();


        public void Start()
        {
            Console.WriteLine("Choose your opponent: 1 for StupidBot or 2 for Einstein");
            if (Console.ReadLine() == "1")
            {
                IGuesser guesser = new StupidGuesser();
            }
            else
            {
                IGuesser guesser = new Einstein();
            }

            bool game = true;
            
            Console.WriteLine("Think of a number between 1 and 1000. I will try to guess it...");
            Console.WriteLine("");
            Console.WriteLine("Use arrow keys up or down to tell me if I'm too high or too low. Press enter if I'm correct.");
            Console.WriteLine("");
            guesser.Guess();
            Console.WriteLine();
            while (game == true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    guesser.TooHigh();
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    guesser.TooLow();
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    guesser.Correct();
                    game = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }

            Console.WriteLine("Play again? Y/N");

            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                Console.Clear();
                Start();
            }
            else
            {
                Console.WriteLine("Bye!");
                Environment.Exit(0);
            }






        }




    }
}
