using Xunit;

namespace PacMan.Tests
{
  public class GameTests
  {
    [Fact]
    public void PacManLocationChangesOnTick()
    {
      var game = new Game();

      game.Tick(Direction.East);

      Assert.NotEqual(game.PacManChar.CurrentLocation, new Coordinates(5, 0));

    }
  }
}