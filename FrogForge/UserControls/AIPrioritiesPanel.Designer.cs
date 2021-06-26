namespace FrogForge.UserControls
{
    partial class AIPrioritiesPanel
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
            this.nudTrueDamage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudRelativeDamage = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSurvival = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHelp1 = new System.Windows.Forms.Button();
            this.btnHelp2 = new System.Windows.Forms.Button();
            this.btnHelp3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbNoDamage = new System.Windows.Forms.CheckBox();
            this.ckbSuicide = new System.Windows.Forms.CheckBox();
            this.ckbLittleDamage = new System.Windows.Forms.CheckBox();
            this.btnHelp4 = new System.Windows.Forms.Button();
            this.btnHelp5 = new System.Windows.Forms.Button();
            this.btnHelp6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrueDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRelativeDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSurvival)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudTrueDamage
            // 
            this.nudTrueDamage.DecimalPlaces = 1;
            this.nudTrueDamage.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudTrueDamage.Location = new System.Drawing.Point(127, 0);
            this.nudTrueDamage.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudTrueDamage.Name = "nudTrueDamage";
            this.nudTrueDamage.Size = new System.Drawing.Size(37, 20);
            this.nudTrueDamage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "True damage weight:";
            // 
            // nudRelativeDamage
            // 
            this.nudRelativeDamage.DecimalPlaces = 1;
            this.nudRelativeDamage.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudRelativeDamage.Location = new System.Drawing.Point(127, 26);
            this.nudRelativeDamage.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudRelativeDamage.Name = "nudRelativeDamage";
            this.nudRelativeDamage.Size = new System.Drawing.Size(37, 20);
            this.nudRelativeDamage.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Relative damage weight:";
            // 
            // nudSurvival
            // 
            this.nudSurvival.DecimalPlaces = 1;
            this.nudSurvival.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudSurvival.Location = new System.Drawing.Point(127, 52);
            this.nudSurvival.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSurvival.Name = "nudSurvival";
            this.nudSurvival.Size = new System.Drawing.Size(37, 20);
            this.nudSurvival.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Survival weight:";
            // 
            // btnHelp1
            // 
            this.btnHelp1.Location = new System.Drawing.Point(170, 0);
            this.btnHelp1.Name = "btnHelp1";
            this.btnHelp1.Size = new System.Drawing.Size(20, 20);
            this.btnHelp1.TabIndex = 2;
            this.btnHelp1.Tag = "Prioritizes enemies that this unit deals the highest True Damage (damage * hit ch" +
    "ance) to.";
            this.btnHelp1.Text = "?";
            this.btnHelp1.UseVisualStyleBackColor = true;
            this.btnHelp1.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnHelp2
            // 
            this.btnHelp2.Location = new System.Drawing.Point(170, 26);
            this.btnHelp2.Name = "btnHelp2";
            this.btnHelp2.Size = new System.Drawing.Size(20, 20);
            this.btnHelp2.TabIndex = 2;
            this.btnHelp2.Tag = "Prioritizes enemies that will have the lowest remaining HP after attacking (calcu" +
    "lates with True Damage).";
            this.btnHelp2.Text = "?";
            this.btnHelp2.UseVisualStyleBackColor = true;
            this.btnHelp2.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnHelp3
            // 
            this.btnHelp3.Location = new System.Drawing.Point(170, 52);
            this.btnHelp3.Name = "btnHelp3";
            this.btnHelp3.Size = new System.Drawing.Size(20, 20);
            this.btnHelp3.TabIndex = 2;
            this.btnHelp3.Tag = "Prioritizes enemies that leave this unit with high HP (calculates with True Damag" +
    "e).";
            this.btnHelp3.Text = "?";
            this.btnHelp3.UseVisualStyleBackColor = true;
            this.btnHelp3.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbLittleDamage);
            this.groupBox1.Controls.Add(this.btnHelp6);
            this.groupBox1.Controls.Add(this.ckbSuicide);
            this.groupBox1.Controls.Add(this.btnHelp5);
            this.groupBox1.Controls.Add(this.ckbNoDamage);
            this.groupBox1.Controls.Add(this.btnHelp4);
            this.groupBox1.Location = new System.Drawing.Point(0, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avoid AI";
            // 
            // ckbNoDamage
            // 
            this.ckbNoDamage.AutoSize = true;
            this.ckbNoDamage.Location = new System.Drawing.Point(6, 19);
            this.ckbNoDamage.Name = "ckbNoDamage";
            this.ckbNoDamage.Size = new System.Drawing.Size(81, 17);
            this.ckbNoDamage.TabIndex = 0;
            this.ckbNoDamage.Text = "No damage";
            this.ckbNoDamage.UseVisualStyleBackColor = true;
            // 
            // ckbSuicide
            // 
            this.ckbSuicide.AutoSize = true;
            this.ckbSuicide.Location = new System.Drawing.Point(6, 42);
            this.ckbSuicide.Name = "ckbSuicide";
            this.ckbSuicide.Size = new System.Drawing.Size(61, 17);
            this.ckbSuicide.TabIndex = 0;
            this.ckbSuicide.Text = "Suicide";
            this.ckbSuicide.UseVisualStyleBackColor = true;
            // 
            // ckbLittleDamage
            // 
            this.ckbLittleDamage.AutoSize = true;
            this.ckbLittleDamage.Location = new System.Drawing.Point(6, 65);
            this.ckbLittleDamage.Name = "ckbLittleDamage";
            this.ckbLittleDamage.Size = new System.Drawing.Size(89, 17);
            this.ckbLittleDamage.TabIndex = 0;
            this.ckbLittleDamage.Text = "Little damage";
            this.ckbLittleDamage.UseVisualStyleBackColor = true;
            // 
            // btnHelp4
            // 
            this.btnHelp4.Location = new System.Drawing.Point(164, 16);
            this.btnHelp4.Name = "btnHelp4";
            this.btnHelp4.Size = new System.Drawing.Size(20, 20);
            this.btnHelp4.TabIndex = 2;
            this.btnHelp4.Tag = "Avoids enemies that this unit deals 0 damage to/has 0% hit chance against.";
            this.btnHelp4.Text = "?";
            this.btnHelp4.UseVisualStyleBackColor = true;
            this.btnHelp4.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnHelp5
            // 
            this.btnHelp5.Location = new System.Drawing.Point(164, 39);
            this.btnHelp5.Name = "btnHelp5";
            this.btnHelp5.Size = new System.Drawing.Size(20, 20);
            this.btnHelp5.TabIndex = 2;
            this.btnHelp5.Tag = "Avoids units that can kill this unit (calculated with True Damage).";
            this.btnHelp5.Text = "?";
            this.btnHelp5.UseVisualStyleBackColor = true;
            this.btnHelp5.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnHelp6
            // 
            this.btnHelp6.Location = new System.Drawing.Point(164, 62);
            this.btnHelp6.Name = "btnHelp6";
            this.btnHelp6.Size = new System.Drawing.Size(20, 20);
            this.btnHelp6.TabIndex = 2;
            this.btnHelp6.Tag = "Avoids enemies that this unit deals 0 True Damage to.";
            this.btnHelp6.Text = "?";
            this.btnHelp6.UseVisualStyleBackColor = true;
            this.btnHelp6.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // AIPrioritiesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHelp3);
            this.Controls.Add(this.btnHelp2);
            this.Controls.Add(this.btnHelp1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSurvival);
            this.Controls.Add(this.nudRelativeDamage);
            this.Controls.Add(this.nudTrueDamage);
            this.Name = "AIPrioritiesPanel";
            this.Size = new System.Drawing.Size(190, 166);
            ((System.ComponentModel.ISupportInitialize)(this.nudTrueDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRelativeDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSurvival)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudTrueDamage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudRelativeDamage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSurvival;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHelp1;
        private System.Windows.Forms.Button btnHelp2;
        private System.Windows.Forms.Button btnHelp3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbNoDamage;
        private System.Windows.Forms.CheckBox ckbSuicide;
        private System.Windows.Forms.CheckBox ckbLittleDamage;
        private System.Windows.Forms.Button btnHelp6;
        private System.Windows.Forms.Button btnHelp5;
        private System.Windows.Forms.Button btnHelp4;
    }
}
