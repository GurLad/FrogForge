using FrogForge.Datas;
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
        private List<MusicData> Musics;
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
                btnSave.Enabled = _current != null;
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
            if (WorkingDirectory.CheckFileExist("Musics.json"))
            {
                Musics = WorkingDirectory.LoadFile("Musics", "", ".json").JsonToObject<List<MusicData>>();
                flbFiles.UpdateList();
            }
            else
            {
                Musics = new List<MusicData>();
            }
            Current = null;
            this.ApplyPreferences();
        }

        private void LoadFile(string fileName)
        {
            if (HasUnsavedChanges())
            {
                return;
            }
            Current = Musics.Find(a => a.FullFileName == flbFiles.CurrentSubDirectory + fileName);
            txtName.Text = fileName;
            txtInternalName.Text = Current.Name;
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
                    // TBA - copy the file
                    return;
                }
                else
                {
                    CurrentDirectory.Path = flbFiles.TopMostDirectory + Current.Directory;
                }
            }
            Dirty = false;
            flbFiles.UpdateList();
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
                    txtInternalName.Text = txtName.Text = "";
                    VoiceAssist.Say("Delete");
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // TBA: Add support for mp3/wav
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.Copy(dlgOpen.FileName, CurrentDirectory.Path + dlgOpen.SafeFileName);
                string fileName = dlgOpen.SafeFileName.Replace(".ogg", "");
                MusicData newData = new MusicData(fileName, flbFiles.CurrentSubDirectory + fileName);
                Musics.Add(newData);
                Current = newData;
                txtName.Text = Current.FileName;
                txtInternalName.Text = Current.Name;
                flbFiles.UpdateList();
            }
        }

        private void frmMusicEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            WorkingDirectory.SaveFile("Musics", Musics.ToJson(), ".json");
        }
    }
}
