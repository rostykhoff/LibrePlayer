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
                FileInfo file = new FileInfo(tracks[i]);
                var track = new MusicItem();
                track.File = file.FullName;
                track.PlayMusic += Track_PlayMusic;
                track.Title = file.Name.Replace(".mp3", "");
                track.Description = file.CreationTime.ToString("d/MM/yyyy");
                musicItemArea.Controls.Add(track);
            }
        }
        WaveOut wave;
        AudioFileReader reader;
        private void Track_PlayMusic(object? sender, EventArgs e)
        {
            string path = (string)sender!;
            if(wave != null)
            {
                wave.Dispose();
                reader.Dispose();
            }
            wave = new WaveOut();
            reader = new AudioFileReader(path);
            wave.Init(reader);
            wave.Play();
        }
    }
}