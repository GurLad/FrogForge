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

namespace FrogForge.Editors
{
    public partial class frmPaint : Form
    {
        public List<Image> Result => new List<Image>() { pnlPaintScreenHolder.BackgroundImage };
        public Size Resolution { private get; set; }
        public List<PictureBox> Sources { private get; set; }
        public bool Animated { private get; set; }
        private List<Palette> BaseSpritePalettes;

        public frmPaint()
        {
            InitializeComponent();
        }

        public void Init(Size resolution, List<PictureBox> sources, bool animated, List<Palette> baseSpritePalettes)
        {
            Resolution = resolution;
            Sources = sources;
            Animated = animated;
            BaseSpritePalettes = baseSpritePalettes;
            // Generate controls
            for (int i = 0; i < Sources.Count; i++)
            {
                DrawingPalettePanel palettePanel;
                if (Sources[i] is PalettedPicturebox palettedPicturebox)
                {
                    palettePanel = new DrawingPalettePanel(palettedPicturebox.Sprite, i, SetColor, BaseSpritePalettes);
                }
                else if (Sources[i] is PartialPalettedPicturebox partialPalettedPicturebox)
                {
                    palettePanel = new DrawingPalettePanel(partialPalettedPicturebox.Sprite, i, SetColor, BaseSpritePalettes);
                }
            }
        }

        private void SetColor(int id, int index)
        {
            if (index >= 0)
            {
                // TBA: Select it...
            }
            else
            {
                // TBA: Update matching layer 
            }
        }

        private void frmPaint_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private class DrawingPalettePanel : GroupBox
        {
            private static readonly Point TOP_LEFT_OFFSET = new Point(7, 20);
            private static readonly Point BOTTOM_RIGHT_OFFSET = new Point(200 - 187 - 7, 100 - 20 - 74);

            public DrawingPalettePanel(bool sprite, int id, Action<int, int> selectColor, List<Palette> baseSpritePalettes) : base()
            {
                Text = "Layer " + (id + 1);
                SelectablePalettePanel palettePanel = new SelectablePalettePanel((i) => selectColor(id, i), sprite);
                palettePanel.Init(null, (p) => selectColor(id, -1));
                palettePanel.Location = TOP_LEFT_OFFSET;
                palettePanel.Width = Width - TOP_LEFT_OFFSET.X - BOTTOM_RIGHT_OFFSET.X;
                palettePanel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                if (sprite)
                {
                    ForegroundPaletteSelector paletteSelector = new ForegroundPaletteSelector();
                    paletteSelector.Init(null, baseSpritePalettes, (p) =>
                        {
                            palettePanel.Data = p;
                            selectColor(id, -1);
                        });
                    paletteSelector.Location = TOP_LEFT_OFFSET;
                    paletteSelector.Width = Width - TOP_LEFT_OFFSET.X - BOTTOM_RIGHT_OFFSET.X;
                    paletteSelector.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                    palettePanel.Top += paletteSelector.Height;
                }
            }

            private class SelectablePalettePanel : PalettePanel
            {
                private Action<int> SelectColor;
                private bool LockColors;

                public SelectablePalettePanel(Action<int> selectColor, bool lockColors)
                {
                    SelectColor = selectColor;
                    LockColors = lockColors;
                }

                protected override void Box_Click(object sender, EventArgs e)
                {
                    if (e is MouseEventArgs mouseArgs)
                    {
                        if (mouseArgs.Button == MouseButtons.Right && !LockColors)
                        {
                            base.Box_Click(sender, e);
                        }
                        else if (mouseArgs.Button == MouseButtons.Left)
                        {
                            SelectColor((int)((PictureBox)sender).Tag);
                        }
                    }
                }
            }
        }
    }
}
