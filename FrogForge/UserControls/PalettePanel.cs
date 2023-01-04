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
    public partial class PalettePanel : PaletteEditor
    {
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Palette Data
        {
            get
            {
                return new Palette(BGPaletteSelectors.Select(a => a.BackColor).ToArray());
            }
            set
            {
                SilentSetData(value);
                OnPaletteChange?.Invoke(Data);
            }
        }
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool SpritePalette { get; set; } = false;
        private frmBaseEditor Editor;
        private List<PictureBox> BGPaletteSelectors;
        private Action<Palette> OnPaletteChange;

        public PalettePanel()
        {
            InitializeComponent();
            GenerateBoxes();
        }

        public void Init(frmBaseEditor editor, Action<Palette> onPaletteChange = null)
        {
            Editor = editor;
            OnPaletteChange = onPaletteChange;
        }

        public void ApplyZoomMode()
        {
            GenerateBoxes();
        }

        public void SilentSetData(Palette value)
        {
            for (int i = 0; i < 4; i++)
            {
                BGPaletteSelectors[i].BackColor = value[i];
                if (SpritePalette && i == 3) // Fix non-transparent JSONs
                {
                    BGPaletteSelectors[i].BackColor = Color.Transparent;
                }
            }
        }

        private void Box_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = dlgColorSelector.Dialog(this) ?? ((PictureBox)sender).BackColor;
            OnPaletteChange?.Invoke(Data);
            if (Editor != null)
            {
                Editor.Dirty = true;
            }
        }

        private void PalettePanel_SizeChanged(object sender, EventArgs e)
        {
            GenerateBoxes();
        }

        private void GenerateBoxes()
        {
            Controls.Clear();
            BGPaletteSelectors = new List<PictureBox>(4);
            // Calculate sizes
            int boxSize = (Width - 6) / 4;
            int boxSpace = (Width + 6 - boxSize * 4) / 4 + boxSize;
            boxSize = Width - boxSpace * 3;
            // Generate boxes
            for (int i = 0; i < 4; i++)
            {
                PictureBox box = new PictureBox();
                box.Location = new Point(boxSpace * i, 0);
                box.Size = new Size(boxSize, Height);
                box.BorderStyle = BorderStyle.Fixed3D;
                box.BackColor = Palette.BasePalette[i];
                if (i != (SpritePalette ? 3 : 0)) // Sprites can modify the Black color, because I misread how NES palettes work initially
                {
                    box.Click += Box_Click;
                }
                else
                {
                    box.Enabled = false;
                }
                Controls.Add(box);
                BGPaletteSelectors.Add(box);
            }
        }
    }
}
