﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game bowlingGame = new Game();
            bowlingGame.StartGame();
            bowlingGame.PrintScore();
            Console.ReadLine();
        }
    }
}
