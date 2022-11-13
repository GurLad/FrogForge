using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrogForge.Datas;
using FrogForge.UserControls;
using Utils;

namespace FrogForge.Editors
{
    public partial class frmDebugOptionsEditor : Form
    {
        private FilesController WorkingDirectory;
        private DebugOptionsData Data;

        public frmDebugOptionsEditor(FilesController workingDirectory)
        {
            InitializeComponent();
            WorkingDirectory = workingDirectory;
        }

        private void frmDebugOptionsEditor_Load(object sender, EventArgs e)
        {
            VoiceAssist.Say("Ready");
            // Init stuff
            this.ApplyPreferences();
            CenterToParent();
            lstStartingUnits.Init(null, () => "", () => new DataTextBox(), (a) => a.Init(null), false);
            // Load game settings
            string json = WorkingDirectory.LoadFile("DebugOptions", "", ".json");
            Data = ((json == "" ? null : json)?.JsonToObject<DebugOptionsData>()) ?? new DebugOptionsData();
            ckbEnabled.Checked = Data.Enabled;
            ckbSkipIntro.Checked = Data.SkipIntro;
            nudFirstLevel.Value = Data.EndgameLevel;
            txtForceConversation.Text = Data.ForceConversation;
            txtForceMap.Text = Data.ForceMap;
            lstStartingUnits.Datas = Data.Units;
            ckbUnlimitedMove.Checked = Data.UnlimitedMove;
            ckbOP.Checked = Data.OPPlayers;
            pnlAll.Enabled = ckbEnabled.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Data.Enabled = ckbEnabled.Checked;
            Data.SkipIntro = ckbSkipIntro.Checked;
            Data.EndgameLevel = (int)nudFirstLevel.Value;
            Data.ForceConversation = txtForceConversation.Text;
            Data.ForceMap = txtForceMap.Text;
            Data.Units = lstStartingUnits.Datas;
            Data.UnlimitedMove = ckbUnlimitedMove.Checked;
            Data.OPPlayers = ckbOP.Checked;
            WorkingDirectory.SaveFile("DebugOptions", Data.ToJson(), ".json");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ckbEnabled_CheckedChanged(object sender, EventArgs e)
        {
            pnlAll.Enabled = ckbEnabled.Checked;
        }
    }
}
