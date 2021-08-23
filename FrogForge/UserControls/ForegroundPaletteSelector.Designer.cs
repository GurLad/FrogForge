namespace FrogForge.UserControls
{
    partial class ForegroundPaletteSelector
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
            this.trkFGPalette = new System.Windows.Forms.TrackBar();
            this.picFGPalette = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trkFGPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFGPalette)).BeginInit();
            this.SuspendLayout();
            // 
            // trkFGPalette
            // 
            this.trkFGPalette.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkFGPalette.AutoSize = false;
            this.trkFGPalette.BackColor = System.Drawing.SystemColors.Control;
            this.trkFGPalette.LargeChange = 1;
            this.trkFGPalette.Location = new System.Drawing.Point(0, 0);
            this.trkFGPalette.Maximum = 3;
            this.trkFGPalette.Name = "trkFGPalette";
            this.trkFGPalette.Size = new System.Drawing.Size(111, 20);
            this.trkFGPalette.TabIndex = 4;
            this.trkFGPalette.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkFGPalette.Scroll += new System.EventHandler(this.trkFGPalette_Scroll);
            // 
            // picFGPalette
            // 
            this.picFGPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picFGPalette.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFGPalette.Location = new System.Drawing.Point(117, 0);
            this.picFGPalette.Name = "picFGPalette";
            this.picFGPalette.Size = new System.Drawing.Size(20, 20);
            this.picFGPalette.TabIndex = 5;
            this.picFGPalette.TabStop = false;
            // 
            // ForegroundPaletteSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picFGPalette);
            this.Controls.Add(this.trkFGPalette);
            this.Name = "ForegroundPaletteSelector";
            this.Size = new System.Drawing.Size(137, 20);
            ((System.ComponentModel.ISupportInitialize)(this.trkFGPalette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFGPalette)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFGPalette;
        private System.Windows.Forms.TrackBar trkFGPalette;
    }
}
