using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using FrogForge.Datas;
using FrogForge.Editors;

namespace FrogForge.UserControls
{
    public class JSONBrowser<T> : ListBox where T : NamedData
    {
        public List<T> Data;
        private Func<T> NewT;
        private Func<T, T> DataFromUI;
        private Action<T> DataToUI;
        private frmBaseEditor BaseEditor;
        private string FileName;

        public void Init(frmBaseEditor baseEditor, Func<T> newT, Func<T, T> dataFromUI, Action<T> dataToUI, string fileName)
        {
            BaseEditor = baseEditor;
            NewT = newT;
            DataFromUI = dataFromUI;
            DataToUI = dataToUI;
            FileName = fileName;
            // Init ListBox
            DoubleClick += ListBox_DoubleClick;
            // Load JSON file
            if (BaseEditor.WorkingDirectory.CheckFileExist(fileName + ".json"))
            {
                Data = BaseEditor.WorkingDirectory.LoadFile(fileName, "", ".json").JsonToObject<List<T>>();
                UpdateList();
            }
            else
            {
                Data = new List<T>();
            }
        }

        public void SaveToFile()
        {
            BaseEditor.WorkingDirectory.SaveFile(FileName, Data.ToJson(), ".json");
        }

        public void Save(string editingName)
        {
            T editing = Data.Find(a => a.Name == editingName);
            if (editing != null)
            {
                DataFromUI(editing);
            }
            else
            {
                editing = DataFromUI(NewT());
                Data.Add(editing);
            }
            UpdateList();
            BaseEditor.Dirty = false;
            VoiceAssist.Say("Save");
        }

        public T Remove()
        {
            if (BaseEditor.ConfirmDialog("Are you sure you want to delete " + Data[SelectedIndex].Name + "?", "Delete"))
            {
                T temp = Data[SelectedIndex];
                Data.RemoveAt(SelectedIndex);
                UpdateList();
                VoiceAssist.Say("Delete");
                return temp;
            }
            return null;
        }

        public void New()
        {
            if (BaseEditor.HasUnsavedChanges())
            {
                return;
            }
            DataToUI(NewT());
            BaseEditor.CurrentFile = "";
            VoiceAssist.Say("New");
        }

        private void UpdateList()
        {

            object item = SelectedItem;
            DataSource = null;
            DataSource = Data;
            if (item != null && Items.Contains(item))
            {
                SelectedItem = item;
            }
            else
            {
                SelectedItem = null;
            }
        }

        private void ListBox_DoubleClick(object sender, EventArgs e)
        {
            if (BaseEditor.HasUnsavedChanges())
            {
                return;
            }
            if (SelectedIndex >= 0)
            {
                DataToUI(Data[SelectedIndex]);
                VoiceAssist.Say("Open");
            }
        }
    }
}
