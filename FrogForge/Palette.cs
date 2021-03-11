using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge
{
    public class Palette
    {
        public static List<Palette> BaseFGPalettes { get; } = new List<Palette>(new Palette[]
        {
            new Palette(
                ColorTranslator.FromHtml("#FF000000"),
                ColorTranslator.FromHtml("#FF58F89C"),
                ColorTranslator.FromHtml("#FF005800"),
                ColorTranslator.FromHtml("#00000000")),
            new Palette(
                ColorTranslator.FromHtml("#FF000000"),
                ColorTranslator.FromHtml("#FFFC7858"),
                ColorTranslator.FromHtml("#FFAC1000"),
                ColorTranslator.FromHtml("#00000000")),
            new Palette(
                ColorTranslator.FromHtml("#FF000000"),
                ColorTranslator.FromHtml("#FF38C0FC"),
                ColorTranslator.FromHtml("#FF0000FC"),
                ColorTranslator.FromHtml("#00000000")),
            new Palette(
                ColorTranslator.FromHtml("#FF000000"),
                ColorTranslator.FromHtml("#FFFFFFFF"),
                ColorTranslator.FromHtml("#FF788084"),
                ColorTranslator.FromHtml("#00000000"))
        });
        public static Palette BasePalette { get; } = new Palette(
            ColorTranslator.FromHtml("#FF000000"),
            ColorTranslator.FromHtml("#FFFFFFFF"),
            ColorTranslator.FromHtml("#FFBCC0C4"),
            ColorTranslator.FromHtml("#FF788084"));

        private List<Color> Colors { get; }
        public Color this[int index]
        {
            get
            {
                return Colors[index];
            }
        }

        public Palette()
        {
            Colors = BasePalette.Colors;
        }

        public Palette(Color c1, Color c2, Color c3, Color c4)
        {
            Colors = new List<Color>();
            Colors.Add(c1);
            Colors.Add(c2);
            Colors.Add(c3);
            Colors.Add(c4);
        }

        public Palette(Color[] colors)
        {
            Colors = new List<Color>(colors);
        }

        public int ClosestColor( Color target)
        {
            var colorDiffs = Colors.Select(n => ColorDiff(n, target)).Min(n => n);
            return Colors.FindIndex(n => ColorDiff(n, target) == colorDiffs);
        }

        private int ColorDiff(Color c1, Color c2)
        {
            return (int)Math.Sqrt((c1.R - c2.R) * (c1.R - c2.R)
                                   + (c1.G - c2.G) * (c1.G - c2.G)
                                   + (c1.B - c2.B) * (c1.B - c2.B));
        }
    }
}
