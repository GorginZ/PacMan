namespace PacMan
{
  public class Pac
  {
    public Coordinates CurrentLocation;
    public Direction CurrentDirection;

    public Pac(Coordinates startingLocation, Direction startingDirection)
    {
      CurrentLocation = startingLocation;
      CurrentDirection = startingDirection;
    }

    public void SetDirection(Direction value)
    {
      CurrentDirection = value;
    }
  }
}