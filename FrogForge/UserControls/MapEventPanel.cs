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
                return new MapEventData(txtRequirement.Text, txtEvent.Text);
            }
            set
            {
                txtRequirement.Text = value.Requirements;
                txtRequirement.ColorText();
                txtEvent.Text = value.Event;
                txtEvent.ColorText();
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
