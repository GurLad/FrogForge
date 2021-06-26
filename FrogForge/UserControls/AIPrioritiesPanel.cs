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

namespace FrogForge.UserControls
{
    public partial class AIPrioritiesPanel : AIPrioritiesEditor
    {
        public override AIPriorities Data
        {
            get
            {
                AIPriorities priorities = new AIPriorities((float)nudTrueDamage.Value, (float)nudRelativeDamage.Value, (float)nudSurvival.Value);
                int cautionLevel = 0;
                cautionLevel |= ckbNoDamage.Checked ? 1 : 0;
                cautionLevel |= ckbSuicide.Checked ? 2 : 0;
                cautionLevel |= ckbLittleDamage.Checked ? 4 : 0;
                priorities.CautionLevel = (AICautionLevel)cautionLevel;
                return priorities;
            }
            set
            {
                nudTrueDamage.Value = (decimal)value.TrueDamageWeight;
                nudRelativeDamage.Value = (decimal)value.RelativeDamageWeight;
                nudSurvival.Value = (decimal)value.SurvivalWeight;
                int cautionLevel = (int)value.CautionLevel;
                ckbNoDamage.Checked = (cautionLevel & 1) != 0;
                ckbSuicide.Checked = (cautionLevel & 2) != 0;
                ckbLittleDamage.Checked = (cautionLevel & 4) != 0;
            }
        }

        public AIPrioritiesPanel()
        {
            InitializeComponent();
        }

        public void Init(EventHandler dirtyFunc)
        {
            nudRelativeDamage.ValueChanged += dirtyFunc;
            nudSurvival.ValueChanged += dirtyFunc;
            nudTrueDamage.ValueChanged += dirtyFunc;
            ckbLittleDamage.CheckedChanged += dirtyFunc;
            ckbNoDamage.CheckedChanged += dirtyFunc;
            ckbSuicide.CheckedChanged += dirtyFunc;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).Tag.ToString());
        }
    }
}
