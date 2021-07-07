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
    public partial class ConversationPlayer : UserControl
    {
        public bool Preview = false;
        private FilesController WorkingDirectory { get; set; }
        private Action<bool> SetPreviewMode;
        private int CharsInLine = 31;
        private List<string> PreviewLines;
        private Dictionary<string, PalettedImage> PortraitsFG = new Dictionary<string, PalettedImage>();
        private Dictionary<string, PalettedImage> PortraitsBG = new Dictionary<string, PalettedImage>();
        private string TargetLine = "";
        private int CurrentChar;

        public ConversationPlayer()
        {
            InitializeComponent();
        }

        public void Init(FilesController workingDirectory, int charsInLine, Action<bool> setPreviewMode)
        {
            WorkingDirectory = workingDirectory;
            CharsInLine = charsInLine;
            SetPreviewMode = setPreviewMode;
        }

        public void Play(string text, bool removeParts = true)
        {
            // Only preview text
            PreviewLines = new List<string>();
            PreviewLines.Add("");
            List<string> sourceParts = new List<string>(text.Split('~'));
            if (removeParts)
            {
                if (sourceParts.Count < 4)
                {
                    MessageBox.Show("Invalid conversation! Must have at least 4 parts - identifiers, requirements, demands, text and (optional) post-battle text.", "Invalid conversation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    sourceParts.RemoveRange(0, 3);
                }
            }
            // Find text parts
            List<string> textParts;
            for (int i = 0; i < sourceParts.Count; i++)
            {
                textParts = new List<string>(sourceParts[i].Split('\n'));
                PreviewLines.Add("Info: " + textParts[0].Trim());
                textParts.RemoveAt(0);
                PreviewLines.AddRange(textParts);
            }
            // Finally, set preview mode
            SetPreviewMode(true);
            Focus();
            ShowLine();
        }

        private void LoadPortrait(string name)
        {
            if (name.Contains("?"))
            {
                picPreviewSpeaker.BackgroundImage = null;
                picPreviewSpeaker.Image = null;
                return;
            }
            if (!WorkingDirectory.DirectoryExists(@"\Images\Portraits\" + name))
            {
                picPreviewSpeaker.BackgroundImage = null;
                picPreviewSpeaker.Image = null;
                return;
            }
            if (!PortraitsBG.ContainsKey(name))
            {
                PortraitsBG.Add(name, new PalettedImage(WorkingDirectory.LoadImage(@"Portraits\" + name + @"\B") ?? new Bitmap(1, 1)));
                PortraitsFG.Add(name, new PalettedImage(WorkingDirectory.LoadImage(@"Portraits\" + name + @"\F") ?? new Bitmap(1, 1)));
            }
            picPreviewSpeaker.Image = PortraitsBG[name];
            picPreviewSpeaker.Palette = Palette.BasePalette;
            picPreviewSpeaker.BackgroundImage = picPreviewSpeaker.Image.Target;
            picPreviewSpeaker.Image = PortraitsFG[name];
            picPreviewSpeaker.Palette = Palette.BaseSpritePalettes[3];
        }

        private void ConversationPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (Preview)
            {
                if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter || e.KeyCode == Keys.NumPad4)
                {
                    ShowLine();
                }
                if (e.KeyCode == Keys.Escape)
                {
                    SetPreviewMode(false);
                }
            }
        }

        private void ShowLine()
        {
            if (TargetLine == "")
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
                    // TBA - set speaker pos and stuff
                    LoadPortrait(parts[0]);
                    lblPreviewName.Text = parts.Length > 1 ? parts[1] : parts[0];
                }
                // Find the line break
                line = line.Replace(@"\a", "\a");
                string trueLine = FindLineBreaks(TrueLine(line));
                // Check if it's short (aka no line break) and had previous
                if (line.IndexOf(':') < 0 && LineAddition(trueLine))
                {
                    string[] previousLineParts = FindLineBreaks(lblPreviewText.Text).Split('\n');
                    TargetLine = previousLineParts[previousLineParts.Length - 1] + '\n' + trueLine;
                    CurrentChar = previousLineParts[previousLineParts.Length - 1].Length;
                    lblPreviewText.Text = previousLineParts[previousLineParts.Length - 1] + '\n' + trueLine;
                }
                else
                {
                    TargetLine = trueLine;
                    CurrentChar = 0;
                    lblPreviewText.Text = trueLine;
                }
            }
            ShowNextLine();
        }

        private void ShowNextLine()
        {
            if (TargetLine == "")
            {
                ShowLine();
                return;
            }
            int aIndex = TargetLine.IndexOf('\a', CurrentChar + 1);
            string trueLine = aIndex > 0 ? TargetLine.Substring(0, aIndex) : TargetLine;
            while (trueLine.Count(a => a == '\n') > 1)
            {
                int lengthReduce = trueLine.IndexOf('\n');
                trueLine = trueLine.Substring(lengthReduce + 1);
            }
            lblPreviewText.Text = trueLine.Replace("\n", "\n\n").Replace("\a", "");
            TargetLine = (aIndex < TargetLine.Length - 1 && aIndex > 0) ? TargetLine : "";
            CurrentChar = aIndex;
        }

        private string TrueLine(string line)
        {
            int index = line.IndexOf(':');
            line = line.Substring(index >= 0 ? index + 2 : 0);
            return line;
        }

        private string FindLineBreaks(string line)
        {
            int lineWidth = CharsInLine - 1;
            string cutLine = line;
            for (int i = line.IndexOf(' '); i > -1; i = cutLine.IndexOf(' ', i + 1))
            {
                int nextLength = cutLine.Substring(i + 1).Split(' ')[0].Length;
                int length = i + 1 + nextLength - cutLine.Substring(0, i + 1 + nextLength).Count(a => a == '\a');
                if (length > lineWidth)
                {
                    //Debug.Log("Length (" + cutLine.Substring(0, i + 1) + "): " + (i + 1) + ", next word (" + cutLine.Substring(i + 1).Split(' ')[0] + "): " + nextLength + @", \a count: " + cutLine.Substring(0, i + 1 + nextLength).Count(a => a == '\a') + ", total: " + length + " / " + lineWidth);
                    line = line.Substring(0, line.LastIndexOf('\n') + 1) + cutLine.Substring(0, i) + '\n' + cutLine.Substring(i + 1);
                    i = 0;
                    cutLine = line.Substring(line.LastIndexOf('\n') + 1);
                }
            }
            //Debug.Log(line);
            return line;
        }

        private bool LineAddition(string trueLine)
        {
            return trueLine.IndexOf('\n') < 0;
        }
    }
}
