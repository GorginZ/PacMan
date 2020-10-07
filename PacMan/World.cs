using System;

namespace PacMan
{
  public class World
  {
    public Grid<CellState> Grid;

    public int DotsEatenThisLevel = 0;

    public Pac PacMan;


    public World(Level level)
    {
      Grid = new Grid<CellState>(level.Rows, level.Columns);
      Grid.SetMany(level.dotCoordinates, CellState.Dot);
      Grid.SetMany(level.WallCoordinates, CellState.Wall);
      Grid.SetElement(level.PacManStartCoordinate, CellState.PacMan);
      PacMan = new Pac(level.PacManStartCoordinate, level.PacStartingDirection);

    }

    public void IncrementDotsEaten(Coordinates coordinateToCheck)
    {
      if (Grid[coordinateToCheck.Row, coordinateToCheck.Column].Equals(CellState.Dot))
      {
        DotsEatenThisLevel += 1;
      }
    }

    public void Tick()
    {
      var previousCoordinate = PacMan.CurrentLocation;

      if (PacMan.CurrentDirection.Equals(Direction.East))
      {
        var coordinateToMoveTo = new Coordinates(PacMan.CurrentLocation.Row, PacMan.CurrentLocation.Column += 1);

        IncrementDotsEaten(coordinateToMoveTo);

        Grid.SetElement(previousCoordinate, CellState.Empty);

        PacMan.CurrentLocation = coordinateToMoveTo;
      }
    }

  }
}