using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LinkifyApp
{
    public partial class Form1 : Form
    {
        static ExternalInterface repo = new ExternalInterface();

        bool loginStatus = false;

        private Timer timer;
        DateTime end;

        public void InitCheckerTimer()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 10000;
            end = DateTime.Now.AddMilliseconds(10000);

        }

        public async void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                await repo.PostCurrentSong();

            } catch (Exception exception)
            {
                if (exception is System.Net.Http.HttpRequestException)
                {
                    ouput_label.Text = "User is not listening to music.";
                    //timer.Stop();
                    //start_timer.Text = "Start";
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitCheckerTimer();
        }

        private void login_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void login_button_Click(object sender, EventArgs e)
        {
            loginStatus = await repo.Login();
            if (loginStatus)
            {
                logged_in_as.Text = repo.curUser.username;
                songpairing_panel.Visible = true;
                songpairing_panel.Enabled = true;
                control_panel.Visible = true;
                control_panel.Enabled = true;
                UpdateSongpairingsBox();
            }
        }

        private async void submit_songpairing_Click(object sender, EventArgs e)
        {
            string key = songkey_box.Text;
            string value = songvalue_box.Text;

            if (key.Contains("open.spotify.com/track") && value.Contains("open.spotify.com/track") && !key.Contains('?') && !value.Contains('?'))
            {
                SongPairing pairing = await repo.PostSongPairing(key, value);
                await repo.UpdateUserPairings(pairing.id);
                songkey_box.Text = String.Empty;
                songvalue_box.Text = String.Empty;
                songpairing_output.Text = "Success! Song pairing was uploaded and paired with your account.";
                //Todo: make this so it doesnt have to ping the server to update the box
                UpdateSongpairingsBox();

            }
            else
            {
                songpairing_output.Text = "Something went wrong. Make sure the song URI link looks like this:\nhttps://open.spotify.com/track/4CJ7iadNL15GuTr7fXMqxr";
            }
        }

        private void control_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void start_timer_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                start_timer.Text = "Start";
            }
            else
            {
                timer.Start();
                start_timer.Text = "Stop";
            }
        }

        //This is hideous.
        private async void UpdateSongpairingsBox()
        {
            songpairings_box.Text = String.Empty;
            List<SongPairing> pairings = await repo.GetSongPairings(repo.curUser.id);
            foreach (SongPairing p in pairings)
            {
                songpairings_box.AppendText(p.song_key + " -> " + p.song_value);
                songpairings_box.AppendText(Environment.NewLine);


            }
        }

    }
}
