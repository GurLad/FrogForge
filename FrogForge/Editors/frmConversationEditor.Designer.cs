namespace FrogForge.Editors
{
    partial class frmConversationEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversationEditor));
            this.pnlEditorUI = new System.Windows.Forms.Panel();
            this.picSeperator2 = new System.Windows.Forms.PictureBox();
            this.picSeperator1 = new System.Windows.Forms.PictureBox();
            this.txtText = new FrogForge.UserControls.EventTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.flbFileBrowser = new FrogForge.UserControls.FileBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNewFolder = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPreview = new System.Windows.Forms.ToolStripButton();
            this.copConversationPlayer = new FrogForge.UserControls.ConversationPlayer();
            this.grpFindAndReplace = new System.Windows.Forms.GroupBox();
            this.farFindAndReplacePanel = new FrogForge.UserControls.FindAndReplacePanel();
            this.pnlEditorUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeperator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeperator1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.grpFindAndReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEditorUI
            // 
            this.pnlEditorUI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEditorUI.Controls.Add(this.picSeperator2);
            this.pnlEditorUI.Controls.Add(this.picSeperator1);
            this.pnlEditorUI.Controls.Add(this.txtText);
            this.pnlEditorUI.Controls.Add(this.label1);
            this.pnlEditorUI.Controls.Add(this.txtName);
            this.pnlEditorUI.Location = new System.Drawing.Point(195, 28);
            this.pnlEditorUI.Name = "pnlEditorUI";
            this.pnlEditorUI.Size = new System.Drawing.Size(567, 694);
            this.pnlEditorUI.TabIndex = 2;
            // 
            // picSeperator2
            // 
            this.picSeperator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.picSeperator2.Location = new System.Drawing.Point(-1, -1);
            this.picSeperator2.Name = "picSeperator2";
            this.picSeperator2.Size = new System.Drawing.Size(1, 12);
            this.picSeperator2.TabIndex = 4;
            this.picSeperator2.TabStop = false;
            // 
            // picSeperator1
            // 
            this.picSeperator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.picSeperator1.Location = new System.Drawing.Point(-1, -1);
            this.picSeperator1.Name = "picSeperator1";
            this.picSeperator1.Size = new System.Drawing.Size(1, 12);
            this.picSeperator1.TabIndex = 4;
            this.picSeperator1.TabStop = false;
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(0, 26);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(567, 668);
            this.txtText.TabIndex = 3;
            this.txtText.Text = "Xirveros: 012345678901234567890123456789 01234567890123456789012345678";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(41, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(526, 20);
            this.txtName.TabIndex = 0;
            // 
            // flbFileBrowser
            // 
            this.flbFileBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flbFileBrowser.Location = new System.Drawing.Point(12, 28);
            this.flbFileBrowser.Name = "flbFileBrowser";
            this.flbFileBrowser.SelectedFilename = null;
            this.flbFileBrowser.Size = new System.Drawing.Size(177, 693);
            this.flbFileBrowser.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnNew,
            this.btnDelete,
            this.toolStripSeparator1,
            this.btnNewFolder,
            this.btnDeleteFolder,
            this.toolStripSeparator2,
            this.btnPreview});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1292, 25);
            this.toolStrip1.TabIndex = 3;
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPreview
            // 
            this.btnPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPreview.Image = global::FrogForge.Properties.Resources.Play;
            this.btnPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(23, 22);
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // copConversationPlayer
            // 
            this.copConversationPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copConversationPlayer.Location = new System.Drawing.Point(768, 28);
            this.copConversationPlayer.Name = "copConversationPlayer";
            this.copConversationPlayer.Size = new System.Drawing.Size(512, 480);
            this.copConversationPlayer.TabIndex = 4;
            // 
            // grpFindAndReplace
            // 
            this.grpFindAndReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFindAndReplace.Controls.Add(this.farFindAndReplacePanel);
            this.grpFindAndReplace.Location = new System.Drawing.Point(769, 515);
            this.grpFindAndReplace.Name = "grpFindAndReplace";
            this.grpFindAndReplace.Size = new System.Drawing.Size(511, 206);
            this.grpFindAndReplace.TabIndex = 5;
            this.grpFindAndReplace.TabStop = false;
            this.grpFindAndReplace.Text = "Find && Replace";
            // 
            // farFindAndReplacePanel
            // 
            this.farFindAndReplacePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.farFindAndReplacePanel.Location = new System.Drawing.Point(7, 20);
            this.farFindAndReplacePanel.Name = "farFindAndReplacePanel";
            this.farFindAndReplacePanel.Size = new System.Drawing.Size(498, 180);
            this.farFindAndReplacePanel.TabIndex = 0;
            // 
            // frmConversationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 734);
            this.Controls.Add(this.grpFindAndReplace);
            this.Controls.Add(this.copConversationPlayer);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlEditorUI);
            this.Controls.Add(this.flbFileBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConversationEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversation Editor";
            this.Load += new System.EventHandler(this.frmConversationEditor_Load);
            this.pnlEditorUI.ResumeLayout(false);
            this.pnlEditorUI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeperator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeperator1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpFindAndReplace.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FrogForge.UserControls.FileBrowser flbFileBrowser;
        private System.Windows.Forms.Panel pnlEditorUI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox picSeperator2;
        private System.Windows.Forms.PictureBox picSeperator1;
        private FrogForge.UserControls.EventTextBox txtText;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPreview;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnNewFolder;
        private System.Windows.Forms.ToolStripButton btnDeleteFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private UserControls.ConversationPlayer copConversationPlayer;
        private System.Windows.Forms.GroupBox grpFindAndReplace;
        private UserControls.FindAndReplacePanel farFindAndReplacePanel;
    }
}