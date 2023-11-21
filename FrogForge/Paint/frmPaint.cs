using FrogForge.Paint.DrawingTools;
using FrogForge.Paint.DrawingToolstripItems;
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

namespace FrogForge.Paint
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
        private DTIDrawingTool SelectedTool;
        private int _zoomAmount = 1;
        private int ZoomAmount
        {
            get => _zoomAmount;
            set
            {
                _zoomAmount = value.Clamp(1, 8);
                this.BeginControlUpdate();
                pnlPaintScreenHolder.Size = ZoomedResolution + new Size(2, 2);
                pnlPaintScreenHolder.Location = new Point(
                    (pnlPaintViewport.Width - pnlPaintScreenHolder.Width) / 2,
                    (pnlPaintViewport.Height - pnlPaintScreenHolder.Height) / 2);
                DrawingPanels.ForEach(a => a.Size = pnlPaintScreenHolder.Size - new Size(2, 2));
                this.EndControlUpdate();
            }
        }
        private Size ZoomedResolution => new Size(Resolution.Width * ZoomAmount, Resolution.Height * ZoomAmount);

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
            // Generate drawint tool bar controls
            List<ADrawingToolstripItem> drawingToolstripItems = new List<ADrawingToolstripItem>()
            {
                new DTIDrawingTool(SetDrawingTool, "Pencil", Properties.Resources.Palette, new DTPencil()),
                new DTIDrawingTool(SetDrawingTool, "Fill", Properties.Resources.Palette, new DTFill()),
            };
            drawingToolstripItems.ForEach(a => tlsDrawingToolstrip.Items.Add(a.Control));
            // Select the first one (pencil probably)
            SetDrawingTool((DTIDrawingTool)drawingToolstripItems.Find(a => a is DTIDrawingTool));
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
                panel.BackgroundImageLayout = ImageLayout.Zoom;
                panel.MouseDown += DrawingPanelMouseDown;
                panel.MouseMove += DrawingPanelMouseMove;
                panel.MouseUp += DrawingPanelMouseUp;
                DrawingPanels.Add(panel);
                prev.Controls.Add(panel);
                prev = panel;
            }
            // Init misc
            Selection = new SelectionClass(PalettePanels);
            MouseWheel += frmPaint_MouseWheel;
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
            Selection.Layer = 0;
            ZoomAmount = (int)Preferences.Current.ZoomAmount;
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
                DrawingPanels[layer].Render();
            }
        }

        private void SetDrawingTool(DTIDrawingTool drawingTool)
        {
            if (SelectedTool != null)
            {
                SelectedTool.Button.Checked = false;
            }
            SelectedTool = drawingTool;
            SelectedTool.Button.Checked = true;
        }

        private void frmPaint_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void frmPaint_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                ZoomAmount += Math.Sign(e.Delta);
            }
        }

        private void DrawingPanelMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = ConvertedMousePos(Cursor.Position);
                SelectedTool.Tool.Press(DrawingPanels[Selection.Layer], Selection.Index, mousePos);
                PreviousMousePos = mousePos;
            }
        }

        private void DrawingPanelMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = ConvertedMousePos(Cursor.Position);
                SelectedTool.Tool.Move(DrawingPanels[Selection.Layer], Selection.Index, mousePos, PreviousMousePos);
                PreviousMousePos = mousePos;
            }
        }

        private void DrawingPanelMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = ConvertedMousePos(Cursor.Position);
                SelectedTool.Tool.Release(DrawingPanels[Selection.Layer], Selection.Index, mousePos);
                PreviousMousePos = mousePos;
            }
        }

        private Point ConvertedMousePos(Point cursorPos)
        {
            cursorPos = DrawingPanels[Selection.Layer].PointToClient(cursorPos);
            return new Point((cursorPos.X / ZoomAmount), (cursorPos.Y / ZoomAmount));
        }

        private void frmPaint_SizeChanged(object sender, EventArgs e)
        {
            ZoomAmount = ZoomAmount;
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
    }
}
