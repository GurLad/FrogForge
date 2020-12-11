namespace FrogForge
{
    partial class frmLevelEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevelEditor));
            this.pnlPossibleTiles = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlRenderer = new System.Windows.Forms.Panel();
            this.pnlBG = new System.Windows.Forms.Panel();
            this.picPreview = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstUnits = new System.Windows.Forms.ListBox();
            this.btnPlace = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.cmbUnitTeam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudLevelNumber = new System.Windows.Forms.NumericUpDown();
            this.cmbTileSets = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcUI = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtLevelName = new System.Windows.Forms.TextBox();
            this.flbFiles = new FrogForge.FileBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpUnitList = new System.Windows.Forms.GroupBox();
            this.cmbAIType = new System.Windows.Forms.ComboBox();
            this.nudReinforcementTurn = new System.Windows.Forms.NumericUpDown();
            this.ckbStatue = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtBossName = new System.Windows.Forms.TextBox();
            this.rdbDefeatBoss = new System.Windows.Forms.RadioButton();
            this.rdbRout = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelNumber)).BeginInit();
            this.tbcUI.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpUnitList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReinforcementTurn)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPossibleTiles
            // 
            this.pnlPossibleTiles.Location = new System.Drawing.Point(0, 0);
            this.pnlPossibleTiles.Name = "pnlPossibleTiles";
            this.pnlPossibleTiles.Size = new System.Drawing.Size(96, 161);
            this.pnlPossibleTiles.TabIndex = 28;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(139, 191);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // pnlRenderer
            // 
            this.pnlRenderer.Location = new System.Drawing.Point(12, 12);
            this.pnlRenderer.Name = "pnlRenderer";
            this.pnlRenderer.Size = new System.Drawing.Size(256, 240);
            this.pnlRenderer.TabIndex = 13;
            // 
            // pnlBG
            // 
            this.pnlBG.Location = new System.Drawing.Point(12, 12);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(256, 240);
            this.pnlBG.TabIndex = 14;
            // 
            // picPreview
            // 
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Location = new System.Drawing.Point(102, -1);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(18, 18);
            this.picPreview.TabIndex = 29;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(6, 179);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstUnits
            // 
            this.lstUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstUnits.FormattingEnabled = true;
            this.lstUnits.Location = new System.Drawing.Point(6, 19);
            this.lstUnits.Name = "lstUnits";
            this.lstUnits.Size = new System.Drawing.Size(106, 147);
            this.lstUnits.TabIndex = 4;
            // 
            // btnPlace
            // 
            this.btnPlace.Location = new System.Drawing.Point(0, 191);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(124, 23);
            this.btnPlace.TabIndex = 3;
            this.btnPlace.Text = "Place";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(40, 0);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(84, 20);
            this.txtClass.TabIndex = 2;
            // 
            // nudLevel
            // 
            this.nudLevel.Location = new System.Drawing.Point(40, 53);
            this.nudLevel.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(84, 20);
            this.nudLevel.TabIndex = 1;
            // 
            // cmbUnitTeam
            // 
            this.cmbUnitTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitTeam.FormattingEnabled = true;
            this.cmbUnitTeam.Items.AddRange(new object[] {
            "Player",
            "Monster",
            "Guard"});
            this.cmbUnitTeam.Location = new System.Drawing.Point(40, 26);
            this.cmbUnitTeam.Name = "cmbUnitTeam";
            this.cmbUnitTeam.Size = new System.Drawing.Size(84, 21);
            this.cmbUnitTeam.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Level number:";
            // 
            // nudLevelNumber
            // 
            this.nudLevelNumber.Location = new System.Drawing.Point(84, 192);
            this.nudLevelNumber.Name = "nudLevelNumber";
            this.nudLevelNumber.Size = new System.Drawing.Size(49, 20);
            this.nudLevelNumber.TabIndex = 33;
            // 
            // cmbTileSets
            // 
            this.cmbTileSets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTileSets.FormattingEnabled = true;
            this.cmbTileSets.Location = new System.Drawing.Point(54, 165);
            this.cmbTileSets.Name = "cmbTileSets";
            this.cmbTileSets.Size = new System.Drawing.Size(79, 21);
            this.cmbTileSets.TabIndex = 32;
            this.cmbTileSets.SelectedIndexChanged += new System.EventHandler(this.cmbTileSets_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tile set:";
            // 
            // tbcUI
            // 
            this.tbcUI.Controls.Add(this.tabPage1);
            this.tbcUI.Controls.Add(this.tabPage2);
            this.tbcUI.Controls.Add(this.tabPage3);
            this.tbcUI.Location = new System.Drawing.Point(274, 12);
            this.tbcUI.Name = "tbcUI";
            this.tbcUI.SelectedIndex = 0;
            this.tbcUI.Size = new System.Drawing.Size(256, 240);
            this.tbcUI.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbTileSets);
            this.tabPage1.Controls.Add(this.txtLevelName);
            this.tabPage1.Controls.Add(this.flbFiles);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nudLevelNumber);
            this.tabPage1.Controls.Add(this.pnlPossibleTiles);
            this.tabPage1.Controls.Add(this.picPreview);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(248, 214);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tiles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtLevelName
            // 
            this.txtLevelName.Location = new System.Drawing.Point(139, 165);
            this.txtLevelName.Name = "txtLevelName";
            this.txtLevelName.Size = new System.Drawing.Size(109, 20);
            this.txtLevelName.TabIndex = 36;
            // 
            // flbFiles
            // 
            this.flbFiles.Location = new System.Drawing.Point(139, 0);
            this.flbFiles.Name = "flbFiles";
            this.flbFiles.Size = new System.Drawing.Size(109, 159);
            this.flbFiles.TabIndex = 35;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.grpUnitList);
            this.tabPage2.Controls.Add(this.cmbAIType);
            this.tabPage2.Controls.Add(this.cmbUnitTeam);
            this.tabPage2.Controls.Add(this.btnPlace);
            this.tabPage2.Controls.Add(this.nudReinforcementTurn);
            this.tabPage2.Controls.Add(this.nudLevel);
            this.tabPage2.Controls.Add(this.txtClass);
            this.tabPage2.Controls.Add(this.ckbStatue);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(248, 214);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Units";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Turn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Level:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "A.I.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Team:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            // 
            // grpUnitList
            // 
            this.grpUnitList.Controls.Add(this.lstUnits);
            this.grpUnitList.Controls.Add(this.btnRemove);
            this.grpUnitList.Location = new System.Drawing.Point(130, 0);
            this.grpUnitList.Name = "grpUnitList";
            this.grpUnitList.Size = new System.Drawing.Size(118, 208);
            this.grpUnitList.TabIndex = 6;
            this.grpUnitList.TabStop = false;
            this.grpUnitList.Text = "List";
            // 
            // cmbAIType
            // 
            this.cmbAIType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAIType.FormattingEnabled = true;
            this.cmbAIType.Items.AddRange(new object[] {
            "Charge",
            "Hold",
            "Guard"});
            this.cmbAIType.Location = new System.Drawing.Point(40, 79);
            this.cmbAIType.Name = "cmbAIType";
            this.cmbAIType.Size = new System.Drawing.Size(84, 21);
            this.cmbAIType.TabIndex = 0;
            // 
            // nudReinforcementTurn
            // 
            this.nudReinforcementTurn.Location = new System.Drawing.Point(40, 106);
            this.nudReinforcementTurn.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudReinforcementTurn.Name = "nudReinforcementTurn";
            this.nudReinforcementTurn.Size = new System.Drawing.Size(32, 20);
            this.nudReinforcementTurn.TabIndex = 1;
            // 
            // ckbStatue
            // 
            this.ckbStatue.AutoSize = true;
            this.ckbStatue.Location = new System.Drawing.Point(78, 107);
            this.ckbStatue.Name = "ckbStatue";
            this.ckbStatue.Size = new System.Drawing.Size(57, 17);
            this.ckbStatue.TabIndex = 8;
            this.ckbStatue.Text = "Statue";
            this.ckbStatue.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtBossName);
            this.tabPage3.Controls.Add(this.rdbDefeatBoss);
            this.tabPage3.Controls.Add(this.rdbRout);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(248, 214);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Objective";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtBossName
            // 
            this.txtBossName.Enabled = false;
            this.txtBossName.Location = new System.Drawing.Point(94, 28);
            this.txtBossName.Name = "txtBossName";
            this.txtBossName.Size = new System.Drawing.Size(100, 20);
            this.txtBossName.TabIndex = 1;
            // 
            // rdbDefeatBoss
            // 
            this.rdbDefeatBoss.AutoSize = true;
            this.rdbDefeatBoss.Location = new System.Drawing.Point(6, 29);
            this.rdbDefeatBoss.Name = "rdbDefeatBoss";
            this.rdbDefeatBoss.Size = new System.Drawing.Size(82, 17);
            this.rdbDefeatBoss.TabIndex = 0;
            this.rdbDefeatBoss.TabStop = true;
            this.rdbDefeatBoss.Text = "Defeat boss";
            this.rdbDefeatBoss.UseVisualStyleBackColor = true;
            this.rdbDefeatBoss.CheckedChanged += new System.EventHandler(this.rdbDefeatBoss_CheckedChanged);
            // 
            // rdbRout
            // 
            this.rdbRout.AutoSize = true;
            this.rdbRout.Checked = true;
            this.rdbRout.Location = new System.Drawing.Point(6, 6);
            this.rdbRout.Name = "rdbRout";
            this.rdbRout.Size = new System.Drawing.Size(48, 17);
            this.rdbRout.TabIndex = 0;
            this.rdbRout.TabStop = true;
            this.rdbRout.Text = "Rout";
            this.rdbRout.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(3, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 59);
            this.label8.TabIndex = 9;
            this.label8.Text = "TBA:\r\n-Change data\r\n-Group (for group AI)";
            // 
            // frmLevelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 264);
            this.Controls.Add(this.tbcUI);
            this.Controls.Add(this.pnlRenderer);
            this.Controls.Add(this.pnlBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLevelEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelNumber)).EndInit();
            this.tbcUI.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpUnitList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudReinforcementTurn)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPossibleTiles;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlRenderer;
        private System.Windows.Forms.Panel pnlBG;
        private System.Windows.Forms.Label picPreview;
        private System.Windows.Forms.ComboBox cmbUnitTeam;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.ListBox lstUnits;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmbTileSets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudLevelNumber;
        private System.Windows.Forms.TabControl tbcUI;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpUnitList;
        private System.Windows.Forms.ComboBox cmbAIType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudReinforcementTurn;
        private System.Windows.Forms.CheckBox ckbStatue;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtBossName;
        private System.Windows.Forms.RadioButton rdbDefeatBoss;
        private System.Windows.Forms.RadioButton rdbRout;
        private FileBrowser flbFiles;
        private System.Windows.Forms.TextBox txtLevelName;
        private System.Windows.Forms.Label label8;
    }
}

