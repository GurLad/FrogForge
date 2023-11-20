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
        private int width { get; set; } = 1;

        public override void Move(DrawingPanel layer, int colorIndex, Point mousePos, Point previousPos)
        {
            // TBA - line drawing...
            Press(layer, colorIndex, mousePos);
        }

        public override void Press(DrawingPanel layer, int colorIndex, Point mousePos)
        {
            layer.Image.UpdateIndexes(mousePos, colorIndex);
            layer.Render();
        }

        public override void Release(DrawingPanel layer, int colorIndex, Point mousePos)
        {
            // Do nothing
        }
    }
}
