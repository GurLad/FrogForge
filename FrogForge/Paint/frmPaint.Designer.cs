namespace FrogForge.Paint
{
    partial class frmPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaint));
            this.pnlPaintScreenHolder = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnImport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPencilTool = new System.Windows.Forms.ToolStripButton();
            this.pnlPalettes = new System.Windows.Forms.Panel();
            this.pnlPaintViewport = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.pnlPaintViewport.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPaintScreenHolder
            // 
            this.pnlPaintScreenHolder.BackColor = System.Drawing.Color.Black;
            this.pnlPaintScreenHolder.Location = new System.Drawing.Point(150, 49);
            this.pnlPaintScreenHolder.Name = "pnlPaintScreenHolder";
            this.pnlPaintScreenHolder.Size = new System.Drawing.Size(248, 171);
            this.pnlPaintScreenHolder.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnNew,
            this.toolStripSeparator1,
            this.btnExport,
            this.btnImport,
            this.toolStripSeparator2,
            this.btnPencilTool});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
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
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = global::FrogForge.Properties.Resources.New;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 22);
            this.btnNew.Text = "New";
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
            // 
            // btnImport
            // 
            this.btnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImport.Image = global::FrogForge.Properties.Resources.Import;
            this.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(23, 22);
            this.btnImport.Text = "Import";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPencilTool
            // 
            this.btnPencilTool.CheckOnClick = true;
            this.btnPencilTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPencilTool.Image = ((System.Drawing.Image)(resources.GetObject("btnPencilTool.Image")));
            this.btnPencilTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPencilTool.Name = "btnPencilTool";
            this.btnPencilTool.Size = new System.Drawing.Size(23, 22);
            this.btnPencilTool.Text = "toolStripButton1";
            // 
            // pnlPalettes
            // 
            this.pnlPalettes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPalettes.Location = new System.Drawing.Point(556, 29);
            this.pnlPalettes.Name = "pnlPalettes";
            this.pnlPalettes.Size = new System.Drawing.Size(232, 409);
            this.pnlPalettes.TabIndex = 13;
            // 
            // pnlPaintViewport
            // 
            this.pnlPaintViewport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPaintViewport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlPaintViewport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaintViewport.Controls.Add(this.pnlPaintScreenHolder);
            this.pnlPaintViewport.Location = new System.Drawing.Point(12, 29);
            this.pnlPaintViewport.Name = "pnlPaintViewport";
            this.pnlPaintViewport.Size = new System.Drawing.Size(538, 304);
            this.pnlPaintViewport.TabIndex = 14;
            // 
            // frmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPalettes);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlPaintViewport);
            this.Name = "frmPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPaint_FormClosed);
            this.SizeChanged += new System.EventHandler(this.frmPaint_SizeChanged);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlPaintViewport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPaintScreenHolder;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnPencilTool;
        private System.Windows.Forms.Panel pnlPalettes;
        private System.Windows.Forms.Panel pnlPaintViewport;
    }
}