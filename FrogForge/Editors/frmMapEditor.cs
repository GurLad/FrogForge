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
using Utils;

namespace FrogForge.Editors
{
    public enum Team { Player, Monster, Guard }
    public enum AIType { Charge, Hold, Guard }
    public partial class frmMapEditor : frmBaseEditor
    {
        private FilesController CurrentDirectory { get; set; }
        private MapTile[,] Tiles;
        private MapTile CurrentSelected = new MapTile();
        private List<TilesetData> Tilesets;
        private TilesetData CurrentTileset;
        private PictureBox[,] Renderers;
        private Point Size = new Point(16, 15);
        private List<Unit> Units = new List<Unit>();
        private Unit Placing = null;
        private Unit Selected = null;
        private PictureBox PreviousHover = null;
        private List<ClassData> CachedSprites = new List<ClassData>();
        private int TILE_SIZE
        {
            get
            {
                return (int)(16 * Preferences.Current.ZoomAmount);
            }
        }

        public frmMapEditor()
        {
            InitializeComponent();
            BaseName = Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Find directory
            CurrentDirectory = new FilesController();
            CurrentDirectory.Path = WorkingDirectory.Path;
            CurrentDirectory.CreateDirectory("Maps", true);
            // Load levels
            CurrentDirectory.DefultFileFormat = ".txt";
            flbFiles.Directory = CurrentDirectory;
            flbFiles.OnFileSelected = LoadFile;
            flbFiles.ShowDirectories = false;
            flbFiles.UpdateList();
            // Load tiles
            Tilesets = WorkingDirectory.LoadFile("Tilesets", "", ".json").JsonToObject<List<TilesetData>>();
            if (Tilesets.Count < 1)
            {
                Close();
                MessageBox.Show("You must have at least 1 tileset!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cmbTileSets.Items.AddRange(Tilesets.ConvertAll(a => a.Name).ToArray());
            cmbTileSets.SelectedIndex = 0;
            SetTileSet(Tilesets[0]);
            // End load files
            // Generate UI
            UpdatePreview();
            Tiles = new MapTile[Size.X, Size.Y];
            int i;
            for (i = 0; i < Tiles.GetLength(0); i++)
            {
                for (int j = 0; j < Tiles.GetLength(1); j++)
                {
                    Tiles[i, j] = new MapTile();
                    Tiles[i, j].Pos = new Point(i, j);
                }
            }
            Renderers = new PictureBox[Size.X, Size.Y];
            for (i = 0; i < Size.X; i++)
            {
                for (int j = 0; j < Size.Y; j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 16;
                    pictureBox.Height = 16;
                    pictureBox.Left = 16 * i;
                    pictureBox.Top = 16 * j;
                    pictureBox.MouseMove += TileMouseMove;
                    pictureBox.MouseDown += TileMouseMove;
                    pictureBox.Capture = false;
                    //pictureBox.BackgroundImageLayout = ImageLayout.Stretch; // Why was this even here?
                    pnlRenderer.Controls.Add(pictureBox);
                    Renderers[i, j] = pictureBox;
                }
            }
            Render();
            cmbAIType.SelectedIndex = 0;
            cmbUnitTeam.SelectedIndex = 0;
            // Set dirty
            rdbDefeatBoss.CheckedChanged += DirtyFunc;
            rdbEscape.CheckedChanged += DirtyFunc;
            rdbRout.CheckedChanged += DirtyFunc;
            rdbSurvive.CheckedChanged += DirtyFunc;
            txtLevelName.TextChanged += DirtyFunc;
            nudLevelNumber.ValueChanged += DirtyFunc;
            // Init stuff
            melMapEvents.Init(this, () => new MapEventData(), () => new UserControls.MapEventPanel(), (a) => a.Init(this, DataDirectory), false);
            this.ApplyPreferences();
            SetTileSet(Tilesets[0]);
        }

        private void Render()
        {
            for (int i = 0; i < Size.X; i++)
            {
                for (int j = 0; j < Size.Y; j++)
                {
                    RenderTile(i, j);
                }
            }
        }

        private void RenderTile(int x, int y)
        {
            RenderPictureboxFromTile(Renderers[x, y], Tiles[x, y]);
        }

        private void RenderPictureboxFromTile(PictureBox pictureBox, MapTile tile)
        {
            pictureBox.BackgroundImage = CurrentTileset.Tiles[tile.TileID].Image.Target;
            Point pos = new Point(pictureBox.Left / TILE_SIZE, pictureBox.Top / TILE_SIZE);
            int unitIndex = Units.FindIndex(a => a.Pos == pos);
            if (unitIndex >= 0)
            {
                pictureBox.Image = Units[unitIndex].image ?? GetUnitImage(Units[unitIndex]);
            }
            else
            {
                pictureBox.Image = null;
            }
            pictureBox.FixZoom();
        }

        private void TileMouseMove(object sender, MouseEventArgs e)
        {
            if (Placing != null)
            {
                if (PreviousHover != null && PreviousHover.Image != null)
                {
                    PreviousHover.Image = null;
                }
                PictureBox pictureBox = (PictureBox)sender;
                if (e.Button == MouseButtons.Left)
                {
                    Placing.Pos = new Point(pictureBox.Left / TILE_SIZE, pictureBox.Top / TILE_SIZE);
                    tbcUI.Enabled = true;
                    lstUnits.DataSource = null;
                    lstUnits.DataSource = Units;
                    lstUnits.SelectedIndex = lstUnits.Items.Count - 1;
                    SelectUnit(Placing);
                    Placing = null;
                    RenderTile(pictureBox.Left / TILE_SIZE, pictureBox.Top / TILE_SIZE);
                    PreviousHover = null;
                    Dirty = true;
                    return;
                }
                else if (pictureBox.Image == null)
                {
                    pictureBox.Image = Placing.image;
                    PreviousHover = pictureBox;
                }
            }
            else if (CurrentSelected != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    PictureBox pictureBox = (PictureBox)sender;
                    pictureBox.Capture = false;
                    Tiles[pictureBox.Left / TILE_SIZE, pictureBox.Top / TILE_SIZE].TileID = CurrentSelected.TileID;
                    RenderTile(pictureBox.Left / TILE_SIZE, pictureBox.Top / TILE_SIZE);
                    Dirty = true;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    PictureBox pictureBox = (PictureBox)sender;
                    pictureBox.Capture = false;
                    FillTile(pictureBox.Left / TILE_SIZE, pictureBox.Top / TILE_SIZE, CurrentSelected);
                    Dirty = true;
                }
            }
        }

        private void FillTile(int x, int y, MapTile tile)
        {
            int originTileID = Tiles[x, y].TileID;
            if (originTileID == tile.TileID)
            {
                return;
            }
            Tiles[x, y].TileID = tile.TileID;
            RenderTile(x, y);
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if ((i == 0 || j == 0) && ValidPos(x + i, y + j) && Tiles[x + i, y + j].TileID == originTileID)
                    {
                        FillTile(x + i, y + j, tile);
                    }
                }
            }
        }

