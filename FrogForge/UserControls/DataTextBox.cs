using FrogForge.Editors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogForge.UserControls
{
    public partial class DataTextBox : StringEditor
    {
        public override string Data { get => txtData.Text; set => txtData.Text = value; }

        public void Init(frmBaseEditor editor)
        {
            if (editor != null)
            {
                txtData.TextChanged += (sender, e) => editor.Dirty = true;
            }
        }

        public DataTextBox()
        {
            InitializeComponent();
        }
    }
}

namespace FrogForge.UserControls
{
    public partial class StringEditor : DataEditor<string>
    {
        public override string Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public partial class StringListEditor : ListDataEditor<DataTextBox, string> { }
}