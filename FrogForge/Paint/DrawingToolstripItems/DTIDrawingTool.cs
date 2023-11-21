using FrogForge.Paint.DrawingTools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge.Paint.DrawingToolstripItems
{
    public class DTIDrawingTool : ADrawingToolstripItem
    {
        public ADrawingTool Tool { get; private set; }
        public ToolStripButton Button { get; private set; }

        public DTIDrawingTool(Action<DTIDrawingTool> setDrawingTool, string name, Image icon, ADrawingTool drawingTool)
        {
            Tool = drawingTool;
            Button = new ToolStripButton();
            Button.Image = icon;
            Button.ToolTipText = name;
            //Button.CheckOnClick = true;
            Button.Click += (s, e) => setDrawingTool(this);
        }

        protected override ToolStripItem Render()
        {
            return Button;
        }
    }
}
