using System;
using System.Collections.Generic;

namespace PacMan
{
  public class LevelOne : ILevel
  {
    public string LevelName
    {
      get;
    }
    public Grid<CellState> LevelMap
    {
      get;
    }
    public LevelOne()
    {
      LevelName = "Level One";
      LevelMap = new Grid<CellState>(11, 10);
      // BuildLevel();
    }

    void ILevel.BuildLevel()
    {
      //top wall
      var wallCoordinates = new List<Coordinates> { new Coordinates(0, 0), new Coordinates(0, 1), new Coordinates(0, 2), new Coordinates(0, 3), new Coordinates(0, 4), new Coordinates(0, 5), new Coordinates(0, 6), new Coordinates(0, 7), new Coordinates(0, 8), new Coordinates(0, 9), new Coordinates(1, 9),
//right edge wall
      new Coordinates(2, 9), new Coordinates(3, 9), new Coordinates(4, 9), new Coordinates(6, 9), new Coordinates(7, 9), new Coordinates(8, 9), new Coordinates(9, 9), new Coordinates(10, 10), new Coordinates(10, 9),
//left edge wall
      new Coordinates(1, 0), new Coordinates(2, 0), new Coordinates(3, 0), new Coordinates(4, 0), new Coordinates(6, 0), new Coordinates(7, 0), new Coordinates(8, 0), new Coordinates(9, 0),
//bottom wall
      new Coordinates(10, 0), new Coordinates(10, 1), new Coordinates(10, 2), new Coordinates(10, 3), new Coordinates(10, 4), new Coordinates(10, 5), new Coordinates(10, 6), new Coordinates(10, 7), new Coordinates(10, 8),
//row one
      new Coordinates(2, 2),new Coordinates(2, 3),new Coordinates(2, 4),
//row two
      new Coordinates(3,4),
//row three
      new Coordinates(4, 2),new Coordinates(4, 3),

      new Coordinates(2, 6),new Coordinates(2, 7),

      new Coordinates(4, 6),new Coordinates(4, 7),

      new Coordinates(6, 2),new Coordinates(6, 3), new Coordinates(6, 4),new Coordinates(6, 5),
      new Coordinates(5, 5),

      new Coordinates(8, 2), new Coordinates(8, 3),

      new Coordinates(8, 5), new Coordinates(8, 6), new Coordinates(8, 7), new Coordinates(7, 7),
      new Coordinates(6, 7)
      };



      LevelMap.SetMany(wallCoordinates, CellState.L);
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



