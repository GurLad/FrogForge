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
    public partial class VoiceTypesSelector : UserControl
    {
        private const int CHECKBOX_H_OFFSET = 25;
        public List<string> OptionNames
        {
            set
            {
                List<int> currentSelected = SelectedOptions;
                pnlOptions.Controls.Clear();
                boxes.Clear();
                int currentWidth = 0;
                for (int i = 0; i < value.Count; i++)
                {
                    CheckBox newBox = new CheckBox();
                    newBox.Text = value[i];
                    newBox.Left = currentWidth;
                    newBox.AutoSize = true;
                    newBox.Checked = currentSelected.Contains(i);
                    newBox.CheckedChanged += (sender, e) => dirtyFunc();
                    pnlOptions.Controls.Add(newBox);
                    boxes.Add(newBox);
                    currentWidth += (int)newBox.CreateGraphics().MeasureString(newBox.Text, newBox.Font).Width + CHECKBOX_H_OFFSET;
                }
                pnlOptions.Width = currentWidth;
                if (hsbScrollBar.Visible = pnlOptions.Width > Width)
                {
                    hsbScrollBar.Maximum = pnlOptions.Width;
                    hsbScrollBar.LargeChange = 5;
                    hsbScrollBar.Value = Width;
                    hsbScrollBar.Minimum = Width;
                }
            }
        }
        public List<int> SelectedOptions
        {
            get
            {
                List<int> result = new List<int>();
                for (int i = 0; i < boxes.Count; i++)
                {
                    if (boxes[i].Checked)
                    {
                        result.Add(i);
                    }
                }
                return result;
            }
            set
            {
                boxes.ForEach(a => a.Checked = false);
                value.ForEach(a => boxes[a].Checked = true);
            }
        }
        private List<CheckBox> boxes = new List<CheckBox>();
        private Action dirtyFunc;

        public VoiceTypesSelector()
        {
            InitializeComponent();
        }

        public void Init(frmBaseEditor baseEditor)
        {
            dirtyFunc = () => baseEditor.Dirty = true;
        }

        private void hsbScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            pnlOptions.Left = Width - hsbScrollBar.Value;
        }
    }
}
