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
    public partial class Playlist : Form
    {
        public Playlist()
        {
            InitializeComponent();
            try
            {
                string[] files = Directory.GetDirectories(@"music\");

                foreach (string s in files)
                {
                    listBox2.Items.Add(Path.GetFileName(s));
                    listBox2.Sorted = true;
                }
            }

            catch (FileNotFoundException)
            {

            }

        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"music\" + textBox1.Text);
            Application.Restart();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            string dir = listBox2.SelectedItem.ToString();
            Directory.Delete(@"music\"+dir, true);
            listBox2.Items.Remove(dir);
            listBox2.Update();
        }
    }
}
