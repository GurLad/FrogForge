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
        public static List<Palette> BaseSpritePalettes { get; } = new List<Palette>(new Palette[]
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

        // For JSON convertion from FrogForge to FrogmanGaiden
        public UnityColor[] Colors
        {
            get
            {
                return new UnityColor[] { RealColors[0], RealColors[1], RealColors[2], RealColors[3] };
            }
            set
            {
                RealColors = new List<Color>(new Color[] { value[0], value[1], value[2], value[3] });
            }
        }
        private List<Color> RealColors { get; set; }
        public Color this[int index]
        {
            get
            {
                return RealColors[index];
            }
        }

        public Palette()
        {
            RealColors = BasePalette.RealColors;
        }

        public Palette(Color c1, Color c2, Color c3, Color c4)
        {
            RealColors = new List<Color>();
            RealColors.Add(c1);
            RealColors.Add(c2);
            RealColors.Add(c3);
            RealColors.Add(c4);
        }

        public Palette(Color[] colors)
        {
            RealColors = new List<Color>(colors);
        }

        public int ClosestColor( Color target)
        {
            var colorDiffs = RealColors.Select(n => ColorDiff(n, target)).Min(n => n);
            return RealColors.FindIndex(n => ColorDiff(n, target) == colorDiffs);
        }

        private int ColorDiff(Color c1, Color c2)
        {
            return (int)Math.Sqrt((c1.R - c2.R) * (c1.R - c2.R)
                                   + (c1.G - c2.G) * (c1.G - c2.G)
                                   + (c1.B - c2.B) * (c1.B - c2.B));
        }
    }
}

namespace FrogForge.UserControls
{
    public partial class PaletteEditor : DataEditor<Palette>
    {
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public override Palette Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public partial class PalettesListEditor : ListDataEditor<PalettePanel, Palette> { }
}