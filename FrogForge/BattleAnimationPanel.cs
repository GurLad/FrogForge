using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge
{
    public partial class BattleAnimationPanel : UserControl
    {
        public string AnimationName
        {
            get
            {
                return txtName.Text;
            }
            set
            {
                txtName.Text = value;
            }
        }
        public PalettedImage Animation
        {
            get
            {
                return picAnimation.Image;
            }
            set
            {
                picAnimation.Image = value;
            }
        }

        public BattleAnimationPanel()
        {
            InitializeComponent();
        }

        public void Init(OpenFileDialog dlgOpen)
        {
            picAnimation.Init(dlgOpen);
        }
    }
}
