namespace FrogForge.Editors
{
    partial class frmClassEditor : frmBaseEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FrogForge.Palette palette1 = new FrogForge.Palette();
            FrogForge.Palette palette2 = new FrogForge.Palette();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassEditor));
            this.lstClasses = new FrogForge.UserControls.ClassJSONBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.grpGrowths = new System.Windows.Forms.GroupBox();
            this.gthClassGrowths = new FrogForge.UserControls.GrowthsPanel();
            this.grpWeapon = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudWeaponWeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudWeaponHit = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudWeaponDamage = new System.Windows.Forms.NumericUpDown();
            this.nudWeaponRange = new System.Windows.Forms.NumericUpDown();
            this.txtWeaponName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbFlies = new System.Windows.Forms.CheckBox();
            this.cmbClassInclination = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.picIcon = new FrogForge.UserControls.PalettedPicturebox();
            this.grpBattleAnimations = new System.Windows.Forms.GroupBox();
            this.btnGenerateBase = new System.Windows.Forms.Button();
            this.balBattleAnimations = new FrogForge.UserControls.BattleAnimationsListEditor();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnRemove = new System.Windows.Forms.ToolStripButton();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpClass = new System.Windows.Forms.TabPage();
            this.grpAnimationData = new System.Windows.Forms.GroupBox();
            this.tbcAnimationExtraData = new System.Windows.Forms.TabControl();
            this.tbpWalk = new System.Windows.Forms.TabPage();
            this.nudWalkSpeed = new System.Windows.Forms.NumericUpDown();
            this.ckbWalkCustomSpeed = new System.Windows.Forms.CheckBox();
            this.tbpProjectile = new System.Windows.Forms.TabPage();
            this.btnProjectileLoad = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nudProjectileLocationY = new System.Windows.Forms.NumericUpDown();
            this.nudProjectileLocationX = new System.Windows.Forms.NumericUpDown();
            this.pnlProjectilePos = new System.Windows.Forms.Panel();
            this.picProjectileIndicator = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.picProjectile = new FrogForge.UserControls.PalettedPicturebox();
            this.tbpTeleport = new System.Windows.Forms.TabPage();
            this.ckbTeleportBackstab = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbClassAnimationModeRanged = new System.Windows.Forms.ComboBox();
            this.cmbClassAnimationModeMelee = new System.Windows.Forms.ComboBox();
            this.tbpUnit = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUnitDeathQuote = new FrogForge.UserControls.EventTextBox();
            this.lstUnits = new FrogForge.UserControls.UnitJSONBrowser();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUnitClass = new System.Windows.Forms.TextBox();
            this.txtUnitDisplayName = new System.Windows.Forms.TextBox();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gthUnitGrowths = new FrogForge.UserControls.GrowthsPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbUnitInclination = new System.Windows.Forms.ComboBox();
            this.grpGrowths.SuspendLayout();
            this.grpWeapon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponHit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponRange)).BeginInit();
            this.grpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.grpBattleAnimations.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tbpClass.SuspendLayout();
            this.grpAnimationData.SuspendLayout();
            this.tbcAnimationExtraData.SuspendLayout();
            this.tbpWalk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWalkSpeed)).BeginInit();
            this.tbpProjectile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProjectileLocationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProjectileLocationX)).BeginInit();
            this.pnlProjectilePos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectileIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile)).BeginInit();
            this.tbpTeleport.SuspendLayout();
            this.tbpUnit.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstClasses
            // 
            this.lstClasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstClasses.FormattingEnabled = true;
            this.lstClasses.Location = new System.Drawing.Point(0, 0);
            this.lstClasses.Name = "lstClasses";
            this.lstClasses.Size = new System.Drawing.Size(120, 199);
            this.lstClasses.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(170, 0);
            this.txtClassName.MaxLength = 8;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(100, 20);
            this.txtClassName.TabIndex = 3;
            // 
            // grpGrowths
            // 
            this.grpGrowths.Controls.Add(this.gthClassGrowths);
            this.grpGrowths.Location = new System.Drawing.Point(126, 52);
            this.grpGrowths.Name = "grpGrowths";
            this.grpGrowths.Size = new System.Drawing.Size(246, 75);
            this.grpGrowths.TabIndex = 4;
            this.grpGrowths.TabStop = false;
            this.grpGrowths.Text = "Growths";
            // 
            // gthClassGrowths
            // 
            this.gthClassGrowths.Location = new System.Drawing.Point(6, 19);
            this.gthClassGrowths.Name = "gthClassGrowths";
            this.gthClassGrowths.Size = new System.Drawing.Size(234, 49);
            this.gthClassGrowths.TabIndex = 0;
            // 
            // grpWeapon
            // 
            this.grpWeapon.Controls.Add(this.label7);
            this.grpWeapon.Controls.Add(this.label6);
            this.grpWeapon.Controls.Add(this.nudWeaponWeight);
            this.grpWeapon.Controls.Add(this.label5);
            this.grpWeapon.Controls.Add(this.nudWeaponHit);
            this.grpWeapon.Controls.Add(this.label4);
            this.grpWeapon.Controls.Add(this.nudWeaponDamage);
            this.grpWeapon.Controls.Add(this.nudWeaponRange);
            this.grpWeapon.Controls.Add(this.txtWeaponName);
            this.grpWeapon.Controls.Add(this.label3);
            this.grpWeapon.Location = new System.Drawing.Point(126, 133);
            this.grpWeapon.Name = "grpWeapon";
            this.grpWeapon.Size = new System.Drawing.Size(246, 71);
            this.grpWeapon.TabIndex = 5;
            this.grpWeapon.TabStop = false;
            this.grpWeapon.Text = "Weapon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Wt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hit:";
            // 
            // nudWeaponWeight
            // 
            this.nudWeaponWeight.Location = new System.Drawing.Point(204, 45);
            this.nudWeaponWeight.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudWeaponWeight.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.nudWeaponWeight.Name = "nudWeaponWeight";
            this.nudWeaponWeight.Size = new System.Drawing.Size(36, 20);
            this.nudWeaponWeight.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dmg:";
            // 
            // nudWeaponHit
            // 
            this.nudWeaponHit.Location = new System.Drawing.Point(124, 45);
            this.nudWeaponHit.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudWeaponHit.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.nudWeaponHit.Name = "nudWeaponHit";
            this.nudWeaponHit.Size = new System.Drawing.Size(36, 20);
            this.nudWeaponHit.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Range:";
            // 
            // nudWeaponDamage
            // 
            this.nudWeaponDamage.Location = new System.Drawing.Point(44, 45);
            this.nudWeaponDamage.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudWeaponDamage.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.nudWeaponDamage.Name = "nudWeaponDamage";
            this.nudWeaponDamage.Size = new System.Drawing.Size(36, 20);
            this.nudWeaponDamage.TabIndex = 4;
            // 
            // nudWeaponRange
            // 
            this.nudWeaponRange.Location = new System.Drawing.Point(204, 19);
            this.nudWeaponRange.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWeaponRange.Name = "nudWeaponRange";
            this.nudWeaponRange.Size = new System.Drawing.Size(36, 20);
            this.nudWeaponRange.TabIndex = 4;
            // 
            // txtWeaponName
            // 
            this.txtWeaponName.Location = new System.Drawing.Point(50, 19);
            this.txtWeaponName.Name = "txtWeaponName";
            this.txtWeaponName.Size = new System.Drawing.Size(100, 20);
            this.txtWeaponName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // ckbFlies
            // 
            this.ckbFlies.AutoSize = true;
            this.ckbFlies.Location = new System.Drawing.Point(276, 2);
            this.ckbFlies.Name = "ckbFlies";
            this.ckbFlies.Size = new System.Drawing.Size(47, 17);
            this.ckbFlies.TabIndex = 6;
            this.ckbFlies.Text = "Flies";
            this.ckbFlies.UseVisualStyleBackColor = true;
            // 
            // cmbClassInclination
            // 
            this.cmbClassInclination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassInclination.FormattingEnabled = true;
            this.cmbClassInclination.Items.AddRange(new object[] {
            "Physical",
            "Technical",
            "Skillful"});
            this.cmbClassInclination.Location = new System.Drawing.Point(190, 25);
            this.cmbClassInclination.Name = "cmbClassInclination";
            this.cmbClassInclination.Size = new System.Drawing.Size(133, 21);
            this.cmbClassInclination.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Inclination:";
            // 
            // grpImage
            // 
            this.grpImage.Controls.Add(this.picIcon);
            this.grpImage.Location = new System.Drawing.Point(329, 0);
            this.grpImage.Name = "grpImage";
            this.grpImage.Size = new System.Drawing.Size(43, 49);
            this.grpImage.TabIndex = 9;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "Icon";
            // 
            // picIcon
            // 
            this.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picIcon.Image = null;
            this.picIcon.Location = new System.Drawing.Point(12, 19);
            this.picIcon.Name = "picIcon";
            this.picIcon.Palette = palette1;
            this.picIcon.Size = new System.Drawing.Size(20, 20);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // grpBattleAnimations
            // 
            this.grpBattleAnimations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBattleAnimations.Controls.Add(this.btnGenerateBase);
            this.grpBattleAnimations.Controls.Add(this.balBattleAnimations);
            this.grpBattleAnimations.Location = new System.Drawing.Point(560, 0);
            this.grpBattleAnimations.Name = "grpBattleAnimations";
            this.grpBattleAnimations.Size = new System.Drawing.Size(193, 204);
            this.grpBattleAnimations.TabIndex = 10;
            this.grpBattleAnimations.TabStop = false;
            this.grpBattleAnimations.Text = "Battle animations";
            // 
            // btnGenerateBase
            // 
            this.btnGenerateBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateBase.Location = new System.Drawing.Point(6, 19);
            this.btnGenerateBase.Name = "btnGenerateBase";
            this.btnGenerateBase.Size = new System.Drawing.Size(181, 153);
            this.btnGenerateBase.TabIndex = 4;
            this.btnGenerateBase.Text = "Generate base";
            this.btnGenerateBase.UseVisualStyleBackColor = true;
            this.btnGenerateBase.Click += new System.EventHandler(this.btnGenerateBase_Click);
            // 
            // balBattleAnimations
            // 
            this.balBattleAnimations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.balBattleAnimations.Location = new System.Drawing.Point(6, 19);
            this.balBattleAnimations.Name = "balBattleAnimations";
            this.balBattleAnimations.Size = new System.Drawing.Size(181, 179);
            this.balBattleAnimations.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnNew,
            this.btnRemove});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(787, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::FrogForge.Properties.Resources.Save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = global::FrogForge.Properties.Resources.New;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 22);
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemove.Image = global::FrogForge.Properties.Resources.Delete;
            this.btnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(23, 22);
            this.btnRemove.Text = "Delete";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbcMain
            // 
            this.tbcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcMain.Controls.Add(this.tbpClass);
            this.tbcMain.Controls.Add(this.tbpUnit);
            this.tbcMain.Location = new System.Drawing.Point(12, 28);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(763, 231);
            this.tbcMain.TabIndex = 12;
            this.tbcMain.SelectedIndexChanged += new System.EventHandler(this.tbcMain_SelectedIndexChanged);
            // 
            // tbpClass
            // 
            this.tbpClass.Controls.Add(this.grpAnimationData);
            this.tbpClass.Controls.Add(this.lstClasses);
            this.tbpClass.Controls.Add(this.label1);
            this.tbpClass.Controls.Add(this.grpBattleAnimations);
            this.tbpClass.Controls.Add(this.txtClassName);
            this.tbpClass.Controls.Add(this.grpImage);
            this.tbpClass.Controls.Add(this.grpGrowths);
            this.tbpClass.Controls.Add(this.label2);
            this.tbpClass.Controls.Add(this.grpWeapon);
            this.tbpClass.Controls.Add(this.cmbClassInclination);
            this.tbpClass.Controls.Add(this.ckbFlies);
            this.tbpClass.Location = new System.Drawing.Point(4, 22);
            this.tbpClass.Name = "tbpClass";
            this.tbpClass.Padding = new System.Windows.Forms.Padding(3);
            this.tbpClass.Size = new System.Drawing.Size(755, 205);
            this.tbpClass.TabIndex = 0;
            this.tbpClass.Text = "Class";
            this.tbpClass.UseVisualStyleBackColor = true;
            // 
            // grpAnimationData
            // 
            this.grpAnimationData.Controls.Add(this.tbcAnimationExtraData);
            this.grpAnimationData.Controls.Add(this.label13);
            this.grpAnimationData.Controls.Add(this.label12);
            this.grpAnimationData.Controls.Add(this.cmbClassAnimationModeRanged);
            this.grpAnimationData.Controls.Add(this.cmbClassAnimationModeMelee);
            this.grpAnimationData.Location = new System.Drawing.Point(378, 0);
            this.grpAnimationData.Name = "grpAnimationData";
            this.grpAnimationData.Size = new System.Drawing.Size(176, 204);
            this.grpAnimationData.TabIndex = 11;
            this.grpAnimationData.TabStop = false;
            this.grpAnimationData.Text = "Animation data";
            // 
            // tbcAnimationExtraData
            // 
            this.tbcAnimationExtraData.Controls.Add(this.tbpWalk);
            this.tbcAnimationExtraData.Controls.Add(this.tbpProjectile);
            this.tbcAnimationExtraData.Controls.Add(this.tbpTeleport);
            this.tbcAnimationExtraData.Location = new System.Drawing.Point(6, 73);
            this.tbcAnimationExtraData.Name = "tbcAnimationExtraData";
            this.tbcAnimationExtraData.SelectedIndex = 0;
            this.tbcAnimationExtraData.Size = new System.Drawing.Size(164, 125);
            this.tbcAnimationExtraData.TabIndex = 3;
            // 
            // tbpWalk
            // 
            this.tbpWalk.Controls.Add(this.nudWalkSpeed);
            this.tbpWalk.Controls.Add(this.ckbWalkCustomSpeed);
            this.tbpWalk.Location = new System.Drawing.Point(4, 22);
            this.tbpWalk.Name = "tbpWalk";
            this.tbpWalk.Padding = new System.Windows.Forms.Padding(3);
            this.tbpWalk.Size = new System.Drawing.Size(156, 99);
            this.tbpWalk.TabIndex = 1;
            this.tbpWalk.Text = "Walk";
            this.tbpWalk.UseVisualStyleBackColor = true;
            // 
            // nudWalkSpeed
            // 
            this.nudWalkSpeed.DecimalPlaces = 1;
            this.nudWalkSpeed.Enabled = false;
            this.nudWalkSpeed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudWalkSpeed.Location = new System.Drawing.Point(99, 0);
            this.nudWalkSpeed.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudWalkSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWalkSpeed.Name = "nudWalkSpeed";
            this.nudWalkSpeed.Size = new System.Drawing.Size(57, 20);
            this.nudWalkSpeed.TabIndex = 1;
            this.nudWalkSpeed.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ckbWalkCustomSpeed
            // 
            this.ckbWalkCustomSpeed.AutoSize = true;
            this.ckbWalkCustomSpeed.Location = new System.Drawing.Point(0, 0);
            this.ckbWalkCustomSpeed.Name = "ckbWalkCustomSpeed";
            this.ckbWalkCustomSpeed.Size = new System.Drawing.Size(93, 17);
            this.ckbWalkCustomSpeed.TabIndex = 0;
            this.ckbWalkCustomSpeed.Text = "Custom speed";
            this.ckbWalkCustomSpeed.UseVisualStyleBackColor = true;
            this.ckbWalkCustomSpeed.CheckedChanged += new System.EventHandler(this.ckbWalkCustomSpeed_CheckedChanged);
            // 
            // tbpProjectile
            // 
            this.tbpProjectile.Controls.Add(this.btnProjectileLoad);
            this.tbpProjectile.Controls.Add(this.label17);
            this.tbpProjectile.Controls.Add(this.label16);
            this.tbpProjectile.Controls.Add(this.nudProjectileLocationY);
            this.tbpProjectile.Controls.Add(this.nudProjectileLocationX);
            this.tbpProjectile.Controls.Add(this.pnlProjectilePos);
            this.tbpProjectile.Controls.Add(this.label15);
            this.tbpProjectile.Controls.Add(this.label14);
            this.tbpProjectile.Controls.Add(this.picProjectile);
            this.tbpProjectile.Location = new System.Drawing.Point(4, 22);
            this.tbpProjectile.Name = "tbpProjectile";
            this.tbpProjectile.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProjectile.Size = new System.Drawing.Size(156, 99);
            this.tbpProjectile.TabIndex = 0;
            this.tbpProjectile.Text = "Projectile";
            this.tbpProjectile.UseVisualStyleBackColor = true;
            // 
            // btnProjectileLoad
            // 
            this.btnProjectileLoad.Location = new System.Drawing.Point(2, 76);
            this.btnProjectileLoad.Name = "btnProjectileLoad";
            this.btnProjectileLoad.Size = new System.Drawing.Size(44, 23);
            this.btnProjectileLoad.TabIndex = 14;
            this.btnProjectileLoad.Text = "Load";
            this.btnProjectileLoad.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Y:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(52, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "X:";
            // 
            // nudProjectileLocationY
            // 
            this.nudProjectileLocationY.Location = new System.Drawing.Point(75, 66);
            this.nudProjectileLocationY.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudProjectileLocationY.Name = "nudProjectileLocationY";
            this.nudProjectileLocationY.Size = new System.Drawing.Size(44, 20);
            this.nudProjectileLocationY.TabIndex = 10;
            // 
            // nudProjectileLocationX
            // 
            this.nudProjectileLocationX.Location = new System.Drawing.Point(75, 40);
            this.nudProjectileLocationX.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudProjectileLocationX.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            -2147483648});
            this.nudProjectileLocationX.Name = "nudProjectileLocationX";
            this.nudProjectileLocationX.Size = new System.Drawing.Size(44, 20);
            this.nudProjectileLocationX.TabIndex = 11;
            // 
            // pnlProjectilePos
            // 
            this.pnlProjectilePos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProjectilePos.Controls.Add(this.picProjectileIndicator);
            this.pnlProjectilePos.Location = new System.Drawing.Point(2, 40);
            this.pnlProjectilePos.Name = "pnlProjectilePos";
            this.pnlProjectilePos.Size = new System.Drawing.Size(44, 36);
            this.pnlProjectilePos.TabIndex = 9;
            // 
            // picProjectileIndicator
            // 
            this.picProjectileIndicator.Location = new System.Drawing.Point(0, 0);
            this.picProjectileIndicator.Name = "picProjectileIndicator";
            this.picProjectileIndicator.Size = new System.Drawing.Size(8, 8);
            this.picProjectileIndicator.TabIndex = 0;
            this.picProjectileIndicator.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(-1, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Location:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-1, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Projectile:";
            // 
            // picProjectile
            // 
            this.picProjectile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picProjectile.Image = null;
            this.picProjectile.Location = new System.Drawing.Point(75, 1);
            this.picProjectile.Name = "picProjectile";
            this.picProjectile.Palette = palette2;
            this.picProjectile.Size = new System.Drawing.Size(12, 12);
            this.picProjectile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picProjectile.TabIndex = 6;
            this.picProjectile.TabStop = false;
            // 
            // tbpTeleport
            // 
            this.tbpTeleport.Controls.Add(this.ckbTeleportBackstab);
            this.tbpTeleport.Location = new System.Drawing.Point(4, 22);
            this.tbpTeleport.Name = "tbpTeleport";
            this.tbpTeleport.Size = new System.Drawing.Size(156, 99);
            this.tbpTeleport.TabIndex = 2;
            this.tbpTeleport.Text = "Teleport";
            this.tbpTeleport.UseVisualStyleBackColor = true;
            // 
            // ckbTeleportBackstab
            // 
            this.ckbTeleportBackstab.AutoSize = true;
            this.ckbTeleportBackstab.Location = new System.Drawing.Point(0, 0);
            this.ckbTeleportBackstab.Name = "ckbTeleportBackstab";
            this.ckbTeleportBackstab.Size = new System.Drawing.Size(71, 17);
            this.ckbTeleportBackstab.TabIndex = 0;
            this.ckbTeleportBackstab.Text = "Backstab";
            this.ckbTeleportBackstab.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Ranged mode:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Melee mode:";
            // 
            // cmbClassAnimationModeRanged
            // 
            this.cmbClassAnimationModeRanged.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassAnimationModeRanged.FormattingEnabled = true;
            this.cmbClassAnimationModeRanged.Location = new System.Drawing.Point(89, 46);
            this.cmbClassAnimationModeRanged.Name = "cmbClassAnimationModeRanged";
            this.cmbClassAnimationModeRanged.Size = new System.Drawing.Size(81, 21);
            this.cmbClassAnimationModeRanged.TabIndex = 0;
            // 
            // cmbClassAnimationModeMelee
            // 
            this.cmbClassAnimationModeMelee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassAnimationModeMelee.FormattingEnabled = true;
            this.cmbClassAnimationModeMelee.Location = new System.Drawing.Point(89, 19);
            this.cmbClassAnimationModeMelee.Name = "cmbClassAnimationModeMelee";
            this.cmbClassAnimationModeMelee.Size = new System.Drawing.Size(81, 21);
            this.cmbClassAnimationModeMelee.TabIndex = 0;
            // 
            // tbpUnit
            // 
            this.tbpUnit.Controls.Add(this.groupBox3);
            this.tbpUnit.Controls.Add(this.lstUnits);
            this.tbpUnit.Controls.Add(this.label10);
            this.tbpUnit.Controls.Add(this.label11);
            this.tbpUnit.Controls.Add(this.label8);
            this.tbpUnit.Controls.Add(this.txtUnitClass);
            this.tbpUnit.Controls.Add(this.txtUnitDisplayName);
            this.tbpUnit.Controls.Add(this.txtUnitName);
            this.tbpUnit.Controls.Add(this.groupBox1);
            this.tbpUnit.Controls.Add(this.label9);
            this.tbpUnit.Controls.Add(this.cmbUnitInclination);
            this.tbpUnit.Location = new System.Drawing.Point(4, 22);
            this.tbpUnit.Name = "tbpUnit";
            this.tbpUnit.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUnit.Size = new System.Drawing.Size(755, 205);
            this.tbpUnit.TabIndex = 1;
            this.tbpUnit.Text = "Unit";
            this.tbpUnit.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtUnitDeathQuote);
            this.groupBox3.Location = new System.Drawing.Point(378, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 204);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Death event";
            // 
            // txtUnitDeathQuote
            // 
            this.txtUnitDeathQuote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnitDeathQuote.Location = new System.Drawing.Point(7, 20);
            this.txtUnitDeathQuote.Name = "txtUnitDeathQuote";
            this.txtUnitDeathQuote.Size = new System.Drawing.Size(362, 178);
            this.txtUnitDeathQuote.TabIndex = 0;
            // 
            // lstUnits
            // 
            this.lstUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstUnits.FormattingEnabled = true;
            this.lstUnits.Location = new System.Drawing.Point(0, 0);
            this.lstUnits.Name = "lstUnits";
            this.lstUnits.Size = new System.Drawing.Size(120, 199);
            this.lstUnits.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Class:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(126, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Display name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Name:";
            // 
            // txtUnitClass
            // 
            this.txtUnitClass.Location = new System.Drawing.Point(205, 52);
            this.txtUnitClass.MaxLength = 8;
            this.txtUnitClass.Name = "txtUnitClass";
            this.txtUnitClass.Size = new System.Drawing.Size(167, 20);
            this.txtUnitClass.TabIndex = 1;
            // 
            // txtUnitDisplayName
            // 
            this.txtUnitDisplayName.Location = new System.Drawing.Point(205, 26);
            this.txtUnitDisplayName.MaxLength = 8;
            this.txtUnitDisplayName.Name = "txtUnitDisplayName";
            this.txtUnitDisplayName.Size = new System.Drawing.Size(167, 20);
            this.txtUnitDisplayName.TabIndex = 0;
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(205, 0);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(167, 20);
            this.txtUnitName.TabIndex = 0;
            this.txtUnitName.TextChanged += new System.EventHandler(this.txtUnitName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gthUnitGrowths);
            this.groupBox1.Location = new System.Drawing.Point(126, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 75);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Growths";
            // 
            // gthUnitGrowths
            // 
            this.gthUnitGrowths.Location = new System.Drawing.Point(6, 19);
            this.gthUnitGrowths.Name = "gthUnitGrowths";
            this.gthUnitGrowths.Size = new System.Drawing.Size(234, 49);
            this.gthUnitGrowths.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Inclination:";
            // 
            // cmbUnitInclination
            // 
            this.cmbUnitInclination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitInclination.FormattingEnabled = true;
            this.cmbUnitInclination.Items.AddRange(new object[] {
            "Physical",
            "Technical",
            "Skillful"});
            this.cmbUnitInclination.Location = new System.Drawing.Point(205, 78);
            this.cmbUnitInclination.Name = "cmbUnitInclination";
            this.cmbUnitInclination.Size = new System.Drawing.Size(167, 21);
            this.cmbUnitInclination.TabIndex = 2;
            // 
            // frmClassEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 271);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmClassEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Class + Unit Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClassEditor_FormClosed);
            this.Load += new System.EventHandler(this.frmClassEditor_Load);
            this.grpGrowths.ResumeLayout(false);
            this.grpWeapon.ResumeLayout(false);
            this.grpWeapon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponHit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponRange)).EndInit();
            this.grpImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.grpBattleAnimations.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbcMain.ResumeLayout(false);
            this.tbpClass.ResumeLayout(false);
            this.tbpClass.PerformLayout();
            this.grpAnimationData.ResumeLayout(false);
            this.grpAnimationData.PerformLayout();
            this.tbcAnimationExtraData.ResumeLayout(false);
            this.tbpWalk.ResumeLayout(false);
            this.tbpWalk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWalkSpeed)).EndInit();
            this.tbpProjectile.ResumeLayout(false);
            this.tbpProjectile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProjectileLocationY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProjectileLocationX)).EndInit();
            this.pnlProjectilePos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProjectileIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile)).EndInit();
            this.tbpTeleport.ResumeLayout(false);
            this.tbpTeleport.PerformLayout();
            this.tbpUnit.ResumeLayout(false);
            this.tbpUnit.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FrogForge.UserControls.ClassJSONBrowser lstClasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.GroupBox grpGrowths;
        private System.Windows.Forms.GroupBox grpWeapon;
        private System.Windows.Forms.CheckBox ckbFlies;
        private System.Windows.Forms.ComboBox cmbClassInclination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.NumericUpDown nudWeaponRange;
        private System.Windows.Forms.TextBox txtWeaponName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudWeaponDamage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudWeaponHit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudWeaponWeight;
        private FrogForge.UserControls.PalettedPicturebox picIcon;
        private System.Windows.Forms.GroupBox grpBattleAnimations;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnRemove;
        private System.Windows.Forms.Button btnGenerateBase;
        private UserControls.BattleAnimationsListEditor balBattleAnimations;
        private UserControls.GrowthsPanel gthClassGrowths;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpClass;
        private System.Windows.Forms.TabPage tbpUnit;
        private UserControls.UnitJSONBrowser lstUnits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.GroupBox groupBox1;
        private UserControls.GrowthsPanel gthUnitGrowths;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbUnitInclination;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUnitClass;
        private System.Windows.Forms.GroupBox groupBox3;
        private UserControls.EventTextBox txtUnitDeathQuote;
        private System.Windows.Forms.GroupBox grpAnimationData;
        private System.Windows.Forms.ComboBox cmbClassAnimationModeMelee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbClassAnimationModeRanged;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUnitDisplayName;
        private System.Windows.Forms.TabControl tbcAnimationExtraData;
        private System.Windows.Forms.TabPage tbpWalk;
        private System.Windows.Forms.TabPage tbpProjectile;
        private System.Windows.Forms.Button btnProjectileLoad;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudProjectileLocationY;
        private System.Windows.Forms.NumericUpDown nudProjectileLocationX;
        private System.Windows.Forms.Panel pnlProjectilePos;
        private System.Windows.Forms.PictureBox picProjectileIndicator;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private UserControls.PalettedPicturebox picProjectile;
        private System.Windows.Forms.TabPage tbpTeleport;
        private System.Windows.Forms.CheckBox ckbWalkCustomSpeed;
        private System.Windows.Forms.NumericUpDown nudWalkSpeed;
        private System.Windows.Forms.CheckBox ckbTeleportBackstab;
    }
}