using FrogForge.Datas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge.Editors
{
    public partial class frmTilemapEditor : frmBaseEditor
    {
        public frmTilemapEditor()
        {
            InitializeComponent();
        }

        private void frmTilemapEditor_Load(object sender, EventArgs e)
        {
            // Init stuff
            lstTilemaps.Init(this, () => new TilemapData(), TilemapDataFromUI, TilemapDataToUI, "Tilemaps");
            plt1.Init(this, Render);
            plt2.Init(this, Render);
        }

        private TilemapData TilemapDataFromUI(TilemapData data)
        {
            data.Name = txtName.Text;
            data.Palette1 = plt1.Data;
            data.Palette2 = plt2.Data;
            CurrentFile = data.Name;
            Dirty = false;
            return data;
        }

        private void TilemapDataToUI(TilemapData data)
        {
            txtName.Text = data.Name;
            plt1.Data = data.Palette1;
            plt2.Data = data.Palette2;
            CurrentFile = data.Name;
            Dirty = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lstTilemaps.Save(txtName.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lstTilemaps.New();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstTilemaps.Remove();
        }

        protected override bool ControlKeyAction(Keys key)
        {
            switch (key)
            {
                case Keys.S:
                    btnSave_Click(this, new EventArgs());
                    return true;
                case Keys.N:
                    btnNew_Click(this, new EventArgs());
                    return true;
                default:
                    break;
            }
            return false;
        }

        private void RenderTile(int index)
        {
            // TBA
        }

        private void Render(Palette palette)
        {
            // TBA
        }
    }
}
