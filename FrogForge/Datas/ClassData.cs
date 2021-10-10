using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace FrogForge.Datas
{
    public enum Inclination { Physical, Technical, Skillful } // Bad names
    public enum StatNames { Str, End, Pir, Arm, Pre, Eva }
    public enum BattleAnimationMode { Walk, Projectile, Teleport }

    public class ClassData : NamedData
    {
        public bool Flies { get; set; }
        public Inclination Inclination { get; set; }
        public Growths Growths { get; set; }
        public Weapon Weapon { get; set; } = new Weapon();
        [System.Text.Json.Serialization.JsonIgnore]
        public PalettedImage MapSprite { get; set; }
        public List<BattleAnimationData> BattleAnimations { get; set; } = new List<BattleAnimationData>();
        public BattleAnimationMode BattleAnimationModeMelee { get; set; }
        public BattleAnimationMode BattleAnimationModeRanged { get; set; }

        public PalettedImage LoadSprite(FilesController files)
        {
            return MapSprite ?? (MapSprite = PalettedImage.FromFile(files, @"ClassMapSprites\" + Name));
        }
    }
}

namespace FrogForge.UserControls
{
    public class ClassJSONBrowser : JSONBrowser<Datas.ClassData> { }
}
