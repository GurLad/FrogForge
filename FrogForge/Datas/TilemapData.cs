using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class TilemapData : NamedData
    {
        public Palette Palette1 { get; set; } = Palette.BasePalette;
        public Palette Palette2 { get; set; } = Palette.BasePalette;
        public List<TileData> Tiles { get; set; } = new List<TileData>();
        // TBA - battle backgrounds
    }
}

namespace FrogForge.UserControls
{
    public class TilemapJSONBrowser : JSONBrowser<Datas.TilemapData> { }
}
