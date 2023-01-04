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

        public PalettedImage(int[,] indexes, Size size, Palette palette)
        {
            Indexes = indexes;
            Target = new Bitmap(size.Width, size.Height);
            currentPalette = palette;
        }

        public static PalettedImage FromFile(FilesController files, string filename)
        {
            Image target = files.LoadImage(filename);
            return target != null ? new PalettedImage(target) : null;
        }

        public static PalettedImage AutoPalette(Bitmap target, UserControls.PalettePanel palettePanel)
        {
            // First, convert to an indexed image using the entire NES colour palette
            int[,] fullImageIndexes = new int[target.Width, target.Height];
            for (int i = 0; i < target.Width; i++)
            {
                for (int j = 0; j < target.Height; j++)
                {
                    Color color = target.GetPixel(i, j);
                    fullImageIndexes[i, j] = color.A == 0 ? UnityColor.TRANSPARENT_INDEX : color.ClosestColorIndex(UnityColor.AllPossibleColors);
                }
            }
            // Now find the 4 most common colours
            List<Point> colors = new List<Point>();
            for (int i = 0; i < UnityColor.AllPossibleColors.Count; i++)
            {
                colors.Add(new Point(i, 0));
            }
            for (int i = 0; i < target.Width; i++)
            {
                for (int j = 0; j < target.Height; j++)
                {
                    colors[fullImageIndexes[i, j]] = new Point(colors[fullImageIndexes[i, j]].X, colors[fullImageIndexes[i, j]].Y + 1);
                }
            }
            colors.Sort((a, b) => a.Y > b.Y ? 1 : (a.Y < b.Y ? -1 : 0));
            List<int> finalIndexes = colors.GetRange(0, 4).ConvertAll(a => a.X);
            // Process the colours, depending on whether it's a sprite or background
            if (palettePanel.SpritePalette)
            {
                // If it doesn't contain transparent, add it instead of the 4th colour.
                if (!finalIndexes.Contains(UnityColor.TRANSPARENT_INDEX))
                {
                    finalIndexes[3] = UnityColor.TRANSPARENT_INDEX;
                }
            }
            else
            {
                // If it doesn't contain black, add it instead of the 4th colour.
                if (finalIndexes.FindIndex(a => UnityColor.AllPossibleColors[a] == Color.Black) < 0)
                {
                    finalIndexes[3] = UnityColor.BLACK_INDEX;
                }
            }
            // Sort these indexes according to brightness - lower indexes are brighter in the default palette
            finalIndexes.Sort();
            // Lastly, sort them according to FM's (foolish) order: Black(/darkest colour), brightest, middle-light, middle-dark(/transparent)
            List<int> sortedIndexes = new List<int>();
            if (!palettePanel.SpritePalette) // BG - Add black
            {
                sortedIndexes.Add(UnityColor.BLACK_INDEX);
            }
            else // Sprite - Add darkest colour, which is index 2 (3 is transparent)
            {
                sortedIndexes.Add(finalIndexes[2]);
            }
            sortedIndexes.Add(finalIndexes[0]); // Add the brightest colour
            sortedIndexes.Add(finalIndexes[1]); // Add the second-brightest colour
            if (!palettePanel.SpritePalette) // BG - Add the darkest colour, which is index 2 (3 is black)
            {
                sortedIndexes.Add(finalIndexes[2]);
            }
            else // Sprite - Add transparent
            {
                sortedIndexes.Add(UnityColor.TRANSPARENT_INDEX);
            }
            // At long last, we have our final palette. Convert it to colors & assign it to the panel.
            List<Color> sortedColors = sortedIndexes.ConvertAll(a => UnityColor.AllPossibleColors[a]);
            palettePanel.SilentSetData(new Palette(sortedColors.ToArray()));
            // Now, we need to generate the image indexes according to the reduced palette.
            int[,] reducedImageIndexes = new int[target.Width, target.Height];
            for (int i = 0; i < target.Width; i++)
            {
                for (int j = 0; j < target.Height; j++)
                {
                    reducedImageIndexes[i, j] = UnityColor.AllPossibleColors[reducedImageIndexes[i, j]].ClosestColorIndex(sortedColors);
                }
            }
            // FINALLY, create the actual PalettedImage from this array
            return new PalettedImage(reducedImageIndexes, target.Size, palettePanel.Data);
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