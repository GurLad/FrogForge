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
        public FilesController DataDirectory = new FilesController("Data");
        public FilesController WorkingDirectoryFiles = new FilesController();
        private const int CHARS_IN_LINE = 23;
        private FilesController currentDirectory;
        private string currentFilename;
        private Dictionary<Color, string[]> keywords = new Dictionary<Color, string[]>();
        private int firstLineWidth;
        private bool userInput = true;
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
                keywords.Add(ColorTranslator.FromHtml(keyValue[0]), values);
            }
            // Find line width
            txtText.Text = new string('-', CHARS_IN_LINE);
            firstLineWidth = txtText.GetPositionFromCharIndex(txtText.Text.LastIndexOf('-')).X;
            // Find directory
            currentDirectory = new FilesController();
            currentDirectory.DefultFileFormat = ".txt";
            currentDirectory.Path = @"C:\Users\Gur\Documents\GitHub\FrogmanGaiden\Assets\Data\Conversations";
            flbFileBrowser.Files = currentDirectory;
            flbFileBrowser.OnFileSelected = LoadFile;
            flbFileBrowser.UpdateList();
        }

        private void LoadFile(string name)
        {
            currentFilename = name.Replace(currentDirectory.DefultFileFormat, "");
            txtText.Text = currentDirectory.LoadFile(currentFilename);
            txtName.Text = currentFilename;
            ColorText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            currentDirectory.SaveFile(txtName.Text, txtText.Text);
            if (txtName.Text != currentFilename)
            {
                flbFileBrowser.UpdateList();
                currentFilename = txtName.Text;
            }
        }

        private void ColorText()
        {
            userInput = false;
            txtText.BeginUpdate();
            CheckKeyword("~", Color.Purple, false);
            CheckKeyword(":", Color.DarkGoldenrod, false);
            CheckKeywordLine("#", Color.DarkCyan);
            foreach (Color color in keywords.Keys)
            {
                foreach (string word in keywords[color])
                {
                    CheckKeyword(word, color);
                }
            }
            txtText.EndUpdate();
            userInput = true;
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
            if (!userInput)
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
            picSeperator1.Left += pos.X + firstLineWidth;
            picSeperator1.Top += pos.Y + 4;
            picSeperator2.Location = picSeperator1.Location;
            picSeperator2.Left += firstLineWidth;
            picSeperator2.Visible = picSeperator1.Visible = picSeperator1.Top >= txtText.Top && picSeperator1.Top + picSeperator1.Height <= txtText.Top + txtText.Height;
        }

        private void txtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' || e.KeyChar == ':')
            {
                ColorText();
            }
        }
    }
}
