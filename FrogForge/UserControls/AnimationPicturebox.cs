using FrogForge.Editors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge.UserControls
{
    public partial class AnimationPicturebox : PictureBox
    {
        private frmBaseEditor Editor;
        private OpenFileDialog dlgOpen;
        private Timer tmrAnimate = new Timer();
        private int CurrentFrame;
        public Action PostOnClick;
        private Palette palette;
        public Palette Palette
        {
            get
            {
                return palette ?? Palette.BasePalette;
            }
            set
            {
                palette = value;
                if (Image != null)
                {
                    Image.CurrentPalette = Palette;
                    Image = Image;
                }
            }
        }
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
                    Image source = System.Drawing.Image.FromFile(dlgOpen.FileName).SplitGIF();
                    // Color image
                    Image = new PalettedImage(source);
                    Image.CurrentPalette = Palette;
                    // Set dirty
                    Editor.Dirty = true;
                    PostOnClick?.Invoke();
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
