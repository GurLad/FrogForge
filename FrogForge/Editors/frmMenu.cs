using Microsoft.WindowsAPICodePack.Dialogs;
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
    public partial class frmMenu : Form
    {
        private FilesController DataDirectory = new FilesController("Data");
        private FilesController WorkingDirectory = new FilesController();
        private CommonOpenFileDialog dlgFolder = new CommonOpenFileDialog();
        private OpenFileDialog dlgDataImport = new OpenFileDialog();
        private SaveFileDialog dlgDataExport = new SaveFileDialog();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            WorkingDirectory.Path = DataDirectory.LoadFile("Path", DataDirectory.Path);
            txtPath.Text = WorkingDirectory.Path;
            dlgFolder.IsFolderPicker = true;
            dlgDataImport.Filter = "ZIP files|*.zip";
            dlgDataExport.Filter = "ZIP files|*.zip";
            if (true) // Joke (voice assist)
            {
                lblVoice.Visible = true;
                cmbVoice.Visible = true;
                cmbVoice.Items.Add("None");
                cmbVoice.Items.AddRange(VoiceAssist.GetAvailableVoices());
                string selectedVoice = DataDirectory.LoadFile("SavedVoice");
                VoiceAssist.SelectVoice(selectedVoice);
                cmbVoice.SelectedItem = selectedVoice == "" ? "None" : selectedVoice;
                VoiceAssist.Say("Ready");
            }
            else
            {
                Height -= 301 - 268;
            }
        }

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            if (dlgFolder.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DataDirectory.SaveFile("Path", dlgFolder.FileName);
                WorkingDirectory.Path = dlgFolder.FileName;
                txtPath.Text = WorkingDirectory.Path;
                // Create directories
                DataDirectory.CreateDirectory("Images");
                DataDirectory.CreateDirectory(@"Images\Tilesets");
                DataDirectory.CreateDirectory(@"Images\Portraits");
                WorkingDirectory.CreateDirectory("Images");
                WorkingDirectory.CreateDirectory(@"Images\ClassMapSprites");
                WorkingDirectory.CreateDirectory(@"Images\ClassBattleAnimations");
            }
        }

        private void btnLevelEditor_Click(object sender, EventArgs e)
        {
            frmLevelEditor levelEditor = new frmLevelEditor();
            levelEditor.DataDirectory = DataDirectory;
            levelEditor.WorkingDirectory = WorkingDirectory;
            VoiceAssist.Say("Open");
            levelEditor.ShowDialog(this);
        }

        private void btnConversationEditor_Click(object sender, EventArgs e)
        {
            frmConversationEditor conversationEditor = new frmConversationEditor();
            conversationEditor.DataDirectory = DataDirectory;
            conversationEditor.WorkingDirectory = WorkingDirectory;
            VoiceAssist.Say("Open");
            conversationEditor.ShowDialog(this);
        }

        private void btnClassEditor_Click(object sender, EventArgs e)
        {
            frmClassEditor classEditor = new frmClassEditor();
            classEditor.DataDirectory = DataDirectory;
            classEditor.WorkingDirectory = WorkingDirectory;
            VoiceAssist.Say("Open");
            classEditor.ShowDialog(this);
        }

        private void btnPortraitEditor_Click(object sender, EventArgs e)
        {
            frmPortraitEditor portraitEditor = new frmPortraitEditor();
            portraitEditor.DataDirectory = DataDirectory;
            portraitEditor.WorkingDirectory = WorkingDirectory;
            VoiceAssist.Say("Open");
            portraitEditor.ShowDialog(this);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (dlgDataImport.ShowDialog(this) == DialogResult.OK)
            {
                FilesController tempData = new FilesController("TempData");
                if (System.IO.Directory.Exists(tempData.Path))
                {
                    System.IO.Directory.Delete(tempData.Path, true);
                }
                System.IO.Compression.ZipFile.ExtractToDirectory(dlgDataImport.FileName, tempData.Path);
                System.IO.Directory.Delete(DataDirectory.Path, true);
                System.IO.Directory.Move(tempData.Path, DataDirectory.Path);
                WorkingDirectory.Path = txtPath.Text;
                DataDirectory.SaveFile("Path", txtPath.Text);
                MessageBox.Show("Done!");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dlgDataExport.ShowDialog(this) == DialogResult.OK)
            {
                if (System.IO.File.Exists(dlgDataExport.FileName))
                {
                    System.IO.File.Delete(dlgDataExport.FileName);
                }
                System.IO.Compression.ZipFile.CreateFromDirectory(DataDirectory.Path, dlgDataExport.FileName);
                MessageBox.Show("Done!");
            }
        }

        private void cmbVoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVoice = cmbVoice.SelectedItem.ToString() == "None" ? "" : cmbVoice.SelectedItem.ToString();
            VoiceAssist.SelectVoice(selectedVoice);
            DataDirectory.SaveFile("SavedVoice", selectedVoice);
            VoiceAssist.Say("Ready");
        }
    }
}
