using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public enum PortraitLoadingMode { Name, Team, Generic }

    public class TeamData : NamedData
    {
        public Palette Palette { get; set; }
        public bool PlayerControlled { get; set; } // Functionality TBA
        public PortraitLoadingMode PortraitLoadingMode { get; set; }
        public AIPriorities AI { get; set; }

        public TeamData(string name, Palette palette, bool playerControlled, PortraitLoadingMode portraitLoadingMode, AIPriorities aI)
        {
            Name = name;
            Palette = palette;
            PlayerControlled = playerControlled;
            PortraitLoadingMode = portraitLoadingMode;
            AI = aI;
        }
    }
}

namespace FrogForge.UserControls
{
    public partial class TeamEditor : DataEditor<Datas.TeamData>
    {
        public override Datas.TeamData Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}