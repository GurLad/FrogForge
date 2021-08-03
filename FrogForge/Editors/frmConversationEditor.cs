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
using static FrogForge.ExtensionMethods;

namespace FrogForge.Editors
{
    public partial class frmConversationEditor : frmBaseEditor
    {
        private const int CHARS_IN_LINE = 31;
        private FilesController CurrentDirectory;
        private string CurrentFileName;
        private string CurrentFilePath;
        private int FirstLineWidth;
        public frmConversationEditor()
        {
            InitializeComponent();
            BaseName = Text;
        }

        private void frmConversationEditor_Load(object sender, EventArgs e)
        {
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
            txtText.UserInput = true;
            // Init stuff
            copConversationPlayer.Init(WorkingDirectory, CHARS_IN_LINE, SetPreviewMode);
            txtText.Init(DataDirectory, this);
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
            txtText.UserInput = false;
            CurrentFileName = name;
            CurrentFilePath = CurrentDirectory.Path;
            txtText.Text = CurrentDirectory.LoadFile(CurrentFileName);
            txtName.Text = CurrentFileName;
            txtText.ColorText();
            txtText.UserInput = true;
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
            txtText.ColorText();
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
            if (CurrentDirectory.DirectoryExists(toDelete) &&
                ConfirmDialog("Are you sure you want to delete folder " + toDeleteName + "?", "Warning") &&
                (CurrentDirectory.AllFiles(false, true, toDelete).Length == 0 ||
                 ConfirmDialog("Warning! " + toDeleteName + " contains files. Continue anyway?", "Warning")))
            {
                CurrentDirectory.DeleteDirectory(toDelete);
                if (toDelete == "")
                {
                    flbFileBrowser.Navigate(@"\..");
                }
                flbFileBrowser.UpdateList();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (txtText.SelectedText == "")
            {
                copConversationPlayer.Play(txtText.Text);
            }
            else
            {
                copConversationPlayer.Play(txtText.SelectedText, false);
            }
        }
    }
}
