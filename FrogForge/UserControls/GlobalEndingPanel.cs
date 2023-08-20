using FrogForge.Datas;
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
    public partial class GlobalEndingPanel : GlobalEndingEditor
    {
        public override GlobalEndingData Data
        {
            get
            {
                return new GlobalEndingData(txtRequirement.Text, txtText.Text);
            }
            set
            {
                txtRequirement.Text = value.Requirements;
                txtText.Text = value.Text;
            }
        }

        public GlobalEndingPanel()
        {
            InitializeComponent();
        }

        public void Init(Utils.FilesController dataDirectory, frmBaseEditor editor)
        {
            txtText.Font = FontStuff.GetFont("Gaiden", (int)Math.Round(txtText.Font.SizeInPoints * Preferences.Current.ZoomAmount));
            txtRequirement.Init(dataDirectory, editor);
            if (editor != null)
            {
                txtRequirement.TextChanged += (sender, e) => editor.Dirty = true;
                txtText.TextChanged += (sender, e) => editor.Dirty = true;
            }
        }
    }
}
