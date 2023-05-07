
namespace FrogForge.UserControls
{
    partial class GenericCharacterVoicePanel
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
            this.txtNames = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbSquare50 = new System.Windows.Forms.CheckBox();
            this.ckbSquare25 = new System.Windows.Forms.CheckBox();
            this.ckbSquare12 = new System.Windows.Forms.CheckBox();
            this.ckbTriangle = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vpsMax = new FrogForge.UserControls.VoicePitchSlider();
            this.vpsMin = new FrogForge.UserControls.VoicePitchSlider();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInternalName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Names:";
            // 
            // txtNames
            // 
            this.txtNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNames.Location = new System.Drawing.Point(0, 40);
            this.txtNames.Multiline = true;
            this.txtNames.Name = "txtNames";
            this.txtNames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNames.Size = new System.Drawing.Size(213, 55);
            this.txtNames.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Voices:";
            // 
            // ckbSquare50
            // 
            this.ckbSquare50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbSquare50.AutoSize = true;
            this.ckbSquare50.Location = new System.Drawing.Point(48, 97);
            this.ckbSquare50.Name = "ckbSquare50";
            this.ckbSquare50.Size = new System.Drawing.Size(75, 17);
            this.ckbSquare50.TabIndex = 3;
            this.ckbSquare50.Text = "Square 50";
            this.ckbSquare50.UseVisualStyleBackColor = true;
            // 
            // ckbSquare25
            // 
            this.ckbSquare25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbSquare25.AutoSize = true;
            this.ckbSquare25.Location = new System.Drawing.Point(129, 97);
            this.ckbSquare25.Name = "ckbSquare25";
            this.ckbSquare25.Size = new System.Drawing.Size(75, 17);
            this.ckbSquare25.TabIndex = 3;
            this.ckbSquare25.Text = "Square 25";
            this.ckbSquare25.UseVisualStyleBackColor = true;
            // 
            // ckbSquare12
            // 
            this.ckbSquare12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbSquare12.AutoSize = true;
            this.ckbSquare12.Location = new System.Drawing.Point(48, 120);
            this.ckbSquare12.Name = "ckbSquare12";
            this.ckbSquare12.Size = new System.Drawing.Size(75, 17);
            this.ckbSquare12.TabIndex = 3;
            this.ckbSquare12.Text = "Square 12";
            this.ckbSquare12.UseVisualStyleBackColor = true;
            // 
            // ckbTriangle
            // 
            this.ckbTriangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbTriangle.AutoSize = true;
            this.ckbTriangle.Location = new System.Drawing.Point(129, 120);
            this.ckbTriangle.Name = "ckbTriangle";
            this.ckbTriangle.Size = new System.Drawing.Size(64, 17);
            this.ckbTriangle.TabIndex = 3;
            this.ckbTriangle.Text = "Triangle";
            this.ckbTriangle.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Minimum pitch:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Maximum pitch:";
            // 
            // vpsMax
            // 
            this.vpsMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vpsMax.Location = new System.Drawing.Point(110, 161);
            this.vpsMax.Name = "vpsMax";
            this.vpsMax.Pitch = 1F;
            this.vpsMax.Size = new System.Drawing.Size(103, 20);
            this.vpsMax.TabIndex = 5;
            // 
            // vpsMin
            // 
            this.vpsMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vpsMin.Location = new System.Drawing.Point(0, 161);
            this.vpsMin.Name = "vpsMin";
            this.vpsMin.Pitch = 1F;
            this.vpsMin.Size = new System.Drawing.Size(103, 20);
            this.vpsMin.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Internal name:";
            // 
            // txtInternalName
            // 
            this.txtInternalName.Location = new System.Drawing.Point(80, 0);
            this.txtInternalName.Name = "txtInternalName";
            this.txtInternalName.Size = new System.Drawing.Size(133, 20);
            this.txtInternalName.TabIndex = 7;
            // 
            // GenericCharacterVoicePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtInternalName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vpsMax);
            this.Controls.Add(this.vpsMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckbTriangle);
            this.Controls.Add(this.ckbSquare25);
            this.Controls.Add(this.ckbSquare12);
            this.Controls.Add(this.ckbSquare50);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.label1);
            this.Name = "GenericCharacterVoicePanel";
            this.Size = new System.Drawing.Size(213, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbSquare50;
        private System.Windows.Forms.CheckBox ckbSquare25;
        private System.Windows.Forms.CheckBox ckbSquare12;
        private System.Windows.Forms.CheckBox ckbTriangle;
        private System.Windows.Forms.Label label3;
        private VoicePitchSlider vpsMin;
        private VoicePitchSlider vpsMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInternalName;
    }
}
