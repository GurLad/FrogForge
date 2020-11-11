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

namespace FrogmanGaidenLevelEditor
{
    public partial class frmConversationEditor : Form
    {
        public FilesController DataDirectory { get; set; }
        public FilesController WorkingDirectory { get; set; }
        private const int CHARS_IN_LINE = 23;
        private FilesController CurrentDirectory;
        private string CurrentFilename;
        private Dictionary<Color, string[]> Keywords = new Dictionary<Color, string[]>();
        private int FirstLineWidth;
        private bool UserInput = false;
        public frmConversationEditor()
        {
            InitializeComponent();
        }

        private void frmConversationEditor_Load(object sender, EventArgs e)
        {
            // Load keywords
            string[] keywordsFile = DataDirectory.LoadFile("Keywords").Split('\n');
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
            flbFileBrowser.Files = CurrentDirectory;
            flbFileBrowser.OnFileSelected = LoadFile;
            flbFileBrowser.UpdateList();
            UserInput = true;
        }

        private void LoadFile(string name)
        {
            if (HasUnsavedChanges())
            {
                return;
            }
            Text = Text.Replace("*", "");
            UserInput = false;
            CurrentFilename = name.Replace(CurrentDirectory.DefultFileFormat, "");
            txtText.Text = CurrentDirectory.LoadFile(CurrentFilename);
            txtName.Text = CurrentFilename;
            ColorText();
            UserInput = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentDirectory.SaveFile(txtName.Text, txtText.Text);
            Text = Text.Replace("*", "");
            if (txtName.Text != CurrentFilename)
            {
                flbFileBrowser.UpdateList();
                CurrentFilename = txtName.Text;
            }
        }

        private void ColorText()
        {
            UserInput = false;
            txtText.BeginUpdate();
            CheckKeyword("~", Color.Purple, false);
            CheckKeyword(":", Color.DarkGoldenrod, false);
            CheckKeywordLine("#", Color.DarkCyan);
            foreach (Color color in Keywords.Keys)
            {
                foreach (string word in Keywords[color])
                {
                    CheckKeyword(word, color);
                }
            }
            txtText.EndUpdate();
            UserInput = true;
        }

        private void CheckKeyword(string word, Color color, bool keyword = true)
        {
            if (txtText.Text.Contains(word))
            {
                int index = -1;
                int selectStart = txtText.SelectionStart;

                while ((index = txtText.Text.IndexOf(word, index + 1)) != -1 && (!keyword || index + word.Length >= txtText.Text.Length || txtText.Text[index + word.Length] == ':'))
                {
                    txtText.Select(index, word.Length);
                    txtText.SelectionColor = color;
                    txtText.Select(selectStart, 0);
                    txtText.SelectionColor = Color.Black;
                }
            }
        }

        private void CheckKeywordLine(string word, Color color)
        {
            if (txtText.Text.Contains(word))
            {
                int index = -1;
                int selectStart = txtText.SelectionStart;

                while ((index = txtText.Text.IndexOf(word, index + 1)) != -1)
                {
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
            int index = Math.Max(txtText.Text.LastIndexOf(':', selectionIndex) + 2, txtText.Text.LastIndexOf('\n', selectionIndex) + 1);
            Point pos = txtText.GetPositionFromCharIndex(index);
            picSeperator1.Location = txtText.Location;
            picSeperator1.Left += pos.X + FirstLineWidth;
            picSeperator1.Top += pos.Y + 4;
            picSeperator2.Location = picSeperator1.Location;
            picSeperator2.Left += FirstLineWidth;
            picSeperator2.Visible = picSeperator1.Visible = picSeperator1.Top >= txtText.Top && picSeperator1.Top + picSeperator1.Height <= txtText.Top + txtText.Height;
            if (!Text.Contains("*"))
            {
                Text += "*";
            }
        }

        private void txtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' || e.KeyChar == ':')
            {
                ColorText();
            }
        }

        private void frmConversationEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            {
                btnSave_Click(sender, e);
            }
        }

        private bool HasUnsavedChanges()
        {
            return Text.Contains("*") && MessageBox.Show("Unsaved changes! Discard?", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No;
        }

        private void frmConversationEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (HasUnsavedChanges())
            {
                e.Cancel = true;
            }
        }
    }
}
