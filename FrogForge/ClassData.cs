using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace FrogForge
{
    public enum Inclination { Physical, Technical, Skillful } // Bad names
    public enum StatNames { Str, End, Pir, Arm, Pre, Eva }

    class ClassData
    {
        public string Name { get; set; }
        public bool Flies { get; set; }
        public Inclination Inclination { get; set; }
        public int[] Growths { get; set; } = new int[6];
        public Weapon Weapon { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public PalettedImage MapSprite { get; set; }
        public List<string> BattleAnimations { get; set; } = new List<string>();
        [System.Text.Json.Serialization.JsonIgnore]
        public List<PalettedImage> BattleAnimationImages { get; set; } = new List<PalettedImage>();

        public override string ToString()
        {
            return Name;
        }
        
        public PalettedImage LoadSprite(FilesController files)
        {
            return MapSprite ?? (MapSprite = PalettedImage.FromFile(files, @"ClassMapSprites\" + Name));
        }
    }
}
