namespace MusicPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.downloadbutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.removebutton = new System.Windows.Forms.Button();
            this.folderbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORPLAYLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choosePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMusicToPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foundABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChoosePlaylistPanel = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.ChoosePlaylistPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Silver;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 156);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(437, 156);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // downloadbutton
            // 
            this.downloadbutton.BackColor = System.Drawing.Color.Green;
            this.downloadbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadbutton.Enabled = false;
            this.downloadbutton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.downloadbutton.FlatAppearance.BorderSize = 2;
            this.downloadbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.downloadbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.downloadbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.downloadbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.downloadbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.downloadbutton.Location = new System.Drawing.Point(12, 322);
            this.downloadbutton.Name = "downloadbutton";
            this.downloadbutton.Size = new System.Drawing.Size(88, 35);
            this.downloadbutton.TabIndex = 4;
            this.downloadbutton.Text = "Download";
            this.downloadbutton.UseVisualStyleBackColor = false;
            this.downloadbutton.Visible = false;
            this.downloadbutton.Click += new System.EventHandler(this.Downloadbutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.Green;
            this.addbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbutton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.addbutton.FlatAppearance.BorderSize = 2;
            this.addbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.addbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.addbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addbutton.Location = new System.Drawing.Point(106, 322);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(88, 35);
            this.addbutton.TabIndex = 5;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // removebutton
            // 
            this.removebutton.BackColor = System.Drawing.Color.Green;
            this.removebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removebutton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.removebutton.FlatAppearance.BorderSize = 2;
            this.removebutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.removebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.removebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.removebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removebutton.Location = new System.Drawing.Point(200, 322);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(88, 35);
            this.removebutton.TabIndex = 6;
            this.removebutton.Text = "Remove";
            this.removebutton.UseVisualStyleBackColor = false;
            this.removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // folderbutton
            // 
            this.folderbutton.BackColor = System.Drawing.Color.Green;
            this.folderbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.folderbutton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.folderbutton.FlatAppearance.BorderSize = 2;
            this.folderbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.folderbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.folderbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.folderbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.folderbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.folderbutton.Location = new System.Drawing.Point(294, 322);
            this.folderbutton.Name = "folderbutton";
            this.folderbutton.Size = new System.Drawing.Size(155, 35);
            this.folderbutton.TabIndex = 7;
            this.folderbutton.Text = "Open Folder with Music";
            this.folderbutton.UseVisualStyleBackColor = false;
            this.folderbutton.Click += new System.EventHandler(this.Folderbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Navy;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(11, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(437, 22);
            this.textBox1.TabIndex = 10;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 108);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(437, 45);
            this.axWindowsMediaPlayer1.TabIndex = 11;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.AxWindowsMediaPlayer1_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.loopToolStripMenuItem,
            this.playlistToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(461, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // loopToolStripMenuItem
            // 
            this.loopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turnONToolStripMenuItem,
            this.turnOFFToolStripMenuItem,
            this.fORPLAYLISTToolStripMenuItem});
            this.loopToolStripMenuItem.Name = "loopToolStripMenuItem";
            this.loopToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.loopToolStripMenuItem.Text = "Loop";
            // 
            // turnONToolStripMenuItem
            // 
            this.turnONToolStripMenuItem.Name = "turnONToolStripMenuItem";
            this.turnONToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.turnONToolStripMenuItem.Text = "On";
            this.turnONToolStripMenuItem.Click += new System.EventHandler(this.TurnONToolStripMenuItem_Click);
            // 
            // turnOFFToolStripMenuItem
            // 
            this.turnOFFToolStripMenuItem.Checked = true;
            this.turnOFFToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.turnOFFToolStripMenuItem.Name = "turnOFFToolStripMenuItem";
            this.turnOFFToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.turnOFFToolStripMenuItem.Text = "Off";
            this.turnOFFToolStripMenuItem.Click += new System.EventHandler(this.TurnOFFToolStripMenuItem_Click);
            // 
            // fORPLAYLISTToolStripMenuItem
            // 
            this.fORPLAYLISTToolStripMenuItem.CheckOnClick = true;
            this.fORPLAYLISTToolStripMenuItem.Name = "fORPLAYLISTToolStripMenuItem";
            this.fORPLAYLISTToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.fORPLAYLISTToolStripMenuItem.Text = "Playlist";
            this.fORPLAYLISTToolStripMenuItem.Click += new System.EventHandler(this.FORPLAYLISTToolStripMenuItem_Click);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allMusicToolStripMenuItem,
            this.choosePlaylistToolStripMenuItem,
            this.addMusicToPlaylistToolStripMenuItem,
            this.importPlaylistToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.playlistToolStripMenuItem.Text = "Playlist";
            // 
            // allMusicToolStripMenuItem
            // 
            this.allMusicToolStripMenuItem.Name = "allMusicToolStripMenuItem";
            this.allMusicToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.allMusicToolStripMenuItem.Text = "All music";
            this.allMusicToolStripMenuItem.Click += new System.EventHandler(this.AllMusicToolStripMenuItem_Click);
            // 
            // choosePlaylistToolStripMenuItem
            // 
            this.choosePlaylistToolStripMenuItem.Name = "choosePlaylistToolStripMenuItem";
            this.choosePlaylistToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.choosePlaylistToolStripMenuItem.Text = "Choose Playlist";
            this.choosePlaylistToolStripMenuItem.Click += new System.EventHandler(this.ChoosePlaylistToolStripMenuItem_Click);
            // 
            // addMusicToPlaylistToolStripMenuItem
            // 
            this.addMusicToPlaylistToolStripMenuItem.Name = "addMusicToPlaylistToolStripMenuItem";
            this.addMusicToPlaylistToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.addMusicToPlaylistToolStripMenuItem.Text = "Add/Remove Music to Playlist";
            this.addMusicToPlaylistToolStripMenuItem.Click += new System.EventHandler(this.AddMusicToPlaylistToolStripMenuItem_Click);
            // 
            // importPlaylistToolStripMenuItem
            // 
            this.importPlaylistToolStripMenuItem.Name = "importPlaylistToolStripMenuItem";
            this.importPlaylistToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.importPlaylistToolStripMenuItem.Text = "Import Playlist";
            this.importPlaylistToolStripMenuItem.Click += new System.EventHandler(this.ImportPlaylistToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.settingsToolStripMenuItem.Text = "Create/Delete Playlist";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem,
            this.foundABugToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutProgramToolStripMenuItem.Text = "About Program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // foundABugToolStripMenuItem
            // 
            this.foundABugToolStripMenuItem.Name = "foundABugToolStripMenuItem";
            this.foundABugToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.foundABugToolStripMenuItem.Text = "Found A bug?";
            this.foundABugToolStripMenuItem.Click += new System.EventHandler(this.FoundABugToolStripMenuItem_Click);
            // 
            // ChoosePlaylistPanel
            // 
            this.ChoosePlaylistPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChoosePlaylistPanel.BackgroundImage")));
            this.ChoosePlaylistPanel.Controls.Add(this.listBox2);
            this.ChoosePlaylistPanel.Controls.Add(this.button1);
            this.ChoosePlaylistPanel.Location = new System.Drawing.Point(0, 0);
            this.ChoosePlaylistPanel.Name = "ChoosePlaylistPanel";
            this.ChoosePlaylistPanel.Size = new System.Drawing.Size(460, 369);
            this.ChoosePlaylistPanel.TabIndex = 13;
            this.ChoosePlaylistPanel.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(437, 290);
            this.listBox2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "CHOOSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.textBox1);
            this.MainPanel.Controls.Add(this.folderbutton);
            this.MainPanel.Controls.Add(this.removebutton);
            this.MainPanel.Controls.Add(this.axWindowsMediaPlayer1);
            this.MainPanel.Controls.Add(this.addbutton);
            this.MainPanel.Controls.Add(this.downloadbutton);
            this.MainPanel.Controls.Add(this.listBox1);
            this.MainPanel.Controls.Add(this.menuStrip1);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(461, 396);
            this.MainPanel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(460, 369);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ChoosePlaylistPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MusicPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ChoosePlaylistPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button downloadbutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button removebutton;
        private System.Windows.Forms.Button folderbutton;
        private System.Windows.Forms.TextBox textBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnOFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fORPLAYLISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choosePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel ChoosePlaylistPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ToolStripMenuItem allMusicToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStripMenuItem addMusicToPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foundABugToolStripMenuItem;
    }
}

