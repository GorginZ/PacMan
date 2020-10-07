using System;
using System.Collections.Generic;

namespace PacMan
{
  public class Game
  {
    private World _currentLevel = new World(new Level());

    public int score = 0;




    public string PrintGameWorld()
    {
     return _currentLevel.Grid.SeeGrid();
    }


  }
}