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
        public override void Move(DrawingPanel layer, int colorIndex, Point mousePos, Point previousPos)
        {
            // Do nothing
        }

        public override void Press(DrawingPanel layer, int colorIndex, Point mousePos)
        {
            // Do nothing
        }

        public override void Release(DrawingPanel layer, int colorIndex, Point mousePos)
        {
            Fill(layer.Image, colorIndex, mousePos);
            layer.Render();
        }

        private void Fill(PalettedImage image, int fillColor, Point pos, int? originColor = null)
        {
            originColor = originColor ?? image.GetIndex(pos);
            if (originColor == fillColor || originColor < 0)
            {
                return;
            }
            image.UpdateIndexes(pos, fillColor);
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i != j && (i == 0 || j == 0) && image.GetIndex(pos.X + i, pos.Y + j) == originColor)
                    {
                        Fill(image, fillColor, new Point(pos.X + i, pos.Y + j), originColor);
                    }
                }
            }
        }
    }
}
