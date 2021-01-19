using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace FrogForge
{
    public partial class frmClassEditor : frmBaseEditor
    {
        private NumericUpDown[] Growths = new NumericUpDown[6];
        private List<ClassData> Classes;

        public frmClassEditor()
        {
            InitializeComponent();
        }

        private void frmClassEditor_Load(object sender, EventArgs e)
        {
            // Create growths UI
            int nudWidth = 36, lblWidth = 32, height = 23, offset = 6, topOffset = 18, lblTopOffset = 3, leftOffset = 6;
            Color[] colors = new Color[] { Color.Red, Color.Blue, Color.Green };
            for (int i = 0; i < 6; i++)
            {
                Label newLbl = new Label();
                newLbl.Width = lblWidth;
                newLbl.Height = height;
                newLbl.Left = (i / 2) * (lblWidth + nudWidth + offset * 2) + leftOffset;
                newLbl.Top = (i % 2) * (height + offset) + topOffset + lblTopOffset;
                newLbl.ForeColor = colors[i / 2];
                newLbl.Text = ((StatNames)i).ToString() + ":";
                grpGrowths.Controls.Add(newLbl);
                NumericUpDown newNud = new NumericUpDown();
                newNud.Width = nudWidth;
                newNud.Height = height;
                newNud.Left = (i / 2) * (lblWidth + nudWidth + offset * 2) + lblWidth + offset + leftOffset;
                newNud.Top = (i % 2) * (height + offset) + topOffset;
                newNud.ForeColor = colors[i / 2];
                newNud.Minimum = 0;
                newNud.Maximum = 5;
                grpGrowths.Controls.Add(newNud);
                Growths[i] = newNud;
            }
            // Load classes data
            if (WorkingDirectory.CheckFileExist("Classes.json"))
            {
                Classes = (List<ClassData>) JsonSerializer.Deserialize(WorkingDirectory.LoadFile("Classes", "", ".json"), typeof(List<ClassData>));
                UpdateList();
            }
            else
            {
                Classes = new List<ClassData>();
            }
            // Misc
            cmbInclination.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClassData editing = Classes.Find(a => a.Name == txtName.Text);
            if (editing != null)
            {
                FromUI(editing);
            }
            else
            {
                editing = FromUI();
                Classes.Add(editing);
            }
            UpdateList();
        }

        private void UpdateList()
        {
            object item = lstClasses.SelectedItem;
            lstClasses.DataSource = null;
            lstClasses.DataSource = Classes;
            if (item != null && lstClasses.Items.Contains(item))
            {
                lstClasses.SelectedItem = item;
            }
            else
            {
                lstClasses.SelectedItem = null;
            }
            // Save
            WorkingDirectory.SaveFile("Classes", JsonSerializer.Serialize(Classes, typeof(List<ClassData>)), ".json");
        }

        private ClassData FromUI()
        {
            return FromUI(new ClassData());
        }

        private ClassData FromUI(ClassData data)
        {
            data.Name = txtName.Text;
            data.MapSprite = picIcon.Image;
            data.Inclination = (Inclination)cmbInclination.SelectedIndex;
            data.Flies = ckbFlies.Checked;
            for (int i = 0; i < 6; i++)
            {
                data.Growths[i] = (int)Growths[i].Value;
            }
            data.Weapon = new Weapon();
            data.Weapon.Name = txtWeaponName.Text;
            data.Weapon.Range = (int)nudWeaponRange.Value;
            data.Weapon.Damage = (int)nudWeaponDamage.Value;
            data.Weapon.HitStat = (int)nudWeaponHit.Value;
            data.Weapon.Weight = (int)nudWeaponWeight.Value;
            return data;
        }

        private void ToUI(ClassData data)
        {
            txtName.Text = data.Name;
            picIcon.Image = data.MapSprite;
            cmbInclination.Text = data.Inclination.ToString();
            ckbFlies.Checked = data.Flies;
            for (int i = 0; i < 6; i++)
            {
                Growths[i].Value = data.Growths[i];
            }
            txtWeaponName.Text = data.Weapon.Name;
            nudWeaponRange.Value = data.Weapon.Range;
            nudWeaponDamage.Value = data.Weapon.Damage;
            nudWeaponHit.Value = data.Weapon.HitStat;
            nudWeaponWeight.Value = data.Weapon.Weight;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Classes.RemoveAt(lstClasses.SelectedIndex);
            UpdateList();
        }

        private void lstClasses_DoubleClick(object sender, EventArgs e)
        {
            if (lstClasses.SelectedIndex >= 0)
            {
                ToUI(Classes[lstClasses.SelectedIndex]);
            }
        }
    }
}
