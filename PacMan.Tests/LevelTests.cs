using Xunit;

namespace PacMan.Tests
{
  public class WorldTests
  {

    [Fact]
    public void PacManLocationChangesOnTick()
    {
      var world = new World(new Level());

      world.Tick();

      Assert.NotEqual(world.PacMan.CurrentLocation, new Coordinates(5, 0));

    }

    [Fact]
    public void DotsEatenThisLevelIncrementWhenPacManEats()
    {
      var world = new World(new Level());

      world.Tick();

      Assert.Equal(1, world.DotsEatenThisLevel);

    }
    [Fact]
    public void DotDisappearsOnceEaten()
    {
      var world = new World(new Level());

      world.Tick();

      Assert.Equal( CellState.Empty, world.Grid[5, 0]);

    }

    // [Fact]
    // public void InitialStateOfLevelMap()
    // {
    //   var world = new WorldOnew Level()ne();

    //   var expected = $"{CellState.Wall}{CellState.Wall}{CellState.Wall}{CellState.Wall}{CellState.Wall}{CellState.Wall}{CellState.Wall}{CellState.Wall}{CellState.Wall}{CellState.Wall}\n{CellState.Wall}{CellState.Dot}{CellState.Dot}{CellState.Dot}{CellState.Dot}{CellState.Dot}{CellState.Dot}{CellState.Dot}{CellState.Dot}{CellState.Wall}\n{CellState.Wall}
    //   {CellState.Dot}{CellState.Dot}{CellState.Dot}"; 


    //   var actual = world.LevelMap.SeeGrid();

    //   Assert.Equal(expected, actual);
    // }
    
  }
}