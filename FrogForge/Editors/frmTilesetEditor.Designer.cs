namespace FrogForge.Editors
{
    partial class frmTilesetEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTilesetEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.lstTilemaps = new FrogForge.UserControls.TilemapJSONBrowser();
            this.plt1 = new FrogForge.UserControls.PalettePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.plt2 = new FrogForge.UserControls.PalettePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbSelectionPush = new System.Windows.Forms.RadioButton();
            this.rdbSelectionSwap = new System.Windows.Forms.RadioButton();
            this.rdbSelectionSelect = new System.Windows.Forms.RadioButton();
            this.grpSelectedTile = new System.Windows.Forms.GroupBox();
            this.picTileImage = new FrogForge.UserControls.AnimationPicturebox();
            this.btnTileApply = new System.Windows.Forms.Button();
            this.rdbPlt2 = new System.Windows.Forms.RadioButton();
            this.rdbPlt1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.ckbAutoApply = new System.Windows.Forms.CheckBox();
            this.ckbHigh = new System.Windows.Forms.CheckBox();
            this.ckbWall = new System.Windows.Forms.CheckBox();
            this.nudArmorMod = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudMoveCost = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoveTiles = new System.Windows.Forms.Button();
            this.btnAddTiles = new System.Windows.Forms.Button();
            this.pnlPossibleTiles = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpSelectedTile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArmorMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveCost)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnNew,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(628, 25);
            this.toolStrip1.TabIndex = 18;
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
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = global::FrogForge.Properties.Resources.Delete;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstTilemaps
            // 
            this.lstTilemaps.FormattingEnabled = true;
            this.lstTilemaps.Location = new System.Drawing.Point(12, 28);
            this.lstTilemaps.Name = "lstTilemaps";
            this.lstTilemaps.Size = new System.Drawing.Size(126, 329);
            this.lstTilemaps.TabIndex = 19;
            // 
            // plt1
            // 
            this.plt1.Location = new System.Drawing.Point(352, 28);
            this.plt1.Name = "plt1";
            this.plt1.Size = new System.Drawing.Size(100, 20);
            this.plt1.SpritePalette = false;
            this.plt1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Palette 1:";
            // 
            // plt2
            // 
            this.plt2.Location = new System.Drawing.Point(516, 28);
            this.plt2.Name = "plt2";
            this.plt2.Size = new System.Drawing.Size(100, 20);
            this.plt2.SpritePalette = false;
            this.plt2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Palette 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(188, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.grpSelectedTile);
            this.groupBox1.Controls.Add(this.btnRemoveTiles);
            this.groupBox1.Controls.Add(this.btnAddTiles);
            this.groupBox1.Controls.Add(this.pnlPossibleTiles);
            this.groupBox1.Location = new System.Drawing.Point(144, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 303);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiles data";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbSelectionPush);
            this.groupBox4.Controls.Add(this.rdbSelectionSwap);
            this.groupBox4.Controls.Add(this.rdbSelectionSelect);
            this.groupBox4.Location = new System.Drawing.Point(6, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 54);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Selection mode";
            // 
            // rdbSelectionPush
            // 
            this.rdbSelectionPush.AutoSize = true;
            this.rdbSelectionPush.Location = new System.Drawing.Point(125, 19);
            this.rdbSelectionPush.Name = "rdbSelectionPush";
            this.rdbSelectionPush.Size = new System.Drawing.Size(49, 17);
            this.rdbSelectionPush.TabIndex = 0;
            this.rdbSelectionPush.Text = "Push";
            this.rdbSelectionPush.UseVisualStyleBackColor = true;
            // 
            // rdbSelectionSwap
            // 
            this.rdbSelectionSwap.AutoSize = true;
            this.rdbSelectionSwap.Location = new System.Drawing.Point(67, 19);
            this.rdbSelectionSwap.Name = "rdbSelectionSwap";
            this.rdbSelectionSwap.Size = new System.Drawing.Size(52, 17);
            this.rdbSelectionSwap.TabIndex = 0;
            this.rdbSelectionSwap.Text = "Swap";
            this.rdbSelectionSwap.UseVisualStyleBackColor = true;
            // 
            // rdbSelectionSelect
            // 
            this.rdbSelectionSelect.AutoSize = true;
            this.rdbSelectionSelect.Checked = true;
            this.rdbSelectionSelect.Location = new System.Drawing.Point(6, 19);
            this.rdbSelectionSelect.Name = "rdbSelectionSelect";
            this.rdbSelectionSelect.Size = new System.Drawing.Size(55, 17);
            this.rdbSelectionSelect.TabIndex = 0;
            this.rdbSelectionSelect.TabStop = true;
            this.rdbSelectionSelect.Text = "Select";
            this.rdbSelectionSelect.UseVisualStyleBackColor = true;
            // 
            // grpSelectedTile
            // 
            this.grpSelectedTile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSelectedTile.Controls.Add(this.picTileImage);
            this.grpSelectedTile.Controls.Add(this.btnTileApply);
            this.grpSelectedTile.Controls.Add(this.rdbPlt2);
            this.grpSelectedTile.Controls.Add(this.rdbPlt1);
            this.grpSelectedTile.Controls.Add(this.label7);
            this.grpSelectedTile.Controls.Add(this.ckbAutoApply);
            this.grpSelectedTile.Controls.Add(this.ckbHigh);
            this.grpSelectedTile.Controls.Add(this.ckbWall);
            this.grpSelectedTile.Controls.Add(this.nudArmorMod);
            this.grpSelectedTile.Controls.Add(this.label6);
            this.grpSelectedTile.Controls.Add(this.nudMoveCost);
            this.grpSelectedTile.Controls.Add(this.label5);
            this.grpSelectedTile.Controls.Add(this.txtTileName);
            this.grpSelectedTile.Controls.Add(this.label4);
            this.grpSelectedTile.Location = new System.Drawing.Point(109, 20);
            this.grpSelectedTile.Name = "grpSelectedTile";
            this.grpSelectedTile.Size = new System.Drawing.Size(165, 159);
            this.grpSelectedTile.TabIndex = 31;
            this.grpSelectedTile.TabStop = false;
            this.grpSelectedTile.Text = "Selected";
            // 
            // picTileImage
            // 
            this.picTileImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picTileImage.Image = null;
            this.picTileImage.Location = new System.Drawing.Point(139, 19);
            this.picTileImage.Name = "picTileImage";
            this.picTileImage.Palette = palette1;
            this.picTileImage.Size = new System.Drawing.Size(20, 20);
            this.picTileImage.TabIndex = 29;
            this.picTileImage.TabStop = false;
            // 
            // btnTileApply
            // 
            this.btnTileApply.Location = new System.Drawing.Point(6, 130);
            this.btnTileApply.Name = "btnTileApply";
            this.btnTileApply.Size = new System.Drawing.Size(100, 23);
            this.btnTileApply.TabIndex = 28;
            this.btnTileApply.Text = "Apply";
            this.btnTileApply.UseVisualStyleBackColor = true;
            this.btnTileApply.Click += new System.EventHandler(this.btnTileApply_Click);
            // 
            // rdbPlt2
            // 
            this.rdbPlt2.AutoSize = true;
            this.rdbPlt2.Location = new System.Drawing.Point(112, 97);
            this.rdbPlt2.Name = "rdbPlt2";
            this.rdbPlt2.Size = new System.Drawing.Size(31, 17);
            this.rdbPlt2.TabIndex = 27;
            this.rdbPlt2.Text = "2";
            this.rdbPlt2.UseVisualStyleBackColor = true;
            // 
            // rdbPlt1
            // 
            this.rdbPlt1.AutoSize = true;
            this.rdbPlt1.Checked = true;
            this.rdbPlt1.Location = new System.Drawing.Point(72, 97);
            this.rdbPlt1.Name = "rdbPlt1";
            this.rdbPlt1.Size = new System.Drawing.Size(31, 17);
            this.rdbPlt1.TabIndex = 27;
            this.rdbPlt1.TabStop = true;
            this.rdbPlt1.Text = "1";
            this.rdbPlt1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Palette:";
            // 
            // ckbAutoApply
            // 
            this.ckbAutoApply.AutoSize = true;
            this.ckbAutoApply.Checked = true;
            this.ckbAutoApply.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAutoApply.Location = new System.Drawing.Point(112, 134);
            this.ckbAutoApply.Name = "ckbAutoApply";
            this.ckbAutoApply.Size = new System.Drawing.Size(48, 17);
            this.ckbAutoApply.TabIndex = 25;
            this.ckbAutoApply.Text = "Auto";
            this.ckbAutoApply.UseVisualStyleBackColor = true;
            // 
            // ckbHigh
            // 
            this.ckbHigh.AutoSize = true;
            this.ckbHigh.Location = new System.Drawing.Point(112, 72);
            this.ckbHigh.Name = "ckbHigh";
            this.ckbHigh.Size = new System.Drawing.Size(48, 17);
            this.ckbHigh.TabIndex = 25;
            this.ckbHigh.Text = "High";
            this.ckbHigh.UseVisualStyleBackColor = true;
            // 
            // ckbWall
            // 
            this.ckbWall.AutoSize = true;
            this.ckbWall.Location = new System.Drawing.Point(112, 46);
            this.ckbWall.Name = "ckbWall";
            this.ckbWall.Size = new System.Drawing.Size(47, 17);
            this.ckbWall.TabIndex = 25;
            this.ckbWall.Text = "Wall";
            this.ckbWall.UseVisualStyleBackColor = true;
            this.ckbWall.CheckedChanged += new System.EventHandler(this.ckbWall_CheckedChanged);
            // 
            // nudArmorMod
            // 
            this.nudArmorMod.Location = new System.Drawing.Point(72, 71);
            this.nudArmorMod.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudArmorMod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudArmorMod.Name = "nudArmorMod";
            this.nudArmorMod.Size = new System.Drawing.Size(34, 20);
            this.nudArmorMod.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Armor mod:";
            // 
            // nudMoveCost
            // 
            this.nudMoveCost.Location = new System.Drawing.Point(72, 45);
            this.nudMoveCost.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMoveCost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMoveCost.Name = "nudMoveCost";
            this.nudMoveCost.Size = new System.Drawing.Size(34, 20);
            this.nudMoveCost.TabIndex = 24;
            this.nudMoveCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Move cost:";
            // 
            // txtTileName
            // 
            this.txtTileName.Location = new System.Drawing.Point(50, 19);
            this.txtTileName.Name = "txtTileName";
            this.txtTileName.Size = new System.Drawing.Size(83, 20);
            this.txtTileName.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Name:";
            // 
            // btnRemoveTiles
            // 
            this.btnRemoveTiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveTiles.Location = new System.Drawing.Point(6, 274);
            this.btnRemoveTiles.Name = "btnRemoveTiles";
            this.btnRemoveTiles.Size = new System.Drawing.Size(268, 23);
            this.btnRemoveTiles.TabIndex = 30;
            this.btnRemoveTiles.Text = "Remove";
            this.btnRemoveTiles.UseVisualStyleBackColor = true;
            this.btnRemoveTiles.Click += new System.EventHandler(this.btnRemoveTiles_Click);
            // 
            // btnAddTiles
            // 
            this.btnAddTiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTiles.Location = new System.Drawing.Point(6, 245);
            this.btnAddTiles.Name = "btnAddTiles";
            this.btnAddTiles.Size = new System.Drawing.Size(268, 23);
            this.btnAddTiles.TabIndex = 30;
            this.btnAddTiles.Text = "Add";
            this.btnAddTiles.UseVisualStyleBackColor = true;
            this.btnAddTiles.Click += new System.EventHandler(this.btnAddTiles_Click);
            // 
            // pnlPossibleTiles
            // 
            this.pnlPossibleTiles.Location = new System.Drawing.Point(6, 19);
            this.pnlPossibleTiles.Name = "pnlPossibleTiles";
            this.pnlPossibleTiles.Size = new System.Drawing.Size(96, 160);
            this.pnlPossibleTiles.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(430, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 303);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Battle backgrounds data (TBA)";
            // 
            // frmTilesetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 369);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plt2);
            this.Controls.Add(this.plt1);
            this.Controls.Add(this.lstTilemaps);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTilesetEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tileset Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTilesetEditor_FormClosed);
            this.Load += new System.EventHandler(this.frmTilesetEditor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpSelectedTile.ResumeLayout(false);
            this.grpSelectedTile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArmorMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private UserControls.TilemapJSONBrowser lstTilemaps;
        private UserControls.PalettePanel plt1;
        private System.Windows.Forms.Label label1;
        private UserControls.PalettePanel plt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlPossibleTiles;
        private System.Windows.Forms.Button btnAddTiles;
        private System.Windows.Forms.Button btnRemoveTiles;
        private System.Windows.Forms.GroupBox grpSelectedTile;
        private System.Windows.Forms.TextBox txtTileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbWall;
        private System.Windows.Forms.NumericUpDown nudMoveCost;
        private System.Windows.Forms.NumericUpDown nudArmorMod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbPlt1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbPlt2;
        private System.Windows.Forms.CheckBox ckbHigh;
        private System.Windows.Forms.Button btnTileApply;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbSelectionSelect;
        private System.Windows.Forms.RadioButton rdbSelectionSwap;
        private System.Windows.Forms.RadioButton rdbSelectionPush;
        private UserControls.AnimationPicturebox picTileImage;
        private System.Windows.Forms.CheckBox ckbAutoApply;
    }
}