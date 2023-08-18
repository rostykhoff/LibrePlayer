namespace LibrePlayer
{
    partial class MusicTrackBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            musicTrackBarArea = new TableLayoutPanel();
            musicControlsArea = new TableLayoutPanel();
            musicButtonsArea = new TableLayoutPanel();
            button5 = new Button();
            nextButton = new Button();
            pauseButton = new Button();
            beforeButton = new Button();
            button1 = new Button();
            musicTrackBarArea.SuspendLayout();
            musicControlsArea.SuspendLayout();
            musicButtonsArea.SuspendLayout();
            SuspendLayout();
            // 
            // musicTrackBarArea
            // 
            musicTrackBarArea.ColumnCount = 3;
            musicTrackBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            musicTrackBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            musicTrackBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            musicTrackBarArea.Controls.Add(musicControlsArea, 1, 0);
            musicTrackBarArea.Dock = DockStyle.Fill;
            musicTrackBarArea.Location = new Point(0, 0);
            musicTrackBarArea.Name = "musicTrackBarArea";
            musicTrackBarArea.RowCount = 1;
            musicTrackBarArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            musicTrackBarArea.Size = new Size(800, 100);
            musicTrackBarArea.TabIndex = 0;
            // 
            // musicControlsArea
            // 
            musicControlsArea.ColumnCount = 1;
            musicControlsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            musicControlsArea.Controls.Add(musicButtonsArea, 0, 0);
            musicControlsArea.Dock = DockStyle.Fill;
            musicControlsArea.Location = new Point(103, 3);
            musicControlsArea.Name = "musicControlsArea";
            musicControlsArea.RowCount = 2;
            musicControlsArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            musicControlsArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            musicControlsArea.Size = new Size(594, 94);
            musicControlsArea.TabIndex = 0;
            // 
            // musicButtonsArea
            // 
            musicButtonsArea.ColumnCount = 5;
            musicButtonsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            musicButtonsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            musicButtonsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            musicButtonsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            musicButtonsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            musicButtonsArea.Controls.Add(button5, 4, 0);
            musicButtonsArea.Controls.Add(nextButton, 3, 0);
            musicButtonsArea.Controls.Add(pauseButton, 2, 0);
            musicButtonsArea.Controls.Add(beforeButton, 1, 0);
            musicButtonsArea.Controls.Add(button1, 0, 0);
            musicButtonsArea.Dock = DockStyle.Fill;
            musicButtonsArea.Location = new Point(3, 3);
            musicButtonsArea.Name = "musicButtonsArea";
            musicButtonsArea.RowCount = 1;
            musicButtonsArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            musicButtonsArea.Size = new Size(588, 57);
            musicButtonsArea.TabIndex = 0;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(357, 3);
            button5.Name = "button5";
            button5.Size = new Size(228, 51);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            nextButton.Dock = DockStyle.Fill;
            nextButton.Location = new Point(317, 3);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(34, 51);
            nextButton.TabIndex = 3;
            nextButton.Text = "button4";
            nextButton.UseVisualStyleBackColor = true;
            // 
            // pauseButton
            // 
            pauseButton.Dock = DockStyle.Fill;
            pauseButton.Location = new Point(277, 3);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(34, 51);
            pauseButton.TabIndex = 2;
            pauseButton.Text = "button3";
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
            // 
            // beforeButton
            // 
            beforeButton.Dock = DockStyle.Fill;
            beforeButton.Location = new Point(237, 3);
            beforeButton.Name = "beforeButton";
            beforeButton.Size = new Size(34, 51);
            beforeButton.TabIndex = 1;
            beforeButton.Text = "B";
            beforeButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(228, 51);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // MusicTrackBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            Controls.Add(musicTrackBarArea);
            Name = "MusicTrackBar";
            Size = new Size(800, 100);
            musicTrackBarArea.ResumeLayout(false);
            musicControlsArea.ResumeLayout(false);
            musicButtonsArea.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel musicTrackBarArea;
        private TableLayoutPanel musicControlsArea;
        private TableLayoutPanel musicButtonsArea;
        private Button button5;
        private Button nextButton;
        private Button pauseButton;
        private Button beforeButton;
        private Button button1;
    }
}
