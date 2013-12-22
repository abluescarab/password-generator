namespace password_generator {
	partial class frmMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.editCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.helpAbluescarab = new System.Windows.Forms.ToolStripMenuItem();
			this.helpGithub = new System.Windows.Forms.ToolStripMenuItem();
			this.helpSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.helpChangelog = new System.Windows.Forms.ToolStripMenuItem();
			this.helpSep2 = new System.Windows.Forms.ToolStripSeparator();
			this.helpHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.helpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnCopy = new System.Windows.Forms.Button();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.gpbGeneration = new System.Windows.Forms.GroupBox();
			this.chkSpecial = new System.Windows.Forms.CheckBox();
			this.numLength = new System.Windows.Forms.NumericUpDown();
			this.chkRepeat = new System.Windows.Forms.CheckBox();
			this.chkBrackets = new System.Windows.Forms.CheckBox();
			this.chkSpace = new System.Windows.Forms.CheckBox();
			this.chkUnderscore = new System.Windows.Forms.CheckBox();
			this.chkHyphen = new System.Windows.Forms.CheckBox();
			this.chkNumbers = new System.Windows.Forms.CheckBox();
			this.chkLowercase = new System.Windows.Forms.CheckBox();
			this.chkUppercase = new System.Windows.Forms.CheckBox();
			this.lblLength = new System.Windows.Forms.Label();
			this.gpbMassGen = new System.Windows.Forms.GroupBox();
			this.numMassGen = new System.Windows.Forms.NumericUpDown();
			this.lblMassGen = new System.Windows.Forms.Label();
			this.chkMassGen = new System.Windows.Forms.CheckBox();
			this.gpbSave = new System.Windows.Forms.GroupBox();
			this.txtSaveLocation = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.chkSave = new System.Windows.Forms.CheckBox();
			this.tmrClearStatus = new System.Windows.Forms.Timer(this.components);
			this.flgSave = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.gpbGeneration.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
			this.gpbMassGen.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMassGen)).BeginInit();
			this.gpbSave.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuHelp});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(299, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExit});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(37, 20);
			this.menuFile.Text = "File";
			// 
			// fileExit
			// 
			this.fileExit.Image = global::password_generator.Properties.Resources.cross;
			this.fileExit.Name = "fileExit";
			this.fileExit.Size = new System.Drawing.Size(92, 22);
			this.fileExit.Text = "Exit";
			this.fileExit.Click += new System.EventHandler(this.fileExit_Click);
			// 
			// menuEdit
			// 
			this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCopy});
			this.menuEdit.Name = "menuEdit";
			this.menuEdit.Size = new System.Drawing.Size(39, 20);
			this.menuEdit.Text = "Edit";
			// 
			// editCopy
			// 
			this.editCopy.Image = global::password_generator.Properties.Resources.page_paste;
			this.editCopy.Name = "editCopy";
			this.editCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.editCopy.Size = new System.Drawing.Size(144, 22);
			this.editCopy.Text = "Copy";
			this.editCopy.Click += new System.EventHandler(this.editCopy_Click);
			// 
			// menuHelp
			// 
			this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAbluescarab,
            this.helpGithub,
            this.helpSep1,
            this.helpChangelog,
            this.helpSep2,
            this.helpHelp,
            this.helpAbout});
			this.menuHelp.Name = "menuHelp";
			this.menuHelp.Size = new System.Drawing.Size(44, 20);
			this.menuHelp.Text = "Help";
			// 
			// helpAbluescarab
			// 
			this.helpAbluescarab.Image = global::password_generator.Properties.Resources.scarab;
			this.helpAbluescarab.Name = "helpAbluescarab";
			this.helpAbluescarab.Size = new System.Drawing.Size(208, 22);
			this.helpAbluescarab.Text = "Visit Abluescarab Designs";
			this.helpAbluescarab.Click += new System.EventHandler(this.helpAbluescarab_Click);
			// 
			// helpGithub
			// 
			this.helpGithub.Image = global::password_generator.Properties.Resources.github;
			this.helpGithub.Name = "helpGithub";
			this.helpGithub.Size = new System.Drawing.Size(208, 22);
			this.helpGithub.Text = "Visit the GitHub project";
			this.helpGithub.Click += new System.EventHandler(this.helpGithub_Click);
			// 
			// helpSep1
			// 
			this.helpSep1.Name = "helpSep1";
			this.helpSep1.Size = new System.Drawing.Size(205, 6);
			// 
			// helpChangelog
			// 
			this.helpChangelog.Image = global::password_generator.Properties.Resources.page_white_text;
			this.helpChangelog.Name = "helpChangelog";
			this.helpChangelog.Size = new System.Drawing.Size(208, 22);
			this.helpChangelog.Text = "Changelog...";
			this.helpChangelog.Click += new System.EventHandler(this.helpChangelog_Click);
			// 
			// helpSep2
			// 
			this.helpSep2.Name = "helpSep2";
			this.helpSep2.Size = new System.Drawing.Size(205, 6);
			// 
			// helpHelp
			// 
			this.helpHelp.Image = global::password_generator.Properties.Resources.help;
			this.helpHelp.Name = "helpHelp";
			this.helpHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.helpHelp.Size = new System.Drawing.Size(208, 22);
			this.helpHelp.Text = "Help Topics";
			this.helpHelp.Click += new System.EventHandler(this.helpHelp_Click);
			// 
			// helpAbout
			// 
			this.helpAbout.Image = global::password_generator.Properties.Resources.information;
			this.helpAbout.Name = "helpAbout";
			this.helpAbout.Size = new System.Drawing.Size(208, 22);
			this.helpAbout.Text = "About";
			this.helpAbout.Click += new System.EventHandler(this.helpAbout_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText});
			this.statusStrip.Location = new System.Drawing.Point(0, 412);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(299, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip1";
			// 
			// statusText
			// 
			this.statusText.Name = "statusText";
			this.statusText.Size = new System.Drawing.Size(228, 17);
			this.statusText.Text = "Thanks for using this Password Generator.";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(12, 24);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(80, 13);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Your password:";
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPassword.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(12, 40);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.ReadOnly = true;
			this.txtPassword.Size = new System.Drawing.Size(275, 20);
			this.txtPassword.TabIndex = 0;
			// 
			// btnCopy
			// 
			this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopy.Image = global::password_generator.Properties.Resources.page_paste;
			this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCopy.Location = new System.Drawing.Point(182, 66);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(105, 25);
			this.btnCopy.TabIndex = 2;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Image = global::password_generator.Properties.Resources.asterisk_orange;
			this.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGenerate.Location = new System.Drawing.Point(12, 66);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(105, 25);
			this.btnGenerate.TabIndex = 1;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// gpbGeneration
			// 
			this.gpbGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gpbGeneration.Controls.Add(this.chkSpecial);
			this.gpbGeneration.Controls.Add(this.numLength);
			this.gpbGeneration.Controls.Add(this.chkRepeat);
			this.gpbGeneration.Controls.Add(this.chkBrackets);
			this.gpbGeneration.Controls.Add(this.chkSpace);
			this.gpbGeneration.Controls.Add(this.chkUnderscore);
			this.gpbGeneration.Controls.Add(this.chkHyphen);
			this.gpbGeneration.Controls.Add(this.chkNumbers);
			this.gpbGeneration.Controls.Add(this.chkLowercase);
			this.gpbGeneration.Controls.Add(this.chkUppercase);
			this.gpbGeneration.Controls.Add(this.lblLength);
			this.gpbGeneration.Location = new System.Drawing.Point(12, 95);
			this.gpbGeneration.Name = "gpbGeneration";
			this.gpbGeneration.Size = new System.Drawing.Size(275, 163);
			this.gpbGeneration.TabIndex = 6;
			this.gpbGeneration.TabStop = false;
			this.gpbGeneration.Text = "General";
			// 
			// chkSpecial
			// 
			this.chkSpecial.AutoSize = true;
			this.chkSpecial.Checked = global::password_generator.Properties.Settings.Default.charSpecial;
			this.chkSpecial.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::password_generator.Properties.Settings.Default, "charSpecial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.chkSpecial.Location = new System.Drawing.Point(142, 117);
			this.chkSpecial.Name = "chkSpecial";
			this.chkSpecial.Size = new System.Drawing.Size(127, 17);
			this.chkSpecial.TabIndex = 11;
			this.chkSpecial.Text = "Special (!, @, #, etc.)";
			this.chkSpecial.UseVisualStyleBackColor = true;
			this.chkSpecial.CheckedChanged += new System.EventHandler(this.chkSpecial_CheckedChanged);
			// 
			// numLength
			// 
			this.numLength.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::password_generator.Properties.Settings.Default, "passLength", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.numLength.Location = new System.Drawing.Point(115, 44);
			this.numLength.Maximum = new decimal(new int[] {
            97,
            0,
            0,
            0});
			this.numLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numLength.Name = "numLength";
			this.numLength.Size = new System.Drawing.Size(64, 20);
			this.numLength.TabIndex = 4;
			this.numLength.ThousandsSeparator = true;
			this.numLength.Value = global::password_generator.Properties.Settings.Default.passLength;
			this.numLength.ValueChanged += new System.EventHandler(this.numLength_ValueChanged);
			// 
			// chkRepeat
			// 
			this.chkRepeat.AutoSize = true;
			this.chkRepeat.Checked = global::password_generator.Properties.Settings.Default.charRepeat;
			this.chkRepeat.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::password_generator.Properties.Settings.Default, "charRepeat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.chkRepeat.Location = new System.Drawing.Point(6, 19);
			this.chkRepeat.Name = "chkRepeat";
			this.chkRepeat.Size = new System.Drawing.Size(200, 17);
			this.chkRepeat.TabIndex = 3;
			this.chkRepeat.Text = "Do not use the same character twice";
			this.chkRepeat.UseVisualStyleBackColor = true;
			this.chkRepeat.CheckedChanged += new System.EventHandler(this.chkRepeat_CheckedChanged);
			// 
			// chkBrackets
			// 
			this.chkBrackets.AutoSize = true;
			this.chkBrackets.Checked = global::password_generator.Properties.Settings.Default.charBrackets;
			this.chkBrackets.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::password_generator.Properties.Settings.Default, "charBrackets", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.chkBrackets.Location = new System.Drawing.Point(142, 140);
			this.chkBrackets.Name = "chkBrackets";
			this.chkBrackets.Size = new System.Drawing.Size(127, 17);
			this.chkBrackets.TabIndex = 12;
			this.chkBrackets.Text = "Brackets ([ ], { }, etc.)";
			this.chkBrackets.UseVisualStyleBackColor = true;
			this.chkBrackets.CheckedChanged += new System.EventHandler(this.chkBrackets_CheckedChanged);
			// 
			// chkSpace
			// 
			this.chkSpace.AutoSize = true;
			this.chkSpace.Checked = global::password_generator.Properties.Settings.Default.charSpace;
			this.chkSpace.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::password_generator.Properties.Settings.Default, "charSpace", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.chkSpace.Location = new System.Drawing.Point(142, 94);
			this.chkSpace.Name = "chkSpace";
			this.chkSpace.Size = new System.Drawing.Size(69, 17);
			this.chkSpace.TabIndex = 10;
			this.chkSpace.Text = "Space ( )";
			this.chkSpace.UseVisualStyleBackColor = true;
			this.chkSpace.CheckedChanged += new System.EventHandler(this.chkSpace_CheckedChanged);
			// 
			// chkUnderscore
			// 
			this.chkUnderscore.AutoSize = true;
			this.chkUnderscore.Checked = global::password_generator.Properties.Settings.Default.charUnderscore;
			this.chkUnderscore.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::password_generator.Properties.Settings.Default, "charUnderscore", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.chkUnderscore.Location = new System.Drawing.Point(142, 71);
			this.chkUnderscore.Name = "chkUnderscore";
			this.chkUnderscore.Size = new System.Drawing.Size(96, 17);
			this.chkUnderscore.TabIndex = 9;
			this.chkUnderscore.Text = "Underscore (_)";
			this.chkUnderscore.UseVisualStyleBackColor = true;
			this.chkUnderscore.CheckedChanged += new System.EventHandler(this.chkUnderscore_CheckedChanged);
			// 
			// chkHyphen
			// 
			this.chkHyphen.AutoSize = true;
			this.chkHyphen.Checked = global::password_generator.Properties.Settings.Default.charHyphen;
			this.chkHyphen.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::password_generator.Properties.Settings.Default, "charHyphen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.chkHyphen.Location = new System.Drawing.Point(9, 140);
			this.chkHyphen.Name = "chkHyphen";
			this.chkHyphen.Size = new System.Drawing.Size(75, 17);
			this.chkHyphen.TabIndex = 8;
			this.chkHyphen.Text = "Hyphen (-)";
			this.chkHyphen.UseVisualStyleBackColor = true;
			this.chkHyphen.CheckedChanged += new System.EventHandler(this.chkHyphen_CheckedChanged);
			// 
			// chkNumbers
			// 
			this.chkNumbers.AutoSize = true;
			this.chkNumbers.Checked = global::password_generator.Properties.Settings.Default.charNumbers;
			this.chkNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkNumbers.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::password_generator.Properties.Settings.Default, "charNumbers", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.chkNumbers.Location = new System.Drawing.Point(9, 117);
			this.chkNumbers.Name = "chkNumbers";
			this.chkNumbers.Size = new System.Drawing.Size(92, 17);
			this.chkNumbers.TabIndex = 7;
			this.chkNumbers.Text = "Numbers (0-9)";
			this.chkNumbers.UseVisualStyleBackColor = true;
			this.chkNumbers.CheckedChanged += new System.EventHandler(this.chkNumbers_CheckedChanged);
			// 
			// chkLowercase
			// 
			this.chkLowercase.AutoSize = true;
			this.chkLowercase.Checked = global::password_generator.Properties.Settings.Default.charLowercase;
			this.chkLowercase.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::password_generator.Properties.Settings.Default, "charLowercase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.chkLowercase.Location = new System.Drawing.Point(9, 94);
			this.chkLowercase.Name = "chkLowercase";
			this.chkLowercase.Size = new System.Drawing.Size(101, 17);
			this.chkLowercase.TabIndex = 6;
			this.chkLowercase.Text = "Lowercase (a-z)";
			this.chkLowercase.UseVisualStyleBackColor = true;
			this.chkLowercase.CheckedChanged += new System.EventHandler(this.chkLowercase_CheckedChanged);
			// 
			// chkUppercase
			// 
			this.chkUppercase.AutoSize = true;
			this.chkUppercase.Checked = global::password_generator.Properties.Settings.Default.charUppercase;
			this.chkUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkUppercase.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::password_generator.Properties.Settings.Default, "charUppercase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.chkUppercase.Location = new System.Drawing.Point(9, 71);
			this.chkUppercase.Name = "chkUppercase";
			this.chkUppercase.Size = new System.Drawing.Size(104, 17);
			this.chkUppercase.TabIndex = 5;
			this.chkUppercase.Text = "Uppercase (A-Z)";
			this.chkUppercase.UseVisualStyleBackColor = true;
			this.chkUppercase.CheckedChanged += new System.EventHandler(this.chkUppercase_CheckedChanged);
			// 
			// lblLength
			// 
			this.lblLength.AutoSize = true;
			this.lblLength.Location = new System.Drawing.Point(6, 48);
			this.lblLength.Name = "lblLength";
			this.lblLength.Size = new System.Drawing.Size(103, 13);
			this.lblLength.TabIndex = 8;
			this.lblLength.Text = "Length of password:";
			// 
			// gpbMassGen
			// 
			this.gpbMassGen.Controls.Add(this.numMassGen);
			this.gpbMassGen.Controls.Add(this.lblMassGen);
			this.gpbMassGen.Controls.Add(this.chkMassGen);
			this.gpbMassGen.Location = new System.Drawing.Point(12, 341);
			this.gpbMassGen.Name = "gpbMassGen";
			this.gpbMassGen.Size = new System.Drawing.Size(275, 68);
			this.gpbMassGen.TabIndex = 7;
			this.gpbMassGen.TabStop = false;
			this.gpbMassGen.Text = "Mass Generation";
			// 
			// numMassGen
			// 
			this.numMassGen.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::password_generator.Properties.Settings.Default, "massAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.numMassGen.Enabled = false;
			this.numMassGen.Location = new System.Drawing.Point(112, 42);
			this.numMassGen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numMassGen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numMassGen.Name = "numMassGen";
			this.numMassGen.Size = new System.Drawing.Size(61, 20);
			this.numMassGen.TabIndex = 17;
			this.numMassGen.ThousandsSeparator = true;
			this.numMassGen.Value = global::password_generator.Properties.Settings.Default.massAmount;
			this.numMassGen.ValueChanged += new System.EventHandler(this.numMassGen_ValueChanged);
			// 
			// lblMassGen
			// 
			this.lblMassGen.AutoSize = true;
			this.lblMassGen.Location = new System.Drawing.Point(6, 44);
			this.lblMassGen.Name = "lblMassGen";
			this.lblMassGen.Size = new System.Drawing.Size(100, 13);
			this.lblMassGen.TabIndex = 9;
			this.lblMassGen.Text = "Generation amount:";
			// 
			// chkMassGen
			// 
			this.chkMassGen.AutoSize = true;
			this.chkMassGen.Checked = global::password_generator.Properties.Settings.Default.massGen;
			this.chkMassGen.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::password_generator.Properties.Settings.Default, "massGen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.chkMassGen.Enabled = false;
			this.chkMassGen.Location = new System.Drawing.Point(6, 19);
			this.chkMassGen.Name = "chkMassGen";
			this.chkMassGen.Size = new System.Drawing.Size(139, 17);
			this.chkMassGen.TabIndex = 16;
			this.chkMassGen.Text = "Enable mass generation";
			this.chkMassGen.UseVisualStyleBackColor = true;
			this.chkMassGen.CheckedChanged += new System.EventHandler(this.chkMassGen_CheckedChanged);
			// 
			// gpbSave
			// 
			this.gpbSave.Controls.Add(this.txtSaveLocation);
			this.gpbSave.Controls.Add(this.btnSave);
			this.gpbSave.Controls.Add(this.chkSave);
			this.gpbSave.Location = new System.Drawing.Point(12, 264);
			this.gpbSave.Name = "gpbSave";
			this.gpbSave.Size = new System.Drawing.Size(275, 71);
			this.gpbSave.TabIndex = 8;
			this.gpbSave.TabStop = false;
			this.gpbSave.Text = "Save to Text File";
			// 
			// txtSaveLocation
			// 
			this.txtSaveLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::password_generator.Properties.Settings.Default, "saveLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtSaveLocation.Location = new System.Drawing.Point(74, 44);
			this.txtSaveLocation.Name = "txtSaveLocation";
			this.txtSaveLocation.ReadOnly = true;
			this.txtSaveLocation.Size = new System.Drawing.Size(195, 20);
			this.txtSaveLocation.TabIndex = 15;
			this.txtSaveLocation.Text = global::password_generator.Properties.Settings.Default.saveLocation;
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(6, 42);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(62, 23);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "Browse...";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// chkSave
			// 
			this.chkSave.AutoSize = true;
			this.chkSave.Checked = global::password_generator.Properties.Settings.Default.saveFile;
			this.chkSave.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::password_generator.Properties.Settings.Default, "saveFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.chkSave.Location = new System.Drawing.Point(6, 19);
			this.chkSave.Name = "chkSave";
			this.chkSave.Size = new System.Drawing.Size(203, 17);
			this.chkSave.TabIndex = 13;
			this.chkSave.Text = "Save generated passwords to text file";
			this.chkSave.UseVisualStyleBackColor = true;
			this.chkSave.CheckedChanged += new System.EventHandler(this.chkSave_CheckedChanged);
			// 
			// tmrClearStatus
			// 
			this.tmrClearStatus.Interval = 7500;
			this.tmrClearStatus.Tick += new System.EventHandler(this.tmrClearStatus_Tick);
			// 
			// flgSave
			// 
			this.flgSave.DefaultExt = "txt";
			this.flgSave.FileName = "passwords.txt";
			this.flgSave.Filter = "All files|*.*";
			this.flgSave.SupportMultiDottedExtensions = true;
			this.flgSave.FileOk += new System.ComponentModel.CancelEventHandler(this.flgSave_FileOk);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(299, 434);
			this.Controls.Add(this.gpbSave);
			this.Controls.Add(this.gpbMassGen);
			this.Controls.Add(this.gpbGeneration);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Password Generator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.gpbGeneration.ResumeLayout(false);
			this.gpbGeneration.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
			this.gpbMassGen.ResumeLayout(false);
			this.gpbMassGen.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMassGen)).EndInit();
			this.gpbSave.ResumeLayout(false);
			this.gpbSave.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuHelp;
		private System.Windows.Forms.ToolStripMenuItem menuEdit;
		private System.Windows.Forms.ToolStripMenuItem fileExit;
		private System.Windows.Forms.ToolStripMenuItem editCopy;
		private System.Windows.Forms.ToolStripMenuItem helpAbluescarab;
		private System.Windows.Forms.ToolStripMenuItem helpGithub;
		private System.Windows.Forms.ToolStripSeparator helpSep1;
		private System.Windows.Forms.ToolStripMenuItem helpHelp;
		private System.Windows.Forms.ToolStripMenuItem helpAbout;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.GroupBox gpbGeneration;
		private System.Windows.Forms.Label lblLength;
		private System.Windows.Forms.CheckBox chkUppercase;
		private System.Windows.Forms.CheckBox chkLowercase;
		private System.Windows.Forms.CheckBox chkNumbers;
		private System.Windows.Forms.CheckBox chkUnderscore;
		private System.Windows.Forms.CheckBox chkHyphen;
		private System.Windows.Forms.CheckBox chkSpace;
		private System.Windows.Forms.CheckBox chkBrackets;
		private System.Windows.Forms.CheckBox chkRepeat;
		private System.Windows.Forms.NumericUpDown numLength;
		private System.Windows.Forms.GroupBox gpbMassGen;
		private System.Windows.Forms.GroupBox gpbSave;
		private System.Windows.Forms.CheckBox chkMassGen;
		private System.Windows.Forms.CheckBox chkSave;
		private System.Windows.Forms.Label lblMassGen;
		private System.Windows.Forms.NumericUpDown numMassGen;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtSaveLocation;
		private System.Windows.Forms.ToolStripStatusLabel statusText;
		private System.Windows.Forms.CheckBox chkSpecial;
		private System.Windows.Forms.Timer tmrClearStatus;
		private System.Windows.Forms.SaveFileDialog flgSave;
		private System.Windows.Forms.ToolStripMenuItem helpChangelog;
		private System.Windows.Forms.ToolStripSeparator helpSep2;
	}
}

