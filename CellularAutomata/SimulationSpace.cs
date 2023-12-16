using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularAutomata;
public sealed class SimulationSpace
{
    private readonly Random _random = new();
    private readonly Cell[][] _space;
    private readonly Cell[][] _prevSpace;

    public Cell[][] Space => _space;

    public int Size => Space.Length;

    public int InitialGrains { get; private set; }

    public int Step { get; private set; }

    public SimulationSpace(int size)
        : this(size, 0)
    {
        
    }

    public SimulationSpace(int size, int initialGrains)
    {
        _space = new Cell[size][];
        _prevSpace = new Cell[size][];
        Reset(initialGrains);
    }

    public Cell Get(int i, int j)
    {
        return Space[i][j];
    }

    public void Set(int i, int j, int value)
    {
        Space[i][j].Value = value;
    }

    public Bitmap GenerateBitmap()
    {
        return BitmapBuilder.Create(this);
    }

    public bool IsFinished()
    {
        if (Step == 0)
        {
            return false;
        }

        for (int i = 0; i < Size; i++)
        {
            for (int j = 0;  j < Size; j++)
            {
                if (Space[i][j].Value != _prevSpace[i][j].Value)
                {
                    return false;
                }
            }
        }

        return true;
    }

    public void CalculateStep()
    {
        if (InitialGrains == 0)
            throw new Exception("Grains not initialized");

        if (Step > 0)
            CopySpace();

        Step++;

        for (int i = 0;  i < Size; i++)
        {
            for (int j = 0;  j < Size; j++)
            {
                int mostPopular = _prevSpace[i][j].Value;

                if (mostPopular != 0)
                {
                    continue;
                }

                if (j - 1 >= 0 && _prevSpace[i][j - 1].Value > mostPopular)
                    mostPopular = _prevSpace[i][j - 1].Value;
                if (i + 1 < Size && _prevSpace[i + 1][j].Value > mostPopular)
                    mostPopular = _prevSpace[i + 1][j].Value;
                if (j + 1 < Size && _prevSpace[i][j + 1].Value > mostPopular)
                    mostPopular = _prevSpace[i][j + 1].Value;
                if (i - 1 >= 0 && _prevSpace[i - 1][j].Value > mostPopular)
                    mostPopular = _prevSpace[i - 1][j].Value;

                if (Space[i][j].Value < mostPopular)
                    Space[i][j].Value = mostPopular;
            }
        }
    }

    public void Reset() => Reset(InitialGrains);
    public void Reset(int initialGrains)
    {
        FillSpace();
        InitialGrains = initialGrains;
        InitializeGrains();
    }

    private void FillSpace()
    {
        for (int i = 0; i < Size; i++)
        {
            Space[i] = new Cell[Size];
            _prevSpace[i] = new Cell[Size];

            for (int j = 0; j < Size;  j++)
            {
                Space[i][j] = new();
                _prevSpace[i][j] = new();
            }
        }
    }

    private void InitializeGrains()
    {
        for (int grain = 0; grain < InitialGrains; grain++)
        {
            int x = _random.Next(0, Size - 1);
            int y = _random.Next(0, Size - 1);
            Space[x][y].Value = grain + 1;
            _prevSpace[x][y].Value = grain + 1;
        }
    }

    private void CopySpace()
    {
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                Cell cell = Space[i][j];
                _prevSpace[i][j] = cell.Clone();
            }
        }
    }
}
