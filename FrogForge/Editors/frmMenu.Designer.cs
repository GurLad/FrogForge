namespace FrogForge.Editors
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLevelEditor = new System.Windows.Forms.Button();
            this.btnConversationEditor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangePath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClassEditor = new System.Windows.Forms.Button();
            this.btnPortraitEditor = new System.Windows.Forms.Button();
            this.lblVoice = new System.Windows.Forms.Label();
            this.cmbVoice = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frog Forge";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frogman Gaiden editor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLevelEditor
            // 
            this.btnLevelEditor.Location = new System.Drawing.Point(12, 49);
            this.btnLevelEditor.Name = "btnLevelEditor";
            this.btnLevelEditor.Size = new System.Drawing.Size(289, 23);
            this.btnLevelEditor.TabIndex = 2;
            this.btnLevelEditor.Text = "Level editor";
            this.btnLevelEditor.UseVisualStyleBackColor = true;
            this.btnLevelEditor.Click += new System.EventHandler(this.btnLevelEditor_Click);
            // 
            // btnConversationEditor
            // 
            this.btnConversationEditor.Location = new System.Drawing.Point(12, 79);
            this.btnConversationEditor.Name = "btnConversationEditor";
            this.btnConversationEditor.Size = new System.Drawing.Size(289, 23);
            this.btnConversationEditor.TabIndex = 2;
            this.btnConversationEditor.Text = "Conversation editor";
            this.btnConversationEditor.UseVisualStyleBackColor = true;
            this.btnConversationEditor.Click += new System.EventHandler(this.btnConversationEditor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangePath);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 45);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project folder";
            // 
            // btnChangePath
            // 
            this.btnChangePath.Location = new System.Drawing.Point(208, 17);
            this.btnChangePath.Name = "btnChangePath";
            this.btnChangePath.Size = new System.Drawing.Size(75, 23);
            this.btnChangePath.TabIndex = 1;
            this.btnChangePath.Text = "Browse...";
            this.btnChangePath.UseVisualStyleBackColor = true;
            this.btnChangePath.Click += new System.EventHandler(this.btnChangePath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(6, 19);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(196, 20);
            this.txtPath.TabIndex = 0;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("3x5", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(-1, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(83, 6);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "V.0.5.1.5 28.03.2021";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImport);
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Location = new System.Drawing.Point(12, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 45);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frog Forge data";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(6, 17);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(134, 23);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import...";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(149, 17);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(134, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export...";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClassEditor
            // 
            this.btnClassEditor.Location = new System.Drawing.Point(12, 108);
            this.btnClassEditor.Name = "btnClassEditor";
            this.btnClassEditor.Size = new System.Drawing.Size(289, 23);
            this.btnClassEditor.TabIndex = 2;
            this.btnClassEditor.Text = "Class editor";
            this.btnClassEditor.UseVisualStyleBackColor = true;
            this.btnClassEditor.Click += new System.EventHandler(this.btnClassEditor_Click);
            // 
            // btnPortraitEditor
            // 
            this.btnPortraitEditor.Location = new System.Drawing.Point(12, 137);
            this.btnPortraitEditor.Name = "btnPortraitEditor";
            this.btnPortraitEditor.Size = new System.Drawing.Size(289, 23);
            this.btnPortraitEditor.TabIndex = 2;
            this.btnPortraitEditor.Text = "Portrait editor";
            this.btnPortraitEditor.UseVisualStyleBackColor = true;
            this.btnPortraitEditor.Click += new System.EventHandler(this.btnPortraitEditor_Click);
            // 
            // lblVoice
            // 
            this.lblVoice.AutoSize = true;
            this.lblVoice.Location = new System.Drawing.Point(12, 271);
            this.lblVoice.Name = "lblVoice";
            this.lblVoice.Size = new System.Drawing.Size(81, 13);
            this.lblVoice.TabIndex = 8;
            this.lblVoice.Text = "Voice assistant:";
            // 
            // cmbVoice
            // 
            this.cmbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoice.FormattingEnabled = true;
            this.cmbVoice.Location = new System.Drawing.Point(99, 268);
            this.cmbVoice.Name = "cmbVoice";
            this.cmbVoice.Size = new System.Drawing.Size(202, 21);
            this.cmbVoice.TabIndex = 7;
            this.cmbVoice.SelectedIndexChanged += new System.EventHandler(this.cmbVoice_SelectedIndexChanged);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 301);
            this.Controls.Add(this.lblVoice);
            this.Controls.Add(this.cmbVoice);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPortraitEditor);
            this.Controls.Add(this.btnClassEditor);
            this.Controls.Add(this.btnConversationEditor);
            this.Controls.Add(this.btnLevelEditor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frog Forge";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLevelEditor;
        private System.Windows.Forms.Button btnConversationEditor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChangePath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnClassEditor;
        private System.Windows.Forms.Button btnPortraitEditor;
        private System.Windows.Forms.Label lblVoice;
        private System.Windows.Forms.ComboBox cmbVoice;
    }
}