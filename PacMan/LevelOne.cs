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
    public Pac PacManChar = new Pac(new Coordinates(5, 0), Direction.East);

    public int DotsEatenThisLevel = 0;

    public LevelOne()
    {
      LevelName = "Level One";
      LevelMap = new Grid<CellState>(11, 10);
      BuildLevel();
    }

    private void BuildLevel()
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
      // dots
      // var dotCoordinates = new List<Coordinates> { new Coordinates(1, 1), new Coordinates(1, 2), new Coordinates(1, 3), new Coordinates(1, 4), new Coordinates(1, 5), new Coordinates(1, 6), new Coordinates(1, 7), new Coordinates(1, 8),
      // new Coordinates(2, 1), new Coordinates(2, 5), new Coordinates(1, 8),

      // new Coordinates(3, 1), new Coordinates(3, 2), new Coordinates(3, 3), new Coordinates(3, 5),new Coordinates(3, 6), new Coordinates(3, 7), new Coordinates(3, 8),
      // new Coordinates(4,1), new Coordinates(4, 4),new Coordinates(4,5), new Coordinates(4, 8),

      // new Coordinates(5, 1), new Coordinates(5, 2),new Coordinates(5, 3),new Coordinates(5, 4), new Coordinates(5, 6), new Coordinates(5, 7), new Coordinates(5, 8), new Coordinates(5, 9),

      // new Coordinates(6, 1), new Coordinates(6, 6), new Coordinates(6, 8),

      // new Coordinates(7, 1), new Coordinates(7, 2), new Coordinates(7, 3), new Coordinates(7, 4), new Coordinates(7, 5), new Coordinates(7, 6), new Coordinates(7, 8),

      // new Coordinates(8, 1),new Coordinates(8, 4), new Coordinates(8, 8),

      // new Coordinates(9, 1), new Coordinates(9, 2), new Coordinates(9, 3), new Coordinates(9, 4), new Coordinates(9, 5), new Coordinates(9, 6), new Coordinates(9, 7), new Coordinates(9, 8)
      // };

      // var monstersStartingPosCoordinates = new List<Coordinates> { new Coordinates(3, 3), new Coordinates(4, 4) };


      LevelMap.SetMany(wallCoordinates, CellState.Wall);
      // LevelMap.SetMany(dotCoordinates, CellState.Dot);

      // LevelMap.SetMany(monstersStartingPosCoordinates, CellState.Monster);
      LevelMap.SetElement(new Coordinates(5, 0), CellState.PacMan);
    }

    public void PrintMap()
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

    public void IncrementDotsEaten(Coordinates coordinateToCheck)
    {
      if (LevelMap[coordinateToCheck.Row, coordinateToCheck.Column].Equals(CellState.Dot))
      {
        DotsEatenThisLevel += 1;
      }
    }



    public void Tick()
    {
      var previousCoordinate = PacManChar.CurrentLocation;

      if (PacManChar.CurrentDirection.Equals(Direction.East))
      {
        var coordinateToMoveTo = new Coordinates(PacManChar.CurrentLocation.Row, PacManChar.CurrentLocation.Column += 1);

        IncrementDotsEaten(coordinateToMoveTo);

        LevelMap.SetElement(previousCoordinate, CellState.Empty);

        PacManChar.CurrentLocation = coordinateToMoveTo;
      }
    }

  }
}



