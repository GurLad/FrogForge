using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace FrogForge.Datas
{
    public class TilesetData : NamedData
    {
        public Palette Palette1 { get; set; } = Palette.BasePalette;
        public Palette Palette2 { get; set; } = Palette.BasePalette;
        public List<TileData> Tiles { get; set; } = new List<TileData>();
        public List<BattleBackgroundData> BattleBackgrounds { get; set; } = new List<BattleBackgroundData>();
        public float SpeedOverride { get; set; } = 1;
        // TBA - battle backgrounds

        public void LoadImages(FilesController workingDirectory)
        {
            workingDirectory.CreateDirectory(@"Images\Tilesets\" + Name);
            workingDirectory.CreateDirectory(@"Images\BattleBackgrounds\" + Name);
            for (int i = 0; i < Tiles.Count; i++)
            {
                Tiles[i].Image = Tiles[i].Image ??
                    PalettedImage.FromFile(workingDirectory, @"Tilesets\" + Name + @"\" + i);
            }
            for (int i = 0; i < BattleBackgrounds.Count; i++)
            {
                BattleBackgrounds[i].Layer1 = BattleBackgrounds[i].Layer1 ??
                    PartialPalettedImage.FromFile(workingDirectory, @"BattleBackgrounds\" + Name + @"\" + BattleBackgrounds[i].Name + "1");
                BattleBackgrounds[i].Layer2 = BattleBackgrounds[i].Layer2 ??
                    PartialPalettedImage.FromFile(workingDirectory, @"BattleBackgrounds\" + Name + @"\" + BattleBackgrounds[i].Name + "2");
            }
        }
    }
}

namespace FrogForge.UserControls
{
    public class TilemapJSONBrowser : JSONBrowser<Datas.TilesetData> { }
}
