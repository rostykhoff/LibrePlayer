using NAudio.Wave;

namespace LibrePlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] tracks = Directory.GetFiles("Music", "*.mp3");

            for (int i = 0; i < tracks.Length; i++)
            {
                var track = new MusicItem(tracks[i]);
                track.PlayMusic += Track_PlayMusic;
                musicItemArea.Controls.Add(track);
            }
        }
        private void Track_PlayMusic(object? sender, EventArgs e)
        {
            MusicItem music = (MusicItem)sender!;
            trackBar.PlayPause(music);
        }
    }
}