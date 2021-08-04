using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class MapEventData
    {
        public string Requirements { get; set; } = "";
        public string Event { get; set; } = "";

        public MapEventData(string requirements, string @event)
        {
            Requirements = requirements;
            Event = @event;
        }

        public MapEventData() {}
    }
}

namespace FrogForge.UserControls
{
    public partial class MapEventEditor : DataEditor<Datas.MapEventData>
    {
        public override Datas.MapEventData Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public partial class MapEventListEditor : ListDataEditor<MapEventPanel, Datas.MapEventData> { }
}
