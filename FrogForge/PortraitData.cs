using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge
{
    public class PortraitData : NamedData
    {
        public Palette BackgroundColor = new Palette();
        public int ForegroundColorID;
        [System.Text.Json.Serialization.JsonIgnore]
        public PalettedImage Background { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public PalettedImage Foreground { get; set; }
    }

    public class PortraitJSONBrowser : JSONBrowser<PortraitData> { }
}
