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
        private static int[] PageWidths { get; } = new int[] { 621, 652 };

        public frmClassEditor()
        {
            InitializeComponent();
            BaseName = Text;
        }

        private void frmClassEditor_Load(object sender, EventArgs e)
        {
            // Init stuff
            dlgOpen.Filter = "Animated image files|*.gif;*.png";
            picIcon.Init(dlgOpen, this);
            cmbClassInclination.SelectedIndex = 0;
            // Set dirty
            nudWeaponDamage.ValueChanged += DirtyFunc;
            nudWeaponWeight.ValueChanged += DirtyFunc;
            nudWeaponRange.ValueChanged += DirtyFunc;
            nudWeaponHit.ValueChanged += DirtyFunc;
            txtWeaponName.TextChanged += DirtyFunc;
            cmbClassInclination.TextChanged += DirtyFunc;
            ckbFlies.CheckedChanged += DirtyFunc;
            txtUnitClass.TextChanged += DirtyFunc;
            cmbUnitInclination.TextChanged += DirtyFunc;
            // Init base
            lstClasses.Init(this, () => new ClassData(), ClassDataFromUI, ClassDataToUI, "Classes");
            lstUnits.Init(this, () => new UnitData(), UnitDataFromUI, UnitDataToUI, "Units");
            gthClassGrowths.Init(this);
            gthUnitGrowths.Init(this);
            balBattleAnimations.Init(
                this, () => new BattleAnimationData(), () => new BattleAnimationPanel(),
                (bap) => bap.Init(dlgOpen, this), true, () => btnGenerateBase.Visible = balBattleAnimations.Datas.Count <= 0);
            txtUnitDeathQuote.Init(DataDirectory, this);
            this.ApplyPreferences();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbcMain.SelectedIndex == 0)
            {
                lstClasses.Save(txtClassName.Text);
            }
            else
            {
                lstUnits.Save(txtUnitName.Text);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (tbcMain.SelectedIndex == 0)
            {
                lstClasses.New();
            }
            else
            {
                lstUnits.New();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tbcMain.SelectedIndex == 0)
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
            else
            {
                UnitData removed = lstUnits.Remove(); // There isn't much to do with it - units have no images
            }
        }

        private ClassData ClassDataFromUI(ClassData data)
        {
            data.Name = txtClassName.Text;
            data.MapSprite = picIcon.Image;
            data.Inclination = (Inclination)cmbClassInclination.SelectedIndex;
            data.Flies = ckbFlies.Checked;
            data.Growths = gthClassGrowths.Data;
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

        private void ClassDataToUI(ClassData data)
        {
            txtClassName.Text = data.Name;
            picIcon.Image = data.LoadSprite(WorkingDirectory);
            cmbClassInclination.Text = data.Inclination.ToString();
            ckbFlies.Checked = data.Flies;
            gthClassGrowths.Data = data.Growths;
            txtWeaponName.Text = data.Weapon.Name;
            nudWeaponRange.Value = data.Weapon.Range;
            nudWeaponDamage.Value = data.Weapon.Damage;
            nudWeaponHit.Value = data.Weapon.HitStat;
            nudWeaponWeight.Value = data.Weapon.Weight;
            BattleAnimationsFromClassData(data);
            CurrentFile = data.Name;
            Dirty = false;
        }

        private UnitData UnitDataFromUI(UnitData data)
        {
            data.Name = txtUnitName.Text;
            data.Class = txtUnitClass.Text;
            data.Inclination = (Inclination)cmbUnitInclination.SelectedIndex;
            data.Growths = gthUnitGrowths.Data;
            data.DeathQuote = txtUnitDeathQuote.Text;
            CurrentFile = data.Name;
            Dirty = false;
            return data;
        }

        private void UnitDataToUI(UnitData data)
        {
            txtUnitName.Text = data.Name;
            txtUnitClass.Text = data.Class;
            cmbUnitInclination.Text = data.Inclination.ToString();
            gthUnitGrowths.Data = data.Growths;
            txtUnitDeathQuote.Text = data.DeathQuote;
            txtUnitDeathQuote.ColorText();
            CurrentFile = data.Name;
            Dirty = false;
        }

        private void frmClassEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Save classes
            lstClasses.SaveToFile();
            // Save class images
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
            // Save units
            lstUnits.SaveToFile();
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
                    btnNew_Click(this, new EventArgs());
                    return true;
                default:
                    break;
            }
            return false;
        }

        private void tbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (HasUnsavedChanges())
            //{
            //    return;
            //}
            Width = PageWidths[tbcMain.SelectedIndex];
            CurrentFile = "";
        }
    }
}
