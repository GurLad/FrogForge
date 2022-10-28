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
        public enum Layers { None = 0, L1 = 1, L2 = 2, Unkown = -1 }
        [System.Text.Json.Serialization.JsonIgnore]
        public PartialPalettedImage Layer1 { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public PartialPalettedImage Layer2 { get; set; }
        private Layers _hasLayers;
        public Layers HasLayers
        {
            get
            {
                return _hasLayers != Layers.Unkown ? _hasLayers : (Layer1 != null ? Layers.L1 : Layers.None) | (Layer2 != null ? Layers.L2 : Layers.None);
            }
            set
            {
                _hasLayers = value;
            }
        }

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