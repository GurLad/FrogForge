using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace FrogForge.Datas
{
    public class LevelMetadata : NamedData
    {
        public TeamData[] TeamDatas { get; set; } = new TeamData[3];
        public string MusicName { get; set; }
        public Palette Palette4 { get; set; }
        public bool[] Alliances { get; set; }
        public List<UnitReplacementData> UnitReplacements { get; set; }

        public LevelMetadata(string name)
        {
            Name = name;
            for (int i = 0; i < 3; i++)
            {
                TeamDatas[i] = new TeamData("", Palette.BasePalette, true, PortraitLoadingMode.Name, new AIPriorities(0, 0, 0));
            }
            MusicName = "";
            Palette4 = Palette.BasePalette;
            Alliances = new bool[3];
            UnitReplacements = new List<UnitReplacementData>();
        }

        public List<Palette> GetPalettes()
        {
            List<Palette> result = TeamDatas.Select(b => b.Palette).ToList();
            result.Add(Palette4);
            return result;
        }

        public void LoadImages(FilesController workingDirectory)
        {
            for (int i = 0; i < TeamDatas.Length; i++)
            {
                TeamDatas[i].LoadImages(workingDirectory);
            }
        }

        public void SaveImages(FilesController workingDirectory)
        {
            for (int i = 0; i < TeamDatas.Length; i++)
            {
                TeamDatas[i].SaveImages(workingDirectory);
            }
        }

        public LevelMetadata Clone()
        {
            return this.ToJson().JsonToObject<LevelMetadata>(); // Very lazy implementation
        }
    }
}

namespace FrogForge.UserControls
{
    public class LevelMetadataJSONBrowser : JSONBrowser<Datas.LevelMetadata> { }
}
