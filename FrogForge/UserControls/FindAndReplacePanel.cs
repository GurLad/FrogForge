using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace FrogForge.UserControls
{
    public partial class FindAndReplacePanel : UserControl
    {
        public bool Dirty;
        private RichTextBox TextBox;
        private FilesController WorkingDirectory;
        private Func<string> GetCurrentFileName;
        private Func<string, bool> LoadFile;
        private Action SaveFile;
        private List<TextFile> FilesCache = new List<TextFile>();
        private bool AllFiles => rdbAllFiles.Checked;

        public FindAndReplacePanel()
        {
            InitializeComponent();
        }

        public void Init(RichTextBox textBox, FilesController workingDirectory, Func<string> getCurrentFileName, Func<string, bool> loadFile, Action saveFile)
        {
            TextBox = textBox;
            WorkingDirectory = workingDirectory;
            GetCurrentFileName = getCurrentFileName;
            LoadFile = loadFile;
            SaveFile = saveFile;
            UpdateFiles();
        }

        public void FixZoom()
        {
            // Save anchors, move
            Dictionary<Control, AnchorStyles> anchors = new Dictionary<Control, AnchorStyles>();
            foreach (Control control in Controls)
            {
                anchors.Add(control, control.Anchor);
                control.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            }
            // Resize
            int oldWidth = Width;
            this.ApplyPreferences();
            // Restore anchors
            foreach (Control control in Controls)
            {
                control.Anchor = anchors[control];
                // Hardcoded fix because this is super annoying
                if ((control.Anchor & AnchorStyles.Left) != 0 && (control.Anchor & AnchorStyles.Right) != 0)
                {
                    control.Width = Width - control.Left;
                }
            }
            // Restore width
            Width = oldWidth;
        }

        private void txtReplace_TextChanged(object sender, EventArgs e)
        {
            btnReplace.Enabled = btnReplaceAll.Enabled = txtReplace.Text != "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!AllFiles)
            {
                if (!MarkNextInCurrent(txtFind.Text, true))
                {
                    ShowNotFoundMessage();
                }
            }
            else
            {
                if (Dirty)
                {
                    UpdateFiles();
                }
                if (!MarkNextInAllFiles(txtFind.Text))
                {
                    ShowNotFoundMessage();
                }
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (!AllFiles)
            {
                if (!ReplaceInCurrent(txtFind.Text, txtReplace.Text))
                {
                    if (!MarkNextInCurrent(txtFind.Text, true))
                    {
                        ShowNotFoundMessage();
                    }
                }
            }
            else
            {
                if (Dirty)
                {
                    UpdateFiles();
                }
                if (!ReplaceInCurrent(txtFind.Text, txtReplace.Text))
                {
                    if (!MarkNextInAllFiles(txtFind.Text))
                    {
                        ShowNotFoundMessage();
                    }
                }
            }
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            if (!ExtensionMethods.ConfirmDialog("Are you sure? This action cannot be undone!", "Replace all"))
            {
                return;
            }
            if (!AllFiles)
            {
                TextBox.Text = TextBox.Text.Replace(txtFind.Text, txtReplace.Text);
            }
            else
            {
                TextBox.Text = TextBox.Text.Replace(txtFind.Text, txtReplace.Text);
                // Reload all files again, just in case one was modified externally
                UpdateFiles();
                int currentIndex = Math.Max(0, FilesCache.FindIndex(a => a.FileName == GetCurrentFileName()));
                bool looped = false;
                while (
                    (currentIndex = GetNextFileIndex(txtFind.Text, currentIndex, false)) >= 0 ||
                    (!looped && (currentIndex = GetNextFileIndex(txtFind.Text, currentIndex, looped = true)) >= 0))
                {
                    FilesCache[currentIndex].Content = FilesCache[currentIndex].Content.Replace(txtFind.Text, txtReplace.Text);
                    WorkingDirectory.SaveFile(FilesCache[currentIndex].FileName, FilesCache[currentIndex].Content, "");
                }
                // Save the file to make sure we didn't mess it up by accident
                SaveFile();
            }
        }

        private bool MarkNextInCurrent(string searchFor, bool loopAround)
        {
            int nextIndex = TextBox.Text.IndexOf(searchFor, TextBox.SelectionStart + TextBox.SelectionLength);
            if (nextIndex < 0)
            {
                if (loopAround)
                {
                    nextIndex = TextBox.Text.IndexOf(searchFor);
                }
                if (nextIndex < 0)
                {
                    return false;
                }
            }
            TextBox.Select(nextIndex, searchFor.Length);
            TextBox.Focus();
            return true;
        }

        private bool MarkNextInAllFiles(string searchFor)
        {
            int currentIndex = Math.Max(0, FilesCache.FindIndex(a => a.FileName == GetCurrentFileName()));
            if (!MarkNextInCurrent(txtFind.Text, false))
            {
                currentIndex = GetNextFileIndex(txtFind.Text, currentIndex, true);
                if (currentIndex >= 0)
                {
                    if (LoadFile(FilesCache[currentIndex].FileName)) // In case the user decides to not discard changes
                    {
                        MarkNextInCurrent(txtFind.Text, true); // Must return true, as we found a file index with that string
                    }
                }
                else
                {
                    if (!MarkNextInCurrent(txtFind.Text, true))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool ReplaceInCurrent(string origin, string target)
        {
            if (TextBox.SelectedText == origin)
            {
                TextBox.SelectedText = target;
                return true;
            }
            return false;
        }

        private int GetNextFileIndex(string searchFor, int currentIndex, bool loopAround)
        {
            for (int i = currentIndex + 1; i < FilesCache.Count; i++)
            {
                if (FilesCache[i].Content.Contains(searchFor))
                {
                    return i;
                }
            }
            if (loopAround)
            {
                for (int i = 0; i < currentIndex; i++)
                {
                    if (FilesCache[i].Content.Contains(searchFor))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private void ShowNotFoundMessage()
        {
            MessageBox.Show("No instance of " + txtFind.Text + " was found" + (!AllFiles ? " in the current document" : " anywhere"));
        }

        private void UpdateFiles()
        {
            // Currently, loads every single file again after each update - change to only update changes
            FilesCache.Clear();
            List<string> files = WorkingDirectory.RecursiveAllFiles(true);
            foreach (string fileName in files)
            {
                string[] parts = fileName.Split('.');
                if (parts[parts.Length - 1] == "txt")
                {
                    string trueName = fileName.Substring(WorkingDirectory.Path.Length);
                    FilesCache.Add(new TextFile(trueName, WorkingDirectory.LoadFile(trueName, "", "")));
                }
            }
            Dirty = false;
        }

        private class TextFile
        {
            public string FileName;
            public string Content;

            public TextFile(string fileName, string content)
            {
                FileName = fileName;
                Content = content;
            }
        }
    }
}
