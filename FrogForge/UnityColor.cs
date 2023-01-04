using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge
{
    public class UnityColor
    {
        public static List<System.Drawing.Color> AllPossibleColors { get; } = new List<System.Drawing.Color>(new System.Drawing.Color[]
        {
            // Generated in Frogman Magmaborn
            System.Drawing.ColorTranslator.FromHtml("#FFFFFFFF"),
            System.Drawing.ColorTranslator.FromHtml("#FFA4E8FC"),
            System.Drawing.ColorTranslator.FromHtml("#FFBCB8FC"),
            System.Drawing.ColorTranslator.FromHtml("#FFDCB8FC"),
            System.Drawing.ColorTranslator.FromHtml("#FFFCB8FC"),
            System.Drawing.ColorTranslator.FromHtml("#FFF4C0E0"),
            System.Drawing.ColorTranslator.FromHtml("#FFF4D0B4"),
            System.Drawing.ColorTranslator.FromHtml("#FFFCE0B4"),
            System.Drawing.ColorTranslator.FromHtml("#FFFCD884"),
            System.Drawing.ColorTranslator.FromHtml("#FFDCF878"),
            System.Drawing.ColorTranslator.FromHtml("#FFB8F878"),
            System.Drawing.ColorTranslator.FromHtml("#FFB0F0D8"),
            System.Drawing.ColorTranslator.FromHtml("#FF00F8FC"),
            System.Drawing.ColorTranslator.FromHtml("#FF000000"),
            System.Drawing.ColorTranslator.FromHtml("#FFFCF8FC"),
            System.Drawing.ColorTranslator.FromHtml("#FF38C0FC"),
            System.Drawing.ColorTranslator.FromHtml("#FF6888FC"),
            System.Drawing.ColorTranslator.FromHtml("#FF9C78FC"),
            System.Drawing.ColorTranslator.FromHtml("#FFFC78FC"),
            System.Drawing.ColorTranslator.FromHtml("#FFFC589C"),
            System.Drawing.ColorTranslator.FromHtml("#FFFC7858"),
            System.Drawing.ColorTranslator.FromHtml("#FFFCA048"),
            System.Drawing.ColorTranslator.FromHtml("#FFFCB800"),
            System.Drawing.ColorTranslator.FromHtml("#FFBCF818"),
            System.Drawing.ColorTranslator.FromHtml("#FF58D858"),
            System.Drawing.ColorTranslator.FromHtml("#FF58F89C"),
            System.Drawing.ColorTranslator.FromHtml("#FF00E8E4"),
            System.Drawing.ColorTranslator.FromHtml("#FF000000"),
            System.Drawing.ColorTranslator.FromHtml("#FFBCC0C4"),
            System.Drawing.ColorTranslator.FromHtml("#FF0078FC"),
            System.Drawing.ColorTranslator.FromHtml("#FF0088FC"),
            System.Drawing.ColorTranslator.FromHtml("#FF6848FC"),
            System.Drawing.ColorTranslator.FromHtml("#FFDC00D4"),
            System.Drawing.ColorTranslator.FromHtml("#FFE40060"),
            System.Drawing.ColorTranslator.FromHtml("#FFFC3800"),
            System.Drawing.ColorTranslator.FromHtml("#FFE46018"),
            System.Drawing.ColorTranslator.FromHtml("#FFAC8000"),
            System.Drawing.ColorTranslator.FromHtml("#FF00B800"),
            System.Drawing.ColorTranslator.FromHtml("#FF00A800"),
            System.Drawing.ColorTranslator.FromHtml("#FF00A848"),
            System.Drawing.ColorTranslator.FromHtml("#FF008894"),
            System.Drawing.ColorTranslator.FromHtml("#FF000000"),
            System.Drawing.ColorTranslator.FromHtml("#FF788084"),
            System.Drawing.ColorTranslator.FromHtml("#FF0000FC"),
            System.Drawing.ColorTranslator.FromHtml("#FF0000C4"),
            System.Drawing.ColorTranslator.FromHtml("#FF4028C4"),
            System.Drawing.ColorTranslator.FromHtml("#FF94008C"),
            System.Drawing.ColorTranslator.FromHtml("#FFAC0028"),
            System.Drawing.ColorTranslator.FromHtml("#FFAC1000"),
            System.Drawing.ColorTranslator.FromHtml("#FF8C1800"),
            System.Drawing.ColorTranslator.FromHtml("#FF503000"),
            System.Drawing.ColorTranslator.FromHtml("#FF007800"),
            System.Drawing.ColorTranslator.FromHtml("#FF006800"),
            System.Drawing.ColorTranslator.FromHtml("#FF005800"),
            System.Drawing.ColorTranslator.FromHtml("#FF004058"),
            System.Drawing.ColorTranslator.FromHtml("#FF000000"),
            System.Drawing.ColorTranslator.FromHtml("#00000000")
        });
        public static int TRANSPARENT_INDEX => AllPossibleColors.Count - 1;
        public static int BLACK_INDEX => AllPossibleColors.Count - 2;

        public int id { get; set; }
        public float r { get; set; }
        public float g { get; set; }
        public float b { get; set; }
        public float a { get; set; }

        public UnityColor(float r, float g, float b, float a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
            if (a < 1)
            {
                id = AllPossibleColors.Count - 1;
            }
            else
            {
                id = ConvertToColor().ClosestColorIndex(AllPossibleColors);
            }
        }

        private System.Drawing.Color ConvertToColor() =>
            System.Drawing.Color.FromArgb((int)(a * 255), (int)(r * 255), (int)(g * 255), (int)(b * 255));

        public static implicit operator System.Drawing.Color(UnityColor c) =>
            AllPossibleColors[c.id];
        public static implicit operator UnityColor(System.Drawing.Color c) =>
            new UnityColor(c.R / 255f, c.G / 255f, c.B / 255f, c.A / 255f);
    }
}
