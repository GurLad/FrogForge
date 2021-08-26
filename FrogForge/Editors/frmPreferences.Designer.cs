namespace FrogForge.Editors
{
    partial class frmPreferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreferences));
            this.btnSave = new System.Windows.Forms.Button();
            this.grpVoice = new System.Windows.Forms.GroupBox();
            this.cmbVoice = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbZoomMode = new System.Windows.Forms.CheckBox();
            this.ckbDarkMode = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpVoice.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(304, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpVoice
            // 
            this.grpVoice.Controls.Add(this.cmbVoice);
            this.grpVoice.Location = new System.Drawing.Point(12, 83);
            this.grpVoice.Name = "grpVoice";
            this.grpVoice.Size = new System.Drawing.Size(367, 46);
            this.grpVoice.TabIndex = 1;
            this.grpVoice.TabStop = false;
            this.grpVoice.Text = "Voice Assist";
            this.grpVoice.Visible = false;
            // 
            // cmbVoice
            // 
            this.cmbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoice.FormattingEnabled = true;
            this.cmbVoice.Location = new System.Drawing.Point(6, 19);
            this.cmbVoice.Name = "cmbVoice";
            this.cmbVoice.Size = new System.Drawing.Size(355, 21);
            this.cmbVoice.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbDarkMode);
            this.groupBox1.Controls.Add(this.ckbZoomMode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editor style";
            // 
            // ckbZoomMode
            // 
            this.ckbZoomMode.AutoSize = true;
            this.ckbZoomMode.Enabled = false;
            this.ckbZoomMode.Location = new System.Drawing.Point(6, 19);
            this.ckbZoomMode.Name = "ckbZoomMode";
            this.ckbZoomMode.Size = new System.Drawing.Size(112, 17);
            this.ckbZoomMode.TabIndex = 0;
            this.ckbZoomMode.Text = "Zoom mode (TBA)";
            this.ckbZoomMode.UseVisualStyleBackColor = true;
            // 
            // ckbDarkMode
            // 
            this.ckbDarkMode.AutoSize = true;
            this.ckbDarkMode.Location = new System.Drawing.Point(6, 42);
            this.ckbDarkMode.Name = "ckbDarkMode";
            this.ckbDarkMode.Size = new System.Drawing.Size(78, 17);
            this.ckbDarkMode.TabIndex = 1;
            this.ckbDarkMode.Text = "Dark mode";
            this.ckbDarkMode.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(223, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 170);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpVoice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPreferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPreferences_FormClosed);
            this.Load += new System.EventHandler(this.frmPreferences_Load);
            this.grpVoice.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpVoice;
        private System.Windows.Forms.ComboBox cmbVoice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbZoomMode;
        private System.Windows.Forms.CheckBox ckbDarkMode;
        private System.Windows.Forms.Button btnCancel;
    }
}