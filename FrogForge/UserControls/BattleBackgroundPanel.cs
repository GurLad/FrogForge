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
                picLayer1.PostOnClick?.Invoke();
                picLayer2.Image = value.Layer2;
                picLayer2.PostOnClick?.Invoke();
                txtTileName.Text = value.Name;
            }
        }

        public BattleBackgroundPanel()
        {
            InitializeComponent();
        }

        public void Init(OpenFileDialog dlgOpen, frmBaseEditor editor, Func<int, Palette> setPalette, PalettePanel palettePanel1, PalettePanel palettePanel2)
        {
            picLayer1.Init(dlgOpen, editor, palettePanel1);
            picLayer1.PostOnClick = () => picLayer1.Palette = setPalette(1);
            picLayer2.Init(dlgOpen, editor, palettePanel2);
            picLayer2.PostOnClick = () => picLayer2.Palette = setPalette(2);
            txtTileName.TextChanged += (s, e) => editor.Dirty = true;
        }

        public void UpdatePalette()
        {
            picLayer1.PostOnClick();
            picLayer2.PostOnClick();
        }
    }
}
