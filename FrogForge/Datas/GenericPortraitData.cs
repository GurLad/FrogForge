using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class GenericPortraitData : BasePortraitData
    {
        public string tags { get; set; } // To match Unity's casing (I'm not sure whether it's case-sensitive, just in case)
        public List<int> VoiceTypes { get; set; } = new List<int>();
    }
}

namespace FrogForge.UserControls
{
    public class GenericPortraitJSONBrowser : JSONBrowser<Datas.GenericPortraitData> { }
}
