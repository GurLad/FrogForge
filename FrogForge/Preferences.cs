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
        public UnityColor DarkModeBackColor { get; set; } = Color.FromArgb(25, 25, 25);
        public bool VoiceAssistAvailable { get; set; }
        public string VoiceAssist { get; set; }
    }
}
