using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellularAutomata
{
    public class DataExporter
    {
        public SimulationSpace Space { get; set; }

        public DataExporter(SimulationSpace space)
        {
            Space = space;
        }

        public void ExportTextFile()
        {
            string? fileName = AskWhereToSave("Save Text File", "Text Files|*.txt");

            if (string.IsNullOrWhiteSpace(fileName))
            {
                return;
            }

            SaveToTextFile(fileName);
        }

        public void ExportBitmap()
        {
            string? fileName = AskWhereToSave("Save Bitmap File", "Bitmap|*.bmp");

            if (string.IsNullOrWhiteSpace(fileName))
            {
                return;
            }

            Space.GenerateBitmap().Save(fileName, ImageFormat.Bmp);
        }

        private static string? AskWhereToSave(string title, string filter)
        {
            using SaveFileDialog saveFileDialog = new();
            saveFileDialog.Title = title;
            saveFileDialog.Filter = filter;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return null;
        }

        private void SaveToTextFile(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                return;

            using StreamWriter writer = new(fileName);

            writer.WriteLine($"{Space.Size} {Space.Size}");

            for (int i = 0; i < Space.Size; i++)
            {
                for (int j = 0; j < Space.Size; j++)
                {
                    writer.WriteLine($"{i} {j} {Space.Size} {Space.Get(i, j).Value}");
                }
            }
        }
    }
}
