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
        public Palette BGPalette1 { get; set; }
        public Palette BGPalette2 { get; set; }
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