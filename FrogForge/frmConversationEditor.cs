﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace FrogForge
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
        private bool Preview = false;
        private List<string> PreviewLines;
        private Dictionary<string, Image> Portraits = new Dictionary<string, Image>();
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
            // Load portraits
            DataDirectory.CreateDirectory("Images");
            DataDirectory.CreateDirectory(@"Images\Portraits");
            string[] files = DataDirectory.AllFiles(false, true, @"\Images\Portraits");
            for (int i = 0; i < files.Length; i++)
            {
                Portraits.Add(files[i].Replace(".png", ""), DataDirectory.LoadImage(@"Portraits\" + files[i], "", false));
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
            // Fix wierd bug
            pnlPreview.BackgroundImage = Properties.Resources.FrogmanGaidenConversationBG;
            picArrow.Image = Properties.Resources.Arrow;
        }

        private void LoadFile(string name)
        {
            if (HasUnsavedChanges())
            {
                return;
            }
            Text = Text.Replace("*", "");
            UserInput = false;
            CurrentFilename = name;
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
        }

        private void txtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' || e.KeyChar == ':')
            {
                ColorText();
            }
            if (!Text.Contains("*"))
            {
                Text += "*";
            }
        }

        private void frmConversationEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (Preview)
            {
                if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter || e.KeyCode == Keys.NumPad4)
                {
                    ShowLine();
                }
            }
            else
            {
                if (ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
                {
                    btnSave_Click(sender, e);
                }
            }
        }

        private void ShowLine()
        {
            do
            {
                PreviewLines.RemoveAt(0);
                if (PreviewLines.Count <= 0)
                {
                    SetPreviewMode(false);
                    return;
                }
            } while (PreviewLines[0] == "" || PreviewLines[0][0] == '#' || PreviewLines[0][0] == ':' || PreviewLines[0][0] == '}');
            string line = PreviewLines[0];
            if (line.IndexOf(':') != -1)
            {
                string[] parts = line.Split(':')[0].Split('|');
                // TBA - load portrait
                picPreviewSpeaker.Image = Portraits.ContainsKey(parts[0]) ? Portraits[parts[0]] : null;
                lblPreviewName.Text = parts[parts.Length - 1];
            }
            // Find the line break
            string trueLine = FindLineBreack(TrueLine(line));
            // Check if it's short (aka no line break) and had previous
            if (line.IndexOf(':') < 0 && LineAddition(trueLine))
            {
                string[] previousLineParts = lblPreviewText.Text.Split('\n');
                lblPreviewText.Text = previousLineParts[previousLineParts.Length - 1] + '\n' + trueLine;
            }
            else
            {
                lblPreviewText.Text = trueLine;
            }
            lblPreviewText.Text = lblPreviewText.Text.Replace("\n", "\n\n");
        }

        private string TrueLine(string line)
        {
            int index = line.IndexOf(':');
            line = line.Substring(index >= 0 ? index + 2 : 0);
            return line;
        }

        private string FindLineBreack(string line)
        {
            for (int i = line.IndexOf(' '); i > -1; i = line.IndexOf(' ', i + 1))
            {
                int length = line.Substring(0, i + 1).Length + line.Substring(i + 1).Split(' ')[0].Length;
                if (length > CHARS_IN_LINE - 1)
                {
                    line = line.Substring(0, i) + '\n' + line.Substring(i + 1);
                    break;
                }
            }
            return line;
        }

        private bool LineAddition(string trueLine)
        {
            return trueLine.IndexOf('\n') < 0;
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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            // Only preview text
            PreviewLines = new List<string>();
            PreviewLines.Add("");
            string[] sourceParts = txtText.Text.Split('~');
            if (sourceParts.Length < 4)
            {
                MessageBox.Show("Invalid conversation! Must have at least 4 parts - identifiers, requirements, demands, text and (optional) post-battle text.", "Invalid conversation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Find text part
            string[] textParts = sourceParts[3].Split('\n');
            PreviewLines.AddRange(textParts);
            // Find post-battle part
            if (sourceParts.Length >= 5)
            {
                PreviewLines.Add("Info: Battle...");
                textParts = sourceParts[4].Split('\n');
                PreviewLines.AddRange(textParts);
            }
            // Finally, set preview mode
            SetPreviewMode(true);
            Focus();
            ShowLine();
        }

        private void SetPreviewMode(bool on)
        {
            pnlEditorUI.Enabled = !on;
            flbFileBrowser.Enabled = !on;
            BackColor = on ? SystemColors.ControlDark : SystemColors.Control;
            Preview = on;
        }
    }
}