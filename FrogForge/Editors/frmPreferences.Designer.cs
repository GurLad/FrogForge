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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbImageImportingGrayscale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbImageImportingAutoPalette = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.grpVoice.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZoomAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(304, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpVoice
            // 
            this.grpVoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpVoice.Controls.Add(this.cmbVoice);
            this.grpVoice.Location = new System.Drawing.Point(12, 210);
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
            this.groupBox1.Controls.Add(this.nudZoomAmount);
            this.groupBox1.Controls.Add(this.ckbDarkMode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 65);
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
            this.ckbDarkMode.Location = new System.Drawing.Point(6, 42);
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
            this.btnCancel.Location = new System.Drawing.Point(223, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rdbImageImportingAutoPalette);
            this.groupBox2.Controls.Add(this.rdbImageImportingGrayscale);
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 121);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image importing";
            // 
            // rdbImageImportingGrayscale
            // 
            this.rdbImageImportingGrayscale.AutoSize = true;
            this.rdbImageImportingGrayscale.Checked = true;
            this.rdbImageImportingGrayscale.Location = new System.Drawing.Point(6, 19);
            this.rdbImageImportingGrayscale.Name = "rdbImageImportingGrayscale";
            this.rdbImageImportingGrayscale.Size = new System.Drawing.Size(72, 17);
            this.rdbImageImportingGrayscale.TabIndex = 0;
            this.rdbImageImportingGrayscale.TabStop = true;
            this.rdbImageImportingGrayscale.Text = "Grayscale";
            this.rdbImageImportingGrayscale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assumes that images were created using the 4 grayscale colors.\r\nYou\'ll need to as" +
    "sign their palettes manually in Frog Forge.";
            // 
            // rdbImageImportingAutoPalette
            // 
            this.rdbImageImportingAutoPalette.AutoSize = true;
            this.rdbImageImportingAutoPalette.Location = new System.Drawing.Point(6, 70);
            this.rdbImageImportingAutoPalette.Name = "rdbImageImportingAutoPalette";
            this.rdbImageImportingAutoPalette.Size = new System.Drawing.Size(82, 17);
            this.rdbImageImportingAutoPalette.TabIndex = 0;
            this.rdbImageImportingAutoPalette.Text = "Auto-palette";
            this.rdbImageImportingAutoPalette.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tries to automatically deduce and assign the palette from the image.\r\nMight resul" +
    "t in undesirable palette order/wrong colors.";
            // 
            // frmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 297);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbImageImportingGrayscale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbImageImportingAutoPalette;
    }
}