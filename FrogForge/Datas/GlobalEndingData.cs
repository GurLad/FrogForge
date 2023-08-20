using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class GlobalEndingData
    {
        public string Requirements { get; set; }
        public string Text { get; set; }

        public GlobalEndingData() { }

        public GlobalEndingData(string requirements, string text)
        {
            Requirements = requirements;
            Text = text;
        }
    }
}

namespace FrogForge.UserControls
{
    public partial class GlobalEndingEditor : DataEditor<Datas.GlobalEndingData>
    {
        public override Datas.GlobalEndingData Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public partial class GlobalEndingsListEditor : ListDataEditor<GlobalEndingPanel, Datas.GlobalEndingData> { }
}
