using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class GenericPortraitData : NamedData
    {
        public string tags { get; set; } // To match Unity's casing (I'm not sure whether it's case-sensitive, just in case)
        public int VoiceType { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public PalettedImage Background { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public PalettedImage Foreground { get; set; }
    }
}

namespace FrogForge.UserControls
{
    public class GenericPortraitJSONBrowser : JSONBrowser<Datas.GenericPortraitData> { }
}
