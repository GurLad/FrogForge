namespace FrogForge.Editors
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLevelEditor = new System.Windows.Forms.Button();
            this.btnConversationEditor = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnClassEditor = new System.Windows.Forms.Button();
            this.btnPortraitEditor = new System.Windows.Forms.Button();
            this.lblVoice = new System.Windows.Forms.Label();
            this.cmbVoice = new System.Windows.Forms.ComboBox();
            this.btnLevelMetadataEditor = new System.Windows.Forms.Button();
            this.btnTilemapEditor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProjectExport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProjectImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.frogForgeDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBrowse = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDataImport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDataExport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frog Forge";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frogman Gaiden editor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLevelEditor
            // 
            this.btnLevelEditor.Location = new System.Drawing.Point(12, 64);
            this.btnLevelEditor.Name = "btnLevelEditor";
            this.btnLevelEditor.Size = new System.Drawing.Size(289, 23);
            this.btnLevelEditor.TabIndex = 2;
            this.btnLevelEditor.Text = "Map editor";
            this.btnLevelEditor.UseVisualStyleBackColor = true;
            this.btnLevelEditor.Click += new System.EventHandler(this.btnLevelEditor_Click);
            // 
            // btnConversationEditor
            // 
            this.btnConversationEditor.Location = new System.Drawing.Point(12, 151);
            this.btnConversationEditor.Name = "btnConversationEditor";
            this.btnConversationEditor.Size = new System.Drawing.Size(289, 23);
            this.btnConversationEditor.TabIndex = 2;
            this.btnConversationEditor.Text = "Conversation editor";
            this.btnConversationEditor.UseVisualStyleBackColor = true;
            this.btnConversationEditor.Click += new System.EventHandler(this.btnConversationEditor_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("3x5", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(218, 235);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(83, 6);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "V.0.5.4.5 30.07.2021";
            // 
            // btnClassEditor
            // 
            this.btnClassEditor.Location = new System.Drawing.Point(12, 180);
            this.btnClassEditor.Name = "btnClassEditor";
            this.btnClassEditor.Size = new System.Drawing.Size(289, 23);
            this.btnClassEditor.TabIndex = 2;
            this.btnClassEditor.Text = "Class + Unit editor";
            this.btnClassEditor.UseVisualStyleBackColor = true;
            this.btnClassEditor.Click += new System.EventHandler(this.btnClassEditor_Click);
            // 
            // btnPortraitEditor
            // 
            this.btnPortraitEditor.Location = new System.Drawing.Point(12, 209);
            this.btnPortraitEditor.Name = "btnPortraitEditor";
            this.btnPortraitEditor.Size = new System.Drawing.Size(289, 23);
            this.btnPortraitEditor.TabIndex = 2;
            this.btnPortraitEditor.Text = "Portrait editor";
            this.btnPortraitEditor.UseVisualStyleBackColor = true;
            this.btnPortraitEditor.Click += new System.EventHandler(this.btnPortraitEditor_Click);
            // 
            // lblVoice
            // 
            this.lblVoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVoice.AutoSize = true;
            this.lblVoice.Location = new System.Drawing.Point(12, 247);
            this.lblVoice.Name = "lblVoice";
            this.lblVoice.Size = new System.Drawing.Size(81, 13);
            this.lblVoice.TabIndex = 8;
            this.lblVoice.Text = "Voice assistant:";
            this.lblVoice.Visible = false;
            // 
            // cmbVoice
            // 
            this.cmbVoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoice.FormattingEnabled = true;
            this.cmbVoice.Location = new System.Drawing.Point(99, 244);
            this.cmbVoice.Name = "cmbVoice";
            this.cmbVoice.Size = new System.Drawing.Size(202, 21);
            this.cmbVoice.TabIndex = 7;
            this.cmbVoice.Visible = false;
            this.cmbVoice.SelectedIndexChanged += new System.EventHandler(this.cmbVoice_SelectedIndexChanged);
            // 
            // btnLevelMetadataEditor
            // 
            this.btnLevelMetadataEditor.Location = new System.Drawing.Point(12, 122);
            this.btnLevelMetadataEditor.Name = "btnLevelMetadataEditor";
            this.btnLevelMetadataEditor.Size = new System.Drawing.Size(289, 23);
            this.btnLevelMetadataEditor.TabIndex = 2;
            this.btnLevelMetadataEditor.Text = "Level metadata editor";
            this.btnLevelMetadataEditor.UseVisualStyleBackColor = true;
            this.btnLevelMetadataEditor.Click += new System.EventHandler(this.btnLevelMetadataEditor_Click);
            // 
            // btnTilemapEditor
            // 
            this.btnTilemapEditor.Location = new System.Drawing.Point(12, 93);
            this.btnTilemapEditor.Name = "btnTilemapEditor";
            this.btnTilemapEditor.Size = new System.Drawing.Size(289, 23);
            this.btnTilemapEditor.TabIndex = 2;
            this.btnTilemapEditor.Text = "Tileset editor";
            this.btnTilemapEditor.UseVisualStyleBackColor = true;
            this.btnTilemapEditor.Click += new System.EventHandler(this.btnTilemapEditor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.btnAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(313, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProjectExport,
            this.btnProjectImport,
            this.toolStripSeparator1,
            this.frogForgeDataToolStripMenuItem});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // btnProjectExport
            // 
            this.btnProjectExport.Name = "btnProjectExport";
            this.btnProjectExport.Size = new System.Drawing.Size(159, 22);
            this.btnProjectExport.Text = "Export project...";
            this.btnProjectExport.Click += new System.EventHandler(this.btnProjectExport_Click);
            // 
            // btnProjectImport
            // 
            this.btnProjectImport.Name = "btnProjectImport";
            this.btnProjectImport.Size = new System.Drawing.Size(159, 22);
            this.btnProjectImport.Text = "Import project...";
            this.btnProjectImport.Click += new System.EventHandler(this.btnProjectImport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // frogForgeDataToolStripMenuItem
            // 
            this.frogForgeDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBrowse,
            this.btnDataImport,
            this.btnDataExport});
            this.frogForgeDataToolStripMenuItem.Name = "frogForgeDataToolStripMenuItem";
            this.frogForgeDataToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.frogForgeDataToolStripMenuItem.Text = "Frog Forge data";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(148, 22);
            this.btnBrowse.Text = "Game folder...";
            this.btnBrowse.Click += new System.EventHandler(this.btnChangePath_Click);
            // 
            // btnDataImport
            // 
            this.btnDataImport.Name = "btnDataImport";
            this.btnDataImport.Size = new System.Drawing.Size(148, 22);
            this.btnDataImport.Text = "Import...";
            this.btnDataImport.Click += new System.EventHandler(this.btnDataImport_Click);
            // 
            // btnDataExport
            // 
            this.btnDataExport.Name = "btnDataExport";
            this.btnDataExport.Size = new System.Drawing.Size(148, 22);
            this.btnDataExport.Text = "Export...";
            this.btnDataExport.Click += new System.EventHandler(this.btnDataExport_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(52, 20);
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("3x5", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 6);
            this.label3.TabIndex = 4;
            this.label3.Text = "By Gur Ladizhinsky";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 277);
            this.Controls.Add(this.lblVoice);
            this.Controls.Add(this.cmbVoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnTilemapEditor);
            this.Controls.Add(this.btnLevelMetadataEditor);
            this.Controls.Add(this.btnPortraitEditor);
            this.Controls.Add(this.btnClassEditor);
            this.Controls.Add(this.btnConversationEditor);
            this.Controls.Add(this.btnLevelEditor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frog Forge";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLevelEditor;
        private System.Windows.Forms.Button btnConversationEditor;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnClassEditor;
        private System.Windows.Forms.Button btnPortraitEditor;
        private System.Windows.Forms.Label lblVoice;
        private System.Windows.Forms.ComboBox cmbVoice;
        private System.Windows.Forms.Button btnLevelMetadataEditor;
        private System.Windows.Forms.Button btnTilemapEditor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem btnProjectExport;
        private System.Windows.Forms.ToolStripMenuItem btnProjectImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem frogForgeDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnBrowse;
        private System.Windows.Forms.ToolStripMenuItem btnDataImport;
        private System.Windows.Forms.ToolStripMenuItem btnDataExport;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.Label label3;
    }
}