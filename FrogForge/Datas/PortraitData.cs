using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace FrogForge.Datas
{
    public class PortraitData : BasePortraitData
    {
        public Palette BackgroundColor { get; set; } = new Palette();
        public int ForegroundColorID { get; set; }
        public int AccentColor { get; set; }
        public CharacterVoice Voice { get; set; } = new CharacterVoice();

        public void LoadImages(FilesController workingDirectory)
        {
            workingDirectory.CreateDirectory(@"Images\Portraits\" + Name);
            Background = Background ?? new PalettedImage(workingDirectory.LoadImage(@"Portraits\" + Name + @"\B"));
            Foreground = Foreground ?? new PalettedImage(workingDirectory.LoadImage(@"Portraits\" + Name + @"\F"));
        }

        public void ApplyPalettes()
        {
            Background.CurrentPalette = BackgroundColor;
            Foreground.CurrentPalette = Palette.BaseSpritePalettes[ForegroundColorID];
        }
    }
}

namespace FrogForge.UserControls
{
    public class PortraitJSONBrowser : JSONBrowser<Datas.PortraitData> { }
}
