using System;

namespace PacMan
{
  public class LevelOne : ILevel
  {
    public string LevelName = "Level One";
    public Grid<CellState> LevelMap = new Grid<CellState>(10, 10);


    string ILevel.LevelName()
    {
      return LevelName;
    }

    Grid<CellState> ILevel.LevelMap()
    {
      return LevelMap;
    }

    void ILevel.PrintMap()
    {
      for (int i = 0; i < LevelMap.RowCount; i++)
      {
        for (int j = 0; j < LevelMap.ColumnCount; j++)
        {
          Console.Write(LevelMap[i, j]);
        }
        Console.WriteLine();
      }
    }

    
  }
}



