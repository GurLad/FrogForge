using FrogForge.Datas;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge.Editors
{
    public partial class frmPortraitEditor : frmBaseEditor
    {
        private static int[] PageWidths { get; } = new int[] { 393, 561 };
        private Random RNG { get; } = new Random();
        private GenericPortraitsGlobalData GlobalData = new GenericPortraitsGlobalData();

        public frmPortraitEditor()
        {
            InitializeComponent();
            BaseName = Text;
        }

        private void frmPortraitEditor_Load(object sender, EventArgs e)
        {
            // Init animation pictureboxes
            picCharactersBG.Init(dlgOpen, this);
            picCharactersFG.Init(dlgOpen, this);
            picCharactersBG.PostOnClick = picCharactersFG.PostOnClick = UpdateCharacterPreview;
            picGenericsBG.Init(dlgOpen, this);
            picGenericsFG.Init(dlgOpen, this);
            picGenericsBG.PostOnClick = picGenericsFG.PostOnClick = UpdateGenericPreview;
            // Init base
            lstCharacters.Init(this, () => new PortraitData(), CharacterDataFromUI, CharacterDataToUI, "Portraits");
            lstGenerics.Init(this, () => new GenericPortraitData(), GenericDataFromUI, GenericDataToUI, "GenericPortraits");
            pleGenericsPossibleBGPalettes.Init(null, () => new Palette(), () => new UserControls.PalettePanel(), (plt) => plt.Init(null), false);
            pltCharactersBGPalette.Init(this, (p) =>
            {
                picCharactersBG.Palette = p;
                UpdateCharacterPreview();
            });
            fgpCharactersFGPalette.Init(this, (p) =>
            {
                picCharactersFG.Palette = p;
                UpdateCharacterPreview();
            });
            fgpCharacterAccent.Init(this);
            Dirty = false;
            // Misc
            cmbVoiceType.SelectedIndex = 0;
            dlgOpen.Filter = "Image files|*.gif;*.png";
            if (WorkingDirectory.CheckFileExist("GenericPortraitsGlobalData.json"))
            {
                GlobalData = WorkingDirectory.LoadFile("GenericPortraitsGlobalData", "", ".json").JsonToObject<GenericPortraitsGlobalData>();
                pleGenericsPossibleBGPalettes.Datas = GlobalData.GenericPossibleBackgroundColors;
            }
            // Set dirty
            txtGenericsTags.TextChanged += DirtyFunc;
            nudPitch.ValueChanged += DirtyFunc;
            cmbVoiceType.SelectedIndexChanged += DirtyFunc;
            Dirty = false;
        }

        private void UpdateCharacterPreview()
        {
            picCharactersPreview.Image = picCharactersFG.Image?.Target;
            picCharactersPreview.BackgroundImage = picCharactersBG.Image?.Target;
        }

        private void UpdateGenericPreview()
        {
            picGenericsPreview.Image = picGenericsFG.Image?.Target;
            picGenericsPreview.BackgroundImage = picGenericsBG.Image?.Target;
            picGenericsBG.Palette = pleGenericsPossibleBGPalettes.Datas.Count > 0 ?
                pleGenericsPossibleBGPalettes.Datas[RNG.Next(pleGenericsPossibleBGPalettes.Datas.Count)] : Palette.BasePalette;
            picGenericsFG.Palette = Palette.BaseSpritePalettes[RNG.Next(0, 4)];
        }

        private PortraitData CharacterDataFromUI(PortraitData data)
        {
            data.Name = txtCharactersName.Text;
            data.ForegroundColorID = fgpCharactersFGPalette.Data;
            data.BackgroundColor = pltCharactersBGPalette.Data;
            data.Background = picCharactersBG.Image;
            data.Foreground = picCharactersFG.Image;
            data.AccentColor = fgpCharacterAccent.Data;
            data.Voice.Pitch = (float)nudPitch.Value;
            data.Voice.VoiceType = (VoiceType)cmbVoiceType.SelectedIndex;
            CurrentFile = data.Name;
            Dirty = false;
            return data;
        }

        private void CharacterDataToUI(PortraitData data)
        {
            data.LoadImages(WorkingDirectory);
            txtCharactersName.Text = data.Name;
            fgpCharactersFGPalette.Data = data.ForegroundColorID;
            pltCharactersBGPalette.Data = data.BackgroundColor;
            picCharactersBG.Image = data.Background ?? new PalettedImage(new Bitmap(1, 1));
            picCharactersBG.Palette = data.BackgroundColor;
            picCharactersFG.Image = data.Foreground ?? new PalettedImage(new Bitmap(1, 1));
            picCharactersFG.Palette = Palette.BaseSpritePalettes[fgpCharactersFGPalette.Data];
            fgpCharacterAccent.Data = data.AccentColor;
            nudPitch.Value = (decimal)data.Voice.Pitch;
            cmbVoiceType.SelectedIndex = (int)data.Voice.VoiceType;
            UpdateCharacterPreview();
            CurrentFile = data.Name;
            Dirty = false;
        }

        private GenericPortraitData GenericDataFromUI(GenericPortraitData data)
        {
            data.Name = txtGenericsID.Text;
            data.tags = txtGenericsTags.Text;
            data.VoiceType = trkGenericsVoiceType.Value;
            data.Background = picGenericsBG.Image;
            data.Foreground = picGenericsFG.Image;
            CurrentFile = data.Name;
            Dirty = false;
            return data;
        }

        private void GenericDataToUI(GenericPortraitData data)
        {
            txtGenericsID.Text = data.Name;
            txtGenericsTags.Text = data.tags;
            trkGenericsVoiceType.Value = data.VoiceType;
            WorkingDirectory.CreateDirectory(@"Images\GenericPortraits\" + data.Name);
            picGenericsBG.Image = data.Background ?? new PalettedImage(WorkingDirectory.LoadImage(@"GenericPortraits\" + data.Name + @"\B") ?? new Bitmap(1, 1));
            picGenericsFG.Image = data.Foreground ?? new PalettedImage(WorkingDirectory.LoadImage(@"GenericPortraits\" + data.Name + @"\F") ?? new Bitmap(1, 1));
            UpdateGenericPreview();
            CurrentFile = data.Name;
            Dirty = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbcMain.SelectedIndex == 0)
            {
                lstCharacters.Save(txtCharactersName.Text);
            }
            else
            {
                lstGenerics.Save(txtGenericsID.Text);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (tbcMain.SelectedIndex == 0)
            {
                lstCharacters.New();
            }
            else
            {
                lstGenerics.New();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BasePortraitData removed;
            string baseFolder;
            if (tbcMain.SelectedIndex == 0)
            {
                removed = lstCharacters.Remove();
                baseFolder = @"Images\Portraits\" + removed?.Name;
            }
            else
            {
                removed = lstGenerics.Remove();
                baseFolder = @"Images\GenericPortraits\" + removed?.Name;
            }
            if (removed != null) // Delete images
            {
                if (WorkingDirectory.CheckFileExist(baseFolder + @"\F" + WorkingDirectory.DefultImageFileFormat))
                {
                    DeleteFile(baseFolder + @"\F", WorkingDirectory, false, WorkingDirectory.DefultImageFileFormat);
                }
                if (WorkingDirectory.CheckFileExist(baseFolder + @"\B" + WorkingDirectory.DefultImageFileFormat))
                {
                    DeleteFile(baseFolder + @"\B", WorkingDirectory, false, WorkingDirectory.DefultImageFileFormat);
                }
                // TBA: Delete folder
            }
        }

        private void frmPortraitEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            // Characters save
            lstCharacters.SaveToFile();
            // Characters save images
            foreach (PortraitData item in lstCharacters.Data)
            {
                WorkingDirectory.CreateDirectory(@"Images\Portraits\" + item.Name);
                if (item.Foreground != null)
                {
                    item.Foreground.CurrentPalette = Palette.BasePalette;
                    WorkingDirectory.SaveImage(@"Portraits\" + item.Name + @"\F", item.Foreground.Target);
                }
                if (item.Background != null)
                {
                    item.Background.CurrentPalette = Palette.BasePalette;
                    WorkingDirectory.SaveImage(@"Portraits\" + item.Name + @"\B", item.Background.Target);
                }
            }
            // Generics save
            lstGenerics.SaveToFile();
            // Generics save images
            foreach (GenericPortraitData item in lstGenerics.Data)
            {
                WorkingDirectory.CreateDirectory(@"Images\GenericPortraits\" + item.Name);
                if (item.Foreground != null)
                {
                    item.Foreground.CurrentPalette = Palette.BasePalette;
                    WorkingDirectory.SaveImage(@"GenericPortraits\" + item.Name + @"\F", item.Foreground.Target);
                }
                if (item.Background != null)
                {
                    item.Background.CurrentPalette = Palette.BasePalette;
                    WorkingDirectory.SaveImage(@"GenericPortraits\" + item.Name + @"\B", item.Background.Target);
                }
            }
            // Generics global data save
            GlobalData.GenericPossibleBackgroundColors = pleGenericsPossibleBGPalettes.Datas;
            WorkingDirectory.SaveFile("GenericPortraitsGlobalData", GlobalData.ToJson(), ".json");
            Cursor.Current = Cursors.Default;
        }

        protected override bool ControlKeyAction(Keys key)
        {
            switch (key)
            {
                case Keys.S:
                    btnSave_Click(this, new EventArgs());
                    return true;
                case Keys.N:
                    btnNew_Click(this, new EventArgs());
                    return true;
                default:
                    break;
            }
            return false;
        }

        private void tbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (HasUnsavedChanges())
            //{
            //    return;
            //}
            Width = PageWidths[tbcMain.SelectedIndex];
            CurrentFile = "";
        }

        private void trkGenericsVoiceType_ValueChanged(object sender, EventArgs e)
        {
            lblVoiceType.Text = trkGenericsVoiceType.Value.ToString();
            Dirty = true;
        }

        private void trkPitch_Scroll(object sender, EventArgs e)
        {
            nudPitch.Value = trkPitch.Value / (decimal)100;
        }

        private void nudPitch_ValueChanged(object sender, EventArgs e)
        {
            trkPitch.Value = (int)(nudPitch.Value * 100);
        }

        private void cmbVoiceType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnVoicePlay_Click(object sender, EventArgs e)
        {
            // From https://github.com/naudio/NAudio/blob/master/Docs/SmbPitchShiftingSampleProvider.md. Pitch changing outside Unity is weird.
            string inPath = DataDirectory.Path + @"\BaseVoices\" + cmbVoiceType.Text + ".wav";
            double semitone = Math.Pow(2, 1.0 / 12);
            double upOneTone = semitone * semitone;
            double downOneTone = 1.0 / upOneTone;
            double targetPitch = ((double)nudPitch.Value + (-0.1 + RNG.NextDouble() / 5)) * semitone;
            using (var reader = new MediaFoundationReader(inPath))
            {
                var pitch = new SmbPitchShiftingSampleProvider(reader.ToSampleProvider());
                using (var device = new WaveOutEvent())
                {
                    pitch.PitchFactor = (float)targetPitch;
                    device.Init(pitch.Take(TimeSpan.FromSeconds(5)));
                    //device.Init(new AudioFileReader(inPath));
                    device.Play();
                    System.Threading.Thread.Sleep(400);
                }
            }
        }
    }
}
