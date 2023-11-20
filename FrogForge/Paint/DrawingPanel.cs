using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge.Paint
{
    public class DrawingPanel : Panel
    {
        private Image sourceImage;
        private PalettedImage image;
        public PalettedImage Image
        {
            get => image;
            set
            {
                sourceImage = (image = value)?.Target ?? null;
            }
        }

        public DrawingPanel() : base()
        {
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs paintEventArgs)
        {
            Graphics g = paintEventArgs.Graphics;
            g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.SmoothingMode = SmoothingMode.None;
            g.PixelOffsetMode = PixelOffsetMode.Half;
            //g.Clear(Color.Transparent);
            g.DrawImage(sourceImage, 0, 0, Size.Width, Size.Height);
        }

        public void Render()
        {
            Invalidate();
        }
    }
}
