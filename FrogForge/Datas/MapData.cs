using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class MapData : NamedData
    {
        public string Tiles { get; set; }
        public List<Unit> Units { get; set; }
        public List<MapEventData> MapEvents { get; set; } = new List<MapEventData>();
        public string Tileset { get; set; }
        public int LevelNumber { get; set; }
        public string Objective { get; set; }
    }
}
