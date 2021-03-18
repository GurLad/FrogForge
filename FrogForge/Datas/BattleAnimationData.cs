using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class BattleAnimationData : NamedData
    {
        [System.Text.Json.Serialization.JsonIgnore]
        public PalettedImage Image { get; set; }

        public BattleAnimationData(string name = "", PalettedImage image = null)
        {
            Name = name;
            Image = image;
        }
    }
}

namespace FrogForge.UserControls
{
    public partial class BattleAnimationEditor : DataEditor<Datas.BattleAnimationData>
    {
        public override Datas.BattleAnimationData Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public partial class BattleAnimationsListEditor : ListDataEditor<BattleAnimationPanel, Datas.BattleAnimationData> { }
}