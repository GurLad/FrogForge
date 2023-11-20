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
    public abstract partial class BasePalettedPicturebox : PictureBox
    {
        // Paint vars
        public List<BasePalettedPicturebox> Sources = null;
        public bool Animated;
        public virtual bool Sprite => false;
        // Everything else
        public Action PostOnClick;
        protected OpenFileDialog dlgOpen;
        protected Paint.frmPaint dlgPaint;
        protected frmBaseEditor Editor;
        protected int ImageWidth { get; set; }
        protected int ImageHeight { get; set; }

        protected void Init(OpenFileDialog dlgOpen, frmBaseEditor editor, Action postOnClick = null)
        {
            MouseUp += OnClick;
            this.dlgOpen = dlgOpen;
            Editor = editor;
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
                if (Preferences.Current.UseBuiltInPaint)
                {
                    if (ShowPaintDialogue())
                    {
                        PostOnClick?.Invoke();
                    }
                }
                else
                {
                    if (ShowFileDialogue())
                    {
                        PostOnClick?.Invoke();
                    }
                }
            }
            else if (e.Button == MouseButtons.Right && Animated)
            {
                RightClickAction();
            }
        }

        protected bool ShowPaintDialogue()
        {
            if (dlgPaint.ShowDialog() == DialogResult.OK)
            {
                List<Image> result = dlgPaint.Result;
                List<BasePalettedPicturebox> sources = Sources ?? new List<BasePalettedPicturebox>() { this };
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
                    else
                    {
                        throw new Exception("Impossible!");
                    }
                }
                return true;
            }
            return false;
        }

        protected abstract bool ShowFileDialogue();

        protected abstract void RightClickAction();
    }

    public partial class BaseSinglePalettedPicturebox<T> : BasePalettedPicturebox where T : PalettedImage
    {
        public override bool Sprite => PalettePanel?.SpritePalette ?? true;
        // Everything else
        protected PalettePanel PalettePanel;
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

        public void Init(OpenFileDialog dlgOpen, frmBaseEditor editor, bool animated, PalettePanel palettePanel = null, Action postOnClick = null)
        {
            Init(dlgOpen, editor, postOnClick);
            Animated = animated;
            PalettePanel = palettePanel;
            PostOnClick = postOnClick;
            tmrAnimate.Interval = 400;
            tmrAnimate.Tick += tmrAnimateTick;
            // Init dlgPaint
            if (Preferences.Current.UseBuiltInPaint)
            {
                dlgPaint = new Paint.frmPaint();
                dlgPaint.Init(new Size(ImageWidth, ImageHeight), new List<BasePalettedPicturebox>() { this }, Animated,
                    Palette.GetBaseSpritePalettes(editor.WorkingDirectory));
            }
        }

        protected override bool ShowFileDialogue()
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
                        return false;
                    }
                }
                // Color image
                Image = NewT(source);
                Image.CurrentPalette = Palette;
                Image = Image;
                // Set dirty
                Editor.Dirty = true;
                return true;
            }
            return false;
        }

        protected override void RightClickAction()
        {
            if (Animated)
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
                    tmrAnimateTick(null, null);
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

    public partial class PalettedPicturebox : BaseSinglePalettedPicturebox<PalettedImage>
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

    public partial class PartialPalettedPicturebox : BaseSinglePalettedPicturebox<PartialPalettedImage>
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

    public partial class MultiPalettedPicturebox : BasePalettedPicturebox
    {
        public void Init(OpenFileDialog dlgOpen, frmBaseEditor editor, List<BasePalettedPicturebox> sources, Action postOnClick = null)
        {
            Init(dlgOpen, editor, postOnClick);
            Sources = sources;
            // Init dlgPaint
            if (Preferences.Current.UseBuiltInPaint)
            {
                dlgPaint = new Paint.frmPaint();
                dlgPaint.Init(new Size(ImageWidth, ImageHeight), Sources, Animated,
                    Palette.GetBaseSpritePalettes(editor.WorkingDirectory));
            }
        }

        protected override void RightClickAction()
        {
            // TBA: Multi-paletted animation support
        }

        protected override bool ShowFileDialogue()
        {
            // TBA: Multi from file support
            return false;
        }
    }
}
