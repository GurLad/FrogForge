using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private OpenFileDialog dlgProjectImport = new OpenFileDialog();
        private SaveFileDialog dlgProjectExport = new SaveFileDialog();
        private string GamePath = "";

        public frmMenu()
        {
            InitializeComponent();
        }

        private async void frmMenu_Load(object sender, EventArgs e)
        {
            // Init stuff
            FontStuff.CreateFont(Properties.Resources.Gaiden);
            FontStuff.CreateFont(Properties.Resources._3X5);
            lblCredits.Font = lblVersion.Font = FontStuff.GetFont("3x5", lblCredits.Font.Size);
            dlgFolder.IsFolderPicker = true;
            dlgDataImport.Filter = "Frog Forge editor data files|*.ffed";
            dlgDataExport.Filter = "Frog Forge editor data files|*.ffed";
            dlgProjectImport.Filter = "Frog Forge project data files|*.ffpd";
            dlgProjectExport.Filter = "Frog Forge project data files|*.ffpd";
            GamePath = DataDirectory.LoadFile("GamePath", "");
            string workingPath = DataDirectory.LoadFile("Path", "");
            if (workingPath == "")
            {
                if (WorkingDirectory.DirectoryExists(@"\Game\Data"))
                {
                    GamePath = WorkingDirectory.Path + @"\Game\";
                    DataDirectory.SaveFile("GamePath", GamePath);
                    WorkingDirectory.Path += @"\Game\Data";
                    DataDirectory.SaveFile("Path", WorkingDirectory.Path);
                }
                else
                {
                    if (ExtensionMethods.ConfirmDialog("Game directory not found. Locate manually?", "Missing game files"))
                    {
                        btnChangePath_Click(sender, e);
                        if (WorkingDirectory.Path == "")
                        {
                            Close();
                            return;
                        }
                    }
                    else
                    {
                        Close();
                        return;
                    }
                }
            }
            else
            {
                WorkingDirectory.Path = workingPath;
            }
            if (GamePath == "")
            {
                btnFrogForgeData.Visible = true;
                btnDebugOptions.Visible = false;
                btnPlay.Visible = false;
                Height -= 30;
            }
            // Load prefences
            string json = DataDirectory.LoadFile("Preferences", "", ".json");
            Preferences.Current = ((json == "" ? null : json)?.JsonToObject<Preferences>()) ?? new Preferences();
            // Apply them
            this.ApplyPreferences();
            CenterToScreen();
            lblVersion.Font = lblCredits.Font = new Font(lblCredits.Font.FontFamily, (int)Math.Round(lblCredits.Font.Size * Preferences.Current.ZoomAmount));
            lblTitle.Font = new Font(lblTitle.Font.FontFamily, (int)Math.Round(lblTitle.Font.Size * Preferences.Current.ZoomAmount));
            // Joke (voice assist)
            if (Preferences.Current.VoiceAssistAvailable)
            {
                VoiceAssist.SelectVoice(Preferences.Current.VoiceAssist ?? "");
                VoiceAssist.Say("Ready");
            }
            // Init project
            if (!WorkingDirectory.CheckFileExist("GameSettings.json"))
            {
                await InitProject(true);
            }
        }

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            if (dlgFolder.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DataDirectory.SaveFile("Path", dlgFolder.FileName);
                WorkingDirectory.Path = dlgFolder.FileName;
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
            frmMapEditor levelEditor = new frmMapEditor();
            levelEditor.DataDirectory = DataDirectory;
            levelEditor.WorkingDirectory = WorkingDirectory;
            VoiceAssist.Say("New");
            levelEditor.ShowDialog(this);
        }

        private void btnConversationEditor_Click(object sender, EventArgs e)
        {
            frmConversationEditor conversationEditor = new frmConversationEditor();
            conversationEditor.DataDirectory = DataDirectory;
            conversationEditor.WorkingDirectory = WorkingDirectory;
            VoiceAssist.Say("New");
            conversationEditor.ShowDialog(this);
        }

        private void btnClassEditor_Click(object sender, EventArgs e)
        {
            frmClassEditor classEditor = new frmClassEditor();
            classEditor.DataDirectory = DataDirectory;
            classEditor.WorkingDirectory = WorkingDirectory;
            VoiceAssist.Say("New");
            classEditor.ShowDialog(this);
        }

        private void btnPortraitEditor_Click(object sender, EventArgs e)
        {
            frmPortraitEditor portraitEditor = new frmPortraitEditor();
            portraitEditor.DataDirectory = DataDirectory;
            portraitEditor.WorkingDirectory = WorkingDirectory;
            VoiceAssist.Say("New");
            portraitEditor.ShowDialog(this);
        }

        private void btnLevelMetadataEditor_Click(object sender, EventArgs e)
        {
            frmLevelMetadataEditor levelMetadataEditor = new frmLevelMetadataEditor();
            levelMetadataEditor.DataDirectory = DataDirectory;
            levelMetadataEditor.WorkingDirectory = WorkingDirectory;
            VoiceAssist.Say("New");
            levelMetadataEditor.ShowDialog(this);
        }

        private void btnTilemapEditor_Click(object sender, EventArgs e)
        {
            frmTilesetEditor tilesetEditor = new frmTilesetEditor();
            tilesetEditor.DataDirectory = DataDirectory;
            tilesetEditor.WorkingDirectory = WorkingDirectory;
            VoiceAssist.Say("New");
            tilesetEditor.ShowDialog(this);
        }

        private void btnCGEditor_Click(object sender, EventArgs e)
        {
            frmCGEditor cgEditor = new frmCGEditor();
            cgEditor.DataDirectory = DataDirectory;
            cgEditor.WorkingDirectory = WorkingDirectory;
            VoiceAssist.Say("New");
            cgEditor.ShowDialog(this);
        }

        private void btnMusicEditor_Click(object sender, EventArgs e)
        {
            frmMusicEditor musicEditor = new frmMusicEditor();
            musicEditor.DataDirectory = DataDirectory;
            musicEditor.WorkingDirectory = WorkingDirectory;
            VoiceAssist.Say("New");
            musicEditor.ShowDialog(this);
        }

        private async void btnDataImport_Click(object sender, EventArgs e)
        {
            if (dlgDataImport.ShowDialog(this) == DialogResult.OK)
            {
                PreWork();
                frmWorkProgress workProgress = frmWorkProgress.Show("Extracting...", "importing", true, false, this);
                FilesController tempData = new FilesController("TempData");
                // Delete current TempData (shouldn't exist, but just in case)
                string tempPath = WorkingDirectory.Path;
                if (System.IO.Directory.Exists(tempData.Path))
                {
                    await Task.Run(() => System.IO.Directory.Delete(tempData.Path, true));
                }
                if (workProgress.Canceled)
                {
                    workProgress.End();
                    PostWork(false);
                    return;
                }
                // Extract the data
                await Task.Run(() => System.IO.Compression.ZipFile.ExtractToDirectory(dlgDataImport.FileName, tempData.Path));
                workProgress.Cancelable = false; // After we delete the current data (next command), it's impossible to cancel the import
                await workProgress.FinishCanceling();
                if (workProgress.Canceled)
                {
                    workProgress.End();
                    PostWork(false);
                    return;
                }
                // Move the TempData to the real Data folder
                workProgress.LabelText = "Importing...";
                await Task.Run(() => System.IO.Directory.Delete(DataDirectory.Path, true));
                await Task.Run(() => System.IO.Directory.Move(tempData.Path, DataDirectory.Path));
                WorkingDirectory.Path = tempPath;
                DataDirectory.SaveFile("Path", WorkingDirectory.Path);
                workProgress.End();
                PostWork();
            }
        }

        private async void btnDataExport_Click(object sender, EventArgs e)
        {
            if (dlgDataExport.ShowDialog(this) == DialogResult.OK)
            {
                PreWork();
                frmWorkProgress workProgress = frmWorkProgress.Show("Exporting...", "exporting", false, false, this);
                if (System.IO.File.Exists(dlgDataExport.FileName))
                {
                    await Task.Run(() => System.IO.File.Delete(dlgDataExport.FileName));
                }
                await Task.Run(() => System.IO.Compression.ZipFile.CreateFromDirectory(DataDirectory.Path, dlgDataExport.FileName));
                workProgress.End();
                PostWork();
            }
        }

        private async void btnProjectNew_Click(object sender, EventArgs e)
        {
            await InitProject();
        }

        private async void btnProjectImport_Click(object sender, EventArgs e)
        {
            if (dlgProjectImport.ShowDialog(this) == DialogResult.OK)
            {
                await ImportProject(dlgProjectImport.FileName);
            }
        }

        private async void btnProjectExport_Click(object sender, EventArgs e)
        {
            if (dlgProjectExport.ShowDialog(this) == DialogResult.OK)
            {
                await ExportProject(dlgProjectExport.FileName);
            }
        }

        private void btnGameSettings_Click(object sender, EventArgs e)
        {
            new frmGameSettingsEditor(WorkingDirectory).ShowDialog(this);
        }

        private void btnDebugOptions_Click(object sender, EventArgs e)
        {
            new frmDebugOptionsEditor(WorkingDirectory).ShowDialog(this);
        }

        private void btnEditPreferences_Click(object sender, EventArgs e)
        {
            new frmPreferences(DataDirectory).ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Process.Start(GamePath + "Frogman Magmaborn.exe");
        }

        private void btnHelpColorsResolutions_Click(object sender, EventArgs e)
        {
            frmColorsHelp colorsHelp = new frmColorsHelp();
            colorsHelp.ShowDialog(this);
        }

        private void btnHelpOnlineWiki_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.github.com/GurLad/FrogForge/wiki");
        }

        private void btnHelpSourceCode_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.github.com/GurLad/FrogForge");
        }

        private async Task InitProject(bool skipWarnings = false)
        {
            if (!skipWarnings)
            {
                if (!ExtensionMethods.ConfirmDialog("Warning! Creating a new project will override your current mod, erasing everything you've changed. This action cannot be undone. Continue?", "New project"))
                {
                    return;
                }
            }
            frmProjectInit projectInit = new frmProjectInit();
            projectInit.ShowDialog(this);
            await ImportProject(DataDirectory.Path + @"\ProjectTemplates\" + projectInit.SelectedTemplate + ".ffpd", false);
        }

        private async Task ImportProject(string path, bool cancelable = true)
        {
            PreWork();
            frmWorkProgress workProgress = frmWorkProgress.Show("Extracting...", "importing", cancelable, false, this);
            FilesController tempProject = new FilesController();
            // Delete current TempData (shouldn't exist, but just in case)
            tempProject.Path = WorkingDirectory.Path.Substring(0, WorkingDirectory.Path.LastIndexOf(@"\"));
            tempProject.CreateDirectory("TempData", true);
            if (System.IO.Directory.Exists(tempProject.Path))
            {
                await Task.Run(() => System.IO.Directory.Delete(tempProject.Path, true));
            }
            if (workProgress.Canceled)
            {
                workProgress.End();
                PostWork(false);
                return;
            }
            // Extract the project
            await Task.Run(() => System.IO.Compression.ZipFile.ExtractToDirectory(path, tempProject.Path));
            workProgress.Cancelable = false; // After we delete the current project (next command), it's impossible to cancel the import
            await workProgress.FinishCanceling();
            if (workProgress.Canceled)
            {
                workProgress.End();
                PostWork(false);
                return;
            }
            // Move the project to the real Data folder
            workProgress.LabelText = "Importing...";
            if (System.IO.Directory.Exists(WorkingDirectory.Path))
            {
                await Task.Run(() => System.IO.Directory.Delete(WorkingDirectory.Path, true));
            }
            await Task.Run(() => System.IO.Directory.Move(tempProject.Path, WorkingDirectory.Path));
            workProgress.End();
            PostWork();
        }

        private async Task ExportProject(string path)
        {
            PreWork();
            frmWorkProgress workProgress = frmWorkProgress.Show("Exporting...", "exporting", false, false, this);
            if (System.IO.File.Exists(path))
            {
                await Task.Run(() => System.IO.File.Delete(path));
            }
            await Task.Run(() => System.IO.Compression.ZipFile.CreateFromDirectory(WorkingDirectory.Path, path));
            workProgress.End();
            PostWork();
        }

        private void PreWork()
        {
            Enabled = false;
        }

        private void PostWork(bool success = true)
        {
            if (success)
            {
                MessageBox.Show("Done!");
            }
            Enabled = true;
            Focus();
        }
    }
}
