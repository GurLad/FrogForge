using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge.Paint
{
    public class DrawingPanel : Panel
    {
        private PalettedImage image;
        public PalettedImage Image
        {
            get => image;
            set
            {
                BackgroundImage = (image = value)?.Target ?? null;
            }
        }

        public void Render()
        {
            BackgroundImage = null;
            BackgroundImage = Image.Target;
        }
    }
}
