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
        public Action Interact { get; protected set; }
        private ToolStripItem _control;
        public ToolStripItem Control => _control = _control ?? Render();
        protected string HotkeyString => hotkey != null ? " (Ctrl+" + hotkey + ")" : "";
        private Keys? hotkey;

        protected ADrawingToolstripItem(Keys? hotkey = null)
        {
            this.hotkey = hotkey;
        }

        protected abstract ToolStripItem Render();

        public bool MatchesHotkey(Keys key)
        {
            return key == hotkey;
        }
    }
}
