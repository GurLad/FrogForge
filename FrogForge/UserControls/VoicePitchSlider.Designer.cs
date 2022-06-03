
namespace FrogForge.UserControls
{
    partial class VoicePitchSlider
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
            this.nudPitch = new System.Windows.Forms.NumericUpDown();
            this.trkPitch = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.nudPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPitch)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPitch
            // 
            this.nudPitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPitch.DecimalPlaces = 2;
            this.nudPitch.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPitch.Location = new System.Drawing.Point(94, 0);
            this.nudPitch.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPitch.Name = "nudPitch";
            this.nudPitch.Size = new System.Drawing.Size(43, 20);
            this.nudPitch.TabIndex = 5;
            this.nudPitch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPitch.ValueChanged += new System.EventHandler(this.nudPitch_ValueChanged);
            // 
            // trkPitch
            // 
            this.trkPitch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkPitch.AutoSize = false;
            this.trkPitch.BackColor = System.Drawing.Color.White;
            this.trkPitch.LargeChange = 20;
            this.trkPitch.Location = new System.Drawing.Point(0, 0);
            this.trkPitch.Maximum = 200;
            this.trkPitch.Name = "trkPitch";
            this.trkPitch.Size = new System.Drawing.Size(88, 20);
            this.trkPitch.SmallChange = 5;
            this.trkPitch.TabIndex = 4;
            this.trkPitch.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkPitch.Value = 100;
            this.trkPitch.Scroll += new System.EventHandler(this.trkPitch_Scroll);
            // 
            // VoicePitchSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudPitch);
            this.Controls.Add(this.trkPitch);
            this.Name = "VoicePitchSlider";
            this.Size = new System.Drawing.Size(137, 20);
            ((System.ComponentModel.ISupportInitialize)(this.nudPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPitch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudPitch;
        private System.Windows.Forms.TrackBar trkPitch;
    }
}
