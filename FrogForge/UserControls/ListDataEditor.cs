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
using static FrogForge.ExtensionMethods;

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
                GeneratedDeleteButtons.Clear();
                pnlControls.Controls.Clear();
                // Add new data
                value.ForEach(a => AddControl(a));
                UpdateUI();
            }
        }
        private frmBaseEditor Editor;
        private const int DATA_SPACING = 3;
        private readonly Point DELETE_BUTTON_SIZE = new Point(16, 16);
        private List<Control> GeneratedControls { get; } = new List<Control>();
        private List<Button> GeneratedDeleteButtons { get; } = new List<Button>();
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
                Width = temp.Width + vsbDatasScroller.Width + DELETE_BUTTON_SIZE.X + DATA_SPACING * 2;
            }
            else
            {
                int widthCopy = pnlControls.Width;
                NewControl = () =>
                {
                    Control t = newControl();
                    t.Width = widthCopy - (DELETE_BUTTON_SIZE.X + DATA_SPACING);
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
            pnlControls.Top = -vsbDatasScroller.Value * (GeneratedControls[0].Height + DATA_SPACING);
        }

        private void AddControl(DataType data = null)
        {
            Control toAdd = NewControl();
            toAdd.Top = GeneratedControls.Count * (toAdd.Height + DATA_SPACING);
            toAdd.Left = DELETE_BUTTON_SIZE.X + DATA_SPACING;
            InitControl(toAdd);
            toAdd.ApplyPreferences();
            toAdd.Data = data ?? NewData();
            Button deleteButton = GenerateDeleteButton(GeneratedControls.Count, toAdd.Top, toAdd.Height);
            deleteButton.ApplyPreferences();
            GeneratedControls.Add(toAdd);
            GeneratedDeleteButtons.Add(deleteButton);
            pnlControls.Controls.Add(toAdd);
            pnlControls.Controls.Add(deleteButton);
            pnlControls.Height = GeneratedControls.Count * (toAdd.Height + DATA_SPACING);
            UpdateUI();
            if (Editor != null)
            {
                Editor.Dirty = true;
            }
        }

        private Button GenerateDeleteButton(int index, int top, int height)
        {
            Button button = new Button();
            button.Size = new Size(DELETE_BUTTON_SIZE);
            button.Top = top + (height - DELETE_BUTTON_SIZE.Y) / 2;
            button.Text = "";
            button.Image = Properties.Resources.MiniDelete;
            button.Tag = index;
            button.Click += (sender, e) => { if (ConfirmDialog("Delete item?", "Delete")) Delete((int)button.Tag); };
            return button;
        }

        private void Delete(int index)
        {
            pnlControls.Controls.Remove(GeneratedControls[index]);
            pnlControls.Controls.Remove(GeneratedDeleteButtons[index]);
            GeneratedControls.RemoveAt(index);
            GeneratedDeleteButtons.RemoveAt(index);
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
            vsbDatasScroller.Value = Math.Min(vsbDatasScroller.Maximum - vsbDatasScroller.LargeChange + 1, vsbDatasScroller.Value);
            if (vsbDatasScroller.Maximum > NumDatasInOneScreen)
            {
                pnlControls.Top = -vsbDatasScroller.Value * (GeneratedControls[0].Height + DATA_SPACING);
            }
            else
            {
                pnlControls.Top = 0;
            }
            for (int i = 0; i < GeneratedControls.Count; i++)
            {
                GeneratedControls[i].Top = i * (GeneratedControls[i].Height + DATA_SPACING);
                GeneratedDeleteButtons[i].Top = GeneratedControls[i].Top + (GeneratedControls[i].Height - DELETE_BUTTON_SIZE.Y) / 2;
                GeneratedDeleteButtons[i].Tag = i;
            }
            UpdateUIAction?.Invoke();
        }
    }
}
