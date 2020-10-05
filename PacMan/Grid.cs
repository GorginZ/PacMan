using System;
using System.Collections.Generic;


namespace PacMan
{
  public class Grid<TItemType>
  {
    private readonly TItemType[,] _cellGrid;

    public Grid(int rowDimension, int columnDimension)
    {
      _cellGrid = new TItemType[rowDimension, columnDimension];
    }

    public int RowCount => _cellGrid.GetLength(0);
    public int ColumnCount => _cellGrid.GetLength(1);

    public TItemType this[int row, int column]
    {
      get => _cellGrid[row, column];
      set => _cellGrid[row, column] = value;
    }

    public TItemType this[Coordinates coordinates]
    {
      get => _cellGrid[coordinates.X, coordinates.Y];
      set => _cellGrid[coordinates.X, coordinates.Y] = value;
    }

    public void SetMany(List<Coordinates> coordinatesToSet, TItemType value)
    {
      foreach (Coordinates coordinate in coordinatesToSet)
      {
        if (coordinate.Y < ColumnCount && coordinate.X < RowCount)
        {
          this[coordinate] = value;
        }
      }
    }


  }
}
