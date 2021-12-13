using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        private void JuiceIt_Click(object sender, EventArgs e)
        {
            foreach (FileInfo file in new DirectoryInfo(PathText.Text).GetFiles())
            {
                string Name = Path.GetFileName(file.FullName).Split('.')[0].Trim();
                string Path_ = file.FullName;

                TagLib.File f = TagLib.File.Create(Path_);
                f.Tag.Album = Album.Text;
                string[] text = { Artist.Text };
                f.Tag.Artists = text;
                f.Tag.Title = Name;
                f.Save();
            }
        }
    }
}
