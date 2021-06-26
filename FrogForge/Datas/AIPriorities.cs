using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public enum AICautionLevel { None = 0, NoDamage = 1, Suicide = 2, LittleDamage = 4 }

    public class AIPriorities
    {
        public float TrueDamageWeight { get; set; }
        public float RelativeDamageWeight { get; set; }
        public float SurvivalWeight { get; set; }
        public AICautionLevel CautionLevel { get; set; }

        public AIPriorities(float trueDamageWeight, float relativeDamageWeight, float survivalWeight)
        {
            TrueDamageWeight = trueDamageWeight;
            RelativeDamageWeight = relativeDamageWeight;
            SurvivalWeight = survivalWeight;
        }
    }
}

namespace FrogForge.UserControls
{
    public partial class AIPrioritiesEditor : DataEditor<Datas.AIPriorities>
    {
        public override Datas.AIPriorities Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}