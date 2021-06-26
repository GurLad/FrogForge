namespace FrogForge.UserControls
{
    partial class TeamPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.pltPalette = new FrogForge.UserControls.PalettePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPortraitMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.appAI = new FrogForge.UserControls.AIPrioritiesPanel();
            this.rdbComputerControlled = new System.Windows.Forms.RadioButton();
            this.rdbPlayerController = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(75, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // pltPalette
            // 
            this.pltPalette.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pltPalette.Location = new System.Drawing.Point(75, 26);
            this.pltPalette.Name = "pltPalette";
            this.pltPalette.Size = new System.Drawing.Size(127, 20);
            this.pltPalette.SpritePalette = true;
            this.pltPalette.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Palette:";
            // 
            // cmbPortraitMode
            // 
            this.cmbPortraitMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPortraitMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortraitMode.FormattingEnabled = true;
            this.cmbPortraitMode.Items.AddRange(new object[] {
            "Name",
            "Team",
            "Generic"});
            this.cmbPortraitMode.Location = new System.Drawing.Point(75, 52);
            this.cmbPortraitMode.Name = "cmbPortraitMode";
            this.cmbPortraitMode.Size = new System.Drawing.Size(127, 21);
            this.cmbPortraitMode.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Portrait mode:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.appAI);
            this.groupBox1.Controls.Add(this.rdbComputerControlled);
            this.groupBox1.Controls.Add(this.rdbPlayerController);
            this.groupBox1.Location = new System.Drawing.Point(0, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 237);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AI";
            // 
            // appAI
            // 
            this.appAI.Enabled = false;
            this.appAI.Location = new System.Drawing.Point(6, 65);
            this.appAI.Name = "appAI";
            this.appAI.Size = new System.Drawing.Size(190, 166);
            this.appAI.TabIndex = 1;
            // 
            // rdbComputerControlled
            // 
            this.rdbComputerControlled.AutoSize = true;
            this.rdbComputerControlled.Location = new System.Drawing.Point(6, 42);
            this.rdbComputerControlled.Name = "rdbComputerControlled";
            this.rdbComputerControlled.Size = new System.Drawing.Size(119, 17);
            this.rdbComputerControlled.TabIndex = 0;
            this.rdbComputerControlled.Text = "Computer controlled";
            this.rdbComputerControlled.UseVisualStyleBackColor = true;
            // 
            // rdbPlayerController
            // 
            this.rdbPlayerController.AutoSize = true;
            this.rdbPlayerController.Checked = true;
            this.rdbPlayerController.Location = new System.Drawing.Point(6, 19);
            this.rdbPlayerController.Name = "rdbPlayerController";
            this.rdbPlayerController.Size = new System.Drawing.Size(103, 17);
            this.rdbPlayerController.TabIndex = 0;
            this.rdbPlayerController.TabStop = true;
            this.rdbPlayerController.Text = "Player controlled";
            this.rdbPlayerController.UseVisualStyleBackColor = true;
            this.rdbPlayerController.CheckedChanged += new System.EventHandler(this.rdbPlayerControlled_CheckedChanged);
            // 
            // TeamPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPortraitMode);
            this.Controls.Add(this.pltPalette);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "TeamPanel";
            this.Size = new System.Drawing.Size(202, 316);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private PalettePanel pltPalette;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPortraitMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbComputerControlled;
        private System.Windows.Forms.RadioButton rdbPlayerController;
        private AIPrioritiesPanel appAI;
    }
}
