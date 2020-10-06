namespace PacMan
{
  public class Pac
  {
    public Coordinates CurrentLocation = new Coordinates(5, 0);
    public Direction CurrentDirection = Direction.East;

    public void SetDirection(Direction value)
    {
      CurrentDirection = value;
    }


  }
}