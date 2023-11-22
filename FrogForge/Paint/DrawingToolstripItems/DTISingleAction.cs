using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge.Paint.DrawingToolstripItems
{
    public class DTISingleAction : ADrawingToolstripItem
    {
        public ToolStripButton Button { get; private set; }

        public DTISingleAction(string name, Image icon, Action action)
        {
            Button = new ToolStripButton();
            Button.Image = icon;
            Button.ToolTipText = name;
            Button.Click += (s, e) => action();
        }

        protected override ToolStripItem Render()
        {
            return Button;
        }
    }
}
