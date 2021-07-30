using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge
{
    public class UnityPoint
    {
        public int x { get; set; }
        public int y { get; set; }

        public UnityPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static implicit operator System.Drawing.Point(UnityPoint p) =>
            new System.Drawing.Point(p.x, p.y);
        public static implicit operator UnityPoint(System.Drawing.Point p) =>
            new UnityPoint(p.X, p.Y);
    }
}
