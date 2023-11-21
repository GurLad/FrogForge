using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge.Paint.DrawingToolstripItems
{
    public class DTISeperator : ADrawingToolstripItem
    {
        protected override ToolStripItem Render()
        {
            return new ToolStripSeparator();
        }
    }
}
