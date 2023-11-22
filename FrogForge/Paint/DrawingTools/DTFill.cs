using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Paint.DrawingTools
{
    public class DTFill : ADrawingTool
    {
        public override void Move(List<DrawingPanel> layers, int layer, int colorIndex, Point mousePos, Point previousPos)
        {
            // Do nothing
        }

        public override void Press(List<DrawingPanel> layers, int layer, int colorIndex, Point mousePos)
        {
            // Do nothing
        }

        public override void Release(List<DrawingPanel> layers, int layer, int colorIndex, Point mousePos)
        {
            Fill(layers.ConvertAll(a => a.Image), layer, colorIndex, mousePos);
            layers.FindAll((a, i) => i >= layer).ForEach(a => a.Render());
        }

        private void Fill(List<PalettedImage> layers, int layer, int fillColor, Point pos)
        {
            void FillInner(Point current, List<int> originColors)
            {
                layers.ForEach((a, i) => a.UpdateIndexes(current, i == layer ? fillColor : 3), layer);
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (i != j && (i == 0 || j == 0) &&
                            layers.FindIndex((a, k) => a.GetIndex(current.X + i, current.Y + j) != originColors[k], layer) < 0)
                        {
                            FillInner(new Point(current.X + i, current.Y + j), originColors);
                        }
                    }
                }
            }

            List<int> originColorsTemp = layers.ConvertAll(a => a.GetIndex(pos));
            if (originColorsTemp[layer] == fillColor || originColorsTemp[layer] < 0)
            {
                return;
            }
            FillInner(pos, originColorsTemp);
        }
    }
}
