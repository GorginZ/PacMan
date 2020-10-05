using System;
using System.Collections.Generic;

namespace PacMan
{
  public class LevelOne : ILevel
  {
    public string LevelName;
    public Grid<CellState> LevelMap;
    public LevelOne()
    {
      LevelName = "Level One";
      LevelMap = new Grid<CellState>(10, 10);
      BuildLevel();
    }

    public void BuildLevel()
    {
      var wallCoordinates = new List<Coordinates> { new Coordinates(0, 0), new Coordinates(0, 1), new Coordinates(0, 2), new Coordinates(0, 3), new Coordinates(0, 4), new Coordinates(0, 5), new Coordinates(0, 6), new Coordinates(0, 7), new Coordinates(0, 8), new Coordinates(0, 9), new Coordinates(0, 9), new Coordinates(1, 9), new Coordinates(2, 9), new Coordinates(3, 9), new Coordinates(4, 9), new Coordinates(5, 9), new Coordinates(6, 9), new Coordinates(7, 9), new Coordinates(8, 9), new Coordinates(9, 9), new Coordinates(1, 0), new Coordinates(2, 0), new Coordinates(3, 0), new Coordinates(4, 0), new Coordinates(4, 0), new Coordinates(5, 0), new Coordinates(6, 0), new Coordinates(7, 0), new Coordinates(8, 0), new Coordinates(9, 0), new Coordinates(9, 1), new Coordinates(9, 2), new Coordinates(9, 3), new Coordinates(9, 4), new Coordinates(9, 5), new Coordinates(9, 6), new Coordinates(9, 7), new Coordinates(9, 8) };
      LevelMap.SetMany(wallCoordinates, CellState.Wall);
    }

    public void SetLevel()
    {

    }

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



