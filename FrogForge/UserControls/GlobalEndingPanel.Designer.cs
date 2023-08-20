namespace FrogForge.UserControls
{
    partial class GlobalEndingPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalEndingPanel));
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtRequirement = new FrogForge.UserControls.EventTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Font = new System.Drawing.Font("Gaiden", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtText.Location = new System.Drawing.Point(0, 79);
            this.txtText.MaxLength = 464;
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(246, 125);
            this.txtText.TabIndex = 9;
            this.txtText.Text = resources.GetString("txtText.Text");
            // 
            // txtRequirement
            // 
            this.txtRequirement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequirement.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtRequirement.Location = new System.Drawing.Point(0, 17);
            this.txtRequirement.Name = "txtRequirement";
            this.txtRequirement.Size = new System.Drawing.Size(246, 37);
            this.txtRequirement.TabIndex = 5;
            this.txtRequirement.Text = "h\nh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Requirements:";
            // 
            // GlobalEndingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtRequirement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "GlobalEndingPanel";
            this.Size = new System.Drawing.Size(246, 204);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtText;
        private EventTextBox txtRequirement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
