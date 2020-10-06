using System.Collections.Generic;

namespace PacMan
{
  public class Game
  {
    private ILevel _currentLevel = new LevelOne();


    public int score = 0;



    public void PrintGameLevel()
    {
      _currentLevel.PrintMap();
    }

    public void Tick(Direction direction)
    {
      _currentLevel.Tick();
    

    }







  }
}