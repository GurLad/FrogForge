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
    public partial class frmPreferences : Form
    {
        private FilesController DataDirectory;

        public frmPreferences(FilesController dataDirectory)
        {
            InitializeComponent();
            DataDirectory = dataDirectory;
        }

        private void frmPreferences_Load(object sender, EventArgs e)
        {
            if (Preferences.Current.VoiceAssistAvailable)
            {
                grpVoice.Visible = true;
                cmbVoice.Items.Add("None");
                cmbVoice.Items.AddRange(VoiceAssist.GetAvailableVoices());
                cmbVoice.SelectedItem = string.IsNullOrEmpty(Preferences.Current.VoiceAssist) ? "None" : Preferences.Current.VoiceAssist;
                VoiceAssist.Say("Ready");
            }
            else
            {
                Height -= 46;
            }
            ckbDarkMode.Checked = Preferences.Current.DarkMode;
            ckbZoomMode.Checked = Preferences.Current.ZoomAmount > 1;
        }

        private void cmbVoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVoice = cmbVoice.SelectedItem.ToString() == "None" ? "" : cmbVoice.SelectedItem.ToString();
            VoiceAssist.SelectVoice(selectedVoice);
            VoiceAssist.Say("Ready");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Preferences.Current.ZoomAmount = ckbZoomMode.Checked ? 1.5 : 1;
            Preferences.Current.DarkMode = ckbDarkMode.Checked;
            Preferences.Current.VoiceAssist = (cmbVoice.SelectedItem?.ToString() ?? "None") == "None" ? "" : cmbVoice.SelectedItem.ToString();
            DataDirectory.SaveFile("Preferences", Preferences.Current.ToJson(), ".json");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPreferences_FormClosed(object sender, FormClosedEventArgs e)
        {
            VoiceAssist.SelectVoice(Preferences.Current.VoiceAssist);
        }
    }
}
