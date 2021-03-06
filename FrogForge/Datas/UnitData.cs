﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class UnitData : NamedData
    {
        public string Class { get; set; }
        public Inclination Inclination { get; set; }
        public Growths Growths { get; set; }
    }
}

namespace FrogForge.UserControls
{
    public class UnitJSONBrowser : JSONBrowser<Datas.UnitData> { }
}
