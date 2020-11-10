using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace FrogmanGaidenLevelEditor
{
    [System.ComponentModel.Designer(typeof(RichTextBoxExDesigner))]
    public partial class FixedRichTextBox : RichTextBox
    {
        private const int WM_USER = 0x0400;
        private const int EM_SETEVENTMASK = (WM_USER + 69);
        private const int WM_SETREDRAW = 0x0b;
        private IntPtr OldEventMask;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        public void BeginUpdate()
        {
            SendMessage(this.Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);
            OldEventMask = (IntPtr)SendMessage(this.Handle, EM_SETEVENTMASK, IntPtr.Zero, IntPtr.Zero);
        }

        public void EndUpdate()
        {
            SendMessage(this.Handle, WM_SETREDRAW, (IntPtr)1, IntPtr.Zero);
            SendMessage(this.Handle, EM_SETEVENTMASK, IntPtr.Zero, OldEventMask);
        }
    }
    public class RichTextBoxExDesigner : ControlDesigner
    {
        public override void InitializeNewComponent(System.Collections.IDictionary defaultValues)
        {
            var txt = Control.Text;
            base.InitializeNewComponent(defaultValues);
            Control.Text = txt;
        }
    }
}
