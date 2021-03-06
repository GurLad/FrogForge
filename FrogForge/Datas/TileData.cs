﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class TileData : NamedData
    {
        [System.Text.Json.Serialization.JsonIgnore]
        public PalettedImage Image { get; set; }
        public int MoveCost { get; set; }
        public int ArmorMod { get; set; }
        public int Palette { get; set; }
        public bool High { get; set; }

        public TileData()
        {
            Image = null;
            MoveCost = Palette = 1;
        }

        public TileData(Image image, int moveCost, int armorMod, int palette, bool high, string name)
        {
            Image = new PalettedImage(image);
            MoveCost = moveCost;
            ArmorMod = armorMod;
            Palette = palette;
            High = high;
            Name = name;
        }

        public TileData Clone()
        {
            return new TileData(Image.Target, MoveCost, ArmorMod, Palette, High, Name);
        }
    }
}
