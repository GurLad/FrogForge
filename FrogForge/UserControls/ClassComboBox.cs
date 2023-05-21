using FrogForge.Datas;
using FrogForge.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace FrogForge.UserControls
{
    public class ClassComboBox : ComboBox
    {
        private FilesController WorkingDirectory;

        public void Init(frmBaseEditor baseEditor, List<ClassData> items = null)
        {
            WorkingDirectory = baseEditor.WorkingDirectory;
            UpdateItems(items);
            TextChanged += (sender, e) => baseEditor.Dirty = true;
        }

        public void UpdateItems(List<ClassData> items = null)
        {
            if (items == null)
            {
                items = WorkingDirectory.LoadFile("Classes", "", ".json").JsonToObject<List<ClassData>>();
            }
            Items.Clear();
            Items.AddRange(items.ConvertAll(a => a.Name).ToArray());
        }
    }
}
