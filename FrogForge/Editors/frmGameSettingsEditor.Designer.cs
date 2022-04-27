namespace FrogForge.Editors
{
    partial class frmGameSettingsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameSettingsEditor));
            this.label1 = new System.Windows.Forms.Label();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMainCharacterName = new System.Windows.Forms.TextBox();
            this.btnHelp1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rdbPlayerTeam1 = new System.Windows.Forms.RadioButton();
            this.rdbPlayerTeam2 = new System.Windows.Forms.RadioButton();
            this.rdbPlayerTeam3 = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mod name:";
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(99, 12);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(131, 20);
            this.txtModName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mod description:";
            // 
            // txtModDescription
            // 
            this.txtModDescription.Location = new System.Drawing.Point(12, 57);
            this.txtModDescription.Multiline = true;
            this.txtModDescription.Name = "txtModDescription";
            this.txtModDescription.Size = new System.Drawing.Size(218, 56);
            this.txtModDescription.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Main character:";
            // 
            // txtMainCharacterName
            // 
            this.txtMainCharacterName.Location = new System.Drawing.Point(99, 119);
            this.txtMainCharacterName.Name = "txtMainCharacterName";
            this.txtMainCharacterName.Size = new System.Drawing.Size(105, 20);
            this.txtMainCharacterName.TabIndex = 3;
            // 
            // btnHelp1
            // 
            this.btnHelp1.Location = new System.Drawing.Point(210, 119);
            this.btnHelp1.Name = "btnHelp1";
            this.btnHelp1.Size = new System.Drawing.Size(20, 20);
            this.btnHelp1.TabIndex = 4;
            this.btnHelp1.Tag = resources.GetString("btnHelp1.Tag");
            this.btnHelp1.Text = "?";
            this.btnHelp1.UseVisualStyleBackColor = true;
            this.btnHelp1.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Player team:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 8;
            this.button1.Tag = resources.GetString("button1.Tag");
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // rdbPlayerTeam1
            // 
            this.rdbPlayerTeam1.AutoSize = true;
            this.rdbPlayerTeam1.Location = new System.Drawing.Point(99, 146);
            this.rdbPlayerTeam1.Name = "rdbPlayerTeam1";
            this.rdbPlayerTeam1.Size = new System.Drawing.Size(31, 17);
            this.rdbPlayerTeam1.TabIndex = 5;
            this.rdbPlayerTeam1.TabStop = true;
            this.rdbPlayerTeam1.Text = "1";
            this.rdbPlayerTeam1.UseVisualStyleBackColor = true;
            // 
            // rdbPlayerTeam2
            // 
            this.rdbPlayerTeam2.AutoSize = true;
            this.rdbPlayerTeam2.Location = new System.Drawing.Point(136, 146);
            this.rdbPlayerTeam2.Name = "rdbPlayerTeam2";
            this.rdbPlayerTeam2.Size = new System.Drawing.Size(31, 17);
            this.rdbPlayerTeam2.TabIndex = 6;
            this.rdbPlayerTeam2.TabStop = true;
            this.rdbPlayerTeam2.Text = "2";
            this.rdbPlayerTeam2.UseVisualStyleBackColor = true;
            // 
            // rdbPlayerTeam3
            // 
            this.rdbPlayerTeam3.AutoSize = true;
            this.rdbPlayerTeam3.Location = new System.Drawing.Point(173, 146);
            this.rdbPlayerTeam3.Name = "rdbPlayerTeam3";
            this.rdbPlayerTeam3.Size = new System.Drawing.Size(31, 17);
            this.rdbPlayerTeam3.TabIndex = 7;
            this.rdbPlayerTeam3.TabStop = true;
            this.rdbPlayerTeam3.Text = "3";
            this.rdbPlayerTeam3.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(74, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(155, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmGameSettingsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 206);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdbPlayerTeam3);
            this.Controls.Add(this.rdbPlayerTeam2);
            this.Controls.Add(this.rdbPlayerTeam1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHelp1);
            this.Controls.Add(this.txtModDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMainCharacterName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGameSettingsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.frmGameSettingsEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMainCharacterName;
        private System.Windows.Forms.Button btnHelp1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbPlayerTeam1;
        private System.Windows.Forms.RadioButton rdbPlayerTeam2;
        private System.Windows.Forms.RadioButton rdbPlayerTeam3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}