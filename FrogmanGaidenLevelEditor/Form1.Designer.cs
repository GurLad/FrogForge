namespace FrogmanGaidenLevelEditor
{
    partial class Form1
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
            this.pnlPossibleTiles = new System.Windows.Forms.Panel();
            this.cmbLevelName = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlRenderer = new System.Windows.Forms.Panel();
            this.pnlBG = new System.Windows.Forms.Panel();
            this.picPreview = new System.Windows.Forms.Label();
            this.grpUnit = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstUnits = new System.Windows.Forms.ListBox();
            this.btnPlace = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.cmbUnitTeam = new System.Windows.Forms.ComboBox();
            this.pnlUI = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTileSets = new System.Windows.Forms.ComboBox();
            this.grpUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            this.pnlUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPossibleTiles
            // 
            this.pnlPossibleTiles.Location = new System.Drawing.Point(0, 1);
            this.pnlPossibleTiles.Name = "pnlPossibleTiles";
            this.pnlPossibleTiles.Size = new System.Drawing.Size(96, 80);
            this.pnlPossibleTiles.TabIndex = 28;
            // 
            // cmbLevelName
            // 
            this.cmbLevelName.FormattingEnabled = true;
            this.cmbLevelName.Location = new System.Drawing.Point(0, 127);
            this.cmbLevelName.Name = "cmbLevelName";
            this.cmbLevelName.Size = new System.Drawing.Size(80, 21);
            this.cmbLevelName.TabIndex = 18;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(86, 141);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(47, 23);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(86, 112);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(47, 23);
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
            this.picPreview.Location = new System.Drawing.Point(102, 0);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(18, 18);
            this.picPreview.TabIndex = 29;
            // 
            // grpUnit
            // 
            this.grpUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUnit.Controls.Add(this.btnRemove);
            this.grpUnit.Controls.Add(this.lstUnits);
            this.grpUnit.Controls.Add(this.btnPlace);
            this.grpUnit.Controls.Add(this.txtClass);
            this.grpUnit.Controls.Add(this.nudLevel);
            this.grpUnit.Controls.Add(this.cmbUnitTeam);
            this.grpUnit.Location = new System.Drawing.Point(139, 0);
            this.grpUnit.Name = "grpUnit";
            this.grpUnit.Size = new System.Drawing.Size(117, 187);
            this.grpUnit.TabIndex = 30;
            this.grpUnit.TabStop = false;
            this.grpUnit.Text = "Units";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(7, 155);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(104, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstUnits
            // 
            this.lstUnits.FormattingEnabled = true;
            this.lstUnits.Location = new System.Drawing.Point(7, 105);
            this.lstUnits.Name = "lstUnits";
            this.lstUnits.Size = new System.Drawing.Size(104, 43);
            this.lstUnits.TabIndex = 4;
            // 
            // btnPlace
            // 
            this.btnPlace.Location = new System.Drawing.Point(7, 75);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(104, 23);
            this.btnPlace.TabIndex = 3;
            this.btnPlace.Text = "Place";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(7, 48);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(104, 20);
            this.txtClass.TabIndex = 2;
            // 
            // nudLevel
            // 
            this.nudLevel.Location = new System.Drawing.Point(75, 20);
            this.nudLevel.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(36, 20);
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
            this.cmbUnitTeam.Location = new System.Drawing.Point(7, 20);
            this.cmbUnitTeam.Name = "cmbUnitTeam";
            this.cmbUnitTeam.Size = new System.Drawing.Size(62, 21);
            this.cmbUnitTeam.TabIndex = 0;
            // 
            // pnlUI
            // 
            this.pnlUI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUI.Controls.Add(this.cmbTileSets);
            this.pnlUI.Controls.Add(this.label1);
            this.pnlUI.Controls.Add(this.grpUnit);
            this.pnlUI.Controls.Add(this.pnlPossibleTiles);
            this.pnlUI.Controls.Add(this.btnLoad);
            this.pnlUI.Controls.Add(this.cmbLevelName);
            this.pnlUI.Controls.Add(this.btnSave);
            this.pnlUI.Controls.Add(this.picPreview);
            this.pnlUI.Location = new System.Drawing.Point(12, 258);
            this.pnlUI.Name = "pnlUI";
            this.pnlUI.Size = new System.Drawing.Size(256, 190);
            this.pnlUI.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tile set:";
            // 
            // cmbTileSets
            // 
            this.cmbTileSets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTileSets.FormattingEnabled = true;
            this.cmbTileSets.Location = new System.Drawing.Point(54, 85);
            this.cmbTileSets.Name = "cmbTileSets";
            this.cmbTileSets.Size = new System.Drawing.Size(79, 21);
            this.cmbTileSets.TabIndex = 32;
            this.cmbTileSets.SelectedIndexChanged += new System.EventHandler(this.cmbTileSets_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 452);
            this.Controls.Add(this.pnlUI);
            this.Controls.Add(this.pnlRenderer);
            this.Controls.Add(this.pnlBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frogman Gaiden level editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpUnit.ResumeLayout(false);
            this.grpUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            this.pnlUI.ResumeLayout(false);
            this.pnlUI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPossibleTiles;
        private System.Windows.Forms.ComboBox cmbLevelName;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlRenderer;
        private System.Windows.Forms.Panel pnlBG;
        private System.Windows.Forms.Label picPreview;
        private System.Windows.Forms.GroupBox grpUnit;
        private System.Windows.Forms.ComboBox cmbUnitTeam;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Panel pnlUI;
        private System.Windows.Forms.ListBox lstUnits;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmbTileSets;
        private System.Windows.Forms.Label label1;
    }
}

