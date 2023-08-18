namespace LibrePlayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            musicItemArea = new FlowLayoutPanel();
            trackBar = new MusicTrackBar();
            SuspendLayout();
            // 
            // musicItemArea
            // 
            musicItemArea.AutoScroll = true;
            musicItemArea.BackColor = Color.FromArgb(30, 30, 30);
            musicItemArea.Dock = DockStyle.Fill;
            musicItemArea.Location = new Point(0, 0);
            musicItemArea.Margin = new Padding(3, 2, 3, 2);
            musicItemArea.Name = "musicItemArea";
            musicItemArea.Size = new Size(1384, 465);
            musicItemArea.TabIndex = 0;
            // 
            // trackBar
            // 
            trackBar.BackColor = Color.FromArgb(20, 20, 20);
            trackBar.Dock = DockStyle.Bottom;
            trackBar.Location = new Point(0, 465);
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(1384, 100);
            trackBar.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1384, 565);
            Controls.Add(musicItemArea);
            Controls.Add(trackBar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel musicItemArea;
        private MusicTrackBar trackBar;
    }
}