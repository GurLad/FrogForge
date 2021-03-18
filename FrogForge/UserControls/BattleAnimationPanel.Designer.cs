namespace FrogForge.UserControls
{
    public partial class BattleAnimationPanel : BattleAnimationEditor
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.picAnimation = new FrogForge.UserControls.AnimationPicturebox();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(42, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // picAnimation
            // 
            this.picAnimation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAnimation.Image = null;
            this.picAnimation.Location = new System.Drawing.Point(0, 0);
            this.picAnimation.Name = "picAnimation";
            this.picAnimation.Size = new System.Drawing.Size(36, 36);
            this.picAnimation.TabIndex = 3;
            this.picAnimation.TabStop = false;
            // 
            // BattleAnimationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picAnimation);
            this.Controls.Add(this.txtName);
            this.Name = "BattleAnimationPanel";
            this.Size = new System.Drawing.Size(142, 36);
            ((System.ComponentModel.ISupportInitialize)(this.picAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AnimationPicturebox picAnimation;
        private System.Windows.Forms.TextBox txtName;
    }
}
