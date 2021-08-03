using FrogForge.Datas;
using FrogForge.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FrogForge.ExtensionMethods;

namespace FrogForge.Editors
{
    public partial class frmTilesetEditor : frmBaseEditor
    {
        private static readonly Point TILEMAP_SIZE = new Point(6, 10);
        private List<TileData> CurrentTiles = new List<TileData>();
        private List<PictureBox> Renderers = new List<PictureBox>(TILEMAP_SIZE.X * TILEMAP_SIZE.Y);
        private OpenFileDialog dlgOpenTiles = new OpenFileDialog();
        private int _selectedIndex = 0;
        private int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                if (_selectedIndex >= 0)
                {
                    Renderers[_selectedIndex].Image = null;
                }
                if (grpSelectedTile.Enabled = ((_selectedIndex = value) >= 0))
                {
                    Renderers[value].Image = Properties.Resources.Cursor;
                    TileDataToUI(value);
                }
            }
        }
        private bool _tileDirty;
        private bool TileDirty
        {
            get
            {
                return _tileDirty;
            }
            set
            {
                btnTileApply.Enabled = _tileDirty = value;
            }
        }

        public frmTilesetEditor()
        {
            InitializeComponent();
            BaseName = Text;
        }

        private void frmTilesetEditor_Load(object sender, EventArgs e)
        {
            // Generate renderers
            for (int i = 0; i < TILEMAP_SIZE.X * TILEMAP_SIZE.Y; i++)
            {
                int temp = i;
                PictureBox renderer = new PictureBox();
                renderer.Left = (i % TILEMAP_SIZE.X) * 16;
                renderer.Top = (i / TILEMAP_SIZE.X) * 16;
                renderer.Size = new Size(16, 16);
                renderer.Click += (sender1, e1) => Renderer_Click(temp);
                pnlPossibleTiles.Controls.Add(renderer);
                Renderers.Add(renderer);
            }
            // Dirty
            EventHandler tileDirtyFunc = (s, e1) => TileDirty = true;
            txtTileName.TextChanged += tileDirtyFunc;
            nudArmorMod.ValueChanged += tileDirtyFunc;
            nudMoveCost.ValueChanged += tileDirtyFunc;
            rdbPlt1.CheckedChanged += tileDirtyFunc;
            ckbHigh.CheckedChanged += tileDirtyFunc;
            ckbWall.CheckedChanged += tileDirtyFunc;
            // Init stuff
            dlgOpenTiles.Filter = "Image files|*.png;*.gif;*.jpg";
            dlgOpenTiles.Multiselect = true;
            SelectedIndex = -1;
            lstTilemaps.Init(this, () => new TilesetData(), TilesetDataFromUI, TilesetDataToUI, "Tilesets");
            picTileImage.Init(dlgOpen, this);
            plt1.Init(this, Render);
            plt2.Init(this, Render);
        }

        private void Renderer_Click(int rendererIndex)
        {
            if (rendererIndex < CurrentTiles.Count)
            {
                if (rdbSelectionSelect.Checked)
                {
                    if (ckbAutoApply.Checked && SelectedIndex >= 0 && TileDirty)
                    {
                        TileDataFromUI(SelectedIndex);
                        SelectedIndex = rendererIndex;
                    }
                    else if (!TileDirty || ConfirmDialog("Discard tile changes?", ""))
                    {
                        SelectedIndex = rendererIndex;
                    }
                }
                else if (rdbSelectionSwap.Checked)
                {
                    if (SelectedIndex < 0)
                    {
                        SelectedIndex = rendererIndex;
                    }
                    else
                    {
                        TileData temp = CurrentTiles[SelectedIndex];
                        CurrentTiles[SelectedIndex] = CurrentTiles[rendererIndex];
                        CurrentTiles[rendererIndex] = temp;
                        Render(SelectedIndex);
                        Render(rendererIndex);
                        SelectedIndex = -1;
                        Dirty = true;
                    }
                }
                else if (rdbSelectionPush.Checked)
                {
                    if (SelectedIndex < 0)
                    {
                        SelectedIndex = rendererIndex;
                    }
                    else
                    {
                        TileData temp = CurrentTiles[SelectedIndex];
                        CurrentTiles.RemoveAt(SelectedIndex);
                        CurrentTiles.Insert(rendererIndex, temp);
                        Render();
                        SelectedIndex = -1;
                        Dirty = true;
                    }
                }
            }
        }

        private TilesetData TilesetDataFromUI(TilesetData data)
        {
            data.Name = txtName.Text;
            data.Palette1 = plt1.Data;
            data.Palette2 = plt2.Data;
            data.Tiles = CurrentTiles.ConvertAll(a => a.Clone());
            CurrentFile = data.Name;
            Dirty = false;
            return data;
        }

        private void TilesetDataToUI(TilesetData data)
        {
            data.LoadImages(WorkingDirectory);
            txtName.Text = data.Name;
            plt1.Data = data.Palette1;
            plt2.Data = data.Palette2;
            CurrentTiles = data.Tiles.ConvertAll(a => a.Clone());
            SelectedIndex = -1;
            Render();
            CurrentFile = data.Name;
            Dirty = false;
        }

        private TileData TileDataFromUI(int index)
        {
            TileData data = CurrentTiles[index];
            data.Name = txtTileName.Text;
            data.MoveCost = ckbWall.Checked ? 99 : (int)nudMoveCost.Value;
            data.ArmorMod = (int)nudArmorMod.Value;
            data.High = ckbHigh.Checked;
            data.Image = picTileImage.Image.Clone();
            data.Palette = rdbPlt1.Checked ? 1 : 2;
            Render(index);
            TileDirty = false;
            Dirty = true;
            return data;
        }

        private void TileDataToUI(int index)
        {
            TileData data = CurrentTiles[index];
            txtTileName.Text = data.Name;
            ckbWall.Checked = data.MoveCost > 50;
            nudMoveCost.Value = data.MoveCost <= 50 ? data.MoveCost : 1;
            nudArmorMod.Value = data.ArmorMod;
            ckbHigh.Checked = data.High;
            picTileImage.Image = data.Image.Clone();
            rdbPlt1.Checked = data.Palette == 1;
            rdbPlt2.Checked = data.Palette != 1;
            picTileImage.Palette = CurrentTiles[index].Palette == 1 ? plt1.Data : plt2.Data;
            TileDirty = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ckbAutoApply.Checked && SelectedIndex >= 0)
            {
                TileDataFromUI(SelectedIndex);
            }
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

        private void Render(int index)
        {
            Renderers[index].BackgroundImage = CurrentTiles[index].Image.ToBitmap(CurrentTiles[index].Palette == 1 ? plt1.Data : plt2.Data);
            Renderers[index].Image = index == SelectedIndex ? Properties.Resources.Cursor : null; // I don't know why, but it doesn't work without this line. Weird.
        }

        private void Render(Palette palette = null)
        {
            for (int i = 0; i < CurrentTiles.Count; i++)
            {
                Render(i);
            }
            for (int i = CurrentTiles.Count; i < TILEMAP_SIZE.X * TILEMAP_SIZE.Y; i++)
            {
                Renderers[i].BackgroundImage = null;
            }
        }

        private void ckbWall_CheckedChanged(object sender, EventArgs e)
        {
            nudMoveCost.Enabled = !ckbWall.Checked;
        }

        private void btnTileApply_Click(object sender, EventArgs e)
        {
            TileDataFromUI(SelectedIndex);
        }

        private void btnAddTiles_Click(object sender, EventArgs e)
        {
            if (dlgOpenTiles.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dlgOpenTiles.FileNames.Length; i++)
                {
                    Image source = Image.FromFile(dlgOpenTiles.FileNames[i]);
                    if ((source.Height > 16 || source.Width > 16) &&
                        ConfirmDialog("Auto-crop " + dlgOpenTiles.FileNames[i].Substring(dlgOpenTiles.FileNames[i].LastIndexOf(@"\") + 1) + "?", ""))
                    {
                        Bitmap target = new Bitmap(16, 16);
                        using (var g = Graphics.FromImage(target))
                        {
                            for (int j = 0; j < source.Height / 16; j++)
                            {
                                for (int k = 0; k < source.Width / 16; k++)
                                {
                                    g.DrawImage(source, 0, 0, new Rectangle(k * 16, j * 16, 16, 16), GraphicsUnit.Pixel);
                                    CurrentTiles.Add(new TileData(target, 1, 0, 1, false, ""));
                                    Render(CurrentTiles.Count - 1);
                                }
                            }
                        }
                    }
                    else
                    {
                        CurrentTiles.Add(new TileData(source.SplitGIF(), 1, 0, 1, false, ""));
                        Render(CurrentTiles.Count - 1);
                    }
                }
            }
        }

        private void btnRemoveTiles_Click(object sender, EventArgs e)
        {
            if (CurrentTiles.Count > 0)
            {
                CurrentTiles.RemoveAt(SelectedIndex >= 0 ? SelectedIndex : (CurrentTiles.Count - 1));
                SelectedIndex = -1;
                Render();
            }
        }

        private void frmTilesetEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            // Save tilemaps
            lstTilemaps.SaveToFile();
            // Save tile images
            foreach (TilesetData item in lstTilemaps.Data)
            {
                WorkingDirectory.CreateDirectory(@"Images\Tilesets\" + item.Name);
                for (int i = 0; i < item.Tiles.Count; i++)
                {
                    if (item.Tiles[i]?.Image?.Target != null)
                    {
                        item.Tiles[i].Image.CurrentPalette = Palette.BasePalette;
                        WorkingDirectory.SaveImage(@"Tilesets\" + item.Name + @"\" + i, item.Tiles[i].Image.Target);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
