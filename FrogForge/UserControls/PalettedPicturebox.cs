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
    public partial class BasePalettedPicturebox<T> : PictureBox where T : PalettedImage
    {
        public Action PostOnClick;
        protected PalettePanel PalettePanel;
        private frmBaseEditor Editor;
        private OpenFileDialog dlgOpen;
        private Timer tmrAnimate = new Timer();
        private int CurrentFrame;
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
        private T image;
        public new T Image
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
                this.FixZoom();
            }
        }
        private int ImageWidth { get; set; }
        private int ImageHeight { get; set; }

        public void Init(OpenFileDialog dlgOpen, frmBaseEditor editor, PalettePanel palettePanel = null, Action postOnClick = null)
        {
            MouseUp += OnClick;
            this.dlgOpen = dlgOpen;
            Editor = editor;
            PalettePanel = palettePanel;
            tmrAnimate.Interval = 400;
            tmrAnimate.Tick += tmrAnimateTick;
            PostOnClick = postOnClick;
            SizeMode = PictureBoxSizeMode.Normal;
            switch (BorderStyle)
            {
                case BorderStyle.None:
                    ImageWidth = Width;
                    ImageHeight = Height;
                    break;
                case BorderStyle.FixedSingle:
                    ImageWidth = Width - 2;
                    ImageHeight = Height - 2;
                    break;
                case BorderStyle.Fixed3D:
                    ImageWidth = Width - 4;
                    ImageHeight = Height - 4;
                    break;
                default:
                    throw new Exception("What?");
            }
        }

        private void OnClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    // Create image
                    Image source = System.Drawing.Image.FromFile(dlgOpen.FileName).SplitGIF();
                    // Verify size
                    if (source.Height != ImageHeight || (source.Width % ImageWidth != 0))
                    {
                        if (ExtensionMethods.ConfirmDialog("Wrong image size (should be " +ImageWidth + "x" + ImageHeight + ", got " + source.Width + "x" + source.Height + " instead). Continue anyway?", "Warning"))
                        {
                            source = source.Resize(ImageWidth, ImageHeight);
                        }
                        else
                        {
                            return;
                        }
                    }
                    // Color image
                    Image = NewT(source);
                    Image.CurrentPalette = Palette;
                    Image = Image;
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
            int width;
            switch (BorderStyle)
            {
                case BorderStyle.None:
                    width = Width;
                    break;
                case BorderStyle.FixedSingle:
                    width = Width - 2;
                    break;
                case BorderStyle.Fixed3D:
                    width = Width - 4;
                    break;
                default:
                    throw new Exception("What?");
            }
            width = (int)(width / Preferences.Current.ZoomAmount);
            CurrentFrame++;
            CurrentFrame %= Image.Target.Width / width;
            Image target = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(target);
            g.DrawImage(Image.Target, new PointF(-CurrentFrame * width, 0));
            g.Dispose();
            base.Image = target;
            this.FixZoom();
        }

        protected virtual T NewT(Image source)
        {
            throw new Exception("Not implemented!");
        }
    }

    public partial class PalettedPicturebox : BasePalettedPicturebox<PalettedImage>
    {
        protected override PalettedImage NewT(Image source)
        {
            if (Preferences.Current.AutoPaletteImageImports && PalettePanel != null)
            {
                return PalettedImage.AutoPalette(new Bitmap(source), PalettePanel);
            }
            else
            {
                return new PalettedImage(source);
            }
        }
    }

    public partial class PartialPalettedPicturebox : BasePalettedPicturebox<PartialPalettedImage>
    {
        protected override PartialPalettedImage NewT(Image source)
        {
            if (Preferences.Current.AutoPaletteImageImports && PalettePanel != null)
            {
                return PartialPalettedImage.AutoPalette(new Bitmap(source), PalettePanel);
            }
            else
            {
                return new PartialPalettedImage(source);
            }
        }
    }
}
