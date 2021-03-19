using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrogForge.Editors;

namespace FrogForge.UserControls
{
    public partial class ListDataEditor<Control, DataType> : UserControl where Control : DataEditor<DataType> where DataType : class
    {
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<DataType> Datas
        {
            get
            {
                return GeneratedControls.Select(a => a.Data).ToList();
            }
            set
            {
                // Remove previous data
                GeneratedControls.Clear();
                pnlControls.Controls.Clear();
                // Add new data
                value.ForEach(a => AddControl(a));
                UpdateUI();
            }
        }
        private frmBaseEditor Editor;
        private const int DATA_SPACING = 3;
        private List<Control> GeneratedControls { get; } = new List<Control>();
        private Func<DataType> NewData;
        private Func<Control> NewControl;
        private Action<Control> InitControl;
        private Action UpdateUIAction;
        private int NumDatasInOneScreen;
        public ListDataEditor()
        {
            InitializeComponent();
        }

        public void Init(frmBaseEditor editor, Func<DataType> newData, Func<Control> newControl, Action<Control> initControl, bool fixWidth = true, Action updateUIAction = null)
        {
            Editor = editor;
            NewData = newData;
            NewControl = newControl;
            InitControl = initControl;
            UpdateUIAction = updateUIAction;
            Control temp = NewControl();
            if (fixWidth)
            {
                Width = temp.Width + vsbDatasScroller.Width + DATA_SPACING;
            }
            else
            {
                NewControl = () =>
                {
                    Control t = newControl();
                    t.Width = pnlControls.Width;
                    return t;
                };
            }
            NumDatasInOneScreen = (pnlContainer.Height + DATA_SPACING) / (temp.Height + DATA_SPACING);
            Height = NumDatasInOneScreen * (temp.Height + DATA_SPACING) - DATA_SPACING + btnAdd.Height + btnAdd.Top - vsbDatasScroller.Bottom;
            vsbDatasScroller.LargeChange = NumDatasInOneScreen + 1;
            UpdateUI();
            temp.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddControl();
        }

        private void vsbDatasScroller_Scroll(object sender, ScrollEventArgs e)
        {
            pnlControls.Top = -vsbDatasScroller.Value * (GeneratedControls[0].Height + 3);
        }

        private void AddControl(DataType data = null)
        {
            Control toAdd = NewControl();
            toAdd.Top = GeneratedControls.Count * (toAdd.Height + DATA_SPACING);
            toAdd.Data = data ?? NewData();
            InitControl(toAdd);
            GeneratedControls.Add(toAdd);
            pnlControls.Controls.Add(toAdd);
            pnlControls.Height = GeneratedControls.Count * (toAdd.Height + 3);
            UpdateUI();
            if (Editor != null)
            {
                Editor.Dirty = true;
            }
        }

        private void UpdateUI()
        {
            vsbDatasScroller.Maximum = GeneratedControls.Count;
            vsbDatasScroller.Visible = GeneratedControls.Count > NumDatasInOneScreen;
            vsbDatasScroller.Value = Math.Min(vsbDatasScroller.Maximum, vsbDatasScroller.Value);
            if (vsbDatasScroller.Maximum > NumDatasInOneScreen)
            {
                pnlControls.Top = -vsbDatasScroller.Value * (GeneratedControls[0].Height + 3);
            }
            else
            {
                pnlControls.Top = 0;
            }
            UpdateUIAction?.Invoke();
        }
    }
}
