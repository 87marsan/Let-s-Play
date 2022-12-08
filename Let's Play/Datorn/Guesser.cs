using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Let_s_Play.Interfaces;

namespace Let_s_Play.Datorn
{
    internal class Guesser : IGuesser
    {
        private int _guess;
        private int _min = 1;
        protected int _max = 1000;
        private int _tries = 0;
        
        public virtual int Guess()
        {
            
            _guess = new Random().Next(_min, _max);
            Console.WriteLine(_guess);
            return _guess;
        }

        public virtual void TooHigh()
        {
            Console.WriteLine("@£$$@$$ too high...");
            Console.WriteLine();
            _max = _guess;
            _tries++;
            Guess();
        }

        public virtual void TooLow()
        {
            Console.WriteLine("Ohh no, too low!");
            Console.WriteLine();
            _min = _guess;
            _tries++;
            Guess();
        }

        public virtual void Correct()
        {
            Console.Clear();
            Console.WriteLine($"YEAH!! I guessed right on my {_tries} try!");
            Console.WriteLine();
        }
    }
}
