using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge.UserControls
{
    public abstract class DataEditor<T> : UserControl where T : class
    {
        public abstract T Data { get; set; }
    }
}
