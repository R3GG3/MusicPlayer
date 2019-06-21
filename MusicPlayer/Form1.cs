using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using Microsoft.Win32;
using System.Threading;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public static string FileName;
        public static bool first = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((e.newState == 1) && (turnONToolStripMenuItem.Checked) && (!fORPLAYLISTToolStripMenuItem.Checked))
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                return;
            }
        }

        private void player_PlayStateChange1(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((e.newState == 1) && (turnOFFToolStripMenuItem.Checked))
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                return;
            }
        }

        private void player_PlayStateChange2(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

            if ((fORPLAYLISTToolStripMenuItem.Checked) && (e.newState == 8))
            {
                try
                {
                    listBox1.SelectedItem = listBox1.Items[listBox1.SelectedIndex + 1];
                }

                catch (ArgumentOutOfRangeException)
                {
                    listBox1.SelectedItem = listBox1.Items[0];
                }

                textBox1.Text = listBox1.SelectedItem.ToString();
                Newurl();
                first = false;
            }

            if ((e.newState == 10) && (!first))
            {
                Thread.Sleep(500);
                axWindowsMediaPlayer1.Ctlcontrols.play();
                first = true;
            }
        }

        private void Downloadbutton_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://www.youtube.com/");
            Process.Start("chrome.exe", "https://www.onlinevideoconverter.com/pl");
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            Browse browse = new Browse();
            browse.Show();
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(@"music\" + listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

            catch (UnauthorizedAccessException)
            {

            }

        }

        private void Folderbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", @"music\");
            }

            catch (DirectoryNotFoundException)
            {

            }
        }

        private void AxWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = @"music\" + listBox1.SelectedItem.ToString();
                axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange);
                axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange1);
                axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange2);
            }


            catch (NullReferenceException)
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChoosePlaylistPanel.Visible = false;

            if (!Directory.Exists("music"))
            {
                Directory.CreateDirectory(@"music");
            }

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

            try
            {
                string[] files = Directory.GetFiles(@"music\");

                foreach (string s in files)
                {
                    listBox1.Items.Add(Path.GetFileName(s));
                    listBox1.Sorted = true;
                }
            }

            catch (FileNotFoundException)
            {

            }

            listBox1.SelectedItem = listBox1.Items[0];
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void Newurl()
        {
            axWindowsMediaPlayer1.URL = @"music\" + listBox1.SelectedItem.ToString();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void SettingsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Playlist playlist = new Playlist();
            playlist.Show();
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was made by Lodomir, all Rights Reserved!", "Info");
        }

        private void TurnONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turnONToolStripMenuItem.Checked = true;
            turnONToolStripMenuItem.CheckState = CheckState.Checked;

            turnOFFToolStripMenuItem.Checked = false;
            turnOFFToolStripMenuItem.CheckState = CheckState.Unchecked;

            fORPLAYLISTToolStripMenuItem.Checked = false;
            fORPLAYLISTToolStripMenuItem.CheckState = CheckState.Unchecked;
        }

        private void TurnOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turnOFFToolStripMenuItem.Checked = true;
            turnOFFToolStripMenuItem.CheckState = CheckState.Checked;

            turnONToolStripMenuItem.Checked = false;
            turnONToolStripMenuItem.CheckState = CheckState.Unchecked;

            fORPLAYLISTToolStripMenuItem.Checked = false;
            fORPLAYLISTToolStripMenuItem.CheckState = CheckState.Unchecked;
        }

        private void ChoosePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoosePlaylistPanel.Visible = true;
            MainPanel.Visible = false;
        }






        private void FORPLAYLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turnOFFToolStripMenuItem.Checked = false;
            turnOFFToolStripMenuItem.CheckState = CheckState.Unchecked;

            turnONToolStripMenuItem.Checked = false;
            turnONToolStripMenuItem.CheckState = CheckState.Unchecked;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] files = Directory.GetFiles(@"music\" + listBox2.SelectedItem.ToString() + @"\");
                listBox1.Items.Clear();

                foreach (string s in files)
                {
                    listBox1.BeginUpdate();
                    listBox1.Items.Add(Path.GetFileName(s));
                    listBox1.Sorted = true;
                    listBox1.EndUpdate();
                    listBox1.Update();
                }

            }

            catch (NullReferenceException)
            {

            }

            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Nie ma takiej ścieżki!");
                listBox2.Items.Remove(listBox2.SelectedItem);
            }

            ChoosePlaylistPanel.Visible = false;
            MainPanel.Visible = true;
        }

        private void AllMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] files = Directory.GetFiles(@"music\");
                listBox1.Items.Clear();

                foreach (string s in files)
                {
                    listBox1.Items.Add(Path.GetFileName(s));
                    listBox1.Sorted = true;
                    listBox1.Refresh();
                }
                ChoosePlaylistPanel.Visible = false;
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Wybierz Playlistę, lub zamknij opcję!");
                ChoosePlaylistPanel.Visible = false;
            }
        }

        private void AddMusicToPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRemoveMusicToPlaylist option = new AddRemoveMusicToPlaylist();
            option.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ImportPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Browse browse = new Browse();
            Browse.folder = true;
            browse.Show();
        }
    }
}