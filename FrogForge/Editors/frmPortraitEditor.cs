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
        private List<PictureBox> BGPaletteSelectors;
        private static int[] PageWidths { get; } = new int[] { 393, 504 };
        public frmPortraitEditor()
        {
            InitializeComponent();
            BaseName = Text;
        }

        private void frmPortraitEditor_Load(object sender, EventArgs e)
        {
            // Generate BGPaletteSelectors
            BGPaletteSelectors = new List<PictureBox>(4);
            for (int i = 0; i < 4; i++)
            {
                PictureBox box = new PictureBox();
                box.Location = new Point(73 + 36 * i, 71);
                box.Size = new Size(29, 20);
                box.BorderStyle = BorderStyle.Fixed3D;
                box.BackColor = Palette.BasePalette[i];
                if (i != 0)
                {
                    box.Click += Box_Click;
                }
                grpData.Controls.Add(box);
                BGPaletteSelectors.Add(box);
            }
            // Init animation pictureboxes
            picCharactersBG.Init(dlgOpen, this);
            picCharactersFG.Init(dlgOpen, this);
            picCharactersBG.PostOnClick = picCharactersFG.PostOnClick = UpdateCharacterPreview;
            picGenericsBG.Init(dlgOpen, this);
            picGenericsFG.Init(dlgOpen, this);
            picGenericsBG.PostOnClick = picGenericsFG.PostOnClick = UpdateGenericPreview;
            // Misc
            dlgOpen.Filter = "Image files|*.gif;*.png";
            trkFGPalette_Scroll(sender, e);
            // Init base
            lstCharacters.Init(this, () => new PortraitData(), CharacterDataFromUI, CharacterDataToUI, "Portraits");
            lstGenerics.Init(this, () => new GenericPortraitData(), GenericDataFromUI, GenericDataToUI, "GenericPortraits");
            Dirty = false;
            // Set dirty
            txtGenericsTags.TextChanged += DirtyFunc;
        }

        private void Box_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = dlgColorSelector.Dialog(this) ?? ((PictureBox)sender).BackColor;
            picCharactersBG.Palette = PaletteFromUI();
            UpdateCharacterPreview();
            Dirty = true;
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
            picGenericsBG.Palette = Palette.BasePalette; // TODO: Replace with a random palette from the available ones
            picGenericsFG.Palette = Palette.BaseSpritePalettes[new Random().Next(0, 4)]; // TODO: Better Random
        }

        private PortraitData CharacterDataFromUI(PortraitData data)
        {
            data.Name = txtCharactersName.Text;
            data.ForegroundColorID = trkCharactersFGPalette.Value;
            data.BackgroundColor = PaletteFromUI();
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
            for (int i = 0; i < 4; i++)
            {
                BGPaletteSelectors[i].BackColor = data.BackgroundColor[i];
            }
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

        private Palette PaletteFromUI()
        {
            return new Palette(BGPaletteSelectors.Select(a => a.BackColor).ToArray());
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
            if (tbcMain.SelectedIndex == 0)
            {
                lstCharacters.Remove();
            }
            else
            {
                lstGenerics.Remove();
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
            Cursor.Current = Cursors.Default;
        }

        protected override void ControlKeyAction(Keys key)
        {
            switch (key)
            {
                case Keys.S:
                    btnSave_Click(this, new EventArgs());
                    break;
                case Keys.N:
                    btnNew_Click(this, new EventArgs());
                    break;
                default:
                    break;
            }
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
