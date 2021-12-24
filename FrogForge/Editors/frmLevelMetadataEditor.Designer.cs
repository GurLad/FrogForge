namespace FrogForge.Editors
{
    partial class frmLevelMetadataEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevelMetadataEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.lstLevels = new FrogForge.UserControls.LevelMetadataJSONBrowser();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMusicName = new System.Windows.Forms.TextBox();
            this.pnlTeams = new System.Windows.Forms.Panel();
            this.lblEditing = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbAllies13 = new System.Windows.Forms.CheckBox();
            this.ckbAllies23 = new System.Windows.Forms.CheckBox();
            this.ckbAllies12 = new System.Windows.Forms.CheckBox();
            this.lstUnitReplacements = new FrogForge.UserControls.UnitReplacementListEditor();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(777, 25);
            this.toolStrip1.TabIndex = 34;
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
            // lstLevels
            // 
            this.lstLevels.FormattingEnabled = true;
            this.lstLevels.Location = new System.Drawing.Point(12, 28);
            this.lstLevels.Name = "lstLevels";
            this.lstLevels.Size = new System.Drawing.Size(119, 368);
            this.lstLevels.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Music:";
            // 
            // txtMusicName
            // 
            this.txtMusicName.Location = new System.Drawing.Point(182, 28);
            this.txtMusicName.Name = "txtMusicName";
            this.txtMusicName.Size = new System.Drawing.Size(109, 20);
            this.txtMusicName.TabIndex = 38;
            // 
            // pnlTeams
            // 
            this.pnlTeams.BackColor = System.Drawing.Color.Transparent;
            this.pnlTeams.Location = new System.Drawing.Point(0, 2);
            this.pnlTeams.Name = "pnlTeams";
            this.pnlTeams.Size = new System.Drawing.Size(618, 316);
            this.pnlTeams.TabIndex = 0;
            // 
            // lblEditing
            // 
            this.lblEditing.AutoSize = true;
            this.lblEditing.Location = new System.Drawing.Point(297, 31);
            this.lblEditing.Name = "lblEditing";
            this.lblEditing.Size = new System.Drawing.Size(35, 13);
            this.lblEditing.TabIndex = 41;
            this.lblEditing.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(137, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(628, 344);
            this.tabControl1.TabIndex = 42;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlTeams);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(620, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Teams";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(620, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Everything else";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstUnitReplacements);
            this.groupBox2.Location = new System.Drawing.Point(0, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Replacements";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbAllies13);
            this.groupBox1.Controls.Add(this.ckbAllies23);
            this.groupBox1.Controls.Add(this.ckbAllies12);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alliances";
            // 
            // ckbAllies13
            // 
            this.ckbAllies13.AutoSize = true;
            this.ckbAllies13.Location = new System.Drawing.Point(6, 65);
            this.ckbAllies13.Name = "ckbAllies13";
            this.ckbAllies13.Size = new System.Drawing.Size(110, 17);
            this.ckbAllies13.TabIndex = 1;
            this.ckbAllies13.Text = "Team 1 && Team 3";
            this.ckbAllies13.UseVisualStyleBackColor = true;
            // 
            // ckbAllies23
            // 
            this.ckbAllies23.AutoSize = true;
            this.ckbAllies23.Location = new System.Drawing.Point(6, 42);
            this.ckbAllies23.Name = "ckbAllies23";
            this.ckbAllies23.Size = new System.Drawing.Size(110, 17);
            this.ckbAllies23.TabIndex = 1;
            this.ckbAllies23.Text = "Team 2 && Team 3";
            this.ckbAllies23.UseVisualStyleBackColor = true;
            // 
            // ckbAllies12
            // 
            this.ckbAllies12.AutoSize = true;
            this.ckbAllies12.Location = new System.Drawing.Point(6, 19);
            this.ckbAllies12.Name = "ckbAllies12";
            this.ckbAllies12.Size = new System.Drawing.Size(110, 17);
            this.ckbAllies12.TabIndex = 1;
            this.ckbAllies12.Text = "Team 1 && Team 2";
            this.ckbAllies12.UseVisualStyleBackColor = true;
            // 
            // lstUnitReplacements
            // 
            this.lstUnitReplacements.Location = new System.Drawing.Point(7, 20);
            this.lstUnitReplacements.Name = "lstUnitReplacements";
            this.lstUnitReplacements.Size = new System.Drawing.Size(187, 195);
            this.lstUnitReplacements.TabIndex = 0;
            // 
            // frmLevelMetadataEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 410);
            this.Controls.Add(this.lblEditing);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMusicName);
            this.Controls.Add(this.lstLevels);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLevelMetadataEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level Metadata Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLevelMetadataEditor_FormClosed);
            this.Load += new System.EventHandler(this.frmLevelMetadataEditor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private UserControls.LevelMetadataJSONBrowser lstLevels;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMusicName;
        private System.Windows.Forms.Label lblEditing;
        private System.Windows.Forms.Panel pnlTeams;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbAllies12;
        private System.Windows.Forms.CheckBox ckbAllies23;
        private System.Windows.Forms.CheckBox ckbAllies13;
        private System.Windows.Forms.GroupBox groupBox2;
        private UserControls.UnitReplacementListEditor lstUnitReplacements;
    }
}