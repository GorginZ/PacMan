namespace PacMan
{
  public class Game
  {
    private ILevel _currentLevel;

    public Game()
    {
      _currentLevel = new LevelOne();
    }

    public void PrintGameLevel()
    {
      _currentLevel.PrintMap();
    }




  }
}