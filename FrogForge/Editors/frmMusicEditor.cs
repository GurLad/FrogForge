using FrogForge.Datas;
using FrogForge.UserControls;
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
    public partial class frmMusicEditor : frmBaseEditor
    {
        private FilesController CurrentDirectory { get; set; }
        private JSONBrowser<MusicData> lstMusics { get; set; } = new JSONBrowser<MusicData>(); // A very bad workaround to add convinient JSON support
        private NAudio.Wave.WaveOut WaveOut = new NAudio.Wave.WaveOut();
        private List<MusicData> Musics
        {
            get
            {
                return lstMusics.Data;
            }
        }
        private MusicData _current;
        private MusicData Current
        {
            get
            {
                return _current;
            }
            set
            {
                _current = value;
                btnSave.Enabled = btnPlay.Enabled = Current != null;
                txtName.Text = CurrentFile = Current?.FileName ?? "";
                txtInternalName.Text = Current?.Name ?? "";
            }
        }

        public frmMusicEditor()
        {
            InitializeComponent();
            BaseName = Text;
        }

        private void frmMusicEditor_Load(object sender, EventArgs e)
        {
            // Find directory
            CurrentDirectory = new FilesController();
            CurrentDirectory.Path = WorkingDirectory.Path;
            CurrentDirectory.CreateDirectory("Musics", true);
            // Load levels
            CurrentDirectory.DefultFileFormat = ".ogg";
            flbFiles.Directory = CurrentDirectory;
            flbFiles.TopMostDirectory = CurrentDirectory.Path;
            flbFiles.OnFileSelected = LoadFile;
            flbFiles.ShowDirectories = true;
            flbFiles.UpdateList();
            // Set dirty
            txtInternalName.TextChanged += DirtyFunc;
            // Init stuff
            lstMusics.Init(this, null, null, null, "Musics");
            Current = null;
            this.ApplyPreferences();
        }

        private void LoadFile(string fileName)
        {
            if (HasUnsavedChanges())
            {
                return;
            }
            Current = Musics.Find(a => a.FullFileName == flbFiles.CurrentSubDirectory + @"\" + fileName);
            Dirty = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Current == null) // Failsafe, although this should be impossible
            {
                return;
            }
            if (Current.Directory != flbFiles.CurrentSubDirectory)
            {
                if (ConfirmDialog("It appears that you're trying to save an existing file in another directory. Is this intended?", ""))
                {
                    string tempInternalName = txtInternalName.Text;
                    Current = Musics.Find(a => a.FullFileName == flbFiles.CurrentSubDirectory + @"\" + Current.FileName) ?? new MusicData(tempInternalName, Current.FileName);
                    Current.Name = txtInternalName.Text = tempInternalName;
                    if (!System.IO.File.Exists(CurrentDirectory.Path + @"\" + Current.FileName))
                    {
                        System.IO.File.Copy(WorkingDirectory.Path + @"\" + Current.Directory + @"\" + Current.FileName, CurrentDirectory.Path + @"\" + Current.FileName);
                    }
                }
                else
                {
                    CurrentDirectory.Path = flbFiles.TopMostDirectory + Current.Directory;
                }
            }
            Dirty = false;
            flbFiles.UpdateList();
            flbFiles.SelectedFilename = Current.FileName;
            Current.Name = txtInternalName.Text;
            VoiceAssist.Say("Save");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string toDelete = flbFiles.SelectedFilename ?? txtName.Text;
            if (CurrentDirectory.CheckFileExist(toDelete + CurrentDirectory.DefultFileFormat))
            {
                if (DeleteFile(toDelete, CurrentDirectory))
                {
                    flbFiles.UpdateList();
                    Current = null;
                    VoiceAssist.Say("Delete");
                    Dirty = false;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // TBA: Add support for mp3/wav
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dlgOpen.FileNames.Length; i++)
                {
                    string fileName = dlgOpen.SafeFileNames[i];
                    if (System.IO.File.Exists(CurrentDirectory.Path + @"\" + fileName))
                    {
                        MessageBox.Show("There is already a music file called " + fileName + " in this directory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    System.IO.File.Copy(dlgOpen.FileNames[i], CurrentDirectory.Path + @"\" + fileName);
                    fileName = fileName.Replace(".ogg", "");
                    MusicData newData = new MusicData(fileName, flbFiles.CurrentSubDirectory + @"\" + fileName);
                    Musics.Add(newData);
                    Current = newData;
                }
                flbFiles.UpdateList();
                Dirty = false;
            }
        }

        private void frmMusicEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            lstMusics.SaveToFile();
            WaveOut.Stop();
            WaveOut.Dispose();
        }

        private void btnNewFolder_Click(object sender, EventArgs e)
        {
            string folderName = InputBox.Show("New folder", "Enter folder name:", this);
            if ((folderName ?? "") == "")
            {
                return;
            }
            CurrentDirectory.CreateDirectory(folderName);
            flbFiles.UpdateList();
        }

        private void btnDeleteFolder_Click(object sender, EventArgs e)
        {
            string toDelete = flbFiles.SelectedFilename ?? @"\";
            if (flbFiles.IsAtTopMostDirectory && toDelete == @"\")
            {
                return;
            }
            string toDeleteName = toDelete != @"\" ? toDelete.Replace(@"\", "") : CurrentDirectory.Path.Substring(CurrentDirectory.Path.LastIndexOf(@"\") + 1);
            if (CurrentDirectory.DirectoryExists(toDelete) &&
                ConfirmDialog("Are you sure you want to delete folder " + toDeleteName + "?", "Warning") &&
                (CurrentDirectory.AllFiles(false, true, toDelete).Length == 0 ||
                 ConfirmDialog("Warning! " + toDeleteName + " contains files. Continue anyway?", "Warning")))
            {
                CurrentDirectory.DeleteDirectory(toDelete);
                if (toDelete == @"\")
                {
                    flbFiles.Navigate(@"\..");
                }
                flbFiles.UpdateList();
            }
        }

        protected override bool ControlKeyAction(Keys key)
        {
            switch (key)
            {
                case Keys.S:
                    btnSave_Click(this, new EventArgs());
                    return true;
                //case Keys.N:
                //    btnNew_Click(this, new EventArgs());
                //    return true;
                default:
                    break;
            }
            return false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (Current == null) // Failsafe, although this should be impossible
            {
                return;
            }
            WaveOut.Stop();
            WaveOut.Dispose();
            WaveOut = new NAudio.Wave.WaveOut();
            var vorbisStream = new NAudio.Vorbis.VorbisWaveReader(flbFiles.TopMostDirectory + @"\" + Current.FullFileName + ".ogg");
            WaveOut.Init(vorbisStream);
            WaveOut.Play();       
        }
    }
}
