using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace FrogForge.Datas
{
    public enum PortraitLoadingMode { Name, Team, Generic }

    public class TeamData : NamedData
    {
        public Palette Palette { get; set; }
        public bool PlayerControlled { get; set; } // Functionality TBA
        public PortraitLoadingMode PortraitLoadingMode { get; set; }
        public AIPriorities AI { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public PalettedImage BaseSymbol { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public PalettedImage MovedSymbol { get; set; }

        public TeamData(string name, Palette palette, bool playerControlled, PortraitLoadingMode portraitLoadingMode, AIPriorities aI, PalettedImage baseSymbol = null, PalettedImage movedSymbol = null)
        {
            Name = name;
            Palette = palette;
            PlayerControlled = playerControlled;
            PortraitLoadingMode = portraitLoadingMode;
            AI = aI;
            BaseSymbol = baseSymbol;
            MovedSymbol = movedSymbol;
        }

        public void LoadImages(FilesController workingDirectory)
        {
            workingDirectory.CreateDirectory(@"Images\TeamSymbols\" + Name);
            // Always reload, as teams with the same name use the same symbol
            BaseSymbol = new PalettedImage(workingDirectory.LoadImage(@"TeamSymbols\" + Name + @"\B") ?? new Bitmap(8, 8));
            MovedSymbol = new PalettedImage(workingDirectory.LoadImage(@"TeamSymbols\" + Name + @"\M") ?? new Bitmap(8, 8));
        }

        public void SaveImages(FilesController workingDirectory)
        {
            workingDirectory.CreateDirectory(@"Images\TeamSymbols\" + Name);
            if (BaseSymbol != null)
            {
                workingDirectory.SaveImage(@"TeamSymbols\" + Name + @"\B", BaseSymbol.ToBitmap(Palette.BasePalette));
            }
            if (MovedSymbol != null)
            {
                workingDirectory.SaveImage(@"TeamSymbols\" + Name + @"\M", MovedSymbol.ToBitmap(Palette.BasePalette));
            }
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