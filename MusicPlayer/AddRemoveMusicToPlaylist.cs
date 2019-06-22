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
    public partial class AddRemoveMusicToPlaylist : Form
    {
        public AddRemoveMusicToPlaylist()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    File.Copy(@"music\" + listBox2.SelectedItem.ToString(), @"music\" + listBox1.SelectedItem.ToString() + @"\" + listBox2.SelectedItem.ToString(), true);
                    Close();
                }

                if (radioButton2.Checked)
                {
                    File.Delete(@"music\" + listBox3.SelectedItem.ToString() + @"\" + listBox4.SelectedItem.ToString());
                    listBox4.Items.Remove(listBox4.SelectedItem.ToString());
                }
            }

            catch (NullReferenceException)
            {

            }
        }

        private void AddRemoveMusicToPlaylist_Load(object sender, EventArgs e)
        {
            string[] playlist = Directory.GetDirectories(@"music\");
            string[] playlist1 = Directory.GetDirectories(@"music\");
            string[] musics = Directory.GetFiles(@"music\");

            foreach (string s in playlist)
            {
                listBox1.Items.Add(Path.GetFileName(s));
            }

            foreach (string s in playlist1)
            {
                listBox3.Items.Add(Path.GetFileName(s));
            }

            foreach (string s in musics)
            {
                if (Path.GetFileName(s).Contains(".mp3"))
                    listBox2.Items.Add(Path.GetFileName(s));
            }

            Application.Idle += new EventHandler(Idle);
        }

        void Idle(object ob, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }

            if(radioButton2.Checked)
            {
                panel1.Visible = false;
                panel2.Visible = true;
            }
        }
        private void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox4.Items.Clear();
                string[] musics1 = Directory.GetFiles(@"music\" + listBox3.SelectedItem.ToString() + @"\");
                foreach (string s in musics1)
                {
                    if (Path.GetFileName(s).Contains(".mp3"))
                        listBox4.Items.Add(Path.GetFileName(s));
                }
            }

            catch(NullReferenceException)
            {

            }

            catch(ArgumentNullException)
            {

            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
