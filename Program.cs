﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace menuForRogulike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game mygame = new Game();

            mygame.Start();
        }
    }
}