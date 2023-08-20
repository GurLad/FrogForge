namespace FrogForge.Editors
{
    partial class frmCharacterEndingEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCharacterEndingEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnImport = new System.Windows.Forms.ToolStripButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstEndingCards = new FrogForge.UserControls.EndingCardsListEditor();
            this.lstCharacterEndings = new FrogForge.UserControls.CharacterEndingJSONBrowser();
            this.grpCards = new System.Windows.Forms.GroupBox();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpCharacters = new System.Windows.Forms.TabPage();
            this.tbpGlobal = new System.Windows.Forms.TabPage();
            this.lstGlobalEndings = new FrogForge.UserControls.GlobalEndingsListEditor();
            this.toolStrip1.SuspendLayout();
            this.grpCards.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tbpCharacters.SuspendLayout();
            this.tbpGlobal.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnNew,
            this.btnRemove,
            this.toolStripSeparator1,
            this.btnExport,
            this.btnImport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(464, 25);
            this.toolStrip1.TabIndex = 12;
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
            this.btnRemove.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExport
            // 
            this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExport.Image = global::FrogForge.Properties.Resources.Export;
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(23, 22);
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImport.Image = global::FrogForge.Properties.Resources.Import;
            this.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(23, 22);
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(223, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Character name:";
            // 
            // lstEndingCards
            // 
            this.lstEndingCards.Location = new System.Drawing.Point(6, 19);
            this.lstEndingCards.Name = "lstEndingCards";
            this.lstEndingCards.Size = new System.Drawing.Size(286, 163);
            this.lstEndingCards.TabIndex = 26;
            // 
            // lstCharacterEndings
            // 
            this.lstCharacterEndings.FormattingEnabled = true;
            this.lstCharacterEndings.Location = new System.Drawing.Point(0, 0);
            this.lstCharacterEndings.Name = "lstCharacterEndings";
            this.lstCharacterEndings.Size = new System.Drawing.Size(126, 212);
            this.lstCharacterEndings.TabIndex = 13;
            // 
            // grpCards
            // 
            this.grpCards.Controls.Add(this.lstEndingCards);
            this.grpCards.Location = new System.Drawing.Point(132, 26);
            this.grpCards.Name = "grpCards";
            this.grpCards.Size = new System.Drawing.Size(298, 188);
            this.grpCards.TabIndex = 27;
            this.grpCards.TabStop = false;
            this.grpCards.Text = "Possible cards";
            // 
            // tbcMain
            // 
            this.tbcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcMain.Controls.Add(this.tbpCharacters);
            this.tbcMain.Controls.Add(this.tbpGlobal);
            this.tbcMain.Location = new System.Drawing.Point(12, 28);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(440, 241);
            this.tbcMain.TabIndex = 28;
            this.tbcMain.SelectedIndexChanged += new System.EventHandler(this.tbcMain_SelectedIndexChanged);
            // 
            // tbpCharacters
            // 
            this.tbpCharacters.Controls.Add(this.lstCharacterEndings);
            this.tbpCharacters.Controls.Add(this.grpCards);
            this.tbpCharacters.Controls.Add(this.label3);
            this.tbpCharacters.Controls.Add(this.txtName);
            this.tbpCharacters.Location = new System.Drawing.Point(4, 22);
            this.tbpCharacters.Name = "tbpCharacters";
            this.tbpCharacters.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCharacters.Size = new System.Drawing.Size(432, 215);
            this.tbpCharacters.TabIndex = 0;
            this.tbpCharacters.Text = "Characters";
            this.tbpCharacters.UseVisualStyleBackColor = true;
            // 
            // tbpGlobal
            // 
            this.tbpGlobal.Controls.Add(this.lstGlobalEndings);
            this.tbpGlobal.Location = new System.Drawing.Point(4, 22);
            this.tbpGlobal.Name = "tbpGlobal";
            this.tbpGlobal.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGlobal.Size = new System.Drawing.Size(432, 215);
            this.tbpGlobal.TabIndex = 1;
            this.tbpGlobal.Text = "Global";
            this.tbpGlobal.UseVisualStyleBackColor = true;
            // 
            // lstGlobalEndings
            // 
            this.lstGlobalEndings.Location = new System.Drawing.Point(0, 0);
            this.lstGlobalEndings.Name = "lstGlobalEndings";
            this.lstGlobalEndings.Size = new System.Drawing.Size(286, 231);
            this.lstGlobalEndings.TabIndex = 0;
            // 
            // frmCharacterEndingEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCharacterEndingEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ending Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCharacterEndingEditor_FormClosed);
            this.Load += new System.EventHandler(this.frmCharacterEndingEditor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpCards.ResumeLayout(false);
            this.tbcMain.ResumeLayout(false);
            this.tbpCharacters.ResumeLayout(false);
            this.tbpCharacters.PerformLayout();
            this.tbpGlobal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnImport;
        private UserControls.CharacterEndingJSONBrowser lstCharacterEndings;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private UserControls.EndingCardsListEditor lstEndingCards;
        private System.Windows.Forms.GroupBox grpCards;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpCharacters;
        private System.Windows.Forms.TabPage tbpGlobal;
        private UserControls.GlobalEndingsListEditor lstGlobalEndings;
    }
}