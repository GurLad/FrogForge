using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class GenericCharacterVoice
    {
        public string Names { get; set; }
        public List<VoiceType> AvailableVoiceTypes { get; set; } = new List<VoiceType>();
        public UnityVector2 PitchRange { get; set; } = new UnityVector2(1, 1);

        public GenericCharacterVoice() { }

        public GenericCharacterVoice(string names, List<VoiceType> availableVoiceTypes, UnityVector2 pitchRange)
        {
            Names = names;
            AvailableVoiceTypes = availableVoiceTypes;
            PitchRange = pitchRange;
        }
    }
}

namespace FrogForge.UserControls
{
    public partial class GenericCharacterVoiceEditor : DataEditor<Datas.GenericCharacterVoice>
    {
        public override Datas.GenericCharacterVoice Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public partial class GenericCharacterVoiceListEditor : ListDataEditor<GenericCharacterVoicePanel, Datas.GenericCharacterVoice> { }
}