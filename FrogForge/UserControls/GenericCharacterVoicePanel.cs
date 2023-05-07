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

namespace FrogForge.UserControls
{
    public partial class GenericCharacterVoicePanel : GenericCharacterVoiceEditor
    {
        public override GenericCharacterVoice Data
        {
            get
            {
                List<VoiceType> voiceTypes = new List<VoiceType>();
                if (ckbSquare12.Checked)
                {
                    voiceTypes.Add(VoiceType.Square12);
                }
                if (ckbSquare25.Checked)
                {
                    voiceTypes.Add(VoiceType.Square25);
                }
                if (ckbSquare50.Checked)
                {
                    voiceTypes.Add(VoiceType.Square50);
                }
                if (ckbTriangle.Checked)
                {
                    voiceTypes.Add(VoiceType.Triangle);
                }
                return new GenericCharacterVoice(txtInternalName.Text, txtNames.Text, voiceTypes, new UnityVector2(vpsMin.Pitch, vpsMax.Pitch));
            }
            set
            {
                ckbSquare12.Checked = value.AvailableVoiceTypes.Contains(VoiceType.Square12);
                ckbSquare25.Checked = value.AvailableVoiceTypes.Contains(VoiceType.Square25);
                ckbSquare50.Checked = value.AvailableVoiceTypes.Contains(VoiceType.Square50);
                ckbTriangle.Checked = value.AvailableVoiceTypes.Contains(VoiceType.Triangle);
                txtInternalName.Text = value.InternalName;
                txtNames.Text = value.Names;
                vpsMin.Pitch = value.PitchRange.x;
                vpsMax.Pitch = value.PitchRange.y;
            }
        }

        public GenericCharacterVoicePanel()
        {
            InitializeComponent();
        }

        public void Init()
        {
            // Wha?
        }
    }
}
