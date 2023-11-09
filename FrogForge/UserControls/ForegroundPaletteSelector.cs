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
        private List<Palette> BaseSpritePalettes;

        public ForegroundPaletteSelector()
        {
            InitializeComponent();
        }

        public void Init(frmBaseEditor editor, List<Palette> baseSpritePalettes, Action<Palette> onPaletteChange = null)
        {
            Editor = editor;
            OnPaletteChange = onPaletteChange;
            BaseSpritePalettes = baseSpritePalettes;
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
            picFGPalette.BackColor = BaseSpritePalettes?[trkFGPalette.Value][1] ?? Color.Transparent;
            OnPaletteChange?.Invoke(BaseSpritePalettes?[trkFGPalette.Value] ?? Palette.BasePalette);
            if (Editor != null)
            {
                Editor.Dirty = true;
            }
        }

        public void Set(int index)
        {
            trkFGPalette.Value = index;
            trkFGPalette_Scroll(null, null);
        }
    }
}
