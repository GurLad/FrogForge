using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class LevelMetadata : NamedData
    {
        public TeamData[] TeamDatas { get; set; } = new TeamData[3];
        public string MusicName { get; set; }

        public LevelMetadata(string name)
        {
            Name = name;
            for (int i = 0; i < 3; i++)
            {
                TeamDatas[i] = new TeamData("", Palette.BasePalette, true, PortraitLoadingMode.Name, new AIPriorities(0, 0, 0));
            }
        }
    }
}

namespace FrogForge.UserControls
{
    public class LevelMetadataJSONBrowser : JSONBrowser<Datas.LevelMetadata> { }
}
