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
        private List<DrawingPalettePanel> PalettePanels = new List<DrawingPalettePanel>();
        private List<DrawingPanel> DrawingPanels = new List<DrawingPanel>();
        private Point PreviousMousePos = new Point(-1, -1);
        private SelectionClass Selection;

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
            // Generate side-bar controls
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
                PalettePanels.Add(palettePanel);
                pnlPalettes.Controls.Add(palettePanel);
                top += palettePanel.Height + 6;
            }
            // Init paint view
            pnlPaintScreenHolder.Size = resolution + new Size(2, 2);
            Panel prev = pnlPaintScreenHolder;
            for (int i = 0; i < Sources.Count; i++)
            {
                DrawingPanel panel = new DrawingPanel();
                panel.Left = panel.Top = i == 0 ? 1 : 0;
                panel.Width = pnlPaintScreenHolder.Width - 2;
                panel.Height = pnlPaintScreenHolder.Height - 2;
                panel.Anchor = (AnchorStyles)15;
                panel.BackColor = Color.Transparent;
                DrawingPanels.Add(panel);
                prev.Controls.Add(panel);
                prev = panel;
            }
            // Init misc
            Selection = new SelectionClass(PalettePanels);
        }

        public new DialogResult ShowDialog()
        {
            for (int i = 0; i < Sources.Count; i++)
            {
                if (Sources[i] is PalettedPicturebox palettedPicturebox)
                {
                    DrawingPanels[i].Image = palettedPicturebox.Image;
                    PalettePanels[i].Palette = palettedPicturebox.Palette;
                }
                else if (Sources[i] is PartialPalettedPicturebox partialPalettedPicturebox)
                {
                    DrawingPanels[i].Image = partialPalettedPicturebox.Image;
                    PalettePanels[i].Palette = partialPalettedPicturebox.Palette;
                }
            }
            return base.ShowDialog();
        }

        private void SetColor(int layer, int index)
        {
            Selection.Layer = layer;
            if (index >= 0)
            {
                Selection.Index = index;
            }
            else
            {
                DrawingPanels[layer].Image.CurrentPalette = PalettePanels[layer].Palette;
                DrawingPanels[layer].Update();
            }
        }

        private void frmPaint_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private class SelectionClass
        {
            private List<DrawingPalettePanel> PalettePanels = new List<DrawingPalettePanel>();

            private int layer = 0;
            public int Layer
            {
                get => layer;
                set
                {
                    PalettePanels[layer].Unselect();
                    layer = value;
                    PalettePanels[layer].Select();
                }
            }
            public int Index;

            public SelectionClass(List<DrawingPalettePanel> palettePanels) => PalettePanels = palettePanels;
        }

        private class DrawingPanel : Panel
        {
            private PalettedImage image;
            public PalettedImage Image
            {
                get => image;
                set
                {
                    BackgroundImage = (image = value)?.Target ?? null;
                }
            }

            public void Update()
            {
                BackgroundImage = Image.Target;
            }
        }

        private class DrawingPalettePanel : GroupBox
        {
            private static readonly Point TOP_LEFT_OFFSET = new Point(7, 20);
            private static readonly Point BOTTOM_RIGHT_OFFSET = new Point(200 - 187 - 7, 100 - 20 - 74);

            public Palette Palette
            {
                get => PalettePanel.Data;
                set
                {
                    if (Sprite)
                    {
                        PaletteSelector.Set(Math.Max(0, BaseSpritePalettes.FindIndex(a => a[1] == value[1])));
                    }
                    else
                    {
                        PalettePanel.Data = value;
                    }
                }
            }
            private bool Sprite;
            private List<Palette> BaseSpritePalettes;
            private SelectablePalettePanel PalettePanel;
            private ForegroundPaletteSelector PaletteSelector;

            public DrawingPalettePanel(bool sprite, int layer, Action<int, int> selectColor, List<Palette> baseSpritePalettes) : base()
            {
                BaseSpritePalettes = baseSpritePalettes;
                Text = "Layer " + (layer + 1);
                PalettePanel = new SelectablePalettePanel((i) => selectColor(layer, i), sprite);
                PalettePanel.Init(null, (p) => selectColor(layer, -1));
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
                            selectColor(layer, -1);
                        });
                    PaletteSelector.Location = TOP_LEFT_OFFSET;
                    PaletteSelector.Width = Width - TOP_LEFT_OFFSET.X - BOTTOM_RIGHT_OFFSET.X;
                    PaletteSelector.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                    Controls.Add(PaletteSelector);
                    PalettePanel.Top += PaletteSelector.Height + BOTTOM_RIGHT_OFFSET.Y;
                }
                Height = PalettePanel.Bottom + BOTTOM_RIGHT_OFFSET.Y;
            }

            public void Select() => Text = Text.Replace(" (Selected)", "");

            public void Unselect() => Text = Text.Replace(" (Selected)", "") + " (Selected)";

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
