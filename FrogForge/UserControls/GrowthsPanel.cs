using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrogForge.Datas;
using FrogForge.Editors;

namespace FrogForge.UserControls
{
    public partial class GrowthsPanel : GrowthsEditor
    {
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Growths Data
        {
            get
            {
                Growths stats = new Growths();
                for (int i = 0; i < 6; i++)
                {
                    stats.Values[i] = (int)Growths[i].Value;
                }
                return stats;
            }
            set
            {
                for (int i = 0; i < 6; i++)
                {
                    Growths[i].Value = value?.Values[i] ?? 0;
                }
            }
        }
        private NumericUpDown[] Growths = new NumericUpDown[6];
        private frmBaseEditor Editor;

        public GrowthsPanel()
        {
            InitializeComponent();
            // Create growths UI
            Size = new Size(234, 49);
            int nudWidth = 36, lblWidth = 32, height = 23, offset = 6, topOffset = 0, lblTopOffset = 3, leftOffset = 0;
            Color[] colors = new Color[] { Color.Red, Color.Blue, Color.Green };
            for (int i = 0; i < 6; i++)
            {
                Label newLbl = new Label();
                newLbl.Width = lblWidth;
                newLbl.Height = height;
                newLbl.Left = (i / 2) * (lblWidth + nudWidth + offset * 2) + leftOffset;
                newLbl.Top = (i % 2) * (height + offset) + topOffset + lblTopOffset;
                newLbl.ForeColor = colors[i / 2];
                newLbl.Text = ((StatNames)i).ToString() + ":";
                Controls.Add(newLbl);
                NumericUpDown newNud = new NumericUpDown();
                newNud.Width = nudWidth;
                newNud.Height = height;
                newNud.Left = (i / 2) * (lblWidth + nudWidth + offset * 2) + lblWidth + offset + leftOffset;
                newNud.Top = (i % 2) * (height + offset) + topOffset;
                newNud.ForeColor = colors[i / 2];
                newNud.Minimum = 0;
                newNud.Maximum = 5;
                newNud.ValueChanged += GrowthsNud_ValueChanged;
                Controls.Add(newNud);
                Growths[i] = newNud;
            }
        }

        public void Init(frmBaseEditor editor)
        {
            Editor = editor;
        }

        private void GrowthsNud_ValueChanged(object sender, EventArgs e)
        {
            if (Editor != null)
            {
                Editor.Dirty = true;
            }
        }
    }
}
