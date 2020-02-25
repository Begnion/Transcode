using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Transcode
{
    public partial class Form2 : Form
    {
        private Player vPlayer;
        private bool isPlaying;

        public Form2(string t)
        {
            InitializeComponent();

            string pluginPath = $"{Environment.CurrentDirectory}\\plugins\\";
            vPlayer = new Player(pluginPath);
            IntPtr renderWnd = panel1.Handle;
            vPlayer.SetRenderWindow((int)renderWnd);
            tbVideoTime.Text = "00:00:00/00:00:00";
            isPlaying = false;

            vPlayer.PlayFile(t);
            trackBar1.SetRange(0, (int)vPlayer.Duration());
            trackBar1.Value = 0;
            timer1.Start();
            isPlaying = true;
            btnStart.Text = "暂停";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                vPlayer.Pause();
                timer1.Stop();
                isPlaying = false;
                btnStart.Text = "播放";
            }
            else
            {
                vPlayer.Play();
                timer1.Start();
                isPlaying = true;
                btnStart.Text = "暂停";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnStart.Text = "播放";
            vPlayer.Stop();
            trackBar1.Value = 0;
            tbVideoTime.Text = "00:00:00/00:00:00";
            timer1.Stop();
            isPlaying = false;
        }

        private void btnFullScr_Click(object sender, EventArgs e)
        {
            if (isPlaying)
                vPlayer.SetFullScreen(true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                if (trackBar1.Value == trackBar1.Maximum)
                {
                    vPlayer.Stop();
                    timer1.Stop();
                }
                else
                {
                    trackBar1.Value = trackBar1.Value + 1;
                    tbVideoTime.Text = string.Format("{0}/{1}", GetTimeString(trackBar1.Value), GetTimeString(trackBar1.Maximum));
                }
            }
        }

        private string GetTimeString(int val)
        {
            int hour = val / 3600;
            val %= 3600;
            int minute = val / 60;
            int second = val % 60;
            return string.Format("{0:00}:{1:00}:{2:00}", hour, minute, second);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                vPlayer.SetPlayTime(trackBar1.Value);
                trackBar1.Value = (int)vPlayer.GetPlayTime();
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                vPlayer.SetVolume(trackBar2.Value);
                trackBar2.Value = (int)vPlayer.GetVolume();
            }
        }
    }
}
