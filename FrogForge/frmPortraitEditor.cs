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
        }

        private void Box_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = dlgColorSelector.Dialog(this) ?? ((PictureBox)sender).BackColor;
            picBG.Palette = new Palette(BGPaletteSelectors.Select(a => a.BackColor).ToArray());
            UpdatePreview();
        }

        private void trkFGPalette_Scroll(object sender, EventArgs e)
        {
            picFGPalette.BackColor = Palette.BaseFGPalettes[trkFGPalette.Value][1];
            picFG.Palette = Palette.BaseFGPalettes[trkFGPalette.Value];
            UpdatePreview();
        }

        private void UpdatePreview()
        {
            picPreview.Image = picFG.Image?.Target;
            picPreview.BackgroundImage = picBG.Image?.Target;
        }
    }
}
