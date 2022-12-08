using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Let_s_Play.Interfaces;

namespace Let_s_Play.Datorn
{
    internal class Dator2 : IGuesser
    {

        public void Guess() => new Random().Next(1, 1000);

        public void HandleFeedback(int feedback)
        {
            if (feedback == 0)
            {
                Console.WriteLine("Jag gissade rätt!");
            }
            else if (feedback == 1)
            {
                Console.WriteLine("Jag gissade för högt!");
            }
            else if (feedback == -1)
            {
                Console.WriteLine("Jag gissade för lågt!");
            }
        }
    }

}
