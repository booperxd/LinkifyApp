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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string newSong = await repo.PostCurrentSong("https://open.spotify.com/track/4CJ7iadNL15GuTr7fXMqxr");
            label1.Text = newSong;
            Debug.Write(newSong);
        }

    }
}
