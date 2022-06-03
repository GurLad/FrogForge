using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    class GenericPortraitsGlobalData
    {
        public List<GenericCharacterVoice> GenericVoicesAndNames { get; set; } = new List<GenericCharacterVoice>();
        public List<Palette> GenericPossibleBackgroundColors { get; set; }
    }
}
