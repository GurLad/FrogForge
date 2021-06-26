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
            this.grpTeams = new System.Windows.Forms.GroupBox();
            this.lblEditing = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(779, 25);
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
            // grpTeams
            // 
            this.grpTeams.Location = new System.Drawing.Point(137, 54);
            this.grpTeams.Name = "grpTeams";
            this.grpTeams.Size = new System.Drawing.Size(630, 341);
            this.grpTeams.TabIndex = 40;
            this.grpTeams.TabStop = false;
            this.grpTeams.Text = "Teams";
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
            // frmLevelMetadataEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 408);
            this.Controls.Add(this.lblEditing);
            this.Controls.Add(this.grpTeams);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMusicName);
            this.Controls.Add(this.lstLevels);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLevelMetadataEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level Metadata Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLevelMetadataEditor_FormClosed);
            this.Load += new System.EventHandler(this.frmLevelMetadataEditor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpTeams;
        private System.Windows.Forms.Label lblEditing;
    }
}