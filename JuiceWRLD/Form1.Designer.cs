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
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenDialog
            // 
            this.OpenDialog.Location = new System.Drawing.Point(745, 12);
            this.OpenDialog.Name = "OpenDialog";
            this.OpenDialog.Size = new System.Drawing.Size(40, 20);
            this.OpenDialog.TabIndex = 0;
            this.OpenDialog.Text = "...";
            this.OpenDialog.UseVisualStyleBackColor = true;
            this.OpenDialog.Click += new System.EventHandler(this.OpenDialog_Click);
            // 
            // PathText
            // 
            this.PathText.Location = new System.Drawing.Point(12, 12);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(727, 20);
            this.PathText.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Artist";
            // 
            // Artist
            // 
            this.Artist.Location = new System.Drawing.Point(40, 49);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(100, 20);
            this.Artist.TabIndex = 3;
            this.Artist.Text = "Juice WRLD";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(361, 49);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 20);
            this.Title.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // Album
            // 
            this.Album.Location = new System.Drawing.Point(685, 49);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(100, 20);
            this.Album.TabIndex = 7;
            this.Album.Text = "Unreleased";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Album";
            // 
            // JuiceIt
            // 
            this.JuiceIt.Location = new System.Drawing.Point(208, 144);
            this.JuiceIt.Name = "JuiceIt";
            this.JuiceIt.Size = new System.Drawing.Size(407, 23);
            this.JuiceIt.TabIndex = 8;
            this.JuiceIt.Text = "Juice It!";
            this.JuiceIt.UseVisualStyleBackColor = true;
            this.JuiceIt.Click += new System.EventHandler(this.JuiceIt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(330, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Leave it Blank, to use file name.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(797, 179);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.JuiceIt);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Artist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.OpenDialog);
            this.Name = "Form1";
            this.Text = "WRLDofVibes";
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
        private System.Windows.Forms.Label label4;
    }
}

