namespace FrogForge
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
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.lblPreviewText = new System.Windows.Forms.Label();
            this.lblPreviewName = new System.Windows.Forms.Label();
            this.picPreviewSpeaker = new System.Windows.Forms.PictureBox();
            this.pnlEditorUI = new System.Windows.Forms.Panel();
            this.picSeperator2 = new System.Windows.Forms.PictureBox();
            this.picSeperator1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtText = new FrogForge.FixedRichTextBox();
            this.flbFileBrowser = new FrogForge.FileBrowser();
            this.pnlPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewSpeaker)).BeginInit();
            this.pnlEditorUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeperator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeperator1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPreview
            // 
            this.pnlPreview.Controls.Add(this.picArrow);
            this.pnlPreview.Controls.Add(this.lblPreviewText);
            this.pnlPreview.Controls.Add(this.lblPreviewName);
            this.pnlPreview.Controls.Add(this.picPreviewSpeaker);
            this.pnlPreview.Location = new System.Drawing.Point(195, 12);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(512, 480);
            this.pnlPreview.TabIndex = 1;
            // 
            // picArrow
            // 
            this.picArrow.Location = new System.Drawing.Point(480, 448);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(16, 16);
            this.picArrow.TabIndex = 2;
            this.picArrow.TabStop = false;
            // 
            // lblPreviewText
            // 
            this.lblPreviewText.BackColor = System.Drawing.Color.Transparent;
            this.lblPreviewText.Font = new System.Drawing.Font("Gaiden", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPreviewText.ForeColor = System.Drawing.Color.White;
            this.lblPreviewText.Location = new System.Drawing.Point(141, 416);
            this.lblPreviewText.Name = "lblPreviewText";
            this.lblPreviewText.Size = new System.Drawing.Size(362, 48);
            this.lblPreviewText.TabIndex = 1;
            this.lblPreviewText.Text = "I was a great wizard~@\r\n\r\nI never ate a lizard@";
            // 
            // lblPreviewName
            // 
            this.lblPreviewName.BackColor = System.Drawing.Color.Transparent;
            this.lblPreviewName.Font = new System.Drawing.Font("Gaiden", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPreviewName.ForeColor = System.Drawing.Color.White;
            this.lblPreviewName.Location = new System.Drawing.Point(141, 368);
            this.lblPreviewName.Name = "lblPreviewName";
            this.lblPreviewName.Size = new System.Drawing.Size(136, 16);
            this.lblPreviewName.TabIndex = 1;
            this.lblPreviewName.Text = "Xirveros";
            // 
            // picPreviewSpeaker
            // 
            this.picPreviewSpeaker.BackColor = System.Drawing.Color.Transparent;
            this.picPreviewSpeaker.Location = new System.Drawing.Point(16, 368);
            this.picPreviewSpeaker.Name = "picPreviewSpeaker";
            this.picPreviewSpeaker.Size = new System.Drawing.Size(96, 96);
            this.picPreviewSpeaker.TabIndex = 0;
            this.picPreviewSpeaker.TabStop = false;
            // 
            // pnlEditorUI
            // 
            this.pnlEditorUI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEditorUI.Controls.Add(this.picSeperator2);
            this.pnlEditorUI.Controls.Add(this.picSeperator1);
            this.pnlEditorUI.Controls.Add(this.txtText);
            this.pnlEditorUI.Controls.Add(this.btnSave);
            this.pnlEditorUI.Controls.Add(this.btnPreview);
            this.pnlEditorUI.Controls.Add(this.label1);
            this.pnlEditorUI.Controls.Add(this.txtName);
            this.pnlEditorUI.Location = new System.Drawing.Point(713, 12);
            this.pnlEditorUI.Name = "pnlEditorUI";
            this.pnlEditorUI.Size = new System.Drawing.Size(455, 480);
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
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(0, 428);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(455, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Location = new System.Drawing.Point(0, 457);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(455, 23);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
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
            this.txtName.Size = new System.Drawing.Size(414, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(0, 26);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(455, 396);
            this.txtText.TabIndex = 3;
            this.txtText.Text = "Xirveros: I was a great wizard~@ I never ate a lizard@\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" +
    "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
            this.txtText.SelectionChanged += new System.EventHandler(this.txtText_TextChanged);
            this.txtText.VScroll += new System.EventHandler(this.txtText_TextChanged);
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            this.txtText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtText_KeyPress);
            // 
            // flbFileBrowser
            // 
            this.flbFileBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flbFileBrowser.Location = new System.Drawing.Point(12, 12);
            this.flbFileBrowser.Name = "flbFileBrowser";
            this.flbFileBrowser.Size = new System.Drawing.Size(177, 479);
            this.flbFileBrowser.TabIndex = 0;
            // 
            // frmConversationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 504);
            this.Controls.Add(this.pnlEditorUI);
            this.Controls.Add(this.pnlPreview);
            this.Controls.Add(this.flbFileBrowser);
            this.KeyPreview = true;
            this.Name = "frmConversationEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversation Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConversationEditor_FormClosing);
            this.Load += new System.EventHandler(this.frmConversationEditor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConversationEditor_KeyDown);
            this.pnlPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewSpeaker)).EndInit();
            this.pnlEditorUI.ResumeLayout(false);
            this.pnlEditorUI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeperator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeperator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FileBrowser flbFileBrowser;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.PictureBox picPreviewSpeaker;
        private System.Windows.Forms.Label lblPreviewName;
        private System.Windows.Forms.Label lblPreviewText;
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.Panel pnlEditorUI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picSeperator2;
        private System.Windows.Forms.PictureBox picSeperator1;
        private FixedRichTextBox txtText;
    }
}