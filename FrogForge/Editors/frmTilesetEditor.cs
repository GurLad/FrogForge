using FrogForge.Datas;
using FrogForge.UserControls;
using System;
using System.Collections;
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
        private enum SelectionMode { Select, Swap, Push, Multi }
        private static readonly Point TILEMAP_SIZE = new Point(6, 10);
        private List<TileData> CurrentTiles = new List<TileData>();
        private List<PictureBox> Renderers = new List<PictureBox>(TILEMAP_SIZE.X * TILEMAP_SIZE.Y);
        private OpenFileDialog dlgOpenTiles = new OpenFileDialog();
        private Selection Selected;
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
        private SelectionMode Mode
        {
            get
            {
                if (rdbSelectionSelect.Checked)
                {
                    return SelectionMode.Select;
                }
                else if (rdbSelectionSwap.Checked)
                {
                    return SelectionMode.Swap;
                }
                else if (rdbSelectionPush.Checked)
                {
                    return SelectionMode.Push;
                }
                else if (rdbSelectionMulti.Checked)
                {
                    return SelectionMode.Multi;
                }
                else
                {
                    throw new Exception("Impossible");
                }
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
            dlgOpenTiles.Filter = "Image files|*.png;*.gif";
            dlgOpenTiles.Multiselect = true;
            (Selected = new Selection(this)).Set(-1);
            lstTilemaps.Init(this, () => new TilesetData(), TilesetDataFromUI, TilesetDataToUI, "Tilesets");
            picTileImage.Init(dlgOpen, this);
            plt1.Init(this, UpdatePalette);
            plt2.Init(this, UpdatePalette);
            bblBattleBackgrounds.Init(
                this, () => new BattleBackgroundData(""),
                () => new BattleBackgroundPanel(), (a) => a.Init(dlgOpen, this, GetPalette), true);
            this.ApplyPreferences();
            // Fix zoom mode~
            for (int i = 0; i < TILEMAP_SIZE.X * TILEMAP_SIZE.Y; i++)
            {
                Renderers[i].Height = Renderers[i].Width;
                Renderers[i].Top = (i / TILEMAP_SIZE.X) * Renderers[i].Height;
                Renderers[i].BackColor = Color.Transparent;
            }
        }

        private void Renderer_Click(int rendererIndex)
        {
            if (rendererIndex < CurrentTiles.Count)
            {
                switch (Mode)
                {
                    case SelectionMode.Select:
                        if (ckbAutoApply.Checked && !Selected.IsEmpty() && TileDirty)
                        {
                            TileDataFromUI(Selected[0]);
                            Selected.Set(rendererIndex);
                        }
                        else if (!TileDirty || ConfirmDialog("Discard tile changes?", ""))
                        {
                            Selected.Set(rendererIndex);
                        }
                        break;
                    case SelectionMode.Swap:
                        if (Selected.IsEmpty())
                        {
                            Selected.Set(rendererIndex);
                        }
                        else
                        {
                            TileData temp = CurrentTiles[Selected[0]];
                            CurrentTiles[Selected[0]] = CurrentTiles[rendererIndex];
                            CurrentTiles[rendererIndex] = temp;
                            Render(Selected[0]);
                            Render(rendererIndex);
                            Selected.Set(-1);
                            Dirty = true;
                        }
                        break;
                    case SelectionMode.Push:
                        if (Selected.IsEmpty())
                        {
                            Selected.Set(rendererIndex);
                        }
                        else
                        {
                            TileData temp = CurrentTiles[Selected[0]];
                            CurrentTiles.RemoveAt(Selected[0]);
                            CurrentTiles.Insert(rendererIndex, temp);
                            Render();
                            Selected.Set(-1);
                            Dirty = true;
                        }
                        break;
                    case SelectionMode.Multi:
                        if (!Selected.Contains(rendererIndex))
                        {
                            Selected.Add(rendererIndex);
                        }
                        else
                        {
                            Selected.Remove(rendererIndex);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private TilesetData TilesetDataFromUI(TilesetData data)
        {
            data.Name = txtName.Text;
            data.Palette1 = plt1.Data;
            data.Palette2 = plt2.Data;
            data.Tiles = CurrentTiles.ConvertAll(a => a.Clone());
            data.BattleBackgrounds = bblBattleBackgrounds.Datas;
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
            bblBattleBackgrounds.Datas = data.BattleBackgrounds;
            Selected.Clear();
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
            if (Mode != SelectionMode.Multi) // Multi-setting the image doesn't make sense
            {
                data.Image = picTileImage.Image.Clone();
                data.Palette = rdbPlt1.Checked ? 1 : 2;
            }
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
            picTileImage.Palette = GetPalette(CurrentTiles[index].Palette);
            TileDirty = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ckbAutoApply.Checked && !Selected.IsEmpty())
            {
                foreach (int index in Selected)
                {
                    TileDataFromUI(index);
                }
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
            Renderers[index].BackgroundImage = CurrentTiles[index].Image.ToBitmap(GetPalette(CurrentTiles[index].Palette));
            Renderers[index].Image = Selected.Contains(index) ? Properties.Resources.Cursor : null; // I don't know why, but it doesn't work without this line. Weird.
            Renderers[index].FixZoom();
        }

        private void Render()
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

        private void UpdatePalette(Palette palette = null)
        {
            Render();
            bblBattleBackgrounds.Datas = bblBattleBackgrounds.Datas;
        }

        private void ckbWall_CheckedChanged(object sender, EventArgs e)
        {
            nudMoveCost.Enabled = !ckbWall.Checked;
        }

        private void btnTileApply_Click(object sender, EventArgs e)
        {
            foreach (int index in Selected)
            {
                TileDataFromUI(index);
            }
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
                        int frameCount = source.GetFrameCount();
                        Image splitSource = source.SplitGIF();
                        Bitmap target = new Bitmap(16 * frameCount, 16);
                        using (var g = Graphics.FromImage(target))
                        {
                            for (int j = 0; j < source.Height / 16; j++)
                            {
                                for (int k = 0; k < source.Width / 16; k++)
                                {
                                    for (int m = 0; m < frameCount; m++)
                                    {
                                        g.DrawImage(splitSource, new Rectangle(m * 16, 0, 16, 16), new Rectangle(k * 16 + m * source.Width, j * 16, 16, 16), GraphicsUnit.Pixel);
                                    }
                                    CurrentTiles.Add(new TileData(target, 1, 0, 1, false, ""));
                                    Render(CurrentTiles.Count - 1);
                                }
                            }
                        }
                    }
                    else
                    {
                        TileData tileData = new TileData(source.SplitGIF(), 1, 0, 1, false, "");
                        CurrentTiles.Add(tileData);
                        Render(CurrentTiles.Count - 1);
                    }
                }
                Dirty = true;
            }
        }

        private void btnRemoveTiles_Click(object sender, EventArgs e)
        {
            if (CurrentTiles.Count > 0)
            {
                Selected.DeleteAll(CurrentTiles);
                Render();
                Dirty = true;
            }
        }

        private void frmTilesetEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            // Save tilemaps
            lstTilemaps.SaveToFile();
            // Save tile images & battle backgrounds images
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
                for (int i = 0; i < item.BattleBackgrounds.Count; i++)
                {
                    if (item.BattleBackgrounds[i]?.Layer1?.Target != null)
                    {
                        item.BattleBackgrounds[i].Layer1.CurrentPalette = Palette.BasePalette;
                        WorkingDirectory.SaveImage(
                            @"BattleBackgrounds\" + item.Name + @"\" + item.BattleBackgrounds[i].Name + "1",item.BattleBackgrounds[i].Layer1.Target);
                    }
                    if (item.BattleBackgrounds[i]?.Layer2?.Target != null)
                    {
                        item.BattleBackgrounds[i].Layer2.CurrentPalette = Palette.BasePalette;
                        WorkingDirectory.SaveImage(
                            @"BattleBackgrounds\" + item.Name + @"\" + item.BattleBackgrounds[i].Name + "2", item.BattleBackgrounds[i].Layer2.Target);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private Palette GetPalette(int palette)
        {
            return palette == 1 ? plt1.Data : plt2.Data;
        }

        private void rdbSelectionMulti_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbSelectionMulti.Checked)
            {
                Selected.Clear();
            }
        }

        private class Selection : IEnumerable<int>
        {
            private List<int> SelectedIndexes = new List<int>();
            private frmTilesetEditor Editor;
            public int this[int i]
            {
                get
                {
                    return SelectedIndexes[i];
                }
            }

            public Selection(frmTilesetEditor editor)
            {
                Editor = editor;
            }

            public bool IsEmpty()
            {
                return SelectedIndexes.Count <= 0;
            }

            public void Set(int index)
            {
                Clear();
                if (index >= 0)
                {
                    Add(index);
                }
            }

            public void Add(int index)
            {
                SelectedIndexes.Add(index);
                Editor.Renderers[index].Image = Properties.Resources.Cursor;
                Editor.Renderers[index].FixZoom(background: false);
                Editor.TileDataToUI(index);
                Editor.grpSelectedTile.Enabled = !IsEmpty();
            }

            public void Remove(int index)
            {
                SelectedIndexes.Remove(index);
                Editor.Renderers[index].Image = null;
                Editor.grpSelectedTile.Enabled = !IsEmpty();
            }

            public void Clear()
            {
                while (!IsEmpty())
                {
                    Remove(this[0]);
                }
            }

            public void DeleteAll(List<TileData> currentTiles)
            {
                for (int i = 0; i < SelectedIndexes.Count; i++)
                {
                    Editor.Renderers[this[i]].Image = null;
                }
                while (!IsEmpty())
                {
                    int index = this[0];
                    currentTiles.RemoveAt(index >= 0 ? index : (currentTiles.Count - 1));
                    SelectedIndexes.Remove(index);
                    for (int i = 0; i < SelectedIndexes.Count; i++)
                    {
                        if (SelectedIndexes[i] > index)
                        {
                            SelectedIndexes[i]--;
                        }
                    }
                }
                Editor.grpSelectedTile.Enabled = false;
            }

            public IEnumerator<int> GetEnumerator()
            {
                return SelectedIndexes.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return SelectedIndexes.GetEnumerator();
            }
        }
    }
}
