﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_s_Play.Interfaces
{
    internal interface IGuesser
    {
        void Guess();
        void HandleFeedback(int feedback);
        
    }
}
