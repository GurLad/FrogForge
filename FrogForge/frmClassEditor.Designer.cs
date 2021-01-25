namespace FrogForge
{
    partial class frmClassEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassEditor));
            this.lstClasses = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpGrowths = new System.Windows.Forms.GroupBox();
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
            this.cmbInclination = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.picIcon = new FrogForge.AnimationPicturebox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpWeapon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponHit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponRange)).BeginInit();
            this.grpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lstClasses
            // 
            this.lstClasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstClasses.FormattingEnabled = true;
            this.lstClasses.Location = new System.Drawing.Point(13, 13);
            this.lstClasses.Name = "lstClasses";
            this.lstClasses.Size = new System.Drawing.Size(120, 199);
            this.lstClasses.TabIndex = 0;
            this.lstClasses.DoubleClick += new System.EventHandler(this.lstClasses_DoubleClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(13, 224);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // grpGrowths
            // 
            this.grpGrowths.Location = new System.Drawing.Point(139, 65);
            this.grpGrowths.Name = "grpGrowths";
            this.grpGrowths.Size = new System.Drawing.Size(246, 76);
            this.grpGrowths.TabIndex = 4;
            this.grpGrowths.TabStop = false;
            this.grpGrowths.Text = "Growths";
            // 
            // grpWeapon
            // 
            this.grpWeapon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.grpWeapon.Location = new System.Drawing.Point(139, 147);
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
            this.ckbFlies.Location = new System.Drawing.Point(289, 15);
            this.ckbFlies.Name = "ckbFlies";
            this.ckbFlies.Size = new System.Drawing.Size(47, 17);
            this.ckbFlies.TabIndex = 6;
            this.ckbFlies.Text = "Flies";
            this.ckbFlies.UseVisualStyleBackColor = true;
            // 
            // cmbInclination
            // 
            this.cmbInclination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInclination.FormattingEnabled = true;
            this.cmbInclination.Items.AddRange(new object[] {
            "Physical",
            "Technical",
            "Skillful"});
            this.cmbInclination.Location = new System.Drawing.Point(203, 38);
            this.cmbInclination.Name = "cmbInclination";
            this.cmbInclination.Size = new System.Drawing.Size(133, 21);
            this.cmbInclination.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Inclination:";
            // 
            // grpImage
            // 
            this.grpImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpImage.Controls.Add(this.picIcon);
            this.grpImage.Location = new System.Drawing.Point(342, 10);
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
            this.picIcon.Location = new System.Drawing.Point(12, 20);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(20, 20);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(139, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(246, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmClassEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 260);
            this.Controls.Add(this.grpImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbInclination);
            this.Controls.Add(this.ckbFlies);
            this.Controls.Add(this.grpWeapon);
            this.Controls.Add(this.grpGrowths);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstClasses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmClassEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Class Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClassEditor_FormClosed);
            this.Load += new System.EventHandler(this.frmClassEditor_Load);
            this.grpWeapon.ResumeLayout(false);
            this.grpWeapon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponHit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeaponRange)).EndInit();
            this.grpImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstClasses;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpGrowths;
        private System.Windows.Forms.GroupBox grpWeapon;
        private System.Windows.Forms.CheckBox ckbFlies;
        private System.Windows.Forms.ComboBox cmbInclination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.Button btnSave;
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
        private AnimationPicturebox picIcon;
    }
}