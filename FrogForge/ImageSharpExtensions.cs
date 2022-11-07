using System;
using System.IO;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Advanced;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.PixelFormats;

namespace FrogForge
{
    // From https://codeblog.vurdalakov.net/2019/06/imagesharp-convert-image-to-system-drawing-bitmap-and-back.html and https://stackoverflow.com/questions/71920487/how-convert-sixlabors-imagesharp-color-to-system-drawing-color
    public static class ImageSharpExtensions
    {
        public static System.Drawing.Bitmap ToBitmap<TPixel>(this Image<TPixel> image) where TPixel : unmanaged, IPixel<TPixel>
        {
            using (var memoryStream = new MemoryStream())
            {
                var imageEncoder = image.GetConfiguration().ImageFormatsManager.FindEncoder(PngFormat.Instance);
                image.Save(memoryStream, imageEncoder);

                memoryStream.Seek(0, SeekOrigin.Begin);

                return new System.Drawing.Bitmap(memoryStream);
            }
        }

        public static Image<TPixel> ToImageSharpImage<TPixel>(this System.Drawing.Bitmap bitmap) where TPixel : unmanaged, IPixel<TPixel>
        {
            using (var memoryStream = new MemoryStream())
            {
                bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

                memoryStream.Seek(0, SeekOrigin.Begin);

                return Image.Load<TPixel>(memoryStream);
            }
        }

        public static System.Drawing.Color ToSystemDrawingColor(this SixLabors.ImageSharp.Color c)
        {
            var converted = c.ToPixel<Argb32>();
            return System.Drawing.Color.FromArgb((int)converted.Argb);
        }

        public static System.Drawing.Color ToSystemDrawingColor(this SixLabors.ImageSharp.PixelFormats.Rgba32 rgba32)
        {
            return System.Drawing.Color.FromArgb(rgba32.A, rgba32.R, rgba32.G, rgba32.B);
        }

        public static SixLabors.ImageSharp.Color ToImageSharpColor(this System.Drawing.Color c)
        {
            return SixLabors.ImageSharp.Color.FromRgba(c.R, c.G, c.B, c.A);
        }
    }
}
