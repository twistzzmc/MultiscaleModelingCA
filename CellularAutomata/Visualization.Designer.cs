namespace CellularAutomata
{
    partial class Visualization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Plain = new PictureBox();
            NextStepButton = new Button();
            TimeBetweenStepsLabel = new Label();
            TimeBetweenStepsTextBox = new TextBox();
            SimulateButton = new Button();
            InitialGrainsTextBox = new TextBox();
            InitialGrainsLabel = new Label();
            ExportBitmapButton = new Button();
            ExportTextFileButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Plain).BeginInit();
            SuspendLayout();
            // 
            // Plain
            // 
            Plain.Location = new Point(12, 12);
            Plain.Name = "Plain";
            Plain.Size = new Size(400, 400);
            Plain.TabIndex = 0;
            Plain.TabStop = false;
            // 
            // NextStepButton
            // 
            NextStepButton.Location = new Point(418, 38);
            NextStepButton.Name = "NextStepButton";
            NextStepButton.Size = new Size(125, 29);
            NextStepButton.TabIndex = 1;
            NextStepButton.Text = "Next step";
            NextStepButton.UseVisualStyleBackColor = true;
            NextStepButton.Click += NextStepButton_Click;
            // 
            // TimeBetweenStepsLabel
            // 
            TimeBetweenStepsLabel.AutoSize = true;
            TimeBetweenStepsLabel.Location = new Point(418, 12);
            TimeBetweenStepsLabel.Name = "TimeBetweenStepsLabel";
            TimeBetweenStepsLabel.Size = new Size(325, 20);
            TimeBetweenStepsLabel.TabIndex = 2;
            TimeBetweenStepsLabel.Text = "Time between simulation steps (in miliseconds):";
            // 
            // TimeBetweenStepsTextBox
            // 
            TimeBetweenStepsTextBox.Location = new Point(749, 5);
            TimeBetweenStepsTextBox.Name = "TimeBetweenStepsTextBox";
            TimeBetweenStepsTextBox.Size = new Size(125, 27);
            TimeBetweenStepsTextBox.TabIndex = 3;
            TimeBetweenStepsTextBox.Text = "1";
            TimeBetweenStepsTextBox.KeyPress += AllowOnlyDigits_KeyPress;
            // 
            // SimulateButton
            // 
            SimulateButton.Location = new Point(749, 38);
            SimulateButton.Name = "SimulateButton";
            SimulateButton.Size = new Size(125, 29);
            SimulateButton.TabIndex = 4;
            SimulateButton.Text = "Simulate";
            SimulateButton.UseVisualStyleBackColor = true;
            SimulateButton.Click += SimulateButton_Click;
            // 
            // InitialGrainsTextBox
            // 
            InitialGrainsTextBox.Location = new Point(518, 84);
            InitialGrainsTextBox.Name = "InitialGrainsTextBox";
            InitialGrainsTextBox.Size = new Size(71, 27);
            InitialGrainsTextBox.TabIndex = 5;
            InitialGrainsTextBox.Text = "10";
            InitialGrainsTextBox.TextChanged += InitialGrainsTextBox_TextChanged;
            InitialGrainsTextBox.KeyPress += AllowOnlyDigits_KeyPress;
            // 
            // InitialGrainsLabel
            // 
            InitialGrainsLabel.AutoSize = true;
            InitialGrainsLabel.Location = new Point(418, 91);
            InitialGrainsLabel.Name = "InitialGrainsLabel";
            InitialGrainsLabel.Size = new Size(94, 20);
            InitialGrainsLabel.TabIndex = 6;
            InitialGrainsLabel.Text = "Initial Grains:";
            // 
            // ExportBitmapButton
            // 
            ExportBitmapButton.Location = new Point(418, 383);
            ExportBitmapButton.Name = "ExportBitmapButton";
            ExportBitmapButton.Size = new Size(125, 29);
            ExportBitmapButton.TabIndex = 7;
            ExportBitmapButton.Text = "Export bitmap";
            ExportBitmapButton.UseVisualStyleBackColor = true;
            ExportBitmapButton.Click += ExportBitmapButton_Click;
            // 
            // ExportTextFileButton
            // 
            ExportTextFileButton.Location = new Point(418, 348);
            ExportTextFileButton.Name = "ExportTextFileButton";
            ExportTextFileButton.Size = new Size(125, 29);
            ExportTextFileButton.TabIndex = 8;
            ExportTextFileButton.Text = "Export text file";
            ExportTextFileButton.UseVisualStyleBackColor = true;
            ExportTextFileButton.Click += ExportTextFileButton_Click;
            // 
            // Visualization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 436);
            Controls.Add(ExportTextFileButton);
            Controls.Add(ExportBitmapButton);
            Controls.Add(InitialGrainsLabel);
            Controls.Add(InitialGrainsTextBox);
            Controls.Add(SimulateButton);
            Controls.Add(TimeBetweenStepsTextBox);
            Controls.Add(TimeBetweenStepsLabel);
            Controls.Add(NextStepButton);
            Controls.Add(Plain);
            Name = "Visualization";
            Text = "Visualization";
            ((System.ComponentModel.ISupportInitialize)Plain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Plain;
        private Button NextStepButton;
        private Label TimeBetweenStepsLabel;
        private TextBox TimeBetweenStepsTextBox;
        private Button SimulateButton;
        private TextBox InitialGrainsTextBox;
        private Label InitialGrainsLabel;
        private Button ExportBitmapButton;
        private Button ExportTextFileButton;
    }
}