using FrogForge.Editors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge.UserControls
{
    public partial class VoicePitchSlider : UserControl
    {
        public float Pitch
        {
            get
            {
                return (float)nudPitch.Value;
            }
            set
            {
                nudPitch.Value = (decimal)value;
            }
        }

        public VoicePitchSlider()
        {
            InitializeComponent();
        }

        public void Init(frmBaseEditor baseEditor)
        {
            nudPitch.ValueChanged += (sender, e) => baseEditor.Dirty = true;
        }

        private void trkPitch_Scroll(object sender, EventArgs e)
        {
            nudPitch.Value = trkPitch.Value / (decimal)100;
        }

        private void nudPitch_ValueChanged(object sender, EventArgs e)
        {
            trkPitch.Value = (int)(nudPitch.Value * 100);
        }
    }
}
