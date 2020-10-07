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

      Assert.Equal(1, levelOne.DotsEatenThisLevel);

    }
    [Fact]
    public void DotDisappearsOnceEaten()
    {
      var levelOne = new LevelOne();

      levelOne.Tick();

      Assert.Equal( CellState.Empty, levelOne.LevelMap[5, 0]);

    }

    // [Fact]
    // public void InitialStateOfLevelMap()
    // {
    //   var levelOne = new LevelOne();

    //   var expected = $"{CellState.Wall}{CellState.Wall}{CellState.Wall}{CellState.Wall}{CellState.Wall}{CellState.Wall}{CellState.Wall}{CellState.Wall}{CellState.Wall}{CellState.Wall}\n{CellState.Wall}{CellState.Dot}{CellState.Dot}{CellState.Dot}{CellState.Dot}{CellState.Dot}{CellState.Dot}{CellState.Dot}{CellState.Dot}{CellState.Wall}\n{CellState.Wall}
    //   {CellState.Dot}{CellState.Dot}{CellState.Dot}"; 


    //   var actual = levelOne.LevelMap.SeeGrid();

    //   Assert.Equal(expected, actual);
    // }
    
  }
}