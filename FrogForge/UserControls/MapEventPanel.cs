using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrogForge.Datas;
using Utils;
using FrogForge.Editors;

namespace FrogForge.UserControls
{
    public partial class MapEventPanel : MapEventEditor
    {
        public override MapEventData Data
        {
            get
            {
                return new MapEventData(txtRequirement.Text, txtEvent.Text, ckbRepeatable.Checked);
            }
            set
            {
                txtRequirement.Text = value.Requirements;
                txtEvent.Text = value.Event;
                ckbRepeatable.Checked = value.Repeatable;
            }
        }

        public MapEventPanel()
        {
            InitializeComponent();
        }

        public void Init(frmBaseEditor editor, FilesController dataDirectory)
        {
            txtRequirement.Init(dataDirectory, editor);
            txtEvent.Init(dataDirectory, editor);
        }
    }
}
