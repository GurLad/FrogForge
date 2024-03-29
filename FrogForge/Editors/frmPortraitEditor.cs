﻿using FrogForge.Datas;
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
        private static int[] PageWidths { get; } = new int[] { 393, 609 };
        private Random RNG { get; } = new Random();
        private GenericPortraitsGlobalData GlobalData = new GenericPortraitsGlobalData();
        private List<Palette> BaseSpritePalettes;

        public frmPortraitEditor()
        {
            InitializeComponent();
            BaseName = Text;
        }

        private void frmPortraitEditor_Load(object sender, EventArgs e)
        {
            // Init palettes
            BaseSpritePalettes = Palette.GetBaseSpritePalettes(WorkingDirectory);
            // Init animation pictureboxes
            picCharactersBG.Init(dlgOpen, this, pltCharactersBGPalette);
            picCharactersFG.Init(dlgOpen, this);
            picCharactersBG.PostOnClick = picCharactersFG.PostOnClick = UpdateCharacterPreview;
            picGenericsBG.Init(dlgOpen, this, new UserControls.PalettePanel()); // So that auto-palettes won't think it's a sprite one
            picGenericsFG.Init(dlgOpen, this);
            picGenericsBG.PostOnClick = picGenericsFG.PostOnClick = UpdateGenericPreview;
            // Init base
            lstCharacters.Init(this, () => new PortraitData(), CharacterDataFromUI, CharacterDataToUI, "Portraits");
            lstGenerics.Init(this, () => new GenericPortraitData(), GenericDataFromUI, GenericDataToUI, "GenericPortraits");
            pleGenericsPossibleBGPalettes.Init(null, () => new Palette(), () => new UserControls.PalettePanel(),
                (plt) => { plt.Init(null); }, false);
            pleGenericsCharacterVoices.Init(null, () => new GenericCharacterVoice(), () => new UserControls.GenericCharacterVoicePanel(), (gcv) => gcv.Init());
            pltCharactersBGPalette.Init(this, (p) =>
            {
                picCharactersBG.Palette = p;
                UpdateCharacterPreview();
            });
            fgpCharactersFGPalette.Init(this, BaseSpritePalettes, (p) =>
            {
                picCharactersFG.Palette = p;
                UpdateCharacterPreview();
            });
            fgpCharacterAccent.Init(this, BaseSpritePalettes);
            vpsVoicePitch.Init(this);
            vpsVoiceSpeed.Init(this);
            vtsGenericsVoiceTypeSelector.Init(this);
            Dirty = false;
            this.ApplyPreferences();
            // Misc
            cmbVoiceType.SelectedIndex = 0;
            dlgOpen.Filter = "Image files|*.gif;*.png";
            if (WorkingDirectory.CheckFileExist("GenericPortraitsGlobalData.json"))
            {
                GlobalData = WorkingDirectory.LoadFile("GenericPortraitsGlobalData", "", ".json").JsonToObject<GenericPortraitsGlobalData>();
                pleGenericsPossibleBGPalettes.Datas = GlobalData.GenericPossibleBackgroundColors;
                pleGenericsCharacterVoices.Datas = GlobalData.GenericVoicesAndNames;
                UpdateGenericVoices();
            }
            // Set dirty
            txtGenericsTags.TextChanged += DirtyFunc;
            cmbVoiceType.SelectedIndexChanged += DirtyFunc;
            Dirty = false;
            // Load empty
            btnNew_Click(sender, e);
        }

        private void UpdateCharacterPreview()
        {
            picCharactersPreview.Image = picCharactersFG.Image?.Target;
            picCharactersPreview.BackgroundImage = picCharactersBG.Image?.Target;
            picCharactersPreview.FixZoom();
        }

        private void UpdateGenericPreview()
        {
            picGenericsPreview.Image = picGenericsFG.Image?.Target;
            picGenericsPreview.BackgroundImage = picGenericsBG.Image?.Target;
            picGenericsBG.Palette = pleGenericsPossibleBGPalettes.Datas.Count > 0 ?
                pleGenericsPossibleBGPalettes.Datas[RNG.Next(pleGenericsPossibleBGPalettes.Datas.Count)] : Palette.BasePalette;
            picGenericsFG.Palette = BaseSpritePalettes[RNG.Next(0, 4)];
            picGenericsPreview.FixZoom();
        }

        private void UpdateGenericVoices()
        {
            vtsGenericsVoiceTypeSelector.OptionNames = pleGenericsCharacterVoices.Datas.ConvertAll(a => a.InternalName);
        }

        private PortraitData CharacterDataFromUI(PortraitData data)
        {
            data.Name = txtCharactersName.Text;
            data.DisplayName = txtCharactersDisplayName.Text;
            data.ForegroundColorID = fgpCharactersFGPalette.Data;
            data.BackgroundColor = pltCharactersBGPalette.Data;
            data.Background = picCharactersBG.Image;
            data.Foreground = picCharactersFG.Image;
            data.AccentColor = fgpCharacterAccent.Data;
            data.Voice.Pitch = vpsVoicePitch.Pitch;
            data.Voice.Speed = vpsVoiceSpeed.Pitch;
            data.Voice.VoiceType = (VoiceType)cmbVoiceType.SelectedIndex;
            CurrentFile = data.Name;
            Dirty = false;
            return data;
        }

        private void CharacterDataToUI(PortraitData data)
        {
            data.LoadImages(WorkingDirectory);
            txtCharactersName.Text = data.Name;
            txtCharactersDisplayName.Text = data.DisplayName;
            fgpCharactersFGPalette.Data = data.ForegroundColorID;
            pltCharactersBGPalette.Data = data.BackgroundColor;
            picCharactersBG.Image = data.Background ?? new PalettedImage(new Bitmap(1, 1));
            picCharactersBG.Palette = data.BackgroundColor;
            picCharactersFG.Image = data.Foreground ?? new PalettedImage(new Bitmap(1, 1));
            picCharactersFG.Palette = BaseSpritePalettes[fgpCharactersFGPalette.Data];
            fgpCharacterAccent.Data = data.AccentColor;
            vpsVoicePitch.Pitch = data.Voice.Pitch;
            vpsVoiceSpeed.Pitch = data.Voice.Speed;
            cmbVoiceType.SelectedIndex = (int)data.Voice.VoiceType;
            UpdateCharacterPreview();
            CurrentFile = data.Name;
            Dirty = false;
        }

        private GenericPortraitData GenericDataFromUI(GenericPortraitData data)
        {
            data.Name = txtGenericsID.Text;
            data.tags = txtGenericsTags.Text;
            data.VoiceTypes = vtsGenericsVoiceTypeSelector.SelectedOptions;
            data.Background = picGenericsBG.Image;
            data.Foreground = picGenericsFG.Image;
            CurrentFile = data.Name;
            UpdateGenericVoices();
            Dirty = false;
            return data;
        }

        private void GenericDataToUI(GenericPortraitData data)
        {
            txtGenericsID.Text = data.Name;
            txtGenericsTags.Text = data.tags;
            vtsGenericsVoiceTypeSelector.SelectedOptions = data.VoiceTypes;
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
                if (WorkingDirectory.DirectoryExists(@"\" + baseFolder))
                {
                    DeleteFolder(baseFolder, WorkingDirectory);
                }
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
            GlobalData.GenericVoicesAndNames = pleGenericsCharacterVoices.Datas;
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
            this.ResizeByZoom(false, y: false);
            CurrentFile = "";
        }

        private void trkGenericsVoiceType_ValueChanged(object sender, EventArgs e)
        {
            Dirty = true;
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
            double targetPitch = ((double)vpsVoicePitch.Pitch + (-0.1 + RNG.NextDouble() / 5)) * semitone;
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

        private void txtCharactersName_TextChanged(object sender, EventArgs e)
        {
            txtCharactersDisplayName.Text = txtCharactersName.Text.Length <= 8 ? txtCharactersName.Text : txtCharactersName.Text.Substring(0, 8);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (tbcMain.SelectedIndex == 0)
            {
                dlgExport.Filter = "Portrait data files|*.portrait.ffpp";
                PortraitData data = CharacterDataFromUI(new PortraitData());
                ProjectPart.Export(
                    dlgExport, "Portrait", data,
                    data.Foreground.ToBitmap(Palette.BasePalette),
                    data.Background.ToBitmap(Palette.BasePalette));
            }
            else
            {
                dlgExport.Filter = "Generic portrait data files|*.generic.ffpp";
                GenericPortraitData data = GenericDataFromUI(new GenericPortraitData());
                ProjectPart.Export(
                    dlgExport, "Generic", data,
                    data.Foreground.ToBitmap(Palette.BasePalette),
                    data.Background.ToBitmap(Palette.BasePalette));
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (tbcMain.SelectedIndex == 0)
            {
                dlgImport.Filter = "Portrait data files|*.portrait.ffpp";
                ProjectPart.Import<PortraitData>(
                    dlgImport, "Portrait",
                    (p) =>
                    {
                        CharacterDataToUI(p);
                        btnSave_Click(sender, e);
                    },
                    (p, img) => p.Foreground = new PalettedImage(img),
                    (p, img) => p.Background = new PalettedImage(img));
            }
            else
            {
                dlgImport.Filter = "Generic portrait data files|*.generic.ffpp";
                ProjectPart.Import<GenericPortraitData>(
                    dlgImport, "Generic",
                    (p) =>
                    {
                        GenericDataToUI(p);
                        btnSave_Click(sender, e);
                    },
                    (p, img) => p.Foreground = new PalettedImage(img),
                    (p, img) => p.Background = new PalettedImage(img));
            }
        }
    }
}
