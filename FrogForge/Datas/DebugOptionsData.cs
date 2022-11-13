using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class DebugOptionsData
    {
        public bool Enabled { get; set; }
        public bool SkipIntro { get; set; }
        public bool StartAtEndgame { get; set; }
        public int EndgameLevel { get; set; } = 1;
        public int ExtraLevels { get; set; }
        public List<string> Units { get; set; } = new List<string>();
        public bool UnlimitedMove { get; set; }
        public bool OPPlayers { get; set; }
        public string ForceConversation { get; set; }
        public string ForceMap { get; set; }
    }
}
