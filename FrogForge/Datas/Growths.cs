using FrogForge.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class Growths
    {
        public int[] Values { get; set; } = new int[6];
    }
}

namespace FrogForge.UserControls
{
    public partial class GrowthsEditor : DataEditor<Growths>
    {
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public override Growths Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}