namespace FrogForge.Editors
{
    partial class frmMapEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapEditor));
            this.pnlPossibleTiles = new System.Windows.Forms.Panel();
            this.pnlRenderer = new System.Windows.Forms.Panel();
            this.pnlBG = new System.Windows.Forms.Panel();
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
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpUnitList = new System.Windows.Forms.GroupBox();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.cmbAIType = new System.Windows.Forms.ComboBox();
            this.nudReinforcementTurn = new System.Windows.Forms.NumericUpDown();
            this.ckbStatue = new System.Windows.Forms.CheckBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.nudEscapePosY = new System.Windows.Forms.NumericUpDown();
            this.nudEscapePosX = new System.Windows.Forms.NumericUpDown();
            this.nudSurviveTurn = new System.Windows.Forms.NumericUpDown();
            this.txtBossName = new System.Windows.Forms.TextBox();
            this.rdbDefeatBoss = new System.Windows.Forms.RadioButton();
            this.rdbEscape = new System.Windows.Forms.RadioButton();
            this.rdbSurvive = new System.Windows.Forms.RadioButton();
            this.rdbRout = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.melMapEvents = new FrogForge.UserControls.MapEventListEditor();
            this.txtLevelName = new System.Windows.Forms.TextBox();
            this.flbFiles = new FrogForge.UserControls.FileBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNewFolder = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteFolder = new System.Windows.Forms.ToolStripButton();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelNumber)).BeginInit();
            this.tbcUI.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grpUnitList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReinforcementTurn)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEscapePosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEscapePosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSurviveTurn)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPossibleTiles
            // 
            this.pnlPossibleTiles.Location = new System.Drawing.Point(0, 0);
            this.pnlPossibleTiles.Name = "pnlPossibleTiles";
            this.pnlPossibleTiles.Size = new System.Drawing.Size(96, 161);
            this.pnlPossibleTiles.TabIndex = 28;
            // 
            // pnlRenderer
            // 
            this.pnlRenderer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlRenderer.Location = new System.Drawing.Point(127, 54);
            this.pnlRenderer.Name = "pnlRenderer";
            this.pnlRenderer.Size = new System.Drawing.Size(256, 240);
            this.pnlRenderer.TabIndex = 13;
            // 
            // pnlBG
            // 
            this.pnlBG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBG.Location = new System.Drawing.Point(127, 54);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.Size = new System.Drawing.Size(256, 240);
            this.pnlBG.TabIndex = 14;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(141, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(101, 23);
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
            this.lstUnits.Size = new System.Drawing.Size(129, 108);
            this.lstUnits.TabIndex = 4;
            this.lstUnits.SelectedIndexChanged += new System.EventHandler(this.lstUnits_SelectedIndexChanged);
            this.lstUnits.DoubleClick += new System.EventHandler(this.lstUnits_DoubleClick);
            // 
            // btnPlace
            // 
            this.btnPlace.Location = new System.Drawing.Point(141, 54);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(108, 23);
            this.btnPlace.TabIndex = 3;
            this.btnPlace.Text = "Place";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(40, 0);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(95, 20);
            this.txtClass.TabIndex = 2;
            // 
            // nudLevel
            // 
            this.nudLevel.Location = new System.Drawing.Point(40, 28);
            this.nudLevel.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(95, 20);
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
            this.cmbUnitTeam.Location = new System.Drawing.Point(181, 0);
            this.cmbUnitTeam.Name = "cmbUnitTeam";
            this.cmbUnitTeam.Size = new System.Drawing.Size(67, 21);
            this.cmbUnitTeam.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Level number:";
            // 
            // nudLevelNumber
            // 
            this.nudLevelNumber.Location = new System.Drawing.Point(366, 28);
            this.nudLevelNumber.Name = "nudLevelNumber";
            this.nudLevelNumber.Size = new System.Drawing.Size(49, 20);
            this.nudLevelNumber.TabIndex = 33;
            this.nudLevelNumber.ValueChanged += new System.EventHandler(this.nudLevelNumber_ValueChanged);
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
            this.tbcUI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbcUI.Controls.Add(this.tabPage1);
            this.tbcUI.Controls.Add(this.tabPage2);
            this.tbcUI.Controls.Add(this.tabPage3);
            this.tbcUI.Controls.Add(this.tabPage4);
            this.tbcUI.Location = new System.Drawing.Point(389, 54);
            this.tbcUI.Name = "tbcUI";
            this.tbcUI.SelectedIndex = 0;
            this.tbcUI.Size = new System.Drawing.Size(256, 240);
            this.tbcUI.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picPreview);
            this.tabPage1.Controls.Add(this.cmbTileSets);
            this.tabPage1.Controls.Add(this.pnlPossibleTiles);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(248, 214);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tiles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // picPreview
            // 
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Location = new System.Drawing.Point(102, -1);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(18, 18);
            this.picPreview.TabIndex = 37;
            this.picPreview.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.grpUnitList);
            this.tabPage2.Controls.Add(this.cmbAIType);
            this.tabPage2.Controls.Add(this.cmbUnitTeam);
            this.tabPage2.Controls.Add(this.nudReinforcementTurn);
            this.tabPage2.Controls.Add(this.nudLevel);
            this.tabPage2.Controls.Add(this.txtClass);
            this.tabPage2.Controls.Add(this.ckbStatue);
            this.tabPage2.Controls.Add(this.btnPlace);
            this.tabPage2.Controls.Add(this.btnReplace);
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
            this.label7.Location = new System.Drawing.Point(-3, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Turn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Level:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "A.I.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 3);
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
            this.grpUnitList.Controls.Add(this.btnMoveDown);
            this.grpUnitList.Controls.Add(this.btnMoveUp);
            this.grpUnitList.Controls.Add(this.btnRemove);
            this.grpUnitList.Location = new System.Drawing.Point(0, 83);
            this.grpUnitList.Name = "grpUnitList";
            this.grpUnitList.Size = new System.Drawing.Size(248, 131);
            this.grpUnitList.TabIndex = 6;
            this.grpUnitList.TabStop = false;
            this.grpUnitList.Text = "List";
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMoveDown.Location = new System.Drawing.Point(141, 77);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(101, 23);
            this.btnMoveDown.TabIndex = 5;
            this.btnMoveDown.Text = "Move down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMoveUp.Location = new System.Drawing.Point(141, 48);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(101, 23);
            this.btnMoveUp.TabIndex = 5;
            this.btnMoveUp.Text = "Move up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // cmbAIType
            // 
            this.cmbAIType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAIType.FormattingEnabled = true;
            this.cmbAIType.Items.AddRange(new object[] {
            "Charge",
            "Hold",
            "Guard"});
            this.cmbAIType.Location = new System.Drawing.Point(181, 27);
            this.cmbAIType.Name = "cmbAIType";
            this.cmbAIType.Size = new System.Drawing.Size(67, 21);
            this.cmbAIType.TabIndex = 0;
            // 
            // nudReinforcementTurn
            // 
            this.nudReinforcementTurn.Location = new System.Drawing.Point(40, 57);
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
            this.ckbStatue.Location = new System.Drawing.Point(78, 58);
            this.ckbStatue.Name = "ckbStatue";
            this.ckbStatue.Size = new System.Drawing.Size(57, 17);
            this.ckbStatue.TabIndex = 8;
            this.ckbStatue.Text = "Statue";
            this.ckbStatue.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            this.btnReplace.Enabled = false;
            this.btnReplace.Location = new System.Drawing.Point(192, 54);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(57, 23);
            this.btnReplace.TabIndex = 3;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.nudEscapePosY);
            this.tabPage3.Controls.Add(this.nudEscapePosX);
            this.tabPage3.Controls.Add(this.nudSurviveTurn);
            this.tabPage3.Controls.Add(this.txtBossName);
            this.tabPage3.Controls.Add(this.rdbDefeatBoss);
            this.tabPage3.Controls.Add(this.rdbEscape);
            this.tabPage3.Controls.Add(this.rdbSurvive);
            this.tabPage3.Controls.Add(this.rdbRout);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(248, 214);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Objective";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // nudEscapePosY
            // 
            this.nudEscapePosY.Enabled = false;
            this.nudEscapePosY.Location = new System.Drawing.Point(143, 85);
            this.nudEscapePosY.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nudEscapePosY.Name = "nudEscapePosY";
            this.nudEscapePosY.Size = new System.Drawing.Size(33, 20);
            this.nudEscapePosY.TabIndex = 2;
            // 
            // nudEscapePosX
            // 
            this.nudEscapePosX.Enabled = false;
            this.nudEscapePosX.Location = new System.Drawing.Point(94, 85);
            this.nudEscapePosX.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudEscapePosX.Name = "nudEscapePosX";
            this.nudEscapePosX.Size = new System.Drawing.Size(33, 20);
            this.nudEscapePosX.TabIndex = 2;
            // 
            // nudSurviveTurn
            // 
            this.nudSurviveTurn.Enabled = false;
            this.nudSurviveTurn.Location = new System.Drawing.Point(94, 59);
            this.nudSurviveTurn.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudSurviveTurn.Name = "nudSurviveTurn";
            this.nudSurviveTurn.Size = new System.Drawing.Size(33, 20);
            this.nudSurviveTurn.TabIndex = 2;
            // 
            // txtBossName
            // 
            this.txtBossName.Enabled = false;
            this.txtBossName.Location = new System.Drawing.Point(94, 32);
            this.txtBossName.Name = "txtBossName";
            this.txtBossName.Size = new System.Drawing.Size(100, 20);
            this.txtBossName.TabIndex = 1;
            // 
            // rdbDefeatBoss
            // 
            this.rdbDefeatBoss.AutoSize = true;
            this.rdbDefeatBoss.Location = new System.Drawing.Point(6, 33);
            this.rdbDefeatBoss.Name = "rdbDefeatBoss";
            this.rdbDefeatBoss.Size = new System.Drawing.Size(82, 17);
            this.rdbDefeatBoss.TabIndex = 0;
            this.rdbDefeatBoss.Text = "Defeat boss";
            this.rdbDefeatBoss.UseVisualStyleBackColor = true;
            this.rdbDefeatBoss.CheckedChanged += new System.EventHandler(this.rdbDefeatBoss_CheckedChanged);
            // 
            // rdbEscape
            // 
            this.rdbEscape.AutoSize = true;
            this.rdbEscape.Location = new System.Drawing.Point(6, 85);
            this.rdbEscape.Name = "rdbEscape";
            this.rdbEscape.Size = new System.Drawing.Size(61, 17);
            this.rdbEscape.TabIndex = 0;
            this.rdbEscape.Text = "Escape";
            this.rdbEscape.UseVisualStyleBackColor = true;
            this.rdbEscape.CheckedChanged += new System.EventHandler(this.rdbEscape_CheckedChanged);
            // 
            // rdbSurvive
            // 
            this.rdbSurvive.AutoSize = true;
            this.rdbSurvive.Location = new System.Drawing.Point(6, 59);
            this.rdbSurvive.Name = "rdbSurvive";
            this.rdbSurvive.Size = new System.Drawing.Size(61, 17);
            this.rdbSurvive.TabIndex = 0;
            this.rdbSurvive.Text = "Survive";
            this.rdbSurvive.UseVisualStyleBackColor = true;
            this.rdbSurvive.CheckedChanged += new System.EventHandler(this.rdbSurvive_CheckedChanged);
            // 
            // rdbRout
            // 
            this.rdbRout.AutoSize = true;
            this.rdbRout.Checked = true;
            this.rdbRout.Location = new System.Drawing.Point(6, 7);
            this.rdbRout.Name = "rdbRout";
            this.rdbRout.Size = new System.Drawing.Size(48, 17);
            this.rdbRout.TabIndex = 0;
            this.rdbRout.TabStop = true;
            this.rdbRout.Text = "Rout";
            this.rdbRout.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = ",";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.melMapEvents);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(248, 214);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Events";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // melMapEvents
            // 
            this.melMapEvents.Location = new System.Drawing.Point(0, 0);
            this.melMapEvents.Name = "melMapEvents";
            this.melMapEvents.Size = new System.Drawing.Size(248, 214);
            this.melMapEvents.TabIndex = 0;
            // 
            // txtLevelName
            // 
            this.txtLevelName.Location = new System.Drawing.Point(171, 28);
            this.txtLevelName.Name = "txtLevelName";
            this.txtLevelName.Size = new System.Drawing.Size(109, 20);
            this.txtLevelName.TabIndex = 36;
            // 
            // flbFiles
            // 
            this.flbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flbFiles.Location = new System.Drawing.Point(12, 28);
            this.flbFiles.Name = "flbFiles";
            this.flbFiles.SelectedFilename = null;
            this.flbFiles.Size = new System.Drawing.Size(109, 266);
            this.flbFiles.TabIndex = 35;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnNew,
            this.btnDelete,
            this.toolStripSeparator1,
            this.btnNewFolder,
            this.btnDeleteFolder});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(657, 25);
            this.toolStrip1.TabIndex = 33;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNewFolder
            // 
            this.btnNewFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewFolder.Image = global::FrogForge.Properties.Resources.NewFolder;
            this.btnNewFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewFolder.Name = "btnNewFolder";
            this.btnNewFolder.Size = new System.Drawing.Size(23, 22);
            this.btnNewFolder.Text = "New folder";
            this.btnNewFolder.Click += new System.EventHandler(this.btnNewFolder_Click);
            // 
            // btnDeleteFolder
            // 
            this.btnDeleteFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteFolder.Image = global::FrogForge.Properties.Resources.DeleteFolder;
            this.btnDeleteFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteFolder.Name = "btnDeleteFolder";
            this.btnDeleteFolder.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteFolder.Text = "Delete folder";
            this.btnDeleteFolder.Click += new System.EventHandler(this.btnDeleteFolder_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(127, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Name:";
            // 
            // frmMapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 306);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbcUI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLevelName);
            this.Controls.Add(this.nudLevelNumber);
            this.Controls.Add(this.pnlRenderer);
            this.Controls.Add(this.flbFiles);
            this.Controls.Add(this.pnlBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMapEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelNumber)).EndInit();
            this.tbcUI.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpUnitList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudReinforcementTurn)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEscapePosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEscapePosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSurviveTurn)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPossibleTiles;
        private System.Windows.Forms.Panel pnlRenderer;
        private System.Windows.Forms.Panel pnlBG;
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
        private FrogForge.UserControls.FileBrowser flbFiles;
        private System.Windows.Forms.TextBox txtLevelName;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.RadioButton rdbSurvive;
        private System.Windows.Forms.RadioButton rdbEscape;
        private System.Windows.Forms.NumericUpDown nudEscapePosX;
        private System.Windows.Forms.NumericUpDown nudSurviveTurn;
        private System.Windows.Forms.NumericUpDown nudEscapePosY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.TabPage tabPage4;
        private UserControls.MapEventListEditor melMapEvents;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnNewFolder;
        private System.Windows.Forms.ToolStripButton btnDeleteFolder;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
    }
}

