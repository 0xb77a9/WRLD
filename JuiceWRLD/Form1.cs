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
using Microsoft;
using Microsoft.CSharp;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Globalization;

namespace JuiceWRLD
{
    public partial class Form1 : Form
    {
        string BackupName;
        int Total = 0;
        int fileCount = 1;
        string[] Formats = { ".mp3", ".m4a" };
        public Form1 ()
        {
            InitializeComponent();
        }

        private void OpenDialog_Click ( object sender, EventArgs e )
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            dialog.Title = "Select The Folder";
            if ( dialog.ShowDialog() == CommonFileDialogResult.Ok )
            {
                PathText.Text = dialog.FileName;
            }
        }
        public string Replace_ ( string Text, string Case, string ReplaceWith )
        {
            var regex = new Regex( Case, RegexOptions.IgnoreCase );
            return regex.Replace( Text, ReplaceWith );
        }
        public void DirSearch ( string sDir )
        {
            new Thread( () =>
            {
                Total = 0;
                fileCount = 0;
                try
                {
                    if ( !sDir.Contains( "Backup" ) && !sDir.Contains( "Broken" ) )
                    {
                        string[] files = IO.Directory.GetFiles( sDir, "*.mp3", IO.SearchOption.AllDirectories );
                        foreach ( var file in files )
                        {
                            string Name = IO.Path.GetFileName( file );
                            string Path_ = file;
                            if ( SubFolders.Checked != true )
                            {
                                fileCount = ( from file2 in IO.Directory.EnumerateFiles( PathText.Text, "*.*", IO.SearchOption.TopDirectoryOnly )
                                              select file2 ).Count();
                            }
                            else
                            {
                                fileCount = ( from file2 in IO.Directory.EnumerateFiles( PathText.Text, "*.*", IO.SearchOption.AllDirectories )
                                              select file2 ).Count();
                            }
                            string TitleFromName = Name.Substring( Convert.ToInt32( FirstShit.Value ) );
                            foreach ( string Temp_ in Formats )
                            {
                                TitleFromName = TitleFromName.Replace( Temp_, "" );
                            }
                            if ( Name.Contains( ".mp3" ) || Name.Contains( ".m4a" ) )
                            {
                                if ( Backup.Checked == true )
                                {
                                    IO.Directory.CreateDirectory( IO.Path.GetDirectoryName( Path_ ) + BackupName );
                                    IO.File.Copy( Path_, IO.Path.GetDirectoryName( Path_ ) + BackupName + Name, true );
                                }
                                try
                                {
                                    File f = File.Create( Path_, TagLib.ReadStyle.Average );
                                    var duration = ( int )f.Properties.Duration.TotalSeconds;
                                    if ( duration <= 0 )
                                    {
                                        IO.Directory.CreateDirectory( IO.Path.GetDirectoryName( Path_ ) + "\\Broken" );
                                        IO.File.Move( Path_, IO.Path.GetDirectoryName( Path_ ) + "\\Broken\\" + Name );
                                    }
                                }
                                catch
                                {
                                    IO.Directory.CreateDirectory( IO.Path.GetDirectoryName( Path_ ) + "\\Broken" );
                                    IO.File.Move( Path_, IO.Path.GetDirectoryName( Path_ ) + "\\Broken\\" + Name );
                                }
                                try
                                {
                                    File f = File.Create( Path_ );
                                    if ( !string.IsNullOrWhiteSpace( Album.Text ) )
                                    {
                                        if ( AlbumSmartMode.Checked != true )
                                        {
                                            if ( AlbumUseFolderName.Checked == true )
                                            {
                                                string[] Final = Remove_2.Text.Split( ',' );
                                                string dirName = new IO.DirectoryInfo( Path_.Replace( Name, "" ) ).Name;
                                                foreach ( string nigga in Final )
                                                {
                                                    dirName = dirName.Replace( nigga, "" );
                                                }
                                                f.Tag.Album = dirName;
                                            }
                                            else
                                            {
                                                f.Tag.Album = Album.Text;
                                            }
                                        }
                                        else
                                        {
                                            string TitleFromName_ = Name.Substring( Convert.ToInt32( FirstShit.Value ) );
                                            if ( TitleFromName_.ToLower().Contains( "aca" ) || TitleFromName_.ToLower().Contains( "acapella" ) || TitleFromName_.ToLower().Contains( "instrumental" ) || TitleFromName_.ToLower().Contains( "inst" ) )
                                            {
                                                if ( TitleFromName_.ToLower().Contains( "aca" ) || TitleFromName_.ToLower().Contains( "acapella" ) )
                                                {
                                                    f.Tag.Album = "Acapella";
                                                }
                                                else if ( TitleFromName_.ToLower().Contains( "instrumental" ) || TitleFromName_.ToLower().Contains( "inst" ) )
                                                {
                                                    f.Tag.Album = "Instrumental";
                                                }
                                            }
                                            else
                                            {
                                                if ( AlbumUseFolderName.Checked == true )
                                                {
                                                    string[] Final = Remove_2.Text.Split( ',' );
                                                    string dirName = new IO.DirectoryInfo( Path_.Replace( Name, "" ) ).Name;
                                                    foreach ( string nigga in Final )
                                                    {
                                                        dirName = dirName.Replace( nigga, "" );
                                                    }
                                                    f.Tag.Album = dirName;
                                                }
                                                else
                                                {
                                                    f.Tag.Album = Album.Text;
                                                }
                                            }
                                        }
                                    }
                                    if ( !string.IsNullOrWhiteSpace( Artist.Text ) )
                                    {
                                        string[] Final = Artist.Text.Split( ',' );
                                        f.Tag.Artists = Final;
                                    }
                                    if ( !string.IsNullOrWhiteSpace( Comment.Text ) )
                                    {
                                        f.Tag.Comment = Comment.Text;
                                    }
                                    if ( !string.IsNullOrWhiteSpace( Title.Text ) )
                                    {
                                        if ( BeautifyTitle.Checked == true )
                                        {
                                            TitleFromName = Replace_( TitleFromName, "dont", "Don't" );
                                            TitleFromName = Replace_( TitleFromName, "cant", "Can't" );
                                        }
                                        string[] R = Remove.Text.Split( ',' );
                                        if ( !string.IsNullOrWhiteSpace( Remove.Text ) )
                                        {
                                            foreach ( string RemoveThis in R )
                                            {
                                                TitleFromName = TitleFromName.Replace( RemoveThis, "" );
                                            }
                                        }
                                        if ( OnlyEmptyTitle.Checked == true )
                                        {
                                            if ( string.IsNullOrWhiteSpace( f.Tag.Title ) )
                                            {
                                                if ( Title.Text == "< fn >" || Title.Text == "<fn>" )
                                                {
                                                    if ( EWC.Checked == true )
                                                    {
                                                        TextInfo textInfo = new CultureInfo( "en-US", false ).TextInfo;
                                                        f.Tag.Title = textInfo.ToTitleCase( TitleFromName.ToLower() );
                                                    }
                                                    else
                                                    {
                                                        f.Tag.Title = TitleFromName;
                                                    }
                                                }
                                                else
                                                {
                                                    f.Tag.Title = Title.Text;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if ( Title.Text == "< fn >" || Title.Text == "<fn>" )
                                            {
                                                if ( EWC.Checked == true )
                                                {
                                                    TextInfo textInfo = new CultureInfo( "en-US", false ).TextInfo;
                                                    f.Tag.Title = textInfo.ToTitleCase( TitleFromName.ToLower() );
                                                }
                                                else
                                                {
                                                    f.Tag.Title = TitleFromName;
                                                }
                                            }
                                            else
                                            {
                                                f.Tag.Title = Title.Text;
                                            }
                                        }
                                    }
                                    if ( ChangeImage.Checked == true )
                                    {
                                        if ( !string.IsNullOrWhiteSpace( ImagePath.Text ) )
                                        {
                                            var imgPath = ImagePath.Text;
                                            if ( System.IO.File.Exists( imgPath ) )
                                            {
                                                var pic = new IPicture[1];
                                                pic[0] = new Picture( imgPath );
                                                f.Tag.Pictures = pic;
                                            }
                                        }
                                    }
                                    Total = Total + 1;
                                    TotalLabel.Text = Name + " (" + Total + " / " + fileCount + " ) ";
                                    Thread.Sleep( 100 );
                                    f.Save();
                                }
                                catch
                                {

                                }
                            }
                        }
                    }
                }
                catch ( Exception ex )
                {
                    MessageBox.Show( ex.Message );
                }
            } ).Start();
        }
        private void JuiceIt_Click ( object sender, EventArgs e )
        {
            new Thread( () =>
            {
                Total = 0;
                fileCount = 0;
                try
                {
                    BackupName = "\\Backup_" + Convert.ToString( DateTime.Now.Date ).Replace( "/", "_" ).Replace( ":", "_" ).Replace( " ", "__" ).Replace( "12_00_00__AM", Convert.ToString( DateTime.Now.Hour ) + "_" + Convert.ToString( DateTime.Now.Minute ) + "_" + Convert.ToString( DateTime.Now.Second ) ) + "\\";
                    foreach ( IO.FileInfo file in new IO.DirectoryInfo( PathText.Text ).GetFiles() )
                    {
                        string Name = IO.Path.GetFileName( file.FullName );
                        string Path_ = file.FullName;
                        if ( SubFolders.Checked != true )
                        {
                            fileCount = ( from file2 in IO.Directory.EnumerateFiles( PathText.Text, "*.*", IO.SearchOption.TopDirectoryOnly )
                                          select file2 ).Count();
                        }
                        else
                        {
                            fileCount = ( from file2 in IO.Directory.EnumerateFiles( PathText.Text, "*.*", IO.SearchOption.AllDirectories )
                                          select file2 ).Count();
                        }
                        string TitleFromName = Name.Substring( Convert.ToInt32( FirstShit.Value ) );
                        foreach ( string Temp_ in Formats )
                        {
                            TitleFromName = TitleFromName.Replace( Temp_, "" );
                        }
                        if ( Name.Contains( ".mp3" ) || Name.Contains( ".m4a" ) )
                        {
                            if ( Backup.Checked == true )
                            {
                                IO.Directory.CreateDirectory( IO.Path.GetDirectoryName( Path_ ) + BackupName );
                                IO.File.Copy( Path_, IO.Path.GetDirectoryName( Path_ ) + BackupName + Name, true );
                            }
                            try
                            {
                                File f = File.Create( Path_, TagLib.ReadStyle.Average );
                                var duration = ( int )f.Properties.Duration.TotalSeconds;
                                if ( duration <= 0 )
                                {
                                    IO.Directory.CreateDirectory( IO.Path.GetDirectoryName( Path_ ) + "\\Broken" );
                                    IO.File.Move( Path_, IO.Path.GetDirectoryName( Path_ ) + "\\Broken\\" + Name );
                                }
                            }
                            catch
                            {
                                IO.Directory.CreateDirectory( IO.Path.GetDirectoryName( Path_ ) + "\\Broken" );
                                IO.File.Move( Path_, IO.Path.GetDirectoryName( Path_ ) + "\\Broken\\" + Name );
                            }
                            try
                            {
                                File f = File.Create( Path_ );
                                if ( !string.IsNullOrWhiteSpace( Album.Text ) )
                                {
                                    if ( AlbumSmartMode.Checked != true )
                                    {
                                        if ( AlbumUseFolderName.Checked == true )
                                        {
                                            string[] Final = Remove_2.Text.Split( ',' );
                                            string dirName = new IO.DirectoryInfo( Path_.Replace( Name, "" ) ).Name;
                                            foreach ( string nigga in Final )
                                            {
                                                dirName = dirName.Replace( nigga, "" );
                                            }
                                            f.Tag.Album = dirName;
                                        }
                                        else
                                        {
                                            f.Tag.Album = Album.Text;
                                        }
                                    }
                                    else
                                    {
                                        string TitleFromName_ = Name.Substring( Convert.ToInt32( FirstShit.Value ) );
                                        if ( TitleFromName_.ToLower().Contains( "aca" ) || TitleFromName_.ToLower().Contains( "acapella" ) || TitleFromName_.ToLower().Contains( "instrumental" ) || TitleFromName_.ToLower().Contains( "inst" ) )
                                        {
                                            if ( TitleFromName_.ToLower().Contains( "aca" ) || TitleFromName_.ToLower().Contains( "acapella" ) )
                                            {
                                                f.Tag.Album = "Acapella";
                                            }
                                            else if ( TitleFromName_.ToLower().Contains( "instrumental" ) || TitleFromName_.ToLower().Contains( "inst" ) )
                                            {
                                                f.Tag.Album = "Instrumental";
                                            }
                                        }
                                        else
                                        {
                                            if ( AlbumUseFolderName.Checked == true )
                                            {
                                                string[] Final = Remove_2.Text.Split( ',' );
                                                string dirName = new IO.DirectoryInfo( Path_.Replace( Name, "" ) ).Name;
                                                foreach ( string nigga in Final )
                                                {
                                                    dirName = dirName.Replace( nigga, "" );
                                                }
                                                f.Tag.Album = dirName;
                                            }
                                            else
                                            {
                                                f.Tag.Album = Album.Text;
                                            }
                                        }
                                    }
                                }
                                if ( !string.IsNullOrWhiteSpace( Artist.Text ) )
                                {
                                    string[] Final = Artist.Text.Split( ',' );
                                    f.Tag.Artists = Final;
                                }
                                if ( !string.IsNullOrWhiteSpace( Comment.Text ) )
                                {
                                    f.Tag.Comment = Comment.Text;
                                }
                                if ( !string.IsNullOrWhiteSpace( Title.Text ) )
                                {
                                    if ( BeautifyTitle.Checked == true )
                                    {
                                        TitleFromName = Replace_( TitleFromName, "dont", "Don't" );
                                        TitleFromName = Replace_( TitleFromName, "cant", "Can't" );
                                        TitleFromName = Replace_( TitleFromName, "isnt", "Isn't" );
                                    }
                                    string[] R = Remove.Text.Split( ',' );
                                    if ( !string.IsNullOrWhiteSpace( Remove.Text ) )
                                    {
                                        foreach ( string RemoveThis in R )
                                        {
                                            TitleFromName = TitleFromName.Replace( RemoveThis, "" );
                                        }
                                    }
                                    if ( OnlyEmptyTitle.Checked == true )
                                    {
                                        if ( string.IsNullOrWhiteSpace( f.Tag.Title ) )
                                        {
                                            if ( Title.Text == "< fn >" || Title.Text == "<fn>" )
                                            {
                                                if ( EWC.Checked == true )
                                                {
                                                    TextInfo textInfo = new CultureInfo( "en-US", false ).TextInfo;
                                                    f.Tag.Title = textInfo.ToTitleCase( TitleFromName.ToLower() );
                                                }
                                                else
                                                {
                                                    f.Tag.Title = TitleFromName;
                                                }
                                            }
                                            else
                                            {
                                                f.Tag.Title = Title.Text;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if ( Title.Text == "< fn >" || Title.Text == "<fn>" )
                                        {
                                            if ( EWC.Checked == true )
                                            {
                                                TextInfo textInfo = new CultureInfo( "en-US", false ).TextInfo;
                                                f.Tag.Title = textInfo.ToTitleCase( TitleFromName.ToLower() );
                                            }
                                            else
                                            {
                                                f.Tag.Title = TitleFromName;
                                            }
                                        }
                                        else
                                        {
                                            f.Tag.Title = Title.Text;
                                        }
                                    }
                                }
                                if ( ChangeImage.Checked == true )
                                {
                                    if ( !string.IsNullOrWhiteSpace( ImagePath.Text ) )
                                    {
                                        var imgPath = ImagePath.Text;
                                        if ( System.IO.File.Exists( imgPath ) )
                                        {
                                            var pic = new IPicture[1];
                                            pic[0] = new Picture( imgPath );
                                            f.Tag.Pictures = pic;
                                        }
                                    }
                                }
                                Total = Total + 1;
                                TotalLabel.Text = Name + " (" + Total + " / " + fileCount + " ) ";
                                Thread.Sleep( 100 );
                                f.Save();
                            }
                            catch
                            {

                            }
                        }
                    }
                }
                catch ( Exception ex )
                {
                    MessageBox.Show( ex.Message );
                }

                if ( SubFolders.Checked == true )
                {
                    DirSearch( PathText.Text );
                }
            } ).Start();
        }

        private void label9_Click ( object sender, EventArgs e )
        {

        }

        private void button1_Click ( object sender, EventArgs e )
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "JPG & PNG|*.jpg;*.png";
            openFileDialog1.RestoreDirectory = true;

            if ( openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                string selectedFileName = openFileDialog1.FileName;
                ImagePath.Text = selectedFileName;
            }
        }

        private void checkBox1_CheckedChanged ( object sender, EventArgs e )
        {

        }

        private void AlbumSmartMode_CheckedChanged ( object sender, EventArgs e )
        {
        }

        private void Form1_Load ( object sender, EventArgs e )
        {

        }
    }
}
