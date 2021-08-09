using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge
{
    public class PartialPalettedImage : PalettedImage
    {
        private bool[,] TransparentBlocks; 

        public PartialPalettedImage(Image target) : base(target) { }

        public PartialPalettedImage(Bitmap target) : base(target) { }

        protected override void SetPalette(Palette palette)
        {
            for (int i = 0; i < Target.Width / 8; i++)
            {
                for (int j = 0; j < Target.Height / 8; j++)
                {
                    bool transparent = TransparentBlocks[i, j];
                    for (int k = 0; k < 8; k++)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            Target.SetPixel(i * 8 + k, j * 8 + l, transparent ? Color.Transparent : CurrentPalette[Indexes[i * 8 + k, j * 8 + l]]);
                        }
                    }
                }
            }
        }

        protected override void SetIndexes(Bitmap target)
        {
            if (target.Width % 8 != 0 || target.Height % 8 != 0)
            {
                System.Windows.Forms.MessageBox.Show("Size must be divisable by 8", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                SetIndexes(new Bitmap(8, 8));
                return;
            }
            Target = target;
            Indexes = new int[target.Size.Width, target.Size.Height];
            TransparentBlocks = new bool[target.Size.Width / 8, target.Size.Height / 8];
            // TBA: Replace with something more efficient
            for (int i = 0; i < Target.Width / 8; i++)
            {
                for (int j = 0; j < Target.Height / 8; j++)
                {
                    bool transparent = true;
                    for (int k = 0; k < 8; k++)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            Color color = target.GetPixel(i * 8 + k, j * 8 + l);
                            Indexes[i * 8 + k, j * 8 + l] = color.A == 0 ? 3 : Palette.BasePalette.ClosestColor(color);
                            transparent = transparent && color.A == 0;
                        }
                    }
                    if (transparent)
                    {
                        TransparentBlocks[i, j] = true;
                    }
                }
            }
        }

        public override PalettedImage Clone()
        {
            PartialPalettedImage target = new PartialPalettedImage(new Bitmap(Target));
            for (int i = 0; i < Target.Width; i++)
            {
                for (int j = 0; j < Target.Height; j++)
                {
                    target.Indexes[i, j] = Indexes[i, j];
                }
            }
            for (int i = 0; i < Target.Width / 8; i++)
            {
                for (int j = 0; j < Target.Height / 8; j++)
                {
                    target.TransparentBlocks[i, j] = TransparentBlocks[i, j];
                }
            }
            return target;
        }
    }
}
