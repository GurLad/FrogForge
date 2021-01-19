using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge
{
    class Weapon
    {
        public string Name { get; set; }
        public int HitStat { get; set; }
        public int Damage { get; set; }
        public int Weight { get; set; }
        public int Range { get; set; } = 1; // Only abilities can modify
    }
}
