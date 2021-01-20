﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge
{
    public class PalettedImage
    {
        public Bitmap Target { get; private set; }
        private List<Color> SourceColors = new List<Color>(new Color[]
        {
            ColorTranslator.FromHtml("#FF000000"),
            ColorTranslator.FromHtml("#FFFFFFFF"),
            ColorTranslator.FromHtml("#FFBCC0C4"),
            ColorTranslator.FromHtml("#FF788084")
        });
        private int[,] Indexes;

        public PalettedImage(Image target) : this(new Bitmap(target)) {}

        public PalettedImage(Bitmap target)
        {
            Target = target;
            Indexes = new int[Target.Size.Width, Target.Size.Height];
            // TBA: Replace with something more efficient
            for (int i = 0; i < Target.Width; i++)
            {
                for (int j = 0; j < Target.Height; j++)
                {
                    Color color = Target.GetPixel(i, j);
                    Indexes[i, j] = color.A == 0 ? 3 : ClosestColor(SourceColors, color);
                }
            }
        }

        public void SetPalette(List<Color> palette = null)
        {
            palette = palette ?? SourceColors;
            if (palette.Count != 4)
            {
                throw new Exception("Palette must have exactly 4 colors!");
            }
            for (int i = 0; i < Target.Width; i++)
            {
                for (int j = 0; j < Target.Height; j++)
                {
                    Target.SetPixel(i, j, palette[Indexes[i, j]]);
                }
            }
        }

        private int ClosestColor(List<Color> colors, Color target)
        {
            var colorDiffs = colors.Select(n => ColorDiff(n, target)).Min(n => n);
            return colors.FindIndex(n => ColorDiff(n, target) == colorDiffs);
        }

        private int ColorDiff(Color c1, Color c2)
        {
            return (int)Math.Sqrt((c1.R - c2.R) * (c1.R - c2.R)
                                   + (c1.G - c2.G) * (c1.G - c2.G)
                                   + (c1.B - c2.B) * (c1.B - c2.B));
        }
    }
}
