using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class PlaylistChoose : Form
    {
        public PlaylistChoose()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

           

        }

        private void PlaylistChoose_Load(object sender, EventArgs e)
        {
            try
            {
                string[] files = Directory.GetDirectories(@"music\");

                foreach (string s in files)
                {
                    listBox1.Items.Add(Path.GetFileName(s));
                    listBox1.Sorted = true;
                }
            }

            catch (FileNotFoundException)
            {

            }
        }
    }
}
