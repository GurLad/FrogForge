using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace FrogForge.UserControls
{
    public partial class FileBrowser : UserControl
    {
        public FilesController Directory;
        /// <summary>
        /// Argument 1 - File name
        /// </summary>
        public Action<string> OnFileSelected;
        public bool ShowDirectories = true;
        public string TopMostDirectory;
        public string SelectedFilename
        {
            get
            {
                return lstFiles.SelectedItem?.ToString();
            }
            set
            {
                lstFiles.SelectedItem = value;
            }
        }
        public string CurrentSubDirectory
        {
            get
            {
                if (IsAtTopMostDirectory)
                {
                    return "";
                }
                else
                {
                    return Directory.Path.Substring(TopMostDirectory.Length + 1);
                }
            }
        }
        public bool IsAtTopMostDirectory
        {
            get
            {
                return Directory.Path == TopMostDirectory;
            }
        }

        public FileBrowser()
        {
            InitializeComponent();
        }

        public void UpdateList()
        {
            List<string> items = new List<string>();
            string selectedItem = "";
            if (ShowDirectories)
            {
                if (Directory.Path != TopMostDirectory)
                {
                    items.Add("..");
                }
                items.AddRange(Directory.AllDirectories());
                for (int i = 0; i < items.Count; i++)
                {
                    items[i] = @"\" + items[i];
                }
            }
            else
            {
                selectedItem = lstFiles.SelectedItem?.ToString() ?? "";
            }
            List<string> files = new List<string>(Directory.AllFiles());
            for (int i = 0; i < files.Count; i++)
            {
                if (files[i].Substring(files[i].Length - Directory.DefultFileFormat.Length) != Directory.DefultFileFormat)
                {
                    files.RemoveAt(i);
                    i--;
                }
                else
                {
                    files[i] = files[i].Replace(Directory.DefultFileFormat, "");
                }
            }
            items.AddRange(files);
            lstFiles.Items.Clear();
            lstFiles.Items.AddRange(items.ToArray());
            if (selectedItem != "")
            {
                lstFiles.SelectedItem = selectedItem;
            }
        }

        public void Navigate(string place)
        {
            if (place[0] == @"\"[0])
            {
                if (place == @"\..")
                {
                    Directory.Path = Directory.Path.Substring(0, Directory.Path.LastIndexOf(Directory.Seperator));
                }
                else
                {
                    Directory.CreateDirectory(place.Substring(1), true);
                }
                UpdateList();
            }
            else
            {
                OnFileSelected(lstFiles.SelectedItem.ToString());
                VoiceAssist.Say("Open");
            }
        }

        private void lstFiles_DoubleClick(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItem == null)
            {
                return;
            }
            string item = lstFiles.SelectedItem.ToString();
            Navigate(item);
        }
    }
}