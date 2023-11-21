using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Paint.DrawingTools
{
    public class DTPencil : ADrawingTool
    {
        private const float EPSILON = 1e-6f;
        private float size { get; set; } = 1;

        public override void Move(DrawingPanel layer, int colorIndex, Point mousePos, Point previousPos)
        {
            layer.Image.UpdateIndexes(Resize(GetLine(previousPos, mousePos)), colorIndex);
            layer.Render();
        }

        public override void Press(DrawingPanel layer, int colorIndex, Point mousePos)
        {
            layer.Image.UpdateIndexes(Resize(mousePos), colorIndex);
            layer.Render();
        }

        public override void Release(DrawingPanel layer, int colorIndex, Point mousePos)
        {
            // Do nothing
        }

        private List<Point> Resize(Point source)
        {
            if (size <= 1 + EPSILON)
            {
                return new List<Point>() { source };
            }
            List<Point> result = new List<Point>();
            int sizeRounded = (int)Math.Floor(size);
            for (int i = -sizeRounded; i <= sizeRounded; i++)
            {
                for (int j = -sizeRounded; j <= sizeRounded; j++)
                {
                    Point target = new Point(source.X + i, source.Y + j);
                    if (target.Dist(source) <= size + EPSILON)
                    {
                        result.Add(target);
                    }
                }
            }
            return result;
        }

        private List<Point> Resize(List<Point> sources)
        {
            List<Point> result = new List<Point>();
            sources.ForEach(a => result.AddRange(Resize(a)));
            return result.Distinct().ToList();
        }

        private List<Point> GetLine(Point start, Point end)
        {
            // Adapted from https://stackoverflow.com/questions/11678693/all-cases-covered-bresenhams-line-algorithm
            if (start.MaxDist(end) <= 1)
            {
                return new List<Point>() { end };
            }
            int x = start.X, y = start.Y;
            int x2 = end.X, y2 = end.Y;
            int w = x2 - x;
            int h = y2 - y;
            int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;
            if (w < 0) dx1 = -1; else if (w > 0) dx1 = 1;
            if (h < 0) dy1 = -1; else if (h > 0) dy1 = 1;
            if (w < 0) dx2 = -1; else if (w > 0) dx2 = 1;
            int longest = Math.Abs(w);
            int shortest = Math.Abs(h);
            if (!(longest > shortest))
            {
                longest = Math.Abs(h);
                shortest = Math.Abs(w);
                if (h < 0) dy2 = -1; else if (h > 0) dy2 = 1;
                dx2 = 0;
            }
            int numerator = longest >> 1;
            List<Point> result = new List<Point>();
            for (int i = 0; i <= longest; i++)
            {
                result.Add(new Point(x, y));
                numerator += shortest;
                if (!(numerator < longest))
                {
                    numerator -= longest;
                    x += dx1;
                    y += dy1;
                }
                else
                {
                    x += dx2;
                    y += dy2;
                }
            }
            return result;
        }
    }
}