        private bool ValidPos(int x, int y)
        {
            return x >= 0 && y >= 0 && x < Size.X && y < Size.Y;
        }

        private void btnTileButton_Click(object sender, EventArgs e)
        {
            CurrentSelected = CurrentSelected ?? new MapTile();
            CurrentSelected.TileID = (int)((PictureBox)sender).Tag;
            UpdatePreview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Dirty = false;
            MapData data = new MapData();
            // Tilemap
            string result = "";
            for (int i = 0; i < Tiles.GetLength(0); i++)
            {
                for (int j = 0; j < Tiles.GetLength(1); j++)
                {
                    result += Tiles[i, j].TileID + "|";
                }
                result = result.Substring(0, result.Length - 1);
                result += ";";
            }
            result = result.Substring(0, result.Length - 1);
            data.Tiles = result;
            // Everything else
            data.Units = Units;
            data.MapEvents = melMapEvents.Datas;
            data.Tileset = cmbTileSets.Text;
            data.LevelNumber = (int)nudLevelNumber.Value;
            data.Objective = ObjectiveToString();
            data.Name = txtLevelName.Text;
            CurrentDirectory.SaveFile(txtLevelName.Text, data.ToJson());
            flbFiles.UpdateList();
            VoiceAssist.Say("Save");
        }

