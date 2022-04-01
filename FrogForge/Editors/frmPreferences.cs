using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        private bool FinishedInit = false;

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
            nudZoomAmount.Value = (decimal)Preferences.Current.ZoomAmount;
            // Get all possible fonts
            List<FontFamily> fontFamilies;
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            // Get the array of FontFamily objects.
            fontFamilies = new List<FontFamily>(installedFontCollection.Families);
            cmbFontFamily.Items.AddRange(fontFamilies.ConvertAll(a => a.Name).ToArray());
            cmbFontFamily.SelectedIndex = Math.Max(0, fontFamilies.FindIndex(a => a.Name == Preferences.Current.FontFamily));
            this.ApplyPreferences();
            CenterToParent();
            FinishedInit = true;
        }

        private void cmbVoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FinishedInit)
            {
                string selectedVoice = cmbVoice.SelectedItem.ToString() == "None" ? "" : cmbVoice.SelectedItem.ToString();
                VoiceAssist.SelectVoice(selectedVoice);
                VoiceAssist.Say("Ready");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Preferences.Current.ZoomAmount = (double)nudZoomAmount.Value;
            Preferences.Current.DarkMode = ckbDarkMode.Checked;
            Preferences.Current.VoiceAssist = (cmbVoice.SelectedItem?.ToString() ?? "None") == "None" ? "" : cmbVoice.SelectedItem.ToString();
            Preferences.Current.FontFamily = cmbFontFamily.Text;
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

        private void cmbFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FinishedInit)
            {
                cmbFontFamily.Font = new Font(cmbFontFamily.Text, cmbFontFamily.Font.Size);
            }
        }
    }
}
