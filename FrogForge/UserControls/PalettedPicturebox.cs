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
        // Paint vars
        public List<PictureBox> Sources = null;
        public bool Animated;
        public bool Sprite => PalettePanel?.SpritePalette ?? false;
        // Everything else
        public Action PostOnClick;
        protected PalettePanel PalettePanel;
        private frmBaseEditor Editor;
        private OpenFileDialog dlgOpen;
        private frmPaint dlgPaint;
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

        public void Init(OpenFileDialog dlgOpen, frmBaseEditor editor, bool animated, PalettePanel palettePanel = null, Action postOnClick = null, List<PictureBox> sources = null)
        {
            MouseUp += OnClick;
            this.dlgOpen = dlgOpen;
            Editor = editor;
            Animated = animated;
            PalettePanel = palettePanel;
            PostOnClick = postOnClick;
            Sources = sources;
            tmrAnimate.Interval = 400;
            tmrAnimate.Tick += tmrAnimateTick;
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
            // Init dlgPaint
            if (Preferences.Current.UseBuiltInPaint)
            {
                dlgPaint = new frmPaint();
                dlgPaint.Init(new Size(Width, Height), Sources ?? new List<PictureBox>() { this }, Animated,
                    Palette.GetBaseSpritePalettes(editor.WorkingDirectory));
            }
        }

        private void OnClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Preferences.Current.UseBuiltInPaint)
                {
                    if (dlgPaint.ShowDialog() == DialogResult.OK)
                    {
                        List<Image> result = dlgPaint.Result;
                        List<PictureBox> sources = Sources ?? new List<PictureBox>() { this };
                        for (int i = 0; i < sources.Count; i++)
                        {
                            if (sources[i] is PalettedPicturebox palettedPicturebox)
                            {
                                palettedPicturebox.Image = new PalettedImage(result[i]);
                            }
                            else if (sources[i] is PartialPalettedPicturebox partialPalettedPicturebox)
                            {
                                partialPalettedPicturebox.Image = new PartialPalettedImage(result[i]);
                            }
                        }
                    }
                }
                else
                {
                    if (dlgOpen.ShowDialog() == DialogResult.OK)
                    {
                        // Create image
                        Image source = System.Drawing.Image.FromFile(dlgOpen.FileName).SplitGIF();
                        // Verify size
                        if (source.Height != ImageHeight || (source.Width % ImageWidth != 0))
                        {
                            if (ExtensionMethods.ConfirmDialog("Wrong image size (should be " + ImageWidth + "x" + ImageHeight + ", got " + source.Width + "x" + source.Height + " instead). Continue anyway?", "Warning"))
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
            }
            else if (e.Button == MouseButtons.Right && Animated)
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
            if (Preferences.Current.AutoPaletteImageImports)
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
            if (Preferences.Current.AutoPaletteImageImports)
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
