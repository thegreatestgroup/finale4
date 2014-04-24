namespace music
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.submitAddSong = new System.Windows.Forms.Button();
            this.addSongGenre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addSongYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addComposer = new System.Windows.Forms.TextBox();
            this.addAlbum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addArtist = new System.Windows.Forms.TextBox();
            this.addSongName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.submitRemoveSome = new System.Windows.Forms.Button();
            this.removeAlbumName = new System.Windows.Forms.TextBox();
            this.removeSongName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.navMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // navMenu
            // 
            this.navMenu.Controls.Add(this.tabPage1);
            this.navMenu.Controls.Add(this.tabPage2);
            this.navMenu.Controls.Add(this.tabPage3);
            this.navMenu.Location = new System.Drawing.Point(13, 13);
            this.navMenu.Name = "navMenu";
            this.navMenu.SelectedIndex = 0;
            this.navMenu.Size = new System.Drawing.Size(1071, 583);
            this.navMenu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1063, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Songs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1050, 544);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.submitAddSong);
            this.tabPage2.Controls.Add(this.addSongGenre);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.addSongYear);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.addComposer);
            this.tabPage2.Controls.Add(this.addAlbum);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.addArtist);
            this.tabPage2.Controls.Add(this.addSongName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1063, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add/Update Song";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // submitAddSong
            // 
            this.submitAddSong.Location = new System.Drawing.Point(55, 194);
            this.submitAddSong.Name = "submitAddSong";
            this.submitAddSong.Size = new System.Drawing.Size(75, 23);
            this.submitAddSong.TabIndex = 12;
            this.submitAddSong.Text = "Add/Update";
            this.submitAddSong.UseVisualStyleBackColor = true;
            // 
            // addSongGenre
            // 
            this.addSongGenre.Location = new System.Drawing.Point(75, 146);
            this.addSongGenre.Name = "addSongGenre";
            this.addSongGenre.Size = new System.Drawing.Size(100, 20);
            this.addSongGenre.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Genre";
            // 
            // addSongYear
            // 
            this.addSongYear.Location = new System.Drawing.Point(75, 116);
            this.addSongYear.Name = "addSongYear";
            this.addSongYear.Size = new System.Drawing.Size(100, 20);
            this.addSongYear.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Year";
            // 
            // addComposer
            // 
            this.addComposer.Location = new System.Drawing.Point(75, 89);
            this.addComposer.Name = "addComposer";
            this.addComposer.Size = new System.Drawing.Size(100, 20);
            this.addComposer.TabIndex = 7;
            // 
            // addAlbum
            // 
            this.addAlbum.Location = new System.Drawing.Point(75, 34);
            this.addAlbum.Name = "addAlbum";
            this.addAlbum.Size = new System.Drawing.Size(100, 20);
            this.addAlbum.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Album";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Composer";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addArtist
            // 
            this.addArtist.Location = new System.Drawing.Point(75, 62);
            this.addArtist.Name = "addArtist";
            this.addArtist.Size = new System.Drawing.Size(100, 20);
            this.addArtist.TabIndex = 3;
            // 
            // addSongName
            // 
            this.addSongName.Location = new System.Drawing.Point(75, 7);
            this.addSongName.Name = "addSongName";
            this.addSongName.Size = new System.Drawing.Size(100, 20);
            this.addSongName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.submitRemoveSome);
            this.tabPage3.Controls.Add(this.removeAlbumName);
            this.tabPage3.Controls.Add(this.removeSongName);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1063, 557);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Remove Song";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // submitRemoveSome
            // 
            this.submitRemoveSome.Location = new System.Drawing.Point(36, 73);
            this.submitRemoveSome.Name = "submitRemoveSome";
            this.submitRemoveSome.Size = new System.Drawing.Size(75, 23);
            this.submitRemoveSome.TabIndex = 4;
            this.submitRemoveSome.Text = "Remove";
            this.submitRemoveSome.UseVisualStyleBackColor = true;
            this.submitRemoveSome.Click += new System.EventHandler(this.submitRemoveSome_Click);
            // 
            // removeAlbumName
            // 
            this.removeAlbumName.Location = new System.Drawing.Point(62, 34);
            this.removeAlbumName.Name = "removeAlbumName";
            this.removeAlbumName.Size = new System.Drawing.Size(100, 20);
            this.removeAlbumName.TabIndex = 3;
            // 
            // removeSongName
            // 
            this.removeSongName.Location = new System.Drawing.Point(62, 7);
            this.removeSongName.Name = "removeSongName";
            this.removeSongName.Size = new System.Drawing.Size(100, 20);
            this.removeSongName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 608);
            this.Controls.Add(this.navMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.navMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl navMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox addSongName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addArtist;
        private System.Windows.Forms.TextBox removeAlbumName;
        private System.Windows.Forms.TextBox removeSongName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitRemoveSome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submitAddSong;
        private System.Windows.Forms.TextBox addSongGenre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addSongYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addComposer;
        private System.Windows.Forms.TextBox addAlbum;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

