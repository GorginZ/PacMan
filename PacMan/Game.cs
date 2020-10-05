namespace PacMan
{
  public class Game
  {
    private ILevel _level;

    public Game()
    {
      _level = new LevelOne();
    }

    public void PrintGameLevel()
    {
      _level.PrintMap();
    }




  }
}