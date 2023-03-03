namespace FrogForge.Editors
{
    partial class frmDebugOptionsEditor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDebugOptionsEditor));
            this.ckbEnabled = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlAll = new System.Windows.Forms.Panel();
            this.grpInGame = new System.Windows.Forms.GroupBox();
            this.txtForceMap = new System.Windows.Forms.TextBox();
            this.txtForceConversation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpStartingUnits = new System.Windows.Forms.GroupBox();
            this.ckbOP = new System.Windows.Forms.CheckBox();
            this.ckbUnlimitedMove = new System.Windows.Forms.CheckBox();
            this.lstStartingUnits = new FrogForge.UserControls.StringListEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.nudFirstLevel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.ckbSkipIntro = new System.Windows.Forms.CheckBox();
            this.ckbKillAutoSaves = new System.Windows.Forms.CheckBox();
            this.pnlAll.SuspendLayout();
            this.grpInGame.SuspendLayout();
            this.grpStartingUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstLevel)).BeginInit();
            this.grpGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbEnabled
            // 
            this.ckbEnabled.AutoSize = true;
            this.ckbEnabled.Location = new System.Drawing.Point(12, 12);
            this.ckbEnabled.Name = "ckbEnabled";
            this.ckbEnabled.Size = new System.Drawing.Size(65, 17);
            this.ckbEnabled.TabIndex = 0;
            this.ckbEnabled.Text = "Enabled";
            this.ckbEnabled.UseVisualStyleBackColor = true;
            this.ckbEnabled.CheckedChanged += new System.EventHandler(this.ckbEnabled_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(159, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(240, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlAll
            // 
            this.pnlAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAll.Controls.Add(this.grpInGame);
            this.pnlAll.Controls.Add(this.grpGeneral);
            this.pnlAll.Location = new System.Drawing.Point(12, 36);
            this.pnlAll.Name = "pnlAll";
            this.pnlAll.Size = new System.Drawing.Size(303, 363);
            this.pnlAll.TabIndex = 12;
            // 
            // grpInGame
            // 
            this.grpInGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInGame.Controls.Add(this.ckbKillAutoSaves);
            this.grpInGame.Controls.Add(this.txtForceMap);
            this.grpInGame.Controls.Add(this.txtForceConversation);
            this.grpInGame.Controls.Add(this.label3);
            this.grpInGame.Controls.Add(this.grpStartingUnits);
            this.grpInGame.Controls.Add(this.label2);
            this.grpInGame.Controls.Add(this.nudFirstLevel);
            this.grpInGame.Controls.Add(this.label1);
            this.grpInGame.Location = new System.Drawing.Point(0, 48);
            this.grpInGame.Name = "grpInGame";
            this.grpInGame.Size = new System.Drawing.Size(303, 315);
            this.grpInGame.TabIndex = 0;
            this.grpInGame.TabStop = false;
            this.grpInGame.Text = "In-game";
            // 
            // txtForceMap
            // 
            this.txtForceMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForceMap.Location = new System.Drawing.Point(110, 97);
            this.txtForceMap.Name = "txtForceMap";
            this.txtForceMap.Size = new System.Drawing.Size(187, 20);
            this.txtForceMap.TabIndex = 3;
            // 
            // txtForceConversation
            // 
            this.txtForceConversation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForceConversation.Location = new System.Drawing.Point(110, 71);
            this.txtForceConversation.Name = "txtForceConversation";
            this.txtForceConversation.Size = new System.Drawing.Size(187, 20);
            this.txtForceConversation.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Force map:";
            // 
            // grpStartingUnits
            // 
            this.grpStartingUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStartingUnits.Controls.Add(this.ckbOP);
            this.grpStartingUnits.Controls.Add(this.ckbUnlimitedMove);
            this.grpStartingUnits.Controls.Add(this.lstStartingUnits);
            this.grpStartingUnits.Location = new System.Drawing.Point(6, 123);
            this.grpStartingUnits.Name = "grpStartingUnits";
            this.grpStartingUnits.Size = new System.Drawing.Size(291, 186);
            this.grpStartingUnits.TabIndex = 2;
            this.grpStartingUnits.TabStop = false;
            this.grpStartingUnits.Text = "Starting units";
            // 
            // ckbOP
            // 
            this.ckbOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbOP.AutoSize = true;
            this.ckbOP.Location = new System.Drawing.Point(6, 163);
            this.ckbOP.Name = "ckbOP";
            this.ckbOP.Size = new System.Drawing.Size(147, 17);
            this.ckbOP.TabIndex = 1;
            this.ckbOP.Text = "Overpowered (+50 levels)";
            this.ckbOP.UseVisualStyleBackColor = true;
            // 
            // ckbUnlimitedMove
            // 
            this.ckbUnlimitedMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbUnlimitedMove.AutoSize = true;
            this.ckbUnlimitedMove.Location = new System.Drawing.Point(6, 140);
            this.ckbUnlimitedMove.Name = "ckbUnlimitedMove";
            this.ckbUnlimitedMove.Size = new System.Drawing.Size(121, 17);
            this.ckbUnlimitedMove.TabIndex = 1;
            this.ckbUnlimitedMove.Text = "Unlimited movement";
            this.ckbUnlimitedMove.UseVisualStyleBackColor = true;
            // 
            // lstStartingUnits
            // 
            this.lstStartingUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstStartingUnits.Location = new System.Drawing.Point(6, 19);
            this.lstStartingUnits.Name = "lstStartingUnits";
            this.lstStartingUnits.Size = new System.Drawing.Size(279, 115);
            this.lstStartingUnits.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Force conversation:";
            // 
            // nudFirstLevel
            // 
            this.nudFirstLevel.Location = new System.Drawing.Point(110, 45);
            this.nudFirstLevel.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudFirstLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFirstLevel.Name = "nudFirstLevel";
            this.nudFirstLevel.Size = new System.Drawing.Size(40, 20);
            this.nudFirstLevel.TabIndex = 1;
            this.nudFirstLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First level:";
            // 
            // grpGeneral
            // 
            this.grpGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGeneral.Controls.Add(this.ckbSkipIntro);
            this.grpGeneral.Location = new System.Drawing.Point(0, 0);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(303, 42);
            this.grpGeneral.TabIndex = 0;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // ckbSkipIntro
            // 
            this.ckbSkipIntro.AutoSize = true;
            this.ckbSkipIntro.Location = new System.Drawing.Point(6, 19);
            this.ckbSkipIntro.Name = "ckbSkipIntro";
            this.ckbSkipIntro.Size = new System.Drawing.Size(70, 17);
            this.ckbSkipIntro.TabIndex = 0;
            this.ckbSkipIntro.Text = "Skip intro";
            this.ckbSkipIntro.UseVisualStyleBackColor = true;
            // 
            // ckbKillAutoSaves
            // 
            this.ckbKillAutoSaves.AutoSize = true;
            this.ckbKillAutoSaves.Location = new System.Drawing.Point(6, 20);
            this.ckbKillAutoSaves.Name = "ckbKillAutoSaves";
            this.ckbKillAutoSaves.Size = new System.Drawing.Size(94, 17);
            this.ckbKillAutoSaves.TabIndex = 0;
            this.ckbKillAutoSaves.Text = "Kill auto-saves";
            this.ckbKillAutoSaves.UseVisualStyleBackColor = true;
            // 
            // frmDebugOptionsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 440);
            this.Controls.Add(this.pnlAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ckbEnabled);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDebugOptionsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Debug Options";
            this.Load += new System.EventHandler(this.frmDebugOptionsEditor_Load);
            this.pnlAll.ResumeLayout(false);
            this.grpInGame.ResumeLayout(false);
            this.grpInGame.PerformLayout();
            this.grpStartingUnits.ResumeLayout(false);
            this.grpStartingUnits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstLevel)).EndInit();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbEnabled;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlAll;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.CheckBox ckbSkipIntro;
        private System.Windows.Forms.GroupBox grpInGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudFirstLevel;
        private System.Windows.Forms.GroupBox grpStartingUnits;
        private UserControls.StringListEditor lstStartingUnits;
        private System.Windows.Forms.CheckBox ckbUnlimitedMove;
        private System.Windows.Forms.CheckBox ckbOP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtForceConversation;
        private System.Windows.Forms.TextBox txtForceMap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbKillAutoSaves;
    }
}