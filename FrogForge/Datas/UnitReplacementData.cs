using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class UnitReplacementData : NamedData
    {
        public List<string> ReplacedBy { get; set; } = new List<string>();

        public UnitReplacementData(string name, List<string> replacedBy)
        {
            Name = name;
            ReplacedBy = replacedBy;
        }

        public UnitReplacementData()
        {

        }
    }
}

namespace FrogForge.UserControls
{
    public partial class UnitReplacementEditor : DataEditor<Datas.UnitReplacementData>
    {
        public override Datas.UnitReplacementData Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public partial class UnitReplacementListEditor : ListDataEditor<UnitReplacementPanel, Datas.UnitReplacementData> { }
}
