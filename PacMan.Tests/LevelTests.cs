using Xunit;

namespace PacMan.Tests
{
  public class LevelTests
  {

    [Fact]
    public void PacManLocationChangesOnTick()
    {
      var levelOne = new LevelOne();

      levelOne.Tick();

      Assert.NotEqual(levelOne.PacManChar.CurrentLocation, new Coordinates(5, 0));

    }

    [Fact]
    public void DotsEatenThisLevelIncrementWhenPacManEats()
    {
      var levelOne = new LevelOne();

      levelOne.Tick();

      Assert.NotEqual(0, levelOne.DotsEatenThisLevel);

    }
    [Fact]
    public void DotDisappearsOnceEaten()
    {
      var levelOne = new LevelOne();

      levelOne.Tick();

      Assert.Equal( CellState.Empty, levelOne.LevelMap[5, 0]);

    }
    
  }
}