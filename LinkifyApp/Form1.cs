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
        static ExteranlInterface repo = new ExteranlInterface();

        bool timerStarted = false;
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
            await repo.PostCurrentSong();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitCheckerTimer();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                timerlabel.Text = "Stopped!";
            }
            else
            {
                timer.Start();
                timerlabel.Text = "Started!";
            }
        }

    }
}
