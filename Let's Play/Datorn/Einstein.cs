using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_s_Play.Datorn
{
    internal class Einstein : Guesser
    {
        private int _guess;
        private int _min = 1;
        private int _max = 1000;
        private int _tries = 0;

        public override int Guess()
        {
            _guess = (_min + _max) / 2;                
            Console.WriteLine(_guess);
            return _guess;
        }

        public override void TooHigh()
        {
            Console.WriteLine("Too high...");
            Console.WriteLine();
            _max = _guess;
            _tries++;
            Guess();
        }

        public override void TooLow()
        {
            Console.WriteLine("Too low!");
            Console.WriteLine();
            _min = _guess;
            _tries++;
            Guess();
        }

        public override void Correct()
        {
            Console.Clear();
            Console.WriteLine($"YEAH!! I guessed right on my {_tries} try!");
            Console.WriteLine();
        }
    }
    
}
