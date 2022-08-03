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
        public BADWalk WalkExtraData { get; set; } = new BADWalk();
        public BADProjectile ProjectileExtraData { get; set; } = new BADProjectile();
        public BADTeleport TeleportExtraData { get; set; } = new BADTeleport();
        public UnityPoint ProjectilePos { get => ProjectileExtraData.Pos; set => ProjectileExtraData.Pos = value; }

        public PalettedImage LoadSprite(FilesController files)
        {
            return MapSprite ?? (MapSprite = PalettedImage.FromFile(files, @"ClassMapSprites\" + Name));
        }

        public PalettedImage LoadProjectile(FilesController files)
        {
            return ProjectileExtraData.Image ?? (ProjectileExtraData.Image = PalettedImage.FromFile(files, @"ClassBattleAnimations\_Projectiles\" + Name));
        }
    }

    public class BADWalk
    {
        public const float DEFAULT_SPEED = 2;
        public float Speed { get; set; } = -1;
        public bool CustomSpeed
        {
            get
            {
                return Speed >= 1;
            }
            set
            {
                if (!value)
                {
                    Speed = -1;
                }
                else if (value && Speed < 1)
                {
                    Speed = DEFAULT_SPEED;
                }
            }
        }
    }

    public class BADProjectile
    {
        [System.Text.Json.Serialization.JsonIgnore]
        public PalettedImage Image { get; set; }
        public UnityPoint Pos { get; set; } = new UnityPoint(0, 0);
    }

    public class BADTeleport
    {
        public bool Backstab { get; set; } = true;
    }
}

namespace FrogForge.UserControls
{
    public class ClassJSONBrowser : JSONBrowser<Datas.ClassData> { }
}
