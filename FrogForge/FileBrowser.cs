﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace FrogForge
{
    public partial class FileBrowser : UserControl
    {
        public FilesController Directory;
        /// <summary>
        /// Argument 1 - File name
        /// </summary>
        public Action<string> OnFileSelected;
        public bool ShowDirectories = true;
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
                items.Add("..");
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

        private void lstFiles_DoubleClick(object sender, EventArgs e)
        {
            string item = lstFiles.SelectedItem.ToString();
            if (item[0] == @"\"[0])
            {
                if (item == @"\..")
                {
                    Directory.Path = Directory.Path.Substring(0, Directory.Path.LastIndexOf(Directory.Seperator));
                }
                else
                {
                    Directory.CreateDirectory(item.Substring(1), true);
                }
                UpdateList();
            }
            else
            {
                OnFileSelected(lstFiles.SelectedItem.ToString());
            }
        }
    }
}