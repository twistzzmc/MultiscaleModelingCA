using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularAutomata
{
    public class ColorPicker
    {
        private static readonly Dictionary<int, Color> UsedColors = [];

        public static Color PickColor(int value)
        {
            if (value == 0)
                return Color.White;

            if (UsedColors.TryGetValue(value, out Color color))
                return color;

            Random rand = new();
            byte[] rgb = new byte[3];
            rand.NextBytes(rgb);
            Color newColor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
            UsedColors.Add(value, newColor);
            return newColor;
        }
    }
}
