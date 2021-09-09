using FrogForge.Editors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace FrogForge.UserControls
{
    [System.ComponentModel.Designer(typeof(RichTextBoxExDesigner))]
    public partial class EventTextBox : FixedRichTextBox
    {
        public new string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                UserInput = false;
                base.Text = "";
                Refresh();
                base.Text = value;
                ColorText();
                UserInput = true;
            }
        }
        private bool UserInput = false;
        private Dictionary<Color, string[]> Keywords = new Dictionary<Color, string[]>();
        private frmBaseEditor Editor;

        public void Init(FilesController dataDirectory, frmBaseEditor editor)
        {
            // Load keywords
            string[] keywordsFile = dataDirectory.LoadFile("Keywords").Replace("\r", "").Split('\n');
            for (int i = 0; i < keywordsFile.Length; i++)
            {
                string[] keyValue = keywordsFile[i].Split(':');
                string[] values = keyValue[1].Split(',');
                Keywords.Add(ColorTranslator.FromHtml(keyValue[0]), values);
            }
            // Set methods
            TextChanged += EventTextBox_TextChanged;
            SelectionChanged += EventTextBox_TextChanged;
            VScroll += EventTextBox_TextChanged;
            KeyPress += EventTextBox_KeyPress;
            // Misc
            Editor = editor;
            Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            UserInput = true;
        }

        private void ColorText(int minIndex = -1, int maxIndex = -1)
        {
            UserInput = false;
            BeginUpdate();
            CheckKeyword(":", Color.DarkGoldenrod, minIndex, maxIndex, false);
            CheckKeyword("{", Color.Red, minIndex, maxIndex, false);
            CheckKeyword("}", Color.Red, minIndex, maxIndex, false);
            CheckKeyword(@"\a", Color.DarkViolet, minIndex, maxIndex, false);
            foreach (Color color in Keywords.Keys)
            {
                foreach (string word in Keywords[color])
                {
                    CheckKeyword(word, color, minIndex, maxIndex);
                }
            }
            CheckKeywordLine("~", Color.Purple, minIndex, maxIndex);
            CheckKeywordLine("#", Color.DarkCyan, minIndex, maxIndex);
            EndUpdate();
            Refresh();
            UserInput = true;
        }

        private void CheckKeyword(string word, Color color, int minIndex = -1, int maxIndex = -1, bool keyword = true)
        {
            if (Preferences.Current.DarkMode)
            {
                color = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
            }
            if (Text.Contains(word))
            {
                int index = minIndex;
                int selectStart = SelectionStart;

                while ((index = Text.IndexOf(word, index + 1)) != -1)
                {
                    if (!(!keyword || index + word.Length >= Text.Length || Text[index + word.Length] == ':'))
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
                    Select(index, word.Length);
                    SelectionColor = color;
                    Select(selectStart, 0);
                    SelectionColor = Color.Black;
                }
            }
        }

        private void CheckKeywordLine(string word, Color color, int minIndex = -1, int maxIndex = -1)
        {
            if (Text.Contains(word))
            {
                int index = -1;
                int selectStart = SelectionStart;

                while ((index = Text.IndexOf(word, index + 1)) != -1)
                {
                    if (minIndex > 0 && index < minIndex)
                    {
                        continue;
                    }
                    if (maxIndex > 0 && index > maxIndex)
                    {
                        return;
                    }
                    Select(index, Text.IndexOf('\n', index + word.Length) - index);
                    SelectionColor = color;
                    Select(selectStart, 0);
                    SelectionColor = Color.Black;
                }
            }
        }

        private void EventTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!UserInput)
            {
                return;
            }
            int selectionIndex = FindSelectedNextLineStart();
            if (selectionIndex >= Text.Length)
            {
                return;
            }
            int index = Math.Max(Text.LastIndexOf(':', selectionIndex) + 2, Text.LastIndexOf('\n', selectionIndex) + 1);
            Point pos = GetPositionFromCharIndex(index);
            // Seperator stuff - currently removed because of \a, might return in the future. But Preview should be enough.
            //picSeperator1.Location = Location;
            //picSeperator1.Left += pos.X + FirstLineWidth;
            //picSeperator1.Top += pos.Y + 4;
            //picSeperator2.Location = picSeperator1.Location;
            //picSeperator2.Left += FirstLineWidth;
            //picSeperator2.Visible = picSeperator1.Visible = picSeperator1.Top >= Top && picSeperator1.Top + picSeperator1.Height <= Top + Height;
        }

        private void EventTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ModifierKeys != Keys.Control)
            {
                if (!Editor.Dirty)
                {
                    Editor.Dirty = true;
                }
                if (SelectionColor != Color.Black)
                {
                    SelectionColor = Color.Black;
                }
            }
            if (e.KeyChar == '\r' || e.KeyChar == ':') // TODO: Fix coloring
            {
                if (e.KeyChar == ':')
                {
                    SelectionColor = Color.DarkGoldenrod;
                }
                int selectionIndex = Text.LastIndexOf('\n', FindSelectedNextLineStart() - 1) + 1;
                int nextLineIndex = Text.IndexOf('\n', selectionIndex + 1);
                ColorText(selectionIndex - 1, nextLineIndex); // Because IndexOf's startIndex is exclusive
            }
        }

        private int FindSelectedNextLineStart()
        {
            int selectionIndex = SelectionStart;
            if (selectionIndex > 0)
            {
                selectionIndex--;
                int lineIndex = Text.IndexOf('\n', selectionIndex);
                if (lineIndex > selectionIndex)
                {
                    selectionIndex = lineIndex - 1;
                }
            }
            if (selectionIndex <= 0)
            {
                selectionIndex = 1; // Fixes crash on empty file
            }
            return selectionIndex;
        }
    }
}
