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
        public Bitmap Target { get; protected set; }
        private Palette currentPalette;
        public Palette CurrentPalette
        {
            get => currentPalette;
            set
            {
                currentPalette = value ?? Palette.BasePalette;
                UpdatePalette();
            }
        }
        protected int[,] Indexes;

        public PalettedImage(Image target) : this(new Bitmap(target)) { }

        public PalettedImage(Bitmap target)
        {
            SetIndexes(target);
            currentPalette = Palette.BasePalette;
        }

        public static PalettedImage FromFile(FilesController files, string filename)
        {
            Image target = files.LoadImage(filename);
            return target != null ? new PalettedImage(target) : null;
        }

        public Bitmap ToBitmap(Palette palette)
        {
            PalettedImage temp = Clone();
            temp.CurrentPalette = palette;
            return temp.Target;
        }

        public virtual PalettedImage Clone()
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

        protected virtual void UpdatePalette()
        {
            for (int i = 0; i < Target.Width; i++)
            {
                for (int j = 0; j < Target.Height; j++)
                {
                    Target.SetPixel(i, j, CurrentPalette[Indexes[i, j]]);
                }
            }
        }

        protected virtual void SetIndexes(Bitmap target)
        {
            Target = target;
            Indexes = new int[target.Size.Width, target.Size.Height];
            // TBA: Replace with something more efficient
            for (int i = 0; i < target.Width; i++)
            {
                for (int j = 0; j < target.Height; j++)
                {
                    Color color = target.GetPixel(i, j);
                    Indexes[i, j] = color.A == 0 ? 3 : Palette.BasePalette.ClosestColor(color);
                }
            }
            //SetPalette(Palette.BasePalette);
        }
    }
}