using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using IO = System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net;
using System.Management;
using System.Text.RegularExpressions;
using System.Windows;
using System.Xml;
using System.IO.Compression;
using TagLib;

namespace JuiceWRLD
{
    public partial class Form1 : Form
    {
        string BackupName;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenDialog_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    PathText.Text = fbd.SelectedPath;
                }
            }
        }
        public void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in IO.Directory.GetDirectories(sDir))
                {
                    if (!d.Contains("Backup") && d != PathText.Text)
                    {
                        foreach (IO.FileInfo file in new IO.DirectoryInfo(d).GetFiles())
                        {
                            string Name = IO.Path.GetFileName(file.FullName);
                            string Path_ = file.FullName;

                            if (Name.Contains(".mp3") || Name.Contains(".m4a") || Name.Contains(".wav"))
                            {
                                if (Backup.Checked == true)
                                {
                                    IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(file.FullName) + BackupName);
                                    IO.File.Copy(file.FullName, IO.Path.GetDirectoryName(file.FullName) + BackupName + Name, true);
                                }
                                File f = File.Create(Path_);
                                if (!string.IsNullOrWhiteSpace(Album.Text))
                                {
                                    f.Tag.Album = Album.Text;
                                }
                                if (!string.IsNullOrWhiteSpace(Artist.Text))
                                {
                                    string[] Final = Artist.Text.Split(',');
                                    f.Tag.Artists = Final;
                                }
                                if (!string.IsNullOrWhiteSpace(Title.Text))
                                {
                                    if (OnlyEmptyTitle.Checked == true)
                                    {
                                        if (string.IsNullOrWhiteSpace(f.Tag.Title))
                                        {
                                            if (Title.Text == "< fn >" || Title.Text == "<fn>")
                                            {
                                                f.Tag.Title = Name.Split('.')[0].Trim();
                                            }
                                            else
                                            {
                                                f.Tag.Title = Title.Text;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Title.Text == "< fn >" || Title.Text == "<fn>")
                                        {
                                            f.Tag.Title = Name.Split('.')[0].Trim();
                                        }
                                        else
                                        {
                                            f.Tag.Title = Title.Text;
                                        }
                                    }
                                }
                                if (ChangeImage.Checked == true)
                                {
                                    if (!string.IsNullOrWhiteSpace(ImagePath.Text))
                                    {
                                        var imgPath = ImagePath.Text;
                                        if (System.IO.File.Exists(imgPath))
                                        {
                                            var pic = new IPicture[1];
                                            pic[0] = new Picture(imgPath);
                                            f.Tag.Pictures = pic;
                                        }
                                    }
                                }
                                f.Save();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void JuiceIt_Click(object sender, EventArgs e)
        {
            BackupName = "\\Backup_" + Convert.ToString(DateTime.Now.Date).Replace("/", "_").Replace(":", "_").Replace(" ", "__").Replace("12_00_00__AM", Convert.ToString(DateTime.Now.Hour) + "_" + Convert.ToString(DateTime.Now.Minute) + "_" + Convert.ToString(DateTime.Now.Second)) + "\\";
            foreach (IO.FileInfo file in new IO.DirectoryInfo(PathText.Text).GetFiles())
            {
                string Name = IO.Path.GetFileName(file.FullName);
                string Path_ = file.FullName;
                string[] R = Remove.Text.Split(',');
                string TitleFromName = Name.Split('.')[0].Trim();
                if (!string.IsNullOrWhiteSpace(Remove.Text))
                {
                    foreach (string RemoveThis in R)
                    {
                        TitleFromName = TitleFromName.Replace(RemoveThis, "");
                    }
                }
                if (Name.Contains(".mp3") || Name.Contains(".m4a") || Name.Contains(".wav"))
                {
                    if (Backup.Checked == true)
                    {
                        IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(file.FullName) + BackupName);
                        IO.File.Copy(file.FullName, IO.Path.GetDirectoryName(file.FullName) + BackupName + Name, true);
                    }
                    File f = File.Create(Path_);
                    if (!string.IsNullOrWhiteSpace(Album.Text))
                    {
                        f.Tag.Album = Album.Text;
                    }
                    if (!string.IsNullOrWhiteSpace(Artist.Text))
                    {
                        string[] Final = Artist.Text.Split(',');
                        f.Tag.Artists = Final;
                    }
                    if (!string.IsNullOrWhiteSpace(Title.Text))
                    {
                        if (OnlyEmptyTitle.Checked == true)
                        {
                            if (string.IsNullOrWhiteSpace(f.Tag.Title))
                            {
                                if (Title.Text == "< fn >" || Title.Text == "<fn>")
                                {
                                    f.Tag.Title = TitleFromName;
                                }
                                else
                                {
                                    f.Tag.Title = Title.Text;
                                }
                            }
                        }
                        else
                        {
                            if (Title.Text == "< fn >" || Title.Text == "<fn>")
                            {
                                f.Tag.Title = TitleFromName;
                            }
                            else
                            {
                                f.Tag.Title = Title.Text;
                            }
                        }
                    }
                    if (ChangeImage.Checked == true)
                    {
                        if (!string.IsNullOrWhiteSpace(ImagePath.Text))
                        {
                            var imgPath = ImagePath.Text;
                            if (System.IO.File.Exists(imgPath))
                            {
                                var pic = new IPicture[1];
                                pic[0] = new Picture(imgPath);
                                f.Tag.Pictures = pic;
                            }
                        }
                    }
                    f.Save();
                }
            }

            if (SubFolders.Checked == true)
            {
                DirSearch(PathText.Text);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "JPG & PNG|*.jpg;*.png";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                ImagePath.Text = selectedFileName;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
