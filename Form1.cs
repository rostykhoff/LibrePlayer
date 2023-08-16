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
                track.Title = file.Name.Replace(".mp3", "");
                track.Description = file.CreationTime.ToString("d/MM/yyyy");
                musicItemArea.Controls.Add(track);
            }
        }
    }
}