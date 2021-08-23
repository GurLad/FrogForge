namespace FrogForge.Editors
{
    partial class frmCGEditor
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
            FrogForge.Palette palette2 = new FrogForge.Palette();
            FrogForge.Palette palette3 = new FrogForge.Palette();
            FrogForge.Palette palette4 = new FrogForge.Palette();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCGEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.lstCGs = new FrogForge.UserControls.CGJSONBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBG1 = new FrogForge.UserControls.PartialPalettedPicturebox();
            this.label1 = new System.Windows.Forms.Label();
            this.pltBG1 = new FrogForge.UserControls.PalettePanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picBG2 = new FrogForge.UserControls.PartialPalettedPicturebox();
            this.pltBG2 = new FrogForge.UserControls.PalettePanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picFG1 = new FrogForge.UserControls.PalettedPicturebox();
            this.fgpFG1 = new FrogForge.UserControls.ForegroundPaletteSelector();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fgpFG2 = new FrogForge.UserControls.ForegroundPaletteSelector();
            this.picFG2 = new FrogForge.UserControls.PalettedPicturebox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBG1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBG2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFG1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFG2)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(964, 25);
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
            // lstCGs
            // 
            this.lstCGs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCGs.FormattingEnabled = true;
            this.lstCGs.Location = new System.Drawing.Point(12, 28);
            this.lstCGs.Name = "lstCGs";
            this.lstCGs.Size = new System.Drawing.Size(118, 615);
            this.lstCGs.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBG1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pltBG1);
            this.groupBox1.Location = new System.Drawing.Point(136, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 291);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BG 1";
            // 
            // picBG1
            // 
            this.picBG1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picBG1.Image = null;
            this.picBG1.Location = new System.Drawing.Point(6, 45);
            this.picBG1.Name = "picBG1";
            this.picBG1.Palette = palette1;
            this.picBG1.Size = new System.Drawing.Size(256, 240);
            this.picBG1.TabIndex = 20;
            this.picBG1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Palette 1:";
            // 
            // pltBG1
            // 
            this.pltBG1.Location = new System.Drawing.Point(64, 19);
            this.pltBG1.Name = "pltBG1";
            this.pltBG1.Size = new System.Drawing.Size(198, 20);
            this.pltBG1.SpritePalette = false;
            this.pltBG1.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.picBG2);
            this.groupBox2.Controls.Add(this.pltBG2);
            this.groupBox2.Location = new System.Drawing.Point(410, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 291);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BG 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Palette 2:";
            // 
            // picBG2
            // 
            this.picBG2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picBG2.Image = null;
            this.picBG2.Location = new System.Drawing.Point(6, 45);
            this.picBG2.Name = "picBG2";
            this.picBG2.Palette = palette2;
            this.picBG2.Size = new System.Drawing.Size(256, 240);
            this.picBG2.TabIndex = 20;
            this.picBG2.TabStop = false;
            // 
            // pltBG2
            // 
            this.pltBG2.Location = new System.Drawing.Point(64, 19);
            this.pltBG2.Name = "pltBG2";
            this.pltBG2.Size = new System.Drawing.Size(198, 20);
            this.pltBG2.SpritePalette = false;
            this.pltBG2.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.picFG1);
            this.groupBox3.Controls.Add(this.fgpFG1);
            this.groupBox3.Location = new System.Drawing.Point(136, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 291);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FG 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Palette 1:";
            // 
            // picFG1
            // 
            this.picFG1.Image = null;
            this.picFG1.Location = new System.Drawing.Point(6, 45);
            this.picFG1.Name = "picFG1";
            this.picFG1.Palette = palette3;
            this.picFG1.Size = new System.Drawing.Size(256, 240);
            this.picFG1.TabIndex = 26;
            this.picFG1.TabStop = false;
            // 
            // fgpFG1
            // 
            this.fgpFG1.Data = 0;
            this.fgpFG1.Location = new System.Drawing.Point(64, 19);
            this.fgpFG1.Name = "fgpFG1";
            this.fgpFG1.Size = new System.Drawing.Size(198, 20);
            this.fgpFG1.TabIndex = 27;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.fgpFG2);
            this.groupBox4.Controls.Add(this.picFG2);
            this.groupBox4.Location = new System.Drawing.Point(410, 351);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 291);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FG 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Palette 2:";
            // 
            // fgpFG2
            // 
            this.fgpFG2.Data = 0;
            this.fgpFG2.Location = new System.Drawing.Point(64, 19);
            this.fgpFG2.Name = "fgpFG2";
            this.fgpFG2.Size = new System.Drawing.Size(198, 20);
            this.fgpFG2.TabIndex = 27;
            // 
            // picFG2
            // 
            this.picFG2.Image = null;
            this.picFG2.Location = new System.Drawing.Point(6, 45);
            this.picFG2.Name = "picFG2";
            this.picFG2.Palette = palette4;
            this.picFG2.Size = new System.Drawing.Size(256, 240);
            this.picFG2.TabIndex = 26;
            this.picFG2.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(180, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Name:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.picPreview);
            this.groupBox5.Location = new System.Drawing.Point(684, 218);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(268, 265);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Preview";
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(6, 19);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(256, 240);
            this.picPreview.TabIndex = 21;
            this.picPreview.TabStop = false;
            // 
            // frmCGEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 654);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstCGs);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCGEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CG Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCGEditor_FormClosed);
            this.Load += new System.EventHandler(this.frmCGEditor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBG1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBG2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFG1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFG2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private UserControls.CGJSONBrowser lstCGs;
        private UserControls.PartialPalettedPicturebox picBG1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private UserControls.PartialPalettedPicturebox picBG2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UserControls.PalettePanel pltBG2;
        private UserControls.PalettePanel pltBG1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private UserControls.PalettedPicturebox picFG1;
        private UserControls.PalettedPicturebox picFG2;
        private System.Windows.Forms.PictureBox picPreview;
        private UserControls.ForegroundPaletteSelector fgpFG1;
        private UserControls.ForegroundPaletteSelector fgpFG2;
    }
}