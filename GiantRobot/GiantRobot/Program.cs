﻿using System;

namespace GiantRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine.StartGame();
            Planet.Select();
            Engine.Round(Planet.enemy, Planet.robot);
        }
    }
}
