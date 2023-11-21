using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge.Paint.DrawingToolstripItems
{
    public abstract class ADrawingToolstripItem
    {
        private ToolStripItem _control;
        public ToolStripItem Control => _control = _control ?? Render();

        protected abstract ToolStripItem Render();
    }
}
