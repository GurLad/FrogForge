using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge
{
    public partial class frmPortraitEditor : frmBaseEditor
    {
        private List<PictureBox> BGPaletteSelectors;
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
            picBG.Init(dlgOpen, this);
            picFG.Init(dlgOpen, this);
            picBG.PostOnClick = picFG.PostOnClick = UpdatePreview;
            // Misc
            dlgOpen.Filter = "Image files|*.gif;*.png";
            trkFGPalette_Scroll(sender, e);
            // Init base
            lstPortraits.Init(this, () => new PortraitData(), DataFromUI, DataToUI, "Portraits");
            Dirty = false;
        }

        private void Box_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = dlgColorSelector.Dialog(this) ?? ((PictureBox)sender).BackColor;
            picBG.Palette = PaletteFromUI();
            UpdatePreview();
            Dirty = true;
        }

        private void trkFGPalette_Scroll(object sender, EventArgs e)
        {
            picFGPalette.BackColor = Palette.BaseSpritePalettes[trkFGPalette.Value][1];
            picFG.Palette = Palette.BaseSpritePalettes[trkFGPalette.Value];
            UpdatePreview();
            Dirty = true;
        }

        private void UpdatePreview()
        {
            picPreview.Image = picFG.Image?.Target;
            picPreview.BackgroundImage = picBG.Image?.Target;
        }

        private PortraitData DataFromUI(PortraitData data)
        {
            data.Name = txtName.Text;
            data.ForegroundColorID = trkFGPalette.Value;
            data.BackgroundColor = PaletteFromUI();
            data.Background = picBG.Image;
            data.Foreground = picFG.Image;
            CurrentFile = data.Name;
            Dirty = false;
            return data;
        }

        private void DataToUI(PortraitData data)
        {
            txtName.Text = data.Name;
            trkFGPalette.Value = data.ForegroundColorID;
            for (int i = 0; i < 4; i++)
            {
                BGPaletteSelectors[i].BackColor = data.BackgroundColor[i];
            }
            WorkingDirectory.CreateDirectory(@"Images\Portraits\" + data.Name);
            picBG.Image = data.Background ?? new PalettedImage(WorkingDirectory.LoadImage(@"Portraits\" + data.Name + @"\B") ?? new Bitmap(1, 1));
            picBG.Palette = data.BackgroundColor;
            picFG.Image = data.Foreground ?? new PalettedImage(WorkingDirectory.LoadImage(@"Portraits\" + data.Name + @"\F") ?? new Bitmap(1, 1));
            picFG.Palette = Palette.BaseSpritePalettes[trkFGPalette.Value];
            UpdatePreview();
            CurrentFile = data.Name;
            Dirty = false;
        }

        private Palette PaletteFromUI()
        {
            return new Palette(BGPaletteSelectors.Select(a => a.BackColor).ToArray());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lstPortraits.Save(txtName.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lstPortraits.New();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstPortraits.Remove();
        }

        private void frmPortraitEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            // Save
            lstPortraits.SaveToFile();
            // Save images
            foreach (PortraitData item in lstPortraits.Data)
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
        }

        protected override void ControlKeyAction(Keys key)
        {
            switch (key)
            {
                case Keys.S:
                    btnSave_Click(this, new EventArgs());
                    break;
                case Keys.N:
                    lstPortraits.New();
                    break;
                default:
                    break;
            }
        }
    }
}
