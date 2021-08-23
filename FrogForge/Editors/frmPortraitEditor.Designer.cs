namespace FrogForge.Editors
{
    partial class frmPortraitEditor
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
            FrogForge.Palette palette1 = new FrogForge.Palette();
            FrogForge.Palette palette2 = new FrogForge.Palette();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPortraitEditor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.picCharactersBG = new FrogForge.UserControls.PalettedPicturebox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.picCharactersPreview = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.picCharactersFG = new FrogForge.UserControls.PalettedPicturebox();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.fgpCharactersFGPalette = new FrogForge.UserControls.ForegroundPaletteSelector();
            this.pltCharactersBGPalette = new FrogForge.UserControls.PalettePanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCharactersName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVoicePlay = new System.Windows.Forms.Button();
            this.nudPitch = new System.Windows.Forms.NumericUpDown();
            this.cmbVoiceType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.trkPitch = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpPortraits = new System.Windows.Forms.TabPage();
            this.lstCharacters = new FrogForge.UserControls.PortraitJSONBrowser();
            this.tbpGenerics = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.pleGenericsPossibleBGPalettes = new FrogForge.UserControls.PalettesListEditor();
            this.lstGenerics = new FrogForge.UserControls.GenericPortraitJSONBrowser();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.picGenericsBG = new FrogForge.UserControls.PalettedPicturebox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.picGenericsPreview = new System.Windows.Forms.PictureBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.picGenericsFG = new FrogForge.UserControls.PalettedPicturebox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblVoiceType = new System.Windows.Forms.Label();
            this.txtGenericsTags = new System.Windows.Forms.TextBox();
            this.txtGenericsID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trkGenericsVoiceType = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCharactersBG)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCharactersPreview)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCharactersFG)).BeginInit();
            this.grpData.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPitch)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tbpPortraits.SuspendLayout();
            this.tbpGenerics.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGenericsBG)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGenericsPreview)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGenericsFG)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkGenericsVoiceType)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(126, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 102);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Images";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.picCharactersBG);
            this.groupBox5.Location = new System.Drawing.Point(76, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(64, 77);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "BG";
            // 
            // picCharactersBG
            // 
            this.picCharactersBG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCharactersBG.Image = null;
            this.picCharactersBG.Location = new System.Drawing.Point(6, 19);
            this.picCharactersBG.Name = "picCharactersBG";
            this.picCharactersBG.Palette = palette1;
            this.picCharactersBG.Size = new System.Drawing.Size(52, 52);
            this.picCharactersBG.TabIndex = 0;
            this.picCharactersBG.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.picCharactersPreview);
            this.groupBox6.Location = new System.Drawing.Point(146, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(64, 77);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Preview";
            // 
            // picCharactersPreview
            // 
            this.picCharactersPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCharactersPreview.Location = new System.Drawing.Point(6, 19);
            this.picCharactersPreview.Name = "picCharactersPreview";
            this.picCharactersPreview.Size = new System.Drawing.Size(52, 52);
            this.picCharactersPreview.TabIndex = 0;
            this.picCharactersPreview.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.picCharactersFG);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(64, 77);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FG";
            // 
            // picCharactersFG
            // 
            this.picCharactersFG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCharactersFG.Image = null;
            this.picCharactersFG.Location = new System.Drawing.Point(6, 19);
            this.picCharactersFG.Name = "picCharactersFG";
            this.picCharactersFG.Palette = palette1;
            this.picCharactersFG.Size = new System.Drawing.Size(52, 52);
            this.picCharactersFG.TabIndex = 0;
            this.picCharactersFG.TabStop = false;
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.fgpCharactersFGPalette);
            this.grpData.Controls.Add(this.pltCharactersBGPalette);
            this.grpData.Controls.Add(this.label3);
            this.grpData.Controls.Add(this.txtCharactersName);
            this.grpData.Controls.Add(this.label2);
            this.grpData.Controls.Add(this.label1);
            this.grpData.Location = new System.Drawing.Point(126, 0);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(216, 97);
            this.grpData.TabIndex = 15;
            this.grpData.TabStop = false;
            this.grpData.Text = "Data";
            // 
            // fgpCharactersFGPalette
            // 
            this.fgpCharactersFGPalette.BackColor = System.Drawing.Color.White;
            this.fgpCharactersFGPalette.Data = 0;
            this.fgpCharactersFGPalette.Location = new System.Drawing.Point(73, 45);
            this.fgpCharactersFGPalette.Name = "fgpCharactersFGPalette";
            this.fgpCharactersFGPalette.Size = new System.Drawing.Size(137, 20);
            this.fgpCharactersFGPalette.TabIndex = 2;
            // 
            // pltCharactersBGPalette
            // 
            this.pltCharactersBGPalette.Location = new System.Drawing.Point(73, 71);
            this.pltCharactersBGPalette.Name = "pltCharactersBGPalette";
            this.pltCharactersBGPalette.Size = new System.Drawing.Size(137, 20);
            this.pltCharactersBGPalette.SpritePalette = false;
            this.pltCharactersBGPalette.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "BG Palette:";
            // 
            // txtCharactersName
            // 
            this.txtCharactersName.Location = new System.Drawing.Point(73, 19);
            this.txtCharactersName.Name = "txtCharactersName";
            this.txtCharactersName.Size = new System.Drawing.Size(137, 20);
            this.txtCharactersName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "FG Palette:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.btnVoicePlay);
            this.groupBox3.Controls.Add(this.nudPitch);
            this.groupBox3.Controls.Add(this.cmbVoiceType);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.trkPitch);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(126, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 79);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Voice";
            // 
            // btnVoicePlay
            // 
            this.btnVoicePlay.Location = new System.Drawing.Point(167, 19);
            this.btnVoicePlay.Name = "btnVoicePlay";
            this.btnVoicePlay.Size = new System.Drawing.Size(43, 21);
            this.btnVoicePlay.TabIndex = 4;
            this.btnVoicePlay.Text = "Play";
            this.btnVoicePlay.UseVisualStyleBackColor = true;
            this.btnVoicePlay.Click += new System.EventHandler(this.btnVoicePlay_Click);
            // 
            // nudPitch
            // 
            this.nudPitch.DecimalPlaces = 2;
            this.nudPitch.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPitch.Location = new System.Drawing.Point(167, 46);
            this.nudPitch.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPitch.Name = "nudPitch";
            this.nudPitch.Size = new System.Drawing.Size(43, 20);
            this.nudPitch.TabIndex = 3;
            this.nudPitch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPitch.ValueChanged += new System.EventHandler(this.nudPitch_ValueChanged);
            // 
            // cmbVoiceType
            // 
            this.cmbVoiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoiceType.FormattingEnabled = true;
            this.cmbVoiceType.Items.AddRange(new object[] {
            "Square50",
            "Square25",
            "Square12",
            "Triangle"});
            this.cmbVoiceType.Location = new System.Drawing.Point(73, 19);
            this.cmbVoiceType.Name = "cmbVoiceType";
            this.cmbVoiceType.Size = new System.Drawing.Size(88, 21);
            this.cmbVoiceType.TabIndex = 0;
            this.cmbVoiceType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbVoiceType_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Type:";
            // 
            // trkPitch
            // 
            this.trkPitch.AutoSize = false;
            this.trkPitch.BackColor = System.Drawing.Color.White;
            this.trkPitch.LargeChange = 20;
            this.trkPitch.Location = new System.Drawing.Point(73, 46);
            this.trkPitch.Maximum = 200;
            this.trkPitch.Name = "trkPitch";
            this.trkPitch.Size = new System.Drawing.Size(88, 20);
            this.trkPitch.SmallChange = 5;
            this.trkPitch.TabIndex = 2;
            this.trkPitch.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkPitch.Value = 100;
            this.trkPitch.Scroll += new System.EventHandler(this.trkPitch_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pitch:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnNew,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(377, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::FrogForge.Properties.Resources.Save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = global::FrogForge.Properties.Resources.New;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 22);
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = global::FrogForge.Properties.Resources.Delete;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbcMain
            // 
            this.tbcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcMain.Controls.Add(this.tbpPortraits);
            this.tbcMain.Controls.Add(this.tbpGenerics);
            this.tbcMain.Location = new System.Drawing.Point(12, 28);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(352, 317);
            this.tbcMain.TabIndex = 10;
            this.tbcMain.SelectedIndexChanged += new System.EventHandler(this.tbcMain_SelectedIndexChanged);
            // 
            // tbpPortraits
            // 
            this.tbpPortraits.Controls.Add(this.lstCharacters);
            this.tbpPortraits.Controls.Add(this.groupBox1);
            this.tbpPortraits.Controls.Add(this.groupBox3);
            this.tbpPortraits.Controls.Add(this.grpData);
            this.tbpPortraits.Location = new System.Drawing.Point(4, 22);
            this.tbpPortraits.Name = "tbpPortraits";
            this.tbpPortraits.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPortraits.Size = new System.Drawing.Size(344, 291);
            this.tbpPortraits.TabIndex = 0;
            this.tbpPortraits.Text = "Character Portraits";
            this.tbpPortraits.UseVisualStyleBackColor = true;
            // 
            // lstCharacters
            // 
            this.lstCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCharacters.FormattingEnabled = true;
            this.lstCharacters.Location = new System.Drawing.Point(0, 0);
            this.lstCharacters.Name = "lstCharacters";
            this.lstCharacters.Size = new System.Drawing.Size(120, 290);
            this.lstCharacters.TabIndex = 3;
            // 
            // tbpGenerics
            // 
            this.tbpGenerics.Controls.Add(this.groupBox11);
            this.tbpGenerics.Controls.Add(this.lstGenerics);
            this.tbpGenerics.Controls.Add(this.groupBox2);
            this.tbpGenerics.Controls.Add(this.groupBox10);
            this.tbpGenerics.Location = new System.Drawing.Point(4, 22);
            this.tbpGenerics.Name = "tbpGenerics";
            this.tbpGenerics.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGenerics.Size = new System.Drawing.Size(344, 291);
            this.tbpGenerics.TabIndex = 1;
            this.tbpGenerics.Text = "Generic Portraits";
            this.tbpGenerics.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.groupBox13);
            this.groupBox11.Controls.Add(this.groupBox12);
            this.groupBox11.Location = new System.Drawing.Point(348, 0);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(162, 290);
            this.groupBox11.TabIndex = 19;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Global Data";
            // 
            // groupBox13
            // 
            this.groupBox13.Location = new System.Drawing.Point(6, 149);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(150, 135);
            this.groupBox13.TabIndex = 2;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Voices TBA";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.pleGenericsPossibleBGPalettes);
            this.groupBox12.Location = new System.Drawing.Point(6, 19);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(150, 124);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "BG Palettes";
            // 
            // pleGenericsPossibleBGPalettes
            // 
            this.pleGenericsPossibleBGPalettes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pleGenericsPossibleBGPalettes.Location = new System.Drawing.Point(6, 19);
            this.pleGenericsPossibleBGPalettes.Name = "pleGenericsPossibleBGPalettes";
            this.pleGenericsPossibleBGPalettes.Size = new System.Drawing.Size(138, 99);
            this.pleGenericsPossibleBGPalettes.TabIndex = 0;
            // 
            // lstGenerics
            // 
            this.lstGenerics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstGenerics.FormattingEnabled = true;
            this.lstGenerics.Location = new System.Drawing.Point(0, 0);
            this.lstGenerics.Name = "lstGenerics";
            this.lstGenerics.Size = new System.Drawing.Size(120, 290);
            this.lstGenerics.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Location = new System.Drawing.Point(126, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 102);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Images";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.picGenericsBG);
            this.groupBox7.Location = new System.Drawing.Point(76, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(64, 77);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "BG";
            // 
            // picGenericsBG
            // 
            this.picGenericsBG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGenericsBG.Image = null;
            this.picGenericsBG.Location = new System.Drawing.Point(6, 19);
            this.picGenericsBG.Name = "picGenericsBG";
            this.picGenericsBG.Palette = palette2;
            this.picGenericsBG.Size = new System.Drawing.Size(52, 52);
            this.picGenericsBG.TabIndex = 0;
            this.picGenericsBG.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.picGenericsPreview);
            this.groupBox8.Location = new System.Drawing.Point(146, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(64, 77);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Preview";
            // 
            // picGenericsPreview
            // 
            this.picGenericsPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGenericsPreview.Location = new System.Drawing.Point(6, 19);
            this.picGenericsPreview.Name = "picGenericsPreview";
            this.picGenericsPreview.Size = new System.Drawing.Size(52, 52);
            this.picGenericsPreview.TabIndex = 0;
            this.picGenericsPreview.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.picGenericsFG);
            this.groupBox9.Location = new System.Drawing.Point(6, 19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(64, 77);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "FG";
            // 
            // picGenericsFG
            // 
            this.picGenericsFG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGenericsFG.Image = null;
            this.picGenericsFG.Location = new System.Drawing.Point(6, 19);
            this.picGenericsFG.Name = "picGenericsFG";
            this.picGenericsFG.Palette = palette2;
            this.picGenericsFG.Size = new System.Drawing.Size(52, 52);
            this.picGenericsFG.TabIndex = 0;
            this.picGenericsFG.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox10.Controls.Add(this.lblVoiceType);
            this.groupBox10.Controls.Add(this.txtGenericsTags);
            this.groupBox10.Controls.Add(this.txtGenericsID);
            this.groupBox10.Controls.Add(this.label4);
            this.groupBox10.Controls.Add(this.label5);
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Controls.Add(this.trkGenericsVoiceType);
            this.groupBox10.Location = new System.Drawing.Point(126, 0);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(216, 182);
            this.groupBox10.TabIndex = 18;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Data";
            // 
            // lblVoiceType
            // 
            this.lblVoiceType.Location = new System.Drawing.Point(180, 71);
            this.lblVoiceType.Name = "lblVoiceType";
            this.lblVoiceType.Size = new System.Drawing.Size(30, 20);
            this.lblVoiceType.TabIndex = 3;
            this.lblVoiceType.Text = "0";
            this.lblVoiceType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGenericsTags
            // 
            this.txtGenericsTags.Location = new System.Drawing.Point(73, 45);
            this.txtGenericsTags.Name = "txtGenericsTags";
            this.txtGenericsTags.Size = new System.Drawing.Size(137, 20);
            this.txtGenericsTags.TabIndex = 2;
            // 
            // txtGenericsID
            // 
            this.txtGenericsID.Location = new System.Drawing.Point(73, 19);
            this.txtGenericsID.Name = "txtGenericsID";
            this.txtGenericsID.Size = new System.Drawing.Size(137, 20);
            this.txtGenericsID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tags:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Voice type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            // 
            // trkGenericsVoiceType
            // 
            this.trkGenericsVoiceType.AutoSize = false;
            this.trkGenericsVoiceType.BackColor = System.Drawing.Color.White;
            this.trkGenericsVoiceType.LargeChange = 1;
            this.trkGenericsVoiceType.Location = new System.Drawing.Point(73, 71);
            this.trkGenericsVoiceType.Maximum = 1;
            this.trkGenericsVoiceType.Name = "trkGenericsVoiceType";
            this.trkGenericsVoiceType.Size = new System.Drawing.Size(111, 20);
            this.trkGenericsVoiceType.TabIndex = 3;
            this.trkGenericsVoiceType.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkGenericsVoiceType.ValueChanged += new System.EventHandler(this.trkGenericsVoiceType_ValueChanged);
            // 
            // frmPortraitEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 357);
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPortraitEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portrait Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPortraitEditor_FormClosed);
            this.Load += new System.EventHandler(this.frmPortraitEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCharactersBG)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCharactersPreview)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCharactersFG)).EndInit();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkPitch)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbcMain.ResumeLayout(false);
            this.tbpPortraits.ResumeLayout(false);
            this.tbpGenerics.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGenericsBG)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGenericsPreview)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGenericsFG)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkGenericsVoiceType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FrogForge.UserControls.PortraitJSONBrowser lstCharacters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.GroupBox groupBox3;
        private FrogForge.UserControls.PalettedPicturebox picCharactersFG;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private FrogForge.UserControls.PalettedPicturebox picCharactersBG;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtCharactersName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.PictureBox picCharactersPreview;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpPortraits;
        private System.Windows.Forms.TabPage tbpGenerics;
        private FrogForge.UserControls.GenericPortraitJSONBrowser lstGenerics;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private FrogForge.UserControls.PalettedPicturebox picGenericsBG;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.PictureBox picGenericsPreview;
        private System.Windows.Forms.GroupBox groupBox9;
        private FrogForge.UserControls.PalettedPicturebox picGenericsFG;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtGenericsID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trkGenericsVoiceType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVoiceType;
        private System.Windows.Forms.TextBox txtGenericsTags;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox11;
        private UserControls.PalettePanel pltCharactersBGPalette;
        private UserControls.PalettesListEditor pleGenericsPossibleBGPalettes;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ComboBox cmbVoiceType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trkPitch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudPitch;
        private System.Windows.Forms.Button btnVoicePlay;
        private UserControls.ForegroundPaletteSelector fgpCharactersFGPalette;
    }
}