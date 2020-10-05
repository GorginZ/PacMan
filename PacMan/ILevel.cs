namespace PacMan
{
  interface ILevel
  {
    // void LevelName();
    // void LevelMap();
    string LevelName();
    Grid<CellState> LevelMap();
  }
}