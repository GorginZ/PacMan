using System;
using System.Collections.Generic;

namespace PacMan
{
  public class Game
  {
    private World _currentLevel;

    public int score = 0;




    public void PrintGameLevel()
    {
      _currentLevel.PrintMap();
    }


  }
}