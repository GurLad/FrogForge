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
            Dirty = false;
            // Misc
            dlgOpen.Filter = "Image files|*.gif;*.png";
            trkFGPalette_Scroll(sender, e);
            if (WorkingDirectory.CheckFileExist("GenericPortraitsGlobalData.json"))
            {
                GlobalData = WorkingDirectory.LoadFile("GenericPortraitsGlobalData", "", ".json").JsonToObject<GenericPortraitsGlobalData>();
                pleGenericsPossibleBGPalettes.Datas = GlobalData.GenericPossibleBackgroundColors;
            }
            // Set dirty
            txtGenericsTags.TextChanged += DirtyFunc;
            Dirty = false;
        }

        private void trkFGPalette_Scroll(object sender, EventArgs e)
        {
            picCharactersFGPalette.BackColor = Palette.BaseSpritePalettes[trkCharactersFGPalette.Value][1];
            picCharactersFG.Palette = Palette.BaseSpritePalettes[trkCharactersFGPalette.Value];
            UpdateCharacterPreview();
            Dirty = true;
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
            data.ForegroundColorID = trkCharactersFGPalette.Value;
            data.BackgroundColor = pltCharactersBGPalette.Data;
            data.Background = picCharactersBG.Image;
            data.Foreground = picCharactersFG.Image;
            CurrentFile = data.Name;
            Dirty = false;
            return data;
        }

        private void CharacterDataToUI(PortraitData data)
        {
            txtCharactersName.Text = data.Name;
            trkCharactersFGPalette.Value = data.ForegroundColorID;
            picCharactersFGPalette.BackColor = Palette.BaseSpritePalettes[data.ForegroundColorID][1];
            pltCharactersBGPalette.Data = data.BackgroundColor;
            WorkingDirectory.CreateDirectory(@"Images\Portraits\" + data.Name);
            picCharactersBG.Image = data.Background ?? new PalettedImage(WorkingDirectory.LoadImage(@"Portraits\" + data.Name + @"\B") ?? new Bitmap(1, 1));
            picCharactersBG.Palette = data.BackgroundColor;
            picCharactersFG.Image = data.Foreground ?? new PalettedImage(WorkingDirectory.LoadImage(@"Portraits\" + data.Name + @"\F") ?? new Bitmap(1, 1));
            picCharactersFG.Palette = Palette.BaseSpritePalettes[trkCharactersFGPalette.Value];
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
            Cursor.Current = Cursors.Default;
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
            Width = PageWidths[tbcMain.SelectedIndex];
        }

        private void trkGenericsVoiceType_ValueChanged(object sender, EventArgs e)
        {
            lblVoiceType.Text = trkGenericsVoiceType.Value.ToString();
            Dirty = true;
        }
    }
}
