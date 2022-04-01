using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge
{
    public class Preferences
    {
        public static Preferences Current = new Preferences();

        public double ZoomAmount { get; set; }
        public bool DarkMode { get; set; }
        public Color DarkModeBackColor { get; } = Color.FromArgb(25, 25, 25);
        public bool VoiceAssistAvailable { get; set; }
        public string VoiceAssist { get; set; }
        public string FontFamily { get; set; } = "Microsoft Sans Serif";
    }
}
