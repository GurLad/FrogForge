using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge
{
    public partial class dlgColorSelector : Form
    {
        private Color Result;

        public static Color? Dialog(IWin32Window owner)
        {
            dlgColorSelector colorSelector = new dlgColorSelector();
            return colorSelector.ShowDialog(owner) == DialogResult.OK ? colorSelector.Result : (Color?)null;
        }

        private dlgColorSelector()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void picPalette_Click(object sender, EventArgs e)
        {
            MouseEventArgs eventArgs = e as MouseEventArgs;
            Result = new Bitmap(picPalette.Image).GetPixel(eventArgs.X, eventArgs.Y);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
