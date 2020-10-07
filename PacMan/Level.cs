using System;
using System.Collections.Generic;

namespace PacMan
{
  public class Level
  {
    public string LevelName = "Level One";

    public int Rows = 11;
    public int Columns = 10;

    public Direction PacStartingDirection = Direction.East;

    public Coordinates PacManStartCoordinate = new Coordinates(5,0);

    public List<Coordinates> WallCoordinates = new List<Coordinates>{ new Coordinates(0, 0), new Coordinates(0, 1), new Coordinates(0, 2), new Coordinates(0, 3), new Coordinates(0, 4), new Coordinates(0, 5), new Coordinates(0, 6), new Coordinates(0, 7), new Coordinates(0, 8), new Coordinates(0, 9), new Coordinates(1, 9),
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
    public List<Coordinates> dotCoordinates = new List<Coordinates> { new Coordinates(1, 1), new Coordinates(1, 2), new Coordinates(1, 3), new Coordinates(1, 4), new Coordinates(1, 5), new Coordinates(1, 6), new Coordinates(1, 7), new Coordinates(1, 8),
      new Coordinates(2, 1), new Coordinates(2, 5), new Coordinates(1, 8),

      new Coordinates(3, 1), new Coordinates(3, 2), new Coordinates(3, 3), new Coordinates(3, 5),new Coordinates(3, 6), new Coordinates(3, 7), new Coordinates(3, 8),
      new Coordinates(4,1), new Coordinates(4, 4),new Coordinates(4,5), new Coordinates(4, 8),

      new Coordinates(5, 1), new Coordinates(5, 2),new Coordinates(5, 3),new Coordinates(5, 4), new Coordinates(5, 6), new Coordinates(5, 7), new Coordinates(5, 8), new Coordinates(5, 9),

      new Coordinates(6, 1), new Coordinates(6, 6), new Coordinates(6, 8),

      new Coordinates(7, 1), new Coordinates(7, 2), new Coordinates(7, 3), new Coordinates(7, 4), new Coordinates(7, 5), new Coordinates(7, 6), new Coordinates(7, 8),

      new Coordinates(8, 1),new Coordinates(8, 4), new Coordinates(8, 8),

      new Coordinates(9, 1), new Coordinates(9, 2), new Coordinates(9, 3), new Coordinates(9, 4), new Coordinates(9, 5), new Coordinates(9, 6), new Coordinates(9, 7), new Coordinates(9, 8)
      };


  }
}




