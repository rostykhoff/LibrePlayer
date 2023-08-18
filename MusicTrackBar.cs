using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrePlayer
{
    public partial class MusicTrackBar : UserControl
    {
        WaveOut wave;
        AudioFileReader reader;

        public MusicTrackBar()
        {
            InitializeComponent();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            
        }
        public void PlayPause(MusicItem track)
        {
            if (wave != null)
            {
                wave.Dispose();
                reader.Dispose();
            }
            wave = new WaveOut();
            reader = new AudioFileReader(track.File);
            wave.Init(reader);
            wave.Play();
        }
    }
}
