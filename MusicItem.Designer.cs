namespace LibrePlayer
{
    partial class MusicItem
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
            musicArea = new TableLayoutPanel();
            musicIcon = new PictureBox();
            title = new Label();
            description = new Label();
            musicArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)musicIcon).BeginInit();
            SuspendLayout();
            // 
            // musicArea
            // 
            musicArea.ColumnCount = 1;
            musicArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            musicArea.Controls.Add(musicIcon, 0, 0);
            musicArea.Controls.Add(title, 0, 1);
            musicArea.Controls.Add(description, 0, 2);
            musicArea.Dock = DockStyle.Fill;
            musicArea.Location = new Point(0, 0);
            musicArea.Name = "musicArea";
            musicArea.Padding = new Padding(20);
            musicArea.RowCount = 3;
            musicArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            musicArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            musicArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            musicArea.Size = new Size(230, 330);
            musicArea.TabIndex = 0;
            // 
            // musicIcon
            // 
            musicIcon.Dock = DockStyle.Fill;
            musicIcon.Image = Properties.Resources._360_F_493956085_jSsQmDTtUIsvelXaxanIIG9LVApe3NV6;
            musicIcon.Location = new Point(23, 23);
            musicIcon.Name = "musicIcon";
            musicIcon.Size = new Size(184, 204);
            musicIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            musicIcon.TabIndex = 0;
            musicIcon.TabStop = false;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Dock = DockStyle.Fill;
            title.Font = new Font("Liberation Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.WhiteSmoke;
            title.Location = new Point(23, 230);
            title.Name = "title";
            title.Size = new Size(184, 40);
            title.TabIndex = 1;
            title.Text = "title";
            title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // description
            // 
            description.AutoSize = true;
            description.Dock = DockStyle.Fill;
            description.Font = new Font("Liberation Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            description.ForeColor = Color.DarkGray;
            description.Location = new Point(23, 270);
            description.Name = "description";
            description.Size = new Size(184, 40);
            description.TabIndex = 2;
            description.Text = "description";
            description.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MusicItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(musicArea);
            Margin = new Padding(10);
            Name = "MusicItem";
            Size = new Size(230, 330);
            musicArea.ResumeLayout(false);
            musicArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)musicIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel musicArea;
        private PictureBox musicIcon;
        private Label title;
        private Label description;
    }
}
