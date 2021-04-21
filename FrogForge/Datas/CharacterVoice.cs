using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public enum VoiceType { Square50, Square25, Square12, Triangle }
    public class CharacterVoice
    {
        public VoiceType VoiceType { get; set; } = VoiceType.Square50;
        public float Pitch { get; set; } = 1;
    }
}
