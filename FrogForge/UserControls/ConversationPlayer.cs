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

        public void Play(string text)
        {
            // Only preview text
            PreviewLines = new List<string>();
            PreviewLines.Add("");
            string[] sourceParts = text.Split('~');
            if (sourceParts.Length < 4)
            {
                MessageBox.Show("Invalid conversation! Must have at least 4 parts - identifiers, requirements, demands, text and (optional) post-battle text.", "Invalid conversation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Find text part
            List<string> textParts = new List<string>(sourceParts[3].Split('\n'));
            textParts.RemoveAt(0);
            PreviewLines.AddRange(textParts);
            // Find post-battle part
            if (sourceParts.Length >= 5)
            {
                PreviewLines.Add("Info: Battle...");
                textParts = new List<string>(sourceParts[4].Split('\n'));
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
                return;
            }
            if (!WorkingDirectory.DirectoryExists(@"Images\Portraits\" + name))
            {
                return;
            }
            WorkingDirectory.CreateDirectory(@"Images\Portraits\" + name);
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
            // TODO: Fix logic
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
                if (length > CharsInLine - 1)
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
    }
}
