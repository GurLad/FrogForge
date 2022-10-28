using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace FrogForge.Datas
{
    public class CGData : NamedData
    {
        public enum Layers { None = 0, L1 = 1, L2 = 2, L3 = 4, L4 = 8, Unkown = -1 }
        public Palette BGPalette1 { get; set; } = new Palette();
        public Palette BGPalette2 { get; set; } = new Palette();
        public int FGPalette1 { get; set; }
        public int FGPalette2 { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public PartialPalettedImage BGImage1 { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public PartialPalettedImage BGImage2 { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public PalettedImage FGImage1 { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public PalettedImage FGImage2 { get; set; }
        private Layers _hasLayers;
        public Layers HasLayers
        {
            get
            {
                return _hasLayers != Layers.Unkown ? _hasLayers :
                    (BGImage1 != null ? Layers.L1 : Layers.None) |
                    (BGImage2 != null ? Layers.L2 : Layers.None) |
                    (FGImage1 != null ? Layers.L3 : Layers.None) |
                    (FGImage2 != null ? Layers.L4 : Layers.None);
            }
            set
            {
                _hasLayers = value;
            }
        }

        public void LoadImages(FilesController workingDirectory)
        {
            workingDirectory.CreateDirectory(@"Images\CGs\" + Name);
            BGImage1 = BGImage1 ?? PartialPalettedImage.FromFile(workingDirectory, @"CGs\" + Name + @"\BG1");
            BGImage2 = BGImage2 ?? PartialPalettedImage.FromFile(workingDirectory, @"CGs\" + Name + @"\BG2");
            FGImage1 = FGImage1 ?? PartialPalettedImage.FromFile(workingDirectory, @"CGs\" + Name + @"\FG1");
            FGImage2 = FGImage2 ?? PartialPalettedImage.FromFile(workingDirectory, @"CGs\" + Name + @"\FG2");
        }
    }
}

namespace FrogForge.UserControls
{
    public class CGJSONBrowser : JSONBrowser<Datas.CGData> { }
}