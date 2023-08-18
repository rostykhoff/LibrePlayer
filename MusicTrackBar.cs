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
        AudioFileReader audio;
        bool isPlay = false;

        public MusicTrackBar()
        {
            InitializeComponent();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (isPlay)
            {
                wave.Pause();
            }
            else
            {
                wave.Play();
            }
            isPlay = !isPlay;
        }
        public void PlayPause(MusicItem track)
        {
            if (wave != null)
            {
                wave.Dispose();
                audio.Dispose();
            }
            wave = new WaveOut();
            audio = new AudioFileReader(track.File);
            Play();
        }

        void Play()
        {
            wave.Init(audio);
            wave.Play();
            musicPlayTimer.Start();
            isPlay = true;
            TimeSpan end = audio.TotalTime;
            endTime.Text = $"{end:mm}:{end:ss}";
        }

        private void musicPlayTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan current = audio.CurrentTime;
            startTime.Text = $"{current:mm}:{current:ss}";

            float timePercent = (float)(audio.CurrentTime / audio.TotalTime) * 100;
            trackLine.ColumnStyles[0].Width = timePercent;
            trackLine.ColumnStyles[1].Width = 100 - timePercent;
        }
    }
}
