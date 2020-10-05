namespace PacMan
{
  public class Game
  {
    private ILevel _currentLevel;

    public Game()
    {
      _currentLevel = new LevelOne();
      _currentLevel.BuildLevel();
    }

    public void PrintGameLevel()
    {
      _currentLevel.PrintMap();
    }




  }
}