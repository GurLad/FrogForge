using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge
{
    public class UnityColor
    {
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
        }

        public static implicit operator System.Drawing.Color(UnityColor c) =>
            System.Drawing.Color.FromArgb((int)(c.a * 255), (int)(c.r * 255), (int)(c.g * 255), (int)(c.b * 255));
        public static implicit operator UnityColor(System.Drawing.Color c) =>
            new UnityColor(c.R / 255f, c.G / 255f, c.B / 255f, c.A / 255f);
    }
}
