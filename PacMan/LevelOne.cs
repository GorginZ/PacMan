namespace PacMan
{
  public class LevelOne : ILevel
  {
    private string _levelName = "Level One";
    private Grid<CellState> _levelMap = new Grid<CellState>(10, 10);


    string ILevel.LevelName()
    {
      return "name";
    }

    Grid<CellState> ILevel.LevelMap()
    {
      return _levelMap;
    }
  }



}