        private void LoadFile(string fileName)
        {
            if (HasUnsavedChanges())
            {
                return;
            }
            CurrentFile = fileName;
            MapData data = CurrentDirectory.LoadFile(txtLevelName.Text = fileName).JsonToObject<MapData>();
            Tiles = null;
            string[] rows = data.Tiles.Split(';');
            for (int i = 0; i < rows.Length; i++)
            {
                string[] row = rows[i].Split('|');
                if (Tiles == null)
                {
                    Tiles = new MapTile[rows.Length, row.Length];
                }
                for (int j = 0; j < row.Length; j++)
                {
                    Tiles[i, j] = new MapTile();
                    Tiles[i, j].Pos = new Point(i, j);
                    Tiles[i, j].TileID = int.Parse(row[j]);
                }
            }
            Units = data.Units;
            melMapEvents.Datas = data.MapEvents;
            cmbTileSets.Text = data.Tileset;
            nudLevelNumber.Value = data.LevelNumber;
            ObjectiveFromString(data.Objective);
            Render();
            lstUnits.DataSource = null;
            lstUnits.DataSource = Units;
            Dirty = false;
        }

        protected override bool ControlKeyAction(Keys key)
        {
            switch (key)
            {
                case Keys.S:
                    btnSave_Click(key, new EventArgs());
                    return true;
                case Keys.N:
                    btnNew_Click(key, new EventArgs());
                    return true;
                default:
                    break;
            }
            return false;
        }

        private string ObjectiveToString()
        {
            if (rdbRout.Checked)
            {
                return "Rout";
            }
            else if (rdbDefeatBoss.Checked)
            {
                return "Boss:" + txtBossName.Text;
            }
            else if (rdbSurvive.Checked)
            {
                return "Survive:" + nudSurviveTurn.Value;
            }
            else if (rdbEscape.Checked)
            {
                return "Escape:" + nudEscapePosX.Value + ":" + nudEscapePosY.Value;
            }
            else
            {
                return "Null";
            }
        }

        private void ObjectiveFromString(string source)
        {
            string[] parts = source.Split(':');
            switch (parts[0])
            {
                case "Rout":
                    rdbRout.Checked = true;
                    break;
                case "Boss":
                    rdbDefeatBoss.Checked = true;
                    txtBossName.Text = parts[1];
                    break;
                case "Survive":
                    rdbSurvive.Checked = true;
                    nudSurviveTurn.Value = int.Parse(parts[1]);
                    break;
                case "Escape":
                    rdbEscape.Checked = true;
                    nudEscapePosX.Value = int.Parse(parts[1]);
                    nudEscapePosY.Value = int.Parse(parts[2]);
                    break;
                default:
                    break;
            }
        }

        private void UpdatePreview()
        {
            RenderPictureboxFromTile(picPreview, CurrentSelected);
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            Units.Add(Placing = new Unit((Team)Enum.Parse(typeof(Team), cmbUnitTeam.Text), (int)nudLevel.Value, txtClass.Text, (AIType)Enum.Parse(typeof(AIType), cmbAIType.Text), (int)nudReinforcementTurn.Value, ckbStatue.Checked));
            Placing.image = GetUnitImage(Placing);
            CurrentSelected = null;
            picPreview.BackgroundImage = null;
            tbcUI.Enabled = false;
        }

        private Image GetUnitImage(Unit unit)
        {
            Palette palette = PaletteFromTeam(unit.Team);
            // Find image
            Image image = CachedSprites.Find(a => a.Name == unit.Class && a.MapSprite.CurrentPalette == palette)?.MapSprite.Target;
            // Check if cached
            if (image != null)
            {
                return image;
            }
            else
            {
                ClassData newData = new ClassData();
                newData.Name = unit.Class;
                CachedSprites.Add(newData);
                newData.LoadSprite(WorkingDirectory);
                // Check if exists. Otherwise, load error sprite
                newData.MapSprite = newData.MapSprite ?? new PalettedImage(DataDirectory.LoadImage("ErrorSprite") ?? throw new Exception("No error sprite!"));
                newData.MapSprite.CurrentPalette = palette;
                return newData.MapSprite.Target;
            }
        }

