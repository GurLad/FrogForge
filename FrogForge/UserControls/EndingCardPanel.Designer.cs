namespace FrogForge.UserControls
{
    partial class EndingCardPanel
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
            this.txtRequirement = new FrogForge.UserControls.EventTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRequirement
            // 
            this.txtRequirement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequirement.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtRequirement.Location = new System.Drawing.Point(0, 17);
            this.txtRequirement.Name = "txtRequirement";
            this.txtRequirement.Size = new System.Drawing.Size(246, 37);
            this.txtRequirement.TabIndex = 1;
            this.txtRequirement.Text = "h\nh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Requirements:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title:";
            // 
            // txtCard
            // 
            this.txtCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCard.Font = new System.Drawing.Font("Gaiden", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCard.Location = new System.Drawing.Point(0, 99);
            this.txtCard.MaxLength = 123;
            this.txtCard.Multiline = true;
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(246, 37);
            this.txtCard.TabIndex = 3;
            this.txtCard.Text = "012345678901234567890123456789\r\n012345678901234567890123456789\r\n01234567890123456" +
    "7890123456789\r\n012345678901234567890123456789";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(36, 60);
            this.txtTitle.MaxLength = 22;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(210, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Card:";
            // 
            // EndingCardPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRequirement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "EndingCardPanel";
            this.Size = new System.Drawing.Size(246, 136);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EventTextBox txtRequirement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
    }
}
