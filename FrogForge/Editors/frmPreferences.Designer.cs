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
            this.nudZoomAmount = new System.Windows.Forms.NumericUpDown();
            this.ckbDarkMode = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFontFamily = new System.Windows.Forms.ComboBox();
            this.grpVoice.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZoomAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(196, 169);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpVoice
            // 
            this.grpVoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVoice.Controls.Add(this.cmbVoice);
            this.grpVoice.Location = new System.Drawing.Point(12, 117);
            this.grpVoice.Name = "grpVoice";
            this.grpVoice.Size = new System.Drawing.Size(259, 46);
            this.grpVoice.TabIndex = 1;
            this.grpVoice.TabStop = false;
            this.grpVoice.Text = "Voice Assist";
            this.grpVoice.Visible = false;
            // 
            // cmbVoice
            // 
            this.cmbVoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoice.FormattingEnabled = true;
            this.cmbVoice.Location = new System.Drawing.Point(6, 19);
            this.cmbVoice.Name = "cmbVoice";
            this.cmbVoice.Size = new System.Drawing.Size(247, 21);
            this.cmbVoice.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbFontFamily);
            this.groupBox1.Controls.Add(this.nudZoomAmount);
            this.groupBox1.Controls.Add(this.ckbDarkMode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editor style";
            // 
            // nudZoomAmount
            // 
            this.nudZoomAmount.DecimalPlaces = 2;
            this.nudZoomAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudZoomAmount.Location = new System.Drawing.Point(87, 18);
            this.nudZoomAmount.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudZoomAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudZoomAmount.Name = "nudZoomAmount";
            this.nudZoomAmount.Size = new System.Drawing.Size(44, 20);
            this.nudZoomAmount.TabIndex = 3;
            this.nudZoomAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ckbDarkMode
            // 
            this.ckbDarkMode.AutoSize = true;
            this.ckbDarkMode.Location = new System.Drawing.Point(6, 48);
            this.ckbDarkMode.Name = "ckbDarkMode";
            this.ckbDarkMode.Size = new System.Drawing.Size(78, 17);
            this.ckbDarkMode.TabIndex = 1;
            this.ckbDarkMode.Text = "Dark mode";
            this.ckbDarkMode.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zoom amount:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(115, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Font family:";
            // 
            // cmbFontFamily
            // 
            this.cmbFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFontFamily.FormattingEnabled = true;
            this.cmbFontFamily.Location = new System.Drawing.Point(87, 71);
            this.cmbFontFamily.Name = "cmbFontFamily";
            this.cmbFontFamily.Size = new System.Drawing.Size(166, 21);
            this.cmbFontFamily.TabIndex = 4;
            this.cmbFontFamily.SelectedIndexChanged += new System.EventHandler(this.cmbFontFamily_SelectedIndexChanged);
            // 
            // frmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 204);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudZoomAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpVoice;
        private System.Windows.Forms.ComboBox cmbVoice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbDarkMode;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudZoomAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFontFamily;
        private System.Windows.Forms.Label label2;
    }
}