using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace FrogForge
{
    public class PalettedImage
    {
        public Bitmap Target { get; private set; }
        public Palette CurrentPalette
        {
            get => currentPalette;
            set
            {
                currentPalette = value ?? Palette.BasePalette;
                for (int i = 0; i < Target.Width; i++)
                {
                    for (int j = 0; j < Target.Height; j++)
                    {
                        Target.SetPixel(i, j, currentPalette[Indexes[i, j]]);
                    }
                }
            }
        }
        private int[,] Indexes;
        private Palette currentPalette;

        public PalettedImage(Image target) : this(new Bitmap(target)) { }

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
                    Indexes[i, j] = color.A == 0 ? 3 : Palette.BasePalette.ClosestColor(color);
                }
            }
        }

        public Bitmap ToBitmap(Palette palette)
        {
            PalettedImage temp = Clone();
            temp.CurrentPalette = palette;
            return temp.Target;
        }

        public PalettedImage Clone()
        {
            PalettedImage target = new PalettedImage(new Bitmap(Target));
            for (int i = 0; i < Target.Width; i++)
            {
                for (int j = 0; j < Target.Height; j++)
                {
                    target.Indexes[i, j] = Indexes[i, j];
                }
            }
            return target;
        }

        public static PalettedImage FromFile(FilesController files, string filename)
        {
            Image target = files.LoadImage(filename);
            return target != null ? new PalettedImage(target) : null;
        }
    }
}