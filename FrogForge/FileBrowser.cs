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

namespace FrogForge
{
    public partial class FileBrowser : UserControl
    {
        public FilesController Files;
        /// <summary>
        /// Argument 1 - File name
        /// </summary>
        public Action<string> OnFileSelected;
        public FileBrowser()
        {
            InitializeComponent();
        }

        public void UpdateList()
        {
            lstFiles.Items.Clear();
            List<string> items = new List<string>();
            items.Add("..");
            items.AddRange(Files.AllDirectories());
            for (int i = 0; i < items.Count; i++)
            {
                items[i] = @"\" + items[i];
            }
            List<string> files = new List<string>(Files.AllFiles());
            for (int i = 0; i < files.Count; i++)
            {
                if (files[i].Substring(files[i].Length - Files.DefultFileFormat.Length) != Files.DefultFileFormat)
                {
                    files.RemoveAt(i);
                    i--;
                }
            }
            items.AddRange(files);
            lstFiles.Items.AddRange(items.ToArray());
        }

        private void lstFiles_DoubleClick(object sender, EventArgs e)
        {
            string item = lstFiles.SelectedItem.ToString();
            if (item[0] == @"\"[0])
            {
                if (item == @"\..")
                {
                    Files.Path = Files.Path.Substring(0, Files.Path.LastIndexOf(Files.Seperator));
                }
                else
                {
                    Files.CreateDirectory(item.Substring(1), true);
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