using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CellularAutomata
{
    public class BitmapBuilder
    {
        private readonly SimulationSpace _space;
        private Bitmap? _bitmap;

        public BitmapBuilder(SimulationSpace space)
        {
            _space = space;
        }

        public Bitmap Build()
        {
            _bitmap = new Bitmap(_space.Size, _space.Size);
            ColorBitmap();
            return _bitmap;
        }

        public static Bitmap Create(SimulationSpace space)
        {
            return new BitmapBuilder(space).Build();
        }

        private void ColorBitmap()
        {
            if (_bitmap == null)
                throw new ArgumentNullException(nameof(_bitmap));

            for (int i = 0; i < _space.Size; i++)
            {
                for (int j = 0; j < _space.Size; j++)
                {
                    Color pixelColor = _space.Get(i, j).Color;
                    _bitmap.SetPixel(j, i, pixelColor);
                }
            }
        }
    }
}
