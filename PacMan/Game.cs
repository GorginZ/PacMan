using System.Collections.Generic;

namespace PacMan
{
  public class Game
  {
    private ILevel _currentLevel = new LevelOne();

    public Pac PacManChar = new Pac();

    public int score = 0;



    public void PrintGameLevel()
    {
      _currentLevel.PrintMap();
    }

    public void Tick(Direction direction)
    {
      PacManChar.SetDirection(direction);

      if (PacManChar.CurrentDirection.Equals(Direction.East))
      {
        var coordinateToMoveTo = PacManChar.CurrentLocation = new Coordinates(PacManChar.CurrentLocation.Row, PacManChar.CurrentLocation.Column += 1);
        // ++ won't increment wtf?
        if (coordinateToMoveTo.Equals(CellState.Dot))
        {
          score++;
        }

        _currentLevel.LevelMap.SetElement(coordinateToMoveTo, CellState.PacMan);
        PacManChar.CurrentLocation = coordinateToMoveTo;
      }



    }



  }
}