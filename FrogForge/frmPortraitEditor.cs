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
        private PictureBox[] BGPaletteSelectors;
        public frmPortraitEditor()
        {
            InitializeComponent();
        }

        private void frmPortraitEditor_Load(object sender, EventArgs e)
        {
            // Generate BGPaletteSelectors
            BGPaletteSelectors = new PictureBox[4];
            for (int i = 0; i < BGPaletteSelectors.Length; i++)
            {
                PictureBox box = BGPaletteSelectors[i] = new PictureBox();
                box.Location = new Point(73 + 36 * i, 71);
                box.Size = new Size(29, 20);
                box.BorderStyle = BorderStyle.Fixed3D;
                box.BackColor = Palette.BasePalette[i];
                if (i != 0)
                {
                    box.Click += Box_Click;
                }
                grpData.Controls.Add(box);
            }
            // Init animation pictureboxes
            picBG.Init(dlgOpen, this);
            picFG.Init(dlgOpen, this);
            picBG.PostOnClick = picFG.PostOnClick = UpdatePreview;
            // Misc
            trkFGPalette_Scroll(sender, e);
        }

        private void Box_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
