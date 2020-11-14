﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace FrogForge
{
    public enum Team { Player, Monster, Guard }
    public enum AIType { Charge, Hold, Guard }
    public partial class frmLevelEditor : Form
    {
        public FilesController DataDirectory { get; set; }
        public FilesController WorkingDirectory { get; set; }
        private FilesController CurrentDirectory { get; set; }
        private Tile[,] Tiles;
        private Tile CurrentSelected = new Tile();
        private List<string> PossibleTileSets;
        private List<Image> PossibleImages = new List<Image>();
        private Label[,] Renderers;
        private Point Size = new Point(16, 15);
        private List<Unit> Units = new List<Unit>();
        private Unit Placing = null;
        private Label PreviousHover = null;

        public frmLevelEditor()
        {
            InitializeComponent();
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
            PossibleTileSets = new List<string>(DataDirectory.AllDirectories(false, @"\Images"));
            cmbTileSets.Items.AddRange(PossibleTileSets.ToArray());
            cmbTileSets.SelectedIndex = 0;
            SetTileSet(PossibleTileSets[0]);
            // End load files
            // Generate UI
            UpdatePreview();
            Tiles = new Tile[Size.X, Size.Y];
            int i;
            for (i = 0; i < Tiles.GetLength(0); i++)
            {
                for (int j = 0; j < Tiles.GetLength(1); j++)
                {
                    Tiles[i, j] = new Tile();
                    Tiles[i, j].Pos = new Point(i, j);
                }
            }
            Renderers = new Label[Size.X, Size.Y];
            for (i = 0; i < Size.X; i++)
            {
                for (int j = 0; j < Size.Y; j++)
                {
                    Label pictureBox = new Label();
                    pictureBox.Width = 16;
                    pictureBox.Height = 16;
                    pictureBox.Left = 16 * i;
                    pictureBox.Top = 16 * j;
                    pictureBox.MouseMove += TileMouseMove;
                    pictureBox.MouseDown += TileMouseMove;
                    pictureBox.Capture = false;
                    pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox.TextAlign = ContentAlignment.MiddleCenter;
                    pnlRenderer.Controls.Add(pictureBox);
                    Renderers[i, j] = pictureBox;
                }
            }
            Render();
        }

        private void Render()
        {
            for (int i = 0; i < Size.X; i++)
            {
                for (int j = 0; j < Size.Y; j++)
                {
                    RenderPictureboxFromTile(Renderers[i, j], Tiles[i, j]);
                }
            }
        }

        private void RenderPictureboxFromTile(Label pictureBox, Tile tile)
        {
            pictureBox.BackgroundImage = PossibleImages[tile.TileID];
            Point pos = new Point(pictureBox.Left / 16, pictureBox.Top / 16);
            int unitIndex = Units.FindIndex(a => a.Pos == pos);
            if (unitIndex >= 0)
            {
                pictureBox.Text = unitIndex.ToString();
                pictureBox.ForeColor = ColorFromTeam(Units[unitIndex].Team);
            }
            else
            {
                pictureBox.Text = "";
            }
        }

        private void TileMouseMove(object sender, MouseEventArgs e)
        {
            if (Placing != null)
            {
                if (PreviousHover != null && PreviousHover.Text == "O")
                {
                    PreviousHover.Text = "";
                }
                Label pictureBox = (Label)sender;
                if (e.Button == MouseButtons.Left)
                {
                    Placing.Pos = new Point(pictureBox.Left / 16, pictureBox.Top / 16);
                    tbcUI.Enabled = true;
                    Placing = null;
                    lstUnits.DataSource = null;
                    lstUnits.DataSource = Units;
                    RenderPictureboxFromTile(pictureBox, Tiles[pictureBox.Left / 16, pictureBox.Top / 16]);
                    return;
                }
                else if (pictureBox.Text == "")
                {
                    pictureBox.Text = "O";
                    pictureBox.ForeColor = ColorFromTeam(Placing.Team);
                    PreviousHover = pictureBox;
                }
            }
            else if (e.Button == MouseButtons.Left && CurrentSelected != null)
            {
                Label pictureBox = (Label)sender;
                pictureBox.Capture = false;
                Tiles[pictureBox.Left / 16, pictureBox.Top / 16].TileID = CurrentSelected.TileID;
                RenderPictureboxFromTile(pictureBox, Tiles[pictureBox.Left / 16, pictureBox.Top / 16]);
            }
        }

        private void BtnTileButton_Click(object sender, EventArgs e)
        {
            CurrentSelected = CurrentSelected ?? new Tile();
            CurrentSelected.TileID = (int)((Label)sender).Tag;
            UpdatePreview();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
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
            // Units
            result += "\n";
            for (int i = 0; i < Units.Count; i++)
            {
                result += Units[i].ToSaveString() + ";";
            }
            result = result.Substring(0, result.Length - 1) + "\n" + cmbTileSets.Text + "\n" + nudLevelNumber.Value + "\n" + ObjectiveToString();
            CurrentDirectory.SaveFile(txtLevelName.Text, result);
            flbFiles.UpdateList();
        }

        private void LoadFile(string fileName)
        {
            Tiles = null;
            string[] result = CurrentDirectory.LoadFile(txtLevelName.Text = fileName).Replace("\r\n", "\n").Split('\n');
            string[] rows = result[0].Split(';');
            for (int i = 0; i < rows.Length; i++)
            {
                string[] row = rows[i].Split('|');
                if (Tiles == null)
                {
                    Tiles = new Tile[rows.Length, row.Length];
                }
                for (int j = 0; j < row.Length; j++)
                {
                    Tiles[i, j] = new Tile();
                    Tiles[i, j].Pos = new Point(i, j);
                    Tiles[i, j].TileID = int.Parse(row[j]);
                }
            }
            rows = result[1].Split(';');
            Units.Clear();
            for (int i = 0; i < rows.Length; i++)
            {
                Units.Add(new Unit(rows[i]));
            }
            cmbTileSets.Text = result[2];
            nudLevelNumber.Value = int.Parse(result[3]);
            ObjectiveFromString(result[4]);
            Render();
            lstUnits.DataSource = null;
            lstUnits.DataSource = Units;
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
            CurrentSelected = null;
            picPreview.BackgroundImage = null;
            tbcUI.Enabled = false;
        }

        private Color ColorFromTeam(Team team)
        {
            switch (team)
            {
                case Team.Player:
                    return Color.Lime;
                case Team.Monster:
                    return Color.Red;
                case Team.Guard:
                    return Color.Blue;
                default:
                    return Color.Black;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Units.RemoveAt(lstUnits.SelectedIndex);
            lstUnits.DataSource = null;
            lstUnits.DataSource = Units;
            Render();
        }

        private void cmbTileSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTileSet(cmbTileSets.Text);
        }

        private void SetTileSet(string set)
        {
            string[] files = DataDirectory.AllFiles(false, true, @"\Images\" + set);
            pnlPossibleTiles.Controls.Clear();
            PossibleImages.Clear();
            for (int i = 0; i < files.Length; i++)
            {
                PossibleImages.Add(DataDirectory.LoadImage(set + @"\" + files[i], "", false));
                Label tileButton = new Label();
                tileButton.Width = 16;
                tileButton.Height = 16;
                tileButton.Left = 16 * (i % 6);
                tileButton.Top = 16 * (i / 6);
                tileButton.Image = PossibleImages[i];
                tileButton.Tag = i;
                tileButton.Click += BtnTileButton_Click;
                pnlPossibleTiles.Controls.Add(tileButton);
            }
            if (Tiles != null)
            {
                Render();
            }
        }

        private void rdbDefeatBoss_CheckedChanged(object sender, EventArgs e)
        {
            txtBossName.Enabled = rdbDefeatBoss.Checked;
        }
    }
}
