﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7G
{
    class Pair
    {
        public int First { get; private set; }
        public int Second { get; private set; }

        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }
    }
}
