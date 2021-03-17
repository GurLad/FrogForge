using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class PortraitData : NamedData
    {
        public Palette BackgroundColor { get; set; } = new Palette();
        public int ForegroundColorID { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public PalettedImage Background { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public PalettedImage Foreground { get; set; }
    }
}

namespace FrogForge.UserControls
{
    public class PortraitJSONBrowser : JSONBrowser<Datas.PortraitData> { }
}
