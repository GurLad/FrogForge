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
            int baseX = 6, baseY = 19, offset = 346 - 138;
            for (int i = 0; i < 3; i++)
            {
                TeamDatas[i] = new TeamPanel();
                TeamDatas[i].Left = baseX + offset * i;
                TeamDatas[i].Top = baseY;
                TeamDatas[i].Init(this);
                grpTeams.Controls.Add(TeamDatas[i]);
            }
            // Dirty
            txtMusicName.TextChanged += DirtyFunc;
            // Init stuff
            lstLevels.Init(this, () => lstLevels.Data[0].ToJson().JsonToObject<LevelMetadata>(), LevelMetadataFromUI, LevelMetadataToUI, "LevelMetadata");
            // Load default
            if (lstLevels.Items.Count == 0)
            {
                lstLevels.Data.Add(new LevelMetadata("Default"));
                lstLevels.Save(CurrentLevel = "Default");
            }
            LevelMetadataToUI(lstLevels.Data[0]);
        }

        private LevelMetadata LevelMetadataFromUI(LevelMetadata data)
        {
            for (int i = 0; i < 3; i++)
            {
                data.TeamDatas[i] = TeamDatas[i].Data;
            }
            data.MusicName = txtMusicName.Text;
            data.Name = CurrentLevel;
            CurrentFile = data.Name;
            Dirty = false;
            return data;
        }

        private void LevelMetadataToUI(LevelMetadata data)
        {
            for (int i = 0; i < 3; i++)
            {
                TeamDatas[i].Data = data.TeamDatas[i];
            }
            txtMusicName.Text = data.MusicName;
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstLevels.SelectedIndex = lstLevels.Data.Count - 1;
            lstLevels.Remove();
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
    }
}
