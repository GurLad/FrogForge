using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class BasePortraitData : DisplayNamedData
    {
        [System.Text.Json.Serialization.JsonIgnore]
        public PalettedImage Background { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public PalettedImage Foreground { get; set; }
    }
}