        private Palette PaletteFromTeam(Team team)
        {
            return Palette.BaseSpritePalettes[(int)team];
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveUnit(Units[lstUnits.SelectedIndex]);
        }

        private void cmbTileSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTileSet(Tilesets.Find(a => a.Name == cmbTileSets.Text));
        }

        private void SetTileSet(TilesetData set)
        {
            (CurrentTileset = set).LoadImages(WorkingDirectory);
            pnlPossibleTiles.Controls.Clear();
            for (int i = 0; i < set.Tiles.Count; i++)
            {
                PictureBox tileButton = new PictureBox();
                tileButton.Width = 16;
                tileButton.Height = 16;
                tileButton.Left = 16 * (i % 6);
                tileButton.Top = 16 * (i / 6);
                set.Tiles[i].Image.CurrentPalette = set.Tiles[i].Palette == 1 ? set.Palette1 : set.Palette2;
                tileButton.Image = set.Tiles[i].Image.Target;
                tileButton.Tag = i;
                tileButton.Click += btnTileButton_Click;
                tileButton.ResizeByZoom();
                pnlPossibleTiles.Controls.Add(tileButton);
                tileButton.FixZoom();
            }
            if (Tiles != null)
            {
                Render();
            }
        }

        private void lstUnits_DoubleClick(object sender, EventArgs e)
        {
            if (Placing == null && lstUnits.SelectedIndex >= 0)
            {
                SelectUnit(Selected = Units[lstUnits.SelectedIndex]);
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            RemoveUnit(Selected);
            btnPlace_Click(sender, e);
        }

        private void SelectUnit(Unit unit)
        {
            Selected = unit;
            if (unit != null)
            {
                cmbUnitTeam.Text = unit.Team.ToString();
                nudLevel.Value = unit.Level;
                txtClass.Text = unit.Class;
                cmbAIType.Text = unit.AIType.ToString();
                nudReinforcementTurn.Value = unit.ReinforcementTurn;
                ckbStatue.Checked = unit.Statue;
                btnPlace.Width = 59;
                btnReplace.Enabled = true;
            }
            else
            {
                btnPlace.Width = 124;
                btnReplace.Enabled = false;
            }
            btnPlace.ResizeByZoom(false, y: false);
        }

        private void RemoveUnit(Unit unit)
        {
            Point pos = unit.Pos;
            Units.Remove(unit);
            lstUnits.DataSource = null;
            lstUnits.DataSource = Units;
            RenderTile(pos.X, pos.Y);
        }

        private void lstUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectUnit(null);
        }

        private void rdbDefeatBoss_CheckedChanged(object sender, EventArgs e)
        {
            txtBossName.Enabled = rdbDefeatBoss.Checked;
        }

        private void rdbSurvive_CheckedChanged(object sender, EventArgs e)
        {
            nudSurviveTurn.Enabled = rdbSurvive.Checked;
        }

        private void rdbEscape_CheckedChanged(object sender, EventArgs e)
        {
            nudEscapePosX.Enabled = nudEscapePosY.Enabled = rdbEscape.Checked;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (HasUnsavedChanges())
            {
                return;
            }
            Units.Clear();
            lstUnits.DataSource = null;
            lstUnits.DataSource = Units;
            txtLevelName.Text = "";
            nudLevelNumber.Value = 0;
            rdbRout.Checked = true;
            for (int i = 0; i < Size.X; i++)
            {
                for (int j = 0; j < Size.Y; j++)
                {
                    Tiles[i, j].TileID = 0;
                }
            }
            cmbTileSets.SelectedIndex = 0;
            SetTileSet(Tilesets[0]);
            Render();
            CurrentFile = "";
            VoiceAssist.Say("New");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string toDelete = flbFiles.SelectedFilename ?? txtLevelName.Text;
            if (CurrentDirectory.CheckFileExist(toDelete + CurrentDirectory.DefultFileFormat))
            {
                if (DeleteFile(toDelete, CurrentDirectory))
                {
                    flbFiles.UpdateList();
                    VoiceAssist.Say("Delete");
                }
            }
        }
    }
}
