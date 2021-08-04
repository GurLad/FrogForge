namespace FrogForge.UserControls
{
    partial class MapEventPanel
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
            this.txtRequirement = new FrogForge.UserControls.EventTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEvent = new FrogForge.UserControls.EventTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Requirements:";
            // 
            // txtRequirement
            // 
            this.txtRequirement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequirement.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtRequirement.Location = new System.Drawing.Point(0, 17);
            this.txtRequirement.Name = "txtRequirement";
            this.txtRequirement.Size = new System.Drawing.Size(274, 37);
            this.txtRequirement.TabIndex = 1;
            this.txtRequirement.Text = "h\nh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Event:";
            // 
            // txtEvent
            // 
            this.txtEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEvent.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtEvent.Location = new System.Drawing.Point(0, 73);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(274, 115);
            this.txtEvent.TabIndex = 1;
            // 
            // MapEventPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.txtRequirement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MapEventPanel";
            this.Size = new System.Drawing.Size(274, 188);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private EventTextBox txtRequirement;
        private System.Windows.Forms.Label label2;
        private EventTextBox txtEvent;
    }
}
