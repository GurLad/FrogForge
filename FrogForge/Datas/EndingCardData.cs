using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class EndingCardData
    {
        public string Requirements { get; set; }
        public string Title { get; set; }
        public string Card { get; set; }

        public EndingCardData() { }

        public EndingCardData(string requirements, string title, string card)
        {
            Requirements = requirements;
            Title = title;
            Card = card;
        }
    }
}

namespace FrogForge.UserControls
{
    public partial class EndingCardEditor : DataEditor<Datas.EndingCardData>
    {
        public override Datas.EndingCardData Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public partial class EndingCardsListEditor : ListDataEditor<EndingCardPanel, Datas.EndingCardData> { }
}
