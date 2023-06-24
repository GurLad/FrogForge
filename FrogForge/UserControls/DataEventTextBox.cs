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
    public partial class DataEventTextBox : StringEditor
    {
        public override string Data { get => txtData.Text; set => txtData.Text = value; }

        public void Init(Utils.FilesController dataDirectory, frmBaseEditor editor)
        {
            if (editor != null)
            {
                txtData.Init(dataDirectory, editor);
            }
        }

        public DataEventTextBox()
        {
            InitializeComponent();
        }
    }

    public partial class EventListEditor : ListDataEditor<DataEventTextBox, string> { }
}
