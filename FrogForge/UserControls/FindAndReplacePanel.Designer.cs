namespace FrogForge.UserControls
{
    partial class FindAndReplacePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.rdbCurrentDocument = new System.Windows.Forms.RadioButton();
            this.rdbAllFiles = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find:";
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.Location = new System.Drawing.Point(0, 16);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(150, 20);
            this.txtFind.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Replace:";
            // 
            // txtReplace
            // 
            this.txtReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReplace.Location = new System.Drawing.Point(0, 55);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(150, 20);
            this.txtReplace.TabIndex = 1;
            this.txtReplace.TextChanged += new System.EventHandler(this.txtReplace_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(0, 81);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(150, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find next";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Enabled = false;
            this.btnReplace.Location = new System.Drawing.Point(0, 110);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(72, 23);
            this.btnReplace.TabIndex = 2;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplaceAll.Enabled = false;
            this.btnReplaceAll.Location = new System.Drawing.Point(78, 110);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(72, 23);
            this.btnReplaceAll.TabIndex = 2;
            this.btnReplaceAll.Text = "Replace all";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // rdbCurrentDocument
            // 
            this.rdbCurrentDocument.AutoSize = true;
            this.rdbCurrentDocument.Checked = true;
            this.rdbCurrentDocument.Location = new System.Drawing.Point(0, 140);
            this.rdbCurrentDocument.Name = "rdbCurrentDocument";
            this.rdbCurrentDocument.Size = new System.Drawing.Size(109, 17);
            this.rdbCurrentDocument.TabIndex = 3;
            this.rdbCurrentDocument.TabStop = true;
            this.rdbCurrentDocument.Text = "Current document";
            this.rdbCurrentDocument.UseVisualStyleBackColor = true;
            // 
            // rdbAllFiles
            // 
            this.rdbAllFiles.AutoSize = true;
            this.rdbAllFiles.Location = new System.Drawing.Point(0, 163);
            this.rdbAllFiles.Name = "rdbAllFiles";
            this.rdbAllFiles.Size = new System.Drawing.Size(57, 17);
            this.rdbAllFiles.TabIndex = 3;
            this.rdbAllFiles.Text = "All files";
            this.rdbAllFiles.UseVisualStyleBackColor = true;
            // 
            // FindAndReplacePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rdbAllFiles);
            this.Controls.Add(this.rdbCurrentDocument);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.Name = "FindAndReplacePanel";
            this.Size = new System.Drawing.Size(150, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.RadioButton rdbCurrentDocument;
        private System.Windows.Forms.RadioButton rdbAllFiles;
    }
}
