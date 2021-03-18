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
using FrogForge.Datas;

namespace FrogForge.UserControls
{
    public partial class BattleAnimationPanel : BattleAnimationEditor
    {
        public override BattleAnimationData Data
        {
            get
            {
                return new BattleAnimationData(txtName.Text, picAnimation.Image);
            }
            set
            {
                picAnimation.Image = value.Image;
                txtName.Text = value.Name;
            }
        }

        public BattleAnimationPanel()
        {
            InitializeComponent();
        }

        public void Init(OpenFileDialog dlgOpen, frmBaseEditor editor)
        {
            picAnimation.Init(dlgOpen, editor);
        }
    }
}
