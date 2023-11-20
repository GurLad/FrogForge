using FrogForge.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace FrogForge.Paint
{
    public class DrawingPalettePanel : GroupBox
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
            Click += (sender, e) => selectColor(layer, -1);
            PalettePanel = new SelectablePalettePanel((i) => selectColor(layer, i), sprite);
            PalettePanel.Init(null, (p) => selectColor(layer, -1));
            PalettePanel.Location = TOP_LEFT_OFFSET;
            PalettePanel.Width = Width - TOP_LEFT_OFFSET.X - BOTTOM_RIGHT_OFFSET.X;
            PalettePanel.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            Controls.Add(PalettePanel);
            if (Sprite = sprite)
            {
                PaletteSelector = new ForegroundPaletteSelector();
                PaletteSelector.Init(null, baseSpritePalettes, (p) => PalettePanel.Data = p);
                PaletteSelector.Location = TOP_LEFT_OFFSET;
                PaletteSelector.Width = Width - TOP_LEFT_OFFSET.X - BOTTOM_RIGHT_OFFSET.X;
                PaletteSelector.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                Controls.Add(PaletteSelector);
                PalettePanel.Top += PaletteSelector.Height + BOTTOM_RIGHT_OFFSET.Y;
            }
            Height = PalettePanel.Bottom + BOTTOM_RIGHT_OFFSET.Y;
        }

        public void Select() => Text = Text.Replace(" (Selected)", "") + " (Selected)";

        public void Unselect() => Text = Text.Replace(" (Selected)", "");

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
