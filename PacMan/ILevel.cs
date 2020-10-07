namespace PacMan
{
  interface ILevel
  {
    // void LevelName();
    // void LevelMap();
    string LevelName
    {
      get;
    }
    Grid<CellState> LevelMap
    {
      get;
    }

    


  }
}