using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class TileData : NamedData
    {
        public PalettedImage Image { get; set; }
        public int MoveCost { get; set; }
        public int ArmorMod { get; set; }
        public int Palette { get; set; }
        public bool High { get; set; }
    }
}
