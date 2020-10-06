using System.Collections.Generic;
using Xunit;

namespace PacMan.Tests

{
  public class GridTests
  {

    [Fact]
    public void Can_Generate_Grid_Of_A_Specified_Type()
    {
      var grid = new Grid<int>(5, 10);

      Assert.IsType<int>(grid[0, 0]);
    }

    [Fact]
    public void Should_Generate_Grid_With_Specified_Dimensions()
    {
      var grid = new Grid<CellState>(5, 10);

      Assert.Equal(5, grid.RowCount);
      Assert.Equal(10, grid.ColumnCount);
    }
    [Fact]
    public void Can_Manipulate_Grid_Cells_At_Specified_Input_Coordinates()
    {
      var grid = new Grid<CellState>(5, 5);

      var listOfCoordinatesToManipulate = new List<Coordinates> { new Coordinates(0, 0), new Coordinates(0, 1) };

      grid.SetMany(listOfCoordinatesToManipulate, CellState.Wall);

      Assert.Equal(CellState.Wall, grid[0, 0]);

    }


  }
}