using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class UnitData : DisplayNamedData
    {
        public string Class { get; set; }
        public Inclination Inclination { get; set; }
        public Growths Growths { get; set; }
        public string DeathQuote { get; set; } = "";
    }
}

namespace FrogForge.UserControls
{
    public class UnitJSONBrowser : JSONBrowser<Datas.UnitData> { }
}
