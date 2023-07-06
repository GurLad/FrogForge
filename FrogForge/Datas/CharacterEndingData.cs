using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class CharacterEndingData : NamedData
    {
        public List<EndingCardData> EndingCards { get; set; } = new List<EndingCardData>();
    }
}

namespace FrogForge.UserControls
{
    public class CharacterEndingJSONBrowser : JSONBrowser<Datas.CharacterEndingData> { }
}
