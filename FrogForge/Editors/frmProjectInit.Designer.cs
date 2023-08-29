namespace FrogForge.Editors
{
    partial class frmProjectInit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectInit));
            this.label1 = new System.Windows.Forms.Label();
            this.rdbFrogmanMagmaborn = new System.Windows.Forms.RadioButton();
            this.rdbSampleMod = new System.Windows.Forms.RadioButton();
            this.rdbEmptyProject = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // rdbFrogmanMagmaborn
            // 
            this.rdbFrogmanMagmaborn.AutoSize = true;
            this.rdbFrogmanMagmaborn.Checked = true;
            this.rdbFrogmanMagmaborn.Location = new System.Drawing.Point(12, 96);
            this.rdbFrogmanMagmaborn.Name = "rdbFrogmanMagmaborn";
            this.rdbFrogmanMagmaborn.Size = new System.Drawing.Size(201, 17);
            this.rdbFrogmanMagmaborn.TabIndex = 1;
            this.rdbFrogmanMagmaborn.TabStop = true;
            this.rdbFrogmanMagmaborn.Text = "Frogman Magmaborn (recommended)";
            this.rdbFrogmanMagmaborn.UseVisualStyleBackColor = true;
            // 
            // rdbSampleMod
            // 
            this.rdbSampleMod.AutoSize = true;
            this.rdbSampleMod.Location = new System.Drawing.Point(12, 119);
            this.rdbSampleMod.Name = "rdbSampleMod";
            this.rdbSampleMod.Size = new System.Drawing.Size(165, 17);
            this.rdbSampleMod.TabIndex = 1;
            this.rdbSampleMod.Text = "Sample mod (Gravity Banana)";
            this.rdbSampleMod.UseVisualStyleBackColor = true;
            // 
            // rdbEmptyProject
            // 
            this.rdbEmptyProject.AutoSize = true;
            this.rdbEmptyProject.Location = new System.Drawing.Point(12, 142);
            this.rdbEmptyProject.Name = "rdbEmptyProject";
            this.rdbEmptyProject.Size = new System.Drawing.Size(258, 17);
            this.rdbEmptyProject.TabIndex = 1;
            this.rdbEmptyProject.Text = "Empty project (will crash the game until you edit it)";
            this.rdbEmptyProject.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(281, 165);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmProjectInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 200);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rdbEmptyProject);
            this.Controls.Add(this.rdbSampleMod);
            this.Controls.Add(this.rdbFrogmanMagmaborn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProjectInit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Welcome to Frog Forge";
            this.Load += new System.EventHandler(this.frmProjectInit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbFrogmanMagmaborn;
        private System.Windows.Forms.RadioButton rdbSampleMod;
        private System.Windows.Forms.RadioButton rdbEmptyProject;
        private System.Windows.Forms.Button btnNext;
    }
}