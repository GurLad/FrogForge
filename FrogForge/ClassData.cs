using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Image MapSprite { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
