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
        public List<BasePalettedPicturebox> Sources { private get; set; }
        public bool Animated { private get; set; }
        private List<Palette> BaseSpritePalettes;
        private List<DrawingPalettePanel> palettePanels = new List<DrawingPalettePanel>();

        public frmPaint()
        {
            InitializeComponent();
        }

        public void Init(Size resolution, List<BasePalettedPicturebox> sources, bool animated, List<Palette> baseSpritePalettes)
        {
            Resolution = resolution;
            Sources = sources;
            Animated = animated;
            BaseSpritePalettes = baseSpritePalettes;
            // Generate controls
            int top = 0;
            for (int i = 0; i < Sources.Count; i++)
            {
                DrawingPalettePanel palettePanel = null;
                if (Sources[i] is PalettedPicturebox palettedPicturebox)
                {
                    palettePanel = new DrawingPalettePanel(palettedPicturebox.Sprite, i, SetColor, BaseSpritePalettes);
                }
                else if (Sources[i] is PartialPalettedPicturebox partialPalettedPicturebox)
                {
                    palettePanel = new DrawingPalettePanel(partialPalettedPicturebox.Sprite, i, SetColor, BaseSpritePalettes);
                }
                else
                {
                    throw new Exception("Impossible!");
                }
                palettePanel.Width = pnlPalettes.Width;
                palettePanel.Top = top;
                palettePanels.Add(palettePanel);
                pnlPalettes.Controls.Add(palettePanel);
                top += palettePanel.Height + 6;
            }
        }

        public new DialogResult ShowDialog()
        {
            for (int i = 0; i < Sources.Count; i++)
            {
                if (Sources[i] is PalettedPicturebox palettedPicturebox)
                {
                    palettePanels[i].SetPalette(palettedPicturebox.Palette);
                }
                else if (Sources[i] is PartialPalettedPicturebox partialPalettedPicturebox)
                {
                    palettePanels[i].SetPalette(partialPalettedPicturebox.Palette);
                }
            }
            return base.ShowDialog();
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
            private bool Sprite;
            private List<Palette> BaseSpritePalettes;
            private SelectablePalettePanel PalettePanel;
            private ForegroundPaletteSelector PaletteSelector;

            public DrawingPalettePanel(bool sprite, int id, Action<int, int> selectColor, List<Palette> baseSpritePalettes) : base()
            {
                BaseSpritePalettes = baseSpritePalettes;
                Text = "Layer " + (id + 1);
                PalettePanel = new SelectablePalettePanel((i) => selectColor(id, i), sprite);
                PalettePanel.Init(null, (p) => selectColor(id, -1));
                PalettePanel.Location = TOP_LEFT_OFFSET;
                PalettePanel.Width = Width - TOP_LEFT_OFFSET.X - BOTTOM_RIGHT_OFFSET.X;
                PalettePanel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                Controls.Add(PalettePanel);
                if (Sprite = sprite)
                {
                    PaletteSelector = new ForegroundPaletteSelector();
                    PaletteSelector.Init(null, baseSpritePalettes, (p) =>
                        {
                            PalettePanel.Data = p;
                            selectColor(id, -1);
                        });
                    PaletteSelector.Location = TOP_LEFT_OFFSET;
                    PaletteSelector.Width = Width - TOP_LEFT_OFFSET.X - BOTTOM_RIGHT_OFFSET.X;
                    PaletteSelector.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                    Controls.Add(PaletteSelector);
                    PalettePanel.Top += PaletteSelector.Height + BOTTOM_RIGHT_OFFSET.Y;
                }
                Height = PalettePanel.Bottom + BOTTOM_RIGHT_OFFSET.Y;
            }

            public void SetPalette(Palette palette)
            {
                if (Sprite)
                {
                    PaletteSelector.Set(Math.Max(0, BaseSpritePalettes.FindIndex(a => a[1] == palette[1])));
                }
                else
                {
                    PalettePanel.Data = palette;
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
