using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularAutomata;
public class Cell
{
    public int Value { get; set; }

    public Color Color => PickColor();

    public Cell()
    {
        Value = 0;
    }

    public Cell(int value)
    {
        Value = value;
    }

    public Cell Clone()
    {
        return new Cell(Value);
    }

    private Color PickColor()
    {
        return ColorPicker.PickColor(Value);
    }
}
