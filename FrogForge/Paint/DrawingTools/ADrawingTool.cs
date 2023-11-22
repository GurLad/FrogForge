using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Paint.DrawingTools
{
    public abstract class ADrawingTool
    {
        public abstract void Press(List<DrawingPanel> layers, int layer, int colorIndex, Point mousePos);

        public abstract void Move(List<DrawingPanel> layers, int layer, int colorIndex, Point mousePos, Point previousPos);

        public abstract void Release(List<DrawingPanel> layers, int layer, int colorIndex, Point mousePos);

        // TBA: Add way to change settings (ex. pencil width) and a matching abstract RenderSettingsMenu or something func
    }
}
