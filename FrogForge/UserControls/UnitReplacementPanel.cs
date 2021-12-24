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
    public partial class UnitReplacementPanel : UnitReplacementEditor
    {
        public override UnitReplacementData Data
        {
            get
            {
                return new UnitReplacementData(txtUnit.Text, lstReplacedBy.Datas);
            }
            set
            {
                txtUnit.Text = value.Name;
                lstReplacedBy.Datas = value.ReplacedBy;
            }
        }

        public void Init(frmBaseEditor editor)
        {
            lstReplacedBy.Init(editor, () => "", () => new DataTextBox(), a => a.Init(editor), false);
            txtUnit.TextChanged += (sender, e) => editor.Dirty = true;
        }

        public UnitReplacementPanel()
        {
            InitializeComponent();
        }
    }
}
