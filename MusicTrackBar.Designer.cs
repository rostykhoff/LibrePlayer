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
            components = new System.ComponentModel.Container();
            musicTrackBarArea = new TableLayoutPanel();
            musicControlsArea = new TableLayoutPanel();
            musicButtonsArea = new TableLayoutPanel();
            nextButton = new Button();
            pauseButton = new Button();
            beforeButton = new Button();
            bottonArea = new TableLayoutPanel();
            trackLine = new TableLayoutPanel();
            whiteLine = new Label();
            grayLine = new Label();
            startTime = new Label();
            endTime = new Label();
            musicPlayTimer = new System.Windows.Forms.Timer(components);
            musicTrackBarArea.SuspendLayout();
            musicControlsArea.SuspendLayout();
            musicButtonsArea.SuspendLayout();
            bottonArea.SuspendLayout();
            trackLine.SuspendLayout();
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
            musicTrackBarArea.Size = new Size(1134, 100);
            musicTrackBarArea.TabIndex = 0;
            // 
            // musicControlsArea
            // 
            musicControlsArea.ColumnCount = 1;
            musicControlsArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            musicControlsArea.Controls.Add(musicButtonsArea, 0, 0);
            musicControlsArea.Controls.Add(bottonArea, 0, 1);
            musicControlsArea.Dock = DockStyle.Fill;
            musicControlsArea.Location = new Point(103, 3);
            musicControlsArea.Name = "musicControlsArea";
            musicControlsArea.RowCount = 2;
            musicControlsArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            musicControlsArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            musicControlsArea.Size = new Size(928, 94);
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
            musicButtonsArea.Controls.Add(nextButton, 3, 0);
            musicButtonsArea.Controls.Add(pauseButton, 2, 0);
            musicButtonsArea.Controls.Add(beforeButton, 1, 0);
            musicButtonsArea.Dock = DockStyle.Fill;
            musicButtonsArea.Location = new Point(3, 3);
            musicButtonsArea.Name = "musicButtonsArea";
            musicButtonsArea.RowCount = 1;
            musicButtonsArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            musicButtonsArea.Size = new Size(922, 57);
            musicButtonsArea.TabIndex = 0;
            // 
            // nextButton
            // 
            nextButton.Dock = DockStyle.Fill;
            nextButton.Location = new Point(484, 3);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(34, 51);
            nextButton.TabIndex = 3;
            nextButton.Text = "N";
            nextButton.UseVisualStyleBackColor = true;
            // 
            // pauseButton
            // 
            pauseButton.Dock = DockStyle.Fill;
            pauseButton.Location = new Point(444, 3);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(34, 51);
            pauseButton.TabIndex = 2;
            pauseButton.Text = "P";
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
            // 
            // beforeButton
            // 
            beforeButton.Dock = DockStyle.Fill;
            beforeButton.Location = new Point(404, 3);
            beforeButton.Name = "beforeButton";
            beforeButton.Size = new Size(34, 51);
            beforeButton.TabIndex = 1;
            beforeButton.Text = "B";
            beforeButton.UseVisualStyleBackColor = true;
            // 
            // bottonArea
            // 
            bottonArea.ColumnCount = 3;
            bottonArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            bottonArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600F));
            bottonArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            bottonArea.Controls.Add(trackLine, 1, 0);
            bottonArea.Controls.Add(startTime, 0, 0);
            bottonArea.Controls.Add(endTime, 2, 0);
            bottonArea.Location = new Point(3, 66);
            bottonArea.Name = "bottonArea";
            bottonArea.RowCount = 1;
            bottonArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bottonArea.Size = new Size(922, 25);
            bottonArea.TabIndex = 1;
            // 
            // trackLine
            // 
            trackLine.BackColor = Color.Transparent;
            trackLine.ColumnCount = 2;
            trackLine.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            trackLine.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            trackLine.Controls.Add(whiteLine, 0, 0);
            trackLine.Controls.Add(grayLine, 1, 0);
            trackLine.Dock = DockStyle.Fill;
            trackLine.Location = new Point(164, 3);
            trackLine.Name = "trackLine";
            trackLine.Padding = new Padding(0, 7, 0, 7);
            trackLine.RowCount = 1;
            trackLine.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            trackLine.Size = new Size(594, 19);
            trackLine.TabIndex = 0;
            // 
            // whiteLine
            // 
            whiteLine.AutoSize = true;
            whiteLine.BackColor = Color.WhiteSmoke;
            whiteLine.Dock = DockStyle.Fill;
            whiteLine.Location = new Point(0, 7);
            whiteLine.Margin = new Padding(0);
            whiteLine.Name = "whiteLine";
            whiteLine.Size = new Size(297, 5);
            whiteLine.TabIndex = 0;
            // 
            // grayLine
            // 
            grayLine.AutoSize = true;
            grayLine.BackColor = Color.DarkGray;
            grayLine.Dock = DockStyle.Fill;
            grayLine.ForeColor = SystemColors.ControlLightLight;
            grayLine.Location = new Point(297, 7);
            grayLine.Margin = new Padding(0);
            grayLine.Name = "grayLine";
            grayLine.Size = new Size(297, 5);
            grayLine.TabIndex = 1;
            // 
            // startTime
            // 
            startTime.AutoSize = true;
            startTime.Dock = DockStyle.Right;
            startTime.ForeColor = SystemColors.ControlDark;
            startTime.Location = new Point(124, 0);
            startTime.Name = "startTime";
            startTime.Size = new Size(34, 25);
            startTime.TabIndex = 1;
            startTime.Text = "00:00";
            startTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // endTime
            // 
            endTime.AutoSize = true;
            endTime.Dock = DockStyle.Left;
            endTime.ForeColor = SystemColors.ControlDark;
            endTime.Location = new Point(764, 0);
            endTime.Name = "endTime";
            endTime.Size = new Size(34, 25);
            endTime.TabIndex = 2;
            endTime.Text = "00:00";
            endTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // musicPlayTimer
            // 
            musicPlayTimer.Tick += musicPlayTimer_Tick;
            // 
            // MusicTrackBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            Controls.Add(musicTrackBarArea);
            Name = "MusicTrackBar";
            Size = new Size(1134, 100);
            musicTrackBarArea.ResumeLayout(false);
            musicControlsArea.ResumeLayout(false);
            musicButtonsArea.ResumeLayout(false);
            bottonArea.ResumeLayout(false);
            bottonArea.PerformLayout();
            trackLine.ResumeLayout(false);
            trackLine.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel musicTrackBarArea;
        private TableLayoutPanel musicControlsArea;
        private TableLayoutPanel musicButtonsArea;
        private Button nextButton;
        private Button pauseButton;
        private Button beforeButton;
        private TableLayoutPanel bottonArea;
        private TableLayoutPanel trackLine;
        private Label whiteLine;
        private Label grayLine;
        private Label startTime;
        private Label endTime;
        private System.Windows.Forms.Timer musicPlayTimer;
    }
}
