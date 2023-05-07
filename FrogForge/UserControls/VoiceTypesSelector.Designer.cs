namespace FrogForge.UserControls
{
    partial class VoiceTypesSelector
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
            this.hsbScrollBar = new System.Windows.Forms.HScrollBar();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // hsbScrollBar
            // 
            this.hsbScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hsbScrollBar.LargeChange = 2;
            this.hsbScrollBar.Location = new System.Drawing.Point(0, 15);
            this.hsbScrollBar.Maximum = 3;
            this.hsbScrollBar.Name = "hsbScrollBar";
            this.hsbScrollBar.Size = new System.Drawing.Size(137, 10);
            this.hsbScrollBar.TabIndex = 1;
            this.hsbScrollBar.Value = 2;
            this.hsbScrollBar.Visible = false;
            this.hsbScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbScrollBar_Scroll);
            // 
            // pnlOptions
            // 
            this.pnlOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(137, 15);
            this.pnlOptions.TabIndex = 2;
            // 
            // VoiceTypesSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hsbScrollBar);
            this.Controls.Add(this.pnlOptions);
            this.Name = "VoiceTypesSelector";
            this.Size = new System.Drawing.Size(137, 25);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.HScrollBar hsbScrollBar;
        private System.Windows.Forms.Panel pnlOptions;
    }
}
