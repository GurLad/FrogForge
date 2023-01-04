using FrogForge.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge
{
    public static class AutoPaletteHelper
    {
        public static int[,] GetFullNESPaletteIndexes(Bitmap target)
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
            return fullImageIndexes;
        }

        public static Palette GenerateAutoPalette(int[,] fullImageIndexes, Bitmap target, bool sprite)
        {
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
            colors.Sort((a, b) => a.Y > b.Y ? -1 : (a.Y < b.Y ? 1 : 0));
            List<int> finalIndexes = colors.GetRange(0, 4).ConvertAll(a => a.X);
            // Process the colours, depending on whether it's a sprite or background
            if (sprite)
            {
                // If it doesn't contain transparent, add it instead of the 4th colour.
                if (!finalIndexes.Contains(UnityColor.TRANSPARENT_INDEX))
                {
                    finalIndexes[3] = UnityColor.TRANSPARENT_INDEX;
                }
            }
            else
            {
                // If it contains transparent, remove it
                if (finalIndexes.Contains(UnityColor.TRANSPARENT_INDEX))
                {
                    finalIndexes.Remove(UnityColor.TRANSPARENT_INDEX);
                    finalIndexes.Add(colors[4].X);
                }
                int blackIndex = finalIndexes.FindIndex(a => UnityColor.AllPossibleColors[a] == Color.Black);
                if (blackIndex < 0) // If it doesn't contain black, add it instead of the 4th colour.
                {
                    finalIndexes[3] = UnityColor.BLACK_INDEX;
                }
                else // Otherwise, make sure the black is always UnityColor.BLACK_INDEX
                {
                    finalIndexes[blackIndex] = UnityColor.BLACK_INDEX;
                }
            }
            // Sort these indexes according to brightness - lower indexes are brighter in the default palette
            finalIndexes.Sort();
            // Lastly, sort them according to FM's (foolish) order: Black(/darkest colour), brightest, middle-light, middle-dark(/transparent)
            List<int> sortedIndexes = new List<int>();
            if (!sprite) // BG - Add black
            {
                sortedIndexes.Add(UnityColor.BLACK_INDEX);
            }
            else // Sprite - Add darkest colour, which is index 2 (3 is transparent)
            {
                sortedIndexes.Add(finalIndexes[2]);
            }
            sortedIndexes.Add(finalIndexes[0]); // Add the brightest colour
            sortedIndexes.Add(finalIndexes[1]); // Add the second-brightest colour
            if (!sprite) // BG - Add the darkest colour, which is index 2 (3 is black)
            {
                sortedIndexes.Add(finalIndexes[2]);
            }
            else // Sprite - Add transparent
            {
                sortedIndexes.Add(UnityColor.TRANSPARENT_INDEX);
            }
            // At long last, we have our final palette. Convert it to colors & assign it to the panel.
            List<Color> sortedColors = sortedIndexes.ConvertAll(a => UnityColor.AllPossibleColors[a]);
            //palettePanel.SilentSetData(new Palette(sortedColors.ToArray()));
            return new Palette(sortedColors.ToArray());
        }

        public static int[,] ReduceIndexes(int[,] fullImageIndexes, Bitmap target, Palette palette)
        {
            // Now, we need to generate the image indexes according to the reduced palette.
            int[,] reducedImageIndexes = new int[target.Width, target.Height];
            List<Color> sortedColors = palette.Colors.ToList().ConvertAll(a => (Color)a);
            for (int i = 0; i < target.Width; i++)
            {
                for (int j = 0; j < target.Height; j++)
                {
                    reducedImageIndexes[i, j] = UnityColor.AllPossibleColors[fullImageIndexes[i, j]].ClosestColorIndex(sortedColors);
                }
            }
            // FINALLY, create the actual PalettedImage from this array
            return reducedImageIndexes;
        }
    }
}
