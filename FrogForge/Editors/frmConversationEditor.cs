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

namespace FrogForge.Editors
{
    public partial class frmConversationEditor : frmBaseEditor
    {
        private const int CHARS_IN_LINE = 31;
        private FilesController CurrentDirectory;
        private string CurrentFileName;
        private string CurrentFilePath;
        private Dictionary<Color, string[]> Keywords = new Dictionary<Color, string[]>();
        private int FirstLineWidth;
        private bool UserInput = false;
        public frmConversationEditor()
        {
            InitializeComponent();
            BaseName = Text;
        }

        private void frmConversationEditor_Load(object sender, EventArgs e)
        {
            // Load keywords
            string[] keywordsFile = DataDirectory.LoadFile("Keywords").Replace("\r", "").Split('\n');
            for (int i = 0; i < keywordsFile.Length; i++)
            {
                string[] keyValue = keywordsFile[i].Split(':');
                string[] values = keyValue[1].Split(',');
                Keywords.Add(ColorTranslator.FromHtml(keyValue[0]), values);
            }
            // Find line width
            txtText.Text = new string('-', CHARS_IN_LINE);
            FirstLineWidth = txtText.GetPositionFromCharIndex(txtText.Text.LastIndexOf('-')).X;
            // Find directory
            CurrentDirectory = new FilesController();
            CurrentDirectory.DefultFileFormat = ".txt";
            CurrentDirectory.Path = WorkingDirectory.Path;
            CurrentDirectory.CreateDirectory("Conversations", true);
            flbFileBrowser.Directory = CurrentDirectory;
            flbFileBrowser.OnFileSelected = LoadFile;
            flbFileBrowser.UpdateList();
            UserInput = true;
            // Init conversation player
            copConversationPlayer.Init(WorkingDirectory, CHARS_IN_LINE, SetPreviewMode);
            // Load empty conversation
            btnNew_Click(sender, e);
        }

        private void LoadFile(string name)
        {
            if (HasUnsavedChanges())
            {
                return;
            }
            CurrentFile = name;
            UserInput = false;
            CurrentFileName = name;
            CurrentFilePath = CurrentDirectory.Path;
            txtText.Text = CurrentDirectory.LoadFile(CurrentFileName);
            txtName.Text = CurrentFileName;
            ColorText();
            UserInput = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            void UpdateList()
            {
                flbFileBrowser.UpdateList();
                flbFileBrowser.SelectedFilename = CurrentFileName;
                CurrentFilePath = CurrentDirectory.Path;
            }
            if (CurrentFilePath != "" && CurrentFilePath != CurrentDirectory.Path && txtName.Text == CurrentFileName)
            {
                if (ConfirmDialog("It appears that you're trying to save an existing file in another directory. Is this intended?", ""))
                {
                    CurrentFilePath = CurrentDirectory.Path;
                }
                else
                {
                    CurrentDirectory.Path = CurrentFilePath;
                }
                CurrentDirectory.SaveFile(txtName.Text, txtText.Text);
                Dirty = false;
                UpdateList();
            }
            else if (CurrentFilePath != CurrentDirectory.Path || txtName.Text != CurrentFileName)
            {
                CurrentFileName = txtName.Text;
                CurrentFilePath = CurrentDirectory.Path;
                CurrentDirectory.SaveFile(txtName.Text, txtText.Text);
                Dirty = false;
                UpdateList();
            }
            else
            {
                CurrentDirectory.SaveFile(txtName.Text, txtText.Text);
                Dirty = false;
            }
            if (CurrentFilePath != CurrentDirectory.Path)
            {
                CurrentFilePath = CurrentDirectory.Path;
            }
            VoiceAssist.Say("Save");
        }

        private void ColorText(int minIndex = -1, int maxIndex = -1)
        {
            UserInput = false;
            txtText.BeginUpdate();
            CheckKeyword(":", Color.DarkGoldenrod, minIndex, maxIndex, false);
            CheckKeyword("{", Color.Red, minIndex, maxIndex, false);
            CheckKeyword("}", Color.Red, minIndex, maxIndex, false);
            foreach (Color color in Keywords.Keys)
            {
                foreach (string word in Keywords[color])
                {
                    CheckKeyword(word, color, minIndex, maxIndex);
                }
            }
            CheckKeywordLine("~", Color.Purple, minIndex, maxIndex);
            CheckKeywordLine("#", Color.DarkCyan, minIndex, maxIndex);
            txtText.EndUpdate();
            txtText.Refresh();
            UserInput = true;
        }

        private void CheckKeyword(string word, Color color, int minIndex = -1, int maxIndex = -1, bool keyword = true)
        {
            if (txtText.Text.Contains(word))
            {
                int index = minIndex;
                int selectStart = txtText.SelectionStart;

                while ((index = txtText.Text.IndexOf(word, index + 1)) != -1)
                {
                    if (!(!keyword || index + word.Length >= txtText.Text.Length || txtText.Text[index + word.Length] == ':'))
                    {
                        continue;
                    }
                    if (minIndex > 0 && index < minIndex)
                    {
                        continue;
                    }
                    if (maxIndex > 0 && index > maxIndex)
                    {
                        return;
                    }
                    txtText.Select(index, word.Length);
                    txtText.SelectionColor = color;
                    txtText.Select(selectStart, 0);
                    txtText.SelectionColor = Color.Black;
                }
            }
        }

