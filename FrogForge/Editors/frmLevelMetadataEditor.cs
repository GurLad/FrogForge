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

namespace FrogForge.Editors
{
    public partial class frmLevelMetadataEditor : frmBaseEditor
    {
        private static int[] PageWidths { get; } = new int[] { 793, 596 };
        private TeamPanel[] TeamDatas = new TeamPanel[3];
        private string _currentLevel;
        private string CurrentLevel
        {
            get
            {
                return _currentLevel;
            }
            set
            {
                _currentLevel = value == "0" ? "Default" : value;
                lblEditing.Text = "Editing: " + _currentLevel;
            }
        }

        public frmLevelMetadataEditor()
        {
            InitializeComponent();
            BaseName = Text;
        }

        private void frmLevelMetadataEditor_Load(object sender, EventArgs e)
        {
            // Generate team panels
            int baseX = 0, baseY = 0, offset = 346 - 138;
            for (int i = 0; i < 3; i++)
            {
                TeamDatas[i] = new TeamPanel();
                TeamDatas[i].Left = baseX + offset * i;
                TeamDatas[i].Top = baseY;
                TeamDatas[i].Init(this, dlgOpen, pltPalette4);
                pnlTeams.Controls.Add(TeamDatas[i]);
            }
            // Dirty
            txtMusicName.TextChanged += DirtyFunc;
            ckbAllies12.CheckedChanged += DirtyFunc;
            ckbAllies13.CheckedChanged += DirtyFunc;
            ckbAllies23.CheckedChanged += DirtyFunc;
            // Init stuff
            lstLevels.Init(this, () => lstLevels.Data[0].Clone(), LevelMetadataFromUI, LevelMetadataToUI, "LevelMetadata");
            lstUnitReplacements.Init(this, () => new UnitReplacementData(), () => new UnitReplacementPanel(), a => a.Init(this), false);
            pltPalette4.Init(this, p =>
            {
                for (int i = 0; i < 3; i++)
                {
                    TeamDatas[i].UpdatePalette4(p);
                }
            });
            // Load default
            if (lstLevels.Items.Count == 0)
            {
                lstLevels.Data.Add(new LevelMetadata("Default"));
                lstLevels.Save(CurrentLevel = "Default");
            }
            this.ApplyPreferences();
            LevelMetadataToUI(lstLevels.Data[0]);
            lstLevels.SelectedIndex = 0;
        }

        private LevelMetadata LevelMetadataFromUI(LevelMetadata data)
        {
            for (int i = 0; i < 3; i++)
            {
                data.TeamDatas[i] = TeamDatas[i].Data;
            }
            data.MusicName = txtMusicName.Text;
            data.Palette4 = pltPalette4.Data;
            data.Alliances = new bool[] { ckbAllies12.Checked, ckbAllies13.Checked, ckbAllies23.Checked };
            data.UnitReplacements = lstUnitReplacements.Datas;
            data.Name = CurrentLevel;
            data.SaveImages(WorkingDirectory);
            CurrentFile = data.Name;
            Dirty = false;
            return data;
        }

        private void LevelMetadataToUI(LevelMetadata data)
        {
            data.LoadImages(WorkingDirectory);
            for (int i = 0; i < 3; i++)
            {
                TeamDatas[i].Data = data.TeamDatas[i];
            }
            txtMusicName.Text = data.MusicName;
            pltPalette4.Data = data.Palette4;
            ckbAllies12.Checked = data.Alliances[0];
            ckbAllies13.Checked = data.Alliances[1];
            ckbAllies23.Checked = data.Alliances[2];
            lstUnitReplacements.Datas = data.UnitReplacements;
            CurrentLevel = data.Name;
            CurrentFile = data.Name;
            Dirty = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lstLevels.Save(CurrentLevel);
        }

        private void frmLevelMetadataEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Save data
            lstLevels.SaveToFile();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lstLevels.New();
            CurrentLevel = lstLevels.Data.Count.ToString();
            lstLevels.Save(CurrentLevel);
            lstLevels.SelectedIndex = lstLevels.Data.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstLevels.Data.Count > 2)
            {
                lstLevels.SelectedIndex = lstLevels.Data.Count - 1;
                lstLevels.Remove();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string theLevel = CurrentLevel;
            lstLevels.New();
            CurrentLevel = theLevel;
            Dirty = true;
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

        private void tbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            Width = PageWidths[tbcMain.SelectedIndex];
            this.ResizeByZoom(false, y: false);
            CurrentFile = "";
        }
    }
}
