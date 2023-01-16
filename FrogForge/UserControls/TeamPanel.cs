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
    public partial class TeamPanel : TeamEditor
    {
        public override TeamData Data
        {
            get
            {
                return new TeamData(
                    txtName.Text,
                    pltPalette.Data,
                    rdbPlayerController.Checked,
                    (PortraitLoadingMode)cmbPortraitMode.SelectedIndex,
                    appAI.Data,
                    picBase.Image,
                    picMoved.Image);
            }
            set
            {
                txtName.Text = value.Name;
                pltPalette.Data = value.Palette;
                picBase.Image = value.BaseSymbol;
                picMoved.Image = value.MovedSymbol;
                rdbPlayerController.Checked = value.PlayerControlled;
                rdbComputerControlled.Checked = !value.PlayerControlled;
                appAI.Enabled = rdbComputerControlled.Checked;
                cmbPortraitMode.SelectedIndex = (int)value.PortraitLoadingMode;
                appAI.Data = value.AI;
            }
        }

        public TeamPanel()
        {
            InitializeComponent();
        }

        public void Init(frmBaseEditor editor, OpenFileDialog dlgOpen, PalettePanel pltPalette4)
        {
            EventHandler dirtyFunc = (s, e1) => editor.Dirty = true;
            pltPalette.Init(editor);
            appAI.Init(dirtyFunc);
            txtName.TextChanged += dirtyFunc;
            rdbPlayerController.CheckedChanged += dirtyFunc;
            cmbPortraitMode.SelectedIndexChanged += dirtyFunc;
            picBase.Init(dlgOpen, editor, pltPalette4);
            picMoved.Init(dlgOpen, editor, pltPalette4);
        }

        public void UpdatePalette4(Palette palette)
        {
            picBase.Palette = palette;
            picMoved.Palette = palette;
        }

        private void rdbPlayerControlled_CheckedChanged(object sender, EventArgs e)
        {
            appAI.Enabled = rdbComputerControlled.Checked;
        }
    }
}
