﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    class MapTile
    {
        public Point Pos { get; set; } = new Point(0, 0);
        public int TileID { get; set; }

        public MapTile()
        {
        }

        public MapTile(int tileID)
        {
            TileID = tileID;
        }
    }
}
