﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Browse : Form
    {
        public static string filename, pathname;
        public static bool folder = false;

        public Browse()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!folder)
            {
                openFileDialog1.Filter = "Muzyka (*.mp3) | *.mp3";
                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pathname = openFileDialog1.FileName;
                    filename = openFileDialog1.SafeFileName;
                    textBox1.Text = pathname;
                }
            }

            if (folder)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    pathname = folderBrowserDialog1.SelectedPath;
                    textBox1.Text = pathname;
                }
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Save(pathname);
                folder = false;
                Application.Restart();
                Close();
            }

            catch (NullReferenceException)
            {
                Close();
            }

            catch (ArgumentNullException)
            {
                Close();
            }
        }



        private void Browse_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save(string path)
        {
            if (!folder)
            {
                try
                {
                    File.Copy(path, @"music\" + filename, true);
                }

                catch (ArgumentNullException)
                {

                }
            }

            if (folder)
            {
                try
                {
                    string foldername = Path.GetFileName(pathname);
                    string[] files = Directory.GetFiles(pathname);
                    Directory.Move(pathname, @"music\" + foldername);
                    Thread.Sleep(1000);

                    foreach (string s in files)
                    {
                        if (File.Exists(@"music\" + foldername + @"\" + Path.GetFileName(s)))
                        {
                            if (!Path.GetFileName(s).Contains(".mp3"))
                            {
                                File.Delete(@"music\" + foldername + @"\" + Path.GetFileName(s));
                            }
                        }

                        Thread.Sleep(1000);

                        try
                        {
                            File.Copy(@"music\" + foldername + @"\" + Path.GetFileName(s), @"music\" + Path.GetFileName(s), true);
                        }

                        catch (FileNotFoundException)
                        {

                        }
                    }

                }

                catch (NullReferenceException)
                {

                }
            }
        }
    }
}