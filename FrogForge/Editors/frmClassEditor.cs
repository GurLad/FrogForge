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
        private static int[] PageWidths { get; } = new int[] { 803, 652 };
        private Random RNG { get; } = new Random();
        private int CurrentPreviewPalette = 0;
        private List<Palette> BaseSpritePalettes;

        public frmClassEditor()
        {
            InitializeComponent();
            BaseName = Text;
        }

        private void frmClassEditor_Load(object sender, EventArgs e)
        {
            // Init stuff
            dlgOpen.Filter = "Animated image files|*.gif;*.png";
            picIcon.Init(dlgOpen, this, true);
            cmbClassInclination.SelectedIndex = 0;
            cmbUnitInclination.SelectedIndex = 0;
            string[] battleAnimationModeNames = Enum.GetNames(typeof(BattleAnimationMode));
            cmbClassAnimationModeMelee.Items.AddRange(battleAnimationModeNames);
            cmbClassAnimationModeRanged.Items.AddRange(battleAnimationModeNames);
            cmbClassAnimationModeMelee.SelectedIndex = 0;
            cmbClassAnimationModeRanged.SelectedIndex = 0;
            BaseSpritePalettes = Palette.GetBaseSpritePalettes(WorkingDirectory);
            // Set dirty
            nudWeaponDamage.ValueChanged += DirtyFunc;
            nudWeaponWeight.ValueChanged += DirtyFunc;
            nudWeaponRange.ValueChanged += DirtyFunc;
            nudWeaponHit.ValueChanged += DirtyFunc;
            txtWeaponName.TextChanged += DirtyFunc;
            cmbClassInclination.TextChanged += DirtyFunc;
            ckbFlies.CheckedChanged += DirtyFunc;
            cmbClassAnimationModeMelee.TextChanged += DirtyFunc;
            cmbClassAnimationModeRanged.TextChanged += DirtyFunc;
            cmbUnitInclination.TextChanged += DirtyFunc;
            nudProjectileLocationX.ValueChanged += DirtyFunc;
            nudProjectileLocationY.ValueChanged += DirtyFunc;
            // Init base
            lstClasses.Init(this, () => new ClassData(), ClassDataFromUI, ClassDataToUI, "Classes");
            lstUnits.Init(this, () => new UnitData(), UnitDataFromUI, UnitDataToUI, "Units");
            gthClassGrowths.Init(this);
            gthUnitGrowths.Init(this);
            balBattleAnimations.Init(
                this, () => new BattleAnimationData(), () => new BattleAnimationPanel(),
                (bap) => { bap.Init(dlgOpen, this); bap.SetPreviewPalette(CurrentPreviewPalette, BaseSpritePalettes); }, true,
                () => btnGenerateBase.Visible = balBattleAnimations.Datas.Count <= 0);
            picProjectile.Init(dlgOpen, this, true, null, () => UpdateProjectileIndicator(true));
            ccbUnitClass.Init(this, lstClasses.Data);
            // Fix zoom mode issues
            lstUnitDeathQuotes.Width -= PageWidths[0] - PageWidths[1];
            lstUnitDeathQuotes.Init(
                this, () => "", () => new DataEventTextBox(), a => a.Init(DataDirectory, this), false);
            lstUnitDeathQuotes.Width += PageWidths[0] - PageWidths[1];
            // Misc
            this.ApplyPreferences();
            pnlProjectilePos.BackColor = picProjectileIndicator.BackColor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbcMain.SelectedIndex == 0)
            {
                lstClasses.Save(txtClassName.Text);
                ccbUnitClass.UpdateItems(lstClasses.Data);
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
                    if (WorkingDirectory.DirectoryExists(@"\Images\ClassBattleAnimations\" + removed.Name))
                    {
                        DeleteFolder(@"\Images\ClassBattleAnimations\" + removed.Name, WorkingDirectory);
                    }
                }
            }
            else
            {
                UnitData removed = lstUnits.Remove(); // There isn't much to do with it - units have no images
            }
        }

        private ClassData ClassDataFromUI(ClassData data)
        {
            if (txtClassName.Text == "_Projectiles") // AKA someone tries to break this program
            {
                txtClassName.Text = "Projectiles";
            }
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
            data.BattleAnimationModeMelee = (BattleAnimationMode)cmbClassAnimationModeMelee.SelectedIndex;
            data.BattleAnimationModeRanged = (BattleAnimationMode)cmbClassAnimationModeRanged.SelectedIndex;
            data.WalkExtraData.Speed = ckbWalkCustomSpeed.Checked ? (float)nudWalkSpeed.Value : -1;
            data.ProjectileExtraData.Image = picProjectile.Image;
            data.ProjectileExtraData.Pos = new UnityPoint((int)nudProjectileLocationX.Value, (int)nudProjectileLocationY.Value);
            data.TeleportExtraData.Backstab = ckbTeleportBackstab.Checked;
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
            cmbClassAnimationModeMelee.SelectedIndex = (int)data.BattleAnimationModeMelee;
            cmbClassAnimationModeRanged.SelectedIndex = (int)data.BattleAnimationModeRanged;
            ckbWalkCustomSpeed.Checked = data.WalkExtraData.CustomSpeed;
            nudWalkSpeed.Value = (decimal)(data.WalkExtraData.Speed >= 1 ? data.WalkExtraData.Speed : BADWalk.DEFAULT_SPEED);
            picProjectile.Image = data.LoadProjectile(WorkingDirectory);
            nudProjectileLocationX.Value = data.ProjectilePos.x;
            nudProjectileLocationY.Value = data.ProjectilePos.y;
            ckbTeleportBackstab.Checked = data.TeleportExtraData.Backstab;
            tbcAnimationExtraData.SelectedIndex = (int)data.BattleAnimationModeRanged;
            SetPreviewPalette(RNG.Next(4));
            UpdateProjectileIndicator(true, true);
            CurrentFile = data.Name;
            Dirty = false;
        }

        private UnitData UnitDataFromUI(UnitData data)
        {
            data.Name = txtUnitName.Text;
            data.DisplayName = txtUnitDisplayName.Text;
            data.Class = ccbUnitClass.Text;
            data.Inclination = (Inclination)cmbUnitInclination.SelectedIndex;
            data.Growths = gthUnitGrowths.Data;
            data.DeathQuotes = lstUnitDeathQuotes.Datas;
            CurrentFile = data.Name;
            Dirty = false;
            return data;
        }

        private void UnitDataToUI(UnitData data)
        {
            txtUnitName.Text = data.Name;
            txtUnitDisplayName.Text = data.DisplayName;
            ccbUnitClass.Text = data.Class;
            cmbUnitInclination.Text = data.Inclination.ToString();
            gthUnitGrowths.Data = data.Growths;
            lstUnitDeathQuotes.Datas = data.DeathQuotes;
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
                    WorkingDirectory.SaveImage(@"ClassMapSprites\" + item.Name, item.MapSprite.ToBitmap(Palette.BasePalette));
                }
                WorkingDirectory.CreateDirectory(@"Images\ClassBattleAnimations\" + item.Name);
                for (int i = 0; i < item.BattleAnimations.Count; i++)
                {
                    if (item.BattleAnimations[i]?.Image?.Target != null)
                    {
                        WorkingDirectory.SaveImage(@"ClassBattleAnimations\" + item.Name + @"\" + item.BattleAnimations[i].Name, item.BattleAnimations[i].Image.ToBitmap(Palette.BasePalette));
                    }
                }
                if (item.ProjectileExtraData.Image != null)
                {
                    WorkingDirectory.CreateDirectory(@"Images\ClassBattleAnimations\_Projectiles");
                    WorkingDirectory.SaveImage(@"ClassBattleAnimations\_Projectiles\" + item.Name, item.ProjectileExtraData.Image.ToBitmap(Palette.BasePalette));
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
            List<BattleAnimationMode> modes = new List<BattleAnimationMode>
            {
                (BattleAnimationMode)cmbClassAnimationModeMelee.SelectedIndex,
                (BattleAnimationMode)cmbClassAnimationModeRanged.SelectedIndex
            };
            List<string> result = new List<string> { "Idle" };
            if (modes.Contains(BattleAnimationMode.Walk))
            {
                result.Add("Walk");
            }
            if (modes.Contains(BattleAnimationMode.Teleport))
            {
                result.Add("TeleportStart");
                result.Add("TeleportEnd");
            }
            result.Add("AttackStart");
            result.Add("AttackEnd");
            if (modes.Contains(BattleAnimationMode.Projectile))
            {
                result.Add("AttackRangeStart");
                result.Add("AttackRangeEnd");
            }
            BattleAnimationsFromList(result);
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
            this.ResizeByZoom(false, y: false);
            CurrentFile = "";
        }

        private void SetPreviewPalette(int palette)
        {
            CurrentPreviewPalette = palette;
            picIcon.Palette = picProjectile.Palette = BaseSpritePalettes[palette];
            balBattleAnimations.ForEachControl(a => a.SetPreviewPalette(palette, BaseSpritePalettes));
        }

        private void nudProjectileLocationX_ValueChanged(object sender, EventArgs e)
        {
            UpdateProjectileIndicator();
        }

        private void btnProjectileLoad_Click(object sender, EventArgs e)
        {
            UpdateProjectileIndicator(true, true);
        }

        private void UpdateProjectileIndicator(bool updateProjectile = false, bool updateSprite = false)
        {
            double zoomMod = Preferences.Current.ZoomAmount;
            picProjectileIndicator.Left = (int)(((int)nudProjectileLocationX.Value + 8) * zoomMod);
            picProjectileIndicator.Top = (int)(((int)nudProjectileLocationY.Value) * zoomMod);
            if (updateProjectile)
            {
                picProjectileIndicator.Image = picProjectile.Image?.Target?.Resize(zoomMod);
            }
            if (updateSprite)
            {
                PalettedImage attackEndSprite = (balBattleAnimations.Datas.Find(a => a.Name == "AttackRangeEnd") ?? (balBattleAnimations.Datas.Count > 0 ? balBattleAnimations.Datas[0] : null))?.Image;
                Image target = new Bitmap(40, 32); 
                if (attackEndSprite != null)
                {
                    Graphics g = Graphics.FromImage(target);
                    g.DrawImage(attackEndSprite.Target, new PointF(8, 0));
                    g.Dispose();
                }
                pnlProjectilePos.BackgroundImage = target.Resize(zoomMod);
            }
            // Fix zoom mode bugs
            pnlProjectilePos.Height = (int)(32 * zoomMod) + 4;
            picProjectileIndicator.Height = (int)(8 * zoomMod);
            picProjectileIndicator.BackColor = Color.Transparent;
        }

        private void txtUnitName_TextChanged(object sender, EventArgs e)
        {
            txtUnitDisplayName.Text = txtUnitName.Text.Length <= 8 ? txtUnitName.Text : txtUnitName.Text.Substring(0, 8);
        }

        private void ckbWalkCustomSpeed_CheckedChanged(object sender, EventArgs e)
        {
            nudWalkSpeed.Enabled = ckbWalkCustomSpeed.Checked;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (tbcMain.SelectedIndex == 0)
            {
                dlgExport.Filter = "Class data files|*.class.ffpp";
                ClassData data = ClassDataFromUI(new ClassData());
                List<Image> images = new List<Image>();
                images.Add(data.MapSprite.ToBitmap(Palette.BasePalette));
                images.AddRange(data.BattleAnimations.ConvertAll(a => a.Image.ToBitmap(Palette.BasePalette)));
                ProjectPart.Export(dlgExport, "Class", data, images.ToArray());
            }
            else
            {
                // Technically, could just be a simple JSON file as it doesn't contain any images, but eh
                dlgExport.Filter = "Unit data files|*.unit.ffpp";
                UnitData data = UnitDataFromUI(new UnitData());
                ProjectPart.Export(dlgExport, "Unit", data);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (tbcMain.SelectedIndex == 0)
            {
                dlgImport.Filter = "Class data files|*.class.ffpp";
                ProjectPart.Import<ClassData>(
                    dlgImport, "Class",
                    (c) =>
                    {
                        ClassDataToUI(c);
                        btnSave_Click(sender, e);
                    },
                    (i, c, img) =>
                    {
                        if (i <= 0)
                        {
                            c.MapSprite = new PalettedImage(img);
                        }
                        else
                        {
                            c.BattleAnimations[i - 1].Image = new PalettedImage(img);
                        }
                    });
            }
            else
            {
                // Technically, could just be a simple JSON file as it doesn't contain any images, but eh
                dlgImport.Filter = "Unit data files|*.unit.ffpp";
                ProjectPart.Import<UnitData>(
                    dlgImport, "Unit",
                    (u) =>
                    {
                        UnitDataToUI(u);
                        btnSave_Click(sender, e);
                    });
            }
        }
    }
}
