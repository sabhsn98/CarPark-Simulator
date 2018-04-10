﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Barrier
    {
        private bool lifted;

        public bool IsLifted()
        {
            return lifted;
        }

        public void Raise()
        {
            lifted = true;
        }

        public void Lower()
        {
            lifted = false;
        }
    }
}
