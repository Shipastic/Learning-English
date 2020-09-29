using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle_English
{
    public partial class Form1 : Form
    {
        Dictionary dict;
        int current = 0;
        public Form1()
        {
            InitializeComponent();
            dict = new Dictionary();
            ShowCard();
        }

        public void ShowCard()
        {
            if (dict.Image(current) != "")
            picture_card.Image = Image.FromFile(dict.Image(current));
            label1_english.Text = dict.English(current);
            label2_russia.Text = dict.Russian(current);
            label1_video.Visible = dict.Video(current) != "";
        }

        private void button_previor_Click(object sender, EventArgs e)
        {
            if (current <= 0)
                return;
            current--;
            ShowCard();
        }

        private void buttonnext_Click(object sender, EventArgs e)
        {
            if (current >= dict.Total() - 1)
                return;
            current++;
            ShowCard();
        }

        private void Play_mp3(string filename)
        {
            if (filename == "") return;
            player.Visible = false;
            player.URL = filename;

        }

        private void Play_mp4(string filename)
        {
            if (filename == "") return;
            player.Visible = true;
            player.uiMode = "none";
            player.URL = filename;

        }
        private void label1_english_Click(object sender, EventArgs e)
        {
            Play_mp3(dict.Audio_eng(current));
        }

        private void label2_russia_Click(object sender, EventArgs e)
        {
            Play_mp3(dict.Audio_rus(current));
        }

        private void label1_video_Click(object sender, EventArgs e)
        {
            Play_mp4(dict.Video(current));
        }

        private void player_Enter(object sender, EventArgs e)
        {
            Play_mp4(dict.Video(current));

        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
                player.Visible = false;
        }
    }
}
