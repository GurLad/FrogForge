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
    public partial class BattleBackgroundPanel : BattleBackgroundEditor
    {
        public override BattleBackgroundData Data
        {
            get
            {
                return new BattleBackgroundData(txtTileName.Text, picLayer1.Image, picLayer2.Image);
            }
            set
            {
                picLayer1.Image = value.Layer1;
                picLayer2.Image = value.Layer2;
                txtTileName.Text = value.Name;
            }
        }

        public BattleBackgroundPanel()
        {
            InitializeComponent();
        }

        public void Init(OpenFileDialog dlgOpen, frmBaseEditor editor)
        {
            picLayer1.Init(dlgOpen, editor);
            picLayer2.Init(dlgOpen, editor);
            txtTileName.TextChanged += (s, e) => editor.Dirty = true;
        }
    }
}