        private void CheckKeywordLine(string word, Color color, int minIndex = -1, int maxIndex = -1)
        {
            if (txtText.Text.Contains(word))
            {
                int index = -1;
                int selectStart = txtText.SelectionStart;

                while ((index = txtText.Text.IndexOf(word, index + 1)) != -1)
                {
                    if (minIndex > 0 && index < minIndex)
                    {
                        continue;
                    }
                    if (maxIndex > 0 && index > maxIndex)
                    {
                        return;
                    }
                    txtText.Select(index, txtText.Text.IndexOf('\n', index + word.Length) - index);
                    txtText.SelectionColor = color;
                    txtText.Select(selectStart, 0);
                    txtText.SelectionColor = Color.Black;
                }
            }
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            if (!UserInput)
            {
                return;
            }
            int selectionIndex = FindSelectedNextLineStart();
            int index = Math.Max(txtText.Text.LastIndexOf(':', selectionIndex) + 2, txtText.Text.LastIndexOf('\n', selectionIndex) + 1);
            Point pos = txtText.GetPositionFromCharIndex(index);
            picSeperator1.Location = txtText.Location;
            picSeperator1.Left += pos.X + FirstLineWidth;
            picSeperator1.Top += pos.Y + 4;
            picSeperator2.Location = picSeperator1.Location;
            picSeperator2.Left += FirstLineWidth;
            picSeperator2.Visible = picSeperator1.Visible = picSeperator1.Top >= txtText.Top && picSeperator1.Top + picSeperator1.Height <= txtText.Top + txtText.Height;
        }

        private void txtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ModifierKeys != Keys.Control)
            {
                if (!Dirty)
                {
                    Dirty = true;
                }
                if (txtText.SelectionColor != Color.Black)
                {
                    txtText.SelectionColor = Color.Black;
                }
            }
            if (e.KeyChar == '\r' || e.KeyChar == ':') // TODO: Fix coloring
            {
                if (e.KeyChar == ':')
                {
                    txtText.SelectionColor = Color.DarkGoldenrod;
                }
                int selectionIndex = txtText.Text.LastIndexOf('\n', FindSelectedNextLineStart() - 1) + 1;
                int nextLineIndex = txtText.Text.IndexOf('\n', selectionIndex + 1);
                ColorText(selectionIndex - 1, nextLineIndex); // Because IndexOf's startIndex is exclusive
            }
        }

        private int FindSelectedNextLineStart()
        {
            int selectionIndex = txtText.SelectionStart;
            if (selectionIndex > 0)
            {
                selectionIndex--;
                int lineIndex = txtText.Text.IndexOf('\n', selectionIndex);
                if (lineIndex > selectionIndex)
                {
                    selectionIndex = lineIndex - 1;
                }
            }
            else
            {
                selectionIndex = 1; // Fixes crash on empty file
            }
            return selectionIndex;
        }

        protected override bool ControlKeyAction(Keys key)
        {
            if (!copConversationPlayer.Preview)
            {
                switch (key)
                {
                    case Keys.S:
                        btnSave_Click(this, new EventArgs());
                        return true;
                    case Keys.N:
                        btnNew_Click(this, new EventArgs());
                        return true;
                    case Keys.P:
                        btnPreview_Click(this, new EventArgs());
                        return true;
                    default:
                        break;
                }
            }
            return false;
        }

        private void SetPreviewMode(bool on)
        {
            pnlEditorUI.Enabled = !on;
            flbFileBrowser.Enabled = !on;
            BackColor = on ? SystemColors.ControlDark : SystemColors.Control;
            copConversationPlayer.Preview = on;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (HasUnsavedChanges())
            {
                return;
            }
            txtName.Text = "";
            txtText.Text = DataDirectory.LoadFile("BaseConversation");
            ColorText();
            CurrentFile = "";
            CurrentFilePath = "";
            VoiceAssist.Say("New");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string toDelete = flbFileBrowser.SelectedFilename ?? txtName.Text;
            if (CurrentDirectory.CheckFileExist(toDelete + CurrentDirectory.DefultFileFormat))
            {
                if (DeleteFile(toDelete, CurrentDirectory))
                {
                    flbFileBrowser.UpdateList();
                    CurrentFileName = "";
                    VoiceAssist.Say("Delete");
                }
            }
        }

        private void btnNewFolder_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("You must enter a folder name.");
                return;
            }
            CurrentDirectory.CreateDirectory(txtName.Text);
            flbFileBrowser.UpdateList();
        }

        private void btnDeleteFolder_Click(object sender, EventArgs e)
        {
            // TBA: Update Utils to add directory support
            string toDelete = flbFileBrowser.SelectedFilename ?? (txtName.Text != "" ? @"\" + txtName.Text : "");
            string toDeleteName = toDelete != "" ? toDelete.Replace(@"\", "") : CurrentDirectory.Path.Substring(CurrentDirectory.Path.LastIndexOf(@"\") + 1);
            if (System.IO.Directory.Exists(CurrentDirectory.Path + toDelete) &&
                ConfirmDialog("Are you sure you want to delete folder " + toDeleteName + "?", "Warning") &&
                (CurrentDirectory.AllFiles(false, true, txtName.Text).Length == 0 ||
                 ConfirmDialog("Warning! " + toDeleteName + " contains files. Continue anyway?", "Warning")))
            {
                System.IO.Directory.Delete(CurrentDirectory.Path + toDelete, true);
                if (toDelete == "")
                {
                    flbFileBrowser.Navigate(@"\..");
                }
                flbFileBrowser.UpdateList();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            copConversationPlayer.Play(txtText.Text);
        }
    }
}
