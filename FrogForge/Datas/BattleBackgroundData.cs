using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class BattleBackgroundData : NamedData
    {
        [System.Text.Json.Serialization.JsonIgnore]
        public PartialPalettedImage Layer1 { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public PartialPalettedImage Layer2 { get; set; }

        [JsonConstructorAttribute]
        public BattleBackgroundData(string name)
        {
            Layer1 = null;
            Layer2 = null;
            Name = name;
        }

        public BattleBackgroundData(string name, PartialPalettedImage image1, PartialPalettedImage image2)
        {
            Layer1 = image1;
            Layer2 = image2;
            Name = name;
        }
    }
}

namespace FrogForge.UserControls
{
    public partial class BattleBackgroundEditor : DataEditor<Datas.BattleBackgroundData>
    {
        public override Datas.BattleBackgroundData Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public partial class BattleBackgroundsListEditor : ListDataEditor<BattleBackgroundPanel, Datas.BattleBackgroundData> { }
}