using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge
{
    public partial class AnimationPicturebox : PictureBox
    {
        private frmBaseEditor Editor;
        private OpenFileDialog dlgOpen;
        private Timer tmrAnimate = new Timer();
        private int CurrentFrame;
        private PalettedImage image;
        public new PalettedImage Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                base.Image = image?.Target;
                tmrAnimate.Stop();
                CurrentFrame = 0;
            }
        }

        public void Init(OpenFileDialog dlgOpen, frmBaseEditor editor)
        {
            MouseUp += OnClick;
            this.dlgOpen = dlgOpen;
            Editor = editor;
            tmrAnimate.Interval = 400;
            tmrAnimate.Tick += tmrAnimateTick;
            SizeMode = PictureBoxSizeMode.Normal;
        }

        private void OnClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    // Create image
                    Image source = System.Drawing.Image.FromFile(dlgOpen.FileName);
                    FrameDimension dimension = new FrameDimension(source.FrameDimensionsList.First());
                    int frameCount = source.GetFrameCount(dimension);
                    Bitmap target = new Bitmap(source.Width * frameCount, source.Height);
                    Graphics graphics = Graphics.FromImage(target);
                    Rectangle cloneRect = new Rectangle(0, 0, source.Width, source.Height);
                    for (int i = 0; i < frameCount; i++)
                    {
                        cloneRect.Location = new Point(i * cloneRect.Width, 0);
                        source.SelectActiveFrame(dimension, i);
                        graphics.DrawImage(source, cloneRect);
                    }
                    // Color image
                    Image = new PalettedImage(target);
                    Image.CurrentPalette = null;
                    // Set dirty
                    Editor.Dirty = true;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (tmrAnimate.Enabled)
                {
                    tmrAnimate.Stop();
                }
                else
                {
                    if (Image == null)
                    {
                        return;
                    }
                    tmrAnimate.Start();
                    tmrAnimateTick(sender, e);
                }
            }
        }

        private void tmrAnimateTick(object sender, EventArgs e)
        {
            int height = Image.Target.Height;
            int width = height; // Assumes square graphics
            CurrentFrame++;
            CurrentFrame %= Image.Target.Width / width;
            Image target = new Bitmap(height, width);
            Graphics g = Graphics.FromImage(target);
            g.DrawImage(Image.Target, new PointF(-CurrentFrame * width, 0));
            base.Image = target;
        }
    }
}
