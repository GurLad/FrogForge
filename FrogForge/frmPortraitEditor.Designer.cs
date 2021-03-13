namespace FrogForge
{
    partial class frmPortraitEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPortraitEditor));
            this.lstPortraits = new FrogForge.PortraitJSONBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.picBG = new FrogForge.AnimationPicturebox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.picFG = new FrogForge.AnimationPicturebox();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.picFGPalette = new System.Windows.Forms.PictureBox();
            this.trkFGPalette = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPreview = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBG)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFG)).BeginInit();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFGPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFGPalette)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPortraits
            // 
            this.lstPortraits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstPortraits.FormattingEnabled = true;
            this.lstPortraits.Location = new System.Drawing.Point(12, 28);
            this.lstPortraits.Name = "lstPortraits";
            this.lstPortraits.Size = new System.Drawing.Size(120, 251);
            this.lstPortraits.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(138, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 102);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Images";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.picBG);
            this.groupBox5.Location = new System.Drawing.Point(76, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(64, 77);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "BG";
            // 
            // picBG
            // 
            this.picBG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBG.Image = null;
            this.picBG.Location = new System.Drawing.Point(6, 19);
            this.picBG.Name = "picBG";
            this.picBG.Palette = palette1;
            this.picBG.Size = new System.Drawing.Size(52, 52);
            this.picBG.TabIndex = 0;
            this.picBG.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.picPreview);
            this.groupBox6.Location = new System.Drawing.Point(146, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(64, 77);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Preview";
            // 
            // picPreview
            // 
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPreview.Location = new System.Drawing.Point(6, 19);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(52, 52);
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picFG);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(64, 77);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FG";
            // 
            // picFG
            // 
            this.picFG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFG.Image = null;
            this.picFG.Location = new System.Drawing.Point(6, 19);
            this.picFG.Name = "picFG";
            this.picFG.Palette = palette1;
            this.picFG.Size = new System.Drawing.Size(52, 52);
            this.picFG.TabIndex = 0;
            this.picFG.TabStop = false;
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.picFGPalette);
            this.grpData.Controls.Add(this.trkFGPalette);
            this.grpData.Controls.Add(this.label3);
            this.grpData.Controls.Add(this.txtName);
            this.grpData.Controls.Add(this.label2);
            this.grpData.Controls.Add(this.label1);
            this.grpData.Location = new System.Drawing.Point(138, 28);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(216, 97);
            this.grpData.TabIndex = 15;
            this.grpData.TabStop = false;
            this.grpData.Text = "Data";
            // 
            // picFGPalette
            // 
            this.picFGPalette.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFGPalette.Location = new System.Drawing.Point(190, 45);
            this.picFGPalette.Name = "picFGPalette";
            this.picFGPalette.Size = new System.Drawing.Size(20, 20);
            this.picFGPalette.TabIndex = 3;
            this.picFGPalette.TabStop = false;
            // 
            // trkFGPalette
            // 
            this.trkFGPalette.AutoSize = false;
            this.trkFGPalette.LargeChange = 1;
            this.trkFGPalette.Location = new System.Drawing.Point(73, 45);
            this.trkFGPalette.Maximum = 3;
            this.trkFGPalette.Name = "trkFGPalette";
            this.trkFGPalette.Size = new System.Drawing.Size(111, 20);
            this.trkFGPalette.TabIndex = 2;
            this.trkFGPalette.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkFGPalette.Scroll += new System.EventHandler(this.trkFGPalette_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "BG Palette:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(73, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "FG Palette:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(138, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 40);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Voice TBA";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnNew,
            this.btnDelete,
            this.toolStripSeparator1,
            this.btnPreview});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(363, 25);
            this.toolStrip1.TabIndex = 17;
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
            // btnPreview
            // 
            this.btnPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPreview.Image = global::FrogForge.Properties.Resources.Play;
            this.btnPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(23, 22);
            this.btnPreview.Text = "Preview";
            // 
            // frmPortraitEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 289);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstPortraits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPortraitEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portrait Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPortraitEditor_FormClosed);
            this.Load += new System.EventHandler(this.frmPortraitEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBG)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFG)).EndInit();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFGPalette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkFGPalette)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FrogForge.PortraitJSONBrowser lstPortraits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.GroupBox groupBox3;
        private AnimationPicturebox picFG;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private AnimationPicturebox picBG;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trkFGPalette;
        private System.Windows.Forms.PictureBox picFGPalette;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPreview;
        private System.Windows.Forms.PictureBox picPreview;
    }
}