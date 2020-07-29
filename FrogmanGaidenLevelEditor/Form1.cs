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

namespace FrogmanGaidenLevelEditor
{
    public enum Team { Player, Monster, Guard }
    public partial class Form1 : Form
    {
        private Tile[,] Tiles;
        private Tile CurrentSelected = new Tile();
        private List<Image> PossibleImages;
        private FilesController Files = new FilesController("Data");
        private Label[,] Renderers;
        private Point Size = new Point(16, 15);
        private List<Unit> Units = new List<Unit>();
        private Unit Placing = null;
        private Label PreviousHover = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load images
            Files.DefultFileFormat = ".level";
            string[] files = Files.AllFiles(false, false, @"\Images");
            cmbLevelName.Items.AddRange(Files.AllFiles(false, false));
            //Tiles
            PossibleImages = new List<Image>();
            int i = 0;
            while (files.Contains(i.ToString()))
            {
                PossibleImages.Add(Files.LoadImage(i.ToString(), null, false));
                i++;
            }
            for (int j = 0; j < PossibleImages.Count; j++)
            {
                Label tileButton = new Label();
                tileButton.Width = 16;
                tileButton.Height = 16;
                tileButton.Left = 16 * (j % 5);
                tileButton.Top = 16 * (j / 5);
                tileButton.Image = PossibleImages[j];
                tileButton.Tag = j;
                tileButton.Click += BtnTileButton_Click;
                pnlPossibleTiles.Controls.Add(tileButton);
            }
            //End load images
            //Generate UI
            UpdatePreview();
            Tiles = new Tile[Size.X, Size.Y];
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
                    pnlUI.Enabled = true;
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
            result = result.Substring(0, result.Length - 1);
            Files.SaveFile(cmbLevelName.Text, result);
            if (!cmbLevelName.Items.Contains(cmbLevelName.Text))
            {
                cmbLevelName.Items.Add(cmbLevelName.Text);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            Tiles = null;
            string[] result = Files.LoadFile(cmbLevelName.Text).Split('\n');
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
            for (int i = 0; i < rows.Length; i++)
            {
                Units.Add(new Unit(rows[i]));
            }
            Render();
        }

        private void UpdatePreview()
        {
            RenderPictureboxFromTile(picPreview, CurrentSelected);
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            Units.Add(Placing = new Unit((Team)Enum.Parse(typeof(Team), cmbUnitTeam.Text), (int)nudLevel.Value, txtClass.Text));
            CurrentSelected = null;
            picPreview.BackgroundImage = null;
            pnlUI.Enabled = false;
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
    }
}
