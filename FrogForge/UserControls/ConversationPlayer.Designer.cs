namespace FrogForge.UserControls
{
    partial class ConversationPlayer
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
            FrogForge.Palette palette2 = new FrogForge.Palette();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.lblPreviewText = new System.Windows.Forms.Label();
            this.lblPreviewName = new System.Windows.Forms.Label();
            this.picPreviewSpeaker = new FrogForge.UserControls.PalettedPicturebox();
            this.pnlPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewSpeaker)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPreview
            // 
            this.pnlPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPreview.BackgroundImage = global::FrogForge.Properties.Resources.FrogmanGaidenConversationBG;
            this.pnlPreview.Controls.Add(this.picArrow);
            this.pnlPreview.Controls.Add(this.lblPreviewText);
            this.pnlPreview.Controls.Add(this.lblPreviewName);
            this.pnlPreview.Controls.Add(this.picPreviewSpeaker);
            this.pnlPreview.Location = new System.Drawing.Point(0, 0);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(512, 480);
            this.pnlPreview.TabIndex = 2;
            // 
            // picArrow
            // 
            this.picArrow.BackgroundImage = global::FrogForge.Properties.Resources.Arrow;
            this.picArrow.Location = new System.Drawing.Point(480, 448);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(16, 16);
            this.picArrow.TabIndex = 2;
            this.picArrow.TabStop = false;
            // 
            // lblPreviewText
            // 
            this.lblPreviewText.BackColor = System.Drawing.Color.Transparent;
            this.lblPreviewText.Font = new System.Drawing.Font("Gaiden", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPreviewText.ForeColor = System.Drawing.Color.White;
            this.lblPreviewText.Location = new System.Drawing.Point(15, 416);
            this.lblPreviewText.Name = "lblPreviewText";
            this.lblPreviewText.Size = new System.Drawing.Size(488, 48);
            this.lblPreviewText.TabIndex = 1;
            this.lblPreviewText.Text = "012345678901234567890123456789\r\n\r\n01234567890123456789012345678";
            // 
            // lblPreviewName
            // 
            this.lblPreviewName.BackColor = System.Drawing.Color.Transparent;
            this.lblPreviewName.Font = new System.Drawing.Font("Gaiden", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPreviewName.ForeColor = System.Drawing.Color.White;
            this.lblPreviewName.Location = new System.Drawing.Point(141, 368);
            this.lblPreviewName.Name = "lblPreviewName";
            this.lblPreviewName.Size = new System.Drawing.Size(136, 16);
            this.lblPreviewName.TabIndex = 1;
            this.lblPreviewName.Text = "Xirveros";
            // 
            // picPreviewSpeaker
            // 
            this.picPreviewSpeaker.BackColor = System.Drawing.Color.Transparent;
            this.picPreviewSpeaker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPreviewSpeaker.Image = null;
            this.picPreviewSpeaker.Location = new System.Drawing.Point(16, 288);
            this.picPreviewSpeaker.Name = "picPreviewSpeaker";
            this.picPreviewSpeaker.Palette = palette2;
            this.picPreviewSpeaker.Size = new System.Drawing.Size(96, 96);
            this.picPreviewSpeaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreviewSpeaker.TabIndex = 3;
            this.picPreviewSpeaker.TabStop = false;
            // 
            // ConversationPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPreview);
            this.Name = "ConversationPlayer";
            this.Size = new System.Drawing.Size(512, 480);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConversationPlayer_KeyDown);
            this.pnlPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewSpeaker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.Label lblPreviewText;
        private System.Windows.Forms.Label lblPreviewName;
        private PalettedPicturebox picPreviewSpeaker;
    }
}
