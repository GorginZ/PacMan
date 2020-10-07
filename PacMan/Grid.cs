using System;
using System.Collections.Generic;
using System.Text;

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
      get => _cellGrid[coordinates.Row, coordinates.Column];
      set => _cellGrid[coordinates.Row, coordinates.Column] = value;
    }

    public void SetMany(List<Coordinates> coordinatesToSet, TItemType value)
    {
      foreach (Coordinates coordinate in coordinatesToSet)
      {
        if (coordinate.Column < ColumnCount && coordinate.Row < RowCount)
        {
          this[coordinate] = value;
        }
      }
    }

    public void SetElement(Coordinates coordinateToSet, TItemType value)
    {
      this[coordinateToSet] = value;
    }

    public String SeeGrid()
    {
      var seeSB = new StringBuilder();

      for (int i = 0; i < this.RowCount; i++)
      {
        for (int j = 0; j < this.ColumnCount; j++)
        {

          seeSB.Append(this[i, j].ToString());
        }
        seeSB.Append("\n");
      }
      return seeSB.ToString();
    }


  }
}
