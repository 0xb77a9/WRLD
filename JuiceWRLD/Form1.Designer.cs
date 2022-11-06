namespace JuiceWRLD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OpenDialog = new System.Windows.Forms.Button();
            this.PathText = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.Artist = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Album = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.JuiceIt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Backup = new System.Windows.Forms.CheckBox();
            this.SubFolders = new System.Windows.Forms.CheckBox();
            this.ImagePath = new System.Windows.Forms.TextBox();
            this.ImageSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ChangeImage = new System.Windows.Forms.CheckBox();
            this.OnlyEmptyTitle = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AlbumUseFolderName = new System.Windows.Forms.CheckBox();
            this.FirstShit = new System.Windows.Forms.NumericUpDown();
            this.EWC = new System.Windows.Forms.CheckBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.Remove_2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.AlbumSmartMode = new System.Windows.Forms.CheckBox();
            this.BeautifyTitle = new System.Windows.Forms.CheckBox();
            this.Comment = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FirstShit)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenDialog
            // 
            this.OpenDialog.Location = new System.Drawing.Point(880, 12);
            this.OpenDialog.Name = "OpenDialog";
            this.OpenDialog.Size = new System.Drawing.Size(40, 20);
            this.OpenDialog.TabIndex = 0;
            this.OpenDialog.Text = "...";
            this.OpenDialog.UseVisualStyleBackColor = true;
            this.OpenDialog.Click += new System.EventHandler(this.OpenDialog_Click);
            // 
            // PathText
            // 
            this.PathText.Location = new System.Drawing.Point(47, 12);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(824, 20);
            this.PathText.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Artist";
            // 
            // Artist
            // 
            this.Artist.Location = new System.Drawing.Point(40, 117);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(100, 20);
            this.Artist.TabIndex = 3;
            this.Artist.Text = "Juice WRLD";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(377, 117);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 20);
            this.Title.TabIndex = 5;
            this.Title.Text = "<fn>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // Album
            // 
            this.Album.Location = new System.Drawing.Point(802, 117);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(100, 20);
            this.Album.TabIndex = 7;
            this.Album.Text = "Unreleased";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(762, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Album";
            // 
            // JuiceIt
            // 
            this.JuiceIt.Location = new System.Drawing.Point(208, 259);
            this.JuiceIt.Name = "JuiceIt";
            this.JuiceIt.Size = new System.Drawing.Size(533, 23);
            this.JuiceIt.TabIndex = 8;
            this.JuiceIt.Text = "Juice It!";
            this.JuiceIt.UseVisualStyleBackColor = true;
            this.JuiceIt.Click += new System.EventHandler(this.JuiceIt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(146, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Leave it Blank, to not change it.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(146, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Multi = Juice, Lil peep, ...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(9, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Use \"Comma\" to Split.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(762, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Leave it Blank, to not change it.";
            // 
            // Backup
            // 
            this.Backup.AutoSize = true;
            this.Backup.Checked = true;
            this.Backup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Backup.Location = new System.Drawing.Point(10, 262);
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(63, 17);
            this.Backup.TabIndex = 14;
            this.Backup.Text = "Backup";
            this.Backup.UseVisualStyleBackColor = true;
            // 
            // SubFolders
            // 
            this.SubFolders.AutoSize = true;
            this.SubFolders.Location = new System.Drawing.Point(747, 262);
            this.SubFolders.Name = "SubFolders";
            this.SubFolders.Size = new System.Drawing.Size(162, 17);
            this.SubFolders.TabIndex = 15;
            this.SubFolders.Text = "Search in SubFolders as well";
            this.SubFolders.UseVisualStyleBackColor = true;
            // 
            // ImagePath
            // 
            this.ImagePath.Location = new System.Drawing.Point(79, 48);
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.Size = new System.Drawing.Size(792, 20);
            this.ImagePath.TabIndex = 17;
            // 
            // ImageSearch
            // 
            this.ImageSearch.Location = new System.Drawing.Point(880, 48);
            this.ImageSearch.Name = "ImageSearch";
            this.ImageSearch.Size = new System.Drawing.Size(40, 20);
            this.ImageSearch.TabIndex = 16;
            this.ImageSearch.Text = "...";
            this.ImageSearch.UseVisualStyleBackColor = true;
            this.ImageSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Path";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Image Path";
            // 
            // ChangeImage
            // 
            this.ChangeImage.AutoSize = true;
            this.ChangeImage.Location = new System.Drawing.Point(79, 262);
            this.ChangeImage.Name = "ChangeImage";
            this.ChangeImage.Size = new System.Drawing.Size(126, 17);
            this.ChangeImage.TabIndex = 20;
            this.ChangeImage.Text = "Change Cover Image";
            this.ChangeImage.UseVisualStyleBackColor = true;
            // 
            // OnlyEmptyTitle
            // 
            this.OnlyEmptyTitle.AutoSize = true;
            this.OnlyEmptyTitle.Location = new System.Drawing.Point(350, 97);
            this.OnlyEmptyTitle.Name = "OnlyEmptyTitle";
            this.OnlyEmptyTitle.Size = new System.Drawing.Size(120, 17);
            this.OnlyEmptyTitle.TabIndex = 21;
            this.OnlyEmptyTitle.Text = "Only if Title is Empty";
            this.OnlyEmptyTitle.UseVisualStyleBackColor = true;
            this.OnlyEmptyTitle.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(346, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Leave it Blank, to not change it.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(483, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "< fn > to use file name";
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(400, 156);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(77, 20);
            this.Remove.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(347, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Remove";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(483, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Multi = By Juice, Official Visual, etc...";
            // 
            // AlbumUseFolderName
            // 
            this.AlbumUseFolderName.AutoSize = true;
            this.AlbumUseFolderName.Location = new System.Drawing.Point(765, 97);
            this.AlbumUseFolderName.Name = "AlbumUseFolderName";
            this.AlbumUseFolderName.Size = new System.Drawing.Size(106, 17);
            this.AlbumUseFolderName.TabIndex = 27;
            this.AlbumUseFolderName.Text = "Use Folder name";
            this.AlbumUseFolderName.UseVisualStyleBackColor = true;
            // 
            // FirstShit
            // 
            this.FirstShit.Location = new System.Drawing.Point(502, 136);
            this.FirstShit.Name = "FirstShit";
            this.FirstShit.Size = new System.Drawing.Size(88, 20);
            this.FirstShit.TabIndex = 29;
            // 
            // EWC
            // 
            this.EWC.AutoSize = true;
            this.EWC.Location = new System.Drawing.Point(476, 97);
            this.EWC.Name = "EWC";
            this.EWC.Size = new System.Drawing.Size(114, 17);
            this.EWC.TabIndex = 30;
            this.EWC.Text = "Every word Capital";
            this.EWC.UseVisualStyleBackColor = true;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalLabel.Location = new System.Drawing.Point(205, 239);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(30, 17);
            this.TotalLabel.TabIndex = 31;
            this.TotalLabel.Text = "Idle";
            // 
            // Remove_2
            // 
            this.Remove_2.Location = new System.Drawing.Point(815, 159);
            this.Remove_2.Name = "Remove_2";
            this.Remove_2.Size = new System.Drawing.Size(87, 20);
            this.Remove_2.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(762, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Remove";
            // 
            // AlbumSmartMode
            // 
            this.AlbumSmartMode.AutoSize = true;
            this.AlbumSmartMode.Location = new System.Drawing.Point(765, 185);
            this.AlbumSmartMode.Name = "AlbumSmartMode";
            this.AlbumSmartMode.Size = new System.Drawing.Size(83, 17);
            this.AlbumSmartMode.TabIndex = 34;
            this.AlbumSmartMode.Text = "Smart Mode";
            this.AlbumSmartMode.UseVisualStyleBackColor = true;
            this.AlbumSmartMode.CheckedChanged += new System.EventHandler(this.AlbumSmartMode_CheckedChanged);
            // 
            // BeautifyTitle
            // 
            this.BeautifyTitle.AutoSize = true;
            this.BeautifyTitle.Location = new System.Drawing.Point(350, 182);
            this.BeautifyTitle.Name = "BeautifyTitle";
            this.BeautifyTitle.Size = new System.Drawing.Size(64, 17);
            this.BeautifyTitle.TabIndex = 35;
            this.BeautifyTitle.Text = "Beautify";
            this.BeautifyTitle.UseVisualStyleBackColor = true;
            // 
            // Comment
            // 
            this.Comment.Location = new System.Drawing.Point(10, 162);
            this.Comment.Multiline = true;
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(260, 74);
            this.Comment.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Comment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(932, 291);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.BeautifyTitle);
            this.Controls.Add(this.AlbumSmartMode);
            this.Controls.Add(this.Remove_2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.EWC);
            this.Controls.Add(this.FirstShit);
            this.Controls.Add(this.AlbumUseFolderName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.OnlyEmptyTitle);
            this.Controls.Add(this.ChangeImage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ImagePath);
            this.Controls.Add(this.ImageSearch);
            this.Controls.Add(this.SubFolders);
            this.Controls.Add(this.Backup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.JuiceIt);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Artist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.OpenDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WRLDofVibes     By BETA#0999";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FirstShit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenDialog;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Artist;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Album;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button JuiceIt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox Backup;
        private System.Windows.Forms.CheckBox SubFolders;
        private System.Windows.Forms.TextBox ImagePath;
        private System.Windows.Forms.Button ImageSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ChangeImage;
        private System.Windows.Forms.CheckBox OnlyEmptyTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Remove;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox AlbumUseFolderName;
        private System.Windows.Forms.NumericUpDown FirstShit;
        private System.Windows.Forms.CheckBox EWC;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox Remove_2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox AlbumSmartMode;
        private System.Windows.Forms.CheckBox BeautifyTitle;
        private System.Windows.Forms.TextBox Comment;
        private System.Windows.Forms.Label label14;
    }
}

