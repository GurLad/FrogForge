using FrogForge.Editors;
using FrogForge.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace FrogForge
{
    public static class ExtensionMethods
    {
        public static string ToJson<T>(this T obj)
        {
            return JsonSerializer.Serialize(obj, typeof(T));
        }

        public static T JsonToObject<T>(this string jsonContent)
        {
            return (T)JsonSerializer.Deserialize(jsonContent, typeof(T));
        }

        public static bool DirectoryExists(this FilesController files, string name)
        {
            return System.IO.Directory.Exists(files.Path + name);
        }

        public static void DeleteDirectory(this FilesController files, string toDelete, bool recursive = true)
        {
            System.IO.Directory.Delete(files.Path + toDelete, recursive);
        }

        public static Image SplitGIF(this Image source)
        {
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
            graphics.Dispose();
            return target;
        }

        public static void ApplyPreferences(this Control control, bool zoom = true)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            {
                return;
            }
            void ApplyDarkMode(Control caller)
            {
                if (caller is PalettePanel || caller is GrowthsPanel || caller is ConversationPlayer)
                {
                    return;
                }
                caller.BackColor = Preferences.Current.DarkModeBackColor;
                caller.ForeColor = Color.White;
                if (caller is Button)
                {
                    ((Button)caller).FlatStyle = FlatStyle.Flat;
                    ((Button)caller).FlatAppearance.MouseOverBackColor = Color.DarkGray;
                }
                else if (caller is ComboBox)
                {
                    ((ComboBox)caller).FlatStyle = FlatStyle.Flat;
                }
                else if (caller is TextBox)
                {
                    ((TextBox)caller).BorderStyle = BorderStyle.FixedSingle;
                }
                else if (caller is ListBox)
                {
                    ((ListBox)caller).BorderStyle = BorderStyle.FixedSingle;
                }
                else if (caller is NumericUpDown)
                {
                    ((NumericUpDown)caller).BorderStyle = BorderStyle.FixedSingle;
                }
                else if (caller is PictureBox)
                {
                    ((PictureBox)caller).BackColor = Color.FromArgb(60, 60, 60);
                }
                foreach (Control otherControl in caller.Controls)
                {
                    ApplyDarkMode(otherControl);
                }
            }
            void ApplyZoomMode(Control caller)
            {
                if (caller is PalettePanel)
                {
                    ((PalettePanel)caller).ApplyZoomMode();
                    return;
                }
                else if (caller is EventTextBox)
                {
                    return;
                }
                else if (caller is TeamPanel)
                {
                    foreach (Control item in caller.Controls)
                    {
                        item.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    }
                    caller.Left = (int)Math.Round(caller.Left / Preferences.Current.ZoomAmount);
                    caller.Width = (int)Math.Round(caller.Width / Preferences.Current.ZoomAmount);
                }
                else if (caller is PictureBox)
                {
                    ((PictureBox)caller).FixZoom();
                }
                foreach (Control otherControl in caller.Controls)
                {
                    ApplyZoomMode(otherControl);
                }
            }
            void ApplyFont(Control caller)
            {
                if (caller is Label || caller is TextBox || caller is ComboBox || caller is CheckBox || caller is ListBox)
                {
                    control.Font = new Font(Preferences.Current.FontFamily, control.Font.Size, control.Font.Style);
                }
                foreach (Control otherControl in caller.Controls)
                {
                    ApplyFont(otherControl);
                }
            }

            if (Preferences.Current.DarkMode)
            {
                ApplyDarkMode(control);
            }
            if (Preferences.Current.ZoomAmount > 1 && zoom)
            {
                control.Font = new Font(control.Font.FontFamily, (int)Math.Round(control.Font.Size * Preferences.Current.ZoomAmount), control.Font.Style);
                foreach (Control otherControl in control.Controls)
                {
                    ApplyZoomMode(otherControl);
                }
                if (control is frmBaseEditor)
                {
                    ((frmBaseEditor)control).RecenterForm();
                }
                else if (control is PalettePanel)
                {
                    ((PalettePanel)control).ApplyZoomMode();
                }
            }
            foreach (Control otherControl in control.Controls)
            {
                ApplyFont(otherControl);
            }
        }

        public static void ResizeByZoom(this Control control, bool pos = true, bool x = true, bool y = true)
        {
            if (x)
            {
                control.Width = (int)Math.Round(control.Width * Preferences.Current.ZoomAmount);
            }
            if (y)
            {
                control.Height = (int)Math.Round(control.Height * Preferences.Current.ZoomAmount);
            }
            if (pos)
            {
                if (x)
                {
                    control.Left = (int)Math.Round(control.Left * Preferences.Current.ZoomAmount);
                }
                if (y)
                {
                    control.Top = (int)Math.Round(control.Top * Preferences.Current.ZoomAmount);
                }
            }
        }

        public static void FixZoom(this PictureBox pictureBox, bool foreground = true, bool background = true)
        {
            if (Preferences.Current.ZoomAmount > 1)
            {
                if (pictureBox.Image != null && foreground)
                {
                    Bitmap origin = new Bitmap(pictureBox.Image);
                    double mod = Preferences.Current.ZoomAmount;
                    Bitmap resized = origin.Resize(mod);
                    pictureBox.Image = resized;
                    if (pictureBox.BorderStyle == BorderStyle.Fixed3D)
                    {
                        // Fix weird picturebox size bug
                        pictureBox.Height = resized.Height + 4;
                    }
                }
                if (pictureBox.BackgroundImage != null && background)
                {
                    Bitmap origin = new Bitmap(pictureBox.BackgroundImage);
                    double mod = Preferences.Current.ZoomAmount;
                    Bitmap resized = origin.Resize(mod);
                    pictureBox.BackgroundImage = resized;
                    if (pictureBox.BorderStyle == BorderStyle.Fixed3D)
                    {
                        // Fix weird picturebox size bug
                        pictureBox.Height = resized.Height + (pictureBox.Width - resized.Width);
                    }
                }
            }
        }

        // Modified from https://stackoverflow.com/questions/1922040/how-to-resize-an-image-c-sharp
        public static Bitmap Resize(this Image image, double mod)
        {
            return image.Resize((int)Math.Round(image.Width * mod), (int)Math.Round(image.Height * mod), Math.Floor(mod) == mod);
        }

        public static Bitmap Resize(this Image image, int width, int height, bool nearestPixel = false)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = nearestPixel ? InterpolationMode.NearestNeighbor : InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public static Color Invert(this Color color)
        {
            return Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
        }

        public static int ClosestColorIndex(this Color origin, List<Color> options)
        {
            int ColorDiff(Color c1, Color c2)
            {
                return (int)Math.Sqrt((c1.R - c2.R) * (c1.R - c2.R)
                                       + (c1.G - c2.G) * (c1.G - c2.G)
                                       + (c1.B - c2.B) * (c1.B - c2.B));
            }

            var colorDiffs = options.Select(n => ColorDiff(n, origin)).Min(n => n);
            return options.FindIndex(n => ColorDiff(n, origin) == colorDiffs);
        }

        public static bool ConfirmDialog(string text, string title)
        {
            VoiceAssist.Say("Confirm");
            return MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }
    }
}
