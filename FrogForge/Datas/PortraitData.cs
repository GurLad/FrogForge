using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class PortraitData : BasePortraitData
    {
        public Palette BackgroundColor { get; set; } = new Palette();
        public int ForegroundColorID { get; set; }
    }
}

namespace FrogForge.UserControls
{
    public class PortraitJSONBrowser : JSONBrowser<Datas.PortraitData> { }
}
