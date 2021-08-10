namespace FrogForge.UserControls
{
    partial class BattleBackgroundPanel
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
            FrogForge.Palette palette5 = new FrogForge.Palette();
            FrogForge.Palette palette6 = new FrogForge.Palette();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picLayer1 = new FrogForge.UserControls.PartialPalettedPicturebox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picLayer2 = new FrogForge.UserControls.PartialPalettedPicturebox();
            this.txtTileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLayer1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picLayer1);
            this.groupBox3.Location = new System.Drawing.Point(0, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 201);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Layer 1";
            // 
            // picLayer1
            // 
            this.picLayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLayer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLayer1.Image = null;
            this.picLayer1.Location = new System.Drawing.Point(6, 19);
            this.picLayer1.Name = "picLayer1";
            this.picLayer1.Palette = palette5;
            this.picLayer1.Size = new System.Drawing.Size(132, 172);
            this.picLayer1.TabIndex = 0;
            this.picLayer1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picLayer2);
            this.groupBox1.Location = new System.Drawing.Point(151, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 201);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Layer 2";
            // 
            // picLayer2
            // 
            this.picLayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLayer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLayer2.Image = null;
            this.picLayer2.Location = new System.Drawing.Point(6, 19);
            this.picLayer2.Name = "picLayer2";
            this.picLayer2.Palette = palette6;
            this.picLayer2.Size = new System.Drawing.Size(132, 172);
            this.picLayer2.TabIndex = 0;
            this.picLayer2.TabStop = false;
            // 
            // txtTileName
            // 
            this.txtTileName.Location = new System.Drawing.Point(47, 0);
            this.txtTileName.Name = "txtTileName";
            this.txtTileName.Size = new System.Drawing.Size(241, 20);
            this.txtTileName.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Name:";
            // 
            // BattleBackgroundPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "BattleBackgroundPanel";
            this.Size = new System.Drawing.Size(296, 252);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLayer1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private PartialPalettedPicturebox picLayer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private PartialPalettedPicturebox picLayer2;
        private System.Windows.Forms.TextBox txtTileName;
        private System.Windows.Forms.Label label4;
    }
}
