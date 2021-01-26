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
using System.Drawing.Imaging;

namespace FrogForge
{
    public partial class frmClassEditor : frmBaseEditor
    {
        private NumericUpDown[] Growths = new NumericUpDown[6];
        private List<ClassData> Classes;
        private List<BattleAnimationPanel> BattleAnimations = new List<BattleAnimationPanel>();
        private OpenFileDialog dlgOpen = new OpenFileDialog();

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
            // Init stuff
            dlgOpen.Filter = "Animated image files|*.gif;*.png";
            picIcon.Init(dlgOpen);
            if (Classes.Count > 0)
            {
                lstClasses.SelectedIndex = 0;
                DataToUI(Classes[lstClasses.SelectedIndex]);
            }
            else
            {
                cmbInclination.SelectedIndex = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClassData editing = Classes.Find(a => a.Name == txtName.Text);
            if (editing != null)
            {
                DataFromUI(editing);
            }
            else
            {
                editing = DataFromUI();
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
        }

        private ClassData DataFromUI()
        {
            return DataFromUI(new ClassData());
        }

        private ClassData DataFromUI(ClassData data)
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
            // Battle animations
            data.BattleAnimations.Clear();
            data.BattleAnimationImages.Clear();
            foreach (var item in BattleAnimations)
            {
                data.BattleAnimations.Add(item.AnimationName);
                data.BattleAnimationImages.Add(item.Animation);
            }
            return data;
        }

        private void DataToUI(ClassData data)
        {
            txtName.Text = data.Name;
            picIcon.Image = data.LoadSprite(WorkingDirectory);
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
            BattleAnimationsFromClassData(data);
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
                DataToUI(Classes[lstClasses.SelectedIndex]);
            }
        }

        private void frmClassEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Save
            WorkingDirectory.SaveFile("Classes", JsonSerializer.Serialize(Classes, typeof(List<ClassData>)), ".json");
            // Save images
            foreach (ClassData item in Classes)
            {
                if (item.MapSprite != null)
                {
                    WorkingDirectory.SaveImage(@"ClassMapSprites\" + item.Name, item.MapSprite.Target);
                }
                WorkingDirectory.CreateDirectory(@"Images\ClassBattleAnimations\" + item.Name);
                for (int i = 0; i < item.BattleAnimationImages.Count; i++)
                {
                    if (item.BattleAnimationImages[i]?.Target != null)
                    {
                        WorkingDirectory.SaveImage(@"ClassBattleAnimations\" + item.Name + @"\" + item.BattleAnimations[i], item.BattleAnimationImages[i].Target);
                    }
                }
            }
        }

        private void AddBattleAnimations(string name = "", PalettedImage image = null)
        {
            BattleAnimationPanel newPanel = new BattleAnimationPanel();
            newPanel.Top = BattleAnimations.Count * (newPanel.Height + 3);
            newPanel.AnimationName = name;
            newPanel.Animation = image;
            newPanel.Init(dlgOpen);
            BattleAnimations.Add(newPanel);
            pnlBattleAnimations.Controls.Add(newPanel);
            pnlBattleAnimations.Height = BattleAnimations.Count * (newPanel.Height + 3);
            UpdateBattleAnimationsUI();
        }

        private void BattleAnimationsFromList(List<string> names)
        {
            BattleAnimations.Clear();
            pnlBattleAnimations.Controls.Clear();
            for (int i = 0; i < names.Count; i++)
            {
                AddBattleAnimations(names[i]);
            }
            UpdateBattleAnimationsUI();
        }

        private void BattleAnimationsFromClassData(ClassData data)
        {
            BattleAnimations.Clear();
            pnlBattleAnimations.Controls.Clear();
            WorkingDirectory.CreateDirectory(@"Images\ClassBattleAnimations\" + data.Name);
            for (int i = data.BattleAnimationImages.Count; i < data.BattleAnimations.Count; i++)
            {
                data.BattleAnimationImages.Add(PalettedImage.FromFile(WorkingDirectory, @"ClassBattleAnimations\" + data.Name + @"\" + data.BattleAnimations[i]));
            }
            for (int i = 0; i < data.BattleAnimations.Count; i++)
            {
                AddBattleAnimations(data.BattleAnimations[i], data.BattleAnimationImages[i]);
            }
            UpdateBattleAnimationsUI();
        }

        private void UpdateBattleAnimationsUI()
        {
            btnGenerateBase.Visible = BattleAnimations.Count == 0;
            vsbBattleAnimationsScrollbar.Visible = BattleAnimations.Count > 4;
            vsbBattleAnimationsScrollbar.Maximum = BattleAnimations.Count;
            vsbBattleAnimationsScrollbar.Value = 0;
            pnlBattleAnimations.Top = 0;
        }

        private void btnAddBattleAnimation_Click(object sender, EventArgs e)
        {
            AddBattleAnimations("");
        }

        private void btnGenerateBase_Click(object sender, EventArgs e)
        {
            BattleAnimationsFromList(new List<string>(new string[]
            {
                "Idle",
                "Walk",
                "AttackStart",
                "AttackEnd"
            }));
        }

        private void vsbBattleAnimationsScrollbar_Scroll(object sender, ScrollEventArgs e)
        {
            pnlBattleAnimations.Top = -vsbBattleAnimationsScrollbar.Value * (BattleAnimations[0].Height + 3);
        }
    }
}
