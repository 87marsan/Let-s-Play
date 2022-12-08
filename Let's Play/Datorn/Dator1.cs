using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Let_s_Play.Interfaces;

namespace Let_s_Play.Datorn
{
    internal class Dator1
    {
        private int _guess;
        private int _min = 1;
        private int _max = 1000;
        private int _tries = 0;

        public void Guess()
        {
            Console.WriteLine();
            _guess = new Random().Next(_min, _max);
            Console.WriteLine(_guess);
            Console.WriteLine();
        }

        public void HandleFeedback(int feedback)
        {
            if (feedback == 3)
            {
                Console.WriteLine($"Jag gissade rätt! Det tog {_tries} försök");
            }
            else if (feedback == 2)
            {
                Console.WriteLine("Jag gissade för högt!");
                _max = _guess;
                _tries++;
                Guess();
            }
            else if (feedback == 1)
            {
                Console.WriteLine("Jag gissade för lågt!");
                _min = _guess;
                _tries++;
                Guess();
            }
        }


    }

}
