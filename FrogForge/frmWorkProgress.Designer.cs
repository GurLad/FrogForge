namespace FrogForge
{
    partial class frmWorkProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkProgress));
            this.lblWorking = new System.Windows.Forms.Label();
            this.prbProgress = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWorking
            // 
            this.lblWorking.AutoSize = true;
            this.lblWorking.Location = new System.Drawing.Point(13, 13);
            this.lblWorking.Name = "lblWorking";
            this.lblWorking.Size = new System.Drawing.Size(56, 13);
            this.lblWorking.TabIndex = 0;
            this.lblWorking.Text = "Working...";
            // 
            // prbProgress
            // 
            this.prbProgress.Location = new System.Drawing.Point(13, 30);
            this.prbProgress.Name = "prbProgress";
            this.prbProgress.Size = new System.Drawing.Size(259, 23);
            this.prbProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prbProgress.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 59);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmWorkProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 94);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.prbProgress);
            this.Controls.Add(this.lblWorking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWorkProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Working...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWorkProgress_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWorking;
        private System.Windows.Forms.ProgressBar prbProgress;
        private System.Windows.Forms.Button btnCancel;
    }
}