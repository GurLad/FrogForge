using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrogForge.Editors;

namespace FrogForge.UserControls
{
    public partial class ForegroundPaletteSelector : UserControl
    {
        public int Data
        {
            get
            {
                return trkFGPalette.Value;
            }
            set
            {
                trkFGPalette.Value = value;
                trkFGPalette_Scroll(this, new EventArgs());
            }
        }
        private frmBaseEditor Editor;
        private Action<Palette> OnPaletteChange;

        public ForegroundPaletteSelector()
        {
            InitializeComponent();
        }

        public void Init(frmBaseEditor editor, Action<Palette> onPaletteChange = null)
        {
            Editor = editor;
            OnPaletteChange = onPaletteChange;
            // Fix TrackBar BG color
            Control tempParent = this;
            while (tempParent != null && tempParent.BackColor.A < 255)
            {
                tempParent = tempParent.Parent;
            }
            trkFGPalette.BackColor = tempParent?.BackColor ?? Color.Magenta;
        }

        private void trkFGPalette_Scroll(object sender, EventArgs e)
        {
            picFGPalette.BackColor = Palette.BaseSpritePalettes[trkFGPalette.Value][1];
            OnPaletteChange?.Invoke(Palette.BaseSpritePalettes[trkFGPalette.Value]);
            if (Editor != null)
            {
                Editor.Dirty = true;
            }
        }
    }
}
