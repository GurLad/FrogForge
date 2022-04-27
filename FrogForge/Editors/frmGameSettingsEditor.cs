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
    public partial class frmGameSettingsEditor : Form
    {
        private FilesController WorkingDirectory;
        private GameSettingsData Data;

        public frmGameSettingsEditor(FilesController workingDirectory)
        {
            InitializeComponent();
            WorkingDirectory = workingDirectory;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).Tag.ToString().Replace(@"\n", "\n"));
        }

        private void frmGameSettingsEditor_Load(object sender, EventArgs e)
        {
            VoiceAssist.Say("Ready");
            // Load game settings
            string json = WorkingDirectory.LoadFile("GameSettings", "", ".json");
            Data = ((json == "" ? null : json)?.JsonToObject<GameSettingsData>()) ?? new GameSettingsData();
            txtModName.Text = Data.ModName;
            txtModDescription.Text = Data.ModDescription;
            txtMainCharacterName.Text = Data.MainCharacterName;
            switch (Data.PlayerTeam)
            {
                case 0:
                    rdbPlayerTeam1.Checked = true;
                    break;
                case 1:
                    rdbPlayerTeam2.Checked = true;
                    break;
                case 2:
                    rdbPlayerTeam3.Checked = true;
                    break;
                default:
                    MessageBox.Show("Invalid player team!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            this.ApplyPreferences();
            CenterToParent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Data.ModName = txtModName.Text;
            Data.ModDescription = txtModDescription.Text;
            Data.MainCharacterName = txtMainCharacterName.Text;
            Data.PlayerTeam = rdbPlayerTeam1.Checked ? 0 : (rdbPlayerTeam2.Checked ? 1 : 2);
            WorkingDirectory.SaveFile("GameSettings", Data.ToJson(), ".json");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
