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
using FrogForge.Datas;
using FrogForge.UserControls;

namespace FrogForge.Editors
{
    public partial class frmClassEditor : frmBaseEditor
    {
        private NumericUpDown[] Growths = new NumericUpDown[6];

        public frmClassEditor()
        {
            InitializeComponent();
            BaseName = Text;
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
                newNud.ValueChanged += DirtyFunc;
                grpGrowths.Controls.Add(newNud);
                Growths[i] = newNud;
            }
            // Init stuff
            dlgOpen.Filter = "Animated image files|*.gif;*.png";
            picIcon.Init(dlgOpen, this);
            cmbInclination.SelectedIndex = 0;
            // Set dirty
            nudWeaponDamage.ValueChanged += DirtyFunc;
            nudWeaponWeight.ValueChanged += DirtyFunc;
            nudWeaponRange.ValueChanged += DirtyFunc;
            nudWeaponHit.ValueChanged += DirtyFunc;
            txtWeaponName.TextChanged += DirtyFunc;
            cmbInclination.TextChanged += DirtyFunc;
            ckbFlies.CheckedChanged += DirtyFunc;
            // Init base
            lstClasses.Init(this, () => new ClassData(), DataFromUI, DataToUI, "Classes");
            balBattleAnimations.Init(
                this, () => new BattleAnimationData(), () => new BattleAnimationPanel(),
                (bap) => bap.Init(dlgOpen, this), true, () => btnGenerateBase.Visible = balBattleAnimations.Datas.Count <= 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lstClasses.Save(txtName.Text);
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
            data.Weapon.Name = txtWeaponName.Text;
            data.Weapon.Range = (int)nudWeaponRange.Value;
            data.Weapon.Damage = (int)nudWeaponDamage.Value;
            data.Weapon.HitStat = (int)nudWeaponHit.Value;
            data.Weapon.Weight = (int)nudWeaponWeight.Value;
            // Battle animations
            data.BattleAnimations.Clear();
            foreach (var item in balBattleAnimations.Datas)
            {
                data.BattleAnimations.Add(item);
            }
            CurrentFile = data.Name;
            Dirty = false;
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
            CurrentFile = data.Name;
            Dirty = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ClassData removed = lstClasses.Remove();
            if (removed != null) // Delete images
            {
                for (int i = 0; i < removed.BattleAnimations.Count; i++)
                {
                    string fileName = @"Images\ClassBattleAnimations\" + removed.Name + @"\" + removed.BattleAnimations[i].Name;
                    if (WorkingDirectory.CheckFileExist(fileName + WorkingDirectory.DefultImageFileFormat))
                    {
                        DeleteFile(fileName, WorkingDirectory, false, WorkingDirectory.DefultImageFileFormat);
                    }
                }
                // TBA: Delete folders
            }
        }

        private void frmClassEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Save
            lstClasses.SaveToFile();
            // Save images
            foreach (ClassData item in lstClasses.Data)
            {
                if (item.MapSprite != null)
                {
                    WorkingDirectory.SaveImage(@"ClassMapSprites\" + item.Name, item.MapSprite.Target);
                }
                WorkingDirectory.CreateDirectory(@"Images\ClassBattleAnimations\" + item.Name);
                for (int i = 0; i < item.BattleAnimations.Count; i++)
                {
                    if (item.BattleAnimations[i]?.Image?.Target != null)
                    {
                        WorkingDirectory.SaveImage(@"ClassBattleAnimations\" + item.Name + @"\" + item.BattleAnimations[i].Name, item.BattleAnimations[i].Image.Target);
                    }
                }
            }
        }

        private void BattleAnimationsFromList(List<string> names)
        {
            List<BattleAnimationData> battleAnimations = new List<BattleAnimationData>();
            for (int i = 0; i < names.Count; i++)
            {
                battleAnimations.Add(new BattleAnimationData(names[i]));
            }
            balBattleAnimations.Datas = battleAnimations;
        }

        private void BattleAnimationsFromClassData(ClassData data)
        {
            WorkingDirectory.CreateDirectory(@"Images\ClassBattleAnimations\" + data.Name);
            for (int i = 0; i < data.BattleAnimations.Count; i++)
            {
                if (data.BattleAnimations[i].Image == null)
                {
                    data.BattleAnimations[i].Image = 
                        PalettedImage.FromFile(WorkingDirectory, @"ClassBattleAnimations\" + data.Name + @"\" + data.BattleAnimations[i].Name);
                }
            }
            balBattleAnimations.Datas = data.BattleAnimations;
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
            Dirty = true;
        }

        protected override bool ControlKeyAction(Keys key)
        {
            switch (key)
            {
                case Keys.S:
                    btnSave_Click(this, new EventArgs());
                    return true;
                case Keys.N:
                    lstClasses.New();
                    return true;
                default:
                    break;
            }
            return false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lstClasses.New();
        }
    }
}
