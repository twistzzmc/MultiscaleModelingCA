using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellularAutomata
{
    public partial class Visualization : Form
    {
        private readonly SimulationSpace _simulationSpace;
        private readonly DataExporter _dataExporter;

        public SimulationSpace Space => _simulationSpace;
        public DataExporter DataExporter => _dataExporter;

        public int TimeBetweenSimulationSteps => Convert.ToInt32(TimeBetweenStepsTextBox.Text);

        public int InitialGrains => Convert.ToInt32(InitialGrainsTextBox.Text);

        public Visualization()
        {
            InitializeComponent();
            _simulationSpace = new SimulationSpace(Math.Min(Plain.Height, Plain.Width), InitialGrains);
            _dataExporter = new DataExporter(Space);
            InitSimulationPlain();
        }

        private void InitSimulationPlain()
        {
            Plain.Image = Space.GenerateBitmap();
        }

        private void NextStepButton_Click(object sender, EventArgs e)
        {
            Space.CalculateStep();
            Plain.Image = Space.GenerateBitmap();
        }

        private void AllowOnlyDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SimulateButton_Click(object sender, EventArgs e)
        {
            if (TimeBetweenSimulationSteps == 0)
            {
                do
                {
                    Space.CalculateStep();
                }
                while (!Space.IsFinished());

                Plain.Image = Space.GenerateBitmap();
                return;
            }

            do
            {
                Space.CalculateStep();
                Thread.Sleep(TimeBetweenSimulationSteps);
                Plain.Image = Space.GenerateBitmap();
                Refresh();
            }
            while (!Space.IsFinished());
        }

        private void InitialGrainsTextBox_TextChanged(object sender, EventArgs e)
        {
            Space.Reset(InitialGrains);
            Plain.Image = Space.GenerateBitmap();
        }

        private void ExportTextFileButton_Click(object sender, EventArgs e)
        {
            DataExporter.ExportTextFile();
        }

        private void ExportBitmapButton_Click(object sender, EventArgs e)
        {
            DataExporter.ExportBitmap();
        }
    }
}
