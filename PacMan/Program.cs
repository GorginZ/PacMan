﻿using System;

namespace PacMan
{
  class Program
  {
    static void Main(string[] args)
    {
      var game = new Game();

      Console.Write(game.PrintGameWorld());

    }
  }
}
