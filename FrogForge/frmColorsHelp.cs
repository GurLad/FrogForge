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

namespace FrogForge
{
    public partial class frmColorsHelp : frmBaseEditor
    {
        public frmColorsHelp()
        {
            InitializeComponent();
        }

        private void frmColorsHelp_Load(object sender, EventArgs e)
        {
            this.ApplyPreferences();
            RecenterForm();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
