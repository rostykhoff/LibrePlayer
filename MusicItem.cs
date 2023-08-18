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
    public partial class MusicItem : UserControl
    {
        private string file;
        private EventHandler? playMusic;

        public MusicItem()
        {
            InitializeComponent();
            HoverRecursive(musicArea);
            ClickRecursive(musicArea);
            DoubleClickRecursive(musicArea);
        }

        #region Hover
        private void MusicArea_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.FromArgb(50,50,50);
        }

        private void MusicArea_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.FromArgb(60, 60, 60);
        }

        private void HoverRecursive(Control element)
        {

            element.MouseEnter += MusicArea_MouseEnter;
            element.MouseLeave += MusicArea_MouseLeave;

            for (int i = 0; i < element.Controls.Count; i++)
            {
                HoverRecursive(element.Controls[i]);
            }
        }
        #endregion
        #region Click
        private void ClickRecursive(Control element)
        {
            element.MouseDown += Element_MouseDown;
            element.MouseUp += Element_MouseUp;

            for (int i = 0; i < element.Controls.Count; i++)
            {
                ClickRecursive(element.Controls[i]);
            }
        }

        private void Element_MouseUp(object? sender, MouseEventArgs e)
        {
            BackColor = Color.FromArgb(60, 60, 60);
        }

        private void Element_MouseDown(object? sender, MouseEventArgs e)
        {
            BackColor = Color.FromArgb(70, 70, 70);
        }
        #endregion
        #region DoubleClick
        private void DoubleClickRecursive(Control element)
        {
            element.MouseDoubleClick += Element_MouseDoubleClick;

            for (int i = 0; i < element.Controls.Count; i++)
            {
                DoubleClickRecursive(element.Controls[i]);
            }
        }

        private void Element_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            if(playMusic!=null)
            {
                playMusic.Invoke(sender, EventArgs.Empty);
            }
        }


        #endregion

        [Category("Track properties")]
        public string Title
        {
            get
            {
                return title.Text;
            }
            set
            {
                title.Text = value;
            }
        }
        [Category("Track properties")]
        public string Description
        {
            get
            {
                return description.Text;
            }
            set
            {
                description.Text = value;
            }
        }
        [Category("Track properties")]
        public Image MusicIcon
        {
            get
            {
                return musicIcon.Image;
            }
            set
            {
                musicIcon.Image = value;
            }
        }
        public string File
        {
            get
            {
                if (file == null)
                {
                    return "null";
                }
                return file;
            }
            set
            {
                file = value;
            }
        }
        public event EventHandler? PlayMusic
        {
            add
            {
                playMusic += value;
            }
            remove
            {
                playMusic -= value;
            }
        }
    }
}
